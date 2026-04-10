using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6B227144AC750D3C, NameHash = 0x37EE71BB)]
    public class GcScanEventData : NMSTemplate
    {
        [NMS(Index = 45)]
        /* 0x000 */ public GcScanEventSolarSystemLookup SolarSystemAttributes;
        [NMS(Index = 46)]
        /* 0x0B0 */ public GcScanEventSolarSystemLookup SolarSystemAttributesFallback;
        [NMS(Index = 69)]
        /* 0x160 */ public GcResourceElement ResourceOverride;
        [NMS(Index = 1)]
        /* 0x1A8 */ public NMSString0x20A ForceInteraction;
        [NMS(Index = 7)]
        /* 0x1C8 */ public NMSString0x20A MustMatchStoryUtilityPuzzle;
        [NMS(Index = 0)]
        /* 0x1E8 */ public NMSString0x20A Name;
        [NMS(Index = 50)]
        /* 0x208 */ public NMSString0x20A NextOption;
        [NMS(Index = 71)]
        /* 0x228 */ public NMSString0x20A OverrideGameTableConfig;
        [NMS(Index = 73)]
        /* 0x248 */ public NMSString0x20A OverrideGameTableGameConfig;
        [NMS(Index = 74)]
        /* 0x268 */ public NMSString0x20A OverrideGameTableGameConfigOnCompletion;
        [NMS(Index = 22)]
        /* 0x288 */ public NMSString0x20A PlanetLabelText;
        [NMS(Index = 70)]
        /* 0x2A8 */ public NMSString0x20A RequireDefaultGameTableConfig;
        [NMS(Index = 24)]
        /* 0x2C8 */ public NMSString0x20A SurveyDiscoveryOSDMessage;
        [NMS(Index = 25)]
        /* 0x2E8 */ public NMSString0x20A SurveyHUDName;
        [NMS(Index = 57)]
        /* 0x308 */ public TkTextureResource MarkerIcon;
        [NMS(Index = 51)]
        /* 0x320 */ public GcScanEventTriggers TriggerActions;
        [NMS(Index = 13)]
        /* 0x338 */ public NMSString0x10 ForceOverrideEncounter;
        [NMS(Index = 49)]
        /* 0x348 */ public NMSString0x10 HasReward;
        [NMS(Index = 55)]
        /* 0x358 */ public VariableSizeString InterstellarOSDMessage;
        [NMS(Index = 56)]
        /* 0x368 */ public VariableSizeString MarkerLabel;
        [NMS(Index = 68)]
        /* 0x378 */ public NMSString0x10 MissionMessageOnInteract;
        [NMS(Index = 54)]
        /* 0x388 */ public VariableSizeString OSDMessage;
        [NMS(Index = 10)]
        /* 0x398 */ public NMSString0x10 ReplacementMaintData;
        [NMS(Index = 67)]
        /* 0x3A8 */ public VariableSizeString TooltipMessage;
        [NMS(Index = 52)]
        /* 0x3B8 */ public List<VariableSizeString> UAsList;
        [NMS(Index = 43)]
        /* 0x3C8 */ public VariableSizeString UseUDAAsSearchPoint;
        // size: 0x8
        public enum BuildingLocationEnum : uint {
            Nearest,
            AllNearest,
            Random,
            RandomOnNearPlanet,
            RandomOnFarPlanet,
            PlanetSearch,
            PlayerSettlement,
            NearestUnmarked,
        }
        [NMS(Index = 34)]
        /* 0x3D8 */ public BuildingLocationEnum BuildingLocation;
        [NMS(Index = 16)]
        /* 0x3DC */ public float BuildingPreventionRadius;
        // size: 0x5
        public enum EventEndTypeEnum : uint {
            None,
            Proximity,
            Interact,
            EnterBuilding,
            TimedInteract,
        }
        [NMS(Index = 28)]
        /* 0x3E0 */ public EventEndTypeEnum EventEndType;
        // size: 0x2
        public enum EventPriorityEnum : uint {
            Regular,
            High,
        }
        [NMS(Index = 29)]
        /* 0x3E4 */ public EventPriorityEnum EventPriority;
        // size: 0x6
        public enum EventStartTypeEnum : uint {
            None,
            Special,
            Discovered,
            Timer,
            ObjectScan,
            LeaveBuilding,
        }
        [NMS(Index = 27)]
        /* 0x3E8 */ public EventStartTypeEnum EventStartType;
        [NMS(Index = 3)]
        /* 0x3EC */ public GcInteractionType ForceInteractionType;
        [NMS(Index = 63)]
        /* 0x3F0 */ public float IconTime;
        [NMS(Index = 62)]
        /* 0x3F4 */ public GcAudioWwiseEvents MessageAudio;
        [NMS(Index = 61)]
        /* 0x3F8 */ public float MessageDisplayTime;
        [NMS(Index = 60)]
        /* 0x3FC */ public float MessageTime;
        [NMS(Index = 58)]
        /* 0x400 */ public GcScannerIconHighlightTypes MissionMarkerHighlightStyleOverride;
        [NMS(Index = 6)]
        /* 0x404 */ public GcAlienRace OverrideInteractionRace;
        [NMS(Index = 26)]
        /* 0x408 */ public GcStaticTag PlaceMarkerAtTaggedNode;
        [NMS(Index = 5)]
        /* 0x40C */ public GcAlienRace RequireInteractionRace;
        // size: 0x1C
        public enum SearchTypeEnum : uint {
            Any,
            AnyShelter,
            AnyNPC,
            FindBuildingClass,
            SpaceStation,
            SpaceAnomaly,
            Atlas,
            Freighter,
            FreighterBase,
            ExternalPlanetBase,
            PlanetBaseTerminal,
            Expedition,
            ExpeditionLeader,
            TutorialShelter,
            MPMissionFreighter,
            Nexus,
            InitialDistressSignal,
            SpaceMarker,
            NexusEggMachine,
            PhotoTarget,
            NPC_PetBattle,
            SettlementConstruction,
            UnownedSettlement,
            NPC_HideOut,
            FriendlyDrone,
            AnyRobotSite,
            UnownedSettlement_Builders,
            OwnedSettlementHub,
        }
        [NMS(Index = 35)]
        /* 0x410 */ public SearchTypeEnum SearchType;
        // size: 0x7
        public enum SolarSystemLocationEnum : uint {
            Local,
            Near,
            LocalOrNear,
            NearWithNoExpeditions,
            FromList,
            SeasonParty,
            FirstPurpleSystemUA,
        }
        [NMS(Index = 44)]
        /* 0x414 */ public SolarSystemLocationEnum SolarSystemLocation;
        [NMS(Index = 59)]
        /* 0x418 */ public float StartTime;
        [NMS(Index = 23)]
        /* 0x41C */ public float SurveyDistance;
        [NMS(Index = 53)]
        /* 0x420 */ public GcTechnologyCategory TechShopType;
        [NMS(Index = 64)]
        /* 0x424 */ public float TooltipTime;
        [NMS(Index = 37)]
        /* 0x428 */ public bool AllowFriendsBases;
        [NMS(Index = 40)]
        /* 0x429 */ public bool AllowOverriddenBuildings;
        [NMS(Index = 19)]
        /* 0x42A */ public bool AlwaysShow;
        [NMS(Index = 32)]
        /* 0x42B */ public bool BlockStartedOnUseEvents;
        [NMS(Index = 17)]
        /* 0x42C */ public bool BuildingPreventionDisallowBuilding;
        [NMS(Index = 30)]
        /* 0x42D */ public bool CanEndFromOutsideMission;
        [NMS(Index = 15)]
        /* 0x42E */ public bool ClearForcedInteractionOnCompletion;
        [NMS(Index = 72)]
        /* 0x42F */ public bool ClearGameTableConfigOverrideOnCompletion;
        [NMS(Index = 31)]
        /* 0x430 */ public bool DisableMultiplayerSync;
        [NMS(Index = 8)]
        /* 0x431 */ public bool ForceBroken;
        [NMS(Index = 9)]
        /* 0x432 */ public bool ForceFixed;
        [NMS(Index = 12)]
        /* 0x433 */ public bool ForceOverridesAll;
        [NMS(Index = 11)]
        /* 0x434 */ public bool ForceReplaceStoryPortalSeed;
        [NMS(Index = 48)]
        /* 0x435 */ public bool ForceResetPortal;
        [NMS(Index = 47)]
        /* 0x436 */ public bool ForceRestartInteraction;
        [NMS(Index = 38)]
        /* 0x437 */ public bool ForceWideRandom;
        [NMS(Index = 14)]
        /* 0x438 */ public bool IsCommunityPortalOverride;
        [NMS(Index = 39)]
        /* 0x439 */ public bool MustFindSystem;
        [NMS(Index = 20)]
        /* 0x43A */ public bool NeverShow;
        [NMS(Index = 4)]
        /* 0x43B */ public bool NPCReactsToPlayer;
        [NMS(Index = 33)]
        /* 0x43C */ public bool ReplaceEventIfAlreadyActive;
        [NMS(Index = 66)]
        /* 0x43D */ public bool ShowEndTooltip;
        [NMS(Index = 21)]
        /* 0x43E */ public bool ShowOnlyIfSequenceTarget;
        [NMS(Index = 36)]
        /* 0x43F */ public GcBuildingClassification SpecificBuildingClass;
        [NMS(Index = 41)]
        /* 0x440 */ public bool TargetMustMatchMissionSeed;
        [NMS(Index = 65)]
        /* 0x441 */ public bool TooltipRepeats;
        [NMS(Index = 42)]
        /* 0x442 */ public bool UseBuildingFromRendezvousStage;
        [NMS(Index = 18)]
        /* 0x443 */ public bool UseMissionTradingDataOverride;
        [NMS(Index = 2)]
        /* 0x444 */ public bool UseSeasonDataAsInteraction;
    }
}
