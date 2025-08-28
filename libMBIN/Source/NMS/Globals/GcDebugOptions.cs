using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x6798F23D234503B1, NameHash = 0xAA861200)]
    public class GcDebugOptions : NMSTemplate
    {
        [NMS(Index = 446)]
        /* 0x0000 */ public GcSeasonTransferInventoryConfig SeasonTransferInventoryConfigOverride;
        [NMS(Index = 214)]
        /* 0x0030 */ public VariableSizeString CrashDumpPath;
        [NMS(Index = 443)]
        /* 0x0040 */ public NMSString0x10 CreateSeasonContextMaskIdOverride;
        [NMS(Index = 328)]
        /* 0x0050 */ public VariableSizeString CursorTexture;
        [NMS(Index = 326)]
        /* 0x0060 */ public VariableSizeString DebugFont;
        [NMS(Index = 327)]
        /* 0x0070 */ public VariableSizeString DebugFontTexture;
        [NMS(Index = 109)]
        /* 0x0080 */ public VariableSizeString DebugScene;
        [NMS(Index = 360)]
        /* 0x0090 */ public NMSString0x10 DefaultAirCreatureTable;
        [NMS(Index = 362)]
        /* 0x00A0 */ public NMSString0x10 DefaultCaveCreatureTable;
        [NMS(Index = 359)]
        /* 0x00B0 */ public NMSString0x10 DefaultGroundCreatureTable;
        [NMS(Index = 184)]
        /* 0x00C0 */ public VariableSizeString DefaultSaveData;
        [NMS(Index = 361)]
        /* 0x00D0 */ public NMSString0x10 DefaultWaterCreatureTable;
        [NMS(Index = 70)]
        /* 0x00E0 */ public NMSString0x10 ForceBuilderMissionBoardMission;
        [NMS(Index = 183)]
        /* 0x00F0 */ public List<NMSString0x20> LocTableList;
        [NMS(Index = 329)]
        /* 0x0100 */ public VariableSizeString PauseTexture;
        [NMS(Index = 271)]
        /* 0x0110 */ public VariableSizeString PipelineFile;
        [NMS(Index = 273)]
        /* 0x0120 */ public VariableSizeString PipelineFileEditor;
        [NMS(Index = 272)]
        /* 0x0130 */ public VariableSizeString PipelineFileFrontend;
        [NMS(Index = 330)]
        /* 0x0140 */ public VariableSizeString PlayTexture;
        [NMS(Index = 181)]
        /* 0x0150 */ public VariableSizeString RealityPresetFile;
        [NMS(Index = 332)]
        /* 0x0160 */ public VariableSizeString RenderToTexture;
        [NMS(Index = 107)]
        /* 0x0170 */ public VariableSizeString SceneSettings;
        [NMS(Index = 331)]
        /* 0x0180 */ public VariableSizeString StepTexture;
        [NMS(Index = 444)]
        /* 0x0190 */ public NMSString0x10 SwitchSeasonContextMaskIdOverride;
        [NMS(Index = 212)]
        /* 0x01A0 */ public ulong ForceTimeToEpoch;
        [NMS(Index = 4)]
        /* 0x01A8 */ public ulong OverrideAbandonedFreighterSeed;
        [NMS(Index = 427)]
        /* 0x01B0 */ public TkGlobals ToolkitGlobals;
        [NMS(Index = 195, MxmlName = "3dTextDistance")]
        /* 0x0698 */ public float _3dTextDistance;
        [NMS(Index = 196, MxmlName = "3dTextMinScale")]
        /* 0x069C */ public float _3dTextMinScale;
        [NMS(Index = 416)]
        /* 0x06A0 */ public GcBaseBuildingPartStyle AutomaticPartSpawnStyle;
        [NMS(Index = 411)]
        /* 0x06A4 */ public float BaseDownloadTimeout;
        [NMS(Index = 424)]
        /* 0x06A8 */ public uint BasePayloadMultiplier;
        [NMS(Index = 11)]
        /* 0x06AC */ public int BootDirectlyIntoSaveSlot;
        // size: 0x3
        public enum BootLoadDelayEnum : uint {
            LoadAll,
            WaitForPlanet,
            WaitForNothing,
        }
        [NMS(Index = 116)]
        /* 0x06B0 */ public BootLoadDelayEnum BootLoadDelay;
        [NMS(Index = 190)]
        /* 0x06B4 */ public float BootLogoFadeRate;
        // size: 0x7
        public enum BootModeEnum : uint {
            MinimalSolarSystem,
            SolarSystem,
            GalaxyMap,
            SmokeTest,
            SmokeTestGalaxyMap,
            Scratchpad,
            UnitTest,
        }
        [NMS(Index = 105)]
        /* 0x06B8 */ public BootModeEnum BootMode;
        [NMS(Index = 173)]
        /* 0x06BC */ public TkLanguages DebugLanguage;
        [NMS(Index = 222)]
        /* 0x06C0 */ public float DebugMenuAlpha;
        [NMS(Index = 224)]
        /* 0x06C4 */ public float DebugTextLineHeight;
        [NMS(Index = 223)]
        /* 0x06C8 */ public float DebugTextSize;
        [NMS(Index = 319)]
        /* 0x06CC */ public int DebugTextureSize;
        [NMS(Index = 292)]
        /* 0x06D0 */ public int DiscoveryAutoSyncIntervalSeconds;
        [NMS(Index = 373)]
        /* 0x06D4 */ public GcGalaxyStarAnomaly ForceAnomalyTo;
        [NMS(Index = 391)]
        /* 0x06D8 */ public int ForceAsteroidSystemIndex;
        [NMS(Index = 350)]
        /* 0x06DC */ public GcBiomeSubType ForceBiomeSubTypeTo;
        [NMS(Index = 349)]
        /* 0x06E0 */ public GcBiomeType ForceBiomeTo;
        [NMS(Index = 354)]
        /* 0x06E4 */ public GcAlienRace ForceBuildingRaceTo;
        [NMS(Index = 363)]
        /* 0x06E8 */ public GcPlanetLife ForceCreatureLifeLevelTo;
        [NMS(Index = 384)]
        /* 0x06EC */ public int ForceGrassColourIndex;
        [NMS(Index = 119)]
        /* 0x06F0 */ public float ForceInitialTimeOfDay;
        [NMS(Index = 168)]
        /* 0x06F4 */ public int ForceInteractionIndex;
        [NMS(Index = 176)]
        /* 0x06F8 */ public GcAlienRace ForceInteractionRaceTo;
        [NMS(Index = 356)]
        /* 0x06FC */ public GcPlanetLife ForceLifeLevelTo;
        [NMS(Index = 169)]
        /* 0x0700 */ public GcAlienPuzzleCategory ForceNPCPuzzleCategory;
        [NMS(Index = 352)]
        /* 0x0704 */ public GcScreenFilters ForceScreenFilterTo;
        [NMS(Index = 376)]
        /* 0x0708 */ public float ForceSeaLevel;
        [NMS(Index = 379)]
        /* 0x070C */ public int ForceSkyColourIndex;
        [NMS(Index = 382)]
        /* 0x0710 */ public uint ForceSkyColourSeed;
        [NMS(Index = 40)]
        /* 0x0714 */ public int ForceSpaceBattleLevel;
        [NMS(Index = 380)]
        /* 0x0718 */ public int ForceSpaceSkyColourIndex;
        [NMS(Index = 347)]
        /* 0x071C */ public GcGalaxyStarTypes ForceStarTypeTo;
        [NMS(Index = 121)]
        /* 0x0720 */ public float ForceSunAngle;
        [NMS(Index = 364)]
        /* 0x0724 */ public GcPlanetLife ForceTerrainSettings;
        [NMS(Index = 366)]
        /* 0x0728 */ public TkVoxelGeneratorSettingsTypes ForceTerrainTypeTo;
        [NMS(Index = 118)]
        /* 0x072C */ public float ForceTimeOfDay;
        [NMS(Index = 383)]
        /* 0x0730 */ public int ForceWaterColourIndex;
        [NMS(Index = 378)]
        /* 0x0734 */ public TkWaterCondition ForceWaterConditionTo;
        [NMS(Index = 375)]
        /* 0x0738 */ public int ForceWaterObjectFileIndex;
        // size: 0x3
        public enum GameStateModeEnum : uint {
            LoadPreset,
            UserStorage,
            FreshStart,
        }
        [NMS(Index = 104)]
        /* 0x073C */ public GameStateModeEnum GameStateMode;
        [NMS(Index = 400)]
        /* 0x0740 */ public float GenerateCostAngle;
        [NMS(Index = 399)]
        /* 0x0744 */ public float GenerateCostDistance;
        [NMS(Index = 401)]
        /* 0x0748 */ public float GenerateCostLOD;
        [NMS(Index = 402)]
        /* 0x074C */ public float GenerateCostWait;
        [NMS(Index = 397)]
        /* 0x0750 */ public int GenerateFarLodBuildingDist;
        [NMS(Index = 206)]
        /* 0x0754 */ public int HavokVDBClientIndex;
        [NMS(Index = 317)]
        /* 0x0758 */ public int MaxNumDebugMessages;
        [NMS(Index = 414)]
        /* 0x075C */ public int MoveBaseIndex;
        [NMS(Index = 439)]
        /* 0x0760 */ public int MultipleFingersSamePressFrameDelta;
        [NMS(Index = 13)]
        /* 0x0764 */ public GcGameMode NewSaveGameMode;
        [NMS(Index = 299)]
        /* 0x0768 */ public int OverrideMatchmakingVersion;
        [NMS(Index = 309)]
        /* 0x076C */ public int OverrideServerSeasonEndTime;
        [NMS(Index = 308)]
        /* 0x0770 */ public int OverrideServerSeasonNumber;
        [NMS(Index = 442)]
        /* 0x0774 */ public float PanDeadzone;
        // size: 0x7
        public enum PlayerSpawnLocationOverrideEnum : uint {
            None,
            FromSettings,
            Space,
            SpaceStation,
            RandomPlanet,
            GameStartPlanet,
            SpecificLocation,
        }
        [NMS(Index = 106)]
        /* 0x0778 */ public PlayerSpawnLocationOverrideEnum PlayerSpawnLocationOverride;
        [NMS(Index = 322)]
        /* 0x077C */ public int ProceduralModelBatchSize;
        [NMS(Index = 323)]
        /* 0x0780 */ public int ProceduralModelFilterMatchretryCount;
        [NMS(Index = 321)]
        /* 0x0784 */ public int ProceduralModelsShown;
        [NMS(Index = 325)]
        /* 0x0788 */ public int ProceduralModelsThumbnailSize;
        [NMS(Index = 418)]
        /* 0x078C */ public int ProfilerPartIndexPhase;
        [NMS(Index = 419)]
        /* 0x0790 */ public int ProfilerPartIndexStride;
        [NMS(Index = 420)]
        /* 0x0794 */ public int ProfilerPartIteration;
        // size: 0x3
        public enum ProxyTypeEnum : uint {
            None,
            ManualURI,
            InetProxy,
        }
        [NMS(Index = 286)]
        /* 0x0798 */ public ProxyTypeEnum ProxyType;
        // size: 0x2
        public enum RealityModeEnum : uint {
            LoadPreset,
            Generate,
        }
        [NMS(Index = 177)]
        /* 0x079C */ public RealityModeEnum RealityMode;
        // size: 0x3
        public enum RecordSettingEnum : uint {
            None,
            Record,
            Playback,
        }
        [NMS(Index = 197)]
        /* 0x07A0 */ public RecordSettingEnum RecordSetting;
        [NMS(Index = 211)]
        /* 0x07A4 */ public int RecurrenceTimeOffset;
        [NMS(Index = 438)]
        /* 0x07A8 */ public int ScreenshotForUploadHeight;
        [NMS(Index = 437)]
        /* 0x07AC */ public int ScreenshotForUploadWidth;
        // size: 0x9
        public enum ServerEnvEnum : uint {
            Default,
            dev,
            qa,
            prodqa,
            prod,
            custom,
            pentest,
            merged,
            local,
        }
        [NMS(Index = 288)]
        /* 0x07B0 */ public ServerEnvEnum ServerEnv;
        // size: 0x2
        public enum ShaderPreloadEnum : uint {
            Off,
            Full,
        }
        [NMS(Index = 112)]
        /* 0x07B4 */ public ShaderPreloadEnum ShaderPreload;
        [NMS(Index = 234)]
        /* 0x07B8 */ public int ShowSpecificGraph;
        [NMS(Index = 250)]
        /* 0x07BC */ public int SmokeTestConfigCaptureCycles;
        [NMS(Index = 251)]
        /* 0x07C0 */ public float SmokeTestConfigCaptureDurationInSeconds;
        [NMS(Index = 252)]
        /* 0x07C4 */ public int SmokeTestConfigCaptureFolderNameNumberOffset;
        [NMS(Index = 243)]
        /* 0x07C8 */ public int SmokeTestConfigPlanetPositionCount;
        [NMS(Index = 245)]
        /* 0x07CC */ public float SmokeTestConfigScenarioLength;
        [NMS(Index = 244)]
        /* 0x07D0 */ public float SmokeTestConfigScenarioPreambleLength;
        // size: 0x7
        public enum SmokeTestCycleModeEnum : uint {
            None,
            TourPlanet,
            TourSolarSystem,
            TourGalaxy,
            TourUDAs,
            TourShortUDAs,
            TourRandomWarps,
        }
        [NMS(Index = 240)]
        /* 0x07D4 */ public SmokeTestCycleModeEnum SmokeTestCycleMode;
        // size: 0xA
        public enum SmokeTestScenarioEnum : uint {
            None,
            TerrainSnapShotFromAltitude,
            BelowCloudLayerSnapShot,
            Flying,
            UltraBiomeSnapShot,
            Walking,
            LeakDetector,
            WalkingSnapshot,
            ModelLoading,
            SettlementSnapshot,
        }
        [NMS(Index = 241)]
        /* 0x07D8 */ public SmokeTestScenarioEnum SmokeTestScenario;
        [NMS(Index = 256)]
        /* 0x07DC */ public int SmokeTestSmokeBotTargetWarps;
        // size: 0x2
        public enum SolarSystemBootEnum : uint {
            FromSettings,
            Generate,
        }
        [NMS(Index = 111)]
        /* 0x07E0 */ public SolarSystemBootEnum SolarSystemBoot;
        [NMS(Index = 276)]
        /* 0x07E4 */ public float SunLightScaleGgx;
        [NMS(Index = 440)]
        /* 0x07E8 */ public int SwipeDetectionMaxFrames;
        [NMS(Index = 441)]
        /* 0x07EC */ public float SwipeDetectionNormalizedTravelThreshold;
        [NMS(Index = 315)]
        /* 0x07F0 */ public int SynergyPort;
        // size: 0x3
        public enum UseBanksEnum : uint {
            False,
            True,
            Default,
        }
        [NMS(Index = 204)]
        /* 0x07F4 */ public UseBanksEnum UseBanks;
        [NMS(Index = 192)]
        /* 0x07F8 */ public float WeaponScale3P;
        [NMS(Index = 182)]
        /* 0x07FC */ public ushort RealityGenerationIteration;
        [NMS(Index = 295)]
        /* 0x07FE */ public NMSString0x800 AutoJoinUserNames;
        [NMS(Index = 85)]
        /* 0x0FFE */ public NMSString0x400 DebugTwitchRewards;
        [NMS(Index = 300)]
        /* 0x13FE */ public NMSString0x200 LoadToBase;
        [NMS(Index = 81)]
        /* 0x15FE */ public NMSString0x200 SeasonalDataOverrideFile;
        [NMS(Index = 310)]
        /* 0x17FE */ public NMSString0x100 ForceHgAccount;
        [NMS(Index = 101)]
        /* 0x18FE */ public NMSString0x100 ForcePlayerPosition;
        [NMS(Index = 100)]
        /* 0x19FE */ public NMSString0x100 ForceUniverseAddress;
        [NMS(Index = 303)]
        /* 0x1AFE */ public NMSString0x100 GOGLogin;
        [NMS(Index = 230)]
        /* 0x1BFE */ public NMSString0x100 ShowUniverseAddressOnGalaxyMap;
        [NMS(Index = 108)]
        /* 0x1CFE */ public NMSString0x100 WorkingDirectory;
        [NMS(Index = 289)]
        /* 0x1DFE */ public NMSString0x80 AuthBaseUrl;
        [NMS(Index = 287)]
        /* 0x1E7E */ public NMSString0x80 ProxyURI;
        [NMS(Index = 311)]
        /* 0x1EFE */ public NMSString0x40 ForceBaseDownloadUser;
        [NMS(Index = 430)]
        /* 0x1F3E */ public NMSString0x40 OverrideSettlementOwnershipOnlineId;
        [NMS(Index = 429)]
        /* 0x1F7E */ public NMSString0x40 OverrideSettlementOwnershipUsername;
        [NMS(Index = 436)]
        /* 0x1FBE */ public NMSString0x40 ScreenshotForUploadName;
        [NMS(Index = 174)]
        /* 0x1FFE */ public NMSString0x20 AllowedLanguagesFile;
        [NMS(Index = 415)]
        /* 0x201E */ public NMSString0x20 AutomaticPartSpawnID;
        [NMS(Index = 423)]
        /* 0x203E */ public NMSString0x20 BaseServerPlatform;
        [NMS(Index = 215)]
        /* 0x205E */ public NMSString0x20 CrashDumpIdentifier;
        [NMS(Index = 291)]
        /* 0x207E */ public NMSString0x20 OverrideUsernameForDev;
        [NMS(Index = 203)]
        /* 0x209E */ public NMSString0x20 SaveTestingCommand;
        [NMS(Index = 258)]
        /* 0x20BE */ public NMSString0x20 SmokeTestForcePlanetDetail;
        [NMS(Index = 259)]
        /* 0x20DE */ public NMSString0x20 SmokeTestRunFolder;
        [NMS(Index = 314)]
        /* 0x20FE */ public NMSString0x20 SynergyServer;
        [NMS(Index = 129)]
        /* 0x211E */ public bool ActiveMissionsIgnoreStartCancelConditions;
        [NMS(Index = 125)]
        /* 0x211F */ public bool AllowGalaxyMapRequests;
        [NMS(Index = 410)]
        /* 0x2120 */ public bool AllowGlobalPartSnapping;
        [NMS(Index = 283)]
        /* 0x2121 */ public bool AllowMultiThreadedRenderingOnVulkan;
        [NMS(Index = 341)]
        /* 0x2122 */ public bool AllowNGuiVR;
        [NMS(Index = 428)]
        /* 0x2123 */ public bool AllowOverrideSettlementOwnership;
        [NMS(Index = 86)]
        /* 0x2124 */ public bool AllowPause;
        [NMS(Index = 147)]
        /* 0x2125 */ public bool AllowRobotBehaviors;
        [NMS(Index = 2)]
        /* 0x2126 */ public bool AllowSavingOnAbandonedFreighters;
        [NMS(Index = 157)]
        /* 0x2127 */ public bool AllSeasonMilestonesShowComplete;
        [NMS(Index = 87)]
        /* 0x2128 */ public bool AllSettlementsAreCompleted;
        [NMS(Index = 71)]
        /* 0x2129 */ public bool AlternateControls;
        [NMS(Index = 80)]
        /* 0x212A */ public bool AlwaysAllowFreighterInventoryAccess;
        [NMS(Index = 78)]
        /* 0x212B */ public bool AlwaysAllowShipOperations;
        [NMS(Index = 144)]
        /* 0x212C */ public bool AlwaysAllowSpookFiends;
        [NMS(Index = 79)]
        /* 0x212D */ public bool AlwaysAllowVehicleOperations;
        [NMS(Index = 19)]
        /* 0x212E */ public bool AlwaysHaveFocus;
        [NMS(Index = 284)]
        /* 0x212F */ public bool AlwaysIncludeLocalPlayerInChatMessage;
        [NMS(Index = 296)]
        /* 0x2130 */ public bool AlwaysSaveGameAsClient;
        [NMS(Index = 232)]
        /* 0x2131 */ public bool AlwaysShowSaveIds;
        [NMS(Index = 72)]
        /* 0x2132 */ public bool AlwaysShowURI;
        [NMS(Index = 39)]
        /* 0x2133 */ public bool AlwaysSpaceBattle;
        [NMS(Index = 302)]
        /* 0x2134 */ public bool AutoJoinRandomGames;
        [NMS(Index = 294)]
        /* 0x2135 */ public bool AutoJoinUserEnabled;
        [NMS(Index = 417)]
        /* 0x2136 */ public bool AutomaticPartSpawnInactive;
        [NMS(Index = 422)]
        /* 0x2137 */ public bool BaseAdmin;
        [NMS(Index = 91)]
        /* 0x2138 */ public bool BlockCommunicatorSignals;
        [NMS(Index = 431)]
        /* 0x2139 */ public bool BlockSettlementsNetwork;
        [NMS(Index = 41)]
        /* 0x213A */ public bool BlockSpaceBattle;
        [NMS(Index = 335)]
        /* 0x213B */ public bool BodyTurning;
        [NMS(Index = 12)]
        /* 0x213C */ public bool BootDirectlyIntoLastSave;
        [NMS(Index = 191)]
        /* 0x213D */ public bool BootMusic;
        [NMS(Index = 30)]
        /* 0x213E */ public bool CanLeaveDialogs;
        [NMS(Index = 290)]
        /* 0x213F */ public bool CertificateSecurityBypass;
        [NMS(Index = 201)]
        /* 0x2140 */ public bool CheckForMissingLocStrings;
        [NMS(Index = 56)]
        /* 0x2141 */ public bool ClothForceAsyncSimulationOff;
        [NMS(Index = 57)]
        /* 0x2142 */ public bool ClothForceAsyncSimulationOn;
        [NMS(Index = 55)]
        /* 0x2143 */ public bool ClothForcePositionExtrapolationAntiSyncWithFpsLock;
        [NMS(Index = 52)]
        /* 0x2144 */ public bool ClothForcePositionExtrapolationBackOn;
        [NMS(Index = 50)]
        /* 0x2145 */ public bool ClothForcePositionExtrapolationOff;
        [NMS(Index = 51)]
        /* 0x2146 */ public bool ClothForcePositionExtrapolationOn;
        [NMS(Index = 54)]
        /* 0x2147 */ public bool ClothForcePositionExtrapolationSyncWithFpsLock;
        [NMS(Index = 53)]
        /* 0x2148 */ public bool ClothForcePositionExtrapolationUpdateOrderDependent;
        [NMS(Index = 264)]
        /* 0x2149 */ public bool CompressTextures;
        [NMS(Index = 213)]
        /* 0x214A */ public bool CrashDumpFull;
        [NMS(Index = 97)]
        /* 0x214B */ public bool CrashOnF10;
        [NMS(Index = 260)]
        /* 0x214C */ public bool CreatureChatter;
        [NMS(Index = 262)]
        /* 0x214D */ public bool CreatureDrawVocals;
        [NMS(Index = 261)]
        /* 0x214E */ public bool CreatureErrors;
        [NMS(Index = 425)]
        /* 0x214F */ public bool CrossPlatformFeaturedBases;
        [NMS(Index = 404)]
        /* 0x2150 */ public bool DChecksEnabled;
        [NMS(Index = 406)]
        /* 0x2151 */ public bool DChecksOutputBinary;
        [NMS(Index = 407)]
        /* 0x2152 */ public bool DChecksOutputFileLine;
        [NMS(Index = 405)]
        /* 0x2153 */ public bool DChecksOutputJson;
        [NMS(Index = 198)]
        /* 0x2154 */ public bool DebugBuildingSpawns;
        [NMS(Index = 269)]
        /* 0x2155 */ public bool DebugDepthReprojection;
        [NMS(Index = 166)]
        /* 0x2156 */ public bool DebugDrawPlayerInteract;
        [NMS(Index = 21)]
        /* 0x2157 */ public bool DebugGalaxyMapInQuickMenu;
        [NMS(Index = 265)]
        /* 0x2158 */ public bool DebugIBL;
        [NMS(Index = 202)]
        /* 0x2159 */ public bool DebugNetworkLocks;
        [NMS(Index = 178)]
        /* 0x215A */ public bool DebugPersistentInteractions;
        [NMS(Index = 268)]
        /* 0x215B */ public bool DebugRenderSpaceOffset;
        [NMS(Index = 266)]
        /* 0x215C */ public bool DebugSpotlights;
        [NMS(Index = 267)]
        /* 0x215D */ public bool DebugTerrainTextures;
        [NMS(Index = 216)]
        /* 0x215E */ public bool DebugThreatLevels;
        [NMS(Index = 398)]
        /* 0x215F */ public bool DeferRegionBodies;
        [NMS(Index = 3)]
        /* 0x2160 */ public bool DisableAbandonedFreighterRoomsOptimisation;
        [NMS(Index = 408)]
        /* 0x2161 */ public bool DisableBaseBuilding;
        [NMS(Index = 409)]
        /* 0x2162 */ public bool DisableBaseBuildingLimits;
        [NMS(Index = 412)]
        /* 0x2163 */ public bool DisableBasePowerRequirements;
        [NMS(Index = 282)]
        /* 0x2164 */ public bool DisableClouds;
        [NMS(Index = 45)]
        /* 0x2165 */ public bool DisableContinuousSaving;
        [NMS(Index = 421)]
        /* 0x2166 */ public bool DisableCorvetteSwapParts;
        [NMS(Index = 98)]
        /* 0x2167 */ public bool DisableCorvetteValidation;
        [NMS(Index = 161)]
        /* 0x2168 */ public bool DisableDebugControls;
        [NMS(Index = 165)]
        /* 0x2169 */ public bool DisableDiscoveryNaming;
        [NMS(Index = 210)]
        /* 0x216A */ public bool DisableFileWatcher;
        [NMS(Index = 28)]
        /* 0x216B */ public bool DisableHazards;
        [NMS(Index = 339)]
        /* 0x216C */ public bool DisableHeadConstraints;
        [NMS(Index = 46)]
        /* 0x216D */ public bool DisableInvalidSaveVersion;
        [NMS(Index = 338)]
        /* 0x216E */ public bool DisableLeftHand;
        [NMS(Index = 392)]
        /* 0x216F */ public bool DisableLimits;
        [NMS(Index = 180)]
        /* 0x2170 */ public bool DisableMissionShop;
        [NMS(Index = 297)]
        /* 0x2171 */ public bool DisableMonumentDownloads;
        [NMS(Index = 67, MxmlName = "DisableNPCHiddenUntilScanned ")]
        /* 0x2172 */ public bool DisableNPCHiddenUntilScanned;
        [NMS(Index = 66)]
        /* 0x2173 */ public bool DisableNPCs;
        [NMS(Index = 31)]
        /* 0x2174 */ public bool DisableOldMissions;
        [NMS(Index = 433)]
        /* 0x2175 */ public bool DisablePartialStories;
        [NMS(Index = 209)]
        /* 0x2176 */ public bool DisableProfanityFilter;
        [NMS(Index = 43)]
        /* 0x2177 */ public bool DisableSaveSlotSorting;
        [NMS(Index = 312)]
        /* 0x2178 */ public bool DisableSaveUploadRateLimits;
        [NMS(Index = 44)]
        /* 0x2179 */ public bool DisableSaving;
        [NMS(Index = 88)]
        /* 0x217A */ public bool DisableSettlements;
        [NMS(Index = 270)]
        /* 0x217B */ public bool DisableShadowSwitching;
        [NMS(Index = 186)]
        /* 0x217C */ public bool DisableShipSaveDataRecovery;
        [NMS(Index = 293)]
        /* 0x217D */ public bool DisableSpaceStationSpawnOnJoin;
        [NMS(Index = 47)]
        /* 0x217E */ public bool DisableStorms;
        [NMS(Index = 20)]
        /* 0x217F */ public bool DisableVibration;
        [NMS(Index = 175)]
        /* 0x2180 */ public bool DoAlienLanguage;
        [NMS(Index = 263)]
        /* 0x2181 */ public bool DrawCreaturesInRoutines;
        [NMS(Index = 217)]
        /* 0x2182 */ public bool DumpManifestContents;
        [NMS(Index = 432)]
        /* 0x2183 */ public bool EnableAccessibleUI;
        [NMS(Index = 160)]
        /* 0x2184 */ public bool EnableBaseBuildingExpandables;
        [NMS(Index = 413)]
        /* 0x2185 */ public bool EnableBaseMovingOption;
        [NMS(Index = 134)]
        /* 0x2186 */ public bool EnableCloudAnimation;
        [NMS(Index = 277)]
        /* 0x2187 */ public bool EnableComputePost;
        [NMS(Index = 143)]
        /* 0x2188 */ public bool EnableDayNightCycle;
        [NMS(Index = 110)]
        /* 0x2189 */ public bool EnableDebugSceneAutoSave;
        [NMS(Index = 278)]
        /* 0x218A */ public bool EnableEvenOddRender;
        [NMS(Index = 123)]
        /* 0x218B */ public bool EnableFrontendPreload;
        [NMS(Index = 158)]
        /* 0x218C */ public bool EnableGalaxyRecolouring;
        [NMS(Index = 275)]
        /* 0x218D */ public bool EnableGgx;
        [NMS(Index = 90)]
        /* 0x218E */ public bool EnableMemoryPoolAllocPrint;
        [NMS(Index = 340)]
        /* 0x218F */ public bool EnablePhotomodeVR;
        [NMS(Index = 313)]
        /* 0x2190 */ public bool EnableSynergy;
        [NMS(Index = 93)]
        /* 0x2191 */ public bool EnableTouchScreenDebugging;
        [NMS(Index = 24)]
        /* 0x2192 */ public bool EverythingIsFree;
        [NMS(Index = 25)]
        /* 0x2193 */ public bool EverythingIsKnown;
        [NMS(Index = 26)]
        /* 0x2194 */ public bool EverythingIsStar;
        [NMS(Index = 305)]
        /* 0x2195 */ public bool FakeHandsInMultiplayer;
        [NMS(Index = 42)]
        /* 0x2196 */ public bool FastAndFrequentFleetInterventions;
        [NMS(Index = 10)]
        /* 0x2197 */ public bool FastLoad;
        [NMS(Index = 162)]
        /* 0x2198 */ public bool FixedFramerate;
        [NMS(Index = 194)]
        /* 0x2199 */ public bool FleetDirectorAutoMode;
        [NMS(Index = 448)]
        /* 0x219A */ public bool ForceAllExhibitsToBeEditable;
        [NMS(Index = 189)]
        /* 0x219B */ public bool ForceBasicLoadScreen;
        [NMS(Index = 371)]
        /* 0x219C */ public bool ForceBinaryStar;
        [NMS(Index = 348)]
        /* 0x219D */ public bool ForceBiome;
        [NMS(Index = 69)]
        /* 0x219E */ public bool ForceBuildersAlwaysKnown;
        [NMS(Index = 353)]
        /* 0x219F */ public bool ForceBuildingRace;
        [NMS(Index = 344)]
        /* 0x21A0 */ public bool ForceCorruptSentinels;
        [NMS(Index = 357)]
        /* 0x21A1 */ public bool ForceCreatureLifeLevel;
        [NMS(Index = 358)]
        /* 0x21A2 */ public bool ForceDefaultCreatureFile;
        [NMS(Index = 49)]
        /* 0x21A3 */ public bool ForceDisableClothComponent;
        [NMS(Index = 62)]
        /* 0x21A4 */ public bool ForceDisableNonPlayerRagdollComponents;
        [NMS(Index = 61)]
        /* 0x21A5 */ public bool ForceDisableRagdollComponent;
        [NMS(Index = 65)]
        /* 0x21A6 */ public bool ForceDisableSeparatePhysicsWorlds;
        [NMS(Index = 64)]
        /* 0x21A7 */ public bool ForceDisableSplitIkOptimisation;
        [NMS(Index = 59)]
        /* 0x21A8 */ public bool ForceDisableSpringComponent;
        [NMS(Index = 48)]
        /* 0x21A9 */ public bool ForceEnableClothComponent;
        [NMS(Index = 60)]
        /* 0x21AA */ public bool ForceEnableRagdollComponent;
        [NMS(Index = 63)]
        /* 0x21AB */ public bool ForceEnableSplitIkOptimisation;
        [NMS(Index = 58)]
        /* 0x21AC */ public bool ForceEnableSpringComponent;
        [NMS(Index = 343)]
        /* 0x21AD */ public bool ForceExtremeSentinels;
        [NMS(Index = 342)]
        /* 0x21AE */ public bool ForceExtremeWeather;
        [NMS(Index = 96)]
        /* 0x21AF */ public bool ForceFullFeatureMode;
        [NMS(Index = 369)]
        /* 0x21B0 */ public bool ForceGasGiantSystem;
        [NMS(Index = 368)]
        /* 0x21B1 */ public bool ForceGiantSystem;
        [NMS(Index = 102)]
        /* 0x21B2 */ public bool ForceInitialShip;
        [NMS(Index = 103)]
        /* 0x21B3 */ public bool ForceInitialWeapon;
        [NMS(Index = 167)]
        /* 0x21B4 */ public bool ForceInteractionToSettings;
        [NMS(Index = 355)]
        /* 0x21B5 */ public bool ForceLifeLevel;
        [NMS(Index = 346)]
        /* 0x21B6 */ public bool ForceLoadAllWeather;
        [NMS(Index = 155)]
        /* 0x21B7 */ public bool ForceNexusInQuickMenu;
        [NMS(Index = 367)]
        /* 0x21B8 */ public bool ForcePirateSystem;
        [NMS(Index = 387)]
        /* 0x21B9 */ public bool ForcePlanetsToHaveNoCaves;
        [NMS(Index = 388)]
        /* 0x21BA */ public bool ForcePlanetsToHaveNoNoiseLayers;
        [NMS(Index = 389)]
        /* 0x21BB */ public bool ForcePlanetsToHaveNoTerrainFeatures;
        [NMS(Index = 386)]
        /* 0x21BC */ public bool ForcePlanetsToHaveNoWater;
        [NMS(Index = 374)]
        /* 0x21BD */ public bool ForcePlanetsToHaveWater;
        [NMS(Index = 370)]
        /* 0x21BE */ public bool ForcePrimeTerrain;
        [NMS(Index = 188)]
        /* 0x21BF */ public bool ForcePurpleSystemsToAlwaysBirth;
        [NMS(Index = 187)]
        /* 0x21C0 */ public bool ForcePurpleSystemsVisibleOnLoad;
        [NMS(Index = 390)]
        /* 0x21C1 */ public bool ForceRareAsteroidSystem;
        [NMS(Index = 0)]
        /* 0x21C2 */ public bool ForceScanEventsToGoPrime;
        [NMS(Index = 351)]
        /* 0x21C3 */ public bool ForceScreenFilter;
        [NMS(Index = 306)]
        /* 0x21C4 */ public bool ForceSmallLobby;
        [NMS(Index = 381)]
        /* 0x21C5 */ public bool ForceSpaceSkyColourRare;
        [NMS(Index = 345)]
        /* 0x21C6 */ public bool ForceStarType;
        [NMS(Index = 120)]
        /* 0x21C7 */ public bool ForceSunDirectionFromPhotoMode;
        [NMS(Index = 372)]
        /* 0x21C8 */ public bool ForceTernaryStar;
        [NMS(Index = 365)]
        /* 0x21C9 */ public bool ForceTerrainType;
        [NMS(Index = 95)]
        /* 0x21CA */ public bool ForceTgaDlc;
        [NMS(Index = 307)]
        /* 0x21CB */ public bool ForceTinyLobby;
        [NMS(Index = 36)]
        /* 0x21CC */ public bool ForceTranslateAllAlienText;
        [NMS(Index = 377)]
        /* 0x21CD */ public bool ForceWaterCondition;
        [NMS(Index = 185)]
        /* 0x21CE */ public bool FormatDownloadStorageAreaOnBoot;
        [NMS(Index = 16)]
        /* 0x21CF */ public bool GodMode;
        [NMS(Index = 235)]
        /* 0x21D0 */ public bool GraphCommandBuffer;
        [NMS(Index = 237)]
        /* 0x21D1 */ public bool GraphFPS;
        [NMS(Index = 236)]
        /* 0x21D2 */ public bool GraphGeneration;
        [NMS(Index = 238)]
        /* 0x21D3 */ public bool GraphTexStreaming;
        [NMS(Index = 205)]
        /* 0x21D4 */ public bool HangOnCrash;
        [NMS(Index = 333)]
        /* 0x21D5 */ public bool HmdFrameShiftEnabled;
        [NMS(Index = 334)]
        /* 0x21D6 */ public bool HmdUseSolidGuiPointer;
        [NMS(Index = 207)]
        /* 0x21D7 */ public bool HotReloadModGlobals;
        [NMS(Index = 37)]
        /* 0x21D8 */ public bool IgnoreFreighterSpawnWarpRequirement;
        [NMS(Index = 29)]
        /* 0x21D9 */ public bool IgnoreMissionRank;
        [NMS(Index = 159)]
        /* 0x21DA */ public bool IgnoreSteamDev;
        [NMS(Index = 301)]
        /* 0x21DB */ public bool IgnoreTransactionTimeouts;
        [NMS(Index = 171)]
        /* 0x21DC */ public bool InfiniteInteractions;
        [NMS(Index = 27)]
        /* 0x21DD */ public bool InfiniteStamina;
        [NMS(Index = 150)]
        /* 0x21DE */ public bool InstanceCollision;
        [NMS(Index = 170)]
        /* 0x21DF */ public bool InteractionsAllwaysGivesTech;
        [NMS(Index = 396)]
        /* 0x21E0 */ public bool LimitGlobalBodies;
        [NMS(Index = 395)]
        /* 0x21E1 */ public bool LimitGlobalInstances;
        [NMS(Index = 394)]
        /* 0x21E2 */ public bool LimitPerRegionBodies;
        [NMS(Index = 393)]
        /* 0x21E3 */ public bool LimitPerRegionInstances;
        [NMS(Index = 151)]
        /* 0x21E4 */ public bool LoadMissions;
        [NMS(Index = 281)]
        /* 0x21E5 */ public bool LoadShaderSourceIfRenderdocEnabled;
        [NMS(Index = 77)]
        /* 0x21E6 */ public bool LockAllTitles;
        [NMS(Index = 193)]
        /* 0x21E7 */ public bool LogMissingLocalisedText;
        [NMS(Index = 23)]
        /* 0x21E8 */ public bool MapWarpCheckIgnoreDrive;
        [NMS(Index = 22)]
        /* 0x21E9 */ public bool MapWarpCheckIgnoreFuel;
        [NMS(Index = 38)]
        /* 0x21EA */ public bool MaximumFreighterSpawns;
        [NMS(Index = 117)]
        /* 0x21EB */ public bool MemCsv;
        [NMS(Index = 126)]
        /* 0x21EC */ public bool MissionMessageLoggingEnabled;
        [NMS(Index = 127)]
        /* 0x21ED */ public bool MissionNGUIShowsConditionResults;
        [NMS(Index = 128)]
        /* 0x21EE */ public bool MissionNGUIShowsTableNames;
        [NMS(Index = 156)]
        /* 0x21EF */ public bool MissionSurveyEnabled;
        [NMS(Index = 385)]
        /* 0x21F0 */ public bool ModifyPlanetsInInitialSystems;
        [NMS(Index = 152)]
        /* 0x21F1 */ public bool MPMissions;
        [NMS(Index = 73)]
        /* 0x21F2 */ public bool MPMissionsAlwaysEPIC;
        [NMS(Index = 154)]
        /* 0x21F3 */ public bool MultiplePlayerFreightersInASystem;
        [NMS(Index = 89)]
        /* 0x21F4 */ public bool PlaceOnGroundWhenLeavingDebugCamera;
        [NMS(Index = 318)]
        /* 0x21F5 */ public bool PreloadToolbox;
        [NMS(Index = 225)]
        /* 0x21F6 */ public bool PrintAvgFrameTimes;
        [NMS(Index = 324)]
        /* 0x21F7 */ public bool ProceduralModelsDeterministicSequence;
        [NMS(Index = 279)]
        /* 0x21F8 */ public bool Proto2DevKit;
        [NMS(Index = 304)]
        /* 0x21F9 */ public bool RecordNetworkStatsOnBoot;
        [NMS(Index = 34)]
        /* 0x21FA */ public bool RenderCreatureDetails;
        [NMS(Index = 164)]
        /* 0x21FB */ public bool RenderHud;
        [NMS(Index = 274)]
        /* 0x21FC */ public bool RenderLowFramerate;
        [NMS(Index = 122)]
        /* 0x21FD */ public bool ResetForcedSaveSlotOnLoad;
        [NMS(Index = 99)]
        /* 0x21FE */ public bool ResetToSupportedResolution;
        [NMS(Index = 75)]
        /* 0x21FF */ public bool RevealAllTitles;
        [NMS(Index = 208)]
        /* 0x2200 */ public bool SaveOutModdedMetadata;
        [NMS(Index = 447)]
        /* 0x2201 */ public bool ScratchpadPlanetEnvironment;
        [NMS(Index = 163)]
        /* 0x2202 */ public bool ScreenshotMode;
        [NMS(Index = 115)]
        /* 0x2203 */ public bool ShaderCaching;
        [NMS(Index = 113)]
        /* 0x2204 */ public bool ShaderPreloadListExport;
        [NMS(Index = 114)]
        /* 0x2205 */ public bool ShaderPreloadListImport;
        [NMS(Index = 68)]
        /* 0x2206 */ public bool ShipSalvageGivesAllParts;
        [NMS(Index = 218)]
        /* 0x2207 */ public bool ShowDebugMessages;
        [NMS(Index = 221)]
        /* 0x2208 */ public bool ShowDynamicResScale;
        [NMS(Index = 316)]
        /* 0x2209 */ public bool ShowEditorPlacementPreview;
        [NMS(Index = 74)]
        /* 0x220A */ public bool ShowFireteamMembersUA;
        [NMS(Index = 219)]
        /* 0x220B */ public bool ShowFramerate;
        [NMS(Index = 227)]
        /* 0x220C */ public bool ShowGPUMemory;
        [NMS(Index = 220)]
        /* 0x220D */ public bool ShowGPURenderTime;
        [NMS(Index = 233)]
        /* 0x220E */ public bool ShowGraphs;
        [NMS(Index = 336)]
        /* 0x220F */ public bool ShowHmdHandControllers;
        [NMS(Index = 200)]
        /* 0x2210 */ public bool ShowLongestStrings;
        [NMS(Index = 228)]
        /* 0x2211 */ public bool ShowMempoolOverlay;
        [NMS(Index = 426)]
        /* 0x2212 */ public bool ShowMissionIdInTitle;
        [NMS(Index = 229)]
        /* 0x2213 */ public bool ShowMouseSmoothing;
        [NMS(Index = 226)]
        /* 0x2214 */ public bool ShowPositionDebug;
        [NMS(Index = 231)]
        /* 0x2215 */ public bool ShowRenderStatsDisplay;
        [NMS(Index = 337)]
        /* 0x2216 */ public bool ShowTeleportEffectLocally;
        [NMS(Index = 280)]
        /* 0x2217 */ public bool SimulateDisabledParticleRefractions;
        [NMS(Index = 285)]
        /* 0x2218 */ public bool SimulateNoNetworkConnection;
        [NMS(Index = 1)]
        /* 0x2219 */ public bool SkipAbandonedFreighterUnlocking;
        [NMS(Index = 7)]
        /* 0x221A */ public bool SkipIntro;
        [NMS(Index = 8)]
        /* 0x221B */ public bool SkipLogos;
        [NMS(Index = 14)]
        /* 0x221C */ public bool SkipPlanetDiscoverOnBoot;
        [NMS(Index = 35)]
        /* 0x221D */ public bool SkipTutorial;
        [NMS(Index = 9)]
        /* 0x221E */ public bool SkipUITimers;
        [NMS(Index = 247)]
        /* 0x221F */ public bool SmokeTestCameraFly;
        [NMS(Index = 253)]
        /* 0x2220 */ public bool SmokeTestConfigRandomizePlanetSeed;
        [NMS(Index = 239)]
        /* 0x2221 */ public bool SmokeTestDumpStatsMode;
        [NMS(Index = 246)]
        /* 0x2222 */ public bool SmokeTestFastExit;
        [NMS(Index = 242)]
        /* 0x2223 */ public bool SmokeTestLegacyOutput;
        [NMS(Index = 248)]
        /* 0x2224 */ public bool SmokeTestOutputOnly;
        [NMS(Index = 257)]
        /* 0x2225 */ public bool SmokeTestPostBandwidthStats;
        [NMS(Index = 249)]
        /* 0x2226 */ public bool SmokeTestPureFlight;
        [NMS(Index = 255)]
        /* 0x2227 */ public bool SmokeTestSmokeBotAutoStart;
        [NMS(Index = 254)]
        /* 0x2228 */ public bool SmokeTestSmokeBotEnabled;
        [NMS(Index = 145)]
        /* 0x2229 */ public bool SpawnPirates;
        [NMS(Index = 149)]
        /* 0x222A */ public bool SpawnPulseEncounters;
        [NMS(Index = 146)]
        /* 0x222B */ public bool SpawnRobots;
        [NMS(Index = 148)]
        /* 0x222C */ public bool SpawnShips;
        [NMS(Index = 153)]
        /* 0x222D */ public bool SpecialsShop;
        [NMS(Index = 172)]
        /* 0x222E */ public bool StopSwitchingToSecondaryInteractions;
        [NMS(Index = 199)]
        /* 0x222F */ public bool StressTestLongNameDisplay;
        [NMS(Index = 18)]
        /* 0x2230 */ public bool SuperKillGuns;
        [NMS(Index = 130)]
        /* 0x2231 */ public bool SuppressSeasonalRewardReminders;
        [NMS(Index = 17)]
        /* 0x2232 */ public bool TakeNoDamage;
        [NMS(Index = 5)]
        /* 0x2233 */ public bool ThirdPersonIsDefaultCameraForPlayer;
        [NMS(Index = 6)]
        /* 0x2234 */ public bool ThirdPersonIsDefaultCameraForShipAndVehicles;
        [NMS(Index = 84)]
        /* 0x2235 */ public bool UnlockAllPlatformRewards;
        [NMS(Index = 82)]
        /* 0x2236 */ public bool UnlockAllSeasonRewards;
        [NMS(Index = 434)]
        /* 0x2237 */ public bool UnlockAllStories;
        [NMS(Index = 76)]
        /* 0x2238 */ public bool UnlockAllTitles;
        [NMS(Index = 83)]
        /* 0x2239 */ public bool UnlockAllTwitchRewards;
        [NMS(Index = 435)]
        /* 0x223A */ public bool UnlockAllWords;
        [NMS(Index = 138)]
        /* 0x223B */ public bool UseBuildings;
        [NMS(Index = 133)]
        /* 0x223C */ public bool UseClouds;
        [NMS(Index = 139)]
        /* 0x223D */ public bool UseCreatures;
        [NMS(Index = 140)]
        /* 0x223E */ public bool UseElevation;
        [NMS(Index = 33)]
        /* 0x223F */ public bool UseGunImpactEffect;
        [NMS(Index = 179)]
        /* 0x2240 */ public bool UseHighlightedOptionStyle;
        [NMS(Index = 94)]
        /* 0x2241 */ public bool UseImmediateModeFrontend;
        [NMS(Index = 136)]
        /* 0x2242 */ public bool UseInstances;
        [NMS(Index = 142)]
        /* 0x2243 */ public bool UseLegacyBuildingTable;
        [NMS(Index = 141)]
        /* 0x2244 */ public bool UseLegacyFreighters;
        [NMS(Index = 92)]
        /* 0x2245 */ public bool UseMovementStickForRun;
        [NMS(Index = 137)]
        /* 0x2246 */ public bool UseObjects;
        [NMS(Index = 403)]
        /* 0x2247 */ public bool UseOldTerrainMeshing;
        [NMS(Index = 298)]
        /* 0x2248 */ public bool UsePadOnUnfocusedWindow;
        [NMS(Index = 131)]
        /* 0x2249 */ public bool UseParticles;
        [NMS(Index = 320)]
        /* 0x224A */ public bool UseProcTextureDebugger;
        [NMS(Index = 124)]
        /* 0x224B */ public bool UseSceneInfoWindow;
        [NMS(Index = 32)]
        /* 0x224C */ public bool UseScreenEffects;
        [NMS(Index = 445)]
        /* 0x224D */ public bool UseSeasonTransferInventoryConfigOverride;
        [NMS(Index = 135)]
        /* 0x224E */ public bool UseTerrain;
        [NMS(Index = 132)]
        /* 0x224F */ public bool UseVolumetrics;
        [NMS(Index = 15)]
        /* 0x2250 */ public bool VideoCaptureMode;
    }
}
