using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xEC13A3279B03A68A, NameHash = 0xC2C9E5EF)]
    public class TkAudioAnimTrigger : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 Anim;
        [NMS(Index = 3)]
        /* 0x10 */ public List<NMSString0x20A> OnlyValidWithParts;
        [NMS(Index = 2)]
        /* 0x20 */ public int FrameStart;
        [NMS(Index = 0)]
        /* 0x24 */ public NMSString0x80 Sound;
    }
}
