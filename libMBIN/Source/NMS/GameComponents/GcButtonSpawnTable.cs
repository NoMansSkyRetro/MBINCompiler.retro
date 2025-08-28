using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x56662DCE50D5F31B, NameHash = 0x421C6C55)]
    public class GcButtonSpawnTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcButtonSpawn> ButtonSpawns;
    }
}
