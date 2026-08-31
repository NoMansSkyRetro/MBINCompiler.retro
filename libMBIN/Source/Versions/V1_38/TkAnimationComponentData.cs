using System.Collections.Generic;

namespace libMBIN.V1_38.Structs
{
    public class TkAnimationComponentData : NMSTemplate     // size: 0xF0
    {
        /* 0x00 */ public TkAnimationData Idle;
        /* 0xE0 */ public List<TkAnimationData> Anims;
    }
}
