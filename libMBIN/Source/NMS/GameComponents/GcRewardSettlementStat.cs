using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC6160501172EB477, NameHash = 0x83BEB92)]
    public class GcRewardSettlementStat : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcSettlementStatChange StatToAward;
        [NMS(Index = 1)]
        /* 0x8 */ public bool Silent;
    }
}
