using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7CF641D9AD5F4408, NameHash = 0x119404EE)]
    public class GcTileTypeOptions : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkPaletteTexture> Options;
    }
}
