using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x742F4C7ED172D1D5, NameHash = 0xDE31ED3D)]
    public class GcSettlementCustomJudgement : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x000 */ public GcSettlementJudgementData Data;
        [NMS(Index = 2)]
        /* 0x170 */ public NMSString0x20A CustomCostText;
        [NMS(Index = 3)]
        /* 0x190 */ public NMSString0x20A CustomMissionObjectiveText;
        [NMS(Index = 0)]
        /* 0x1B0 */ public NMSString0x10 ID;
    }
}
