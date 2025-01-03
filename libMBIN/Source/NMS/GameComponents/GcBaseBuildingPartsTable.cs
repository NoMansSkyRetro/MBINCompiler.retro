using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC5062DF4506F0D06, NameHash = 0x3D61DD26)]
    public class GcBaseBuildingPartsTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcBaseBuildingPart> Parts;
    }
}
