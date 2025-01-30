using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2DCD99C18C1E897B, NameHash = 0x3AB38D4F)]
    public class GcUniverseAddressData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public GcGalacticAddressData GalacticAddress;
        [NMS(Index = 0)]
        /* 0x14 */ public int RealityIndex;
    }
}
