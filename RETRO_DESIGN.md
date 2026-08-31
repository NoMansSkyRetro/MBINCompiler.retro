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

## Status (2026-08-31, final)

Round-trip verification, byte-perfect past the header, at FORTY samples per
root template: **all four PC builds are complete - 1.09.1 762/763,
1.13 773/774, 1.24 780/781, 1.38 829/830 (3144 of 3148 sampled files;
the single failure in each build is METADATA/INPUTTEST.MBIN, a pre-2500
debug capture with an older header, unsupported by design).**
rc1 stays at 114/171 (base set frozen by request).
The RC1 set lives frozen in `libMBIN/Source/Versions/RC1` (namespace unchanged,
still the per-template fallback).

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
- rc1 stays frozen (44 dec-fail / 12 byte-diff untouched by request).
- Coverage is per-template sampled (verified clean at 40 files per root
  template per build); a full-corpus sweep may still surface rare variants.
