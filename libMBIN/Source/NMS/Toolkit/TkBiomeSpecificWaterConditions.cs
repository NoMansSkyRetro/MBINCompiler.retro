using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x3B8A912F5D97CF0C, NameHash = 0x69E02AAE)]
    public class TkBiomeSpecificWaterConditions : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x2, EnumType = typeof(TkWaterRequirement.WaterRequirementEnum))]
        /* 0x0 */ public TkAllowedWaterConditions[] WaterConditionUsage;
    }
}
