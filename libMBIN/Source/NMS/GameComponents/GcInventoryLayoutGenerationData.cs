using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8DCB798E872B6AB9, NameHash = 0x5EB6EE4B)]
    public class GcInventoryLayoutGenerationData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x2B, EnumType = typeof(GcInventoryLayoutSizeType.SizeTypeEnum))]
        /* 0x0 */ public GcInventoryLayoutGenerationDataEntry[] GenerationDataPerSizeType;
    }
}
