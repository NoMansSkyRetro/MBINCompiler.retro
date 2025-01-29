using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB7DF94A83A64EDEF, NameHash = 0xC74BB941)]
    public class GcNPCAnimationList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcNPCProbabilityAnimationData> Animations;
    }
}
