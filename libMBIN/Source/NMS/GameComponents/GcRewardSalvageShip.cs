using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x676482FB58140E0E, NameHash = 0xA2994124)]
    public class GcRewardSalvageShip : NMSTemplate
    {
        [NMS(Index = 1, Size = 0xB, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x00 */ public NMSString0x10[] SpecificCustomisationSlotIDs;
        [NMS(Index = 0)]
        /* 0xB0 */ public bool RewardShipParts;
    }
}
