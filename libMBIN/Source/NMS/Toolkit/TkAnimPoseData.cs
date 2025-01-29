namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x2B86312097FA666F, NameHash = 0x6ABBA097)]
    public class TkAnimPoseData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Anim;
        [NMS(Index = 2)]
        /* 0x10 */ public int FrameEnd;
        [NMS(Index = 1)]
        /* 0x14 */ public int FrameStart;
    }
}
