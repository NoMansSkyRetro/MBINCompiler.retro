using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB94066BF3E6E2959, NameHash = 0xF85CDB97)]
    public class GcSettlementPerksTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcSettlementPerkData> Table;
    }
}
