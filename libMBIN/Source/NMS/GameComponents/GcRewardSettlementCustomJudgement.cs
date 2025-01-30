namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB8D96584C06AF276, NameHash = 0x60619BEE)]
    public class GcRewardSettlementCustomJudgement : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 CustomJudgement;
        [NMS(Index = 2)]
        /* 0x10 */ public bool CanOverrideNonCustomJudgement;
        [NMS(Index = 1)]
        /* 0x11 */ public bool Silent;
    }
}
