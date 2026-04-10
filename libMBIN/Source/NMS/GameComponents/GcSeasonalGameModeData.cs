using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDC02B6B5CD788DED, NameHash = 0xC2909BE6)]
    public class GcSeasonalGameModeData : NMSTemplate
    {
        [NMS(Index = 76, Size = 0x1E)]
        /* 0x0000 */ public GcPetData[] SpecificPets;
        [NMS(Index = 68)]
        /* 0x5910 */ public GcInventoryContainer Inventory;
        [NMS(Index = 70)]
        /* 0x5A70 */ public GcInventoryContainer Inventory_Cargo;
        [NMS(Index = 69)]
        /* 0x5BD0 */ public GcInventoryContainer Inventory_TechOnly;
        [NMS(Index = 71)]
        /* 0x5D30 */ public GcInventoryContainer ShipInventory;
        [NMS(Index = 72)]
        /* 0x5E90 */ public GcInventoryContainer WeaponInventory;
        [NMS(Index = 122)]
        /* 0x5FF0 */ public GcTradeData SeasonalUAStationTradeData;
        [NMS(Index = 42)]
        /* 0x60D8 */ public GcMissionSequenceDetailMessage InitialJoaoBox;
        [NMS(Index = 43)]
        /* 0x6170 */ public GcMissionSequenceDetailMessage InitialJoaoBoxNoMainSave;
        [NMS(Index = 93, Size = 0x3, EnumType = typeof(GcExperienceBossType.ExperienceBossTypeEnum))]
        /* 0x6208 */ public NMSString0x10[] AltBossRewards;
        [NMS(Index = 73)]
        /* 0x6238 */ public GcSeasonTransferInventoryConfig SeasonTransferInventoryConfig;
        [NMS(Index = 33)]
        /* 0x6268 */ public NMSString0x20A CommunityProgressTitle;
        [NMS(Index = 36)]
        /* 0x6288 */ public NMSString0x20A CommunityTierCompleteLabel;
        [NMS(Index = 34)]
        /* 0x62A8 */ public NMSString0x20A CommunityTierLabel;
        [NMS(Index = 35)]
        /* 0x62C8 */ public NMSString0x20A CommunityTierProgressLabel;
        [NMS(Index = 22)]
        /* 0x62E8 */ public NMSString0x20A FinalCantRewardMessage;
        [NMS(Index = 8)]
        /* 0x6308 */ public NMSString0x20A FinalStageTitle;
        [NMS(Index = 31)]
        /* 0x6328 */ public NMSString0x20A MainMissionMessage;
        [NMS(Index = 30)]
        /* 0x6348 */ public NMSString0x20A MainMissionTitle;
        [NMS(Index = 9)]
        /* 0x6368 */ public NMSString0x20A MilestoneWithStageLocId;
        [NMS(Index = 28)]
        /* 0x6388 */ public NMSString0x20A SeasonName;
        [NMS(Index = 29)]
        /* 0x63A8 */ public NMSString0x20A SeasonNameUpper;
        [NMS(Index = 24)]
        /* 0x63C8 */ public TkTextureResource MainIcon;
        [NMS(Index = 65)]
        /* 0x63E0 */ public GcInventoryLayout ShipInventoryLayout;
        [NMS(Index = 66)]
        /* 0x63F8 */ public GcInventoryLayout ShipTechInventoryLayout;
        [NMS(Index = 64)]
        /* 0x6410 */ public GcInventoryLayout WeaponInventoryLayout;
        [NMS(Index = 105)]
        /* 0x6428 */ public List<NMSString0x10> AdditionalKnownProducts;
        [NMS(Index = 106)]
        /* 0x6438 */ public List<NMSString0x10> AdditionalKnownTech;
        [NMS(Index = 39)]
        /* 0x6448 */ public List<NMSString0x10> AdditionalTradeProducts;
        [NMS(Index = 131)]
        /* 0x6458 */ public GcSeed BlockShipRepairUntilMilestoneWithSeedComplete;
        [NMS(Index = 16)]
        /* 0x6468 */ public NMSString0x10 CreateContextSaveDataMask;
        [NMS(Index = 20)]
        /* 0x6478 */ public NMSString0x10 FinalReward;
        [NMS(Index = 21)]
        /* 0x6488 */ public NMSString0x10 FinalRewardSwitchAlt;
        [NMS(Index = 41)]
        /* 0x6498 */ public List<int> ForceBlackHolesAtPartyUAs;
        [NMS(Index = 103)]
        /* 0x64A8 */ public List<NMSString0x10> ForgottenProducts;
        [NMS(Index = 104)]
        /* 0x64B8 */ public List<NMSString0x10> ForgottenTech;
        [NMS(Index = 52)]
        /* 0x64C8 */ public GcFilename FreighterBaseOverrideFilename;
        [NMS(Index = 60)]
        /* 0x64D8 */ public NMSString0x10 IntroSequencePOI;
        [NMS(Index = 102)]
        /* 0x64E8 */ public List<NMSString0x10> NeverLearnableTech;
        [NMS(Index = 40)]
        /* 0x64F8 */ public List<NMSString0x10> NeverTradeProducts;
        [NMS(Index = 54)]
        /* 0x6508 */ public GcFilename OverrideFreighterFilename;
        [NMS(Index = 50)]
        /* 0x6518 */ public GcFilename OverrideMTFilename;
        [NMS(Index = 120)]
        /* 0x6528 */ public List<GcProductData> ProductTable;
        [NMS(Index = 75)]
        /* 0x6538 */ public List<GcSeasonPetConstraints> RandomPetConstraints;
        [NMS(Index = 78)]
        /* 0x6548 */ public List<GcSandwormTimerAndFrequencyOverride> SandwormOverrides;
        [NMS(Index = 114)]
        /* 0x6558 */ public GcScanEventTable ScanEventTable;
        [NMS(Index = 48)]
        /* 0x6568 */ public GcSeed ShipSeed;
        [NMS(Index = 113)]
        /* 0x6578 */ public List<GcSeasonalStage> Stages;
        [NMS(Index = 97)]
        /* 0x6588 */ public NMSString0x10 StartPlanetRareSubstanceOverride;
        [NMS(Index = 116)]
        /* 0x6598 */ public List<GcPersistedStatData> StatsToPersistOnReset;
        [NMS(Index = 121)]
        /* 0x65A8 */ public List<GcRealitySubstanceData> SubstanceTable;
        [NMS(Index = 17)]
        /* 0x65B8 */ public NMSString0x10 SwitchContextSaveDataMask;
        [NMS(Index = 119)]
        /* 0x65C8 */ public List<GcTechnology> TechnologyTable;
        [NMS(Index = 62)]
        /* 0x65D8 */ public List<GcBuildingClassification> ValidSpawnBuildings;
        [NMS(Index = 47)]
        /* 0x65E8 */ public GcSeed WeaponSeed;
        [NMS(Index = 2)]
        /* 0x65F8 */ public ulong EndTimeUTC;
        [NMS(Index = 3)]
        /* 0x6600 */ public ulong Hash;
        [NMS(Index = 1)]
        /* 0x6608 */ public ulong StartTimeUTC;
        [NMS(Index = 19)]
        /* 0x6610 */ public ulong UAOverrideValue;
        [NMS(Index = 15)]
        /* 0x6618 */ public GcDifficultySettingsData DifficultyMinimums;
        [NMS(Index = 91)]
        /* 0x6678 */ public Vector2f CustomFrigateFlybyTimer;
        [NMS(Index = 92)]
        /* 0x6680 */ public Vector2f CustomPiratePlanetFlybyTimer;
        [NMS(Index = 108)]
        /* 0x6688 */ public float AbandonedFreighterHazardProtectionMul;
        [NMS(Index = 85)]
        /* 0x668C */ public float BuildingRadiusShipOffsetMultiplier;
        [NMS(Index = 14)]
        /* 0x6690 */ public GcDifficultyPresetType DifficultySettingPreset;
        [NMS(Index = 27)]
        /* 0x6694 */ public int DisplayNumber;
        [NMS(Index = 84)]
        /* 0x6698 */ public float DistanceFromShipAtStartOfGame;
        [NMS(Index = 111)]
        /* 0x669C */ public float EnergyDrainMultiplier;
        [NMS(Index = 109)]
        /* 0x66A0 */ public float FarmPlantsTimerMul;
        [NMS(Index = 99)]
        /* 0x66A4 */ public int FreighterBattleEarlyWarpsOverride;
        [NMS(Index = 53)]
        /* 0x66A8 */ public GcAlienRace FreighterRace;
        [NMS(Index = 13)]
        /* 0x66AC */ public GcGameMode GameMode;
        [NMS(Index = 110)]
        /* 0x66B0 */ public float HazardProtectionDrainMultiplier;
        [NMS(Index = 112)]
        /* 0x66B4 */ public int QuestSubstanceReducer;
        [NMS(Index = 26)]
        /* 0x66B8 */ public int RemixNumber;
        [NMS(Index = 81)]
        /* 0x66BC */ public float SandwormGlobalOverrideSpawnChance;
        [NMS(Index = 80)]
        /* 0x66C0 */ public float SandwormGlobalOverrideTimer;
        [NMS(Index = 0)]
        /* 0x66C4 */ public int SeasonId;
        [NMS(Index = 25)]
        /* 0x66C8 */ public int SeasonNumber;
        [NMS(Index = 10)]
        /* 0x66CC */ public GcAudioWwiseEvents SeasonStartMusicOverride;
        [NMS(Index = 49)]
        /* 0x66D0 */ public GcSpaceshipClasses ShipType;
        [NMS(Index = 77)]
        /* 0x66D4 */ public int StartingPetSlots;
        [NMS(Index = 46)]
        /* 0x66D8 */ public int StartingSuitCargoSlots;
        [NMS(Index = 44)]
        /* 0x66DC */ public int StartingSuitSlots;
        [NMS(Index = 45)]
        /* 0x66E0 */ public int StartingSuitTechSlots;
        [NMS(Index = 128)]
        /* 0x66E4 */ public GcScreenFilters StartingUAScreenFilter;
        [NMS(Index = 101)]
        /* 0x66E8 */ public int TechCostMultiplier;
        [NMS(Index = 23)]
        /* 0x66EC */ public NMSString0x200 FinalRewardDescription;
        [NMS(Index = 63)]
        /* 0x68EC */ public NMSString0x80 UseSpawnBuildingNearUDA;
        [NMS(Index = 6)]
        /* 0x696C */ public NMSString0x20 Description;
        [NMS(Index = 18)]
        /* 0x698C */ public NMSString0x20 SeasonalUAOverride;
        [NMS(Index = 5)]
        /* 0x69AC */ public NMSString0x20 Subtitle;
        [NMS(Index = 7)]
        /* 0x69CC */ public NMSString0x20 Summary;
        [NMS(Index = 4)]
        /* 0x69EC */ public NMSString0x20 Title;
        [NMS(Index = 94)]
        /* 0x6A0C */ public bool AllowMissionDetailMessages;
        [NMS(Index = 133)]
        /* 0x6A0D */ public bool AllowOnlyCorvetteShipPurchases;
        [NMS(Index = 134)]
        /* 0x6A0E */ public bool AllowSaveContextMultitoolTransfer;
        [NMS(Index = 135)]
        /* 0x6A0F */ public bool AllowSaveContextShipTransfer;
        [NMS(Index = 88)]
        /* 0x6A10 */ public bool AlwaysStormy;
        [NMS(Index = 124)]
        /* 0x6A11 */ public bool AlwaysUseSeasonalStationTradeData;
        [NMS(Index = 89)]
        /* 0x6A12 */ public bool BlockAggressiveSentinelsInStartSystem;
        [NMS(Index = 90)]
        /* 0x6A13 */ public bool BlockExtremeWeatherInStartSystem;
        [NMS(Index = 12)]
        /* 0x6A14 */ public bool BlockFirstSpaceMusic;
        [NMS(Index = 87)]
        /* 0x6A15 */ public bool BlockStormsAtStart;
        [NMS(Index = 61)]
        /* 0x6A16 */ public bool CarnageMode;
        [NMS(Index = 117)]
        /* 0x6A17 */ public bool CompatibleWithState;
        [NMS(Index = 37)]
        /* 0x6A18 */ public bool DefaultToPvPOff;
        [NMS(Index = 32)]
        /* 0x6A19 */ public bool DoCommunityMissionTextSubstitutions;
        [NMS(Index = 59)]
        /* 0x6A1A */ public bool ForceAllSentinelsAggressive;
        [NMS(Index = 58)]
        /* 0x6A1B */ public bool ForceAllSystemsAbandoned;
        [NMS(Index = 100)]
        /* 0x6A1C */ public bool ForceDeepSpaceAmbientFrigatesOnInfested;
        [NMS(Index = 96)]
        /* 0x6A1D */ public bool ForceStartPlanetToHaveScrap;
        [NMS(Index = 57)]
        /* 0x6A1E */ public bool ForceStartSystemAbandoned;
        [NMS(Index = 56)]
        /* 0x6A1F */ public bool ForceStartSystemTernary;
        [NMS(Index = 118)]
        /* 0x6A20 */ public bool HasBeenConverted;
        [NMS(Index = 107)]
        /* 0x6A21 */ public bool IncreaseXClassTechOddsWithCommTier;
        [NMS(Index = 38)]
        /* 0x6A22 */ public bool MustCraftInBases;
        [NMS(Index = 132)]
        /* 0x6A23 */ public bool NeverAllowShipPurchases;
        [NMS(Index = 130)]
        /* 0x6A24 */ public bool OnlyCorvetteLauncherCanBeRepaired;
        [NMS(Index = 129)]
        /* 0x6A25 */ public bool OnlyCorvettesSpawnWhenPlayerTeleports;
        [NMS(Index = 127)]
        /* 0x6A26 */ public bool OverrideStartingUAScreenFilter;
        [NMS(Index = 11)]
        /* 0x6A27 */ public bool PlayStartMusicInIntro;
        [NMS(Index = 126)]
        /* 0x6A28 */ public bool PurpleSystemsUnlocked;
        [NMS(Index = 115)]
        /* 0x6A29 */ public bool ResetSaveOnDeath;
        [NMS(Index = 79)]
        /* 0x6A2A */ public bool SandwormGlobalOverride;
        [NMS(Index = 83)]
        /* 0x6A2B */ public bool ShipIsAtDifferentBuildingToPlayer;
        [NMS(Index = 86)]
        /* 0x6A2C */ public bool ShipStartsDamaged;
        [NMS(Index = 55)]
        /* 0x6A2D */ public bool StartAboardFreighter;
        [NMS(Index = 82)]
        /* 0x6A2E */ public bool StartNextToShip;
        [NMS(Index = 51)]
        /* 0x6A2F */ public bool StartWithFreighter;
        [NMS(Index = 98)]
        /* 0x6A30 */ public bool TrashInventoryOnGalaxyTravel;
        [NMS(Index = 67)]
        /* 0x6A31 */ public bool UseDefaultAppearance;
        [NMS(Index = 74)]
        /* 0x6A32 */ public bool UseRandomPet;
        [NMS(Index = 123)]
        /* 0x6A33 */ public bool UseSeasonalUAStationTradeData;
        [NMS(Index = 125)]
        /* 0x6A34 */ public bool UseSpookHazardOnly;
        [NMS(Index = 95)]
        /* 0x6A35 */ public bool UseStartPlanetObjectListOverrides;
    }
}
