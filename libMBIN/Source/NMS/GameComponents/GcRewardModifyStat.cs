using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8D99CF62C8BEE055, NameHash = 0x1E9EFBA2)]
    public class GcRewardModifyStat : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 OtherStat;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 Stat;
        [NMS(Index = 5)]
        /* 0x20 */ public NMSString0x10 StatGroup;
        [NMS(Index = 2)]
        /* 0x30 */ public int Amount;
        [NMS(Index = 4)]
        /* 0x34 */ public GcStatModifyType ModifyType;
        [NMS(Index = 3)]
        /* 0x38 */ public bool UseOtherStat;
    }
}
