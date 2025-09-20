using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBE86149BFD67A312, NameHash = 0x37EE71BB)]
    public class GcScanEventData : NMSTemplate
    {
        [NMS(Index = 42)]
        /* 0x000 */ public GcScanEventSolarSystemLookup SolarSystemAttributes;
        [NMS(Index = 43)]
        /* 0x0A0 */ public GcScanEventSolarSystemLookup SolarSystemAttributesFallback;
        [NMS(Index = 66)]
        /* 0x140 */ public GcResourceElement ResourceOverride;
        [NMS(Index = 1)]
        /* 0x188 */ public NMSString0x20A ForceInteraction;
        [NMS(Index = 7)]
        /* 0x1A8 */ public NMSString0x20A MustMatchStoryUtilityPuzzle;
        [NMS(Index = 0)]
        /* 0x1C8 */ public NMSString0x20A Name;
        [NMS(Index = 47)]
        /* 0x1E8 */ public NMSString0x20A NextOption;
        [NMS(Index = 21)]
        /* 0x208 */ public NMSString0x20A PlanetLabelText;
        [NMS(Index = 23)]
        /* 0x228 */ public NMSString0x20A SurveyDiscoveryOSDMessage;
        [NMS(Index = 24)]
        /* 0x248 */ public NMSString0x20A SurveyHUDName;
        [NMS(Index = 54)]
        /* 0x268 */ public TkTextureResource MarkerIcon;
        [NMS(Index = 48)]
        /* 0x280 */ public GcScanEventTriggers TriggerActions;
        [NMS(Index = 13)]
        /* 0x298 */ public NMSString0x10 ForceOverrideEncounter;
        [NMS(Index = 46)]
        /* 0x2A8 */ public NMSString0x10 HasReward;
        [NMS(Index = 52)]
        /* 0x2B8 */ public VariableSizeString InterstellarOSDMessage;
        [NMS(Index = 53)]
        /* 0x2C8 */ public VariableSizeString MarkerLabel;
        [NMS(Index = 65)]
        /* 0x2D8 */ public NMSString0x10 MissionMessageOnInteract;
        [NMS(Index = 51)]
        /* 0x2E8 */ public VariableSizeString OSDMessage;
        [NMS(Index = 10)]
        /* 0x2F8 */ public NMSString0x10 ReplacementMaintData;
        [NMS(Index = 64)]
        /* 0x308 */ public VariableSizeString TooltipMessage;
        [NMS(Index = 49)]
        /* 0x318 */ public List<VariableSizeString> UAsList;
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
        /* 0x328 */ public BuildingLocationEnum BuildingLocation;
        [NMS(Index = 16)]
        /* 0x32C */ public float BuildingPreventionRadius;
        // size: 0x5
        public enum EventEndTypeEnum : uint {
            None,
            Proximity,
            Interact,
            EnterBuilding,
            TimedInteract,
        }
        [NMS(Index = 26)]
        /* 0x330 */ public EventEndTypeEnum EventEndType;
        // size: 0x2
        public enum EventPriorityEnum : uint {
            Regular,
            High,
        }
        [NMS(Index = 27)]
        /* 0x334 */ public EventPriorityEnum EventPriority;
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
        /* 0x338 */ public EventStartTypeEnum EventStartType;
        [NMS(Index = 3)]
        /* 0x33C */ public GcInteractionType ForceInteractionType;
        [NMS(Index = 60)]
        /* 0x340 */ public float IconTime;
        [NMS(Index = 59)]
        /* 0x344 */ public GcAudioWwiseEvents MessageAudio;
        [NMS(Index = 58)]
        /* 0x348 */ public float MessageDisplayTime;
        [NMS(Index = 57)]
        /* 0x34C */ public float MessageTime;
        [NMS(Index = 55)]
        /* 0x350 */ public GcScannerIconHighlightTypes MissionMarkerHighlightStyleOverride;
        [NMS(Index = 6)]
        /* 0x354 */ public GcAlienRace OverrideInteractionRace;
        [NMS(Index = 5)]
        /* 0x358 */ public GcAlienRace RequireInteractionRace;
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
        /* 0x35C */ public SearchTypeEnum SearchType;
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
        /* 0x360 */ public SolarSystemLocationEnum SolarSystemLocation;
        [NMS(Index = 34)]
        /* 0x364 */ public GcBuildingClassification SpecificBuildingClass;
        [NMS(Index = 56)]
        /* 0x368 */ public float StartTime;
        [NMS(Index = 22)]
        /* 0x36C */ public float SurveyDistance;
        [NMS(Index = 50)]
        /* 0x370 */ public GcTechnologyCategory TechShopType;
        [NMS(Index = 61)]
        /* 0x374 */ public float TooltipTime;
        [NMS(Index = 35)]
        /* 0x378 */ public bool AllowFriendsBases;
        [NMS(Index = 38)]
        /* 0x379 */ public bool AllowOverriddenBuildings;
        [NMS(Index = 18)]
        /* 0x37A */ public bool AlwaysShow;
        [NMS(Index = 30)]
        /* 0x37B */ public bool BlockStartedOnUseEvents;
        [NMS(Index = 28)]
        /* 0x37C */ public bool CanEndFromOutsideMission;
        [NMS(Index = 15)]
        /* 0x37D */ public bool ClearForcedInteractionOnCompletion;
        [NMS(Index = 29)]
        /* 0x37E */ public bool DisableMultiplayerSync;
        [NMS(Index = 8)]
        /* 0x37F */ public bool ForceBroken;
        [NMS(Index = 9)]
        /* 0x380 */ public bool ForceFixed;
        [NMS(Index = 12)]
        /* 0x381 */ public bool ForceOverridesAll;
        [NMS(Index = 11)]
        /* 0x382 */ public bool ForceReplaceStoryPortalSeed;
        [NMS(Index = 45)]
        /* 0x383 */ public bool ForceResetPortal;
        [NMS(Index = 44)]
        /* 0x384 */ public bool ForceRestartInteraction;
        [NMS(Index = 36)]
        /* 0x385 */ public bool ForceWideRandom;
        [NMS(Index = 14)]
        /* 0x386 */ public bool IsCommunityPortalOverride;
        [NMS(Index = 37)]
        /* 0x387 */ public bool MustFindSystem;
        [NMS(Index = 19)]
        /* 0x388 */ public bool NeverShow;
        [NMS(Index = 4)]
        /* 0x389 */ public bool NPCReactsToPlayer;
        [NMS(Index = 31)]
        /* 0x38A */ public bool ReplaceEventIfAlreadyActive;
        [NMS(Index = 63)]
        /* 0x38B */ public bool ShowEndTooltip;
        [NMS(Index = 20)]
        /* 0x38C */ public bool ShowOnlyIfSequenceTarget;
        [NMS(Index = 39)]
        /* 0x38D */ public bool TargetMustMatchMissionSeed;
        [NMS(Index = 62)]
        /* 0x38E */ public bool TooltipRepeats;
        [NMS(Index = 40)]
        /* 0x38F */ public bool UseBuildingFromRendezvousStage;
        [NMS(Index = 17)]
        /* 0x390 */ public bool UseMissionTradingDataOverride;
        [NMS(Index = 2)]
        /* 0x391 */ public bool UseSeasonDataAsInteraction;
    }
}
