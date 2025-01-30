namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA72CDE1B142C3B05, NameHash = 0xB7F9543C)]
    public class GcMissionConditionCookingSearch : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Product;
        [NMS(Index = 1)]
        /* 0x10 */ public int Amount;
        [NMS(Index = 3)]
        /* 0x14 */ public bool ReturnTrueIfCanMakeProduct;
        [NMS(Index = 2)]
        /* 0x15 */ public bool SetIcon;
    }
}
