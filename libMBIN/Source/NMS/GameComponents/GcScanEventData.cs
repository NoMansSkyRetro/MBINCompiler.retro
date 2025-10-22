using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x11F34D4AF100D228, NameHash = 0x37EE71BB)]
    public class GcScanEventData : NMSTemplate
    {
        [NMS(Index = 42)]
        /* 0x000 */ public GcScanEventSolarSystemLookup SolarSystemAttributes;
        [NMS(Index = 43)]
        /* 0x0B0 */ public GcScanEventSolarSystemLookup SolarSystemAttributesFallback;
        [NMS(Index = 66)]
        /* 0x160 */ public GcResourceElement ResourceOverride;
        [NMS(Index = 1)]
        /* 0x1A8 */ public NMSString0x20A ForceInteraction;
        [NMS(Index = 7)]
        /* 0x1C8 */ public NMSString0x20A MustMatchStoryUtilityPuzzle;
        [NMS(Index = 0)]
        /* 0x1E8 */ public NMSString0x20A Name;
        [NMS(Index = 47)]
        /* 0x208 */ public NMSString0x20A NextOption;
        [NMS(Index = 21)]
        /* 0x228 */ public NMSString0x20A PlanetLabelText;
        [NMS(Index = 23)]
        /* 0x248 */ public NMSString0x20A SurveyDiscoveryOSDMessage;
        [NMS(Index = 24)]
        /* 0x268 */ public NMSString0x20A SurveyHUDName;
        [NMS(Index = 54)]
        /* 0x288 */ public TkTextureResource MarkerIcon;
        [NMS(Index = 48)]
        /* 0x2A0 */ public GcScanEventTriggers TriggerActions;
        [NMS(Index = 13)]
        /* 0x2B8 */ public NMSString0x10 ForceOverrideEncounter;
        [NMS(Index = 46)]
        /* 0x2C8 */ public NMSString0x10 HasReward;
        [NMS(Index = 52)]
        /* 0x2D8 */ public VariableSizeString InterstellarOSDMessage;
        [NMS(Index = 53)]
        /* 0x2E8 */ public VariableSizeString MarkerLabel;
        [NMS(Index = 65)]
        /* 0x2F8 */ public NMSString0x10 MissionMessageOnInteract;
        [NMS(Index = 51)]
        /* 0x308 */ public VariableSizeString OSDMessage;
        [NMS(Index = 10)]
        /* 0x318 */ public NMSString0x10 ReplacementMaintData;
        [NMS(Index = 64)]
        /* 0x328 */ public VariableSizeString TooltipMessage;
        [NMS(Index = 49)]
        /* 0x338 */ public List<VariableSizeString> UAsList;
        // size: 0x7
        public enum BuildingLocationEnum : uint {
            Nearest,
            AllNearest,
            Random,
            RandomOnNearPlanet,
            RandomOnFarPlanet,
            PlanetSearch,
            PlayerSettlement,
        }
        [NMS(Index = 32)]
        /* 0x348 */ public BuildingLocationEnum BuildingLocation;
        [NMS(Index = 16)]
        /* 0x34C */ public float BuildingPreventionRadius;
        // size: 0x5
        public enum EventEndTypeEnum : uint {
            None,
            Proximity,
            Interact,
            EnterBuilding,
            TimedInteract,
        }
        [NMS(Index = 26)]
        /* 0x350 */ public EventEndTypeEnum EventEndType;
        // size: 0x2
        public enum EventPriorityEnum : uint {
            Regular,
            High,
        }
        [NMS(Index = 27)]
        /* 0x354 */ public EventPriorityEnum EventPriority;
        // size: 0x6
        public enum EventStartTypeEnum : uint {
            None,
            Special,
            Discovered,
            Timer,
            ObjectScan,
            LeaveBuilding,
        }
        [NMS(Index = 25)]
        /* 0x358 */ public EventStartTypeEnum EventStartType;
        [NMS(Index = 3)]
        /* 0x35C */ public GcInteractionType ForceInteractionType;
        [NMS(Index = 60)]
        /* 0x360 */ public float IconTime;
        [NMS(Index = 59)]
        /* 0x364 */ public GcAudioWwiseEvents MessageAudio;
        [NMS(Index = 58)]
        /* 0x368 */ public float MessageDisplayTime;
        [NMS(Index = 57)]
        /* 0x36C */ public float MessageTime;
        [NMS(Index = 55)]
        /* 0x370 */ public GcScannerIconHighlightTypes MissionMarkerHighlightStyleOverride;
        [NMS(Index = 6)]
        /* 0x374 */ public GcAlienRace OverrideInteractionRace;
        [NMS(Index = 5)]
        /* 0x378 */ public GcAlienRace RequireInteractionRace;
        // size: 0x1B
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
            SettlementConstruction,
            UnownedSettlement,
            NPC_HideOut,
            FriendlyDrone,
            AnyRobotSite,
            UnownedSettlement_Builders,
            OwnedSettlementHub,
        }
        [NMS(Index = 33)]
        /* 0x37C */ public SearchTypeEnum SearchType;
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
        [NMS(Index = 41)]
        /* 0x380 */ public SolarSystemLocationEnum SolarSystemLocation;
        [NMS(Index = 34)]
        /* 0x384 */ public GcBuildingClassification SpecificBuildingClass;
        [NMS(Index = 56)]
        /* 0x388 */ public float StartTime;
        [NMS(Index = 22)]
        /* 0x38C */ public float SurveyDistance;
        [NMS(Index = 50)]
        /* 0x390 */ public GcTechnologyCategory TechShopType;
        [NMS(Index = 61)]
        /* 0x394 */ public float TooltipTime;
        [NMS(Index = 35)]
        /* 0x398 */ public bool AllowFriendsBases;
        [NMS(Index = 38)]
        /* 0x399 */ public bool AllowOverriddenBuildings;
        [NMS(Index = 18)]
        /* 0x39A */ public bool AlwaysShow;
        [NMS(Index = 30)]
        /* 0x39B */ public bool BlockStartedOnUseEvents;
        [NMS(Index = 28)]
        /* 0x39C */ public bool CanEndFromOutsideMission;
        [NMS(Index = 15)]
        /* 0x39D */ public bool ClearForcedInteractionOnCompletion;
        [NMS(Index = 29)]
        /* 0x39E */ public bool DisableMultiplayerSync;
        [NMS(Index = 8)]
        /* 0x39F */ public bool ForceBroken;
        [NMS(Index = 9)]
        /* 0x3A0 */ public bool ForceFixed;
        [NMS(Index = 12)]
        /* 0x3A1 */ public bool ForceOverridesAll;
        [NMS(Index = 11)]
        /* 0x3A2 */ public bool ForceReplaceStoryPortalSeed;
        [NMS(Index = 45)]
        /* 0x3A3 */ public bool ForceResetPortal;
        [NMS(Index = 44)]
        /* 0x3A4 */ public bool ForceRestartInteraction;
        [NMS(Index = 36)]
        /* 0x3A5 */ public bool ForceWideRandom;
        [NMS(Index = 14)]
        /* 0x3A6 */ public bool IsCommunityPortalOverride;
        [NMS(Index = 37)]
        /* 0x3A7 */ public bool MustFindSystem;
        [NMS(Index = 19)]
        /* 0x3A8 */ public bool NeverShow;
        [NMS(Index = 4)]
        /* 0x3A9 */ public bool NPCReactsToPlayer;
        [NMS(Index = 31)]
        /* 0x3AA */ public bool ReplaceEventIfAlreadyActive;
        [NMS(Index = 63)]
        /* 0x3AB */ public bool ShowEndTooltip;
        [NMS(Index = 20)]
        /* 0x3AC */ public bool ShowOnlyIfSequenceTarget;
        [NMS(Index = 39)]
        /* 0x3AD */ public bool TargetMustMatchMissionSeed;
        [NMS(Index = 62)]
        /* 0x3AE */ public bool TooltipRepeats;
        [NMS(Index = 40)]
        /* 0x3AF */ public bool UseBuildingFromRendezvousStage;
        [NMS(Index = 17)]
        /* 0x3B0 */ public bool UseMissionTradingDataOverride;
        [NMS(Index = 2)]
        /* 0x3B1 */ public bool UseSeasonDataAsInteraction;
    }
}
