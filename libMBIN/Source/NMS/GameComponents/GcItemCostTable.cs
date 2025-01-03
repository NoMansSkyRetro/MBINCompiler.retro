using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCC5ADB59283ADE66, NameHash = 0x363A73C6)]
    public class GcItemCostTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public HashMap<GcItemCostData> Items;
    }
}
