using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x351DCD6E536E2BF0, NameHash = 0xCD3146AC)]
    public class GcGameTableNPCEventReactionList : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public List<GcNPCProbabilityReactionData> Animations;
        [NMS(Index = 0)]
        /* 0x10 */ public float Priority;
        [NMS(Index = 1)]
        /* 0x14 */ public float ReactionChance;
    }
}
