using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x708A69A899BFE829, NameHash = 0xCDDCFCB7)]
    public class GcSettlementGlobals : NMSTemplate
    {
        [NMS(Index = 38)]
        /* 0x0000 */ public Colour NegativeStatColour;
        [NMS(Index = 37)]
        /* 0x0010 */ public Colour PositiveStatColour;
        [NMS(Index = 16, Size = 0x39, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x0020 */ public GcSettlementBuildingCost[] SettlementBuildingCosts;
        [NMS(Index = 19, Size = 0x39, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x4040 */ public GcSettlementStatChangeArray[] SettlementBuildingStatRewards;
        [NMS(Index = 15, Size = 0x39, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x43D0 */ public ulong[] SettlementBuildingTimes;
        [NMS(Index = 61, Size = 0x7, EnumType = typeof(GcSettlementJudgementType.SettlementJudgementTypeEnum))]
        /* 0x4598 */ public NMSString0x20A[] JudgementUpdateMainText;
        [NMS(Index = 62, Size = 0x7, EnumType = typeof(GcSettlementJudgementType.SettlementJudgementTypeEnum))]
        /* 0x4678 */ public NMSString0x20A[] JudgementUpdateSubtitles;
        [NMS(Index = 60, Size = 0x7, EnumType = typeof(GcSettlementJudgementType.SettlementJudgementTypeEnum))]
        /* 0x4758 */ public NMSString0x20A[] JudgementUpdateTitles;
        [NMS(Index = 75, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4838 */ public NMSString0x20A[] LongAltResearchLocIDs;
        [NMS(Index = 71, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4918 */ public NMSString0x20A[] LongPolicyLocIDs;
        [NMS(Index = 73, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x49F8 */ public NMSString0x20A[] LongResearchLocIDs;
        [NMS(Index = 68, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4AD8 */ public NMSString0x20A[] NegativeFakePerkOSDLocIDs;
        [NMS(Index = 64, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4BB8 */ public NMSString0x20A[] NegativeStatChangeOSDLocIDs;
        [NMS(Index = 67, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4C98 */ public NMSString0x20A[] PositiveFakePerkOSDLocIDs;
        [NMS(Index = 63, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4D78 */ public NMSString0x20A[] PositiveStatChangeOSDLocIDs;
        [NMS(Index = 69, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4E58 */ public NMSString0x20A[] ProcPerkDescriptions;
        [NMS(Index = 74, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x4F38 */ public NMSString0x20A[] ShortAltResearchLocIDs;
        [NMS(Index = 70, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x5018 */ public NMSString0x20A[] ShortPolicyLocIDs;
        [NMS(Index = 72, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x50F8 */ public NMSString0x20A[] ShortResearchLocIDs;
        [NMS(Index = 52, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x51D8 */ public NMSString0x10[] AltResearchPerks;
        [NMS(Index = 66, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x5248 */ public NMSString0x10[] NegativeStatChangeSubstances;
        [NMS(Index = 50, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x52B8 */ public NMSString0x10[] PolicyPerks;
        [NMS(Index = 65, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x5328 */ public NMSString0x10[] PositiveStatChangeSubstances;
        [NMS(Index = 51, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x5398 */ public NMSString0x10[] ResearchPerks;
        [NMS(Index = 18)]
        /* 0x5408 */ public List<GcSettlementCustomJudgement> CustomJudgements;
        [NMS(Index = 76)]
        /* 0x5418 */ public List<GcSettlementGiftDetails> GekGifts;
        [NMS(Index = 54)]
        /* 0x5428 */ public List<NMSString0x10> GekProductionElements;
        [NMS(Index = 79)]
        /* 0x5438 */ public List<GcSettlementGiftDetails> Gifts;
        [NMS(Index = 81)]
        /* 0x5448 */ public List<GcSettlementJobDetails> JobTypes;
        [NMS(Index = 17)]
        /* 0x5458 */ public List<GcSettlementJudgementData> Judgements;
        [NMS(Index = 77)]
        /* 0x5468 */ public List<GcSettlementGiftDetails> KorvaxGifts;
        [NMS(Index = 55)]
        /* 0x5478 */ public List<NMSString0x10> KorvaxProductionElements;
        [NMS(Index = 58)]
        /* 0x5488 */ public List<NMSString0x10> NeutralProductionElements;
        [NMS(Index = 57)]
        /* 0x5498 */ public List<NMSString0x10> PoorProductionElements;
        [NMS(Index = 59)]
        /* 0x54A8 */ public List<NMSString0x10> RichProductionElements;
        [NMS(Index = 0)]
        /* 0x54B8 */ public List<NMSString0x20A> ScanEventsThatPreventSentinelAlert;
        [NMS(Index = 20)]
        /* 0x54C8 */ public NMSString0x10 SettlementCostGek;
        [NMS(Index = 21)]
        /* 0x54D8 */ public NMSString0x10 SettlementCostKorvax;
        [NMS(Index = 22)]
        /* 0x54E8 */ public NMSString0x10 SettlementCostVykeen;
        [NMS(Index = 13)]
        /* 0x54F8 */ public NMSString0x10 SettlementMiniExpeditionMissionID;
        [NMS(Index = 80)]
        /* 0x5508 */ public List<NMSString0x10> TechGiftPerks;
        [NMS(Index = 78)]
        /* 0x5518 */ public List<GcSettlementGiftDetails> VykeenGifts;
        [NMS(Index = 56)]
        /* 0x5528 */ public List<NMSString0x10> VykeenProductionElements;
        [NMS(Index = 41)]
        /* 0x5538 */ public ulong AlertCycleDurationInSeconds;
        [NMS(Index = 2)]
        /* 0x5540 */ public ulong BuildingFreeUpgradeTimeInSeconds;
        [NMS(Index = 1)]
        /* 0x5548 */ public ulong BuildingUpgradeTimeInSeconds;
        [NMS(Index = 40)]
        /* 0x5550 */ public ulong ProductionCycleDurationInSeconds;
        [NMS(Index = 39)]
        /* 0x5558 */ public ulong ProductionSlotTimerOffsetInSeconds;
        [NMS(Index = 53, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x5560 */ public GcSettlementStatStrengthData[] PerkStatStrengthValues;
        [NMS(Index = 33, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x56E8 */ public int[] InitialStatsMaxValues;
        [NMS(Index = 30, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x5704 */ public int[] InitialStatsMinValues;
        [NMS(Index = 35, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x5720 */ public float[] NormalisedStatBadThresholds;
        [NMS(Index = 36, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x573C */ public float[] NormalisedStatGoodThresholds;
        [NMS(Index = 48, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x5758 */ public int[] StatProductivityContributionModifiers;
        [NMS(Index = 29, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x5774 */ public int[] StatsMaxValues;
        [NMS(Index = 28, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x5790 */ public int[] StatsMinValues;
        [NMS(Index = 47)]
        /* 0x57AC */ public int AlertUnitsPerCycleRateModifier;
        [NMS(Index = 5)]
        /* 0x57B0 */ public float BuildingJudgementPriorityChance;
        [NMS(Index = 9)]
        /* 0x57B4 */ public float ConflictJudgementSelector;
        [NMS(Index = 46)]
        /* 0x57B8 */ public int DailyDebtPaymentModifier;
        [NMS(Index = 32)]
        /* 0x57BC */ public int InitialBuildingCountMax;
        [NMS(Index = 31)]
        /* 0x57C0 */ public int InitialBuildingCountMin;
        [NMS(Index = 45)]
        /* 0x57C4 */ public int InitialDebtCycles;
        [NMS(Index = 4)]
        /* 0x57C8 */ public int JudgementWaitTimeMax;
        [NMS(Index = 3)]
        /* 0x57CC */ public int JudgementWaitTimeMin;
        [NMS(Index = 27)]
        /* 0x57D0 */ public int MaxInitialNegativePerksCount;
        [NMS(Index = 25)]
        /* 0x57D4 */ public int MaxInitialPositivePerksCount;
        [NMS(Index = 10)]
        /* 0x57D8 */ public int MaxNPCPopulation;
        [NMS(Index = 23)]
        /* 0x57DC */ public int MaxPerksCount;
        [NMS(Index = 42)]
        /* 0x57E0 */ public int MaxProductionSlotUnits;
        [NMS(Index = 26)]
        /* 0x57E4 */ public int MinInitialNegativePerksCount;
        [NMS(Index = 24)]
        /* 0x57E8 */ public int MinInitialPositivePerksCount;
        [NMS(Index = 7)]
        /* 0x57EC */ public float PolicyJudgementSelector;
        [NMS(Index = 43)]
        /* 0x57F0 */ public int ProductUnitsPerCycleRateModifier;
        [NMS(Index = 8)]
        /* 0x57F4 */ public float RequestJudgementSelector;
        [NMS(Index = 12)]
        /* 0x57F8 */ public float SettlementEntryMessageDistance;
        [NMS(Index = 14)]
        /* 0x57FC */ public float SettlementMiniExpeditionSuccessChance;
        [NMS(Index = 44)]
        /* 0x5800 */ public int SubstanceUnitsPerCycleRateModifier;
        [NMS(Index = 6)]
        /* 0x5804 */ public float VisitorJudgementSelector;
        [NMS(Index = 34, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x5808 */ public bool[] StatIsGoodWhenPositive;
        [NMS(Index = 49, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x580F */ public bool[] StatProductionIsNegativeWhenBad;
        [NMS(Index = 11)]
        /* 0x5816 */ public bool DebugForceShowHiddenPerks;
    }
}
