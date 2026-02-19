using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x827E083193C7E65E, NameHash = 0xF989045F)]
    public class GcDefaultSaveData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00000 */ public GcPlayerStateData State;
        [NMS(Index = 1)]
        /* 0x7FB80 */ public GcPlayerSpawnStateData Spawn;
    }
}
