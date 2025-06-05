using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBEF27BFB58999DA6, NameHash = 0x3514EB26)]
    public class GcSettlementJudgementOption : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A OptionText;
        [NMS(Index = 5)]
        /* 0x20 */ public List<NMSString0x10> AdditionalRewards;
        [NMS(Index = 1)]
        /* 0x30 */ public List<NMSString0x20A> AltOptionText;
        [NMS(Index = 6)]
        /* 0x40 */ public NMSString0x10 ChainedJudgementID;
        [NMS(Index = 2)]
        /* 0x50 */ public List<GcSettlementJudgementPerkOption> Perks;
        [NMS(Index = 4)]
        /* 0x60 */ public List<GcSettlementStatChange> StatChanges;
        [NMS(Index = 3)]
        /* 0x70 */ public bool HidePerkInJudgement;
        [NMS(Index = 11)]
        /* 0x71 */ public bool OptionIsPositiveForNPC;
        [NMS(Index = 9)]
        /* 0x72 */ public bool UseGiftReward;
        [NMS(Index = 7)]
        /* 0x73 */ public bool UsePolicyPerk;
        [NMS(Index = 8)]
        /* 0x74 */ public bool UsePolicyStat;
        [NMS(Index = 10)]
        /* 0x75 */ public bool UseTechPerk;
    }
}
