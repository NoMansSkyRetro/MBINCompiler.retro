using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB784EE1BE2BC2C, NameHash = 0x336C420F)]
    public class GcSettlementColourUpgradeData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcBuildingColourPalette> BuildingPalettes;
        [NMS(Index = 0)]
        /* 0x10 */ public List<GcWeightedColourId> DefaultPalettes;
    }
}
