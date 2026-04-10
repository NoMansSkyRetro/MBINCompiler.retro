using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA0F92B2D2652C0B3, NameHash = 0x5E49C3E9)]
    public class GcPlayerStateData : NMSTemplate
    {
        [NMS(Index = 122)]
        /* 0x00000 */ public GcTerrainEditsBuffer TerrainEditData;
        [NMS(Index = 226, Size = 0x64)]
        /* 0x3C780 */ public GcSettlementState[] SettlementStatesV2;
        [NMS(Index = 167, Size = 0x12)]
        /* 0x5DAC0 */ public GcArchivedShipData[] ArchivedShipOwnership;
        [NMS(Index = 166, Size = 0xC)]
        /* 0x64480 */ public GcPlayerOwnershipData[] ShipOwnership;
        [NMS(Index = 14, Size = 0x12)]
        /* 0x67F00 */ public GcArchivedMultitoolData[] ArchivedMultitools;
        [NMS(Index = 117, Size = 0x8)]
        /* 0x6B080 */ public GcFreighterSaveData[] FreighterFleet;
        [NMS(Index = 163, Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x6D880 */ public GcPlayerOwnershipData[] VehicleOwnership;
        [NMS(Index = 12, Size = 0x6)]
        /* 0x6FAA0 */ public GcMultitoolData[] Multitools;
        [NMS(Index = 123, Size = 0x5, EnumType = typeof(GcNPCHabitationType.NPCHabitationTypeEnum))]
        /* 0x70A00 */ public GcNPCWorkerData[] NPCWorkers;
        [NMS(Index = 87, Size = 0x10)]
        /* 0x70C80 */ public Vector3f[] PlanetPositions;
        [NMS(Index = 203)]
        /* 0x70D80 */ public GcPlayerSpawnStateData MultiplayerSpawn;
        [NMS(Index = 180)]
        /* 0x70E60 */ public GcTeleportEndpoint OtherSideOfPortalReturnBase;
        [NMS(Index = 165)]
        /* 0x70EE0 */ public GcSkiffSaveData SkiffData;
        [NMS(Index = 45)]
        /* 0x70F10 */ public GcInteractionData HoloExplorerInteraction;
        [NMS(Index = 47)]
        /* 0x70F30 */ public GcInteractionData HoloNooneInteraction;
        [NMS(Index = 46)]
        /* 0x70F50 */ public GcInteractionData HoloScepticInteraction;
        [NMS(Index = 97)]
        /* 0x70F70 */ public Vector4f AnomalyPositionOverride;
        [NMS(Index = 101)]
        /* 0x70F80 */ public Vector4f FirstShipPosition;
        [NMS(Index = 73)]
        /* 0x70F90 */ public Vector4f FirstSpawnPosition;
        [NMS(Index = 114)]
        /* 0x70FA0 */ public Vector3f FreighterMatrixAt;
        [NMS(Index = 116)]
        /* 0x70FB0 */ public Vector3f FreighterMatrixPos;
        [NMS(Index = 115)]
        /* 0x70FC0 */ public Vector3f FreighterMatrixUp;
        [NMS(Index = 25)]
        /* 0x70FD0 */ public Vector4f GraveMatrixLookAt;
        [NMS(Index = 26)]
        /* 0x70FE0 */ public Vector4f GraveMatrixUp;
        [NMS(Index = 24)]
        /* 0x70FF0 */ public Vector4f GravePosition;
        [NMS(Index = 213)]
        /* 0x71000 */ public Vector3f NexusMatrixAt;
        [NMS(Index = 215)]
        /* 0x71010 */ public Vector3f NexusMatrixPos;
        [NMS(Index = 214)]
        /* 0x71020 */ public Vector3f NexusMatrixUp;
        [NMS(Index = 181)]
        /* 0x71030 */ public Vector4f PortalMarkerPosition_Local;
        [NMS(Index = 182)]
        /* 0x71040 */ public Vector4f PortalMarkerPosition_Offset;
        [NMS(Index = 172)]
        /* 0x71050 */ public Vector4f StartGameShipPosition;
        [NMS(Index = 15, Size = 0x1E)]
        /* 0x71060 */ public GcPetData[] Pets;
        [NMS(Index = 16, Size = 0x12)]
        /* 0x76970 */ public GcPetData[] Eggs;
        [NMS(Index = 17, Size = 0x1E)]
        /* 0x79EE0 */ public GcPetCustomisationData[] PetAccessoryCustomisation;
        [NMS(Index = 245)]
        /* 0x7C370 */ public GcFishingRecord FishingRecord;
        [NMS(Index = 185, Size = 0x1A, EnumType = typeof(GcCustomisationComponentData.CustomisationDataTypeEnum))]
        /* 0x7DB70 */ public GcCharacterCustomisationSaveData[] CharacterCustomisationData;
        [NMS(Index = 206, Size = 0x3, EnumType = typeof(GcHotActionMenuTypes.HotActionMenuTypesEnum))]
        /* 0x7E600 */ public GcHotActionsSaveData[] HotActions;
        [NMS(Index = 119, Size = 0x4)]
        /* 0x7E9C0 */ public GcSquadronPilotData[] SquadronPilots;
        [NMS(Index = 189, Size = 0x6)]
        /* 0x7EC40 */ public GcCharacterCustomisationData[] CustomTruckPresets;
        [NMS(Index = 187, Size = 0x6)]
        /* 0x7EE50 */ public GcCharacterCustomisationData[] Outfits;
        [NMS(Index = 234, Size = 0xF, EnumType = typeof(GcWonderCreatureCategory.WonderCreatureCategoryEnum))]
        /* 0x7F060 */ public GcWonderRecord[] WonderCreatureRecords;
        [NMS(Index = 145)]
        /* 0x7F1C8 */ public GcInventoryContainer Chest10Inventory;
        [NMS(Index = 127)]
        /* 0x7F328 */ public GcInventoryContainer Chest1Inventory;
        [NMS(Index = 129)]
        /* 0x7F488 */ public GcInventoryContainer Chest2Inventory;
        [NMS(Index = 131)]
        /* 0x7F5E8 */ public GcInventoryContainer Chest3Inventory;
        [NMS(Index = 133)]
        /* 0x7F748 */ public GcInventoryContainer Chest4Inventory;
        [NMS(Index = 135)]
        /* 0x7F8A8 */ public GcInventoryContainer Chest5Inventory;
        [NMS(Index = 137)]
        /* 0x7FA08 */ public GcInventoryContainer Chest6Inventory;
        [NMS(Index = 139)]
        /* 0x7FB68 */ public GcInventoryContainer Chest7Inventory;
        [NMS(Index = 141)]
        /* 0x7FCC8 */ public GcInventoryContainer Chest8Inventory;
        [NMS(Index = 143)]
        /* 0x7FE28 */ public GcInventoryContainer Chest9Inventory;
        [NMS(Index = 149)]
        /* 0x7FF88 */ public GcInventoryContainer ChestMagic2Inventory;
        [NMS(Index = 147)]
        /* 0x800E8 */ public GcInventoryContainer ChestMagicInventory;
        [NMS(Index = 151)]
        /* 0x80248 */ public GcInventoryContainer CookingIngredientsInventory;
        [NMS(Index = 161)]
        /* 0x803A8 */ public GcInventoryContainer CorvetteStorageInventory;
        [NMS(Index = 157)]
        /* 0x80508 */ public GcInventoryContainer FishBaitBoxInventory;
        [NMS(Index = 155)]
        /* 0x80668 */ public GcInventoryContainer FishPlatformInventory;
        [NMS(Index = 159)]
        /* 0x807C8 */ public GcInventoryContainer FoodUnitInventory;
        [NMS(Index = 108)]
        /* 0x80928 */ public GcInventoryContainer FreighterInventory;
        [NMS(Index = 110)]
        /* 0x80A88 */ public GcInventoryContainer FreighterInventory_Cargo;
        [NMS(Index = 109)]
        /* 0x80BE8 */ public GcInventoryContainer FreighterInventory_TechOnly;
        [NMS(Index = 20)]
        /* 0x80D48 */ public GcInventoryContainer GraveInventory;
        [NMS(Index = 6)]
        /* 0x80EA8 */ public GcInventoryContainer Inventory;
        [NMS(Index = 8)]
        /* 0x81008 */ public GcInventoryContainer Inventory_Cargo;
        [NMS(Index = 7)]
        /* 0x81168 */ public GcInventoryContainer Inventory_TechOnly;
        [NMS(Index = 153)]
        /* 0x812C8 */ public GcInventoryContainer RocketLockerInventory;
        [NMS(Index = 9)]
        /* 0x81428 */ public GcInventoryContainer ShipInventory;
        [NMS(Index = 10)]
        /* 0x81588 */ public GcInventoryContainer WeaponInventory;
        [NMS(Index = 237, Size = 0xD, EnumType = typeof(GcWonderTreasureCategory.WonderTreasureCategoryEnum))]
        /* 0x816E8 */ public GcWonderRecord[] WonderTreasureRecords;
        [NMS(Index = 228, Size = 0x4)]
        /* 0x81820 */ public GcSettlementHistory[] SettlementHistory;
        [NMS(Index = 239, Size = 0xC, EnumType = typeof(GcWonderCustomCategory.WonderCustomCategoryEnum))]
        /* 0x81940 */ public GcWonderRecord[] WonderCustomRecords;
        [NMS(Index = 64, Size = 0xB, EnumType = typeof(GcInteractionBufferType.InteractionBufferTypeEnum))]
        /* 0x81A60 */ public GcInteractionBuffer[] StoredInteractions;
        [NMS(Index = 233, Size = 0xB, EnumType = typeof(GcWonderPlanetCategory.WonderPlanetCategoryEnum))]
        /* 0x81B68 */ public GcWonderRecord[] WonderPlanetRecords;
        [NMS(Index = 238, Size = 0xB, EnumType = typeof(GcWonderWeirdBasePartCategory.WonderWeirdBasePartCategoryEnum))]
        /* 0x81C70 */ public GcWonderRecord[] WonderWeirdBasePartRecords;
        [NMS(Index = 88, Size = 0x10)]
        /* 0x81D78 */ public GcSeed[] PlanetSeeds;
        [NMS(Index = 235, Size = 0x8, EnumType = typeof(GcWonderFloraCategory.WonderFloraCategoryEnum))]
        /* 0x81E78 */ public GcWonderRecord[] WonderFloraRecords;
        [NMS(Index = 236, Size = 0x8, EnumType = typeof(GcWonderMineralCategory.WonderMineralCategoryEnum))]
        /* 0x81F38 */ public GcWonderRecord[] WonderMineralRecords;
        [NMS(Index = 230, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x81FF8 */ public GcStoryPageSeenDataArray[] SeenStories;
        [NMS(Index = 105)]
        /* 0x82088 */ public GcResourceElement CurrentFreighter;
        [NMS(Index = 162)]
        /* 0x820D0 */ public GcResourceElement CurrentFreighterNPC;
        [NMS(Index = 29)]
        /* 0x82118 */ public GcResourceElement CurrentShip;
        [NMS(Index = 241, Size = 0x4, EnumType = typeof(GcSynchronisedBufferType.SyncBufferTypeEnum))]
        /* 0x82160 */ public GcSyncBufferSaveDataArray[] SyncBuffersData;
        [NMS(Index = 30)]
        /* 0x821A0 */ public GcExactResource CurrentWeapon;
        [NMS(Index = 177)]
        /* 0x821C0 */ public GcPortalSaveData VisitedPortal;
        [NMS(Index = 144)]
        /* 0x821E0 */ public GcInventoryLayout Chest10Layout;
        [NMS(Index = 126)]
        /* 0x821F8 */ public GcInventoryLayout Chest1Layout;
        [NMS(Index = 128)]
        /* 0x82210 */ public GcInventoryLayout Chest2Layout;
        [NMS(Index = 130)]
        /* 0x82228 */ public GcInventoryLayout Chest3Layout;
        [NMS(Index = 132)]
        /* 0x82240 */ public GcInventoryLayout Chest4Layout;
        [NMS(Index = 134)]
        /* 0x82258 */ public GcInventoryLayout Chest5Layout;
        [NMS(Index = 136)]
        /* 0x82270 */ public GcInventoryLayout Chest6Layout;
        [NMS(Index = 138)]
        /* 0x82288 */ public GcInventoryLayout Chest7Layout;
        [NMS(Index = 140)]
        /* 0x822A0 */ public GcInventoryLayout Chest8Layout;
        [NMS(Index = 142)]
        /* 0x822B8 */ public GcInventoryLayout Chest9Layout;
        [NMS(Index = 148)]
        /* 0x822D0 */ public GcInventoryLayout ChestMagic2Layout;
        [NMS(Index = 146)]
        /* 0x822E8 */ public GcInventoryLayout ChestMagicLayout;
        [NMS(Index = 150)]
        /* 0x82300 */ public GcInventoryLayout CookingIngredientsLayout;
        [NMS(Index = 160)]
        /* 0x82318 */ public GcInventoryLayout CorvetteStorageLayout;
        [NMS(Index = 156)]
        /* 0x82330 */ public GcInventoryLayout FishBaitBoxLayout;
        [NMS(Index = 154)]
        /* 0x82348 */ public GcInventoryLayout FishPlatformLayout;
        [NMS(Index = 158)]
        /* 0x82360 */ public GcInventoryLayout FoodUnitLayout;
        [NMS(Index = 107)]
        /* 0x82378 */ public GcInventoryLayout FreighterCargoLayout;
        [NMS(Index = 106)]
        /* 0x82390 */ public GcInventoryLayout FreighterLayout;
        [NMS(Index = 152)]
        /* 0x823A8 */ public GcInventoryLayout RocketLockerLayout;
        [NMS(Index = 27)]
        /* 0x823C0 */ public GcInventoryLayout ShipLayout;
        [NMS(Index = 28)]
        /* 0x823D8 */ public GcInventoryLayout WeaponLayout;
        [NMS(Index = 219)]
        /* 0x823F0 */ public NMSString0x10 BannerTitleId;
        [NMS(Index = 121)]
        /* 0x82400 */ public List<GcPersistentBBObjectData> BaseBuildingObjects;
        [NMS(Index = 104)]
        /* 0x82410 */ public GcSeed CurrentFreighterHomeSystemSeed;
        [NMS(Index = 39)]
        /* 0x82420 */ public NMSString0x10 CurrentMissionID;
        [NMS(Index = 196)]
        /* 0x82430 */ public List<ulong> ExpeditionSeedsSelectedToday;
        [NMS(Index = 195)]
        /* 0x82440 */ public List<GcFleetExpeditionSaveData> FleetExpeditions;
        [NMS(Index = 194)]
        /* 0x82450 */ public List<GcFleetFrigateSaveData> FleetFrigates;
        [NMS(Index = 193)]
        /* 0x82460 */ public GcSeed FleetSeed;
        [NMS(Index = 200)]
        /* 0x82470 */ public NMSString0x10 FoodUnitItem;
        [NMS(Index = 192)]
        /* 0x82480 */ public NMSString0x10 FreighterEngineEffect;
        [NMS(Index = 244)]
        /* 0x82490 */ public List<GcGalaxyWaypoint> GalaxyWaypoints;
        [NMS(Index = 76)]
        /* 0x824A0 */ public List<NMSString0x20A> InteractionProgressTable;
        [NMS(Index = 191)]
        /* 0x824B0 */ public NMSString0x10 JetpackEffect;
        [NMS(Index = 32)]
        /* 0x824C0 */ public List<NMSString0x10> KnownProducts;
        [NMS(Index = 34)]
        /* 0x824D0 */ public List<NMSString0x20A> KnownRefinerRecipes;
        [NMS(Index = 33)]
        /* 0x824E0 */ public List<NMSString0x10> KnownSpecials;
        [NMS(Index = 31)]
        /* 0x824F0 */ public List<NMSString0x10> KnownTech;
        [NMS(Index = 36)]
        /* 0x82500 */ public List<GcWordGroupKnowledge> KnownWordGroups;
        [NMS(Index = 35)]
        /* 0x82510 */ public List<GcWordKnowledge> KnownWords;
        [NMS(Index = 176)]
        /* 0x82520 */ public List<GcPortalSaveData> LastPortal;
        [NMS(Index = 65)]
        /* 0x82530 */ public List<GcMaintenanceContainer> MaintenanceInteractions;
        [NMS(Index = 57)]
        /* 0x82540 */ public List<GcScanEventSave> MarkerStack;
        [NMS(Index = 37)]
        /* 0x82550 */ public List<GcPlayerMissionProgress> MissionProgress;
        [NMS(Index = 44)]
        /* 0x82560 */ public List<GcMissionIDEpochPair> MissionRecurrences;
        [NMS(Index = 58)]
        /* 0x82570 */ public List<GcScanEventSave> NewMPMarkerStack;
        [NMS(Index = 124)]
        /* 0x82580 */ public List<GcPersistentBase> PersistentPlayerBases;
        [NMS(Index = 66)]
        /* 0x82590 */ public List<GcMaintenanceContainer> PersonalMaintenanceInteractions;
        [NMS(Index = 41)]
        /* 0x825A0 */ public NMSString0x10 PreviousMissionID;
        [NMS(Index = 225)]
        /* 0x825B0 */ public List<NMSString0x10> RedeemedPlatformRewards;
        [NMS(Index = 223)]
        /* 0x825C0 */ public List<NMSString0x10> RedeemedSeasonRewards;
        [NMS(Index = 224)]
        /* 0x825D0 */ public List<NMSString0x10> RedeemedTwitchRewards;
        [NMS(Index = 243)]
        /* 0x825E0 */ public List<GcMaintenanceContainer> RefinerBufferData;
        [NMS(Index = 242)]
        /* 0x825F0 */ public List<GcMaintenanceSaveKey> RefinerBufferKeys;
        [NMS(Index = 204)]
        /* 0x82600 */ public List<GcRepairTechData> RepairTechBuffer;
        [NMS(Index = 75)]
        /* 0x82610 */ public List<GcSavedInteractionDialogData> SavedInteractionDialogTable;
        [NMS(Index = 120)]
        /* 0x82620 */ public List<NMSString0x10> SeenBaseBuildingObjects;
        [NMS(Index = 251)]
        /* 0x82630 */ public List<GcSettlementLocalSaveData> SettlementLocalSaveData;
        [NMS(Index = 62)]
        /* 0x82640 */ public List<GcPlayerStatsGroup> Stats;
        [NMS(Index = 59)]
        /* 0x82650 */ public List<Vector3f> SurveyedEventPositions;
        [NMS(Index = 63)]
        /* 0x82660 */ public List<GcTelemetryStat> TelemetryStats;
        [NMS(Index = 125)]
        /* 0x82670 */ public List<GcTeleportEndpoint> TeleportEndpoints;
        [NMS(Index = 175)]
        /* 0x82680 */ public List<GcTradingSupplyData> TradingSupplyData;
        [NMS(Index = 86)]
        /* 0x82690 */ public List<GcSavedEntitlement> UsedEntitlements;
        [NMS(Index = 79)]
        /* 0x826A0 */ public List<GcUniverseAddressData> VisitedAtlasStationsData;
        [NMS(Index = 67)]
        /* 0x826B0 */ public List<ulong> VisitedSystems;
        [NMS(Index = 11)]
        /* 0x826C0 */ public List<GcInWorldUIScreenData> WristScreenData;
        [NMS(Index = 92)]
        /* 0x826D0 */ public ulong ActiveSpaceBattleUA;
        [NMS(Index = 254)]
        /* 0x826D8 */ public ulong CorvetteDraftShipSeed;
        [NMS(Index = 40)]
        /* 0x826E0 */ public ulong CurrentMissionSeed;
        [NMS(Index = 247)]
        /* 0x826E8 */ public ulong FirstPurpleSystemUA;
        [NMS(Index = 111)]
        /* 0x826F0 */ public ulong FreighterLastSpawnTime;
        [NMS(Index = 102)]
        /* 0x826F8 */ public ulong HazardTimeAlive;
        [NMS(Index = 61)]
        /* 0x82700 */ public ulong LastCheckedForStatResetsTime;
        [NMS(Index = 197)]
        /* 0x82708 */ public ulong LastKnownDay;
        [NMS(Index = 207)]
        /* 0x82710 */ public ulong LastUABeforePortalWarp;
        [NMS(Index = 96)]
        /* 0x82718 */ public ulong MiniStationUA;
        [NMS(Index = 201)]
        /* 0x82720 */ public ulong MultiplayerLobbyID;
        [NMS(Index = 205)]
        /* 0x82728 */ public ulong MultiplayerPrivileges;
        [NMS(Index = 42)]
        /* 0x82730 */ public ulong PreviousMissionSeed;
        [NMS(Index = 208)]
        /* 0x82738 */ public ulong StoryPortalSeed;
        [NMS(Index = 198)]
        /* 0x82740 */ public ulong SunTimer;
        [NMS(Index = 250)]
        /* 0x82748 */ public ulong TaggedPlanetUA;
        [NMS(Index = 56)]
        /* 0x82750 */ public ulong TimeAlive;
        [NMS(Index = 94)]
        /* 0x82758 */ public ulong TimeLastMiniStation;
        [NMS(Index = 90)]
        /* 0x82760 */ public ulong TimeLastSpaceBattle;
        [NMS(Index = 5)]
        /* 0x82768 */ public ulong TimeStamp;
        [NMS(Index = 74, Size = 0x9C, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x82770 */ public GcSavedInteractionRaceData[] SavedInteractionIndicies;
        [NMS(Index = 240, Size = 0xC, EnumType = typeof(GcWonderCustomCategory.WonderCustomCategoryEnum))]
        /* 0x844B0 */ public GcWonderRecordCustomData[] WonderCustomRecordsExtraData;
        [NMS(Index = 81, Size = 0xB)]
        /* 0x847E0 */ public GcUniverseAddressData[] CompletedAtlasAddresses;
        [NMS(Index = 78, Size = 0xB)]
        /* 0x848E8 */ public GcUniverseAddressData[] NewAtlasStationAdressData;
        [NMS(Index = 77, Size = 0xA)]
        /* 0x849F0 */ public GcUniverseAddressData[] AtlasStationAdressData;
        [NMS(Index = 4)]
        /* 0x84AE0 */ public GcDifficultyStateData DifficultyState;
        [NMS(Index = 68, Size = 0x7, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x84B4C */ public float[] Hazard;
        [NMS(Index = 112)]
        /* 0x84B68 */ public GcUniverseAddressData FreighterUniverseAddress;
        [NMS(Index = 98)]
        /* 0x84B80 */ public GcUniverseAddressData GameStartAddress1;
        [NMS(Index = 99)]
        /* 0x84B98 */ public GcUniverseAddressData GameStartAddress2;
        [NMS(Index = 23)]
        /* 0x84BB0 */ public GcUniverseAddressData GraveUniverseAddress;
        [NMS(Index = 202)]
        /* 0x84BC8 */ public GcUniverseAddressData MultiplayerUA;
        [NMS(Index = 212)]
        /* 0x84BE0 */ public GcUniverseAddressData NexusUniverseAddress;
        [NMS(Index = 1)]
        /* 0x84BF8 */ public GcUniverseAddressData PreviousUniverseAddress;
        [NMS(Index = 0)]
        /* 0x84C10 */ public GcUniverseAddressData UniverseAddress;
        [NMS(Index = 19)]
        /* 0x84C28 */ public GcPetBattleTeamData PetBattleTeam;
        [NMS(Index = 13)]
        /* 0x84C34 */ public int ActiveMultioolIndex;
        [NMS(Index = 93)]
        /* 0x84C38 */ public int ActiveSpaceBattleLevel;
        [NMS(Index = 218)]
        /* 0x84C3C */ public int BannerBackgroundColour;
        [NMS(Index = 216)]
        /* 0x84C40 */ public int BannerIcon;
        [NMS(Index = 217)]
        /* 0x84C44 */ public int BannerMainColour;
        [NMS(Index = 69)]
        /* 0x84C48 */ public int BoltAmmo;
        [NMS(Index = 252)]
        /* 0x84C4C */ public int CorvetteEditAssociatedShipIndex;
        [NMS(Index = 52)]
        /* 0x84C50 */ public int Energy;
        [NMS(Index = 199)]
        /* 0x84C54 */ public float FoodUnitAccumulator;
        [NMS(Index = 48)]
        /* 0x84C58 */ public int Health;
        [NMS(Index = 2)]
        /* 0x84C5C */ public int HomeRealityIteration;
        [NMS(Index = 178)]
        /* 0x84C60 */ public int KnownPortalRunes;
        [NMS(Index = 72)]
        /* 0x84C64 */ public int LaserAmmo;
        [NMS(Index = 43)]
        /* 0x84C68 */ public int MissionVersion;
        [NMS(Index = 54)]
        /* 0x84C6C */ public int Nanites;
        [NMS(Index = 60)]
        /* 0x84C70 */ public int NextSurveyedEventPositionIndex;
        [NMS(Index = 38)]
        /* 0x84C74 */ public int PostMissionIndex;
        [NMS(Index = 89)]
        /* 0x84C78 */ public int PrimaryPlanet;
        [NMS(Index = 168)]
        /* 0x84C7C */ public int PrimaryShip;
        [NMS(Index = 164)]
        /* 0x84C80 */ public int PrimaryVehicle;
        [NMS(Index = 83)]
        /* 0x84C84 */ public int ProcTechIndex;
        [NMS(Index = 82)]
        /* 0x84C88 */ public int ProgressionLevel;
        [NMS(Index = 71)]
        /* 0x84C8C */ public int PulseAmmo;
        [NMS(Index = 70)]
        /* 0x84C90 */ public int ScatterAmmo;
        [NMS(Index = 227)]
        /* 0x84C94 */ public int SettlementStateRingBufferIndexV2;
        [NMS(Index = 50)]
        /* 0x84C98 */ public int Shield;
        [NMS(Index = 49)]
        /* 0x84C9C */ public int ShipHealth;
        [NMS(Index = 51)]
        /* 0x84CA0 */ public int ShipShield;
        [NMS(Index = 55)]
        /* 0x84CA4 */ public int Specials;
        [NMS(Index = 183)]
        /* 0x84CA8 */ public GcPlayerWeapons StartingPrimaryWeapon;
        [NMS(Index = 232)]
        /* 0x84CAC */ public int StartingSeasonNumber;
        [NMS(Index = 184)]
        /* 0x84CB0 */ public GcPlayerWeapons StartingSecondaryWeapon;
        [NMS(Index = 220)]
        /* 0x84CB4 */ public int TelemetryUploadVersion;
        [NMS(Index = 174)]
        /* 0x84CB8 */ public int TradingSupplyDataIndex;
        [NMS(Index = 53)]
        /* 0x84CBC */ public int Units;
        [NMS(Index = 221)]
        /* 0x84CC0 */ public float VRCameraOffset;
        [NMS(Index = 95)]
        /* 0x84CC4 */ public int WarpsLastMiniStation;
        [NMS(Index = 91)]
        /* 0x84CC8 */ public int WarpsLastSpaceBattle;
        [NMS(Index = 209)]
        /* 0x84CCC */ public ushort ShopNumber;
        [NMS(Index = 210)]
        /* 0x84CCE */ public ushort ShopTier;
        [NMS(Index = 190, Size = 0x6)]
        /* 0x84CD0 */ public NMSString0x20[] CustomTruckPresetNames;
        [NMS(Index = 188, Size = 0x6)]
        /* 0x84D90 */ public NMSString0x20[] OutfitNames;
        [NMS(Index = 253)]
        /* 0x84E50 */ public NMSString0x80 CorvetteEditShipName;
        [NMS(Index = 3)]
        /* 0x84ED0 */ public NMSString0x80 SaveSummary;
        [NMS(Index = 171)]
        /* 0x84F50 */ public NMSString0x20 PlayerFreighterName;
        [NMS(Index = 18, Size = 0x1E)]
        /* 0x84F70 */ public bool[] UnlockedPetSlots;
        [NMS(Index = 100, Size = 0x10)]
        /* 0x84F8E */ public bool[] GalacticMapRequests;
        [NMS(Index = 186, Size = 0xC)]
        /* 0x84F9E */ public bool[] ShipUsesLegacyColours;
        [NMS(Index = 118, Size = 0x4)]
        /* 0x84FAA */ public bool[] SquadronUnlockedPilotSlots;
        [NMS(Index = 231)]
        /* 0x84FAE */ public bool BuildersKnown;
        [NMS(Index = 80)]
        /* 0x84FAF */ public bool FirstAtlasStationDiscovered;
        [NMS(Index = 113)]
        /* 0x84FB0 */ public bool FreighterDismissed;
        [NMS(Index = 211)]
        /* 0x84FB1 */ public bool HasAccessToNexus;
        [NMS(Index = 246)]
        /* 0x84FB2 */ public bool HasDiscoveredPurpleSystems;
        [NMS(Index = 248)]
        /* 0x84FB3 */ public bool HasGalacticMapRequestAllPurples;
        [NMS(Index = 249)]
        /* 0x84FB4 */ public bool HasGalacticMapRequestFirstPurple;
        [NMS(Index = 84)]
        /* 0x84FB5 */ public bool IsNew;
        [NMS(Index = 169)]
        /* 0x84FB6 */ public bool MultiShipEnabled;
        [NMS(Index = 229)]
        /* 0x84FB7 */ public bool NextLoadSpawnsWithFreshStart;
        [NMS(Index = 179)]
        /* 0x84FB8 */ public bool OnOtherSideOfPortal;
        [NMS(Index = 222)]
        /* 0x84FB9 */ public bool RestartAllInactiveSeasonalMissions;
        [NMS(Index = 103)]
        /* 0x84FBA */ public bool RevealBlackHoles;
        [NMS(Index = 173)]
        /* 0x84FBB */ public bool ShipNeedsTerrainPositioning;
        [NMS(Index = 22)]
        /* 0x84FBC */ public bool SpaceGrave;
        [NMS(Index = 21)]
        /* 0x84FBD */ public bool SpawnGrave;
        [NMS(Index = 85)]
        /* 0x84FBE */ public bool UseSmallerBlackholeJumps;
        [NMS(Index = 170)]
        /* 0x84FBF */ public bool VehicleAIControlEnabled;
    }
}
