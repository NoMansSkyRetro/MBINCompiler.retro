using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x359175E74F930402, NameHash = 0x95A6BF76)]
    public class GcVibrationDataTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcVibrationChannelData> Data;
    }
}
