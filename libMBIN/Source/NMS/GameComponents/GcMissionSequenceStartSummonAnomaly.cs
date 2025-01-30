using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD092DDF0F6877C0A, NameHash = 0x99FB3436)]
    public class GcMissionSequenceStartSummonAnomaly : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public GcGalaxyStarAnomaly Anomaly;
        [NMS(Index = 1)]
        /* 0x14 */ public float SummonInFrontDistance;
    }
}
