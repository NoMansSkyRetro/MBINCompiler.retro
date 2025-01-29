using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF1FAD0079B2AB600, NameHash = 0x9F906ED9)]
    public class GcNPCAnimationsData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x000 */ public GcNPCAnimationSetData SittingAnimatons;
        [NMS(Index = 4)]
        /* 0x190 */ public GcNPCAnimationSetData SittingIPadAnimatons;
        [NMS(Index = 0)]
        /* 0x320 */ public GcNPCAnimationSetData StandingAnimatons;
        [NMS(Index = 1)]
        /* 0x4B0 */ public GcNPCAnimationSetData StandingIPadAnimatons;
        [NMS(Index = 2)]
        /* 0x640 */ public GcNPCAnimationSetData StandingStaffAnimatons;
    }
}
