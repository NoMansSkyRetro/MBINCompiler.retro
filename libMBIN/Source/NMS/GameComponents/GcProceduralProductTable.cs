using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB8E02353C37BD477, NameHash = 0xB792767A)]
    public class GcProceduralProductTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x1C, EnumType = typeof(GcProceduralProductCategory.ProceduralProductCategoryEnum))]
        /* 0x0 */ public GcProceduralProductData[] Table;
    }
}
