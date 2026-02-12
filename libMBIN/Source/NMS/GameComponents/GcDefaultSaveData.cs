using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2C1300D6E6ED4ACD, NameHash = 0xF989045F)]
    public class GcDefaultSaveData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00000 */ public GcPlayerStateData State;
        [NMS(Index = 1)]
        /* 0x7FB80 */ public GcPlayerSpawnStateData Spawn;
    }
}
