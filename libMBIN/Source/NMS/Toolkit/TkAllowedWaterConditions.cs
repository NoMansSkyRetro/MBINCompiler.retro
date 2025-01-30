using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xAC8C8B34F602315A, NameHash = 0x19CB938A)]
    public class TkAllowedWaterConditions : NMSTemplate
    {
        [NMS(Index = 0, Size = 0xE, EnumType = typeof(TkWaterCondition.WaterConditionEnum))]
        /* 0x0 */ public float[] ConditionWeights;
    }
}
