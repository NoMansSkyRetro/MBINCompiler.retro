using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x5D9DA838892236CB, NameHash = 0xCDDCFCB7)]
    public class GcSettlementGlobals : NMSTemplate
    {
        [NMS(Index = 51)]
        /* 0x0000 */ public Colour NegativeStatColour;
        [NMS(Index = 50)]
        /* 0x0010 */ public Colour PositiveStatColour;
        [NMS(Index = 23, Size = 0x3C, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x0020 */ public GcSettlementBuildingCost[] SettlementBuildingCosts;
        [NMS(Index = 21, Size = 0x3C, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x6560 */ public GcSettlementBuildingContribution[] SettlementBuildingContributions;
        [NMS(Index = 19, Size = 0x3C, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x7460 */ public NMSString0x20A[] BuildingProductionNotes;
        [NMS(Index = 20, Size = 0x3C, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x7BE0 */ public NMSString0x20A[] BuildingUpgradePageNames;
        [NMS(Index = 74, Size = 0x3C, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x8360 */ public NMSString0x20A[] SettlementBuildingClassGenericRequirement;
        [NMS(Index = 73, Size = 0x3C, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x8AE0 */ public NMSString0x20A[] SettlementBuildingClassGenericTitle;
        [NMS(Index = 22, Size = 0x3C, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x9260 */ public ulong[] SettlementBuildingTimes;
        [NMS(Index = 78, Size = 0xC, EnumType = typeof(GcSettlementJudgementType.SettlementJudgementTypeEnum))]
        /* 0x9440 */ public NMSString0x20A[] JudgementMissionObjectives;
        [NMS(Index = 76, Size = 0xC, EnumType = typeof(GcSettlementJudgementType.SettlementJudgementTypeEnum))]
        /* 0x95C0 */ public NMSString0x20A[] JudgementUpdateMainText;
        [NMS(Index = 77, Size = 0xC, EnumType = typeof(GcSettlementJudgementType.SettlementJudgementTypeEnum))]
        /* 0x9740 */ public NMSString0x20A[] JudgementUpdateSubtitles;
        [NMS(Index = 75, Size = 0xC, EnumType = typeof(GcSettlementJudgementType.SettlementJudgementTypeEnum))]
        /* 0x98C0 */ public NMSString0x20A[] JudgementUpdateTitles;
        [NMS(Index = 91, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x9A40 */ public NMSString0x20A[] LongAltResearchLocIDs;
        [NMS(Index = 87, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x9B40 */ public NMSString0x20A[] LongPolicyLocIDs;
        [NMS(Index = 89, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x9C40 */ public NMSString0x20A[] LongResearchLocIDs;
        [NMS(Index = 84, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x9D40 */ public NMSString0x20A[] NegativeFakePerkOSDLocIDs;
        [NMS(Index = 80, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x9E40 */ public NMSString0x20A[] NegativeStatChangeOSDLocIDs;
        [NMS(Index = 83, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x9F40 */ public NMSString0x20A[] PositiveFakePerkOSDLocIDs;
        [NMS(Index = 79, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xA040 */ public NMSString0x20A[] PositiveStatChangeOSDLocIDs;
        [NMS(Index = 85, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xA140 */ public NMSString0x20A[] ProcPerkDescriptions;
        [NMS(Index = 90, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xA240 */ public NMSString0x20A[] ShortAltResearchLocIDs;
        [NMS(Index = 86, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xA340 */ public NMSString0x20A[] ShortPolicyLocIDs;
        [NMS(Index = 88, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xA440 */ public NMSString0x20A[] ShortResearchLocIDs;
        [NMS(Index = 67, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xA540 */ public NMSString0x10[] AltResearchPerks;
        [NMS(Index = 82, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xA5C0 */ public NMSString0x10[] NegativeStatChangeSubstances;
        [NMS(Index = 65, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xA640 */ public NMSString0x10[] PolicyPerks;
        [NMS(Index = 81, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xA6C0 */ public NMSString0x10[] PositiveStatChangeSubstances;
        [NMS(Index = 66, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xA740 */ public NMSString0x10[] ResearchPerks;
        [NMS(Index = 0)]
        /* 0xA7C0 */ public GcScanToRevealComponentData BuilderNPCScanToRevealData;
        [NMS(Index = 95)]
        /* 0xA810 */ public List<GcSettlementGiftDetails> AutophageGifts;
        [NMS(Index = 72)]
        /* 0xA820 */ public List<GcSettlementProductionElement> AutophageProductionElementsSelectable;
        [NMS(Index = 25)]
        /* 0xA830 */ public List<GcSettlementCustomJudgement> CustomJudgements;
        [NMS(Index = 92)]
        /* 0xA840 */ public List<GcSettlementGiftDetails> GekGifts;
        [NMS(Index = 69)]
        /* 0xA850 */ public List<GcSettlementProductionElement> GekProductionElementsSelectable;
        [NMS(Index = 96)]
        /* 0xA860 */ public List<GcSettlementGiftDetails> Gifts;
        [NMS(Index = 98)]
        /* 0xA870 */ public List<GcSettlementJobDetails> JobTypes;
        [NMS(Index = 24)]
        /* 0xA880 */ public List<GcSettlementJudgementData> Judgements;
        [NMS(Index = 13)]
        /* 0xA890 */ public NMSString0x10 JudgementTextHashID;
        [NMS(Index = 93)]
        /* 0xA8A0 */ public List<GcSettlementGiftDetails> KorvaxGifts;
        [NMS(Index = 70)]
        /* 0xA8B0 */ public List<GcSettlementProductionElement> KorvaxProductionElementsSelectable;
        [NMS(Index = 17)]
        /* 0xA8C0 */ public NMSString0x10 MiniMissionFailJudgement;
        [NMS(Index = 16)]
        /* 0xA8D0 */ public NMSString0x10 MiniMissionSuccessJudgement;
        [NMS(Index = 1)]
        /* 0xA8E0 */ public List<NMSString0x20A> ScanEventsThatPreventSentinelAlert;
        [NMS(Index = 29)]
        /* 0xA8F0 */ public NMSString0x10 SettlementCostAutophage;
        [NMS(Index = 26)]
        /* 0xA900 */ public NMSString0x10 SettlementCostGek;
        [NMS(Index = 27)]
        /* 0xA910 */ public NMSString0x10 SettlementCostKorvax;
        [NMS(Index = 28)]
        /* 0xA920 */ public NMSString0x10 SettlementCostVykeen;
        [NMS(Index = 15)]
        /* 0xA930 */ public NMSString0x10 SettlementMiniExpeditionMissionID;
        [NMS(Index = 97)]
        /* 0xA940 */ public List<NMSString0x10> TechGiftPerks;
        [NMS(Index = 94)]
        /* 0xA950 */ public List<GcSettlementGiftDetails> VykeenGifts;
        [NMS(Index = 71)]
        /* 0xA960 */ public List<GcSettlementProductionElement> VykeenProductionElementsSelectable;
        [NMS(Index = 55)]
        /* 0xA970 */ public ulong AlertCycleDurationInSeconds;
        [NMS(Index = 56)]
        /* 0xA978 */ public ulong BugAttackCycleDurationInSeconds;
        [NMS(Index = 4)]
        /* 0xA980 */ public ulong BuildingFreeUpgradeTimeInSeconds;
        [NMS(Index = 3)]
        /* 0xA988 */ public ulong BuildingUpgradeTimeInSeconds;
        [NMS(Index = 53)]
        /* 0xA990 */ public ulong ProductionCycleDurationInSeconds;
        [NMS(Index = 52)]
        /* 0xA998 */ public ulong ProductionSlotTimerOffsetInSeconds;
        [NMS(Index = 11)]
        /* 0xA9A0 */ public ulong TowerRechargeTime;
        [NMS(Index = 68, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xA9A8 */ public GcSettlementStatStrengthData[] PerkStatStrengthValues;
        [NMS(Index = 7, Size = 0xC, EnumType = typeof(GcSettlementJudgementType.SettlementJudgementTypeEnum))]
        /* 0xAB68 */ public float[] JudgementSelectionWeights;
        [NMS(Index = 46, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xAB98 */ public int[] InitialStatsMaxValues;
        [NMS(Index = 43, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xABB8 */ public int[] InitialStatsMinValues;
        [NMS(Index = 48, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xABD8 */ public float[] NormalisedStatBadThresholds;
        [NMS(Index = 49, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xABF8 */ public float[] NormalisedStatGoodThresholds;
        [NMS(Index = 63, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xAC18 */ public int[] StatProductivityContributionModifiers;
        [NMS(Index = 42, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xAC38 */ public int[] StatsMaxValues;
        [NMS(Index = 41, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xAC58 */ public int[] StatsMinValues;
        [NMS(Index = 61)]
        /* 0xAC78 */ public int AlertUnitsPerCycleRateModifier;
        [NMS(Index = 62)]
        /* 0xAC7C */ public int BugAttackUnitsPerCycleRateModifier;
        [NMS(Index = 2)]
        /* 0xAC80 */ public float BuildingRevealCutsceneLength;
        [NMS(Index = 60)]
        /* 0xAC84 */ public int DailyDebtPaymentModifier;
        [NMS(Index = 45)]
        /* 0xAC88 */ public int InitialBuildingCountMax;
        [NMS(Index = 44)]
        /* 0xAC8C */ public int InitialBuildingCountMin;
        [NMS(Index = 59)]
        /* 0xAC90 */ public int InitialDebtCycles;
        [NMS(Index = 8)]
        /* 0xAC94 */ public float JudgementSpecificRacePartyChance;
        [NMS(Index = 6)]
        /* 0xAC98 */ public int JudgementWaitTimeMax;
        [NMS(Index = 5)]
        /* 0xAC9C */ public int JudgementWaitTimeMin;
        [NMS(Index = 34)]
        /* 0xACA0 */ public int MaxInitialNegativePerksCount;
        [NMS(Index = 32)]
        /* 0xACA4 */ public int MaxInitialPositivePerksCount;
        [NMS(Index = 9)]
        /* 0xACA8 */ public int MaxNPCPopulation;
        [NMS(Index = 30)]
        /* 0xACAC */ public int MaxPerksCount;
        [NMS(Index = 33)]
        /* 0xACB0 */ public int MinInitialNegativePerksCount;
        [NMS(Index = 31)]
        /* 0xACB4 */ public int MinInitialPositivePerksCount;
        [NMS(Index = 37)]
        /* 0xACB8 */ public int PopulationGrowthRatePerDayBad;
        [NMS(Index = 39)]
        /* 0xACBC */ public int PopulationGrowthRatePerDayGood;
        [NMS(Index = 38)]
        /* 0xACC0 */ public int PopulationGrowthRatePerDayNeutral;
        [NMS(Index = 35)]
        /* 0xACC4 */ public float PopulationGrowthRateThresholdBad;
        [NMS(Index = 36)]
        /* 0xACC8 */ public float PopulationGrowthRateThresholdGood;
        [NMS(Index = 54)]
        /* 0xACCC */ public float ProductionBoostConversionRate;
        [NMS(Index = 57)]
        /* 0xACD0 */ public int ProductUnitsPerCycleRateModifier;
        [NMS(Index = 12)]
        /* 0xACD4 */ public float SettlementEntryMessageDistance;
        [NMS(Index = 18)]
        /* 0xACD8 */ public float SettlementMiniExpeditionSuccessChance;
        [NMS(Index = 14)]
        /* 0xACDC */ public int SettlementMiniExpeditionTime;
        [NMS(Index = 40)]
        /* 0xACE0 */ public float StartingPopulationScalar;
        [NMS(Index = 58)]
        /* 0xACE4 */ public int SubstanceUnitsPerCycleRateModifier;
        [NMS(Index = 47, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xACE8 */ public bool[] StatIsGoodWhenPositive;
        [NMS(Index = 64, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xACF0 */ public bool[] StatProductionIsNegativeWhenBad;
        [NMS(Index = 10)]
        /* 0xACF8 */ public bool DebugForceShowHiddenPerks;
    }
}
