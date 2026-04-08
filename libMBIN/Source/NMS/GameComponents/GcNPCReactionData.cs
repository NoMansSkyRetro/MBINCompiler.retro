using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1BFBFAC2D67BCEBF, NameHash = 0x5589CB5C)]
    public class GcNPCReactionData : NMSTemplate
    {
        [NMS(Index = 1, Size = 0xA, EnumType = typeof(GcGameTableNPCEventTrigger.GameTableNPCEventTriggerEnum))]
        /* 0x000 */ public GcGameTableNPCEventReactionData[] GameTableEventReactions;
        [NMS(Index = 0)]
        /* 0x1E0 */ public List<GcNPCReactionEntry> Reactions;
    }
}
