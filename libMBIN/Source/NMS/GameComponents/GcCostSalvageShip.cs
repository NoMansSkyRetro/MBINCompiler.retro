using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2AEC296158B31BA3, NameHash = 0x94BADD03)]
    public class GcCostSalvageShip : NMSTemplate
    {
        [NMS(Index = 2, Size = 0xB, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x000 */ public NMSString0x20A[] CustomErrorMessageOSD;
        [NMS(Index = 1, Size = 0xB, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x160 */ public NMSString0x20A[] ShipClassStringOverride;
        [NMS(Index = 3)]
        /* 0x2C0 */ public bool CannotAffordIfStringOverrideIsNull;
        [NMS(Index = 0)]
        /* 0x2C1 */ public bool WillGiveShipParts;
    }
}
