using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBF5F4F7BD7D0DA49, NameHash = 0x94BADD03)]
    public class GcCostSalvageShip : NMSTemplate
    {
        [NMS(Index = 1, Size = 0xB, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x000 */ public NMSString0x20A[] ShipClassStringOverride;
        [NMS(Index = 2)]
        /* 0x160 */ public bool CannotAffordIfStringOverrideIsNull;
        [NMS(Index = 0)]
        /* 0x161 */ public bool WillGiveShipParts;
    }
}
