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
| rc1 / 1.09.1 / 1.13 | base, `libMBIN.NMS.*` | the `rc1` branch defs |
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
- `NMSTemplate.GetTemplateType(name)` resolves in the active build's folder first
  (`libMBIN.V1_24` / `libMBIN.V1_38`), then falls back to the base set for shared infra
  (`MBINHeader`, `NMSString`, …) and for builds with no dedicated folder (rc1/1.09.1/1.13).
- With no active build, only the base set is used, so single-version behaviour is unchanged.

## Status

- rc1 / 1.24 / 1.38 folders build and decompile in one binary; a real 1.24 and a real 1.38
  globals file each decode via their own defs. Autodetection and `--nms-version` both route.
- `dumplayout` dumps the active build's folder (rc1 525 / 1.24 703 / 1.38 894 templates) and is
  still the per-build layout export for NMS.retro.py's `gen_structs.py` (`layouts/`).

## Open

- **1.13** has no tag: give it its own `libMBIN.V1_13.*` folder once a def set exists (bisect
  libMBIN history for GUID-matching structs, or derive from exe RE), else it uses the base set.
- **Recompile (EXML -> MBIN)** fidelity is bounded by the incomplete `rc1` base and the
  era tags for some complex structs (e.g. `GcEnvironmentGlobals`); decompile is the solid path.
- `--nms-version=1.09.1` currently resolves to the base set (same as rc1); a dedicated 1.09.1
  folder is only needed if its layout is shown to differ from rc1.
