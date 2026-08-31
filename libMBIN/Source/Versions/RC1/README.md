# RC1 base set — frozen

The rc1 branch's struct definitions, kept in namespace `libMBIN.NMS.*` (only the folder
moved; the namespace is unchanged because these types are also shared infrastructure).

Two roles:

1. The definitions used when the active build is `rc1` (PS4 disc psarcs) or none.
2. The per-template **fallback** for the partial version folders (`V1_09_1`, `V1_13`):
   any template those folders don't carry resolves here.

**Do not edit these files to improve another build's compatibility.** Add or fix the
struct in that build's own `V1_xx` folder instead; it shadows this set automatically.
Known caveat: this set is a mix of RC1-disc and 1.09.1-era layouts (see
RETRO_DESIGN.md); it is preserved as-is by request.
