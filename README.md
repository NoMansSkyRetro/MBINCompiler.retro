# MBINCompiler.retro

A fork of [monkeyman192's MBINCompiler](https://github.com/monkeyman192/MBINCompiler/tree/rc1)
(`rc1` branch) that targets **legacy** No Man's Sky builds. Enormous thanks to monkeyman192
and the MBINCompiler contributors; this fork just carries their `rc1` work sideways to the
old versions.

Targeted versions:

| Id       | Update                     |
|----------|----------------------------|
| `rc1`    | Release Candidate / launch (PS4 disc) |
| `1.09.1` | The Initial Release        |
| `1.13`   | The Foundation update      |
| `1.24`   | The Path Finder update     |
| `1.38`   | Atlas Rises                |

### What this fork adds

- **Version autodetection + `--nms-version` flag.** Vanilla (uncompiled) MBINs carry no
  MBINCompiler version, so stock MBINCompiler reports "Unknown". This fork identifies the
  build from the MBIN header's timestamp stamp / globals GUID, e.g.

  ```
  MBINCompiler.retro version FILE.GLOBAL.MBIN
  → Retro build: 1.24 (Path Finder)
  ```

  Files that carry no stamp (most non-`*.GLOBAL` MBINs) can't be autodetected; select the
  build explicitly with `--nms-version=<rc1|1.09.1|1.13|1.24|1.38>`.

- **`dumplayout` command.** Emits every struct's authoritative memory layout
  (name / type / offset / size) as JSON, straight from libMBIN's own `OffsetOf`/`SizeOf`:

  ```
  MBINCompiler.retro dumplayout > layout.json
  ```

  This is the retro pipeline's first-class output: per-build struct layouts for tools that
  read the game's structs from memory.

---

# Design and internals

Goal: **one** binary that reads/writes every targeted legacy NMS build, version-selected at
runtime, with no pile of era binaries and no hand-maintained per-field deltas.

## One binary, per-build struct folders over a shared base

libMBIN and MBINCompiler ship together and share a version. The struct definitions changed
enough between builds (naming and layout) that carrying per-field version deltas would be its
own clutter, so each build gets its own namespace folder for the structs that differ, layered
over a **shared base set that is common to every build**. It all compiles into the one libMBIN:

| Build(s) | Struct set | Source | Improvements past the source |
|----------|-----------|--------|------------------------------|
| Shared (all builds) | base, `libMBIN.NMS.*` | the `rc1` branch defs (in truth a mixed RC1/1.09.1-era set), plus the serialization primitives (`NMSString`, `Colour`, `Vector`, `GcSeed`, …) | the deliberate common fallback: every build resolves here for the structs and primitives it does not override |
| RC1 (PS4 disc) | `libMBIN.V1_00.*` | the `rc1` branch defs, improved per struct | started from the RC1 branch definitions and fixed the structs whose disc layout differs, verified against the disc psarcs (and, for the structural cases, the PS4 `eboot` decompile) |
| 1.09.1 (Release) | `libMBIN.V1_09_1.*` | derived per struct over the shared base | ~30 structs derived from file evidence (globals, saves, reality/reward tables, the voxel/planet chain, launch-era GcSolarGenerationGlobals); 762/763 byte-perfect |
| 1.13 (Foundation) | `libMBIN.V1_13.*` | imported `1a6c980e` (last pre-Path-Finder commit), over the shared base | ~60 structs fixed or rebuilt (GcUIGlobals and GcScannerIcons re-derived from the 1.24 defs, mission/reward/cost tables, planet chain, fog byte sentinel); 773/774 byte-perfect |
| 1.24 (Path Finder) | `libMBIN.V1_24.*` | imported `1.24.4` tag (its csproj's file list) | base-infra dedup (the single biggest win: 119 to 173 clean), mission/reward/cost table shapes, 8-aligned requirement lists; 780/781 byte-perfect |
| 1.38 (Atlas Rises) | `libMBIN.V1_38.*` | imported `1.38.0.2` tag | solar-system SystemShips, save mission-progress shapes, cost model, layout-list bool, biome option alignment; 829/830 byte-perfect |

The shared base is genuinely shared: the pre-2017 builds (rc1 / 1.09.1 / 1.13) hold only small
deltas and lean on it heavily, while 1.24 / 1.38 are near-complete sets that still fall back to
it for the many structs (and all the primitives) that never changed. Duplicating those
primitives per build without their `[NMS]` attributes was historically the single biggest bug
class, so they stay in the one shared base on purpose.

Serializer-level fixes benefit every build at once: type-exact nested deserialization,
lossless Ignore-padding, NaN payload preservation, the vanilla anim block order with its
0xFE fill, list-data alignment semantics, and raw-index emission for enums whose name
lists contain duplicates.

The sets coexist because their namespaces differ; they share the one modern serializer
(`libMBIN.NMSTemplate`) via namespace walk-up.

## Routing

- Active build: `NMSVersion.ActiveId`, set from `--nms-version` or autodetection (the MBIN
  header stamp / globals GUID; see `MBINCompiler/Source/RetroVersion.cs`).
- `NMSTemplate.GetTemplateType(name)` resolves in the active build's folder first, then
  falls back to the **shared base set** for everything the folder does not carry: the
  serialization primitives (`MBINHeader`, `NMSString`, …) and every struct that build did not
  need to override. This fallback is the shared base by design, not a per-build accident.
- With no active build, only the shared base set is used, so single-version behaviour is
  unchanged.

## Ground truth

- **RC1 (PS4 disc) is NOT 1.09.1.** Byte-diffing the 15,526 path-shared MBINs between the
  disc psarcs and 1.09.1's PAKs: 10,681 identical, but ~40 root templates changed layout
  (every `*.GLOBAL` single-struct file changed size). The `rc1` branch defs are themselves a
  mix: several structs match 1.09.1's sizes, not the disc's.
- **Template GUIDs are HG-stamped layout hashes** in every V0 MBIN header. PC-to-PC GUID
  equality proves layout equality per root-template tree (1.09.1 vs 1.24: 60 of 114 roots
  identical; 1.13 vs 1.24: 84 of 118). PS4-vs-PC GUIDs differ even for byte-identical
  files, so never compare GUIDs across platforms.
- Census + tooling live in the retro pipeline's `tools/mbin/`: `guid_census.py` (per-template
  GUIDs per build), `body_diff.py` (byte-level build compare), `verify_roundtrip.py` (the
  acceptance test: extract per-template samples, decompile, recompile, byte-compare).

## How the sets were derived

The struct sets were brought to byte-perfect by an autonomous, evidence-driven loop against
the shipped game files. No struct change was ever accepted on theory alone; the round-trip
harness was the referee for every edit.

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

## Status

Round-trip verification, byte-perfect past the header, at forty samples per
root template: **all four PC builds are complete - 1.09.1 762/763,
1.13 773/774, 1.24 780/781, 1.38 829/830 (3144 of 3148 sampled files;
the single failure in each build is METADATA/INPUTTEST.MBIN, a pre-2500
debug capture with an older header, unsupported by design).**
The base `rc1` set lives in `libMBIN/Source/Versions/RC1`; disc-specific fixes land in the
`V1_00` folder (`libMBIN.V1_00.Structs`, routed for `--nms-version=rc1`). **rc1 is now 159/171
clean** (up from the original 114) across the full corpus, not sampled.

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
disc `eboot.bin` was extracted from the retail pkg and decompiled in Ghidra. This is
the true RC1-era source (the RC1 branch predates it). The decompile carries the game's
template reflection registry (548 types) and a per-struct field walker that spells
out every field's name, offset and type. Weather was the first decompile-driven
win: disc `GcWeatherProperties` has two 8-float Sky/MaxSky horizon blocks the PC
era lacks, standard fog, and a 3x6 hazard-triplet tail (Min/Average/Max) with no
Override bools - byte-perfect on the first build from the walker output.

### Open

- METADATA/INPUTTEST.MBIN: pre-2500 debug input capture, older header layout -
  intentionally unsupported in every build.
- rc1 (V1_00): 159/171 clean; 11 files remain (plus INPUTTEST). Each is a large or
  custom-serializer reconstruction now unblocked by the PS4 decompile but not yet
  done: the saves (`GcPlayerStateData`, the whole player-save struct) x2, DefaultReality
  (`GcRealityManagerData`), `GcRobotGlobals` (hand-loaded, not in the reflection registry -
  its head needs byte-derivation; its `GcDroneData` sub-struct is registered), the anims x2
  and geometry x2 (custom serializers whose disc vertex/frame formats differ).
- Coverage is per-template sampled for the PC builds (verified clean at 40 files per
  root template per build); a full-corpus sweep may still surface rare variants. rc1
  is verified across its full corpus.

---

# MBINCompiler

_The sections below are adapted from the upstream MBINCompiler README. Original project by
monkeyman192 and contributors._

## DOWNLOAD ![GitHub release (latest by date including pre-releases)](https://img.shields.io/github/v/release/NoMansSkyRetro/MBINCompiler.retro?include_prereleases&label=release%20%28experimental%29) ![GitHub release (latest by date)](https://img.shields.io/github/v/release/NoMansSkyRetro/MBINCompiler.retro?label=release%20%28public%29)

_**For Modders:** You only need to download MBINCompiler.retro.exe_  
_**For Developers:** You can download a precompiled DLL or get the libMBIN source and integrate with your own NMS modding tools._

[DOWNLOAD LATEST RELEASE](../../releases)  

** PLEASE NOTE:** MBINCompiler.retro requires .NET 5 or newer to run. If you do not have this you can download it [here](https://dotnet.microsoft.com/download/dotnet/5.0/runtime).
Some applications which depend on libMBIN however require a .NET 4 version of the library, and this is also provided with the downloads in each release.

Each release contains the following files:

- libMBIN.dll: A library which can be used by other applications to directly interface with the serialised data contained within .MBIN files.
- MBINCompiler.retro.exe: The main application used to convert .MBIN files to .EXML files and back again. Drag a file or folder of files onto the exe and away you go!
- mapping.json: A .json file which contains a mapping to de-obfuscate the save file .json used by the game.
- report.json: A report generated which indicates which of the test files passed or failed the automated tests. This is just for reporting purposes.

## DESCRIPTION
A modding tool for the game: [No Man's Sky](https://www.nomanssky.com/) that converts the game's MBIN data files (binary) into human-readable EXML files (text) that can be edited with any text editor and then converted back again for use in a modded game.

Various MBIN files have different data formats. MBINCompiler.retro maps all of these formats to be able to understand how to read the binary data from file, convert it to EXML and vice versa.

Because each version of the game ships different MBIN formats, it is **very important to note** that MBIN files
compiled with one version may not be decompiled successfully with a different version if that particular MBIN format has changed. Select the matching build with `--nms-version` (or rely on autodetection for stamped files) so the correct struct set is used.

If you need to find out what version an MBIN file was compiled with, there is a `version` command line option that will tell you.

If you are a developer, you can access all the functionality that MBINCompiler.retro uses for its own command line interface by downloading or compiling the libMBIN.dll and linking it in your own application. The API makes things like MBIN/EXML de/serialization accessible as well as all the MBIN structure definitions. The structures are C# classes that map the mbin data as public fields, so they can be used in code like any other class.

## USAGE INSTRUCTIONS

Before you decompile any MBIN files you must know how to unpack the game assets.  
To use your recompiled MBIN files, you must know how to enable mods, install them and how to repack assets into your own mods.

To create a modified MBIN:  
1) Drag the MBIN file onto MBINCompiler.retro.exe to create an EXML file in the same directory as the MBIN file.  
_The exe does not need to be in the same directory._
2) Open the EXML file with a text, xml or code editor. Make your changes and save.  
_[Notepad++](https://notepad-plus-plus.org/) is good._
3) Drag the EXML file onto MBINCompiler.retro.exe to recompile back to an MBIN file.

Repack your file(s) into a new mod and add to your game.

### COMMAND LINE ARGUMENTS

MBINCompiler.retro has a number of arguments that can be called from the command line which may be useful:

`MBINCompiler.retro.exe version [<Option> ...] [<File>]` - prints the version of the binary (if no arguments provided), or the version used to generate the .MBIN or .EXML file if a filepath is provided.

`MBINCompiler.retro.exe register` - Registers the directory that the exe resides in to your system path. This allows you to call `MBINCompiler.retro` from anywhere on your computer.

`MBINCompiler.retro.exe --nms-version=<rc1|1.09.1|1.13|1.24|1.38> <path> [<path> ...]` - Converts the input path(s) from their input format (either .MBIN or .EXML) to the output format (.MBIN -> .EXML, .EXML -> .MBIN). This is the default mode.

`MBINCompiler.retro.exe dumplayout [--nms-version=<Version>] > layout.json` - Dumps every struct's memory layout as JSON.

To see all the details call `MBINCompiler.retro.exe help`.

## SUBMITTING BUG REPORTS

If you run into errors, in most cases the errors are because:

a) You made an error when editing the EXML file and it fails to recompile.
Check if it's a problem with your file or with the tool by decompiling the vanilla MBIN to EXML and then recompiling it back to MBIN to verify that it works. If the vanilla file recompiles fine, then it's most likely a problem with your file changes.

b) You are using the wrong build's struct set for the file.
Make sure you selected the correct `--nms-version` for the file you are trying to process.

c) The tool has yet to be updated for that data structure.
Check if there are any [Open Issues](../../issues) for the file you are having problems with.

If none of the above apply, open a [New issue](../../issues/new). Detail as much as you can to reproduce it, and include: relevant error messages, the file's name and path relative to the GAMEDATA folder, the MBINCompiler.retro version, and the NMS version of the MBIN file.

## Building

While the library targets multiple frameworks, building MBINCompiler.retro and libMBIN locally is done via `dotnet publish` with the framework specified by the `-f` argument, e.g.

```sh
dotnet publish -c Release -f net6.0-windows -r win-x64 -o Build/Release/net6/ /nowarn:cs0618
```

## CREDITS

This is a fork of [monkeyman192's MBINCompiler](https://github.com/monkeyman192/MBINCompiler). Original project thanks to Emoose: https://github.com/emoose/MBINCompiler
