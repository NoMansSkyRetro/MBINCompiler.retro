using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9E263CF1D2437309, NameHash = 0xD56EAD1F)]
    public class GcCreatureBehaviourTrees : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcCreatureBehaviourTreeData> BehaviourTree;
    }
}
