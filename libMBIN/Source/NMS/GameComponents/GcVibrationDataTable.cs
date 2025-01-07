using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2578DFB6BFB7F9EA, NameHash = 0x95A6BF76)]
    public class GcVibrationDataTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcVibrationChannelData> Data;
    }
}
