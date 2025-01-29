using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF487AE5508684FD6, NameHash = 0x421C6C55)]
    public class GcButtonSpawnTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcButtonSpawn> ButtonSpawns;
    }
}
