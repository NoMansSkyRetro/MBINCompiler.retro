using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x232C28E1E4FDF816, NameHash = 0xFBADBD2)]
    public class GcMissionConditionStatLevel : NMSTemplate
    {
        [NMS(Index = 7)]
        /* 0x00 */ public NMSString0x10 CompareStat;
        [NMS(Index = 10)]
        /* 0x10 */ public NMSString0x10 FormatItemNameIntoText;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 Stat;
        [NMS(Index = 1)]
        /* 0x30 */ public NMSString0x10 StatGroup;
        [NMS(Index = 8)]
        /* 0x40 */ public int DisplayMilestoneNumber;
        [NMS(Index = 2)]
        /* 0x44 */ public int Level;
        [NMS(Index = 3)]
        /* 0x48 */ public int LevelledStatRank;
        [NMS(Index = 9)]
        /* 0x4C */ public TkEqualityEnum Test;
        [NMS(Index = 5)]
        /* 0x50 */ public bool ForceIgnoreLevelledStat;
        [NMS(Index = 6)]
        /* 0x51 */ public bool MulAmountBySeasonTier;
        [NMS(Index = 4)]
        /* 0x52 */ public bool TakeLevelFromSeasonData;
    }
}
