using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8310581AF6B5B960, NameHash = 0xF6C0D5D)]
    public class GcBuildingColourPalette : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcWeightedColourId> Palettes;
        [NMS(Index = 0)]
        /* 0x10 */ public GcBuildingClassification Building;
    }
}
