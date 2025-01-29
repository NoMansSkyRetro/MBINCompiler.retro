using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x1134EF7E474E0B08, NameHash = 0xAD0019B)]
    public class TkAnimStateMachineStateData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x10 Anim;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 Name;
        [NMS(Index = 8)]
        /* 0x20 */ public List<TkAnimStateMachineTransitionData> Transitions;
        [NMS(Index = 1)]
        /* 0x30 */ public int Id;
        [NMS(Index = 3)]
        /* 0x34 */ public int NodePosX;
        [NMS(Index = 4)]
        /* 0x38 */ public int NodePosY;
        [NMS(Index = 5)]
        /* 0x3C */ public float ScrollX;
        [NMS(Index = 6)]
        /* 0x40 */ public float ScrollY;
        [NMS(Index = 7)]
        /* 0x44 */ public float Zoom;
    }
}
