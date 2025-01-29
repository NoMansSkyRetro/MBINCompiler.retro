using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF8FCA8A8EA15E484, NameHash = 0xFC3967D1)]
    public class GcShipOwnershipComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcSpaceshipComponentData Data;
    }
}
