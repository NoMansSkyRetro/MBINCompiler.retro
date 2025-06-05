using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x66DF599B755917AB, NameHash = 0x5E49C3E9)]
    public class GcPlayerStateData : NMSTemplate
    {
        [NMS(Index = 120)]
        /* 0x00000 */ public GcTerrainEditsBuffer TerrainEditData;
        [NMS(Index = 219, Size = 0x64)]
        /* 0x3C780 */ public GcSettlementState[] SettlementStatesV2;
        [NMS(Index = 163, Size = 0x12)]
        /* 0x5D480 */ public GcArchivedShipData[] ArchivedShipOwnership;
        [NMS(Index = 162, Size = 0xC)]
        /* 0x63AE0 */ public GcPlayerOwnershipData[] ShipOwnership;
        [NMS(Index = 14, Size = 0x12)]
        /* 0x67320 */ public GcArchivedMultitoolData[] ArchivedMultitools;
        [NMS(Index = 159, Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x6A380 */ public GcPlayerOwnershipData[] VehicleOwnership;
        [NMS(Index = 12, Size = 0x6)]
        /* 0x6C450 */ public GcMultitoolData[] Multitools;
        [NMS(Index = 121, Size = 0x5, EnumType = typeof(GcNPCHabitationType.NPCHabitationTypeEnum))]
        /* 0x6D350 */ public GcNPCWorkerData[] NPCWorkers;
        [NMS(Index = 86, Size = 0x10)]
        /* 0x6D5D0 */ public Vector3f[] PlanetPositions;
        [NMS(Index = 196)]
        /* 0x6D6D0 */ public GcPlayerSpawnStateData MultiplayerSpawn;
        [NMS(Index = 176)]
        /* 0x6D7A0 */ public GcTeleportEndpoint OtherSideOfPortalReturnBase;
        [NMS(Index = 161)]
        /* 0x6D820 */ public GcSkiffSaveData SkiffData;
        [NMS(Index = 44)]
        /* 0x6D850 */ public GcInteractionData HoloExplorerInteraction;
        [NMS(Index = 46)]
        /* 0x6D870 */ public GcInteractionData HoloNooneInteraction;
        [NMS(Index = 45)]
        /* 0x6D890 */ public GcInteractionData HoloScepticInteraction;
        [NMS(Index = 96)]
        /* 0x6D8B0 */ public Vector4f AnomalyPositionOverride;
        [NMS(Index = 100)]
        /* 0x6D8C0 */ public Vector4f FirstShipPosition;
        [NMS(Index = 72)]
        /* 0x6D8D0 */ public Vector4f FirstSpawnPosition;
        [NMS(Index = 113)]
        /* 0x6D8E0 */ public Vector3f FreighterMatrixAt;
        [NMS(Index = 115)]
        /* 0x6D8F0 */ public Vector3f FreighterMatrixPos;
        [NMS(Index = 114)]
        /* 0x6D900 */ public Vector3f FreighterMatrixUp;
        [NMS(Index = 24)]
        /* 0x6D910 */ public Vector4f GraveMatrixLookAt;
        [NMS(Index = 25)]
        /* 0x6D920 */ public Vector4f GraveMatrixUp;
        [NMS(Index = 23)]
        /* 0x6D930 */ public Vector4f GravePosition;
        [NMS(Index = 206)]
        /* 0x6D940 */ public Vector3f NexusMatrixAt;
        [NMS(Index = 208)]
        /* 0x6D950 */ public Vector3f NexusMatrixPos;
        [NMS(Index = 207)]
        /* 0x6D960 */ public Vector3f NexusMatrixUp;
        [NMS(Index = 177)]
        /* 0x6D970 */ public Vector4f PortalMarkerPosition_Local;
        [NMS(Index = 178)]
        /* 0x6D980 */ public Vector4f PortalMarkerPosition_Offset;
        [NMS(Index = 168)]
        /* 0x6D990 */ public Vector4f StartGameShipPosition;
        [NMS(Index = 16, Size = 0x12)]
        /* 0x6D9A0 */ public GcPetData[] Eggs;
        [NMS(Index = 15, Size = 0x12)]
        /* 0x6FE30 */ public GcPetData[] Pets;
        [NMS(Index = 238)]
        /* 0x722C0 */ public GcFishingRecord FishingRecord;
        [NMS(Index = 17, Size = 0x12)]
        /* 0x73AC0 */ public GcPetCustomisationData[] PetAccessoryCustomisation;
        [NMS(Index = 181, Size = 0x1A, EnumType = typeof(GcCustomisationComponentData.CustomisationDataTypeEnum))]
        /* 0x750B0 */ public GcCharacterCustomisationSaveData[] CharacterCustomisationData;
        [NMS(Index = 199, Size = 0x3, EnumType = typeof(GcHotActionMenuTypes.HotActionMenuTypesEnum))]
        /* 0x75B40 */ public GcHotActionsSaveData[] HotActions;
        [NMS(Index = 117, Size = 0x4)]
        /* 0x75F00 */ public GcSquadronPilotData[] SquadronPilots;
        [NMS(Index = 227, Size = 0xF, EnumType = typeof(GcWonderCreatureCategory.WonderCreatureCategoryEnum))]
        /* 0x76180 */ public GcWonderRecord[] WonderCreatureRecords;
        [NMS(Index = 143)]
        /* 0x762E8 */ public GcInventoryContainer Chest10Inventory;
        [NMS(Index = 125)]
        /* 0x76440 */ public GcInventoryContainer Chest1Inventory;
        [NMS(Index = 127)]
        /* 0x76598 */ public GcInventoryContainer Chest2Inventory;
        [NMS(Index = 129)]
        /* 0x766F0 */ public GcInventoryContainer Chest3Inventory;
        [NMS(Index = 131)]
        /* 0x76848 */ public GcInventoryContainer Chest4Inventory;
        [NMS(Index = 133)]
        /* 0x769A0 */ public GcInventoryContainer Chest5Inventory;
        [NMS(Index = 135)]
        /* 0x76AF8 */ public GcInventoryContainer Chest6Inventory;
        [NMS(Index = 137)]
        /* 0x76C50 */ public GcInventoryContainer Chest7Inventory;
        [NMS(Index = 139)]
        /* 0x76DA8 */ public GcInventoryContainer Chest8Inventory;
        [NMS(Index = 141)]
        /* 0x76F00 */ public GcInventoryContainer Chest9Inventory;
        [NMS(Index = 147)]
        /* 0x77058 */ public GcInventoryContainer ChestMagic2Inventory;
        [NMS(Index = 145)]
        /* 0x771B0 */ public GcInventoryContainer ChestMagicInventory;
        [NMS(Index = 149)]
        /* 0x77308 */ public GcInventoryContainer CookingIngredientsInventory;
        [NMS(Index = 155)]
        /* 0x77460 */ public GcInventoryContainer FishBaitBoxInventory;
        [NMS(Index = 153)]
        /* 0x775B8 */ public GcInventoryContainer FishPlatformInventory;
        [NMS(Index = 157)]
        /* 0x77710 */ public GcInventoryContainer FoodUnitInventory;
        [NMS(Index = 107)]
        /* 0x77868 */ public GcInventoryContainer FreighterInventory;
        [NMS(Index = 109)]
        /* 0x779C0 */ public GcInventoryContainer FreighterInventory_Cargo;
        [NMS(Index = 108)]
        /* 0x77B18 */ public GcInventoryContainer FreighterInventory_TechOnly;
        [NMS(Index = 19)]
        /* 0x77C70 */ public GcInventoryContainer GraveInventory;
        [NMS(Index = 6)]
        /* 0x77DC8 */ public GcInventoryContainer Inventory;
        [NMS(Index = 8)]
        /* 0x77F20 */ public GcInventoryContainer Inventory_Cargo;
        [NMS(Index = 7)]
        /* 0x78078 */ public GcInventoryContainer Inventory_TechOnly;
        [NMS(Index = 151)]
        /* 0x781D0 */ public GcInventoryContainer RocketLockerInventory;
        [NMS(Index = 9)]
        /* 0x78328 */ public GcInventoryContainer ShipInventory;
        [NMS(Index = 10)]
        /* 0x78480 */ public GcInventoryContainer WeaponInventory;
        [NMS(Index = 230, Size = 0xD, EnumType = typeof(GcWonderTreasureCategory.WonderTreasureCategoryEnum))]
        /* 0x785D8 */ public GcWonderRecord[] WonderTreasureRecords;
        [NMS(Index = 221, Size = 0x4)]
        /* 0x78710 */ public GcSettlementHistory[] SettlementHistory;
        [NMS(Index = 232, Size = 0xC, EnumType = typeof(GcWonderCustomCategory.WonderCustomCategoryEnum))]
        /* 0x78830 */ public GcWonderRecord[] WonderCustomRecords;
        [NMS(Index = 183, Size = 0x3)]
        /* 0x78950 */ public GcCharacterCustomisationData[] Outfits;
        [NMS(Index = 63, Size = 0xB, EnumType = typeof(GcInteractionBufferType.InteractionBufferTypeEnum))]
        /* 0x78A58 */ public GcInteractionBuffer[] StoredInteractions;
        [NMS(Index = 226, Size = 0xB, EnumType = typeof(GcWonderPlanetCategory.WonderPlanetCategoryEnum))]
        /* 0x78B60 */ public GcWonderRecord[] WonderPlanetRecords;
        [NMS(Index = 231, Size = 0xB, EnumType = typeof(GcWonderWeirdBasePartCategory.WonderWeirdBasePartCategoryEnum))]
        /* 0x78C68 */ public GcWonderRecord[] WonderWeirdBasePartRecords;
        [NMS(Index = 87, Size = 0x10)]
        /* 0x78D70 */ public GcSeed[] PlanetSeeds;
        [NMS(Index = 228, Size = 0x8, EnumType = typeof(GcWonderFloraCategory.WonderFloraCategoryEnum))]
        /* 0x78E70 */ public GcWonderRecord[] WonderFloraRecords;
        [NMS(Index = 229, Size = 0x8, EnumType = typeof(GcWonderMineralCategory.WonderMineralCategoryEnum))]
        /* 0x78F30 */ public GcWonderRecord[] WonderMineralRecords;
        [NMS(Index = 223, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x78FF0 */ public GcStoryPageSeenDataArray[] SeenStories;
        [NMS(Index = 104)]
        /* 0x79080 */ public GcResourceElement CurrentFreighter;
        [NMS(Index = 158)]
        /* 0x790C8 */ public GcResourceElement CurrentFreighterNPC;
        [NMS(Index = 28)]
        /* 0x79110 */ public GcResourceElement CurrentShip;
        [NMS(Index = 234, Size = 0x4, EnumType = typeof(GcSynchronisedBufferType.SyncBufferTypeEnum))]
        /* 0x79158 */ public GcSyncBufferSaveDataArray[] SyncBuffersData;
        [NMS(Index = 29)]
        /* 0x79198 */ public GcExactResource CurrentWeapon;
        [NMS(Index = 173)]
        /* 0x791B8 */ public GcPortalSaveData VisitedPortal;
        [NMS(Index = 142)]
        /* 0x791D8 */ public GcInventoryLayout Chest10Layout;
        [NMS(Index = 124)]
        /* 0x791F0 */ public GcInventoryLayout Chest1Layout;
        [NMS(Index = 126)]
        /* 0x79208 */ public GcInventoryLayout Chest2Layout;
        [NMS(Index = 128)]
        /* 0x79220 */ public GcInventoryLayout Chest3Layout;
        [NMS(Index = 130)]
        /* 0x79238 */ public GcInventoryLayout Chest4Layout;
        [NMS(Index = 132)]
        /* 0x79250 */ public GcInventoryLayout Chest5Layout;
        [NMS(Index = 134)]
        /* 0x79268 */ public GcInventoryLayout Chest6Layout;
        [NMS(Index = 136)]
        /* 0x79280 */ public GcInventoryLayout Chest7Layout;
        [NMS(Index = 138)]
        /* 0x79298 */ public GcInventoryLayout Chest8Layout;
        [NMS(Index = 140)]
        /* 0x792B0 */ public GcInventoryLayout Chest9Layout;
        [NMS(Index = 146)]
        /* 0x792C8 */ public GcInventoryLayout ChestMagic2Layout;
        [NMS(Index = 144)]
        /* 0x792E0 */ public GcInventoryLayout ChestMagicLayout;
        [NMS(Index = 148)]
        /* 0x792F8 */ public GcInventoryLayout CookingIngredientsLayout;
        [NMS(Index = 154)]
        /* 0x79310 */ public GcInventoryLayout FishBaitBoxLayout;
        [NMS(Index = 152)]
        /* 0x79328 */ public GcInventoryLayout FishPlatformLayout;
        [NMS(Index = 156)]
        /* 0x79340 */ public GcInventoryLayout FoodUnitLayout;
        [NMS(Index = 106)]
        /* 0x79358 */ public GcInventoryLayout FreighterCargoLayout;
        [NMS(Index = 105)]
        /* 0x79370 */ public GcInventoryLayout FreighterLayout;
        [NMS(Index = 150)]
        /* 0x79388 */ public GcInventoryLayout RocketLockerLayout;
        [NMS(Index = 26)]
        /* 0x793A0 */ public GcInventoryLayout ShipLayout;
        [NMS(Index = 27)]
        /* 0x793B8 */ public GcInventoryLayout WeaponLayout;
        [NMS(Index = 212)]
        /* 0x793D0 */ public NMSString0x10 BannerTitleId;
        [NMS(Index = 119)]
        /* 0x793E0 */ public List<GcPersistentBBObjectData> BaseBuildingObjects;
        [NMS(Index = 103)]
        /* 0x793F0 */ public GcSeed CurrentFreighterHomeSystemSeed;
        [NMS(Index = 38)]
        /* 0x79400 */ public NMSString0x10 CurrentMissionID;
        [NMS(Index = 189)]
        /* 0x79410 */ public List<ulong> ExpeditionSeedsSelectedToday;
        [NMS(Index = 188)]
        /* 0x79420 */ public List<GcFleetExpeditionSaveData> FleetExpeditions;
        [NMS(Index = 187)]
        /* 0x79430 */ public List<GcFleetFrigateSaveData> FleetFrigates;
        [NMS(Index = 186)]
        /* 0x79440 */ public GcSeed FleetSeed;
        [NMS(Index = 193)]
        /* 0x79450 */ public NMSString0x10 FoodUnitItem;
        [NMS(Index = 185)]
        /* 0x79460 */ public NMSString0x10 FreighterEngineEffect;
        [NMS(Index = 237)]
        /* 0x79470 */ public List<GcGalaxyWaypoint> GalaxyWaypoints;
        [NMS(Index = 75)]
        /* 0x79480 */ public List<NMSString0x20A> InteractionProgressTable;
        [NMS(Index = 184)]
        /* 0x79490 */ public NMSString0x10 JetpackEffect;
        [NMS(Index = 31)]
        /* 0x794A0 */ public List<NMSString0x10> KnownProducts;
        [NMS(Index = 33)]
        /* 0x794B0 */ public List<NMSString0x20A> KnownRefinerRecipes;
        [NMS(Index = 32)]
        /* 0x794C0 */ public List<NMSString0x10> KnownSpecials;
        [NMS(Index = 30)]
        /* 0x794D0 */ public List<NMSString0x10> KnownTech;
        [NMS(Index = 35)]
        /* 0x794E0 */ public List<GcWordGroupKnowledge> KnownWordGroups;
        [NMS(Index = 34)]
        /* 0x794F0 */ public List<GcWordKnowledge> KnownWords;
        [NMS(Index = 172)]
        /* 0x79500 */ public List<GcPortalSaveData> LastPortal;
        [NMS(Index = 64)]
        /* 0x79510 */ public List<GcMaintenanceContainer> MaintenanceInteractions;
        [NMS(Index = 56)]
        /* 0x79520 */ public List<GcScanEventSave> MarkerStack;
        [NMS(Index = 36)]
        /* 0x79530 */ public List<GcPlayerMissionProgress> MissionProgress;
        [NMS(Index = 43)]
        /* 0x79540 */ public List<GcMissionIDEpochPair> MissionRecurrences;
        [NMS(Index = 57)]
        /* 0x79550 */ public List<GcScanEventSave> NewMPMarkerStack;
        [NMS(Index = 122)]
        /* 0x79560 */ public List<GcPersistentBase> PersistentPlayerBases;
        [NMS(Index = 65)]
        /* 0x79570 */ public List<GcMaintenanceContainer> PersonalMaintenanceInteractions;
        [NMS(Index = 40)]
        /* 0x79580 */ public NMSString0x10 PreviousMissionID;
        [NMS(Index = 218)]
        /* 0x79590 */ public List<NMSString0x10> RedeemedPlatformRewards;
        [NMS(Index = 216)]
        /* 0x795A0 */ public List<NMSString0x10> RedeemedSeasonRewards;
        [NMS(Index = 217)]
        /* 0x795B0 */ public List<NMSString0x10> RedeemedTwitchRewards;
        [NMS(Index = 236)]
        /* 0x795C0 */ public List<GcMaintenanceContainer> RefinerBufferData;
        [NMS(Index = 235)]
        /* 0x795D0 */ public List<GcMaintenanceSaveKey> RefinerBufferKeys;
        [NMS(Index = 197)]
        /* 0x795E0 */ public List<GcRepairTechData> RepairTechBuffer;
        [NMS(Index = 74)]
        /* 0x795F0 */ public List<GcSavedInteractionDialogData> SavedInteractionDialogTable;
        [NMS(Index = 118)]
        /* 0x79600 */ public List<NMSString0x10> SeenBaseBuildingObjects;
        [NMS(Index = 244)]
        /* 0x79610 */ public List<GcSettlementLocalSaveData> SettlementLocalSaveData;
        [NMS(Index = 61)]
        /* 0x79620 */ public List<GcPlayerStatsGroup> Stats;
        [NMS(Index = 58)]
        /* 0x79630 */ public List<Vector3f> SurveyedEventPositions;
        [NMS(Index = 62)]
        /* 0x79640 */ public List<GcTelemetryStat> TelemetryStats;
        [NMS(Index = 123)]
        /* 0x79650 */ public List<GcTeleportEndpoint> TeleportEndpoints;
        [NMS(Index = 171)]
        /* 0x79660 */ public List<GcTradingSupplyData> TradingSupplyData;
        [NMS(Index = 85)]
        /* 0x79670 */ public List<GcSavedEntitlement> UsedEntitlements;
        [NMS(Index = 78)]
        /* 0x79680 */ public List<GcUniverseAddressData> VisitedAtlasStationsData;
        [NMS(Index = 66)]
        /* 0x79690 */ public List<ulong> VisitedSystems;
        [NMS(Index = 11)]
        /* 0x796A0 */ public List<GcInWorldUIScreenData> WristScreenData;
        [NMS(Index = 91)]
        /* 0x796B0 */ public ulong ActiveSpaceBattleUA;
        [NMS(Index = 39)]
        /* 0x796B8 */ public ulong CurrentMissionSeed;
        [NMS(Index = 240)]
        /* 0x796C0 */ public ulong FirstPurpleSystemUA;
        [NMS(Index = 110)]
        /* 0x796C8 */ public ulong FreighterLastSpawnTime;
        [NMS(Index = 101)]
        /* 0x796D0 */ public ulong HazardTimeAlive;
        [NMS(Index = 60)]
        /* 0x796D8 */ public ulong LastCheckedForStatResetsTime;
        [NMS(Index = 190)]
        /* 0x796E0 */ public ulong LastKnownDay;
        [NMS(Index = 200)]
        /* 0x796E8 */ public ulong LastUABeforePortalWarp;
        [NMS(Index = 95)]
        /* 0x796F0 */ public ulong MiniStationUA;
        [NMS(Index = 194)]
        /* 0x796F8 */ public ulong MultiplayerLobbyID;
        [NMS(Index = 198)]
        /* 0x79700 */ public ulong MultiplayerPrivileges;
        [NMS(Index = 41)]
        /* 0x79708 */ public ulong PreviousMissionSeed;
        [NMS(Index = 201)]
        /* 0x79710 */ public ulong StoryPortalSeed;
        [NMS(Index = 191)]
        /* 0x79718 */ public ulong SunTimer;
        [NMS(Index = 243)]
        /* 0x79720 */ public ulong TaggedPlanetUA;
        [NMS(Index = 55)]
        /* 0x79728 */ public ulong TimeAlive;
        [NMS(Index = 93)]
        /* 0x79730 */ public ulong TimeLastMiniStation;
        [NMS(Index = 89)]
        /* 0x79738 */ public ulong TimeLastSpaceBattle;
        [NMS(Index = 5)]
        /* 0x79740 */ public ulong TimeStamp;
        [NMS(Index = 73, Size = 0x95, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x79748 */ public GcSavedInteractionRaceData[] SavedInteractionIndicies;
        [NMS(Index = 233, Size = 0xC, EnumType = typeof(GcWonderCustomCategory.WonderCustomCategoryEnum))]
        /* 0x7B338 */ public GcWonderRecordCustomData[] WonderCustomRecordsExtraData;
        [NMS(Index = 80, Size = 0xB)]
        /* 0x7B668 */ public GcUniverseAddressData[] CompletedAtlasAddresses;
        [NMS(Index = 77, Size = 0xB)]
        /* 0x7B770 */ public GcUniverseAddressData[] NewAtlasStationAdressData;
        [NMS(Index = 76, Size = 0xA)]
        /* 0x7B878 */ public GcUniverseAddressData[] AtlasStationAdressData;
        [NMS(Index = 4)]
        /* 0x7B968 */ public GcDifficultyStateData DifficultyState;
        [NMS(Index = 67, Size = 0x7, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x7B9D4 */ public float[] Hazard;
        [NMS(Index = 111)]
        /* 0x7B9F0 */ public GcUniverseAddressData FreighterUniverseAddress;
        [NMS(Index = 97)]
        /* 0x7BA08 */ public GcUniverseAddressData GameStartAddress1;
        [NMS(Index = 98)]
        /* 0x7BA20 */ public GcUniverseAddressData GameStartAddress2;
        [NMS(Index = 22)]
        /* 0x7BA38 */ public GcUniverseAddressData GraveUniverseAddress;
        [NMS(Index = 195)]
        /* 0x7BA50 */ public GcUniverseAddressData MultiplayerUA;
        [NMS(Index = 205)]
        /* 0x7BA68 */ public GcUniverseAddressData NexusUniverseAddress;
        [NMS(Index = 1)]
        /* 0x7BA80 */ public GcUniverseAddressData PreviousUniverseAddress;
        [NMS(Index = 0)]
        /* 0x7BA98 */ public GcUniverseAddressData UniverseAddress;
        [NMS(Index = 13)]
        /* 0x7BAB0 */ public int ActiveMultioolIndex;
        [NMS(Index = 92)]
        /* 0x7BAB4 */ public int ActiveSpaceBattleLevel;
        [NMS(Index = 211)]
        /* 0x7BAB8 */ public int BannerBackgroundColour;
        [NMS(Index = 209)]
        /* 0x7BABC */ public int BannerIcon;
        [NMS(Index = 210)]
        /* 0x7BAC0 */ public int BannerMainColour;
        [NMS(Index = 68)]
        /* 0x7BAC4 */ public int BoltAmmo;
        [NMS(Index = 51)]
        /* 0x7BAC8 */ public int Energy;
        [NMS(Index = 192)]
        /* 0x7BACC */ public float FoodUnitAccumulator;
        [NMS(Index = 47)]
        /* 0x7BAD0 */ public int Health;
        [NMS(Index = 2)]
        /* 0x7BAD4 */ public int HomeRealityIteration;
        [NMS(Index = 174)]
        /* 0x7BAD8 */ public int KnownPortalRunes;
        [NMS(Index = 71)]
        /* 0x7BADC */ public int LaserAmmo;
        [NMS(Index = 42)]
        /* 0x7BAE0 */ public int MissionVersion;
        [NMS(Index = 53)]
        /* 0x7BAE4 */ public int Nanites;
        [NMS(Index = 59)]
        /* 0x7BAE8 */ public int NextSurveyedEventPositionIndex;
        [NMS(Index = 37)]
        /* 0x7BAEC */ public int PostMissionIndex;
        [NMS(Index = 88)]
        /* 0x7BAF0 */ public int PrimaryPlanet;
        [NMS(Index = 164)]
        /* 0x7BAF4 */ public int PrimaryShip;
        [NMS(Index = 160)]
        /* 0x7BAF8 */ public int PrimaryVehicle;
        [NMS(Index = 82)]
        /* 0x7BAFC */ public int ProcTechIndex;
        [NMS(Index = 81)]
        /* 0x7BB00 */ public int ProgressionLevel;
        [NMS(Index = 70)]
        /* 0x7BB04 */ public int PulseAmmo;
        [NMS(Index = 69)]
        /* 0x7BB08 */ public int ScatterAmmo;
        [NMS(Index = 220)]
        /* 0x7BB0C */ public int SettlementStateRingBufferIndexV2;
        [NMS(Index = 49)]
        /* 0x7BB10 */ public int Shield;
        [NMS(Index = 48)]
        /* 0x7BB14 */ public int ShipHealth;
        [NMS(Index = 50)]
        /* 0x7BB18 */ public int ShipShield;
        [NMS(Index = 54)]
        /* 0x7BB1C */ public int Specials;
        [NMS(Index = 179)]
        /* 0x7BB20 */ public GcPlayerWeapons StartingPrimaryWeapon;
        [NMS(Index = 225)]
        /* 0x7BB24 */ public int StartingSeasonNumber;
        [NMS(Index = 180)]
        /* 0x7BB28 */ public GcPlayerWeapons StartingSecondaryWeapon;
        [NMS(Index = 213)]
        /* 0x7BB2C */ public int TelemetryUploadVersion;
        [NMS(Index = 170)]
        /* 0x7BB30 */ public int TradingSupplyDataIndex;
        [NMS(Index = 52)]
        /* 0x7BB34 */ public int Units;
        [NMS(Index = 214)]
        /* 0x7BB38 */ public float VRCameraOffset;
        [NMS(Index = 94)]
        /* 0x7BB3C */ public int WarpsLastMiniStation;
        [NMS(Index = 90)]
        /* 0x7BB40 */ public int WarpsLastSpaceBattle;
        [NMS(Index = 202)]
        /* 0x7BB44 */ public ushort ShopNumber;
        [NMS(Index = 203)]
        /* 0x7BB46 */ public ushort ShopTier;
        [NMS(Index = 3)]
        /* 0x7BB48 */ public NMSString0x80 SaveSummary;
        [NMS(Index = 167)]
        /* 0x7BBC8 */ public NMSString0x20 PlayerFreighterName;
        [NMS(Index = 18, Size = 0x12)]
        /* 0x7BBE8 */ public bool[] UnlockedPetSlots;
        [NMS(Index = 99, Size = 0x10)]
        /* 0x7BBFA */ public bool[] GalacticMapRequests;
        [NMS(Index = 182, Size = 0xC)]
        /* 0x7BC0A */ public bool[] ShipUsesLegacyColours;
        [NMS(Index = 116, Size = 0x4)]
        /* 0x7BC16 */ public bool[] SquadronUnlockedPilotSlots;
        [NMS(Index = 224)]
        /* 0x7BC1A */ public bool BuildersKnown;
        [NMS(Index = 79)]
        /* 0x7BC1B */ public bool FirstAtlasStationDiscovered;
        [NMS(Index = 112)]
        /* 0x7BC1C */ public bool FreighterDismissed;
        [NMS(Index = 204)]
        /* 0x7BC1D */ public bool HasAccessToNexus;
        [NMS(Index = 239)]
        /* 0x7BC1E */ public bool HasDiscoveredPurpleSystems;
        [NMS(Index = 241)]
        /* 0x7BC1F */ public bool HasGalacticMapRequestAllPurples;
        [NMS(Index = 242)]
        /* 0x7BC20 */ public bool HasGalacticMapRequestFirstPurple;
        [NMS(Index = 83)]
        /* 0x7BC21 */ public bool IsNew;
        [NMS(Index = 165)]
        /* 0x7BC22 */ public bool MultiShipEnabled;
        [NMS(Index = 222)]
        /* 0x7BC23 */ public bool NextLoadSpawnsWithFreshStart;
        [NMS(Index = 175)]
        /* 0x7BC24 */ public bool OnOtherSideOfPortal;
        [NMS(Index = 215)]
        /* 0x7BC25 */ public bool RestartAllInactiveSeasonalMissions;
        [NMS(Index = 102)]
        /* 0x7BC26 */ public bool RevealBlackHoles;
        [NMS(Index = 169)]
        /* 0x7BC27 */ public bool ShipNeedsTerrainPositioning;
        [NMS(Index = 21)]
        /* 0x7BC28 */ public bool SpaceGrave;
        [NMS(Index = 20)]
        /* 0x7BC29 */ public bool SpawnGrave;
        [NMS(Index = 84)]
        /* 0x7BC2A */ public bool UseSmallerBlackholeJumps;
        [NMS(Index = 166)]
        /* 0x7BC2B */ public bool VehicleAIControlEnabled;
    }
}
