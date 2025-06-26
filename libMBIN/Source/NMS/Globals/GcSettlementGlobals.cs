using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xB49AE7D411340282, NameHash = 0xCDDCFCB7)]
    public class GcSettlementGlobals : NMSTemplate
    {
        [NMS(Index = 52)]
        /* 0x0000 */ public Colour NegativeStatColour;
        [NMS(Index = 51)]
        /* 0x0010 */ public Colour PositiveStatColour;
        [NMS(Index = 24, Size = 0x3C, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x0020 */ public GcSettlementBuildingCost[] SettlementBuildingCosts;
        [NMS(Index = 22, Size = 0x3C, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x6560 */ public GcSettlementBuildingContribution[] SettlementBuildingContributions;
        [NMS(Index = 20, Size = 0x3C, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x7460 */ public NMSString0x20A[] BuildingProductionNotes;
        [NMS(Index = 21, Size = 0x3C, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x7BE0 */ public NMSString0x20A[] BuildingUpgradePageNames;
        [NMS(Index = 75, Size = 0x3C, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x8360 */ public NMSString0x20A[] SettlementBuildingClassGenericRequirement;
        [NMS(Index = 74, Size = 0x3C, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x8AE0 */ public NMSString0x20A[] SettlementBuildingClassGenericTitle;
        [NMS(Index = 23, Size = 0x3C, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x9260 */ public ulong[] SettlementBuildingTimes;
        [NMS(Index = 79, Size = 0xC, EnumType = typeof(GcSettlementJudgementType.SettlementJudgementTypeEnum))]
        /* 0x9440 */ public NMSString0x20A[] JudgementMissionObjectives;
        [NMS(Index = 77, Size = 0xC, EnumType = typeof(GcSettlementJudgementType.SettlementJudgementTypeEnum))]
        /* 0x95C0 */ public NMSString0x20A[] JudgementUpdateMainText;
        [NMS(Index = 78, Size = 0xC, EnumType = typeof(GcSettlementJudgementType.SettlementJudgementTypeEnum))]
        /* 0x9740 */ public NMSString0x20A[] JudgementUpdateSubtitles;
        [NMS(Index = 76, Size = 0xC, EnumType = typeof(GcSettlementJudgementType.SettlementJudgementTypeEnum))]
        /* 0x98C0 */ public NMSString0x20A[] JudgementUpdateTitles;
        [NMS(Index = 92, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x9A40 */ public NMSString0x20A[] LongAltResearchLocIDs;
        [NMS(Index = 88, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x9B40 */ public NMSString0x20A[] LongPolicyLocIDs;
        [NMS(Index = 90, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x9C40 */ public NMSString0x20A[] LongResearchLocIDs;
        [NMS(Index = 85, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x9D40 */ public NMSString0x20A[] NegativeFakePerkOSDLocIDs;
        [NMS(Index = 81, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x9E40 */ public NMSString0x20A[] NegativeStatChangeOSDLocIDs;
        [NMS(Index = 84, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x9F40 */ public NMSString0x20A[] PositiveFakePerkOSDLocIDs;
        [NMS(Index = 80, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xA040 */ public NMSString0x20A[] PositiveStatChangeOSDLocIDs;
        [NMS(Index = 86, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xA140 */ public NMSString0x20A[] ProcPerkDescriptions;
        [NMS(Index = 91, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xA240 */ public NMSString0x20A[] ShortAltResearchLocIDs;
        [NMS(Index = 87, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xA340 */ public NMSString0x20A[] ShortPolicyLocIDs;
        [NMS(Index = 89, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xA440 */ public NMSString0x20A[] ShortResearchLocIDs;
        [NMS(Index = 68, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xA540 */ public NMSString0x10[] AltResearchPerks;
        [NMS(Index = 83, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xA5C0 */ public NMSString0x10[] NegativeStatChangeSubstances;
        [NMS(Index = 66, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xA640 */ public NMSString0x10[] PolicyPerks;
        [NMS(Index = 82, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xA6C0 */ public NMSString0x10[] PositiveStatChangeSubstances;
        [NMS(Index = 67, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xA740 */ public NMSString0x10[] ResearchPerks;
        [NMS(Index = 0)]
        /* 0xA7C0 */ public GcScanToRevealComponentData BuilderNPCScanToRevealData;
        [NMS(Index = 12, Size = 0x4, EnumType = typeof(GcSettlementTowerPower.SettlementTowerPowerEnum))]
        /* 0xA810 */ public ulong[] TowerPowerRechargeTime;
        [NMS(Index = 96)]
        /* 0xA830 */ public List<GcSettlementGiftDetails> AutophageGifts;
        [NMS(Index = 73)]
        /* 0xA840 */ public List<GcSettlementProductionElement> AutophageProductionElementsSelectable;
        [NMS(Index = 26)]
        /* 0xA850 */ public List<GcSettlementCustomJudgement> CustomJudgements;
        [NMS(Index = 93)]
        /* 0xA860 */ public List<GcSettlementGiftDetails> GekGifts;
        [NMS(Index = 70)]
        /* 0xA870 */ public List<GcSettlementProductionElement> GekProductionElementsSelectable;
        [NMS(Index = 97)]
        /* 0xA880 */ public List<GcSettlementGiftDetails> Gifts;
        [NMS(Index = 99)]
        /* 0xA890 */ public List<GcSettlementJobDetails> JobTypes;
        [NMS(Index = 25)]
        /* 0xA8A0 */ public List<GcSettlementJudgementData> Judgements;
        [NMS(Index = 14)]
        /* 0xA8B0 */ public NMSString0x10 JudgementTextHashID;
        [NMS(Index = 94)]
        /* 0xA8C0 */ public List<GcSettlementGiftDetails> KorvaxGifts;
        [NMS(Index = 71)]
        /* 0xA8D0 */ public List<GcSettlementProductionElement> KorvaxProductionElementsSelectable;
        [NMS(Index = 18)]
        /* 0xA8E0 */ public NMSString0x10 MiniMissionFailJudgement;
        [NMS(Index = 17)]
        /* 0xA8F0 */ public NMSString0x10 MiniMissionSuccessJudgement;
        [NMS(Index = 1)]
        /* 0xA900 */ public List<NMSString0x20A> ScanEventsThatPreventSentinelAlert;
        [NMS(Index = 30)]
        /* 0xA910 */ public NMSString0x10 SettlementCostAutophage;
        [NMS(Index = 27)]
        /* 0xA920 */ public NMSString0x10 SettlementCostGek;
        [NMS(Index = 28)]
        /* 0xA930 */ public NMSString0x10 SettlementCostKorvax;
        [NMS(Index = 29)]
        /* 0xA940 */ public NMSString0x10 SettlementCostVykeen;
        [NMS(Index = 16)]
        /* 0xA950 */ public NMSString0x10 SettlementMiniExpeditionMissionID;
        [NMS(Index = 98)]
        /* 0xA960 */ public List<NMSString0x10> TechGiftPerks;
        [NMS(Index = 95)]
        /* 0xA970 */ public List<GcSettlementGiftDetails> VykeenGifts;
        [NMS(Index = 72)]
        /* 0xA980 */ public List<GcSettlementProductionElement> VykeenProductionElementsSelectable;
        [NMS(Index = 56)]
        /* 0xA990 */ public ulong AlertCycleDurationInSeconds;
        [NMS(Index = 57)]
        /* 0xA998 */ public ulong BugAttackCycleDurationInSeconds;
        [NMS(Index = 4)]
        /* 0xA9A0 */ public ulong BuildingFreeUpgradeTimeInSeconds;
        [NMS(Index = 3)]
        /* 0xA9A8 */ public ulong BuildingUpgradeTimeInSeconds;
        [NMS(Index = 54)]
        /* 0xA9B0 */ public ulong ProductionCycleDurationInSeconds;
        [NMS(Index = 53)]
        /* 0xA9B8 */ public ulong ProductionSlotTimerOffsetInSeconds;
        [NMS(Index = 11)]
        /* 0xA9C0 */ public ulong TowerRechargeTime;
        [NMS(Index = 69, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xA9C8 */ public GcSettlementStatStrengthData[] PerkStatStrengthValues;
        [NMS(Index = 7, Size = 0xC, EnumType = typeof(GcSettlementJudgementType.SettlementJudgementTypeEnum))]
        /* 0xAB88 */ public float[] JudgementSelectionWeights;
        [NMS(Index = 47, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xABB8 */ public int[] InitialStatsMaxValues;
        [NMS(Index = 44, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xABD8 */ public int[] InitialStatsMinValues;
        [NMS(Index = 49, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xABF8 */ public float[] NormalisedStatBadThresholds;
        [NMS(Index = 50, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xAC18 */ public float[] NormalisedStatGoodThresholds;
        [NMS(Index = 64, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xAC38 */ public int[] StatProductivityContributionModifiers;
        [NMS(Index = 43, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xAC58 */ public int[] StatsMaxValues;
        [NMS(Index = 42, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xAC78 */ public int[] StatsMinValues;
        [NMS(Index = 62)]
        /* 0xAC98 */ public int AlertUnitsPerCycleRateModifier;
        [NMS(Index = 63)]
        /* 0xAC9C */ public int BugAttackUnitsPerCycleRateModifier;
        [NMS(Index = 2)]
        /* 0xACA0 */ public float BuildingRevealCutsceneLength;
        [NMS(Index = 61)]
        /* 0xACA4 */ public int DailyDebtPaymentModifier;
        [NMS(Index = 46)]
        /* 0xACA8 */ public int InitialBuildingCountMax;
        [NMS(Index = 45)]
        /* 0xACAC */ public int InitialBuildingCountMin;
        [NMS(Index = 60)]
        /* 0xACB0 */ public int InitialDebtCycles;
        [NMS(Index = 8)]
        /* 0xACB4 */ public float JudgementSpecificRacePartyChance;
        [NMS(Index = 6)]
        /* 0xACB8 */ public int JudgementWaitTimeMax;
        [NMS(Index = 5)]
        /* 0xACBC */ public int JudgementWaitTimeMin;
        [NMS(Index = 35)]
        /* 0xACC0 */ public int MaxInitialNegativePerksCount;
        [NMS(Index = 33)]
        /* 0xACC4 */ public int MaxInitialPositivePerksCount;
        [NMS(Index = 9)]
        /* 0xACC8 */ public int MaxNPCPopulation;
        [NMS(Index = 31)]
        /* 0xACCC */ public int MaxPerksCount;
        [NMS(Index = 34)]
        /* 0xACD0 */ public int MinInitialNegativePerksCount;
        [NMS(Index = 32)]
        /* 0xACD4 */ public int MinInitialPositivePerksCount;
        [NMS(Index = 38)]
        /* 0xACD8 */ public int PopulationGrowthRatePerDayBad;
        [NMS(Index = 40)]
        /* 0xACDC */ public int PopulationGrowthRatePerDayGood;
        [NMS(Index = 39)]
        /* 0xACE0 */ public int PopulationGrowthRatePerDayNeutral;
        [NMS(Index = 36)]
        /* 0xACE4 */ public float PopulationGrowthRateThresholdBad;
        [NMS(Index = 37)]
        /* 0xACE8 */ public float PopulationGrowthRateThresholdGood;
        [NMS(Index = 55)]
        /* 0xACEC */ public float ProductionBoostConversionRate;
        [NMS(Index = 58)]
        /* 0xACF0 */ public int ProductUnitsPerCycleRateModifier;
        [NMS(Index = 13)]
        /* 0xACF4 */ public float SettlementEntryMessageDistance;
        [NMS(Index = 19)]
        /* 0xACF8 */ public float SettlementMiniExpeditionSuccessChance;
        [NMS(Index = 15)]
        /* 0xACFC */ public int SettlementMiniExpeditionTime;
        [NMS(Index = 41)]
        /* 0xAD00 */ public float StartingPopulationScalar;
        [NMS(Index = 59)]
        /* 0xAD04 */ public int SubstanceUnitsPerCycleRateModifier;
        [NMS(Index = 48, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xAD08 */ public bool[] StatIsGoodWhenPositive;
        [NMS(Index = 65, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xAD10 */ public bool[] StatProductionIsNegativeWhenBad;
        [NMS(Index = 10)]
        /* 0xAD18 */ public bool DebugForceShowHiddenPerks;
    }
}
