using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF8B4C8910A275DFF, NameHash = 0xC2909BE6)]
    public class GcSeasonalGameModeData : NMSTemplate
    {
        [NMS(Index = 75, Size = 0x12)]
        /* 0x0000 */ public GcPetData[] SpecificPets;
        [NMS(Index = 67)]
        /* 0x2490 */ public GcInventoryContainer Inventory;
        [NMS(Index = 69)]
        /* 0x25F0 */ public GcInventoryContainer Inventory_Cargo;
        [NMS(Index = 68)]
        /* 0x2750 */ public GcInventoryContainer Inventory_TechOnly;
        [NMS(Index = 70)]
        /* 0x28B0 */ public GcInventoryContainer ShipInventory;
        [NMS(Index = 71)]
        /* 0x2A10 */ public GcInventoryContainer WeaponInventory;
        [NMS(Index = 115)]
        /* 0x2B70 */ public GcTradeData SeasonalUAStationTradeData;
        [NMS(Index = 42)]
        /* 0x2C58 */ public GcMissionSequenceDetailMessage InitialJoaoBox;
        [NMS(Index = 43)]
        /* 0x2CF0 */ public GcMissionSequenceDetailMessage InitialJoaoBoxNoMainSave;
        [NMS(Index = 90, Size = 0x3, EnumType = typeof(GcExperienceBossType.ExperienceBossTypeEnum))]
        /* 0x2D88 */ public NMSString0x10[] AltBossRewards;
        [NMS(Index = 72)]
        /* 0x2DB8 */ public GcSeasonTransferInventoryConfig SeasonTransferInventoryConfig;
        [NMS(Index = 33)]
        /* 0x2DE8 */ public NMSString0x20A CommunityProgressTitle;
        [NMS(Index = 36)]
        /* 0x2E08 */ public NMSString0x20A CommunityTierCompleteLabel;
        [NMS(Index = 34)]
        /* 0x2E28 */ public NMSString0x20A CommunityTierLabel;
        [NMS(Index = 35)]
        /* 0x2E48 */ public NMSString0x20A CommunityTierProgressLabel;
        [NMS(Index = 22)]
        /* 0x2E68 */ public NMSString0x20A FinalCantRewardMessage;
        [NMS(Index = 8)]
        /* 0x2E88 */ public NMSString0x20A FinalStageTitle;
        [NMS(Index = 31)]
        /* 0x2EA8 */ public NMSString0x20A MainMissionMessage;
        [NMS(Index = 30)]
        /* 0x2EC8 */ public NMSString0x20A MainMissionTitle;
        [NMS(Index = 9)]
        /* 0x2EE8 */ public NMSString0x20A MilestoneWithStageLocId;
        [NMS(Index = 28)]
        /* 0x2F08 */ public NMSString0x20A SeasonName;
        [NMS(Index = 29)]
        /* 0x2F28 */ public NMSString0x20A SeasonNameUpper;
        [NMS(Index = 24)]
        /* 0x2F48 */ public TkTextureResource MainIcon;
        [NMS(Index = 64)]
        /* 0x2F60 */ public GcInventoryLayout ShipInventoryLayout;
        [NMS(Index = 65)]
        /* 0x2F78 */ public GcInventoryLayout ShipTechInventoryLayout;
        [NMS(Index = 63)]
        /* 0x2F90 */ public GcInventoryLayout WeaponInventoryLayout;
        [NMS(Index = 39)]
        /* 0x2FA8 */ public List<NMSString0x10> AdditionalTradeProducts;
        [NMS(Index = 16)]
        /* 0x2FB8 */ public NMSString0x10 CreateContextSaveDataMask;
        [NMS(Index = 20)]
        /* 0x2FC8 */ public NMSString0x10 FinalReward;
        [NMS(Index = 21)]
        /* 0x2FD8 */ public NMSString0x10 FinalRewardSwitchAlt;
        [NMS(Index = 41)]
        /* 0x2FE8 */ public List<int> ForceBlackHolesAtPartyUAs;
        [NMS(Index = 99)]
        /* 0x2FF8 */ public List<NMSString0x10> ForgottenProducts;
        [NMS(Index = 52)]
        /* 0x3008 */ public VariableSizeString FreighterBaseOverrideFilename;
        [NMS(Index = 60)]
        /* 0x3018 */ public NMSString0x10 IntroSequencePOI;
        [NMS(Index = 98)]
        /* 0x3028 */ public List<NMSString0x10> NeverLearnableTech;
        [NMS(Index = 40)]
        /* 0x3038 */ public List<NMSString0x10> NeverTradeProducts;
        [NMS(Index = 54)]
        /* 0x3048 */ public VariableSizeString OverrideFreighterFilename;
        [NMS(Index = 50)]
        /* 0x3058 */ public VariableSizeString OverrideMTFilename;
        [NMS(Index = 113)]
        /* 0x3068 */ public List<GcProductData> ProductTable;
        [NMS(Index = 74)]
        /* 0x3078 */ public List<GcSeasonPetConstraints> RandomPetConstraints;
        [NMS(Index = 77)]
        /* 0x3088 */ public List<GcSandwormTimerAndFrequencyOverride> SandwormOverrides;
        [NMS(Index = 107)]
        /* 0x3098 */ public GcScanEventTable ScanEventTable;
        [NMS(Index = 48)]
        /* 0x30A8 */ public GcSeed ShipSeed;
        [NMS(Index = 106)]
        /* 0x30B8 */ public List<GcSeasonalStage> Stages;
        [NMS(Index = 93)]
        /* 0x30C8 */ public NMSString0x10 StartPlanetRareSubstanceOverride;
        [NMS(Index = 109)]
        /* 0x30D8 */ public List<GcPersistedStatData> StatsToPersistOnReset;
        [NMS(Index = 114)]
        /* 0x30E8 */ public List<GcRealitySubstanceData> SubstanceTable;
        [NMS(Index = 17)]
        /* 0x30F8 */ public NMSString0x10 SwitchContextSaveDataMask;
        [NMS(Index = 112)]
        /* 0x3108 */ public List<GcTechnology> TechnologyTable;
        [NMS(Index = 62)]
        /* 0x3118 */ public List<GcBuildingClassification> ValidSpawnBuildings;
        [NMS(Index = 47)]
        /* 0x3128 */ public GcSeed WeaponSeed;
        [NMS(Index = 2)]
        /* 0x3138 */ public ulong EndTimeUTC;
        [NMS(Index = 3)]
        /* 0x3140 */ public ulong Hash;
        [NMS(Index = 1)]
        /* 0x3148 */ public ulong StartTimeUTC;
        [NMS(Index = 19)]
        /* 0x3150 */ public ulong UAOverrideValue;
        [NMS(Index = 15)]
        /* 0x3158 */ public GcDifficultySettingsData DifficultyMinimums;
        [NMS(Index = 101)]
        /* 0x31B8 */ public float AbandonedFreighterHazardProtectionMul;
        [NMS(Index = 84)]
        /* 0x31BC */ public float BuildingRadiusShipOffsetMultiplier;
        [NMS(Index = 14)]
        /* 0x31C0 */ public GcDifficultyPresetType DifficultySettingPreset;
        [NMS(Index = 27)]
        /* 0x31C4 */ public int DisplayNumber;
        [NMS(Index = 83)]
        /* 0x31C8 */ public float DistanceFromShipAtStartOfGame;
        [NMS(Index = 104)]
        /* 0x31CC */ public float EnergyDrainMultiplier;
        [NMS(Index = 102)]
        /* 0x31D0 */ public float FarmPlantsTimerMul;
        [NMS(Index = 95)]
        /* 0x31D4 */ public int FreighterBattleEarlyWarpsOverride;
        [NMS(Index = 53)]
        /* 0x31D8 */ public GcAlienRace FreighterRace;
        [NMS(Index = 13)]
        /* 0x31DC */ public GcGameMode GameMode;
        [NMS(Index = 103)]
        /* 0x31E0 */ public float HazardProtectionDrainMultiplier;
        [NMS(Index = 105)]
        /* 0x31E4 */ public int QuestSubstanceReducer;
        [NMS(Index = 26)]
        /* 0x31E8 */ public int RemixNumber;
        [NMS(Index = 80)]
        /* 0x31EC */ public float SandwormGlobalOverrideSpawnChance;
        [NMS(Index = 79)]
        /* 0x31F0 */ public float SandwormGlobalOverrideTimer;
        [NMS(Index = 0)]
        /* 0x31F4 */ public int SeasonId;
        [NMS(Index = 25)]
        /* 0x31F8 */ public int SeasonNumber;
        [NMS(Index = 10)]
        /* 0x31FC */ public GcAudioWwiseEvents SeasonStartMusicOverride;
        [NMS(Index = 49)]
        /* 0x3200 */ public GcSpaceshipClasses ShipType;
        [NMS(Index = 76)]
        /* 0x3204 */ public int StartingPetSlots;
        [NMS(Index = 46)]
        /* 0x3208 */ public int StartingSuitCargoSlots;
        [NMS(Index = 44)]
        /* 0x320C */ public int StartingSuitSlots;
        [NMS(Index = 45)]
        /* 0x3210 */ public int StartingSuitTechSlots;
        [NMS(Index = 121)]
        /* 0x3214 */ public GcScreenFilters StartingUAScreenFilter;
        [NMS(Index = 97)]
        /* 0x3218 */ public int TechCostMultiplier;
        [NMS(Index = 23)]
        /* 0x321C */ public NMSString0x200 FinalRewardDescription;
        [NMS(Index = 6)]
        /* 0x341C */ public NMSString0x20 Description;
        [NMS(Index = 18)]
        /* 0x343C */ public NMSString0x20 SeasonalUAOverride;
        [NMS(Index = 5)]
        /* 0x345C */ public NMSString0x20 Subtitle;
        [NMS(Index = 7)]
        /* 0x347C */ public NMSString0x20 Summary;
        [NMS(Index = 4)]
        /* 0x349C */ public NMSString0x20 Title;
        [NMS(Index = 91)]
        /* 0x34BC */ public bool AllowMissionDetailMessages;
        [NMS(Index = 124)]
        /* 0x34BD */ public bool AllowOnlyCorvetteShipPurchases;
        [NMS(Index = 125)]
        /* 0x34BE */ public bool AllowSaveContextMultitoolTransfer;
        [NMS(Index = 126)]
        /* 0x34BF */ public bool AllowSaveContextShipTransfer;
        [NMS(Index = 87)]
        /* 0x34C0 */ public bool AlwaysStormy;
        [NMS(Index = 117)]
        /* 0x34C1 */ public bool AlwaysUseSeasonalStationTradeData;
        [NMS(Index = 88)]
        /* 0x34C2 */ public bool BlockAggressiveSentinelsInStartSystem;
        [NMS(Index = 89)]
        /* 0x34C3 */ public bool BlockExtremeWeatherInStartSystem;
        [NMS(Index = 12)]
        /* 0x34C4 */ public bool BlockFirstSpaceMusic;
        [NMS(Index = 86)]
        /* 0x34C5 */ public bool BlockStormsAtStart;
        [NMS(Index = 61)]
        /* 0x34C6 */ public bool CarnageMode;
        [NMS(Index = 110)]
        /* 0x34C7 */ public bool CompatibleWithState;
        [NMS(Index = 37)]
        /* 0x34C8 */ public bool DefaultToPvPOff;
        [NMS(Index = 32)]
        /* 0x34C9 */ public bool DoCommunityMissionTextSubstitutions;
        [NMS(Index = 59)]
        /* 0x34CA */ public bool ForceAllSentinelsAggressive;
        [NMS(Index = 58)]
        /* 0x34CB */ public bool ForceAllSystemsAbandoned;
        [NMS(Index = 96)]
        /* 0x34CC */ public bool ForceDeepSpaceAmbientFrigatesOnInfested;
        [NMS(Index = 57)]
        /* 0x34CD */ public bool ForceStartSystemAbandoned;
        [NMS(Index = 56)]
        /* 0x34CE */ public bool ForceStartSystemTernary;
        [NMS(Index = 111)]
        /* 0x34CF */ public bool HasBeenConverted;
        [NMS(Index = 100)]
        /* 0x34D0 */ public bool IncreaseXClassTechOddsWithCommTier;
        [NMS(Index = 38)]
        /* 0x34D1 */ public bool MustCraftInBases;
        [NMS(Index = 123)]
        /* 0x34D2 */ public bool OnlyCorvetteLauncherCanBeRepaired;
        [NMS(Index = 122)]
        /* 0x34D3 */ public bool OnlyCorvettesSpawnWhenPlayerTeleports;
        [NMS(Index = 120)]
        /* 0x34D4 */ public bool OverrideStartingUAScreenFilter;
        [NMS(Index = 11)]
        /* 0x34D5 */ public bool PlayStartMusicInIntro;
        [NMS(Index = 119)]
        /* 0x34D6 */ public bool PurpleSystemsUnlocked;
        [NMS(Index = 108)]
        /* 0x34D7 */ public bool ResetSaveOnDeath;
        [NMS(Index = 78)]
        /* 0x34D8 */ public bool SandwormGlobalOverride;
        [NMS(Index = 82)]
        /* 0x34D9 */ public bool ShipIsAtDifferentBuildingToPlayer;
        [NMS(Index = 85)]
        /* 0x34DA */ public bool ShipStartsDamaged;
        [NMS(Index = 55)]
        /* 0x34DB */ public bool StartAboardFreighter;
        [NMS(Index = 81)]
        /* 0x34DC */ public bool StartNextToShip;
        [NMS(Index = 51)]
        /* 0x34DD */ public bool StartWithFreighter;
        [NMS(Index = 94)]
        /* 0x34DE */ public bool TrashInventoryOnGalaxyTravel;
        [NMS(Index = 66)]
        /* 0x34DF */ public bool UseDefaultAppearance;
        [NMS(Index = 73)]
        /* 0x34E0 */ public bool UseRandomPet;
        [NMS(Index = 116)]
        /* 0x34E1 */ public bool UseSeasonalUAStationTradeData;
        [NMS(Index = 118)]
        /* 0x34E2 */ public bool UseSpookHazardOnly;
        [NMS(Index = 92)]
        /* 0x34E3 */ public bool UseStartPlanetObjectListOverrides;
    }
}
