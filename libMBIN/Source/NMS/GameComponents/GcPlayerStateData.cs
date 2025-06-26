using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC046A3AB0111F065, NameHash = 0x5E49C3E9)]
    public class GcPlayerStateData : NMSTemplate
    {
        [NMS(Index = 120)]
        /* 0x00000 */ public GcTerrainEditsBuffer TerrainEditData;
        [NMS(Index = 219, Size = 0x64)]
        /* 0x3C780 */ public GcSettlementState[] SettlementStatesV2;
        [NMS(Index = 163, Size = 0x12)]
        /* 0x5DAC0 */ public GcArchivedShipData[] ArchivedShipOwnership;
        [NMS(Index = 162, Size = 0xC)]
        /* 0x64120 */ public GcPlayerOwnershipData[] ShipOwnership;
        [NMS(Index = 14, Size = 0x12)]
        /* 0x67960 */ public GcArchivedMultitoolData[] ArchivedMultitools;
        [NMS(Index = 159, Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x6A9C0 */ public GcPlayerOwnershipData[] VehicleOwnership;
        [NMS(Index = 12, Size = 0x6)]
        /* 0x6CA90 */ public GcMultitoolData[] Multitools;
        [NMS(Index = 121, Size = 0x5, EnumType = typeof(GcNPCHabitationType.NPCHabitationTypeEnum))]
        /* 0x6D990 */ public GcNPCWorkerData[] NPCWorkers;
        [NMS(Index = 86, Size = 0x10)]
        /* 0x6DC10 */ public Vector3f[] PlanetPositions;
        [NMS(Index = 196)]
        /* 0x6DD10 */ public GcPlayerSpawnStateData MultiplayerSpawn;
        [NMS(Index = 176)]
        /* 0x6DDE0 */ public GcTeleportEndpoint OtherSideOfPortalReturnBase;
        [NMS(Index = 161)]
        /* 0x6DE60 */ public GcSkiffSaveData SkiffData;
        [NMS(Index = 44)]
        /* 0x6DE90 */ public GcInteractionData HoloExplorerInteraction;
        [NMS(Index = 46)]
        /* 0x6DEB0 */ public GcInteractionData HoloNooneInteraction;
        [NMS(Index = 45)]
        /* 0x6DED0 */ public GcInteractionData HoloScepticInteraction;
        [NMS(Index = 96)]
        /* 0x6DEF0 */ public Vector4f AnomalyPositionOverride;
        [NMS(Index = 100)]
        /* 0x6DF00 */ public Vector4f FirstShipPosition;
        [NMS(Index = 72)]
        /* 0x6DF10 */ public Vector4f FirstSpawnPosition;
        [NMS(Index = 113)]
        /* 0x6DF20 */ public Vector3f FreighterMatrixAt;
        [NMS(Index = 115)]
        /* 0x6DF30 */ public Vector3f FreighterMatrixPos;
        [NMS(Index = 114)]
        /* 0x6DF40 */ public Vector3f FreighterMatrixUp;
        [NMS(Index = 24)]
        /* 0x6DF50 */ public Vector4f GraveMatrixLookAt;
        [NMS(Index = 25)]
        /* 0x6DF60 */ public Vector4f GraveMatrixUp;
        [NMS(Index = 23)]
        /* 0x6DF70 */ public Vector4f GravePosition;
        [NMS(Index = 206)]
        /* 0x6DF80 */ public Vector3f NexusMatrixAt;
        [NMS(Index = 208)]
        /* 0x6DF90 */ public Vector3f NexusMatrixPos;
        [NMS(Index = 207)]
        /* 0x6DFA0 */ public Vector3f NexusMatrixUp;
        [NMS(Index = 177)]
        /* 0x6DFB0 */ public Vector4f PortalMarkerPosition_Local;
        [NMS(Index = 178)]
        /* 0x6DFC0 */ public Vector4f PortalMarkerPosition_Offset;
        [NMS(Index = 168)]
        /* 0x6DFD0 */ public Vector4f StartGameShipPosition;
        [NMS(Index = 16, Size = 0x12)]
        /* 0x6DFE0 */ public GcPetData[] Eggs;
        [NMS(Index = 15, Size = 0x12)]
        /* 0x70470 */ public GcPetData[] Pets;
        [NMS(Index = 238)]
        /* 0x72900 */ public GcFishingRecord FishingRecord;
        [NMS(Index = 17, Size = 0x12)]
        /* 0x74100 */ public GcPetCustomisationData[] PetAccessoryCustomisation;
        [NMS(Index = 181, Size = 0x1A, EnumType = typeof(GcCustomisationComponentData.CustomisationDataTypeEnum))]
        /* 0x756F0 */ public GcCharacterCustomisationSaveData[] CharacterCustomisationData;
        [NMS(Index = 199, Size = 0x3, EnumType = typeof(GcHotActionMenuTypes.HotActionMenuTypesEnum))]
        /* 0x76180 */ public GcHotActionsSaveData[] HotActions;
        [NMS(Index = 117, Size = 0x4)]
        /* 0x76540 */ public GcSquadronPilotData[] SquadronPilots;
        [NMS(Index = 227, Size = 0xF, EnumType = typeof(GcWonderCreatureCategory.WonderCreatureCategoryEnum))]
        /* 0x767C0 */ public GcWonderRecord[] WonderCreatureRecords;
        [NMS(Index = 143)]
        /* 0x76928 */ public GcInventoryContainer Chest10Inventory;
        [NMS(Index = 125)]
        /* 0x76A80 */ public GcInventoryContainer Chest1Inventory;
        [NMS(Index = 127)]
        /* 0x76BD8 */ public GcInventoryContainer Chest2Inventory;
        [NMS(Index = 129)]
        /* 0x76D30 */ public GcInventoryContainer Chest3Inventory;
        [NMS(Index = 131)]
        /* 0x76E88 */ public GcInventoryContainer Chest4Inventory;
        [NMS(Index = 133)]
        /* 0x76FE0 */ public GcInventoryContainer Chest5Inventory;
        [NMS(Index = 135)]
        /* 0x77138 */ public GcInventoryContainer Chest6Inventory;
        [NMS(Index = 137)]
        /* 0x77290 */ public GcInventoryContainer Chest7Inventory;
        [NMS(Index = 139)]
        /* 0x773E8 */ public GcInventoryContainer Chest8Inventory;
        [NMS(Index = 141)]
        /* 0x77540 */ public GcInventoryContainer Chest9Inventory;
        [NMS(Index = 147)]
        /* 0x77698 */ public GcInventoryContainer ChestMagic2Inventory;
        [NMS(Index = 145)]
        /* 0x777F0 */ public GcInventoryContainer ChestMagicInventory;
        [NMS(Index = 149)]
        /* 0x77948 */ public GcInventoryContainer CookingIngredientsInventory;
        [NMS(Index = 155)]
        /* 0x77AA0 */ public GcInventoryContainer FishBaitBoxInventory;
        [NMS(Index = 153)]
        /* 0x77BF8 */ public GcInventoryContainer FishPlatformInventory;
        [NMS(Index = 157)]
        /* 0x77D50 */ public GcInventoryContainer FoodUnitInventory;
        [NMS(Index = 107)]
        /* 0x77EA8 */ public GcInventoryContainer FreighterInventory;
        [NMS(Index = 109)]
        /* 0x78000 */ public GcInventoryContainer FreighterInventory_Cargo;
        [NMS(Index = 108)]
        /* 0x78158 */ public GcInventoryContainer FreighterInventory_TechOnly;
        [NMS(Index = 19)]
        /* 0x782B0 */ public GcInventoryContainer GraveInventory;
        [NMS(Index = 6)]
        /* 0x78408 */ public GcInventoryContainer Inventory;
        [NMS(Index = 8)]
        /* 0x78560 */ public GcInventoryContainer Inventory_Cargo;
        [NMS(Index = 7)]
        /* 0x786B8 */ public GcInventoryContainer Inventory_TechOnly;
        [NMS(Index = 151)]
        /* 0x78810 */ public GcInventoryContainer RocketLockerInventory;
        [NMS(Index = 9)]
        /* 0x78968 */ public GcInventoryContainer ShipInventory;
        [NMS(Index = 10)]
        /* 0x78AC0 */ public GcInventoryContainer WeaponInventory;
        [NMS(Index = 230, Size = 0xD, EnumType = typeof(GcWonderTreasureCategory.WonderTreasureCategoryEnum))]
        /* 0x78C18 */ public GcWonderRecord[] WonderTreasureRecords;
        [NMS(Index = 221, Size = 0x4)]
        /* 0x78D50 */ public GcSettlementHistory[] SettlementHistory;
        [NMS(Index = 232, Size = 0xC, EnumType = typeof(GcWonderCustomCategory.WonderCustomCategoryEnum))]
        /* 0x78E70 */ public GcWonderRecord[] WonderCustomRecords;
        [NMS(Index = 183, Size = 0x3)]
        /* 0x78F90 */ public GcCharacterCustomisationData[] Outfits;
        [NMS(Index = 63, Size = 0xB, EnumType = typeof(GcInteractionBufferType.InteractionBufferTypeEnum))]
        /* 0x79098 */ public GcInteractionBuffer[] StoredInteractions;
        [NMS(Index = 226, Size = 0xB, EnumType = typeof(GcWonderPlanetCategory.WonderPlanetCategoryEnum))]
        /* 0x791A0 */ public GcWonderRecord[] WonderPlanetRecords;
        [NMS(Index = 231, Size = 0xB, EnumType = typeof(GcWonderWeirdBasePartCategory.WonderWeirdBasePartCategoryEnum))]
        /* 0x792A8 */ public GcWonderRecord[] WonderWeirdBasePartRecords;
        [NMS(Index = 87, Size = 0x10)]
        /* 0x793B0 */ public GcSeed[] PlanetSeeds;
        [NMS(Index = 228, Size = 0x8, EnumType = typeof(GcWonderFloraCategory.WonderFloraCategoryEnum))]
        /* 0x794B0 */ public GcWonderRecord[] WonderFloraRecords;
        [NMS(Index = 229, Size = 0x8, EnumType = typeof(GcWonderMineralCategory.WonderMineralCategoryEnum))]
        /* 0x79570 */ public GcWonderRecord[] WonderMineralRecords;
        [NMS(Index = 223, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x79630 */ public GcStoryPageSeenDataArray[] SeenStories;
        [NMS(Index = 104)]
        /* 0x796C0 */ public GcResourceElement CurrentFreighter;
        [NMS(Index = 158)]
        /* 0x79708 */ public GcResourceElement CurrentFreighterNPC;
        [NMS(Index = 28)]
        /* 0x79750 */ public GcResourceElement CurrentShip;
        [NMS(Index = 234, Size = 0x4, EnumType = typeof(GcSynchronisedBufferType.SyncBufferTypeEnum))]
        /* 0x79798 */ public GcSyncBufferSaveDataArray[] SyncBuffersData;
        [NMS(Index = 29)]
        /* 0x797D8 */ public GcExactResource CurrentWeapon;
        [NMS(Index = 173)]
        /* 0x797F8 */ public GcPortalSaveData VisitedPortal;
        [NMS(Index = 142)]
        /* 0x79818 */ public GcInventoryLayout Chest10Layout;
        [NMS(Index = 124)]
        /* 0x79830 */ public GcInventoryLayout Chest1Layout;
        [NMS(Index = 126)]
        /* 0x79848 */ public GcInventoryLayout Chest2Layout;
        [NMS(Index = 128)]
        /* 0x79860 */ public GcInventoryLayout Chest3Layout;
        [NMS(Index = 130)]
        /* 0x79878 */ public GcInventoryLayout Chest4Layout;
        [NMS(Index = 132)]
        /* 0x79890 */ public GcInventoryLayout Chest5Layout;
        [NMS(Index = 134)]
        /* 0x798A8 */ public GcInventoryLayout Chest6Layout;
        [NMS(Index = 136)]
        /* 0x798C0 */ public GcInventoryLayout Chest7Layout;
        [NMS(Index = 138)]
        /* 0x798D8 */ public GcInventoryLayout Chest8Layout;
        [NMS(Index = 140)]
        /* 0x798F0 */ public GcInventoryLayout Chest9Layout;
        [NMS(Index = 146)]
        /* 0x79908 */ public GcInventoryLayout ChestMagic2Layout;
        [NMS(Index = 144)]
        /* 0x79920 */ public GcInventoryLayout ChestMagicLayout;
        [NMS(Index = 148)]
        /* 0x79938 */ public GcInventoryLayout CookingIngredientsLayout;
        [NMS(Index = 154)]
        /* 0x79950 */ public GcInventoryLayout FishBaitBoxLayout;
        [NMS(Index = 152)]
        /* 0x79968 */ public GcInventoryLayout FishPlatformLayout;
        [NMS(Index = 156)]
        /* 0x79980 */ public GcInventoryLayout FoodUnitLayout;
        [NMS(Index = 106)]
        /* 0x79998 */ public GcInventoryLayout FreighterCargoLayout;
        [NMS(Index = 105)]
        /* 0x799B0 */ public GcInventoryLayout FreighterLayout;
        [NMS(Index = 150)]
        /* 0x799C8 */ public GcInventoryLayout RocketLockerLayout;
        [NMS(Index = 26)]
        /* 0x799E0 */ public GcInventoryLayout ShipLayout;
        [NMS(Index = 27)]
        /* 0x799F8 */ public GcInventoryLayout WeaponLayout;
        [NMS(Index = 212)]
        /* 0x79A10 */ public NMSString0x10 BannerTitleId;
        [NMS(Index = 119)]
        /* 0x79A20 */ public List<GcPersistentBBObjectData> BaseBuildingObjects;
        [NMS(Index = 103)]
        /* 0x79A30 */ public GcSeed CurrentFreighterHomeSystemSeed;
        [NMS(Index = 38)]
        /* 0x79A40 */ public NMSString0x10 CurrentMissionID;
        [NMS(Index = 189)]
        /* 0x79A50 */ public List<ulong> ExpeditionSeedsSelectedToday;
        [NMS(Index = 188)]
        /* 0x79A60 */ public List<GcFleetExpeditionSaveData> FleetExpeditions;
        [NMS(Index = 187)]
        /* 0x79A70 */ public List<GcFleetFrigateSaveData> FleetFrigates;
        [NMS(Index = 186)]
        /* 0x79A80 */ public GcSeed FleetSeed;
        [NMS(Index = 193)]
        /* 0x79A90 */ public NMSString0x10 FoodUnitItem;
        [NMS(Index = 185)]
        /* 0x79AA0 */ public NMSString0x10 FreighterEngineEffect;
        [NMS(Index = 237)]
        /* 0x79AB0 */ public List<GcGalaxyWaypoint> GalaxyWaypoints;
        [NMS(Index = 75)]
        /* 0x79AC0 */ public List<NMSString0x20A> InteractionProgressTable;
        [NMS(Index = 184)]
        /* 0x79AD0 */ public NMSString0x10 JetpackEffect;
        [NMS(Index = 31)]
        /* 0x79AE0 */ public List<NMSString0x10> KnownProducts;
        [NMS(Index = 33)]
        /* 0x79AF0 */ public List<NMSString0x20A> KnownRefinerRecipes;
        [NMS(Index = 32)]
        /* 0x79B00 */ public List<NMSString0x10> KnownSpecials;
        [NMS(Index = 30)]
        /* 0x79B10 */ public List<NMSString0x10> KnownTech;
        [NMS(Index = 35)]
        /* 0x79B20 */ public List<GcWordGroupKnowledge> KnownWordGroups;
        [NMS(Index = 34)]
        /* 0x79B30 */ public List<GcWordKnowledge> KnownWords;
        [NMS(Index = 172)]
        /* 0x79B40 */ public List<GcPortalSaveData> LastPortal;
        [NMS(Index = 64)]
        /* 0x79B50 */ public List<GcMaintenanceContainer> MaintenanceInteractions;
        [NMS(Index = 56)]
        /* 0x79B60 */ public List<GcScanEventSave> MarkerStack;
        [NMS(Index = 36)]
        /* 0x79B70 */ public List<GcPlayerMissionProgress> MissionProgress;
        [NMS(Index = 43)]
        /* 0x79B80 */ public List<GcMissionIDEpochPair> MissionRecurrences;
        [NMS(Index = 57)]
        /* 0x79B90 */ public List<GcScanEventSave> NewMPMarkerStack;
        [NMS(Index = 122)]
        /* 0x79BA0 */ public List<GcPersistentBase> PersistentPlayerBases;
        [NMS(Index = 65)]
        /* 0x79BB0 */ public List<GcMaintenanceContainer> PersonalMaintenanceInteractions;
        [NMS(Index = 40)]
        /* 0x79BC0 */ public NMSString0x10 PreviousMissionID;
        [NMS(Index = 218)]
        /* 0x79BD0 */ public List<NMSString0x10> RedeemedPlatformRewards;
        [NMS(Index = 216)]
        /* 0x79BE0 */ public List<NMSString0x10> RedeemedSeasonRewards;
        [NMS(Index = 217)]
        /* 0x79BF0 */ public List<NMSString0x10> RedeemedTwitchRewards;
        [NMS(Index = 236)]
        /* 0x79C00 */ public List<GcMaintenanceContainer> RefinerBufferData;
        [NMS(Index = 235)]
        /* 0x79C10 */ public List<GcMaintenanceSaveKey> RefinerBufferKeys;
        [NMS(Index = 197)]
        /* 0x79C20 */ public List<GcRepairTechData> RepairTechBuffer;
        [NMS(Index = 74)]
        /* 0x79C30 */ public List<GcSavedInteractionDialogData> SavedInteractionDialogTable;
        [NMS(Index = 118)]
        /* 0x79C40 */ public List<NMSString0x10> SeenBaseBuildingObjects;
        [NMS(Index = 244)]
        /* 0x79C50 */ public List<GcSettlementLocalSaveData> SettlementLocalSaveData;
        [NMS(Index = 61)]
        /* 0x79C60 */ public List<GcPlayerStatsGroup> Stats;
        [NMS(Index = 58)]
        /* 0x79C70 */ public List<Vector3f> SurveyedEventPositions;
        [NMS(Index = 62)]
        /* 0x79C80 */ public List<GcTelemetryStat> TelemetryStats;
        [NMS(Index = 123)]
        /* 0x79C90 */ public List<GcTeleportEndpoint> TeleportEndpoints;
        [NMS(Index = 171)]
        /* 0x79CA0 */ public List<GcTradingSupplyData> TradingSupplyData;
        [NMS(Index = 85)]
        /* 0x79CB0 */ public List<GcSavedEntitlement> UsedEntitlements;
        [NMS(Index = 78)]
        /* 0x79CC0 */ public List<GcUniverseAddressData> VisitedAtlasStationsData;
        [NMS(Index = 66)]
        /* 0x79CD0 */ public List<ulong> VisitedSystems;
        [NMS(Index = 11)]
        /* 0x79CE0 */ public List<GcInWorldUIScreenData> WristScreenData;
        [NMS(Index = 91)]
        /* 0x79CF0 */ public ulong ActiveSpaceBattleUA;
        [NMS(Index = 39)]
        /* 0x79CF8 */ public ulong CurrentMissionSeed;
        [NMS(Index = 240)]
        /* 0x79D00 */ public ulong FirstPurpleSystemUA;
        [NMS(Index = 110)]
        /* 0x79D08 */ public ulong FreighterLastSpawnTime;
        [NMS(Index = 101)]
        /* 0x79D10 */ public ulong HazardTimeAlive;
        [NMS(Index = 60)]
        /* 0x79D18 */ public ulong LastCheckedForStatResetsTime;
        [NMS(Index = 190)]
        /* 0x79D20 */ public ulong LastKnownDay;
        [NMS(Index = 200)]
        /* 0x79D28 */ public ulong LastUABeforePortalWarp;
        [NMS(Index = 95)]
        /* 0x79D30 */ public ulong MiniStationUA;
        [NMS(Index = 194)]
        /* 0x79D38 */ public ulong MultiplayerLobbyID;
        [NMS(Index = 198)]
        /* 0x79D40 */ public ulong MultiplayerPrivileges;
        [NMS(Index = 41)]
        /* 0x79D48 */ public ulong PreviousMissionSeed;
        [NMS(Index = 201)]
        /* 0x79D50 */ public ulong StoryPortalSeed;
        [NMS(Index = 191)]
        /* 0x79D58 */ public ulong SunTimer;
        [NMS(Index = 243)]
        /* 0x79D60 */ public ulong TaggedPlanetUA;
        [NMS(Index = 55)]
        /* 0x79D68 */ public ulong TimeAlive;
        [NMS(Index = 93)]
        /* 0x79D70 */ public ulong TimeLastMiniStation;
        [NMS(Index = 89)]
        /* 0x79D78 */ public ulong TimeLastSpaceBattle;
        [NMS(Index = 5)]
        /* 0x79D80 */ public ulong TimeStamp;
        [NMS(Index = 73, Size = 0x95, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x79D88 */ public GcSavedInteractionRaceData[] SavedInteractionIndicies;
        [NMS(Index = 233, Size = 0xC, EnumType = typeof(GcWonderCustomCategory.WonderCustomCategoryEnum))]
        /* 0x7B978 */ public GcWonderRecordCustomData[] WonderCustomRecordsExtraData;
        [NMS(Index = 80, Size = 0xB)]
        /* 0x7BCA8 */ public GcUniverseAddressData[] CompletedAtlasAddresses;
        [NMS(Index = 77, Size = 0xB)]
        /* 0x7BDB0 */ public GcUniverseAddressData[] NewAtlasStationAdressData;
        [NMS(Index = 76, Size = 0xA)]
        /* 0x7BEB8 */ public GcUniverseAddressData[] AtlasStationAdressData;
        [NMS(Index = 4)]
        /* 0x7BFA8 */ public GcDifficultyStateData DifficultyState;
        [NMS(Index = 67, Size = 0x7, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x7C014 */ public float[] Hazard;
        [NMS(Index = 111)]
        /* 0x7C030 */ public GcUniverseAddressData FreighterUniverseAddress;
        [NMS(Index = 97)]
        /* 0x7C048 */ public GcUniverseAddressData GameStartAddress1;
        [NMS(Index = 98)]
        /* 0x7C060 */ public GcUniverseAddressData GameStartAddress2;
        [NMS(Index = 22)]
        /* 0x7C078 */ public GcUniverseAddressData GraveUniverseAddress;
        [NMS(Index = 195)]
        /* 0x7C090 */ public GcUniverseAddressData MultiplayerUA;
        [NMS(Index = 205)]
        /* 0x7C0A8 */ public GcUniverseAddressData NexusUniverseAddress;
        [NMS(Index = 1)]
        /* 0x7C0C0 */ public GcUniverseAddressData PreviousUniverseAddress;
        [NMS(Index = 0)]
        /* 0x7C0D8 */ public GcUniverseAddressData UniverseAddress;
        [NMS(Index = 13)]
        /* 0x7C0F0 */ public int ActiveMultioolIndex;
        [NMS(Index = 92)]
        /* 0x7C0F4 */ public int ActiveSpaceBattleLevel;
        [NMS(Index = 211)]
        /* 0x7C0F8 */ public int BannerBackgroundColour;
        [NMS(Index = 209)]
        /* 0x7C0FC */ public int BannerIcon;
        [NMS(Index = 210)]
        /* 0x7C100 */ public int BannerMainColour;
        [NMS(Index = 68)]
        /* 0x7C104 */ public int BoltAmmo;
        [NMS(Index = 51)]
        /* 0x7C108 */ public int Energy;
        [NMS(Index = 192)]
        /* 0x7C10C */ public float FoodUnitAccumulator;
        [NMS(Index = 47)]
        /* 0x7C110 */ public int Health;
        [NMS(Index = 2)]
        /* 0x7C114 */ public int HomeRealityIteration;
        [NMS(Index = 174)]
        /* 0x7C118 */ public int KnownPortalRunes;
        [NMS(Index = 71)]
        /* 0x7C11C */ public int LaserAmmo;
        [NMS(Index = 42)]
        /* 0x7C120 */ public int MissionVersion;
        [NMS(Index = 53)]
        /* 0x7C124 */ public int Nanites;
        [NMS(Index = 59)]
        /* 0x7C128 */ public int NextSurveyedEventPositionIndex;
        [NMS(Index = 37)]
        /* 0x7C12C */ public int PostMissionIndex;
        [NMS(Index = 88)]
        /* 0x7C130 */ public int PrimaryPlanet;
        [NMS(Index = 164)]
        /* 0x7C134 */ public int PrimaryShip;
        [NMS(Index = 160)]
        /* 0x7C138 */ public int PrimaryVehicle;
        [NMS(Index = 82)]
        /* 0x7C13C */ public int ProcTechIndex;
        [NMS(Index = 81)]
        /* 0x7C140 */ public int ProgressionLevel;
        [NMS(Index = 70)]
        /* 0x7C144 */ public int PulseAmmo;
        [NMS(Index = 69)]
        /* 0x7C148 */ public int ScatterAmmo;
        [NMS(Index = 220)]
        /* 0x7C14C */ public int SettlementStateRingBufferIndexV2;
        [NMS(Index = 49)]
        /* 0x7C150 */ public int Shield;
        [NMS(Index = 48)]
        /* 0x7C154 */ public int ShipHealth;
        [NMS(Index = 50)]
        /* 0x7C158 */ public int ShipShield;
        [NMS(Index = 54)]
        /* 0x7C15C */ public int Specials;
        [NMS(Index = 179)]
        /* 0x7C160 */ public GcPlayerWeapons StartingPrimaryWeapon;
        [NMS(Index = 225)]
        /* 0x7C164 */ public int StartingSeasonNumber;
        [NMS(Index = 180)]
        /* 0x7C168 */ public GcPlayerWeapons StartingSecondaryWeapon;
        [NMS(Index = 213)]
        /* 0x7C16C */ public int TelemetryUploadVersion;
        [NMS(Index = 170)]
        /* 0x7C170 */ public int TradingSupplyDataIndex;
        [NMS(Index = 52)]
        /* 0x7C174 */ public int Units;
        [NMS(Index = 214)]
        /* 0x7C178 */ public float VRCameraOffset;
        [NMS(Index = 94)]
        /* 0x7C17C */ public int WarpsLastMiniStation;
        [NMS(Index = 90)]
        /* 0x7C180 */ public int WarpsLastSpaceBattle;
        [NMS(Index = 202)]
        /* 0x7C184 */ public ushort ShopNumber;
        [NMS(Index = 203)]
        /* 0x7C186 */ public ushort ShopTier;
        [NMS(Index = 3)]
        /* 0x7C188 */ public NMSString0x80 SaveSummary;
        [NMS(Index = 167)]
        /* 0x7C208 */ public NMSString0x20 PlayerFreighterName;
        [NMS(Index = 18, Size = 0x12)]
        /* 0x7C228 */ public bool[] UnlockedPetSlots;
        [NMS(Index = 99, Size = 0x10)]
        /* 0x7C23A */ public bool[] GalacticMapRequests;
        [NMS(Index = 182, Size = 0xC)]
        /* 0x7C24A */ public bool[] ShipUsesLegacyColours;
        [NMS(Index = 116, Size = 0x4)]
        /* 0x7C256 */ public bool[] SquadronUnlockedPilotSlots;
        [NMS(Index = 224)]
        /* 0x7C25A */ public bool BuildersKnown;
        [NMS(Index = 79)]
        /* 0x7C25B */ public bool FirstAtlasStationDiscovered;
        [NMS(Index = 112)]
        /* 0x7C25C */ public bool FreighterDismissed;
        [NMS(Index = 204)]
        /* 0x7C25D */ public bool HasAccessToNexus;
        [NMS(Index = 239)]
        /* 0x7C25E */ public bool HasDiscoveredPurpleSystems;
        [NMS(Index = 241)]
        /* 0x7C25F */ public bool HasGalacticMapRequestAllPurples;
        [NMS(Index = 242)]
        /* 0x7C260 */ public bool HasGalacticMapRequestFirstPurple;
        [NMS(Index = 83)]
        /* 0x7C261 */ public bool IsNew;
        [NMS(Index = 165)]
        /* 0x7C262 */ public bool MultiShipEnabled;
        [NMS(Index = 222)]
        /* 0x7C263 */ public bool NextLoadSpawnsWithFreshStart;
        [NMS(Index = 175)]
        /* 0x7C264 */ public bool OnOtherSideOfPortal;
        [NMS(Index = 215)]
        /* 0x7C265 */ public bool RestartAllInactiveSeasonalMissions;
        [NMS(Index = 102)]
        /* 0x7C266 */ public bool RevealBlackHoles;
        [NMS(Index = 169)]
        /* 0x7C267 */ public bool ShipNeedsTerrainPositioning;
        [NMS(Index = 21)]
        /* 0x7C268 */ public bool SpaceGrave;
        [NMS(Index = 20)]
        /* 0x7C269 */ public bool SpawnGrave;
        [NMS(Index = 84)]
        /* 0x7C26A */ public bool UseSmallerBlackholeJumps;
        [NMS(Index = 166)]
        /* 0x7C26B */ public bool VehicleAIControlEnabled;
    }
}
