using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA13DCB37FCC1DE54, NameHash = 0x10947519)]
    public class GcGameTableSpawnData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A Id;
        [NMS(Index = 2)]
        /* 0x20 */ public List<GcGameTableNPCSpawnData> NPCSpawns;
        [NMS(Index = 1)]
        /* 0x30 */ public GcFilename SceneFilename;
    }
}
