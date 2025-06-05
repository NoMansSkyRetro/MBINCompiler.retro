using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x383E55F05F80EA26, NameHash = 0x7A414D59)]
    public class GcSettlementStatChangeArray : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcSettlementStatChange> Stats;
    }
}
