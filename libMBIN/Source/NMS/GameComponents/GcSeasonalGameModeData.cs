using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x42AB277F69C3B6FF, NameHash = 0xC2909BE6)]
    public class GcSeasonalGameModeData : NMSTemplate
    {
        [NMS(Index = 76, Size = 0x1E)]
        /* 0x0000 */ public GcPetData[] SpecificPets;
        [NMS(Index = 68)]
        /* 0x4FB0 */ public GcInventoryContainer Inventory;
        [NMS(Index = 70)]
        /* 0x5110 */ public GcInventoryContainer Inventory_Cargo;
        [NMS(Index = 69)]
        /* 0x5270 */ public GcInventoryContainer Inventory_TechOnly;
        [NMS(Index = 71)]
        /* 0x53D0 */ public GcInventoryContainer ShipInventory;
        [NMS(Index = 72)]
        /* 0x5530 */ public GcInventoryContainer WeaponInventory;
        [NMS(Index = 122)]
        /* 0x5690 */ public GcTradeData SeasonalUAStationTradeData;
        [NMS(Index = 42)]
        /* 0x5778 */ public GcMissionSequenceDetailMessage InitialJoaoBox;
        [NMS(Index = 43)]
        /* 0x5810 */ public GcMissionSequenceDetailMessage InitialJoaoBoxNoMainSave;
        [NMS(Index = 93, Size = 0x3, EnumType = typeof(GcExperienceBossType.ExperienceBossTypeEnum))]
        /* 0x58A8 */ public NMSString0x10[] AltBossRewards;
        [NMS(Index = 73)]
        /* 0x58D8 */ public GcSeasonTransferInventoryConfig SeasonTransferInventoryConfig;
        [NMS(Index = 33)]
        /* 0x5908 */ public NMSString0x20A CommunityProgressTitle;
        [NMS(Index = 36)]
        /* 0x5928 */ public NMSString0x20A CommunityTierCompleteLabel;
        [NMS(Index = 34)]
        /* 0x5948 */ public NMSString0x20A CommunityTierLabel;
        [NMS(Index = 35)]
        /* 0x5968 */ public NMSString0x20A CommunityTierProgressLabel;
        [NMS(Index = 22)]
        /* 0x5988 */ public NMSString0x20A FinalCantRewardMessage;
        [NMS(Index = 8)]
        /* 0x59A8 */ public NMSString0x20A FinalStageTitle;
        [NMS(Index = 31)]
        /* 0x59C8 */ public NMSString0x20A MainMissionMessage;
        [NMS(Index = 30)]
        /* 0x59E8 */ public NMSString0x20A MainMissionTitle;
        [NMS(Index = 9)]
        /* 0x5A08 */ public NMSString0x20A MilestoneWithStageLocId;
        [NMS(Index = 28)]
        /* 0x5A28 */ public NMSString0x20A SeasonName;
        [NMS(Index = 29)]
        /* 0x5A48 */ public NMSString0x20A SeasonNameUpper;
        [NMS(Index = 24)]
        /* 0x5A68 */ public TkTextureResource MainIcon;
        [NMS(Index = 65)]
        /* 0x5A80 */ public GcInventoryLayout ShipInventoryLayout;
        [NMS(Index = 66)]
        /* 0x5A98 */ public GcInventoryLayout ShipTechInventoryLayout;
        [NMS(Index = 64)]
        /* 0x5AB0 */ public GcInventoryLayout WeaponInventoryLayout;
        [NMS(Index = 105)]
        /* 0x5AC8 */ public List<NMSString0x10> AdditionalKnownProducts;
        [NMS(Index = 106)]
        /* 0x5AD8 */ public List<NMSString0x10> AdditionalKnownTech;
        [NMS(Index = 39)]
        /* 0x5AE8 */ public List<NMSString0x10> AdditionalTradeProducts;
        [NMS(Index = 131)]
        /* 0x5AF8 */ public GcSeed BlockShipRepairUntilMilestoneWithSeedComplete;
        [NMS(Index = 16)]
        /* 0x5B08 */ public NMSString0x10 CreateContextSaveDataMask;
        [NMS(Index = 20)]
        /* 0x5B18 */ public NMSString0x10 FinalReward;
        [NMS(Index = 21)]
        /* 0x5B28 */ public NMSString0x10 FinalRewardSwitchAlt;
        [NMS(Index = 41)]
        /* 0x5B38 */ public List<int> ForceBlackHolesAtPartyUAs;
        [NMS(Index = 103)]
        /* 0x5B48 */ public List<NMSString0x10> ForgottenProducts;
        [NMS(Index = 104)]
        /* 0x5B58 */ public List<NMSString0x10> ForgottenTech;
        [NMS(Index = 52)]
        /* 0x5B68 */ public GcFilename FreighterBaseOverrideFilename;
        [NMS(Index = 60)]
        /* 0x5B78 */ public NMSString0x10 IntroSequencePOI;
        [NMS(Index = 102)]
        /* 0x5B88 */ public List<NMSString0x10> NeverLearnableTech;
        [NMS(Index = 40)]
        /* 0x5B98 */ public List<NMSString0x10> NeverTradeProducts;
        [NMS(Index = 54)]
        /* 0x5BA8 */ public GcFilename OverrideFreighterFilename;
        [NMS(Index = 50)]
        /* 0x5BB8 */ public GcFilename OverrideMTFilename;
        [NMS(Index = 120)]
        /* 0x5BC8 */ public List<GcProductData> ProductTable;
        [NMS(Index = 75)]
        /* 0x5BD8 */ public List<GcSeasonPetConstraints> RandomPetConstraints;
        [NMS(Index = 78)]
        /* 0x5BE8 */ public List<GcSandwormTimerAndFrequencyOverride> SandwormOverrides;
        [NMS(Index = 114)]
        /* 0x5BF8 */ public GcScanEventTable ScanEventTable;
        [NMS(Index = 48)]
        /* 0x5C08 */ public GcSeed ShipSeed;
        [NMS(Index = 113)]
        /* 0x5C18 */ public List<GcSeasonalStage> Stages;
        [NMS(Index = 97)]
        /* 0x5C28 */ public NMSString0x10 StartPlanetRareSubstanceOverride;
        [NMS(Index = 116)]
        /* 0x5C38 */ public List<GcPersistedStatData> StatsToPersistOnReset;
        [NMS(Index = 121)]
        /* 0x5C48 */ public List<GcRealitySubstanceData> SubstanceTable;
        [NMS(Index = 17)]
        /* 0x5C58 */ public NMSString0x10 SwitchContextSaveDataMask;
        [NMS(Index = 119)]
        /* 0x5C68 */ public List<GcTechnology> TechnologyTable;
        [NMS(Index = 62)]
        /* 0x5C78 */ public List<GcBuildingClassification> ValidSpawnBuildings;
        [NMS(Index = 47)]
        /* 0x5C88 */ public GcSeed WeaponSeed;
        [NMS(Index = 2)]
        /* 0x5C98 */ public ulong EndTimeUTC;
        [NMS(Index = 3)]
        /* 0x5CA0 */ public ulong Hash;
        [NMS(Index = 1)]
        /* 0x5CA8 */ public ulong StartTimeUTC;
        [NMS(Index = 19)]
        /* 0x5CB0 */ public ulong UAOverrideValue;
        [NMS(Index = 15)]
        /* 0x5CB8 */ public GcDifficultySettingsData DifficultyMinimums;
        [NMS(Index = 91)]
        /* 0x5D18 */ public Vector2f CustomFrigateFlybyTimer;
        [NMS(Index = 92)]
        /* 0x5D20 */ public Vector2f CustomPiratePlanetFlybyTimer;
        [NMS(Index = 108)]
        /* 0x5D28 */ public float AbandonedFreighterHazardProtectionMul;
        [NMS(Index = 85)]
        /* 0x5D2C */ public float BuildingRadiusShipOffsetMultiplier;
        [NMS(Index = 14)]
        /* 0x5D30 */ public GcDifficultyPresetType DifficultySettingPreset;
        [NMS(Index = 27)]
        /* 0x5D34 */ public int DisplayNumber;
        [NMS(Index = 84)]
        /* 0x5D38 */ public float DistanceFromShipAtStartOfGame;
        [NMS(Index = 111)]
        /* 0x5D3C */ public float EnergyDrainMultiplier;
        [NMS(Index = 109)]
        /* 0x5D40 */ public float FarmPlantsTimerMul;
        [NMS(Index = 99)]
        /* 0x5D44 */ public int FreighterBattleEarlyWarpsOverride;
        [NMS(Index = 53)]
        /* 0x5D48 */ public GcAlienRace FreighterRace;
        [NMS(Index = 13)]
        /* 0x5D4C */ public GcGameMode GameMode;
        [NMS(Index = 110)]
        /* 0x5D50 */ public float HazardProtectionDrainMultiplier;
        [NMS(Index = 112)]
        /* 0x5D54 */ public int QuestSubstanceReducer;
        [NMS(Index = 26)]
        /* 0x5D58 */ public int RemixNumber;
        [NMS(Index = 81)]
        /* 0x5D5C */ public float SandwormGlobalOverrideSpawnChance;
        [NMS(Index = 80)]
        /* 0x5D60 */ public float SandwormGlobalOverrideTimer;
        [NMS(Index = 0)]
        /* 0x5D64 */ public int SeasonId;
        [NMS(Index = 25)]
        /* 0x5D68 */ public int SeasonNumber;
        [NMS(Index = 10)]
        /* 0x5D6C */ public GcAudioWwiseEvents SeasonStartMusicOverride;
        [NMS(Index = 49)]
        /* 0x5D70 */ public GcSpaceshipClasses ShipType;
        [NMS(Index = 77)]
        /* 0x5D74 */ public int StartingPetSlots;
        [NMS(Index = 46)]
        /* 0x5D78 */ public int StartingSuitCargoSlots;
        [NMS(Index = 44)]
        /* 0x5D7C */ public int StartingSuitSlots;
        [NMS(Index = 45)]
        /* 0x5D80 */ public int StartingSuitTechSlots;
        [NMS(Index = 128)]
        /* 0x5D84 */ public GcScreenFilters StartingUAScreenFilter;
        [NMS(Index = 101)]
        /* 0x5D88 */ public int TechCostMultiplier;
        [NMS(Index = 23)]
        /* 0x5D8C */ public NMSString0x200 FinalRewardDescription;
        [NMS(Index = 63)]
        /* 0x5F8C */ public NMSString0x80 UseSpawnBuildingNearUDA;
        [NMS(Index = 6)]
        /* 0x600C */ public NMSString0x20 Description;
        [NMS(Index = 18)]
        /* 0x602C */ public NMSString0x20 SeasonalUAOverride;
        [NMS(Index = 5)]
        /* 0x604C */ public NMSString0x20 Subtitle;
        [NMS(Index = 7)]
        /* 0x606C */ public NMSString0x20 Summary;
        [NMS(Index = 4)]
        /* 0x608C */ public NMSString0x20 Title;
        [NMS(Index = 94)]
        /* 0x60AC */ public bool AllowMissionDetailMessages;
        [NMS(Index = 133)]
        /* 0x60AD */ public bool AllowOnlyCorvetteShipPurchases;
        [NMS(Index = 134)]
        /* 0x60AE */ public bool AllowSaveContextMultitoolTransfer;
        [NMS(Index = 135)]
        /* 0x60AF */ public bool AllowSaveContextShipTransfer;
        [NMS(Index = 88)]
        /* 0x60B0 */ public bool AlwaysStormy;
        [NMS(Index = 124)]
        /* 0x60B1 */ public bool AlwaysUseSeasonalStationTradeData;
        [NMS(Index = 89)]
        /* 0x60B2 */ public bool BlockAggressiveSentinelsInStartSystem;
        [NMS(Index = 90)]
        /* 0x60B3 */ public bool BlockExtremeWeatherInStartSystem;
        [NMS(Index = 12)]
        /* 0x60B4 */ public bool BlockFirstSpaceMusic;
        [NMS(Index = 87)]
        /* 0x60B5 */ public bool BlockStormsAtStart;
        [NMS(Index = 61)]
        /* 0x60B6 */ public bool CarnageMode;
        [NMS(Index = 117)]
        /* 0x60B7 */ public bool CompatibleWithState;
        [NMS(Index = 37)]
        /* 0x60B8 */ public bool DefaultToPvPOff;
        [NMS(Index = 32)]
        /* 0x60B9 */ public bool DoCommunityMissionTextSubstitutions;
        [NMS(Index = 59)]
        /* 0x60BA */ public bool ForceAllSentinelsAggressive;
        [NMS(Index = 58)]
        /* 0x60BB */ public bool ForceAllSystemsAbandoned;
        [NMS(Index = 100)]
        /* 0x60BC */ public bool ForceDeepSpaceAmbientFrigatesOnInfested;
        [NMS(Index = 96)]
        /* 0x60BD */ public bool ForceStartPlanetToHaveScrap;
        [NMS(Index = 57)]
        /* 0x60BE */ public bool ForceStartSystemAbandoned;
        [NMS(Index = 56)]
        /* 0x60BF */ public bool ForceStartSystemTernary;
        [NMS(Index = 118)]
        /* 0x60C0 */ public bool HasBeenConverted;
        [NMS(Index = 107)]
        /* 0x60C1 */ public bool IncreaseXClassTechOddsWithCommTier;
        [NMS(Index = 38)]
        /* 0x60C2 */ public bool MustCraftInBases;
        [NMS(Index = 132)]
        /* 0x60C3 */ public bool NeverAllowShipPurchases;
        [NMS(Index = 130)]
        /* 0x60C4 */ public bool OnlyCorvetteLauncherCanBeRepaired;
        [NMS(Index = 129)]
        /* 0x60C5 */ public bool OnlyCorvettesSpawnWhenPlayerTeleports;
        [NMS(Index = 127)]
        /* 0x60C6 */ public bool OverrideStartingUAScreenFilter;
        [NMS(Index = 11)]
        /* 0x60C7 */ public bool PlayStartMusicInIntro;
        [NMS(Index = 126)]
        /* 0x60C8 */ public bool PurpleSystemsUnlocked;
        [NMS(Index = 115)]
        /* 0x60C9 */ public bool ResetSaveOnDeath;
        [NMS(Index = 79)]
        /* 0x60CA */ public bool SandwormGlobalOverride;
        [NMS(Index = 83)]
        /* 0x60CB */ public bool ShipIsAtDifferentBuildingToPlayer;
        [NMS(Index = 86)]
        /* 0x60CC */ public bool ShipStartsDamaged;
        [NMS(Index = 55)]
        /* 0x60CD */ public bool StartAboardFreighter;
        [NMS(Index = 82)]
        /* 0x60CE */ public bool StartNextToShip;
        [NMS(Index = 51)]
        /* 0x60CF */ public bool StartWithFreighter;
        [NMS(Index = 98)]
        /* 0x60D0 */ public bool TrashInventoryOnGalaxyTravel;
        [NMS(Index = 67)]
        /* 0x60D1 */ public bool UseDefaultAppearance;
        [NMS(Index = 74)]
        /* 0x60D2 */ public bool UseRandomPet;
        [NMS(Index = 123)]
        /* 0x60D3 */ public bool UseSeasonalUAStationTradeData;
        [NMS(Index = 125)]
        /* 0x60D4 */ public bool UseSpookHazardOnly;
        [NMS(Index = 95)]
        /* 0x60D5 */ public bool UseStartPlanetObjectListOverrides;
    }
}
