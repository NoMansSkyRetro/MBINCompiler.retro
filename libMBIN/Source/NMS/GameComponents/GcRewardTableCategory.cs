using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF32AEDA18DDE552A, NameHash = 0x29A7763F)]
    public class GcRewardTableCategory : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x3, EnumType = typeof(GcSizeIndicator.SizeIndicatorEnum))]
        /* 0x0 */ public GcRewardTableItemList[] Sizes;
    }
}
