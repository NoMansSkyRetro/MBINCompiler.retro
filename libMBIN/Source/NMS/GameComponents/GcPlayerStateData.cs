using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x531481B76DF5C340, NameHash = 0x5E49C3E9)]
    public class GcPlayerStateData : NMSTemplate
    {
        [NMS(Index = 121)]
        /* 0x00000 */ public GcTerrainEditsBuffer TerrainEditData;
        [NMS(Index = 222, Size = 0x64)]
        /* 0x3C780 */ public GcSettlementState[] SettlementStatesV2;
        [NMS(Index = 166, Size = 0x12)]
        /* 0x5DAC0 */ public GcArchivedShipData[] ArchivedShipOwnership;
        [NMS(Index = 165, Size = 0xC)]
        /* 0x64360 */ public GcPlayerOwnershipData[] ShipOwnership;
        [NMS(Index = 14, Size = 0x12)]
        /* 0x67D20 */ public GcArchivedMultitoolData[] ArchivedMultitools;
        [NMS(Index = 116, Size = 0x8)]
        /* 0x6AEA0 */ public GcFreighterSaveData[] FreighterFleet;
        [NMS(Index = 162, Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x6D6A0 */ public GcPlayerOwnershipData[] VehicleOwnership;
        [NMS(Index = 12, Size = 0x6)]
        /* 0x6F850 */ public GcMultitoolData[] Multitools;
        [NMS(Index = 122, Size = 0x5, EnumType = typeof(GcNPCHabitationType.NPCHabitationTypeEnum))]
        /* 0x707B0 */ public GcNPCWorkerData[] NPCWorkers;
        [NMS(Index = 86, Size = 0x10)]
        /* 0x70A30 */ public Vector3f[] PlanetPositions;
        [NMS(Index = 199)]
        /* 0x70B30 */ public GcPlayerSpawnStateData MultiplayerSpawn;
        [NMS(Index = 179)]
        /* 0x70C10 */ public GcTeleportEndpoint OtherSideOfPortalReturnBase;
        [NMS(Index = 164)]
        /* 0x70C90 */ public GcSkiffSaveData SkiffData;
        [NMS(Index = 44)]
        /* 0x70CC0 */ public GcInteractionData HoloExplorerInteraction;
        [NMS(Index = 46)]
        /* 0x70CE0 */ public GcInteractionData HoloNooneInteraction;
        [NMS(Index = 45)]
        /* 0x70D00 */ public GcInteractionData HoloScepticInteraction;
        [NMS(Index = 96)]
        /* 0x70D20 */ public Vector4f AnomalyPositionOverride;
        [NMS(Index = 100)]
        /* 0x70D30 */ public Vector4f FirstShipPosition;
        [NMS(Index = 72)]
        /* 0x70D40 */ public Vector4f FirstSpawnPosition;
        [NMS(Index = 113)]
        /* 0x70D50 */ public Vector3f FreighterMatrixAt;
        [NMS(Index = 115)]
        /* 0x70D60 */ public Vector3f FreighterMatrixPos;
        [NMS(Index = 114)]
        /* 0x70D70 */ public Vector3f FreighterMatrixUp;
        [NMS(Index = 24)]
        /* 0x70D80 */ public Vector4f GraveMatrixLookAt;
        [NMS(Index = 25)]
        /* 0x70D90 */ public Vector4f GraveMatrixUp;
        [NMS(Index = 23)]
        /* 0x70DA0 */ public Vector4f GravePosition;
        [NMS(Index = 209)]
        /* 0x70DB0 */ public Vector3f NexusMatrixAt;
        [NMS(Index = 211)]
        /* 0x70DC0 */ public Vector3f NexusMatrixPos;
        [NMS(Index = 210)]
        /* 0x70DD0 */ public Vector3f NexusMatrixUp;
        [NMS(Index = 180)]
        /* 0x70DE0 */ public Vector4f PortalMarkerPosition_Local;
        [NMS(Index = 181)]
        /* 0x70DF0 */ public Vector4f PortalMarkerPosition_Offset;
        [NMS(Index = 171)]
        /* 0x70E00 */ public Vector4f StartGameShipPosition;
        [NMS(Index = 16, Size = 0x12)]
        /* 0x70E10 */ public GcPetData[] Eggs;
        [NMS(Index = 15, Size = 0x12)]
        /* 0x732A0 */ public GcPetData[] Pets;
        [NMS(Index = 241)]
        /* 0x75730 */ public GcFishingRecord FishingRecord;
        [NMS(Index = 17, Size = 0x12)]
        /* 0x76F30 */ public GcPetCustomisationData[] PetAccessoryCustomisation;
        [NMS(Index = 184, Size = 0x1A, EnumType = typeof(GcCustomisationComponentData.CustomisationDataTypeEnum))]
        /* 0x78520 */ public GcCharacterCustomisationSaveData[] CharacterCustomisationData;
        [NMS(Index = 202, Size = 0x3, EnumType = typeof(GcHotActionMenuTypes.HotActionMenuTypesEnum))]
        /* 0x78FB0 */ public GcHotActionsSaveData[] HotActions;
        [NMS(Index = 118, Size = 0x4)]
        /* 0x79370 */ public GcSquadronPilotData[] SquadronPilots;
        [NMS(Index = 230, Size = 0xF, EnumType = typeof(GcWonderCreatureCategory.WonderCreatureCategoryEnum))]
        /* 0x795F0 */ public GcWonderRecord[] WonderCreatureRecords;
        [NMS(Index = 144)]
        /* 0x79758 */ public GcInventoryContainer Chest10Inventory;
        [NMS(Index = 126)]
        /* 0x798B8 */ public GcInventoryContainer Chest1Inventory;
        [NMS(Index = 128)]
        /* 0x79A18 */ public GcInventoryContainer Chest2Inventory;
        [NMS(Index = 130)]
        /* 0x79B78 */ public GcInventoryContainer Chest3Inventory;
        [NMS(Index = 132)]
        /* 0x79CD8 */ public GcInventoryContainer Chest4Inventory;
        [NMS(Index = 134)]
        /* 0x79E38 */ public GcInventoryContainer Chest5Inventory;
        [NMS(Index = 136)]
        /* 0x79F98 */ public GcInventoryContainer Chest6Inventory;
        [NMS(Index = 138)]
        /* 0x7A0F8 */ public GcInventoryContainer Chest7Inventory;
        [NMS(Index = 140)]
        /* 0x7A258 */ public GcInventoryContainer Chest8Inventory;
        [NMS(Index = 142)]
        /* 0x7A3B8 */ public GcInventoryContainer Chest9Inventory;
        [NMS(Index = 148)]
        /* 0x7A518 */ public GcInventoryContainer ChestMagic2Inventory;
        [NMS(Index = 146)]
        /* 0x7A678 */ public GcInventoryContainer ChestMagicInventory;
        [NMS(Index = 150)]
        /* 0x7A7D8 */ public GcInventoryContainer CookingIngredientsInventory;
        [NMS(Index = 160)]
        /* 0x7A938 */ public GcInventoryContainer CorvetteStorageInventory;
        [NMS(Index = 156)]
        /* 0x7AA98 */ public GcInventoryContainer FishBaitBoxInventory;
        [NMS(Index = 154)]
        /* 0x7ABF8 */ public GcInventoryContainer FishPlatformInventory;
        [NMS(Index = 158)]
        /* 0x7AD58 */ public GcInventoryContainer FoodUnitInventory;
        [NMS(Index = 107)]
        /* 0x7AEB8 */ public GcInventoryContainer FreighterInventory;
        [NMS(Index = 109)]
        /* 0x7B018 */ public GcInventoryContainer FreighterInventory_Cargo;
        [NMS(Index = 108)]
        /* 0x7B178 */ public GcInventoryContainer FreighterInventory_TechOnly;
        [NMS(Index = 19)]
        /* 0x7B2D8 */ public GcInventoryContainer GraveInventory;
        [NMS(Index = 6)]
        /* 0x7B438 */ public GcInventoryContainer Inventory;
        [NMS(Index = 8)]
        /* 0x7B598 */ public GcInventoryContainer Inventory_Cargo;
        [NMS(Index = 7)]
        /* 0x7B6F8 */ public GcInventoryContainer Inventory_TechOnly;
        [NMS(Index = 152)]
        /* 0x7B858 */ public GcInventoryContainer RocketLockerInventory;
        [NMS(Index = 9)]
        /* 0x7B9B8 */ public GcInventoryContainer ShipInventory;
        [NMS(Index = 10)]
        /* 0x7BB18 */ public GcInventoryContainer WeaponInventory;
        [NMS(Index = 233, Size = 0xD, EnumType = typeof(GcWonderTreasureCategory.WonderTreasureCategoryEnum))]
        /* 0x7BC78 */ public GcWonderRecord[] WonderTreasureRecords;
        [NMS(Index = 224, Size = 0x4)]
        /* 0x7BDB0 */ public GcSettlementHistory[] SettlementHistory;
        [NMS(Index = 235, Size = 0xC, EnumType = typeof(GcWonderCustomCategory.WonderCustomCategoryEnum))]
        /* 0x7BED0 */ public GcWonderRecord[] WonderCustomRecords;
        [NMS(Index = 186, Size = 0x3)]
        /* 0x7BFF0 */ public GcCharacterCustomisationData[] Outfits;
        [NMS(Index = 63, Size = 0xB, EnumType = typeof(GcInteractionBufferType.InteractionBufferTypeEnum))]
        /* 0x7C0F8 */ public GcInteractionBuffer[] StoredInteractions;
        [NMS(Index = 229, Size = 0xB, EnumType = typeof(GcWonderPlanetCategory.WonderPlanetCategoryEnum))]
        /* 0x7C200 */ public GcWonderRecord[] WonderPlanetRecords;
        [NMS(Index = 234, Size = 0xB, EnumType = typeof(GcWonderWeirdBasePartCategory.WonderWeirdBasePartCategoryEnum))]
        /* 0x7C308 */ public GcWonderRecord[] WonderWeirdBasePartRecords;
        [NMS(Index = 87, Size = 0x10)]
        /* 0x7C410 */ public GcSeed[] PlanetSeeds;
        [NMS(Index = 231, Size = 0x8, EnumType = typeof(GcWonderFloraCategory.WonderFloraCategoryEnum))]
        /* 0x7C510 */ public GcWonderRecord[] WonderFloraRecords;
        [NMS(Index = 232, Size = 0x8, EnumType = typeof(GcWonderMineralCategory.WonderMineralCategoryEnum))]
        /* 0x7C5D0 */ public GcWonderRecord[] WonderMineralRecords;
        [NMS(Index = 226, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x7C690 */ public GcStoryPageSeenDataArray[] SeenStories;
        [NMS(Index = 104)]
        /* 0x7C720 */ public GcResourceElement CurrentFreighter;
        [NMS(Index = 161)]
        /* 0x7C768 */ public GcResourceElement CurrentFreighterNPC;
        [NMS(Index = 28)]
        /* 0x7C7B0 */ public GcResourceElement CurrentShip;
        [NMS(Index = 237, Size = 0x4, EnumType = typeof(GcSynchronisedBufferType.SyncBufferTypeEnum))]
        /* 0x7C7F8 */ public GcSyncBufferSaveDataArray[] SyncBuffersData;
        [NMS(Index = 29)]
        /* 0x7C838 */ public GcExactResource CurrentWeapon;
        [NMS(Index = 176)]
        /* 0x7C858 */ public GcPortalSaveData VisitedPortal;
        [NMS(Index = 143)]
        /* 0x7C878 */ public GcInventoryLayout Chest10Layout;
        [NMS(Index = 125)]
        /* 0x7C890 */ public GcInventoryLayout Chest1Layout;
        [NMS(Index = 127)]
        /* 0x7C8A8 */ public GcInventoryLayout Chest2Layout;
        [NMS(Index = 129)]
        /* 0x7C8C0 */ public GcInventoryLayout Chest3Layout;
        [NMS(Index = 131)]
        /* 0x7C8D8 */ public GcInventoryLayout Chest4Layout;
        [NMS(Index = 133)]
        /* 0x7C8F0 */ public GcInventoryLayout Chest5Layout;
        [NMS(Index = 135)]
        /* 0x7C908 */ public GcInventoryLayout Chest6Layout;
        [NMS(Index = 137)]
        /* 0x7C920 */ public GcInventoryLayout Chest7Layout;
        [NMS(Index = 139)]
        /* 0x7C938 */ public GcInventoryLayout Chest8Layout;
        [NMS(Index = 141)]
        /* 0x7C950 */ public GcInventoryLayout Chest9Layout;
        [NMS(Index = 147)]
        /* 0x7C968 */ public GcInventoryLayout ChestMagic2Layout;
        [NMS(Index = 145)]
        /* 0x7C980 */ public GcInventoryLayout ChestMagicLayout;
        [NMS(Index = 149)]
        /* 0x7C998 */ public GcInventoryLayout CookingIngredientsLayout;
        [NMS(Index = 159)]
        /* 0x7C9B0 */ public GcInventoryLayout CorvetteStorageLayout;
        [NMS(Index = 155)]
        /* 0x7C9C8 */ public GcInventoryLayout FishBaitBoxLayout;
        [NMS(Index = 153)]
        /* 0x7C9E0 */ public GcInventoryLayout FishPlatformLayout;
        [NMS(Index = 157)]
        /* 0x7C9F8 */ public GcInventoryLayout FoodUnitLayout;
        [NMS(Index = 106)]
        /* 0x7CA10 */ public GcInventoryLayout FreighterCargoLayout;
        [NMS(Index = 105)]
        /* 0x7CA28 */ public GcInventoryLayout FreighterLayout;
        [NMS(Index = 151)]
        /* 0x7CA40 */ public GcInventoryLayout RocketLockerLayout;
        [NMS(Index = 26)]
        /* 0x7CA58 */ public GcInventoryLayout ShipLayout;
        [NMS(Index = 27)]
        /* 0x7CA70 */ public GcInventoryLayout WeaponLayout;
        [NMS(Index = 215)]
        /* 0x7CA88 */ public NMSString0x10 BannerTitleId;
        [NMS(Index = 120)]
        /* 0x7CA98 */ public List<GcPersistentBBObjectData> BaseBuildingObjects;
        [NMS(Index = 103)]
        /* 0x7CAA8 */ public GcSeed CurrentFreighterHomeSystemSeed;
        [NMS(Index = 38)]
        /* 0x7CAB8 */ public NMSString0x10 CurrentMissionID;
        [NMS(Index = 192)]
        /* 0x7CAC8 */ public List<ulong> ExpeditionSeedsSelectedToday;
        [NMS(Index = 191)]
        /* 0x7CAD8 */ public List<GcFleetExpeditionSaveData> FleetExpeditions;
        [NMS(Index = 190)]
        /* 0x7CAE8 */ public List<GcFleetFrigateSaveData> FleetFrigates;
        [NMS(Index = 189)]
        /* 0x7CAF8 */ public GcSeed FleetSeed;
        [NMS(Index = 196)]
        /* 0x7CB08 */ public NMSString0x10 FoodUnitItem;
        [NMS(Index = 188)]
        /* 0x7CB18 */ public NMSString0x10 FreighterEngineEffect;
        [NMS(Index = 240)]
        /* 0x7CB28 */ public List<GcGalaxyWaypoint> GalaxyWaypoints;
        [NMS(Index = 75)]
        /* 0x7CB38 */ public List<NMSString0x20A> InteractionProgressTable;
        [NMS(Index = 187)]
        /* 0x7CB48 */ public NMSString0x10 JetpackEffect;
        [NMS(Index = 31)]
        /* 0x7CB58 */ public List<NMSString0x10> KnownProducts;
        [NMS(Index = 33)]
        /* 0x7CB68 */ public List<NMSString0x20A> KnownRefinerRecipes;
        [NMS(Index = 32)]
        /* 0x7CB78 */ public List<NMSString0x10> KnownSpecials;
        [NMS(Index = 30)]
        /* 0x7CB88 */ public List<NMSString0x10> KnownTech;
        [NMS(Index = 35)]
        /* 0x7CB98 */ public List<GcWordGroupKnowledge> KnownWordGroups;
        [NMS(Index = 34)]
        /* 0x7CBA8 */ public List<GcWordKnowledge> KnownWords;
        [NMS(Index = 175)]
        /* 0x7CBB8 */ public List<GcPortalSaveData> LastPortal;
        [NMS(Index = 64)]
        /* 0x7CBC8 */ public List<GcMaintenanceContainer> MaintenanceInteractions;
        [NMS(Index = 56)]
        /* 0x7CBD8 */ public List<GcScanEventSave> MarkerStack;
        [NMS(Index = 36)]
        /* 0x7CBE8 */ public List<GcPlayerMissionProgress> MissionProgress;
        [NMS(Index = 43)]
        /* 0x7CBF8 */ public List<GcMissionIDEpochPair> MissionRecurrences;
        [NMS(Index = 57)]
        /* 0x7CC08 */ public List<GcScanEventSave> NewMPMarkerStack;
        [NMS(Index = 123)]
        /* 0x7CC18 */ public List<GcPersistentBase> PersistentPlayerBases;
        [NMS(Index = 65)]
        /* 0x7CC28 */ public List<GcMaintenanceContainer> PersonalMaintenanceInteractions;
        [NMS(Index = 40)]
        /* 0x7CC38 */ public NMSString0x10 PreviousMissionID;
        [NMS(Index = 221)]
        /* 0x7CC48 */ public List<NMSString0x10> RedeemedPlatformRewards;
        [NMS(Index = 219)]
        /* 0x7CC58 */ public List<NMSString0x10> RedeemedSeasonRewards;
        [NMS(Index = 220)]
        /* 0x7CC68 */ public List<NMSString0x10> RedeemedTwitchRewards;
        [NMS(Index = 239)]
        /* 0x7CC78 */ public List<GcMaintenanceContainer> RefinerBufferData;
        [NMS(Index = 238)]
        /* 0x7CC88 */ public List<GcMaintenanceSaveKey> RefinerBufferKeys;
        [NMS(Index = 200)]
        /* 0x7CC98 */ public List<GcRepairTechData> RepairTechBuffer;
        [NMS(Index = 74)]
        /* 0x7CCA8 */ public List<GcSavedInteractionDialogData> SavedInteractionDialogTable;
        [NMS(Index = 119)]
        /* 0x7CCB8 */ public List<NMSString0x10> SeenBaseBuildingObjects;
        [NMS(Index = 247)]
        /* 0x7CCC8 */ public List<GcSettlementLocalSaveData> SettlementLocalSaveData;
        [NMS(Index = 61)]
        /* 0x7CCD8 */ public List<GcPlayerStatsGroup> Stats;
        [NMS(Index = 58)]
        /* 0x7CCE8 */ public List<Vector3f> SurveyedEventPositions;
        [NMS(Index = 62)]
        /* 0x7CCF8 */ public List<GcTelemetryStat> TelemetryStats;
        [NMS(Index = 124)]
        /* 0x7CD08 */ public List<GcTeleportEndpoint> TeleportEndpoints;
        [NMS(Index = 174)]
        /* 0x7CD18 */ public List<GcTradingSupplyData> TradingSupplyData;
        [NMS(Index = 85)]
        /* 0x7CD28 */ public List<GcSavedEntitlement> UsedEntitlements;
        [NMS(Index = 78)]
        /* 0x7CD38 */ public List<GcUniverseAddressData> VisitedAtlasStationsData;
        [NMS(Index = 66)]
        /* 0x7CD48 */ public List<ulong> VisitedSystems;
        [NMS(Index = 11)]
        /* 0x7CD58 */ public List<GcInWorldUIScreenData> WristScreenData;
        [NMS(Index = 91)]
        /* 0x7CD68 */ public ulong ActiveSpaceBattleUA;
        [NMS(Index = 250)]
        /* 0x7CD70 */ public ulong CorvetteDraftShipSeed;
        [NMS(Index = 39)]
        /* 0x7CD78 */ public ulong CurrentMissionSeed;
        [NMS(Index = 243)]
        /* 0x7CD80 */ public ulong FirstPurpleSystemUA;
        [NMS(Index = 110)]
        /* 0x7CD88 */ public ulong FreighterLastSpawnTime;
        [NMS(Index = 101)]
        /* 0x7CD90 */ public ulong HazardTimeAlive;
        [NMS(Index = 60)]
        /* 0x7CD98 */ public ulong LastCheckedForStatResetsTime;
        [NMS(Index = 193)]
        /* 0x7CDA0 */ public ulong LastKnownDay;
        [NMS(Index = 203)]
        /* 0x7CDA8 */ public ulong LastUABeforePortalWarp;
        [NMS(Index = 95)]
        /* 0x7CDB0 */ public ulong MiniStationUA;
        [NMS(Index = 197)]
        /* 0x7CDB8 */ public ulong MultiplayerLobbyID;
        [NMS(Index = 201)]
        /* 0x7CDC0 */ public ulong MultiplayerPrivileges;
        [NMS(Index = 41)]
        /* 0x7CDC8 */ public ulong PreviousMissionSeed;
        [NMS(Index = 204)]
        /* 0x7CDD0 */ public ulong StoryPortalSeed;
        [NMS(Index = 194)]
        /* 0x7CDD8 */ public ulong SunTimer;
        [NMS(Index = 246)]
        /* 0x7CDE0 */ public ulong TaggedPlanetUA;
        [NMS(Index = 55)]
        /* 0x7CDE8 */ public ulong TimeAlive;
        [NMS(Index = 93)]
        /* 0x7CDF0 */ public ulong TimeLastMiniStation;
        [NMS(Index = 89)]
        /* 0x7CDF8 */ public ulong TimeLastSpaceBattle;
        [NMS(Index = 5)]
        /* 0x7CE00 */ public ulong TimeStamp;
        [NMS(Index = 73, Size = 0x99, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x7CE08 */ public GcSavedInteractionRaceData[] SavedInteractionIndicies;
        [NMS(Index = 236, Size = 0xC, EnumType = typeof(GcWonderCustomCategory.WonderCustomCategoryEnum))]
        /* 0x7EAB8 */ public GcWonderRecordCustomData[] WonderCustomRecordsExtraData;
        [NMS(Index = 80, Size = 0xB)]
        /* 0x7EDE8 */ public GcUniverseAddressData[] CompletedAtlasAddresses;
        [NMS(Index = 77, Size = 0xB)]
        /* 0x7EEF0 */ public GcUniverseAddressData[] NewAtlasStationAdressData;
        [NMS(Index = 76, Size = 0xA)]
        /* 0x7EFF8 */ public GcUniverseAddressData[] AtlasStationAdressData;
        [NMS(Index = 4)]
        /* 0x7F0E8 */ public GcDifficultyStateData DifficultyState;
        [NMS(Index = 67, Size = 0x7, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x7F154 */ public float[] Hazard;
        [NMS(Index = 111)]
        /* 0x7F170 */ public GcUniverseAddressData FreighterUniverseAddress;
        [NMS(Index = 97)]
        /* 0x7F188 */ public GcUniverseAddressData GameStartAddress1;
        [NMS(Index = 98)]
        /* 0x7F1A0 */ public GcUniverseAddressData GameStartAddress2;
        [NMS(Index = 22)]
        /* 0x7F1B8 */ public GcUniverseAddressData GraveUniverseAddress;
        [NMS(Index = 198)]
        /* 0x7F1D0 */ public GcUniverseAddressData MultiplayerUA;
        [NMS(Index = 208)]
        /* 0x7F1E8 */ public GcUniverseAddressData NexusUniverseAddress;
        [NMS(Index = 1)]
        /* 0x7F200 */ public GcUniverseAddressData PreviousUniverseAddress;
        [NMS(Index = 0)]
        /* 0x7F218 */ public GcUniverseAddressData UniverseAddress;
        [NMS(Index = 13)]
        /* 0x7F230 */ public int ActiveMultioolIndex;
        [NMS(Index = 92)]
        /* 0x7F234 */ public int ActiveSpaceBattleLevel;
        [NMS(Index = 214)]
        /* 0x7F238 */ public int BannerBackgroundColour;
        [NMS(Index = 212)]
        /* 0x7F23C */ public int BannerIcon;
        [NMS(Index = 213)]
        /* 0x7F240 */ public int BannerMainColour;
        [NMS(Index = 68)]
        /* 0x7F244 */ public int BoltAmmo;
        [NMS(Index = 248)]
        /* 0x7F248 */ public int CorvetteEditAssociatedShipIndex;
        [NMS(Index = 51)]
        /* 0x7F24C */ public int Energy;
        [NMS(Index = 195)]
        /* 0x7F250 */ public float FoodUnitAccumulator;
        [NMS(Index = 47)]
        /* 0x7F254 */ public int Health;
        [NMS(Index = 2)]
        /* 0x7F258 */ public int HomeRealityIteration;
        [NMS(Index = 177)]
        /* 0x7F25C */ public int KnownPortalRunes;
        [NMS(Index = 71)]
        /* 0x7F260 */ public int LaserAmmo;
        [NMS(Index = 42)]
        /* 0x7F264 */ public int MissionVersion;
        [NMS(Index = 53)]
        /* 0x7F268 */ public int Nanites;
        [NMS(Index = 59)]
        /* 0x7F26C */ public int NextSurveyedEventPositionIndex;
        [NMS(Index = 37)]
        /* 0x7F270 */ public int PostMissionIndex;
        [NMS(Index = 88)]
        /* 0x7F274 */ public int PrimaryPlanet;
        [NMS(Index = 167)]
        /* 0x7F278 */ public int PrimaryShip;
        [NMS(Index = 163)]
        /* 0x7F27C */ public int PrimaryVehicle;
        [NMS(Index = 82)]
        /* 0x7F280 */ public int ProcTechIndex;
        [NMS(Index = 81)]
        /* 0x7F284 */ public int ProgressionLevel;
        [NMS(Index = 70)]
        /* 0x7F288 */ public int PulseAmmo;
        [NMS(Index = 69)]
        /* 0x7F28C */ public int ScatterAmmo;
        [NMS(Index = 223)]
        /* 0x7F290 */ public int SettlementStateRingBufferIndexV2;
        [NMS(Index = 49)]
        /* 0x7F294 */ public int Shield;
        [NMS(Index = 48)]
        /* 0x7F298 */ public int ShipHealth;
        [NMS(Index = 50)]
        /* 0x7F29C */ public int ShipShield;
        [NMS(Index = 54)]
        /* 0x7F2A0 */ public int Specials;
        [NMS(Index = 182)]
        /* 0x7F2A4 */ public GcPlayerWeapons StartingPrimaryWeapon;
        [NMS(Index = 228)]
        /* 0x7F2A8 */ public int StartingSeasonNumber;
        [NMS(Index = 183)]
        /* 0x7F2AC */ public GcPlayerWeapons StartingSecondaryWeapon;
        [NMS(Index = 216)]
        /* 0x7F2B0 */ public int TelemetryUploadVersion;
        [NMS(Index = 173)]
        /* 0x7F2B4 */ public int TradingSupplyDataIndex;
        [NMS(Index = 52)]
        /* 0x7F2B8 */ public int Units;
        [NMS(Index = 217)]
        /* 0x7F2BC */ public float VRCameraOffset;
        [NMS(Index = 94)]
        /* 0x7F2C0 */ public int WarpsLastMiniStation;
        [NMS(Index = 90)]
        /* 0x7F2C4 */ public int WarpsLastSpaceBattle;
        [NMS(Index = 205)]
        /* 0x7F2C8 */ public ushort ShopNumber;
        [NMS(Index = 206)]
        /* 0x7F2CA */ public ushort ShopTier;
        [NMS(Index = 249)]
        /* 0x7F2CC */ public NMSString0x80 CorvetteEditShipName;
        [NMS(Index = 3)]
        /* 0x7F34C */ public NMSString0x80 SaveSummary;
        [NMS(Index = 170)]
        /* 0x7F3CC */ public NMSString0x20 PlayerFreighterName;
        [NMS(Index = 18, Size = 0x12)]
        /* 0x7F3EC */ public bool[] UnlockedPetSlots;
        [NMS(Index = 99, Size = 0x10)]
        /* 0x7F3FE */ public bool[] GalacticMapRequests;
        [NMS(Index = 185, Size = 0xC)]
        /* 0x7F40E */ public bool[] ShipUsesLegacyColours;
        [NMS(Index = 117, Size = 0x4)]
        /* 0x7F41A */ public bool[] SquadronUnlockedPilotSlots;
        [NMS(Index = 227)]
        /* 0x7F41E */ public bool BuildersKnown;
        [NMS(Index = 79)]
        /* 0x7F41F */ public bool FirstAtlasStationDiscovered;
        [NMS(Index = 112)]
        /* 0x7F420 */ public bool FreighterDismissed;
        [NMS(Index = 207)]
        /* 0x7F421 */ public bool HasAccessToNexus;
        [NMS(Index = 242)]
        /* 0x7F422 */ public bool HasDiscoveredPurpleSystems;
        [NMS(Index = 244)]
        /* 0x7F423 */ public bool HasGalacticMapRequestAllPurples;
        [NMS(Index = 245)]
        /* 0x7F424 */ public bool HasGalacticMapRequestFirstPurple;
        [NMS(Index = 83)]
        /* 0x7F425 */ public bool IsNew;
        [NMS(Index = 168)]
        /* 0x7F426 */ public bool MultiShipEnabled;
        [NMS(Index = 225)]
        /* 0x7F427 */ public bool NextLoadSpawnsWithFreshStart;
        [NMS(Index = 178)]
        /* 0x7F428 */ public bool OnOtherSideOfPortal;
        [NMS(Index = 218)]
        /* 0x7F429 */ public bool RestartAllInactiveSeasonalMissions;
        [NMS(Index = 102)]
        /* 0x7F42A */ public bool RevealBlackHoles;
        [NMS(Index = 172)]
        /* 0x7F42B */ public bool ShipNeedsTerrainPositioning;
        [NMS(Index = 21)]
        /* 0x7F42C */ public bool SpaceGrave;
        [NMS(Index = 20)]
        /* 0x7F42D */ public bool SpawnGrave;
        [NMS(Index = 84)]
        /* 0x7F42E */ public bool UseSmallerBlackholeJumps;
        [NMS(Index = 169)]
        /* 0x7F42F */ public bool VehicleAIControlEnabled;
    }
}
