using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x1DAE11A87E1DBDFA, NameHash = 0x573A9AA9)]
    public class TkAnimationComponentData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x000 */ public TkAnimationData Idle;
        [NMS(Index = 3)]
        /* 0x108 */ public NMSString0x10 AnimGroup;
        [NMS(Index = 5)]
        /* 0x118 */ public List<VariableSizeString> AnimLibraries;
        [NMS(Index = 4)]
        /* 0x128 */ public List<TkAnimationData> Anims;
        [NMS(Index = 7)]
        /* 0x138 */ public List<TkAnimJointLODData> JointLODOverrides;
        [NMS(Index = 2)]
        /* 0x148 */ public List<TkAnimRandomOneShots> RandomOneShots;
        [NMS(Index = 6)]
        /* 0x158 */ public List<TkAnimBlendTree> Trees;
        [NMS(Index = 0)]
        /* 0x168 */ public bool NetSyncAnimations;
    }
}
