using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x186C7B97B5D5AE64, NameHash = 0x9DD850FA)]
    public class GcBuildingMaterialOverride : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcWeightedMaterialId> Materials;
        [NMS(Index = 0)]
        /* 0x10 */ public GcBuildingClassification Building;
    }
}
