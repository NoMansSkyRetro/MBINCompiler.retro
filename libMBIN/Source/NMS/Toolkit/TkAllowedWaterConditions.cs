using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xADF41A3BB221F706, NameHash = 0x19CB938A)]
    public class TkAllowedWaterConditions : NMSTemplate
    {
        [NMS(Index = 0, Size = 0xF, EnumType = typeof(TkWaterCondition.WaterConditionEnum))]
        /* 0x0 */ public float[] ConditionWeights;
    }
}
