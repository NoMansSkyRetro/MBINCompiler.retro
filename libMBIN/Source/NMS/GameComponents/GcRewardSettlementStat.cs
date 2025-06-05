using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x453E0133ADF03CBD, NameHash = 0x83BEB92)]
    public class GcRewardSettlementStat : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcSettlementStatChange StatToAward;
        [NMS(Index = 1)]
        /* 0x8 */ public bool Silent;
    }
}
