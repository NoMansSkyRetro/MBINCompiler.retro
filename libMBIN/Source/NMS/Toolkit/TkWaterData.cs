using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xB34CC91CEFC07C58, NameHash = 0xD4D0EA68)]
    public class TkWaterData : NMSTemplate
    {
        [NMS(Index = 1, Size = 0xE, EnumType = typeof(TkWaterCondition.WaterConditionEnum))]
        /* 0x000 */ public TkWaterConditionData[] WaterConditions;
        [NMS(Index = 3, Size = 0x11, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x310 */ public TkBiomeSpecificWaterConditions[] BiomeSpecificUsage;
        [NMS(Index = 2, Size = 0x2, EnumType = typeof(TkWaterRequirement.WaterRequirementEnum))]
        /* 0xA80 */ public TkAllowedWaterConditions[] WaterConditionUsage;
        [NMS(Index = 0)]
        /* 0xAF0 */ public float MinimumWavelength;
    }
}
