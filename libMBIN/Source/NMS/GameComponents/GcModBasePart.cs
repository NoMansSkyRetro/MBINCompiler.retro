using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE73F919B68A05A84, NameHash = 0xEE9DB27A)]
    public class GcModBasePart : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x000 */ public GcProductData ProductData;
        [NMS(Index = 2)]
        /* 0x2E0 */ public GcBaseBuildingEntry PartData;
        [NMS(Index = 0)]
        /* 0x4B0 */ public NMSString0x40 ID;
    }
}
