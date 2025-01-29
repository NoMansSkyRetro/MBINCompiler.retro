using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4827ABC6CCA6883B, NameHash = 0xDC8CEC5A)]
    public class GcWFCDecorationSet : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcWFCDecorationItem> Items;
    }
}
