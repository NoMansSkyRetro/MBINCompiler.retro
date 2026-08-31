# MBINCompiler.retro design

Goal: **one** binary that reads/writes every targeted legacy NMS build, version-selected at
runtime, with no pile of era binaries and no hand-maintained per-field deltas.

## One binary, one complete struct folder per build

libMBIN and MBINCompiler ship together and share a version; "the RC1 libMBIN" just means
libMBIN built from the `rc1` branch (our base). The struct definitions changed enough between
builds (naming and layout) that carrying per-field version deltas would be its own clutter, so
instead each build gets a **complete, self-contained struct set in its own namespace folder**,
all compiled into the one libMBIN:

| Build(s) | Struct set | Source | Improvements past the source |
|----------|-----------|--------|------------------------------|
| rc1 / fallback | base, `libMBIN.NMS.*` | the `rc1` branch defs (in truth a mixed RC1/1.09.1-era set) | kept frozen during the PC-build work; RC1-specific fixes now land in `V1_00` |
| RC1 (PS4 disc) | `libMBIN.V1_00.*` | the `rc1` branch defs, improved per struct | started from the RC1 branch definitions and fixed the structs whose disc layout differs, verified against the disc psarcs (and, for the structural cases, the PS4 `eboot` decompile) |
| 1.09.1 (Release) | `libMBIN.V1_09_1.*` | derived per struct; falls back to base | ~30 structs derived from file evidence (globals, saves, reality/reward tables, the voxel/planet chain, launch-era GcSolarGenerationGlobals); 762/763 byte-perfect |
| 1.13 (Foundation) | `libMBIN.V1_13.*` | imported `1a6c980e` (last pre-Path-Finder commit); falls back to base | ~60 structs fixed or rebuilt (GcUIGlobals and GcScannerIcons re-derived from the 1.24 defs, mission/reward/cost tables, planet chain, fog byte sentinel); 773/774 byte-perfect |
| 1.24 (Path Finder) | `libMBIN.V1_24.*` | imported `1.24.4` tag (its csproj's file list) | base-infra dedup (the single biggest win: 119 to 173 clean), mission/reward/cost table shapes, 8-aligned requirement lists; 780/781 byte-perfect |
| 1.38 (Atlas Rises) | `libMBIN.V1_38.*` | imported `1.38.0.2` tag | solar-system SystemShips, save mission-progress shapes, cost model, layout-list bool, biome option alignment; 829/830 byte-perfect |

Serializer-level fixes benefit every build at once: type-exact nested deserialization,
lossless Ignore-padding, NaN payload preservation, the vanilla anim block order with its
0xFE fill, list-data alignment semantics, and raw-index emission for enums whose name
lists contain duplicates.

The sets coexist because their namespaces differ; they share the one modern serializer
(`libMBIN.NMSTemplate`) via namespace walk-up. Geometry's `TkGeometryData` is dropped from the
imported sets (out of scope; its 2017 `CustomDeserialize` signature predates the base's, and
the base keeps its own).

Duplication between 1.24 and 1.38 (534 of ~700 shared structs are byte-identical) is just
cheap files. The thing we avoid is bespoke deltas.

## Routing

- Active build: `NMSVersion.ActiveId`, set from `--nms-version` or autodetection (the MBIN
  header stamp / globals GUID; see `MBINCompiler/Source/RetroVersion.cs`).
- `NMSTemplate.GetTemplateType(name)` resolves in the active build's folder first, then
  falls back to the base set for shared infra (`MBINHeader`, `NMSString`, …), for builds
  with no dedicated folder (rc1), and for templates a partial folder doesn't carry yet.
- With no active build, only the base set is used, so single-version behaviour is unchanged.

## Ground truth (proven 2026-08-30)

- **RC1 (PS4 disc) is NOT 1.09.1.** Byte-diffing the 15,526 path-shared MBINs between the
  disc psarcs (`E:\NMS_PS4\nms-arc`) and 1.09.1's PAKs: 10,681 identical, but ~40 root
  templates changed layout (every `*.GLOBAL` single-struct file changed size). The `rc1`
  branch defs are themselves a mix: several structs match 1.09.1's sizes, not the disc's.
- **Template GUIDs are HG-stamped layout hashes** in every V0 MBIN header. PC-to-PC GUID
  equality proves layout equality per root-template tree (1.09.1 vs 1.24: 60 of 114 roots
  identical; 1.13 vs 1.24: 84 of 118). PS4-vs-PC GUIDs differ even for byte-identical
  files, so never compare GUIDs across platforms.
- Census + tooling live in NMS.retro.py `tools/mbin/`: `guid_census.py` (per-template GUIDs
  per build), `body_diff.py` (byte-level build compare), `verify_roundtrip.py` (the
  acceptance test: extract per-template samples, decompile, recompile, byte-compare).

## How the sets were derived (the Claude workflow)

The struct sets were brought to byte-perfect by Claude (Anthropic's coding agent) running
an autonomous evidence-driven loop against the shipped game files. No struct change was
ever accepted on theory alone; the round-trip harness was the referee for every edit.

The loop, per failing file:

1. **Verify** - `verify_roundtrip.py <build>` extracts N samples per root template from
   the real PAKs/psarcs, decompiles each to EXML, recompiles, and byte-compares past the
   0x60 header. Its failing list picks the next target.
2. **Localize** - word-level `difflib` over original-vs-round-trip payloads (or
   `globals_diff.py` original-vs-original across two builds) turns a failure into a
   handful of INSERT/DELETE/REPLACE runs with exact offsets.
3. **Identify** - for generic (polymorphic) lists, the `{offset, cGc...name}` entry
   table in the file itself maps every element to its type, start offset, and extent;
   for flat globals, `dumplayout` gives the compiled field-to-offset map to overlay on
   the diff.
4. **Decode** - hexdump the disputed region and read it semantically: resolutions,
   FoV floats, path strings, item ids, RGBA rows, seeds. Values that decode as
   plausible game data confirm a layout; garbage refutes it.
5. **Fix in the right place** - the era def in that build's folder (never the shared
   base), or the serializer when the behaviour is era-universal.
6. **Re-test** - single file first, then the full per-build matrix, then all five
   builds whenever a serializer or shared type changed. Commit only on a clean matrix.

Recurring bug classes this loop caught: fields hidden inside Ignore-padding (data
zeroed on round-trip), unaligned `byte[]` padding standing in for aligned fields,
era-inserted fields the imports missed, structs whose element data is 8-aligned in the
engine's allocator versus packed neighbours (settled by measuring `{start mod 8,
extent-to-next}` across every instance in a file rather than guessing), bools reading
sentinel bytes (0x8F, 0xFEFEFEFE), duplicated names in enum lists making the
name-to-index mapping lossy, and custom-serializer block ordering in the anim files.

Wrong hypotheses were cheap because the harness rejected them within a minute: a
blanket 8-alignment of list data looked right for two tables and was reverted when the
matrix showed three other builds regressing. Where a whole struct had no usable
ancestor (launch-era `GcSolarGenerationGlobals`), the layout was reconstructed
field-by-field from a value-anchored side-by-side decode of the two builds' payloads.

## Status (2026-08-31, final)

Round-trip verification, byte-perfect past the header, at FORTY samples per
root template: **all four PC builds are complete - 1.09.1 762/763,
1.13 773/774, 1.24 780/781, 1.38 829/830 (3144 of 3148 sampled files;
the single failure in each build is METADATA/INPUTTEST.MBIN, a pre-2500
debug capture with an older header, unsupported by design).**
The base `rc1` set lives untouched in `libMBIN/Source/Versions/RC1` (still the
per-template fallback); disc-specific fixes land in the new `V1_00` folder
(`libMBIN.V1_00.Structs`, routed for `--nms-version=rc1`). **rc1 is now 159/171
clean** (up from the frozen 114) across the full corpus, not sampled.

### RC1 (V1_00): from file bytes, then from the PS4 binary

The disc is a genuinely older era - smaller globals, 27 palettes vs 38, 7 biomes
vs 9, 5 factions vs 6, fewer strings and tails everywhere. The first pass derived
V1_00 defs from file bytes alone (unique-dword shift maps + value-anchored decode
against the byte-perfect 1.09.1 counterparts): terrain/audio/solar/environment/UI
globals, the palette/biome/building/reward/product/selectable tables, the full
planet chain (hazard 3x6, an extra day-colour weather block, 0x320 building spawn,
0x378 creature role), procedural textures, and the previously-parked GcSkyGlobals
(disc fog `IsRaining` is a float, plus two extra tail colour rows).

For the structural items that file-byte guessing could not disambiguate, the PS4
disc `eboot.bin` was extracted from the retail pkg and decompiled in Ghidra (see
`E:\NMSLegacy_Decomp\PS4_EXTRACTION_README.md` and the `ps4_extract_eboot.ps1` /
`ps4_self_to_elf.py` / `build_ps4_ghidra.py` scripts). This is the true RC1-era
source (the MBINCompiler RC1 branch predates it). The decompile carries the game's
template reflection registry (548 types) and a per-struct field walker that spells
out every field's name, offset and type. Weather was the first decompile-driven
win: disc `GcWeatherProperties` has two 8-float Sky/MaxSky horizon blocks the PC
era lacks, standard fog, and a 3x6 hazard-triplet tail (Min/Average/Max) with no
Override bools - byte-perfect on the first build from the walker output.

Landed since the first pass: planets/voxel chains (all builds), solar systems
(era SystemShips is a flat preload-cache list), mission tables (StartScanEvent
0xA0 8-aligned, GetToScanEvent 0x118, BasePartNear 0x18, FreighterBattle packed
0xC), GcUIGlobals-1.13 (derived from the 1.24 def; 17 model views, no Exocraft),
reward tables in 1.09.1/1.13/1.24 (product/recipe/tech-recipe shapes, empty
StartPurchase, 8-aligned Specific*/Substance data), 1.38 saves (mission
participant 0x20), anims on every build (vanilla writes Rot/Scale/Trans block
order, 0xFE alignment fill, CanCompress sentinel), LAYOUTLIST (trailing bool),
and the cost tables in all three eras (measured per-type alignment/size model;
GcCostBuildingParts is a 0x20 description plus a list of 0x18 part counts).

## Open

- METADATA/INPUTTEST.MBIN: pre-2500 debug input capture, older header layout -
  intentionally unsupported in every build.
- rc1 (V1_00): 159/171 clean; 11 files remain (plus INPUTTEST). Each is a large or
  custom-serializer reconstruction now unblocked by the PS4 decompile but not yet
  done: the saves (`GcPlayerStateData`, the whole player-save struct) x2, DefaultReality
  (`GcRealityManagerData`), `GcRobotGlobals` (hand-loaded, not in the reflection registry -
  its head needs byte-derivation; its `GcDroneData` sub-struct is registered), the anims x2
  and geometry x2 (custom serializers whose disc vertex/frame formats differ). The field
  walkers for the registered ones are found via `FUN_00d80dc0(name, ctor, namecheck, helper)`
  then the function immediately after the namecheck.
- Coverage is per-template sampled for the PC builds (verified clean at 40 files per
  root template per build); a full-corpus sweep may still surface rare variants. rc1
  is verified across its full corpus.
