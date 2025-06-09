using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFD2F5A4C560660AA, NameHash = 0xC2909BE6)]
    public class GcSeasonalGameModeData : NMSTemplate
    {
        [NMS(Index = 72, Size = 0x12)]
        /* 0x0000 */ public GcPetData[] SpecificPets;
        [NMS(Index = 64)]
        /* 0x2490 */ public GcInventoryContainer Inventory;
        [NMS(Index = 66)]
        /* 0x25E8 */ public GcInventoryContainer Inventory_Cargo;
        [NMS(Index = 65)]
        /* 0x2740 */ public GcInventoryContainer Inventory_TechOnly;
        [NMS(Index = 67)]
        /* 0x2898 */ public GcInventoryContainer ShipInventory;
        [NMS(Index = 68)]
        /* 0x29F0 */ public GcInventoryContainer WeaponInventory;
        [NMS(Index = 111)]
        /* 0x2B48 */ public GcTradeData SeasonalUAStationTradeData;
        [NMS(Index = 41)]
        /* 0x2C30 */ public GcMissionSequenceDetailMessage InitialJoaoBox;
        [NMS(Index = 42)]
        /* 0x2CC8 */ public GcMissionSequenceDetailMessage InitialJoaoBoxNoMainSave;
        [NMS(Index = 69)]
        /* 0x2D60 */ public GcSeasonTransferInventoryConfig SeasonTransferInventoryConfig;
        [NMS(Index = 33)]
        /* 0x2D90 */ public NMSString0x20A CommunityProgressTitle;
        [NMS(Index = 36)]
        /* 0x2DB0 */ public NMSString0x20A CommunityTierCompleteLabel;
        [NMS(Index = 34)]
        /* 0x2DD0 */ public NMSString0x20A CommunityTierLabel;
        [NMS(Index = 35)]
        /* 0x2DF0 */ public NMSString0x20A CommunityTierProgressLabel;
        [NMS(Index = 22)]
        /* 0x2E10 */ public NMSString0x20A FinalCantRewardMessage;
        [NMS(Index = 8)]
        /* 0x2E30 */ public NMSString0x20A FinalStageTitle;
        [NMS(Index = 31)]
        /* 0x2E50 */ public NMSString0x20A MainMissionMessage;
        [NMS(Index = 30)]
        /* 0x2E70 */ public NMSString0x20A MainMissionTitle;
        [NMS(Index = 9)]
        /* 0x2E90 */ public NMSString0x20A MilestoneWithStageLocId;
        [NMS(Index = 28)]
        /* 0x2EB0 */ public NMSString0x20A SeasonName;
        [NMS(Index = 29)]
        /* 0x2ED0 */ public NMSString0x20A SeasonNameUpper;
        [NMS(Index = 24)]
        /* 0x2EF0 */ public TkTextureResource MainIcon;
        [NMS(Index = 61)]
        /* 0x2F08 */ public GcInventoryLayout ShipInventoryLayout;
        [NMS(Index = 62)]
        /* 0x2F20 */ public GcInventoryLayout ShipTechInventoryLayout;
        [NMS(Index = 60)]
        /* 0x2F38 */ public GcInventoryLayout WeaponInventoryLayout;
        [NMS(Index = 39)]
        /* 0x2F50 */ public List<NMSString0x10> AdditionalTradeProducts;
        [NMS(Index = 16)]
        /* 0x2F60 */ public NMSString0x10 CreateContextSaveDataMask;
        [NMS(Index = 20)]
        /* 0x2F70 */ public NMSString0x10 FinalReward;
        [NMS(Index = 21)]
        /* 0x2F80 */ public NMSString0x10 FinalRewardSwitchAlt;
        [NMS(Index = 95)]
        /* 0x2F90 */ public List<NMSString0x10> ForgottenProducts;
        [NMS(Index = 51)]
        /* 0x2FA0 */ public VariableSizeString FreighterBaseOverrideFilename;
        [NMS(Index = 57)]
        /* 0x2FB0 */ public NMSString0x10 IntroSequencePOI;
        [NMS(Index = 94)]
        /* 0x2FC0 */ public List<NMSString0x10> NeverLearnableTech;
        [NMS(Index = 40)]
        /* 0x2FD0 */ public List<NMSString0x10> NeverTradeProducts;
        [NMS(Index = 49)]
        /* 0x2FE0 */ public VariableSizeString OverrideMTFilename;
        [NMS(Index = 109)]
        /* 0x2FF0 */ public List<GcProductData> ProductTable;
        [NMS(Index = 71)]
        /* 0x3000 */ public List<GcSeasonPetConstraints> RandomPetConstraints;
        [NMS(Index = 74)]
        /* 0x3010 */ public List<GcSandwormTimerAndFrequencyOverride> SandwormOverrides;
        [NMS(Index = 103)]
        /* 0x3020 */ public GcScanEventTable ScanEventTable;
        [NMS(Index = 47)]
        /* 0x3030 */ public GcSeed ShipSeed;
        [NMS(Index = 102)]
        /* 0x3040 */ public List<GcSeasonalStage> Stages;
        [NMS(Index = 89)]
        /* 0x3050 */ public NMSString0x10 StartPlanetRareSubstanceOverride;
        [NMS(Index = 105)]
        /* 0x3060 */ public List<GcPersistedStatData> StatsToPersistOnReset;
        [NMS(Index = 110)]
        /* 0x3070 */ public List<GcRealitySubstanceData> SubstanceTable;
        [NMS(Index = 17)]
        /* 0x3080 */ public NMSString0x10 SwitchContextSaveDataMask;
        [NMS(Index = 108)]
        /* 0x3090 */ public List<GcTechnology> TechnologyTable;
        [NMS(Index = 59)]
        /* 0x30A0 */ public List<GcBuildingClassification> ValidSpawnBuildings;
        [NMS(Index = 46)]
        /* 0x30B0 */ public GcSeed WeaponSeed;
        [NMS(Index = 2)]
        /* 0x30C0 */ public ulong EndTimeUTC;
        [NMS(Index = 3)]
        /* 0x30C8 */ public ulong Hash;
        [NMS(Index = 1)]
        /* 0x30D0 */ public ulong StartTimeUTC;
        [NMS(Index = 19)]
        /* 0x30D8 */ public ulong UAOverrideValue;
        [NMS(Index = 15)]
        /* 0x30E0 */ public GcDifficultySettingsData DifficultyMinimums;
        [NMS(Index = 97)]
        /* 0x3140 */ public float AbandonedFreighterHazardProtectionMul;
        [NMS(Index = 81)]
        /* 0x3144 */ public float BuildingRadiusShipOffsetMultiplier;
        [NMS(Index = 14)]
        /* 0x3148 */ public GcDifficultyPresetType DifficultySettingPreset;
        [NMS(Index = 27)]
        /* 0x314C */ public int DisplayNumber;
        [NMS(Index = 80)]
        /* 0x3150 */ public float DistanceFromShipAtStartOfGame;
        [NMS(Index = 100)]
        /* 0x3154 */ public float EnergyDrainMultiplier;
        [NMS(Index = 98)]
        /* 0x3158 */ public float FarmPlantsTimerMul;
        [NMS(Index = 91)]
        /* 0x315C */ public int FreighterBattleEarlyWarpsOverride;
        [NMS(Index = 52)]
        /* 0x3160 */ public GcAlienRace FreighterRace;
        [NMS(Index = 13)]
        /* 0x3164 */ public GcGameMode GameMode;
        [NMS(Index = 99)]
        /* 0x3168 */ public float HazardProtectionDrainMultiplier;
        [NMS(Index = 101)]
        /* 0x316C */ public int QuestSubstanceReducer;
        [NMS(Index = 26)]
        /* 0x3170 */ public int RemixNumber;
        [NMS(Index = 77)]
        /* 0x3174 */ public float SandwormGlobalOverrideSpawnChance;
        [NMS(Index = 76)]
        /* 0x3178 */ public float SandwormGlobalOverrideTimer;
        [NMS(Index = 0)]
        /* 0x317C */ public int SeasonId;
        [NMS(Index = 25)]
        /* 0x3180 */ public int SeasonNumber;
        [NMS(Index = 10)]
        /* 0x3184 */ public GcAudioWwiseEvents SeasonStartMusicOverride;
        [NMS(Index = 48)]
        /* 0x3188 */ public GcSpaceshipClasses ShipType;
        [NMS(Index = 73)]
        /* 0x318C */ public int StartingPetSlots;
        [NMS(Index = 45)]
        /* 0x3190 */ public int StartingSuitCargoSlots;
        [NMS(Index = 43)]
        /* 0x3194 */ public int StartingSuitSlots;
        [NMS(Index = 44)]
        /* 0x3198 */ public int StartingSuitTechSlots;
        [NMS(Index = 93)]
        /* 0x319C */ public int TechCostMultiplier;
        [NMS(Index = 23)]
        /* 0x31A0 */ public NMSString0x200 FinalRewardDescription;
        [NMS(Index = 6)]
        /* 0x33A0 */ public NMSString0x20 Description;
        [NMS(Index = 18)]
        /* 0x33C0 */ public NMSString0x20 SeasonalUAOverride;
        [NMS(Index = 5)]
        /* 0x33E0 */ public NMSString0x20 Subtitle;
        [NMS(Index = 7)]
        /* 0x3400 */ public NMSString0x20 Summary;
        [NMS(Index = 4)]
        /* 0x3420 */ public NMSString0x20 Title;
        [NMS(Index = 87)]
        /* 0x3440 */ public bool AllowMissionDetailMessages;
        [NMS(Index = 84)]
        /* 0x3441 */ public bool AlwaysStormy;
        [NMS(Index = 113)]
        /* 0x3442 */ public bool AlwaysUseSeasonalStationTradeData;
        [NMS(Index = 85)]
        /* 0x3443 */ public bool BlockAggressiveSentinelsInStartSystem;
        [NMS(Index = 86)]
        /* 0x3444 */ public bool BlockExtremeWeatherInStartSystem;
        [NMS(Index = 12)]
        /* 0x3445 */ public bool BlockFirstSpaceMusic;
        [NMS(Index = 83)]
        /* 0x3446 */ public bool BlockStormsAtStart;
        [NMS(Index = 58)]
        /* 0x3447 */ public bool CarnageMode;
        [NMS(Index = 106)]
        /* 0x3448 */ public bool CompatibleWithState;
        [NMS(Index = 37)]
        /* 0x3449 */ public bool DefaultToPvPOff;
        [NMS(Index = 32)]
        /* 0x344A */ public bool DoCommunityMissionTextSubstitutions;
        [NMS(Index = 56)]
        /* 0x344B */ public bool ForceAllSystemsAbandoned;
        [NMS(Index = 92)]
        /* 0x344C */ public bool ForceDeepSpaceAmbientFrigatesOnInfested;
        [NMS(Index = 55)]
        /* 0x344D */ public bool ForceStartSystemAbandoned;
        [NMS(Index = 54)]
        /* 0x344E */ public bool ForceStartSystemTernary;
        [NMS(Index = 107)]
        /* 0x344F */ public bool HasBeenConverted;
        [NMS(Index = 96)]
        /* 0x3450 */ public bool IncreaseXClassTechOddsWithCommTier;
        [NMS(Index = 38)]
        /* 0x3451 */ public bool MustCraftInBases;
        [NMS(Index = 11)]
        /* 0x3452 */ public bool PlayStartMusicInIntro;
        [NMS(Index = 115)]
        /* 0x3453 */ public bool PurpleSystemsUnlocked;
        [NMS(Index = 104)]
        /* 0x3454 */ public bool ResetSaveOnDeath;
        [NMS(Index = 75)]
        /* 0x3455 */ public bool SandwormGlobalOverride;
        [NMS(Index = 79)]
        /* 0x3456 */ public bool ShipIsAtDifferentBuildingToPlayer;
        [NMS(Index = 82)]
        /* 0x3457 */ public bool ShipStartsDamaged;
        [NMS(Index = 53)]
        /* 0x3458 */ public bool StartAboardFreighter;
        [NMS(Index = 78)]
        /* 0x3459 */ public bool StartNextToShip;
        [NMS(Index = 50)]
        /* 0x345A */ public bool StartWithFreighter;
        [NMS(Index = 90)]
        /* 0x345B */ public bool TrashInventoryOnGalaxyTravel;
        [NMS(Index = 63)]
        /* 0x345C */ public bool UseDefaultAppearance;
        [NMS(Index = 70)]
        /* 0x345D */ public bool UseRandomPet;
        [NMS(Index = 112)]
        /* 0x345E */ public bool UseSeasonalUAStationTradeData;
        [NMS(Index = 114)]
        /* 0x345F */ public bool UseSpookHazardOnly;
        [NMS(Index = 88)]
        /* 0x3460 */ public bool UseStartPlanetObjectListOverrides;
    }
}
