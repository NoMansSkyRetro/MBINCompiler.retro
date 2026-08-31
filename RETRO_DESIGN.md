# MBINCompiler.retro design

Goal: **one** binary that reads/writes every targeted legacy NMS build, version-selected at
runtime, with no pile of era binaries and no hand-maintained per-field deltas.

## One binary, one complete struct folder per build

libMBIN and MBINCompiler ship together and share a version; "the RC1 libMBIN" just means
libMBIN built from the `rc1` branch (our base). The struct definitions changed enough between
builds (naming and layout) that carrying per-field version deltas would be its own clutter, so
instead each build gets a **complete, self-contained struct set in its own namespace folder**,
all compiled into the one libMBIN:

| Build(s) | Struct set | Source |
|----------|-----------|--------|
| rc1 / fallback | base, `libMBIN.NMS.*` | the `rc1` branch defs (in truth a mixed RC1/1.09.1-era set) |
| 1.09.1 (Release) | `libMBIN.V1_09_1.*` | derived per struct; falls back to base |
| 1.13 (Foundation) | `libMBIN.V1_13.*` | imported `1a6c980e` (last pre-Path-Finder commit); falls back to base |
| 1.24 (Path Finder) | `libMBIN.V1_24.*` | imported `1.24.4` tag (its csproj's file list) |
| 1.38 (Atlas Rises) | `libMBIN.V1_38.*` | imported `1.38.0.2` tag |

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

## Status (2026-08-31)

Round-trip verification (per-template samples; byte-perfect past the header):
rc1 114/171 (base set frozen by request), 1.09.1 169/184, 1.13 171/191,
1.24 186/195, 1.38 197/208. The RC1 set lives frozen in
`libMBIN/Source/Versions/RC1` (namespace unchanged, still the per-template fallback).

## Open (the remaining tail, in rough effort order)

- 1.13-era head-region reworks: GcUIGlobals, GcGameplayGlobals (1.13 delta),
  GcEnvironmentGlobals (+56), GcGraphicsGlobals (+192), GcScannerIcons - each adds
  colour/texture blocks the Foundation update introduced.
- 1.09.1 deep structs: GcDefaultSaveData, GcRealityManagerData (DEFAULTREALITY),
  GcPlanetData, GcSolarGenerationGlobals, TkVoxelGeneratorSettingsArray, GcSkyGlobals.
- GcCostTable: the cost subtypes (GcCostSubstance at least) are far larger in the era
  files than any def; needs entry-level modeling (fails in all four PC builds).
- GcMissionTable small per-era drifts; TkNGuiLayoutList 1.38 (6 bytes).
- TkAnimMetadata custom serializer writes two float sections in swapped order
  (same-size byte-diffs on every anim).
- METADATA/INPUTTEST.MBIN has an invalid header in every build ("Not a valid MBIN") -
  possibly not a real MBIN; ignore or special-case.
