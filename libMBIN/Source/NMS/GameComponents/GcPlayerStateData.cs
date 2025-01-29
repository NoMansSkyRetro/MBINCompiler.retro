using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x91CE237B7B18FFCB, NameHash = 0x5E49C3E9)]
    public class GcPlayerStateData : NMSTemplate
    {
        [NMS(Index = 120)]
        /* 0x00000 */ public GcTerrainEditsBuffer TerrainEditData;
        [NMS(Index = 219, Size = 0x64)]
        /* 0x3C780 */ public GcSettlementState[] SettlementStatesV2;
        [NMS(Index = 163, Size = 0x12)]
        /* 0x5B540 */ public GcArchivedShipData[] ArchivedShipOwnership;
        [NMS(Index = 162, Size = 0xC)]
        /* 0x61BA0 */ public GcPlayerOwnershipData[] ShipOwnership;
        [NMS(Index = 14, Size = 0x12)]
        /* 0x653E0 */ public GcArchivedMultitoolData[] ArchivedMultitools;
        [NMS(Index = 159, Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x68440 */ public GcPlayerOwnershipData[] VehicleOwnership;
        [NMS(Index = 12, Size = 0x6)]
        /* 0x6A510 */ public GcMultitoolData[] Multitools;
        [NMS(Index = 121, Size = 0x5, EnumType = typeof(GcNPCHabitationType.NPCHabitationTypeEnum))]
        /* 0x6B410 */ public GcNPCWorkerData[] NPCWorkers;
        [NMS(Index = 86, Size = 0x10)]
        /* 0x6B690 */ public Vector3f[] PlanetPositions;
        [NMS(Index = 196)]
        /* 0x6B790 */ public GcPlayerSpawnStateData MultiplayerSpawn;
        [NMS(Index = 176)]
        /* 0x6B860 */ public GcTeleportEndpoint OtherSideOfPortalReturnBase;
        [NMS(Index = 161)]
        /* 0x6B8E0 */ public GcSkiffSaveData SkiffData;
        [NMS(Index = 44)]
        /* 0x6B910 */ public GcInteractionData HoloExplorerInteraction;
        [NMS(Index = 46)]
        /* 0x6B930 */ public GcInteractionData HoloNooneInteraction;
        [NMS(Index = 45)]
        /* 0x6B950 */ public GcInteractionData HoloScepticInteraction;
        [NMS(Index = 96)]
        /* 0x6B970 */ public Vector4f AnomalyPositionOverride;
        [NMS(Index = 100)]
        /* 0x6B980 */ public Vector4f FirstShipPosition;
        [NMS(Index = 72)]
        /* 0x6B990 */ public Vector4f FirstSpawnPosition;
        [NMS(Index = 113)]
        /* 0x6B9A0 */ public Vector3f FreighterMatrixAt;
        [NMS(Index = 115)]
        /* 0x6B9B0 */ public Vector3f FreighterMatrixPos;
        [NMS(Index = 114)]
        /* 0x6B9C0 */ public Vector3f FreighterMatrixUp;
        [NMS(Index = 24)]
        /* 0x6B9D0 */ public Vector4f GraveMatrixLookAt;
        [NMS(Index = 25)]
        /* 0x6B9E0 */ public Vector4f GraveMatrixUp;
        [NMS(Index = 23)]
        /* 0x6B9F0 */ public Vector4f GravePosition;
        [NMS(Index = 206)]
        /* 0x6BA00 */ public Vector3f NexusMatrixAt;
        [NMS(Index = 208)]
        /* 0x6BA10 */ public Vector3f NexusMatrixPos;
        [NMS(Index = 207)]
        /* 0x6BA20 */ public Vector3f NexusMatrixUp;
        [NMS(Index = 177)]
        /* 0x6BA30 */ public Vector4f PortalMarkerPosition_Local;
        [NMS(Index = 178)]
        /* 0x6BA40 */ public Vector4f PortalMarkerPosition_Offset;
        [NMS(Index = 168)]
        /* 0x6BA50 */ public Vector4f StartGameShipPosition;
        [NMS(Index = 16, Size = 0x12)]
        /* 0x6BA60 */ public GcPetData[] Eggs;
        [NMS(Index = 15, Size = 0x12)]
        /* 0x6DEF0 */ public GcPetData[] Pets;
        [NMS(Index = 237)]
        /* 0x70380 */ public GcFishingRecord FishingRecord;
        [NMS(Index = 17, Size = 0x12)]
        /* 0x71B80 */ public GcPetCustomisationData[] PetAccessoryCustomisation;
        [NMS(Index = 181, Size = 0x1A, EnumType = typeof(GcCustomisationComponentData.CustomisationDataTypeEnum))]
        /* 0x73170 */ public GcCharacterCustomisationSaveData[] CharacterCustomisationData;
        [NMS(Index = 199, Size = 0x3, EnumType = typeof(GcHotActionMenuTypes.HotActionMenuTypesEnum))]
        /* 0x73C00 */ public GcHotActionsSaveData[] HotActions;
        [NMS(Index = 117, Size = 0x4)]
        /* 0x73FC0 */ public GcSquadronPilotData[] SquadronPilots;
        [NMS(Index = 226, Size = 0xF, EnumType = typeof(GcWonderCreatureCategory.WonderCreatureCategoryEnum))]
        /* 0x74240 */ public GcWonderRecord[] WonderCreatureRecords;
        [NMS(Index = 143)]
        /* 0x743A8 */ public GcInventoryContainer Chest10Inventory;
        [NMS(Index = 125)]
        /* 0x74500 */ public GcInventoryContainer Chest1Inventory;
        [NMS(Index = 127)]
        /* 0x74658 */ public GcInventoryContainer Chest2Inventory;
        [NMS(Index = 129)]
        /* 0x747B0 */ public GcInventoryContainer Chest3Inventory;
        [NMS(Index = 131)]
        /* 0x74908 */ public GcInventoryContainer Chest4Inventory;
        [NMS(Index = 133)]
        /* 0x74A60 */ public GcInventoryContainer Chest5Inventory;
        [NMS(Index = 135)]
        /* 0x74BB8 */ public GcInventoryContainer Chest6Inventory;
        [NMS(Index = 137)]
        /* 0x74D10 */ public GcInventoryContainer Chest7Inventory;
        [NMS(Index = 139)]
        /* 0x74E68 */ public GcInventoryContainer Chest8Inventory;
        [NMS(Index = 141)]
        /* 0x74FC0 */ public GcInventoryContainer Chest9Inventory;
        [NMS(Index = 147)]
        /* 0x75118 */ public GcInventoryContainer ChestMagic2Inventory;
        [NMS(Index = 145)]
        /* 0x75270 */ public GcInventoryContainer ChestMagicInventory;
        [NMS(Index = 149)]
        /* 0x753C8 */ public GcInventoryContainer CookingIngredientsInventory;
        [NMS(Index = 155)]
        /* 0x75520 */ public GcInventoryContainer FishBaitBoxInventory;
        [NMS(Index = 153)]
        /* 0x75678 */ public GcInventoryContainer FishPlatformInventory;
        [NMS(Index = 157)]
        /* 0x757D0 */ public GcInventoryContainer FoodUnitInventory;
        [NMS(Index = 107)]
        /* 0x75928 */ public GcInventoryContainer FreighterInventory;
        [NMS(Index = 109)]
        /* 0x75A80 */ public GcInventoryContainer FreighterInventory_Cargo;
        [NMS(Index = 108)]
        /* 0x75BD8 */ public GcInventoryContainer FreighterInventory_TechOnly;
        [NMS(Index = 19)]
        /* 0x75D30 */ public GcInventoryContainer GraveInventory;
        [NMS(Index = 6)]
        /* 0x75E88 */ public GcInventoryContainer Inventory;
        [NMS(Index = 8)]
        /* 0x75FE0 */ public GcInventoryContainer Inventory_Cargo;
        [NMS(Index = 7)]
        /* 0x76138 */ public GcInventoryContainer Inventory_TechOnly;
        [NMS(Index = 151)]
        /* 0x76290 */ public GcInventoryContainer RocketLockerInventory;
        [NMS(Index = 9)]
        /* 0x763E8 */ public GcInventoryContainer ShipInventory;
        [NMS(Index = 10)]
        /* 0x76540 */ public GcInventoryContainer WeaponInventory;
        [NMS(Index = 229, Size = 0xD, EnumType = typeof(GcWonderTreasureCategory.WonderTreasureCategoryEnum))]
        /* 0x76698 */ public GcWonderRecord[] WonderTreasureRecords;
        [NMS(Index = 231, Size = 0xC, EnumType = typeof(GcWonderCustomCategory.WonderCustomCategoryEnum))]
        /* 0x767D0 */ public GcWonderRecord[] WonderCustomRecords;
        [NMS(Index = 183, Size = 0x3)]
        /* 0x768F0 */ public GcCharacterCustomisationData[] Outfits;
        [NMS(Index = 63, Size = 0xB, EnumType = typeof(GcInteractionBufferType.InteractionBufferTypeEnum))]
        /* 0x769F8 */ public GcInteractionBuffer[] StoredInteractions;
        [NMS(Index = 225, Size = 0xB, EnumType = typeof(GcWonderPlanetCategory.WonderPlanetCategoryEnum))]
        /* 0x76B00 */ public GcWonderRecord[] WonderPlanetRecords;
        [NMS(Index = 230, Size = 0xB, EnumType = typeof(GcWonderWeirdBasePartCategory.WonderWeirdBasePartCategoryEnum))]
        /* 0x76C08 */ public GcWonderRecord[] WonderWeirdBasePartRecords;
        [NMS(Index = 87, Size = 0x10)]
        /* 0x76D10 */ public GcSeed[] PlanetSeeds;
        [NMS(Index = 227, Size = 0x8, EnumType = typeof(GcWonderFloraCategory.WonderFloraCategoryEnum))]
        /* 0x76E10 */ public GcWonderRecord[] WonderFloraRecords;
        [NMS(Index = 228, Size = 0x8, EnumType = typeof(GcWonderMineralCategory.WonderMineralCategoryEnum))]
        /* 0x76ED0 */ public GcWonderRecord[] WonderMineralRecords;
        [NMS(Index = 222, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x76F90 */ public GcStoryPageSeenDataArray[] SeenStories;
        [NMS(Index = 104)]
        /* 0x77020 */ public GcResourceElement CurrentFreighter;
        [NMS(Index = 158)]
        /* 0x77068 */ public GcResourceElement CurrentFreighterNPC;
        [NMS(Index = 28)]
        /* 0x770B0 */ public GcResourceElement CurrentShip;
        [NMS(Index = 233, Size = 0x4, EnumType = typeof(GcSynchronisedBufferType.SyncBufferTypeEnum))]
        /* 0x770F8 */ public GcSyncBufferSaveDataArray[] SyncBuffersData;
        [NMS(Index = 29)]
        /* 0x77138 */ public GcExactResource CurrentWeapon;
        [NMS(Index = 173)]
        /* 0x77158 */ public GcPortalSaveData VisitedPortal;
        [NMS(Index = 142)]
        /* 0x77178 */ public GcInventoryLayout Chest10Layout;
        [NMS(Index = 124)]
        /* 0x77190 */ public GcInventoryLayout Chest1Layout;
        [NMS(Index = 126)]
        /* 0x771A8 */ public GcInventoryLayout Chest2Layout;
        [NMS(Index = 128)]
        /* 0x771C0 */ public GcInventoryLayout Chest3Layout;
        [NMS(Index = 130)]
        /* 0x771D8 */ public GcInventoryLayout Chest4Layout;
        [NMS(Index = 132)]
        /* 0x771F0 */ public GcInventoryLayout Chest5Layout;
        [NMS(Index = 134)]
        /* 0x77208 */ public GcInventoryLayout Chest6Layout;
        [NMS(Index = 136)]
        /* 0x77220 */ public GcInventoryLayout Chest7Layout;
        [NMS(Index = 138)]
        /* 0x77238 */ public GcInventoryLayout Chest8Layout;
        [NMS(Index = 140)]
        /* 0x77250 */ public GcInventoryLayout Chest9Layout;
        [NMS(Index = 146)]
        /* 0x77268 */ public GcInventoryLayout ChestMagic2Layout;
        [NMS(Index = 144)]
        /* 0x77280 */ public GcInventoryLayout ChestMagicLayout;
        [NMS(Index = 148)]
        /* 0x77298 */ public GcInventoryLayout CookingIngredientsLayout;
        [NMS(Index = 154)]
        /* 0x772B0 */ public GcInventoryLayout FishBaitBoxLayout;
        [NMS(Index = 152)]
        /* 0x772C8 */ public GcInventoryLayout FishPlatformLayout;
        [NMS(Index = 156)]
        /* 0x772E0 */ public GcInventoryLayout FoodUnitLayout;
        [NMS(Index = 106)]
        /* 0x772F8 */ public GcInventoryLayout FreighterCargoLayout;
        [NMS(Index = 105)]
        /* 0x77310 */ public GcInventoryLayout FreighterLayout;
        [NMS(Index = 150)]
        /* 0x77328 */ public GcInventoryLayout RocketLockerLayout;
        [NMS(Index = 26)]
        /* 0x77340 */ public GcInventoryLayout ShipLayout;
        [NMS(Index = 27)]
        /* 0x77358 */ public GcInventoryLayout WeaponLayout;
        [NMS(Index = 212)]
        /* 0x77370 */ public NMSString0x10 BannerTitleId;
        [NMS(Index = 119)]
        /* 0x77380 */ public List<GcPersistentBBObjectData> BaseBuildingObjects;
        [NMS(Index = 103)]
        /* 0x77390 */ public GcSeed CurrentFreighterHomeSystemSeed;
        [NMS(Index = 38)]
        /* 0x773A0 */ public NMSString0x10 CurrentMissionID;
        [NMS(Index = 189)]
        /* 0x773B0 */ public List<ulong> ExpeditionSeedsSelectedToday;
        [NMS(Index = 188)]
        /* 0x773C0 */ public List<GcFleetExpeditionSaveData> FleetExpeditions;
        [NMS(Index = 187)]
        /* 0x773D0 */ public List<GcFleetFrigateSaveData> FleetFrigates;
        [NMS(Index = 186)]
        /* 0x773E0 */ public GcSeed FleetSeed;
        [NMS(Index = 193)]
        /* 0x773F0 */ public NMSString0x10 FoodUnitItem;
        [NMS(Index = 185)]
        /* 0x77400 */ public NMSString0x10 FreighterEngineEffect;
        [NMS(Index = 236)]
        /* 0x77410 */ public List<GcGalaxyWaypoint> GalaxyWaypoints;
        [NMS(Index = 75)]
        /* 0x77420 */ public List<NMSString0x20A> InteractionProgressTable;
        [NMS(Index = 184)]
        /* 0x77430 */ public NMSString0x10 JetpackEffect;
        [NMS(Index = 31)]
        /* 0x77440 */ public List<NMSString0x10> KnownProducts;
        [NMS(Index = 33)]
        /* 0x77450 */ public List<NMSString0x20A> KnownRefinerRecipes;
        [NMS(Index = 32)]
        /* 0x77460 */ public List<NMSString0x10> KnownSpecials;
        [NMS(Index = 30)]
        /* 0x77470 */ public List<NMSString0x10> KnownTech;
        [NMS(Index = 35)]
        /* 0x77480 */ public List<GcWordGroupKnowledge> KnownWordGroups;
        [NMS(Index = 34)]
        /* 0x77490 */ public List<GcWordKnowledge> KnownWords;
        [NMS(Index = 172)]
        /* 0x774A0 */ public List<GcPortalSaveData> LastPortal;
        [NMS(Index = 64)]
        /* 0x774B0 */ public List<GcMaintenanceContainer> MaintenanceInteractions;
        [NMS(Index = 56)]
        /* 0x774C0 */ public List<GcScanEventSave> MarkerStack;
        [NMS(Index = 36)]
        /* 0x774D0 */ public List<GcPlayerMissionProgress> MissionProgress;
        [NMS(Index = 43)]
        /* 0x774E0 */ public List<GcMissionIDEpochPair> MissionRecurrences;
        [NMS(Index = 57)]
        /* 0x774F0 */ public List<GcScanEventSave> NewMPMarkerStack;
        [NMS(Index = 122)]
        /* 0x77500 */ public List<GcPersistentBase> PersistentPlayerBases;
        [NMS(Index = 65)]
        /* 0x77510 */ public List<GcMaintenanceContainer> PersonalMaintenanceInteractions;
        [NMS(Index = 40)]
        /* 0x77520 */ public NMSString0x10 PreviousMissionID;
        [NMS(Index = 218)]
        /* 0x77530 */ public List<NMSString0x10> RedeemedPlatformRewards;
        [NMS(Index = 216)]
        /* 0x77540 */ public List<NMSString0x10> RedeemedSeasonRewards;
        [NMS(Index = 217)]
        /* 0x77550 */ public List<NMSString0x10> RedeemedTwitchRewards;
        [NMS(Index = 235)]
        /* 0x77560 */ public List<GcMaintenanceContainer> RefinerBufferData;
        [NMS(Index = 234)]
        /* 0x77570 */ public List<GcMaintenanceSaveKey> RefinerBufferKeys;
        [NMS(Index = 197)]
        /* 0x77580 */ public List<GcRepairTechData> RepairTechBuffer;
        [NMS(Index = 74)]
        /* 0x77590 */ public List<GcSavedInteractionDialogData> SavedInteractionDialogTable;
        [NMS(Index = 118)]
        /* 0x775A0 */ public List<NMSString0x10> SeenBaseBuildingObjects;
        [NMS(Index = 61)]
        /* 0x775B0 */ public List<GcPlayerStatsGroup> Stats;
        [NMS(Index = 58)]
        /* 0x775C0 */ public List<Vector3f> SurveyedEventPositions;
        [NMS(Index = 62)]
        /* 0x775D0 */ public List<GcTelemetryStat> TelemetryStats;
        [NMS(Index = 123)]
        /* 0x775E0 */ public List<GcTeleportEndpoint> TeleportEndpoints;
        [NMS(Index = 171)]
        /* 0x775F0 */ public List<GcTradingSupplyData> TradingSupplyData;
        [NMS(Index = 85)]
        /* 0x77600 */ public List<GcSavedEntitlement> UsedEntitlements;
        [NMS(Index = 78)]
        /* 0x77610 */ public List<GcUniverseAddressData> VisitedAtlasStationsData;
        [NMS(Index = 66)]
        /* 0x77620 */ public List<ulong> VisitedSystems;
        [NMS(Index = 11)]
        /* 0x77630 */ public List<GcInWorldUIScreenData> WristScreenData;
        [NMS(Index = 91)]
        /* 0x77640 */ public ulong ActiveSpaceBattleUA;
        [NMS(Index = 39)]
        /* 0x77648 */ public ulong CurrentMissionSeed;
        [NMS(Index = 239)]
        /* 0x77650 */ public ulong FirstPurpleSystemUA;
        [NMS(Index = 110)]
        /* 0x77658 */ public ulong FreighterLastSpawnTime;
        [NMS(Index = 101)]
        /* 0x77660 */ public ulong HazardTimeAlive;
        [NMS(Index = 60)]
        /* 0x77668 */ public ulong LastCheckedForStatResetsTime;
        [NMS(Index = 190)]
        /* 0x77670 */ public ulong LastKnownDay;
        [NMS(Index = 200)]
        /* 0x77678 */ public ulong LastUABeforePortalWarp;
        [NMS(Index = 95)]
        /* 0x77680 */ public ulong MiniStationUA;
        [NMS(Index = 194)]
        /* 0x77688 */ public ulong MultiplayerLobbyID;
        [NMS(Index = 198)]
        /* 0x77690 */ public ulong MultiplayerPrivileges;
        [NMS(Index = 41)]
        /* 0x77698 */ public ulong PreviousMissionSeed;
        [NMS(Index = 201)]
        /* 0x776A0 */ public ulong StoryPortalSeed;
        [NMS(Index = 191)]
        /* 0x776A8 */ public ulong SunTimer;
        [NMS(Index = 55)]
        /* 0x776B0 */ public ulong TimeAlive;
        [NMS(Index = 93)]
        /* 0x776B8 */ public ulong TimeLastMiniStation;
        [NMS(Index = 89)]
        /* 0x776C0 */ public ulong TimeLastSpaceBattle;
        [NMS(Index = 5)]
        /* 0x776C8 */ public ulong TimeStamp;
        [NMS(Index = 73, Size = 0x90, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x776D0 */ public GcSavedInteractionRaceData[] SavedInteractionIndicies;
        [NMS(Index = 232, Size = 0xC, EnumType = typeof(GcWonderCustomCategory.WonderCustomCategoryEnum))]
        /* 0x791D0 */ public GcWonderRecordCustomData[] WonderCustomRecordsExtraData;
        [NMS(Index = 80, Size = 0xB)]
        /* 0x79500 */ public GcUniverseAddressData[] CompletedAtlasAddresses;
        [NMS(Index = 77, Size = 0xB)]
        /* 0x79608 */ public GcUniverseAddressData[] NewAtlasStationAdressData;
        [NMS(Index = 76, Size = 0xA)]
        /* 0x79710 */ public GcUniverseAddressData[] AtlasStationAdressData;
        [NMS(Index = 4)]
        /* 0x79800 */ public GcDifficultyStateData DifficultyState;
        [NMS(Index = 67, Size = 0x7, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x7986C */ public float[] Hazard;
        [NMS(Index = 111)]
        /* 0x79888 */ public GcUniverseAddressData FreighterUniverseAddress;
        [NMS(Index = 97)]
        /* 0x798A0 */ public GcUniverseAddressData GameStartAddress1;
        [NMS(Index = 98)]
        /* 0x798B8 */ public GcUniverseAddressData GameStartAddress2;
        [NMS(Index = 22)]
        /* 0x798D0 */ public GcUniverseAddressData GraveUniverseAddress;
        [NMS(Index = 195)]
        /* 0x798E8 */ public GcUniverseAddressData MultiplayerUA;
        [NMS(Index = 205)]
        /* 0x79900 */ public GcUniverseAddressData NexusUniverseAddress;
        [NMS(Index = 1)]
        /* 0x79918 */ public GcUniverseAddressData PreviousUniverseAddress;
        [NMS(Index = 0)]
        /* 0x79930 */ public GcUniverseAddressData UniverseAddress;
        [NMS(Index = 13)]
        /* 0x79948 */ public int ActiveMultioolIndex;
        [NMS(Index = 92)]
        /* 0x7994C */ public int ActiveSpaceBattleLevel;
        [NMS(Index = 211)]
        /* 0x79950 */ public int BannerBackgroundColour;
        [NMS(Index = 209)]
        /* 0x79954 */ public int BannerIcon;
        [NMS(Index = 210)]
        /* 0x79958 */ public int BannerMainColour;
        [NMS(Index = 68)]
        /* 0x7995C */ public int BoltAmmo;
        [NMS(Index = 51)]
        /* 0x79960 */ public int Energy;
        [NMS(Index = 192)]
        /* 0x79964 */ public float FoodUnitAccumulator;
        [NMS(Index = 47)]
        /* 0x79968 */ public int Health;
        [NMS(Index = 2)]
        /* 0x7996C */ public int HomeRealityIteration;
        [NMS(Index = 174)]
        /* 0x79970 */ public int KnownPortalRunes;
        [NMS(Index = 71)]
        /* 0x79974 */ public int LaserAmmo;
        [NMS(Index = 42)]
        /* 0x79978 */ public int MissionVersion;
        [NMS(Index = 53)]
        /* 0x7997C */ public int Nanites;
        [NMS(Index = 59)]
        /* 0x79980 */ public int NextSurveyedEventPositionIndex;
        [NMS(Index = 37)]
        /* 0x79984 */ public int PostMissionIndex;
        [NMS(Index = 88)]
        /* 0x79988 */ public int PrimaryPlanet;
        [NMS(Index = 164)]
        /* 0x7998C */ public int PrimaryShip;
        [NMS(Index = 160)]
        /* 0x79990 */ public int PrimaryVehicle;
        [NMS(Index = 82)]
        /* 0x79994 */ public int ProcTechIndex;
        [NMS(Index = 81)]
        /* 0x79998 */ public int ProgressionLevel;
        [NMS(Index = 70)]
        /* 0x7999C */ public int PulseAmmo;
        [NMS(Index = 69)]
        /* 0x799A0 */ public int ScatterAmmo;
        [NMS(Index = 220)]
        /* 0x799A4 */ public int SettlementStateRingBufferIndexV2;
        [NMS(Index = 49)]
        /* 0x799A8 */ public int Shield;
        [NMS(Index = 48)]
        /* 0x799AC */ public int ShipHealth;
        [NMS(Index = 50)]
        /* 0x799B0 */ public int ShipShield;
        [NMS(Index = 54)]
        /* 0x799B4 */ public int Specials;
        [NMS(Index = 179)]
        /* 0x799B8 */ public GcPlayerWeapons StartingPrimaryWeapon;
        [NMS(Index = 224)]
        /* 0x799BC */ public int StartingSeasonNumber;
        [NMS(Index = 180)]
        /* 0x799C0 */ public GcPlayerWeapons StartingSecondaryWeapon;
        [NMS(Index = 213)]
        /* 0x799C4 */ public int TelemetryUploadVersion;
        [NMS(Index = 170)]
        /* 0x799C8 */ public int TradingSupplyDataIndex;
        [NMS(Index = 52)]
        /* 0x799CC */ public int Units;
        [NMS(Index = 214)]
        /* 0x799D0 */ public float VRCameraOffset;
        [NMS(Index = 94)]
        /* 0x799D4 */ public int WarpsLastMiniStation;
        [NMS(Index = 90)]
        /* 0x799D8 */ public int WarpsLastSpaceBattle;
        [NMS(Index = 202)]
        /* 0x799DC */ public ushort ShopNumber;
        [NMS(Index = 203)]
        /* 0x799DE */ public ushort ShopTier;
        [NMS(Index = 3)]
        /* 0x799E0 */ public NMSString0x80 SaveSummary;
        [NMS(Index = 167)]
        /* 0x79A60 */ public NMSString0x20 PlayerFreighterName;
        [NMS(Index = 18, Size = 0x12)]
        /* 0x79A80 */ public bool[] UnlockedPetSlots;
        [NMS(Index = 99, Size = 0x10)]
        /* 0x79A92 */ public bool[] GalacticMapRequests;
        [NMS(Index = 182, Size = 0xC)]
        /* 0x79AA2 */ public bool[] ShipUsesLegacyColours;
        [NMS(Index = 116, Size = 0x4)]
        /* 0x79AAE */ public bool[] SquadronUnlockedPilotSlots;
        [NMS(Index = 223)]
        /* 0x79AB2 */ public bool BuildersKnown;
        [NMS(Index = 79)]
        /* 0x79AB3 */ public bool FirstAtlasStationDiscovered;
        [NMS(Index = 112)]
        /* 0x79AB4 */ public bool FreighterDismissed;
        [NMS(Index = 204)]
        /* 0x79AB5 */ public bool HasAccessToNexus;
        [NMS(Index = 238)]
        /* 0x79AB6 */ public bool HasDiscoveredPurpleSystems;
        [NMS(Index = 240)]
        /* 0x79AB7 */ public bool HasGalacticMapRequestAllPurples;
        [NMS(Index = 241)]
        /* 0x79AB8 */ public bool HasGalacticMapRequestFirstPurple;
        [NMS(Index = 83)]
        /* 0x79AB9 */ public bool IsNew;
        [NMS(Index = 165)]
        /* 0x79ABA */ public bool MultiShipEnabled;
        [NMS(Index = 221)]
        /* 0x79ABB */ public bool NextLoadSpawnsWithFreshStart;
        [NMS(Index = 175)]
        /* 0x79ABC */ public bool OnOtherSideOfPortal;
        [NMS(Index = 215)]
        /* 0x79ABD */ public bool RestartAllInactiveSeasonalMissions;
        [NMS(Index = 102)]
        /* 0x79ABE */ public bool RevealBlackHoles;
        [NMS(Index = 169)]
        /* 0x79ABF */ public bool ShipNeedsTerrainPositioning;
        [NMS(Index = 21)]
        /* 0x79AC0 */ public bool SpaceGrave;
        [NMS(Index = 20)]
        /* 0x79AC1 */ public bool SpawnGrave;
        [NMS(Index = 84)]
        /* 0x79AC2 */ public bool UseSmallerBlackholeJumps;
        [NMS(Index = 166)]
        /* 0x79AC3 */ public bool VehicleAIControlEnabled;
    }
}
