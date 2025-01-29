using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3B45A16410429AE6, NameHash = 0x55918A51)]
    public class GcTileTypeSets : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcTileTypeSet> TileTypeSets;
    }
}
