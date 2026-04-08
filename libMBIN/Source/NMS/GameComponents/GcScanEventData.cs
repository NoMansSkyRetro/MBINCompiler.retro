using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF537CB82BAC753F, NameHash = 0x37EE71BB)]
    public class GcScanEventData : NMSTemplate
    {
        [NMS(Index = 48)]
        /* 0x000 */ public GcScanEventSolarSystemLookup SolarSystemAttributes;
        [NMS(Index = 49)]
        /* 0x0B0 */ public GcScanEventSolarSystemLookup SolarSystemAttributesFallback;
        [NMS(Index = 72)]
        /* 0x160 */ public GcResourceElement ResourceOverride;
        [NMS(Index = 1)]
        /* 0x1A8 */ public NMSString0x20A ForceInteraction;
        [NMS(Index = 7)]
        /* 0x1C8 */ public NMSString0x20A MustMatchStoryUtilityPuzzle;
        [NMS(Index = 0)]
        /* 0x1E8 */ public NMSString0x20A Name;
        [NMS(Index = 53)]
        /* 0x208 */ public NMSString0x20A NextOption;
        [NMS(Index = 19)]
        /* 0x228 */ public NMSString0x20A OverrideGameTableConfig;
        [NMS(Index = 20)]
        /* 0x248 */ public NMSString0x20A OverrideGameTableGameConfig;
        [NMS(Index = 24)]
        /* 0x268 */ public NMSString0x20A PlanetLabelText;
        [NMS(Index = 43)]
        /* 0x288 */ public NMSString0x20A RequireDefaultGameTableConfig;
        [NMS(Index = 26)]
        /* 0x2A8 */ public NMSString0x20A SurveyDiscoveryOSDMessage;
        [NMS(Index = 27)]
        /* 0x2C8 */ public NMSString0x20A SurveyHUDName;
        [NMS(Index = 60)]
        /* 0x2E8 */ public TkTextureResource MarkerIcon;
        [NMS(Index = 54)]
        /* 0x300 */ public GcScanEventTriggers TriggerActions;
        [NMS(Index = 13)]
        /* 0x318 */ public NMSString0x10 ForceOverrideEncounter;
        [NMS(Index = 52)]
        /* 0x328 */ public NMSString0x10 HasReward;
        [NMS(Index = 58)]
        /* 0x338 */ public VariableSizeString InterstellarOSDMessage;
        [NMS(Index = 59)]
        /* 0x348 */ public VariableSizeString MarkerLabel;
        [NMS(Index = 71)]
        /* 0x358 */ public NMSString0x10 MissionMessageOnInteract;
        [NMS(Index = 57)]
        /* 0x368 */ public VariableSizeString OSDMessage;
        [NMS(Index = 10)]
        /* 0x378 */ public NMSString0x10 ReplacementMaintData;
        [NMS(Index = 70)]
        /* 0x388 */ public VariableSizeString TooltipMessage;
        [NMS(Index = 55)]
        /* 0x398 */ public List<VariableSizeString> UAsList;
        [NMS(Index = 46)]
        /* 0x3A8 */ public VariableSizeString UseUDAAsSearchPoint;
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
        [NMS(Index = 36)]
        /* 0x3B8 */ public BuildingLocationEnum BuildingLocation;
        [NMS(Index = 16)]
        /* 0x3BC */ public float BuildingPreventionRadius;
        // size: 0x5
        public enum EventEndTypeEnum : uint {
            None,
            Proximity,
            Interact,
            EnterBuilding,
            TimedInteract,
        }
        [NMS(Index = 30)]
        /* 0x3C0 */ public EventEndTypeEnum EventEndType;
        // size: 0x2
        public enum EventPriorityEnum : uint {
            Regular,
            High,
        }
        [NMS(Index = 31)]
        /* 0x3C4 */ public EventPriorityEnum EventPriority;
        // size: 0x6
        public enum EventStartTypeEnum : uint {
            None,
            Special,
            Discovered,
            Timer,
            ObjectScan,
            LeaveBuilding,
        }
        [NMS(Index = 29)]
        /* 0x3C8 */ public EventStartTypeEnum EventStartType;
        [NMS(Index = 3)]
        /* 0x3CC */ public GcInteractionType ForceInteractionType;
        [NMS(Index = 66)]
        /* 0x3D0 */ public float IconTime;
        [NMS(Index = 65)]
        /* 0x3D4 */ public GcAudioWwiseEvents MessageAudio;
        [NMS(Index = 64)]
        /* 0x3D8 */ public float MessageDisplayTime;
        [NMS(Index = 63)]
        /* 0x3DC */ public float MessageTime;
        [NMS(Index = 61)]
        /* 0x3E0 */ public GcScannerIconHighlightTypes MissionMarkerHighlightStyleOverride;
        [NMS(Index = 6)]
        /* 0x3E4 */ public GcAlienRace OverrideInteractionRace;
        [NMS(Index = 28)]
        /* 0x3E8 */ public GcStaticTag PlaceMarkerAtTaggedNode;
        [NMS(Index = 5)]
        /* 0x3EC */ public GcAlienRace RequireInteractionRace;
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
        [NMS(Index = 37)]
        /* 0x3F0 */ public SearchTypeEnum SearchType;
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
        [NMS(Index = 47)]
        /* 0x3F4 */ public SolarSystemLocationEnum SolarSystemLocation;
        [NMS(Index = 62)]
        /* 0x3F8 */ public float StartTime;
        [NMS(Index = 25)]
        /* 0x3FC */ public float SurveyDistance;
        [NMS(Index = 56)]
        /* 0x400 */ public GcTechnologyCategory TechShopType;
        [NMS(Index = 67)]
        /* 0x404 */ public float TooltipTime;
        [NMS(Index = 39)]
        /* 0x408 */ public bool AllowFriendsBases;
        [NMS(Index = 42)]
        /* 0x409 */ public bool AllowOverriddenBuildings;
        [NMS(Index = 21)]
        /* 0x40A */ public bool AlwaysShow;
        [NMS(Index = 34)]
        /* 0x40B */ public bool BlockStartedOnUseEvents;
        [NMS(Index = 17)]
        /* 0x40C */ public bool BuildingPreventionDisallowBuilding;
        [NMS(Index = 32)]
        /* 0x40D */ public bool CanEndFromOutsideMission;
        [NMS(Index = 15)]
        /* 0x40E */ public bool ClearForcedInteractionOnCompletion;
        [NMS(Index = 33)]
        /* 0x40F */ public bool DisableMultiplayerSync;
        [NMS(Index = 8)]
        /* 0x410 */ public bool ForceBroken;
        [NMS(Index = 9)]
        /* 0x411 */ public bool ForceFixed;
        [NMS(Index = 12)]
        /* 0x412 */ public bool ForceOverridesAll;
        [NMS(Index = 11)]
        /* 0x413 */ public bool ForceReplaceStoryPortalSeed;
        [NMS(Index = 51)]
        /* 0x414 */ public bool ForceResetPortal;
        [NMS(Index = 50)]
        /* 0x415 */ public bool ForceRestartInteraction;
        [NMS(Index = 40)]
        /* 0x416 */ public bool ForceWideRandom;
        [NMS(Index = 14)]
        /* 0x417 */ public bool IsCommunityPortalOverride;
        [NMS(Index = 41)]
        /* 0x418 */ public bool MustFindSystem;
        [NMS(Index = 22)]
        /* 0x419 */ public bool NeverShow;
        [NMS(Index = 4)]
        /* 0x41A */ public bool NPCReactsToPlayer;
        [NMS(Index = 35)]
        /* 0x41B */ public bool ReplaceEventIfAlreadyActive;
        [NMS(Index = 69)]
        /* 0x41C */ public bool ShowEndTooltip;
        [NMS(Index = 23)]
        /* 0x41D */ public bool ShowOnlyIfSequenceTarget;
        [NMS(Index = 38)]
        /* 0x41E */ public GcBuildingClassification SpecificBuildingClass;
        [NMS(Index = 44)]
        /* 0x41F */ public bool TargetMustMatchMissionSeed;
        [NMS(Index = 68)]
        /* 0x420 */ public bool TooltipRepeats;
        [NMS(Index = 45)]
        /* 0x421 */ public bool UseBuildingFromRendezvousStage;
        [NMS(Index = 18)]
        /* 0x422 */ public bool UseMissionTradingDataOverride;
        [NMS(Index = 2)]
        /* 0x423 */ public bool UseSeasonDataAsInteraction;
    }
}
