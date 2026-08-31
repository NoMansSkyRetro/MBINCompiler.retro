# MBINCompiler.retro design

Goal: **one** libMBIN that reads/writes every targeted legacy build (RC1 / 1.09.1, 1.13,
1.24, 1.38), version-selected at runtime, not a pile of era libMBINs loaded side by side.

## Why one libMBIN, not several

libMBIN ships with MBINCompiler and shares its version; "the RC1 libMBIN" just means libMBIN
built from the `rc1` branch (our base). Each era's definitions live in a different place and
toolchain:

| Era | Source | Toolchain |
|-----|--------|-----------|
| RC1 / launch (1.09.1) | `rc1` branch (base) | net6, modern, has `OffsetOf` |
| 1.24 | `1.24.4` tag | net452, 2017, no `OffsetOf` |
| 1.38 | `1.38.0.2` tag | net452, 2017, no `OffsetOf` |
| 1.13 | none exists | — |

Loading the 2017 net452 assemblies into a net6 host is the "hacked together" path we reject.
Instead we keep the single modern `rc1` libMBIN and make its struct definitions
version-aware.

## Mechanism

1. **Active version.** `RetroVersion.Selected` (from `--nms-version`) or autodetection from
   the MBIN header stamp / globals GUID. Already wired.
2. **Version-tagged fields.** A field that differs across builds carries a version range,
   e.g. `[NMSVersion(First="1.24", Last="1.38")]`, plus a per-version type/size when those
   changed. The (de)serialize field walk includes only fields valid for the active version.
   Stable fields (~half of them) carry no tag and apply to every build. Struct size and
   alignment fall out of the filtered field set, the same way libMBIN already derives them.
3. **Lookup by `TemplateName`, not GUID.** `cGcEnvironmentGlobals` is stable across builds;
   its GUID is not. GUIDs become a per-build table used only for detection and for writing a
   correct header on compile.

## Where the per-version data comes from

`layouts/layout_<build>.json` are authoritative field/offset/size dumps from each build's own
serializer (`layouts/README.md`). Diffing them field by field yields exactly the version
tags; a generator applies them to the divergent structs and leaves the stable ones alone.
The 2017 tags also supply better field *names* for 1.24/1.38 (where `rc1` still has
`Unknown<offset>`), reconciled in during generation.

This is the same layout data NMS.retro.py's `gen_structs.py` consumes for its Python
`versioned_struct` classes; here it is retargeted to C# attributes on one libMBIN.

## Phases

- **P1 (done): data + plumbing.** Per-build layouts + dumplayout patches vendored; version
  selection + `dumplayout` + detection already in the CLI.
- **P2: the mechanism.** `NMSVersion` attribute + version-filtered field walk in
  `NMSTemplate`, and `TemplateName`+version lookup. Proven on `GcEnvironmentGlobals` so one
  binary round-trips both a 1.24 and a 1.38 MBIN.
- **P3: the bulk.** Generate/port per-version deltas across all divergent structs from the
  layout diffs + tag names.
- **P4: 1.13.** No tag exists; bisect libMBIN history for a GUID-matching commit or derive
  from exe RE.

## Open decisions

- Attribute shape: extend `NMSAttribute` (add `Versions=`) vs a separate `[NMSVersion]`.
- Whether per-version *type* changes need a full second field or an attribute-carried type.
- 1.13 sourcing (P4).
