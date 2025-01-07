using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x45956F5166A0F100, NameHash = 0xBEA4D836)]
    public class GcProceduralTechnologyTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcProceduralTechnologyData> Table;
    }
}
