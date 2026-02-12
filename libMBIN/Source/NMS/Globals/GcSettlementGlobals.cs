using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x8A6E8E69994980F7, NameHash = 0xCDDCFCB7)]
    public class GcSettlementGlobals : NMSTemplate
    {
        [NMS(Index = 52)]
        /* 0x0000 */ public Colour NegativeStatColour;
        [NMS(Index = 51)]
        /* 0x0010 */ public Colour PositiveStatColour;
        [NMS(Index = 24, Size = 0x3E, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x0020 */ public GcSettlementBuildingCost[] SettlementBuildingCosts;
        [NMS(Index = 22, Size = 0x3E, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x68C0 */ public GcSettlementBuildingContribution[] SettlementBuildingContributions;
        [NMS(Index = 20, Size = 0x3E, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x7840 */ public NMSString0x20A[] BuildingProductionNotes;
        [NMS(Index = 21, Size = 0x3E, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x8000 */ public NMSString0x20A[] BuildingUpgradePageNames;
        [NMS(Index = 75, Size = 0x3E, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x87C0 */ public NMSString0x20A[] SettlementBuildingClassGenericRequirement;
        [NMS(Index = 74, Size = 0x3E, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x8F80 */ public NMSString0x20A[] SettlementBuildingClassGenericTitle;
        [NMS(Index = 23, Size = 0x3E, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x9740 */ public ulong[] SettlementBuildingTimes;
        [NMS(Index = 79, Size = 0xC, EnumType = typeof(GcSettlementJudgementType.SettlementJudgementTypeEnum))]
        /* 0x9930 */ public NMSString0x20A[] JudgementMissionObjectives;
        [NMS(Index = 77, Size = 0xC, EnumType = typeof(GcSettlementJudgementType.SettlementJudgementTypeEnum))]
        /* 0x9AB0 */ public NMSString0x20A[] JudgementUpdateMainText;
        [NMS(Index = 78, Size = 0xC, EnumType = typeof(GcSettlementJudgementType.SettlementJudgementTypeEnum))]
        /* 0x9C30 */ public NMSString0x20A[] JudgementUpdateSubtitles;
        [NMS(Index = 76, Size = 0xC, EnumType = typeof(GcSettlementJudgementType.SettlementJudgementTypeEnum))]
        /* 0x9DB0 */ public NMSString0x20A[] JudgementUpdateTitles;
        [NMS(Index = 92, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x9F30 */ public NMSString0x20A[] LongAltResearchLocIDs;
        [NMS(Index = 88, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xA030 */ public NMSString0x20A[] LongPolicyLocIDs;
        [NMS(Index = 90, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xA130 */ public NMSString0x20A[] LongResearchLocIDs;
        [NMS(Index = 85, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xA230 */ public NMSString0x20A[] NegativeFakePerkOSDLocIDs;
        [NMS(Index = 81, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xA330 */ public NMSString0x20A[] NegativeStatChangeOSDLocIDs;
        [NMS(Index = 84, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xA430 */ public NMSString0x20A[] PositiveFakePerkOSDLocIDs;
        [NMS(Index = 80, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xA530 */ public NMSString0x20A[] PositiveStatChangeOSDLocIDs;
        [NMS(Index = 86, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xA630 */ public NMSString0x20A[] ProcPerkDescriptions;
        [NMS(Index = 91, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xA730 */ public NMSString0x20A[] ShortAltResearchLocIDs;
        [NMS(Index = 87, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xA830 */ public NMSString0x20A[] ShortPolicyLocIDs;
        [NMS(Index = 89, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xA930 */ public NMSString0x20A[] ShortResearchLocIDs;
        [NMS(Index = 68, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xAA30 */ public NMSString0x10[] AltResearchPerks;
        [NMS(Index = 83, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xAAB0 */ public NMSString0x10[] NegativeStatChangeSubstances;
        [NMS(Index = 66, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xAB30 */ public NMSString0x10[] PolicyPerks;
        [NMS(Index = 82, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xABB0 */ public NMSString0x10[] PositiveStatChangeSubstances;
        [NMS(Index = 67, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xAC30 */ public NMSString0x10[] ResearchPerks;
        [NMS(Index = 0)]
        /* 0xACB0 */ public GcScanToRevealComponentData BuilderNPCScanToRevealData;
        [NMS(Index = 12, Size = 0x4, EnumType = typeof(GcSettlementTowerPower.SettlementTowerPowerEnum))]
        /* 0xAD00 */ public ulong[] TowerPowerRechargeTime;
        [NMS(Index = 96)]
        /* 0xAD20 */ public List<GcSettlementGiftDetails> AutophageGifts;
        [NMS(Index = 73)]
        /* 0xAD30 */ public List<GcSettlementProductionElement> AutophageProductionElementsSelectable;
        [NMS(Index = 26)]
        /* 0xAD40 */ public List<GcSettlementCustomJudgement> CustomJudgements;
        [NMS(Index = 93)]
        /* 0xAD50 */ public List<GcSettlementGiftDetails> GekGifts;
        [NMS(Index = 70)]
        /* 0xAD60 */ public List<GcSettlementProductionElement> GekProductionElementsSelectable;
        [NMS(Index = 97)]
        /* 0xAD70 */ public List<GcSettlementGiftDetails> Gifts;
        [NMS(Index = 99)]
        /* 0xAD80 */ public List<GcSettlementJobDetails> JobTypes;
        [NMS(Index = 25)]
        /* 0xAD90 */ public List<GcSettlementJudgementData> Judgements;
        [NMS(Index = 14)]
        /* 0xADA0 */ public NMSString0x10 JudgementTextHashID;
        [NMS(Index = 94)]
        /* 0xADB0 */ public List<GcSettlementGiftDetails> KorvaxGifts;
        [NMS(Index = 71)]
        /* 0xADC0 */ public List<GcSettlementProductionElement> KorvaxProductionElementsSelectable;
        [NMS(Index = 18)]
        /* 0xADD0 */ public NMSString0x10 MiniMissionFailJudgement;
        [NMS(Index = 17)]
        /* 0xADE0 */ public NMSString0x10 MiniMissionSuccessJudgement;
        [NMS(Index = 1)]
        /* 0xADF0 */ public List<NMSString0x20A> ScanEventsThatPreventSentinelAlert;
        [NMS(Index = 30)]
        /* 0xAE00 */ public NMSString0x10 SettlementCostAutophage;
        [NMS(Index = 27)]
        /* 0xAE10 */ public NMSString0x10 SettlementCostGek;
        [NMS(Index = 28)]
        /* 0xAE20 */ public NMSString0x10 SettlementCostKorvax;
        [NMS(Index = 29)]
        /* 0xAE30 */ public NMSString0x10 SettlementCostVykeen;
        [NMS(Index = 16)]
        /* 0xAE40 */ public NMSString0x10 SettlementMiniExpeditionMissionID;
        [NMS(Index = 98)]
        /* 0xAE50 */ public List<NMSString0x10> TechGiftPerks;
        [NMS(Index = 95)]
        /* 0xAE60 */ public List<GcSettlementGiftDetails> VykeenGifts;
        [NMS(Index = 72)]
        /* 0xAE70 */ public List<GcSettlementProductionElement> VykeenProductionElementsSelectable;
        [NMS(Index = 56)]
        /* 0xAE80 */ public ulong AlertCycleDurationInSeconds;
        [NMS(Index = 57)]
        /* 0xAE88 */ public ulong BugAttackCycleDurationInSeconds;
        [NMS(Index = 4)]
        /* 0xAE90 */ public ulong BuildingFreeUpgradeTimeInSeconds;
        [NMS(Index = 3)]
        /* 0xAE98 */ public ulong BuildingUpgradeTimeInSeconds;
        [NMS(Index = 54)]
        /* 0xAEA0 */ public ulong ProductionCycleDurationInSeconds;
        [NMS(Index = 53)]
        /* 0xAEA8 */ public ulong ProductionSlotTimerOffsetInSeconds;
        [NMS(Index = 11)]
        /* 0xAEB0 */ public ulong TowerRechargeTime;
        [NMS(Index = 69, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xAEB8 */ public GcSettlementStatStrengthData[] PerkStatStrengthValues;
        [NMS(Index = 7, Size = 0xC, EnumType = typeof(GcSettlementJudgementType.SettlementJudgementTypeEnum))]
        /* 0xB078 */ public float[] JudgementSelectionWeights;
        [NMS(Index = 47, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xB0A8 */ public int[] InitialStatsMaxValues;
        [NMS(Index = 44, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xB0C8 */ public int[] InitialStatsMinValues;
        [NMS(Index = 49, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xB0E8 */ public float[] NormalisedStatBadThresholds;
        [NMS(Index = 50, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xB108 */ public float[] NormalisedStatGoodThresholds;
        [NMS(Index = 64, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xB128 */ public int[] StatProductivityContributionModifiers;
        [NMS(Index = 43, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xB148 */ public int[] StatsMaxValues;
        [NMS(Index = 42, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xB168 */ public int[] StatsMinValues;
        [NMS(Index = 62)]
        /* 0xB188 */ public int AlertUnitsPerCycleRateModifier;
        [NMS(Index = 63)]
        /* 0xB18C */ public int BugAttackUnitsPerCycleRateModifier;
        [NMS(Index = 2)]
        /* 0xB190 */ public float BuildingRevealCutsceneLength;
        [NMS(Index = 61)]
        /* 0xB194 */ public int DailyDebtPaymentModifier;
        [NMS(Index = 46)]
        /* 0xB198 */ public int InitialBuildingCountMax;
        [NMS(Index = 45)]
        /* 0xB19C */ public int InitialBuildingCountMin;
        [NMS(Index = 60)]
        /* 0xB1A0 */ public int InitialDebtCycles;
        [NMS(Index = 8)]
        /* 0xB1A4 */ public float JudgementSpecificRacePartyChance;
        [NMS(Index = 6)]
        /* 0xB1A8 */ public int JudgementWaitTimeMax;
        [NMS(Index = 5)]
        /* 0xB1AC */ public int JudgementWaitTimeMin;
        [NMS(Index = 35)]
        /* 0xB1B0 */ public int MaxInitialNegativePerksCount;
        [NMS(Index = 33)]
        /* 0xB1B4 */ public int MaxInitialPositivePerksCount;
        [NMS(Index = 9)]
        /* 0xB1B8 */ public int MaxNPCPopulation;
        [NMS(Index = 31)]
        /* 0xB1BC */ public int MaxPerksCount;
        [NMS(Index = 34)]
        /* 0xB1C0 */ public int MinInitialNegativePerksCount;
        [NMS(Index = 32)]
        /* 0xB1C4 */ public int MinInitialPositivePerksCount;
        [NMS(Index = 38)]
        /* 0xB1C8 */ public int PopulationGrowthRatePerDayBad;
        [NMS(Index = 40)]
        /* 0xB1CC */ public int PopulationGrowthRatePerDayGood;
        [NMS(Index = 39)]
        /* 0xB1D0 */ public int PopulationGrowthRatePerDayNeutral;
        [NMS(Index = 36)]
        /* 0xB1D4 */ public float PopulationGrowthRateThresholdBad;
        [NMS(Index = 37)]
        /* 0xB1D8 */ public float PopulationGrowthRateThresholdGood;
        [NMS(Index = 55)]
        /* 0xB1DC */ public float ProductionBoostConversionRate;
        [NMS(Index = 58)]
        /* 0xB1E0 */ public int ProductUnitsPerCycleRateModifier;
        [NMS(Index = 13)]
        /* 0xB1E4 */ public float SettlementEntryMessageDistance;
        [NMS(Index = 19)]
        /* 0xB1E8 */ public float SettlementMiniExpeditionSuccessChance;
        [NMS(Index = 15)]
        /* 0xB1EC */ public int SettlementMiniExpeditionTime;
        [NMS(Index = 41)]
        /* 0xB1F0 */ public float StartingPopulationScalar;
        [NMS(Index = 59)]
        /* 0xB1F4 */ public int SubstanceUnitsPerCycleRateModifier;
        [NMS(Index = 48, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xB1F8 */ public bool[] StatIsGoodWhenPositive;
        [NMS(Index = 65, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0xB200 */ public bool[] StatProductionIsNegativeWhenBad;
        [NMS(Index = 10)]
        /* 0xB208 */ public bool DebugForceShowHiddenPerks;
    }
}
