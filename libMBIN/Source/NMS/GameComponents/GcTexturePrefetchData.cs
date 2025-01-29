using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4D8552BB0C8BA78, NameHash = 0x98680091)]
    public class GcTexturePrefetchData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<NMSString0x80> Textures;
    }
}
