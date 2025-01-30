using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8C098A8C48A5FAD5, NameHash = 0x5589CB5C)]
    public class GcNPCReactionData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcNPCReactionEntry> Reactions;
    }
}
