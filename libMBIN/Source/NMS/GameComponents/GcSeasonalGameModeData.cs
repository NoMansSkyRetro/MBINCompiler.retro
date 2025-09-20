using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD2A001748393D870, NameHash = 0xC2909BE6)]
    public class GcSeasonalGameModeData : NMSTemplate
    {
        [NMS(Index = 74, Size = 0x12)]
        /* 0x0000 */ public GcPetData[] SpecificPets;
        [NMS(Index = 66)]
        /* 0x2490 */ public GcInventoryContainer Inventory;
        [NMS(Index = 68)]
        /* 0x25F0 */ public GcInventoryContainer Inventory_Cargo;
        [NMS(Index = 67)]
        /* 0x2750 */ public GcInventoryContainer Inventory_TechOnly;
        [NMS(Index = 69)]
        /* 0x28B0 */ public GcInventoryContainer ShipInventory;
        [NMS(Index = 70)]
        /* 0x2A10 */ public GcInventoryContainer WeaponInventory;
        [NMS(Index = 113)]
        /* 0x2B70 */ public GcTradeData SeasonalUAStationTradeData;
        [NMS(Index = 41)]
        /* 0x2C58 */ public GcMissionSequenceDetailMessage InitialJoaoBox;
        [NMS(Index = 42)]
        /* 0x2CF0 */ public GcMissionSequenceDetailMessage InitialJoaoBoxNoMainSave;
        [NMS(Index = 71)]
        /* 0x2D88 */ public GcSeasonTransferInventoryConfig SeasonTransferInventoryConfig;
        [NMS(Index = 33)]
        /* 0x2DB8 */ public NMSString0x20A CommunityProgressTitle;
        [NMS(Index = 36)]
        /* 0x2DD8 */ public NMSString0x20A CommunityTierCompleteLabel;
        [NMS(Index = 34)]
        /* 0x2DF8 */ public NMSString0x20A CommunityTierLabel;
        [NMS(Index = 35)]
        /* 0x2E18 */ public NMSString0x20A CommunityTierProgressLabel;
        [NMS(Index = 22)]
        /* 0x2E38 */ public NMSString0x20A FinalCantRewardMessage;
        [NMS(Index = 8)]
        /* 0x2E58 */ public NMSString0x20A FinalStageTitle;
        [NMS(Index = 31)]
        /* 0x2E78 */ public NMSString0x20A MainMissionMessage;
        [NMS(Index = 30)]
        /* 0x2E98 */ public NMSString0x20A MainMissionTitle;
        [NMS(Index = 9)]
        /* 0x2EB8 */ public NMSString0x20A MilestoneWithStageLocId;
        [NMS(Index = 28)]
        /* 0x2ED8 */ public NMSString0x20A SeasonName;
        [NMS(Index = 29)]
        /* 0x2EF8 */ public NMSString0x20A SeasonNameUpper;
        [NMS(Index = 24)]
        /* 0x2F18 */ public TkTextureResource MainIcon;
        [NMS(Index = 63)]
        /* 0x2F30 */ public GcInventoryLayout ShipInventoryLayout;
        [NMS(Index = 64)]
        /* 0x2F48 */ public GcInventoryLayout ShipTechInventoryLayout;
        [NMS(Index = 62)]
        /* 0x2F60 */ public GcInventoryLayout WeaponInventoryLayout;
        [NMS(Index = 39)]
        /* 0x2F78 */ public List<NMSString0x10> AdditionalTradeProducts;
        [NMS(Index = 16)]
        /* 0x2F88 */ public NMSString0x10 CreateContextSaveDataMask;
        [NMS(Index = 20)]
        /* 0x2F98 */ public NMSString0x10 FinalReward;
        [NMS(Index = 21)]
        /* 0x2FA8 */ public NMSString0x10 FinalRewardSwitchAlt;
        [NMS(Index = 97)]
        /* 0x2FB8 */ public List<NMSString0x10> ForgottenProducts;
        [NMS(Index = 51)]
        /* 0x2FC8 */ public VariableSizeString FreighterBaseOverrideFilename;
        [NMS(Index = 59)]
        /* 0x2FD8 */ public NMSString0x10 IntroSequencePOI;
        [NMS(Index = 96)]
        /* 0x2FE8 */ public List<NMSString0x10> NeverLearnableTech;
        [NMS(Index = 40)]
        /* 0x2FF8 */ public List<NMSString0x10> NeverTradeProducts;
        [NMS(Index = 53)]
        /* 0x3008 */ public VariableSizeString OverrideFreighterFilename;
        [NMS(Index = 49)]
        /* 0x3018 */ public VariableSizeString OverrideMTFilename;
        [NMS(Index = 111)]
        /* 0x3028 */ public List<GcProductData> ProductTable;
        [NMS(Index = 73)]
        /* 0x3038 */ public List<GcSeasonPetConstraints> RandomPetConstraints;
        [NMS(Index = 76)]
        /* 0x3048 */ public List<GcSandwormTimerAndFrequencyOverride> SandwormOverrides;
        [NMS(Index = 105)]
        /* 0x3058 */ public GcScanEventTable ScanEventTable;
        [NMS(Index = 47)]
        /* 0x3068 */ public GcSeed ShipSeed;
        [NMS(Index = 104)]
        /* 0x3078 */ public List<GcSeasonalStage> Stages;
        [NMS(Index = 91)]
        /* 0x3088 */ public NMSString0x10 StartPlanetRareSubstanceOverride;
        [NMS(Index = 107)]
        /* 0x3098 */ public List<GcPersistedStatData> StatsToPersistOnReset;
        [NMS(Index = 112)]
        /* 0x30A8 */ public List<GcRealitySubstanceData> SubstanceTable;
        [NMS(Index = 17)]
        /* 0x30B8 */ public NMSString0x10 SwitchContextSaveDataMask;
        [NMS(Index = 110)]
        /* 0x30C8 */ public List<GcTechnology> TechnologyTable;
        [NMS(Index = 61)]
        /* 0x30D8 */ public List<GcBuildingClassification> ValidSpawnBuildings;
        [NMS(Index = 46)]
        /* 0x30E8 */ public GcSeed WeaponSeed;
        [NMS(Index = 2)]
        /* 0x30F8 */ public ulong EndTimeUTC;
        [NMS(Index = 3)]
        /* 0x3100 */ public ulong Hash;
        [NMS(Index = 1)]
        /* 0x3108 */ public ulong StartTimeUTC;
        [NMS(Index = 19)]
        /* 0x3110 */ public ulong UAOverrideValue;
        [NMS(Index = 15)]
        /* 0x3118 */ public GcDifficultySettingsData DifficultyMinimums;
        [NMS(Index = 99)]
        /* 0x3178 */ public float AbandonedFreighterHazardProtectionMul;
        [NMS(Index = 83)]
        /* 0x317C */ public float BuildingRadiusShipOffsetMultiplier;
        [NMS(Index = 14)]
        /* 0x3180 */ public GcDifficultyPresetType DifficultySettingPreset;
        [NMS(Index = 27)]
        /* 0x3184 */ public int DisplayNumber;
        [NMS(Index = 82)]
        /* 0x3188 */ public float DistanceFromShipAtStartOfGame;
        [NMS(Index = 102)]
        /* 0x318C */ public float EnergyDrainMultiplier;
        [NMS(Index = 100)]
        /* 0x3190 */ public float FarmPlantsTimerMul;
        [NMS(Index = 93)]
        /* 0x3194 */ public int FreighterBattleEarlyWarpsOverride;
        [NMS(Index = 52)]
        /* 0x3198 */ public GcAlienRace FreighterRace;
        [NMS(Index = 13)]
        /* 0x319C */ public GcGameMode GameMode;
        [NMS(Index = 101)]
        /* 0x31A0 */ public float HazardProtectionDrainMultiplier;
        [NMS(Index = 103)]
        /* 0x31A4 */ public int QuestSubstanceReducer;
        [NMS(Index = 26)]
        /* 0x31A8 */ public int RemixNumber;
        [NMS(Index = 79)]
        /* 0x31AC */ public float SandwormGlobalOverrideSpawnChance;
        [NMS(Index = 78)]
        /* 0x31B0 */ public float SandwormGlobalOverrideTimer;
        [NMS(Index = 0)]
        /* 0x31B4 */ public int SeasonId;
        [NMS(Index = 25)]
        /* 0x31B8 */ public int SeasonNumber;
        [NMS(Index = 10)]
        /* 0x31BC */ public GcAudioWwiseEvents SeasonStartMusicOverride;
        [NMS(Index = 48)]
        /* 0x31C0 */ public GcSpaceshipClasses ShipType;
        [NMS(Index = 75)]
        /* 0x31C4 */ public int StartingPetSlots;
        [NMS(Index = 45)]
        /* 0x31C8 */ public int StartingSuitCargoSlots;
        [NMS(Index = 43)]
        /* 0x31CC */ public int StartingSuitSlots;
        [NMS(Index = 44)]
        /* 0x31D0 */ public int StartingSuitTechSlots;
        [NMS(Index = 95)]
        /* 0x31D4 */ public int TechCostMultiplier;
        [NMS(Index = 23)]
        /* 0x31D8 */ public NMSString0x200 FinalRewardDescription;
        [NMS(Index = 6)]
        /* 0x33D8 */ public NMSString0x20 Description;
        [NMS(Index = 18)]
        /* 0x33F8 */ public NMSString0x20 SeasonalUAOverride;
        [NMS(Index = 5)]
        /* 0x3418 */ public NMSString0x20 Subtitle;
        [NMS(Index = 7)]
        /* 0x3438 */ public NMSString0x20 Summary;
        [NMS(Index = 4)]
        /* 0x3458 */ public NMSString0x20 Title;
        [NMS(Index = 89)]
        /* 0x3478 */ public bool AllowMissionDetailMessages;
        [NMS(Index = 120)]
        /* 0x3479 */ public bool AllowOnlyCorvetteShipPurchases;
        [NMS(Index = 121)]
        /* 0x347A */ public bool AllowSaveContextMultitoolTransfer;
        [NMS(Index = 122)]
        /* 0x347B */ public bool AllowSaveContextShipTransfer;
        [NMS(Index = 86)]
        /* 0x347C */ public bool AlwaysStormy;
        [NMS(Index = 115)]
        /* 0x347D */ public bool AlwaysUseSeasonalStationTradeData;
        [NMS(Index = 87)]
        /* 0x347E */ public bool BlockAggressiveSentinelsInStartSystem;
        [NMS(Index = 88)]
        /* 0x347F */ public bool BlockExtremeWeatherInStartSystem;
        [NMS(Index = 12)]
        /* 0x3480 */ public bool BlockFirstSpaceMusic;
        [NMS(Index = 85)]
        /* 0x3481 */ public bool BlockStormsAtStart;
        [NMS(Index = 60)]
        /* 0x3482 */ public bool CarnageMode;
        [NMS(Index = 108)]
        /* 0x3483 */ public bool CompatibleWithState;
        [NMS(Index = 37)]
        /* 0x3484 */ public bool DefaultToPvPOff;
        [NMS(Index = 32)]
        /* 0x3485 */ public bool DoCommunityMissionTextSubstitutions;
        [NMS(Index = 58)]
        /* 0x3486 */ public bool ForceAllSentinelsAggressive;
        [NMS(Index = 57)]
        /* 0x3487 */ public bool ForceAllSystemsAbandoned;
        [NMS(Index = 94)]
        /* 0x3488 */ public bool ForceDeepSpaceAmbientFrigatesOnInfested;
        [NMS(Index = 56)]
        /* 0x3489 */ public bool ForceStartSystemAbandoned;
        [NMS(Index = 55)]
        /* 0x348A */ public bool ForceStartSystemTernary;
        [NMS(Index = 109)]
        /* 0x348B */ public bool HasBeenConverted;
        [NMS(Index = 98)]
        /* 0x348C */ public bool IncreaseXClassTechOddsWithCommTier;
        [NMS(Index = 38)]
        /* 0x348D */ public bool MustCraftInBases;
        [NMS(Index = 119)]
        /* 0x348E */ public bool OnlyCorvetteLauncherCanBeRepaired;
        [NMS(Index = 118)]
        /* 0x348F */ public bool OnlyCorvettesSpawnWhenPlayerTeleports;
        [NMS(Index = 11)]
        /* 0x3490 */ public bool PlayStartMusicInIntro;
        [NMS(Index = 117)]
        /* 0x3491 */ public bool PurpleSystemsUnlocked;
        [NMS(Index = 106)]
        /* 0x3492 */ public bool ResetSaveOnDeath;
        [NMS(Index = 77)]
        /* 0x3493 */ public bool SandwormGlobalOverride;
        [NMS(Index = 81)]
        /* 0x3494 */ public bool ShipIsAtDifferentBuildingToPlayer;
        [NMS(Index = 84)]
        /* 0x3495 */ public bool ShipStartsDamaged;
        [NMS(Index = 54)]
        /* 0x3496 */ public bool StartAboardFreighter;
        [NMS(Index = 80)]
        /* 0x3497 */ public bool StartNextToShip;
        [NMS(Index = 50)]
        /* 0x3498 */ public bool StartWithFreighter;
        [NMS(Index = 92)]
        /* 0x3499 */ public bool TrashInventoryOnGalaxyTravel;
        [NMS(Index = 65)]
        /* 0x349A */ public bool UseDefaultAppearance;
        [NMS(Index = 72)]
        /* 0x349B */ public bool UseRandomPet;
        [NMS(Index = 114)]
        /* 0x349C */ public bool UseSeasonalUAStationTradeData;
        [NMS(Index = 116)]
        /* 0x349D */ public bool UseSpookHazardOnly;
        [NMS(Index = 90)]
        /* 0x349E */ public bool UseStartPlanetObjectListOverrides;
    }
}
