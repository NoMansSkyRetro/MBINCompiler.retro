using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x250A200D5266A4E6, NameHash = 0x4E2556EB)]
    public class GcMissionTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcGenericMissionSequence> Missions;
    }
}
