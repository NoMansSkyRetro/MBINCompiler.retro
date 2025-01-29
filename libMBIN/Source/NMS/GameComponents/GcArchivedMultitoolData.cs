using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x72FACD8F406B9A05, NameHash = 0x5401D7B)]
    public class GcArchivedMultitoolData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x000 */ public GcMultitoolData MultitoolData;
        [NMS(Index = 2)]
        /* 0x280 */ public GcInventoryClass ArchivedInventoryClass;
        [NMS(Index = 3)]
        /* 0x284 */ public GcWeaponClasses WeaponClass;
        [NMS(Index = 1)]
        /* 0x288 */ public NMSString0x20 ArchivedName;
    }
}
