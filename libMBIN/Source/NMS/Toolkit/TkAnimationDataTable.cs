using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x5ECF4E0B9D0E0029, NameHash = 0x7D76DCB)]
    public class TkAnimationDataTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkAnimationData> Table;
    }
}
