using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDB8B46817E68BA8, NameHash = 0x5E49C3E9)]
    public class GcPlayerStateData : NMSTemplate
    {
        [NMS(Index = 121)]
        /* 0x00000 */ public GcTerrainEditsBuffer TerrainEditData;
        [NMS(Index = 225, Size = 0x64)]
        /* 0x3C780 */ public GcSettlementState[] SettlementStatesV2;
        [NMS(Index = 166, Size = 0x12)]
        /* 0x5DAC0 */ public GcArchivedShipData[] ArchivedShipOwnership;
        [NMS(Index = 165, Size = 0xC)]
        /* 0x64480 */ public GcPlayerOwnershipData[] ShipOwnership;
        [NMS(Index = 14, Size = 0x12)]
        /* 0x67F00 */ public GcArchivedMultitoolData[] ArchivedMultitools;
        [NMS(Index = 116, Size = 0x8)]
        /* 0x6B080 */ public GcFreighterSaveData[] FreighterFleet;
        [NMS(Index = 162, Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x6D880 */ public GcPlayerOwnershipData[] VehicleOwnership;
        [NMS(Index = 12, Size = 0x6)]
        /* 0x6FAA0 */ public GcMultitoolData[] Multitools;
        [NMS(Index = 122, Size = 0x5, EnumType = typeof(GcNPCHabitationType.NPCHabitationTypeEnum))]
        /* 0x70A00 */ public GcNPCWorkerData[] NPCWorkers;
        [NMS(Index = 86, Size = 0x10)]
        /* 0x70C80 */ public Vector3f[] PlanetPositions;
        [NMS(Index = 202)]
        /* 0x70D80 */ public GcPlayerSpawnStateData MultiplayerSpawn;
        [NMS(Index = 179)]
        /* 0x70E60 */ public GcTeleportEndpoint OtherSideOfPortalReturnBase;
        [NMS(Index = 164)]
        /* 0x70EE0 */ public GcSkiffSaveData SkiffData;
        [NMS(Index = 44)]
        /* 0x70F10 */ public GcInteractionData HoloExplorerInteraction;
        [NMS(Index = 46)]
        /* 0x70F30 */ public GcInteractionData HoloNooneInteraction;
        [NMS(Index = 45)]
        /* 0x70F50 */ public GcInteractionData HoloScepticInteraction;
        [NMS(Index = 96)]
        /* 0x70F70 */ public Vector4f AnomalyPositionOverride;
        [NMS(Index = 100)]
        /* 0x70F80 */ public Vector4f FirstShipPosition;
        [NMS(Index = 72)]
        /* 0x70F90 */ public Vector4f FirstSpawnPosition;
        [NMS(Index = 113)]
        /* 0x70FA0 */ public Vector3f FreighterMatrixAt;
        [NMS(Index = 115)]
        /* 0x70FB0 */ public Vector3f FreighterMatrixPos;
        [NMS(Index = 114)]
        /* 0x70FC0 */ public Vector3f FreighterMatrixUp;
        [NMS(Index = 24)]
        /* 0x70FD0 */ public Vector4f GraveMatrixLookAt;
        [NMS(Index = 25)]
        /* 0x70FE0 */ public Vector4f GraveMatrixUp;
        [NMS(Index = 23)]
        /* 0x70FF0 */ public Vector4f GravePosition;
        [NMS(Index = 212)]
        /* 0x71000 */ public Vector3f NexusMatrixAt;
        [NMS(Index = 214)]
        /* 0x71010 */ public Vector3f NexusMatrixPos;
        [NMS(Index = 213)]
        /* 0x71020 */ public Vector3f NexusMatrixUp;
        [NMS(Index = 180)]
        /* 0x71030 */ public Vector4f PortalMarkerPosition_Local;
        [NMS(Index = 181)]
        /* 0x71040 */ public Vector4f PortalMarkerPosition_Offset;
        [NMS(Index = 171)]
        /* 0x71050 */ public Vector4f StartGameShipPosition;
        [NMS(Index = 16, Size = 0x12)]
        /* 0x71060 */ public GcPetData[] Eggs;
        [NMS(Index = 15, Size = 0x12)]
        /* 0x734F0 */ public GcPetData[] Pets;
        [NMS(Index = 244)]
        /* 0x75980 */ public GcFishingRecord FishingRecord;
        [NMS(Index = 17, Size = 0x12)]
        /* 0x77180 */ public GcPetCustomisationData[] PetAccessoryCustomisation;
        [NMS(Index = 184, Size = 0x1A, EnumType = typeof(GcCustomisationComponentData.CustomisationDataTypeEnum))]
        /* 0x78770 */ public GcCharacterCustomisationSaveData[] CharacterCustomisationData;
        [NMS(Index = 205, Size = 0x3, EnumType = typeof(GcHotActionMenuTypes.HotActionMenuTypesEnum))]
        /* 0x79200 */ public GcHotActionsSaveData[] HotActions;
        [NMS(Index = 118, Size = 0x4)]
        /* 0x795C0 */ public GcSquadronPilotData[] SquadronPilots;
        [NMS(Index = 188, Size = 0x6)]
        /* 0x79840 */ public GcCharacterCustomisationData[] CustomTruckPresets;
        [NMS(Index = 186, Size = 0x6)]
        /* 0x79A50 */ public GcCharacterCustomisationData[] Outfits;
        [NMS(Index = 233, Size = 0xF, EnumType = typeof(GcWonderCreatureCategory.WonderCreatureCategoryEnum))]
        /* 0x79C60 */ public GcWonderRecord[] WonderCreatureRecords;
        [NMS(Index = 144)]
        /* 0x79DC8 */ public GcInventoryContainer Chest10Inventory;
        [NMS(Index = 126)]
        /* 0x79F28 */ public GcInventoryContainer Chest1Inventory;
        [NMS(Index = 128)]
        /* 0x7A088 */ public GcInventoryContainer Chest2Inventory;
        [NMS(Index = 130)]
        /* 0x7A1E8 */ public GcInventoryContainer Chest3Inventory;
        [NMS(Index = 132)]
        /* 0x7A348 */ public GcInventoryContainer Chest4Inventory;
        [NMS(Index = 134)]
        /* 0x7A4A8 */ public GcInventoryContainer Chest5Inventory;
        [NMS(Index = 136)]
        /* 0x7A608 */ public GcInventoryContainer Chest6Inventory;
        [NMS(Index = 138)]
        /* 0x7A768 */ public GcInventoryContainer Chest7Inventory;
        [NMS(Index = 140)]
        /* 0x7A8C8 */ public GcInventoryContainer Chest8Inventory;
        [NMS(Index = 142)]
        /* 0x7AA28 */ public GcInventoryContainer Chest9Inventory;
        [NMS(Index = 148)]
        /* 0x7AB88 */ public GcInventoryContainer ChestMagic2Inventory;
        [NMS(Index = 146)]
        /* 0x7ACE8 */ public GcInventoryContainer ChestMagicInventory;
        [NMS(Index = 150)]
        /* 0x7AE48 */ public GcInventoryContainer CookingIngredientsInventory;
        [NMS(Index = 160)]
        /* 0x7AFA8 */ public GcInventoryContainer CorvetteStorageInventory;
        [NMS(Index = 156)]
        /* 0x7B108 */ public GcInventoryContainer FishBaitBoxInventory;
        [NMS(Index = 154)]
        /* 0x7B268 */ public GcInventoryContainer FishPlatformInventory;
        [NMS(Index = 158)]
        /* 0x7B3C8 */ public GcInventoryContainer FoodUnitInventory;
        [NMS(Index = 107)]
        /* 0x7B528 */ public GcInventoryContainer FreighterInventory;
        [NMS(Index = 109)]
        /* 0x7B688 */ public GcInventoryContainer FreighterInventory_Cargo;
        [NMS(Index = 108)]
        /* 0x7B7E8 */ public GcInventoryContainer FreighterInventory_TechOnly;
        [NMS(Index = 19)]
        /* 0x7B948 */ public GcInventoryContainer GraveInventory;
        [NMS(Index = 6)]
        /* 0x7BAA8 */ public GcInventoryContainer Inventory;
        [NMS(Index = 8)]
        /* 0x7BC08 */ public GcInventoryContainer Inventory_Cargo;
        [NMS(Index = 7)]
        /* 0x7BD68 */ public GcInventoryContainer Inventory_TechOnly;
        [NMS(Index = 152)]
        /* 0x7BEC8 */ public GcInventoryContainer RocketLockerInventory;
        [NMS(Index = 9)]
        /* 0x7C028 */ public GcInventoryContainer ShipInventory;
        [NMS(Index = 10)]
        /* 0x7C188 */ public GcInventoryContainer WeaponInventory;
        [NMS(Index = 236, Size = 0xD, EnumType = typeof(GcWonderTreasureCategory.WonderTreasureCategoryEnum))]
        /* 0x7C2E8 */ public GcWonderRecord[] WonderTreasureRecords;
        [NMS(Index = 227, Size = 0x4)]
        /* 0x7C420 */ public GcSettlementHistory[] SettlementHistory;
        [NMS(Index = 238, Size = 0xC, EnumType = typeof(GcWonderCustomCategory.WonderCustomCategoryEnum))]
        /* 0x7C540 */ public GcWonderRecord[] WonderCustomRecords;
        [NMS(Index = 63, Size = 0xB, EnumType = typeof(GcInteractionBufferType.InteractionBufferTypeEnum))]
        /* 0x7C660 */ public GcInteractionBuffer[] StoredInteractions;
        [NMS(Index = 232, Size = 0xB, EnumType = typeof(GcWonderPlanetCategory.WonderPlanetCategoryEnum))]
        /* 0x7C768 */ public GcWonderRecord[] WonderPlanetRecords;
        [NMS(Index = 237, Size = 0xB, EnumType = typeof(GcWonderWeirdBasePartCategory.WonderWeirdBasePartCategoryEnum))]
        /* 0x7C870 */ public GcWonderRecord[] WonderWeirdBasePartRecords;
        [NMS(Index = 87, Size = 0x10)]
        /* 0x7C978 */ public GcSeed[] PlanetSeeds;
        [NMS(Index = 234, Size = 0x8, EnumType = typeof(GcWonderFloraCategory.WonderFloraCategoryEnum))]
        /* 0x7CA78 */ public GcWonderRecord[] WonderFloraRecords;
        [NMS(Index = 235, Size = 0x8, EnumType = typeof(GcWonderMineralCategory.WonderMineralCategoryEnum))]
        /* 0x7CB38 */ public GcWonderRecord[] WonderMineralRecords;
        [NMS(Index = 229, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x7CBF8 */ public GcStoryPageSeenDataArray[] SeenStories;
        [NMS(Index = 104)]
        /* 0x7CC88 */ public GcResourceElement CurrentFreighter;
        [NMS(Index = 161)]
        /* 0x7CCD0 */ public GcResourceElement CurrentFreighterNPC;
        [NMS(Index = 28)]
        /* 0x7CD18 */ public GcResourceElement CurrentShip;
        [NMS(Index = 240, Size = 0x4, EnumType = typeof(GcSynchronisedBufferType.SyncBufferTypeEnum))]
        /* 0x7CD60 */ public GcSyncBufferSaveDataArray[] SyncBuffersData;
        [NMS(Index = 29)]
        /* 0x7CDA0 */ public GcExactResource CurrentWeapon;
        [NMS(Index = 176)]
        /* 0x7CDC0 */ public GcPortalSaveData VisitedPortal;
        [NMS(Index = 143)]
        /* 0x7CDE0 */ public GcInventoryLayout Chest10Layout;
        [NMS(Index = 125)]
        /* 0x7CDF8 */ public GcInventoryLayout Chest1Layout;
        [NMS(Index = 127)]
        /* 0x7CE10 */ public GcInventoryLayout Chest2Layout;
        [NMS(Index = 129)]
        /* 0x7CE28 */ public GcInventoryLayout Chest3Layout;
        [NMS(Index = 131)]
        /* 0x7CE40 */ public GcInventoryLayout Chest4Layout;
        [NMS(Index = 133)]
        /* 0x7CE58 */ public GcInventoryLayout Chest5Layout;
        [NMS(Index = 135)]
        /* 0x7CE70 */ public GcInventoryLayout Chest6Layout;
        [NMS(Index = 137)]
        /* 0x7CE88 */ public GcInventoryLayout Chest7Layout;
        [NMS(Index = 139)]
        /* 0x7CEA0 */ public GcInventoryLayout Chest8Layout;
        [NMS(Index = 141)]
        /* 0x7CEB8 */ public GcInventoryLayout Chest9Layout;
        [NMS(Index = 147)]
        /* 0x7CED0 */ public GcInventoryLayout ChestMagic2Layout;
        [NMS(Index = 145)]
        /* 0x7CEE8 */ public GcInventoryLayout ChestMagicLayout;
        [NMS(Index = 149)]
        /* 0x7CF00 */ public GcInventoryLayout CookingIngredientsLayout;
        [NMS(Index = 159)]
        /* 0x7CF18 */ public GcInventoryLayout CorvetteStorageLayout;
        [NMS(Index = 155)]
        /* 0x7CF30 */ public GcInventoryLayout FishBaitBoxLayout;
        [NMS(Index = 153)]
        /* 0x7CF48 */ public GcInventoryLayout FishPlatformLayout;
        [NMS(Index = 157)]
        /* 0x7CF60 */ public GcInventoryLayout FoodUnitLayout;
        [NMS(Index = 106)]
        /* 0x7CF78 */ public GcInventoryLayout FreighterCargoLayout;
        [NMS(Index = 105)]
        /* 0x7CF90 */ public GcInventoryLayout FreighterLayout;
        [NMS(Index = 151)]
        /* 0x7CFA8 */ public GcInventoryLayout RocketLockerLayout;
        [NMS(Index = 26)]
        /* 0x7CFC0 */ public GcInventoryLayout ShipLayout;
        [NMS(Index = 27)]
        /* 0x7CFD8 */ public GcInventoryLayout WeaponLayout;
        [NMS(Index = 218)]
        /* 0x7CFF0 */ public NMSString0x10 BannerTitleId;
        [NMS(Index = 120)]
        /* 0x7D000 */ public List<GcPersistentBBObjectData> BaseBuildingObjects;
        [NMS(Index = 103)]
        /* 0x7D010 */ public GcSeed CurrentFreighterHomeSystemSeed;
        [NMS(Index = 38)]
        /* 0x7D020 */ public NMSString0x10 CurrentMissionID;
        [NMS(Index = 195)]
        /* 0x7D030 */ public List<ulong> ExpeditionSeedsSelectedToday;
        [NMS(Index = 194)]
        /* 0x7D040 */ public List<GcFleetExpeditionSaveData> FleetExpeditions;
        [NMS(Index = 193)]
        /* 0x7D050 */ public List<GcFleetFrigateSaveData> FleetFrigates;
        [NMS(Index = 192)]
        /* 0x7D060 */ public GcSeed FleetSeed;
        [NMS(Index = 199)]
        /* 0x7D070 */ public NMSString0x10 FoodUnitItem;
        [NMS(Index = 191)]
        /* 0x7D080 */ public NMSString0x10 FreighterEngineEffect;
        [NMS(Index = 243)]
        /* 0x7D090 */ public List<GcGalaxyWaypoint> GalaxyWaypoints;
        [NMS(Index = 75)]
        /* 0x7D0A0 */ public List<NMSString0x20A> InteractionProgressTable;
        [NMS(Index = 190)]
        /* 0x7D0B0 */ public NMSString0x10 JetpackEffect;
        [NMS(Index = 31)]
        /* 0x7D0C0 */ public List<NMSString0x10> KnownProducts;
        [NMS(Index = 33)]
        /* 0x7D0D0 */ public List<NMSString0x20A> KnownRefinerRecipes;
        [NMS(Index = 32)]
        /* 0x7D0E0 */ public List<NMSString0x10> KnownSpecials;
        [NMS(Index = 30)]
        /* 0x7D0F0 */ public List<NMSString0x10> KnownTech;
        [NMS(Index = 35)]
        /* 0x7D100 */ public List<GcWordGroupKnowledge> KnownWordGroups;
        [NMS(Index = 34)]
        /* 0x7D110 */ public List<GcWordKnowledge> KnownWords;
        [NMS(Index = 175)]
        /* 0x7D120 */ public List<GcPortalSaveData> LastPortal;
        [NMS(Index = 64)]
        /* 0x7D130 */ public List<GcMaintenanceContainer> MaintenanceInteractions;
        [NMS(Index = 56)]
        /* 0x7D140 */ public List<GcScanEventSave> MarkerStack;
        [NMS(Index = 36)]
        /* 0x7D150 */ public List<GcPlayerMissionProgress> MissionProgress;
        [NMS(Index = 43)]
        /* 0x7D160 */ public List<GcMissionIDEpochPair> MissionRecurrences;
        [NMS(Index = 57)]
        /* 0x7D170 */ public List<GcScanEventSave> NewMPMarkerStack;
        [NMS(Index = 123)]
        /* 0x7D180 */ public List<GcPersistentBase> PersistentPlayerBases;
        [NMS(Index = 65)]
        /* 0x7D190 */ public List<GcMaintenanceContainer> PersonalMaintenanceInteractions;
        [NMS(Index = 40)]
        /* 0x7D1A0 */ public NMSString0x10 PreviousMissionID;
        [NMS(Index = 224)]
        /* 0x7D1B0 */ public List<NMSString0x10> RedeemedPlatformRewards;
        [NMS(Index = 222)]
        /* 0x7D1C0 */ public List<NMSString0x10> RedeemedSeasonRewards;
        [NMS(Index = 223)]
        /* 0x7D1D0 */ public List<NMSString0x10> RedeemedTwitchRewards;
        [NMS(Index = 242)]
        /* 0x7D1E0 */ public List<GcMaintenanceContainer> RefinerBufferData;
        [NMS(Index = 241)]
        /* 0x7D1F0 */ public List<GcMaintenanceSaveKey> RefinerBufferKeys;
        [NMS(Index = 203)]
        /* 0x7D200 */ public List<GcRepairTechData> RepairTechBuffer;
        [NMS(Index = 74)]
        /* 0x7D210 */ public List<GcSavedInteractionDialogData> SavedInteractionDialogTable;
        [NMS(Index = 119)]
        /* 0x7D220 */ public List<NMSString0x10> SeenBaseBuildingObjects;
        [NMS(Index = 250)]
        /* 0x7D230 */ public List<GcSettlementLocalSaveData> SettlementLocalSaveData;
        [NMS(Index = 61)]
        /* 0x7D240 */ public List<GcPlayerStatsGroup> Stats;
        [NMS(Index = 58)]
        /* 0x7D250 */ public List<Vector3f> SurveyedEventPositions;
        [NMS(Index = 62)]
        /* 0x7D260 */ public List<GcTelemetryStat> TelemetryStats;
        [NMS(Index = 124)]
        /* 0x7D270 */ public List<GcTeleportEndpoint> TeleportEndpoints;
        [NMS(Index = 174)]
        /* 0x7D280 */ public List<GcTradingSupplyData> TradingSupplyData;
        [NMS(Index = 85)]
        /* 0x7D290 */ public List<GcSavedEntitlement> UsedEntitlements;
        [NMS(Index = 78)]
        /* 0x7D2A0 */ public List<GcUniverseAddressData> VisitedAtlasStationsData;
        [NMS(Index = 66)]
        /* 0x7D2B0 */ public List<ulong> VisitedSystems;
        [NMS(Index = 11)]
        /* 0x7D2C0 */ public List<GcInWorldUIScreenData> WristScreenData;
        [NMS(Index = 91)]
        /* 0x7D2D0 */ public ulong ActiveSpaceBattleUA;
        [NMS(Index = 253)]
        /* 0x7D2D8 */ public ulong CorvetteDraftShipSeed;
        [NMS(Index = 39)]
        /* 0x7D2E0 */ public ulong CurrentMissionSeed;
        [NMS(Index = 246)]
        /* 0x7D2E8 */ public ulong FirstPurpleSystemUA;
        [NMS(Index = 110)]
        /* 0x7D2F0 */ public ulong FreighterLastSpawnTime;
        [NMS(Index = 101)]
        /* 0x7D2F8 */ public ulong HazardTimeAlive;
        [NMS(Index = 60)]
        /* 0x7D300 */ public ulong LastCheckedForStatResetsTime;
        [NMS(Index = 196)]
        /* 0x7D308 */ public ulong LastKnownDay;
        [NMS(Index = 206)]
        /* 0x7D310 */ public ulong LastUABeforePortalWarp;
        [NMS(Index = 95)]
        /* 0x7D318 */ public ulong MiniStationUA;
        [NMS(Index = 200)]
        /* 0x7D320 */ public ulong MultiplayerLobbyID;
        [NMS(Index = 204)]
        /* 0x7D328 */ public ulong MultiplayerPrivileges;
        [NMS(Index = 41)]
        /* 0x7D330 */ public ulong PreviousMissionSeed;
        [NMS(Index = 207)]
        /* 0x7D338 */ public ulong StoryPortalSeed;
        [NMS(Index = 197)]
        /* 0x7D340 */ public ulong SunTimer;
        [NMS(Index = 249)]
        /* 0x7D348 */ public ulong TaggedPlanetUA;
        [NMS(Index = 55)]
        /* 0x7D350 */ public ulong TimeAlive;
        [NMS(Index = 93)]
        /* 0x7D358 */ public ulong TimeLastMiniStation;
        [NMS(Index = 89)]
        /* 0x7D360 */ public ulong TimeLastSpaceBattle;
        [NMS(Index = 5)]
        /* 0x7D368 */ public ulong TimeStamp;
        [NMS(Index = 73, Size = 0x9B, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x7D370 */ public GcSavedInteractionRaceData[] SavedInteractionIndicies;
        [NMS(Index = 239, Size = 0xC, EnumType = typeof(GcWonderCustomCategory.WonderCustomCategoryEnum))]
        /* 0x7F080 */ public GcWonderRecordCustomData[] WonderCustomRecordsExtraData;
        [NMS(Index = 80, Size = 0xB)]
        /* 0x7F3B0 */ public GcUniverseAddressData[] CompletedAtlasAddresses;
        [NMS(Index = 77, Size = 0xB)]
        /* 0x7F4B8 */ public GcUniverseAddressData[] NewAtlasStationAdressData;
        [NMS(Index = 76, Size = 0xA)]
        /* 0x7F5C0 */ public GcUniverseAddressData[] AtlasStationAdressData;
        [NMS(Index = 4)]
        /* 0x7F6B0 */ public GcDifficultyStateData DifficultyState;
        [NMS(Index = 67, Size = 0x7, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x7F71C */ public float[] Hazard;
        [NMS(Index = 111)]
        /* 0x7F738 */ public GcUniverseAddressData FreighterUniverseAddress;
        [NMS(Index = 97)]
        /* 0x7F750 */ public GcUniverseAddressData GameStartAddress1;
        [NMS(Index = 98)]
        /* 0x7F768 */ public GcUniverseAddressData GameStartAddress2;
        [NMS(Index = 22)]
        /* 0x7F780 */ public GcUniverseAddressData GraveUniverseAddress;
        [NMS(Index = 201)]
        /* 0x7F798 */ public GcUniverseAddressData MultiplayerUA;
        [NMS(Index = 211)]
        /* 0x7F7B0 */ public GcUniverseAddressData NexusUniverseAddress;
        [NMS(Index = 1)]
        /* 0x7F7C8 */ public GcUniverseAddressData PreviousUniverseAddress;
        [NMS(Index = 0)]
        /* 0x7F7E0 */ public GcUniverseAddressData UniverseAddress;
        [NMS(Index = 13)]
        /* 0x7F7F8 */ public int ActiveMultioolIndex;
        [NMS(Index = 92)]
        /* 0x7F7FC */ public int ActiveSpaceBattleLevel;
        [NMS(Index = 217)]
        /* 0x7F800 */ public int BannerBackgroundColour;
        [NMS(Index = 215)]
        /* 0x7F804 */ public int BannerIcon;
        [NMS(Index = 216)]
        /* 0x7F808 */ public int BannerMainColour;
        [NMS(Index = 68)]
        /* 0x7F80C */ public int BoltAmmo;
        [NMS(Index = 251)]
        /* 0x7F810 */ public int CorvetteEditAssociatedShipIndex;
        [NMS(Index = 51)]
        /* 0x7F814 */ public int Energy;
        [NMS(Index = 198)]
        /* 0x7F818 */ public float FoodUnitAccumulator;
        [NMS(Index = 47)]
        /* 0x7F81C */ public int Health;
        [NMS(Index = 2)]
        /* 0x7F820 */ public int HomeRealityIteration;
        [NMS(Index = 177)]
        /* 0x7F824 */ public int KnownPortalRunes;
        [NMS(Index = 71)]
        /* 0x7F828 */ public int LaserAmmo;
        [NMS(Index = 42)]
        /* 0x7F82C */ public int MissionVersion;
        [NMS(Index = 53)]
        /* 0x7F830 */ public int Nanites;
        [NMS(Index = 59)]
        /* 0x7F834 */ public int NextSurveyedEventPositionIndex;
        [NMS(Index = 37)]
        /* 0x7F838 */ public int PostMissionIndex;
        [NMS(Index = 88)]
        /* 0x7F83C */ public int PrimaryPlanet;
        [NMS(Index = 167)]
        /* 0x7F840 */ public int PrimaryShip;
        [NMS(Index = 163)]
        /* 0x7F844 */ public int PrimaryVehicle;
        [NMS(Index = 82)]
        /* 0x7F848 */ public int ProcTechIndex;
        [NMS(Index = 81)]
        /* 0x7F84C */ public int ProgressionLevel;
        [NMS(Index = 70)]
        /* 0x7F850 */ public int PulseAmmo;
        [NMS(Index = 69)]
        /* 0x7F854 */ public int ScatterAmmo;
        [NMS(Index = 226)]
        /* 0x7F858 */ public int SettlementStateRingBufferIndexV2;
        [NMS(Index = 49)]
        /* 0x7F85C */ public int Shield;
        [NMS(Index = 48)]
        /* 0x7F860 */ public int ShipHealth;
        [NMS(Index = 50)]
        /* 0x7F864 */ public int ShipShield;
        [NMS(Index = 54)]
        /* 0x7F868 */ public int Specials;
        [NMS(Index = 182)]
        /* 0x7F86C */ public GcPlayerWeapons StartingPrimaryWeapon;
        [NMS(Index = 231)]
        /* 0x7F870 */ public int StartingSeasonNumber;
        [NMS(Index = 183)]
        /* 0x7F874 */ public GcPlayerWeapons StartingSecondaryWeapon;
        [NMS(Index = 219)]
        /* 0x7F878 */ public int TelemetryUploadVersion;
        [NMS(Index = 173)]
        /* 0x7F87C */ public int TradingSupplyDataIndex;
        [NMS(Index = 52)]
        /* 0x7F880 */ public int Units;
        [NMS(Index = 220)]
        /* 0x7F884 */ public float VRCameraOffset;
        [NMS(Index = 94)]
        /* 0x7F888 */ public int WarpsLastMiniStation;
        [NMS(Index = 90)]
        /* 0x7F88C */ public int WarpsLastSpaceBattle;
        [NMS(Index = 208)]
        /* 0x7F890 */ public ushort ShopNumber;
        [NMS(Index = 209)]
        /* 0x7F892 */ public ushort ShopTier;
        [NMS(Index = 189, Size = 0x6)]
        /* 0x7F894 */ public NMSString0x20[] CustomTruckPresetNames;
        [NMS(Index = 187, Size = 0x6)]
        /* 0x7F954 */ public NMSString0x20[] OutfitNames;
        [NMS(Index = 252)]
        /* 0x7FA14 */ public NMSString0x80 CorvetteEditShipName;
        [NMS(Index = 3)]
        /* 0x7FA94 */ public NMSString0x80 SaveSummary;
        [NMS(Index = 170)]
        /* 0x7FB14 */ public NMSString0x20 PlayerFreighterName;
        [NMS(Index = 18, Size = 0x12)]
        /* 0x7FB34 */ public bool[] UnlockedPetSlots;
        [NMS(Index = 99, Size = 0x10)]
        /* 0x7FB46 */ public bool[] GalacticMapRequests;
        [NMS(Index = 185, Size = 0xC)]
        /* 0x7FB56 */ public bool[] ShipUsesLegacyColours;
        [NMS(Index = 117, Size = 0x4)]
        /* 0x7FB62 */ public bool[] SquadronUnlockedPilotSlots;
        [NMS(Index = 230)]
        /* 0x7FB66 */ public bool BuildersKnown;
        [NMS(Index = 79)]
        /* 0x7FB67 */ public bool FirstAtlasStationDiscovered;
        [NMS(Index = 112)]
        /* 0x7FB68 */ public bool FreighterDismissed;
        [NMS(Index = 210)]
        /* 0x7FB69 */ public bool HasAccessToNexus;
        [NMS(Index = 245)]
        /* 0x7FB6A */ public bool HasDiscoveredPurpleSystems;
        [NMS(Index = 247)]
        /* 0x7FB6B */ public bool HasGalacticMapRequestAllPurples;
        [NMS(Index = 248)]
        /* 0x7FB6C */ public bool HasGalacticMapRequestFirstPurple;
        [NMS(Index = 83)]
        /* 0x7FB6D */ public bool IsNew;
        [NMS(Index = 168)]
        /* 0x7FB6E */ public bool MultiShipEnabled;
        [NMS(Index = 228)]
        /* 0x7FB6F */ public bool NextLoadSpawnsWithFreshStart;
        [NMS(Index = 178)]
        /* 0x7FB70 */ public bool OnOtherSideOfPortal;
        [NMS(Index = 221)]
        /* 0x7FB71 */ public bool RestartAllInactiveSeasonalMissions;
        [NMS(Index = 102)]
        /* 0x7FB72 */ public bool RevealBlackHoles;
        [NMS(Index = 172)]
        /* 0x7FB73 */ public bool ShipNeedsTerrainPositioning;
        [NMS(Index = 21)]
        /* 0x7FB74 */ public bool SpaceGrave;
        [NMS(Index = 20)]
        /* 0x7FB75 */ public bool SpawnGrave;
        [NMS(Index = 84)]
        /* 0x7FB76 */ public bool UseSmallerBlackholeJumps;
        [NMS(Index = 169)]
        /* 0x7FB77 */ public bool VehicleAIControlEnabled;
    }
}
