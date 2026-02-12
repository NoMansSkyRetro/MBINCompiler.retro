using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC55B3447EE545778, NameHash = 0xC2909BE6)]
    public class GcSeasonalGameModeData : NMSTemplate
    {
        [NMS(Index = 76, Size = 0x12)]
        /* 0x0000 */ public GcPetData[] SpecificPets;
        [NMS(Index = 68)]
        /* 0x2490 */ public GcInventoryContainer Inventory;
        [NMS(Index = 70)]
        /* 0x25F0 */ public GcInventoryContainer Inventory_Cargo;
        [NMS(Index = 69)]
        /* 0x2750 */ public GcInventoryContainer Inventory_TechOnly;
        [NMS(Index = 71)]
        /* 0x28B0 */ public GcInventoryContainer ShipInventory;
        [NMS(Index = 72)]
        /* 0x2A10 */ public GcInventoryContainer WeaponInventory;
        [NMS(Index = 122)]
        /* 0x2B70 */ public GcTradeData SeasonalUAStationTradeData;
        [NMS(Index = 42)]
        /* 0x2C58 */ public GcMissionSequenceDetailMessage InitialJoaoBox;
        [NMS(Index = 43)]
        /* 0x2CF0 */ public GcMissionSequenceDetailMessage InitialJoaoBoxNoMainSave;
        [NMS(Index = 93, Size = 0x3, EnumType = typeof(GcExperienceBossType.ExperienceBossTypeEnum))]
        /* 0x2D88 */ public NMSString0x10[] AltBossRewards;
        [NMS(Index = 73)]
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
        [NMS(Index = 65)]
        /* 0x2F60 */ public GcInventoryLayout ShipInventoryLayout;
        [NMS(Index = 66)]
        /* 0x2F78 */ public GcInventoryLayout ShipTechInventoryLayout;
        [NMS(Index = 64)]
        /* 0x2F90 */ public GcInventoryLayout WeaponInventoryLayout;
        [NMS(Index = 105)]
        /* 0x2FA8 */ public List<NMSString0x10> AdditionalKnownProducts;
        [NMS(Index = 106)]
        /* 0x2FB8 */ public List<NMSString0x10> AdditionalKnownTech;
        [NMS(Index = 39)]
        /* 0x2FC8 */ public List<NMSString0x10> AdditionalTradeProducts;
        [NMS(Index = 131)]
        /* 0x2FD8 */ public GcSeed BlockShipRepairUntilMilestoneWithSeedComplete;
        [NMS(Index = 16)]
        /* 0x2FE8 */ public NMSString0x10 CreateContextSaveDataMask;
        [NMS(Index = 20)]
        /* 0x2FF8 */ public NMSString0x10 FinalReward;
        [NMS(Index = 21)]
        /* 0x3008 */ public NMSString0x10 FinalRewardSwitchAlt;
        [NMS(Index = 41)]
        /* 0x3018 */ public List<int> ForceBlackHolesAtPartyUAs;
        [NMS(Index = 103)]
        /* 0x3028 */ public List<NMSString0x10> ForgottenProducts;
        [NMS(Index = 104)]
        /* 0x3038 */ public List<NMSString0x10> ForgottenTech;
        [NMS(Index = 52)]
        /* 0x3048 */ public GcFilename FreighterBaseOverrideFilename;
        [NMS(Index = 60)]
        /* 0x3058 */ public NMSString0x10 IntroSequencePOI;
        [NMS(Index = 102)]
        /* 0x3068 */ public List<NMSString0x10> NeverLearnableTech;
        [NMS(Index = 40)]
        /* 0x3078 */ public List<NMSString0x10> NeverTradeProducts;
        [NMS(Index = 54)]
        /* 0x3088 */ public GcFilename OverrideFreighterFilename;
        [NMS(Index = 50)]
        /* 0x3098 */ public GcFilename OverrideMTFilename;
        [NMS(Index = 120)]
        /* 0x30A8 */ public List<GcProductData> ProductTable;
        [NMS(Index = 75)]
        /* 0x30B8 */ public List<GcSeasonPetConstraints> RandomPetConstraints;
        [NMS(Index = 78)]
        /* 0x30C8 */ public List<GcSandwormTimerAndFrequencyOverride> SandwormOverrides;
        [NMS(Index = 114)]
        /* 0x30D8 */ public GcScanEventTable ScanEventTable;
        [NMS(Index = 48)]
        /* 0x30E8 */ public GcSeed ShipSeed;
        [NMS(Index = 113)]
        /* 0x30F8 */ public List<GcSeasonalStage> Stages;
        [NMS(Index = 97)]
        /* 0x3108 */ public NMSString0x10 StartPlanetRareSubstanceOverride;
        [NMS(Index = 116)]
        /* 0x3118 */ public List<GcPersistedStatData> StatsToPersistOnReset;
        [NMS(Index = 121)]
        /* 0x3128 */ public List<GcRealitySubstanceData> SubstanceTable;
        [NMS(Index = 17)]
        /* 0x3138 */ public NMSString0x10 SwitchContextSaveDataMask;
        [NMS(Index = 119)]
        /* 0x3148 */ public List<GcTechnology> TechnologyTable;
        [NMS(Index = 62)]
        /* 0x3158 */ public List<GcBuildingClassification> ValidSpawnBuildings;
        [NMS(Index = 47)]
        /* 0x3168 */ public GcSeed WeaponSeed;
        [NMS(Index = 2)]
        /* 0x3178 */ public ulong EndTimeUTC;
        [NMS(Index = 3)]
        /* 0x3180 */ public ulong Hash;
        [NMS(Index = 1)]
        /* 0x3188 */ public ulong StartTimeUTC;
        [NMS(Index = 19)]
        /* 0x3190 */ public ulong UAOverrideValue;
        [NMS(Index = 15)]
        /* 0x3198 */ public GcDifficultySettingsData DifficultyMinimums;
        [NMS(Index = 91)]
        /* 0x31F8 */ public Vector2f CustomFrigateFlybyTimer;
        [NMS(Index = 92)]
        /* 0x3200 */ public Vector2f CustomPiratePlanetFlybyTimer;
        [NMS(Index = 108)]
        /* 0x3208 */ public float AbandonedFreighterHazardProtectionMul;
        [NMS(Index = 85)]
        /* 0x320C */ public float BuildingRadiusShipOffsetMultiplier;
        [NMS(Index = 14)]
        /* 0x3210 */ public GcDifficultyPresetType DifficultySettingPreset;
        [NMS(Index = 27)]
        /* 0x3214 */ public int DisplayNumber;
        [NMS(Index = 84)]
        /* 0x3218 */ public float DistanceFromShipAtStartOfGame;
        [NMS(Index = 111)]
        /* 0x321C */ public float EnergyDrainMultiplier;
        [NMS(Index = 109)]
        /* 0x3220 */ public float FarmPlantsTimerMul;
        [NMS(Index = 99)]
        /* 0x3224 */ public int FreighterBattleEarlyWarpsOverride;
        [NMS(Index = 53)]
        /* 0x3228 */ public GcAlienRace FreighterRace;
        [NMS(Index = 13)]
        /* 0x322C */ public GcGameMode GameMode;
        [NMS(Index = 110)]
        /* 0x3230 */ public float HazardProtectionDrainMultiplier;
        [NMS(Index = 112)]
        /* 0x3234 */ public int QuestSubstanceReducer;
        [NMS(Index = 26)]
        /* 0x3238 */ public int RemixNumber;
        [NMS(Index = 81)]
        /* 0x323C */ public float SandwormGlobalOverrideSpawnChance;
        [NMS(Index = 80)]
        /* 0x3240 */ public float SandwormGlobalOverrideTimer;
        [NMS(Index = 0)]
        /* 0x3244 */ public int SeasonId;
        [NMS(Index = 25)]
        /* 0x3248 */ public int SeasonNumber;
        [NMS(Index = 10)]
        /* 0x324C */ public GcAudioWwiseEvents SeasonStartMusicOverride;
        [NMS(Index = 49)]
        /* 0x3250 */ public GcSpaceshipClasses ShipType;
        [NMS(Index = 77)]
        /* 0x3254 */ public int StartingPetSlots;
        [NMS(Index = 46)]
        /* 0x3258 */ public int StartingSuitCargoSlots;
        [NMS(Index = 44)]
        /* 0x325C */ public int StartingSuitSlots;
        [NMS(Index = 45)]
        /* 0x3260 */ public int StartingSuitTechSlots;
        [NMS(Index = 128)]
        /* 0x3264 */ public GcScreenFilters StartingUAScreenFilter;
        [NMS(Index = 101)]
        /* 0x3268 */ public int TechCostMultiplier;
        [NMS(Index = 23)]
        /* 0x326C */ public NMSString0x200 FinalRewardDescription;
        [NMS(Index = 63)]
        /* 0x346C */ public NMSString0x80 UseSpawnBuildingNearUDA;
        [NMS(Index = 6)]
        /* 0x34EC */ public NMSString0x20 Description;
        [NMS(Index = 18)]
        /* 0x350C */ public NMSString0x20 SeasonalUAOverride;
        [NMS(Index = 5)]
        /* 0x352C */ public NMSString0x20 Subtitle;
        [NMS(Index = 7)]
        /* 0x354C */ public NMSString0x20 Summary;
        [NMS(Index = 4)]
        /* 0x356C */ public NMSString0x20 Title;
        [NMS(Index = 94)]
        /* 0x358C */ public bool AllowMissionDetailMessages;
        [NMS(Index = 133)]
        /* 0x358D */ public bool AllowOnlyCorvetteShipPurchases;
        [NMS(Index = 134)]
        /* 0x358E */ public bool AllowSaveContextMultitoolTransfer;
        [NMS(Index = 135)]
        /* 0x358F */ public bool AllowSaveContextShipTransfer;
        [NMS(Index = 88)]
        /* 0x3590 */ public bool AlwaysStormy;
        [NMS(Index = 124)]
        /* 0x3591 */ public bool AlwaysUseSeasonalStationTradeData;
        [NMS(Index = 89)]
        /* 0x3592 */ public bool BlockAggressiveSentinelsInStartSystem;
        [NMS(Index = 90)]
        /* 0x3593 */ public bool BlockExtremeWeatherInStartSystem;
        [NMS(Index = 12)]
        /* 0x3594 */ public bool BlockFirstSpaceMusic;
        [NMS(Index = 87)]
        /* 0x3595 */ public bool BlockStormsAtStart;
        [NMS(Index = 61)]
        /* 0x3596 */ public bool CarnageMode;
        [NMS(Index = 117)]
        /* 0x3597 */ public bool CompatibleWithState;
        [NMS(Index = 37)]
        /* 0x3598 */ public bool DefaultToPvPOff;
        [NMS(Index = 32)]
        /* 0x3599 */ public bool DoCommunityMissionTextSubstitutions;
        [NMS(Index = 59)]
        /* 0x359A */ public bool ForceAllSentinelsAggressive;
        [NMS(Index = 58)]
        /* 0x359B */ public bool ForceAllSystemsAbandoned;
        [NMS(Index = 100)]
        /* 0x359C */ public bool ForceDeepSpaceAmbientFrigatesOnInfested;
        [NMS(Index = 96)]
        /* 0x359D */ public bool ForceStartPlanetToHaveScrap;
        [NMS(Index = 57)]
        /* 0x359E */ public bool ForceStartSystemAbandoned;
        [NMS(Index = 56)]
        /* 0x359F */ public bool ForceStartSystemTernary;
        [NMS(Index = 118)]
        /* 0x35A0 */ public bool HasBeenConverted;
        [NMS(Index = 107)]
        /* 0x35A1 */ public bool IncreaseXClassTechOddsWithCommTier;
        [NMS(Index = 38)]
        /* 0x35A2 */ public bool MustCraftInBases;
        [NMS(Index = 132)]
        /* 0x35A3 */ public bool NeverAllowShipPurchases;
        [NMS(Index = 130)]
        /* 0x35A4 */ public bool OnlyCorvetteLauncherCanBeRepaired;
        [NMS(Index = 129)]
        /* 0x35A5 */ public bool OnlyCorvettesSpawnWhenPlayerTeleports;
        [NMS(Index = 127)]
        /* 0x35A6 */ public bool OverrideStartingUAScreenFilter;
        [NMS(Index = 11)]
        /* 0x35A7 */ public bool PlayStartMusicInIntro;
        [NMS(Index = 126)]
        /* 0x35A8 */ public bool PurpleSystemsUnlocked;
        [NMS(Index = 115)]
        /* 0x35A9 */ public bool ResetSaveOnDeath;
        [NMS(Index = 79)]
        /* 0x35AA */ public bool SandwormGlobalOverride;
        [NMS(Index = 83)]
        /* 0x35AB */ public bool ShipIsAtDifferentBuildingToPlayer;
        [NMS(Index = 86)]
        /* 0x35AC */ public bool ShipStartsDamaged;
        [NMS(Index = 55)]
        /* 0x35AD */ public bool StartAboardFreighter;
        [NMS(Index = 82)]
        /* 0x35AE */ public bool StartNextToShip;
        [NMS(Index = 51)]
        /* 0x35AF */ public bool StartWithFreighter;
        [NMS(Index = 98)]
        /* 0x35B0 */ public bool TrashInventoryOnGalaxyTravel;
        [NMS(Index = 67)]
        /* 0x35B1 */ public bool UseDefaultAppearance;
        [NMS(Index = 74)]
        /* 0x35B2 */ public bool UseRandomPet;
        [NMS(Index = 123)]
        /* 0x35B3 */ public bool UseSeasonalUAStationTradeData;
        [NMS(Index = 125)]
        /* 0x35B4 */ public bool UseSpookHazardOnly;
        [NMS(Index = 95)]
        /* 0x35B5 */ public bool UseStartPlanetObjectListOverrides;
    }
}
