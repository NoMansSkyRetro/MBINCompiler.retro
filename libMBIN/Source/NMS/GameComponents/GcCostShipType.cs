using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB49B77463F1B678E, NameHash = 0xC61E1F77)]
    public class GcCostShipType : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcSpaceshipClasses ShipType;
    }
}
