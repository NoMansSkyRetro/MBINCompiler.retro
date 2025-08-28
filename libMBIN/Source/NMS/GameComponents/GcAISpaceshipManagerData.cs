using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC4F3FF1D72FA3463, NameHash = 0x3FFAD7C8)]
    public class GcAISpaceshipManagerData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x5, EnumType = typeof(GcRealityCommonFactions.AIFactionEnum))]
        /* 0x00 */ public GcAISpaceshipModelDataArray[] SystemSpaceships;
        [NMS(Index = 1)]
        /* 0x50 */ public GcAISpaceshipModelData SentinelCrashSiteShip;
    }
}
