using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAA527F8B566C4370, NameHash = 0x7FD50C85)]
    public class GcGenericMissionSequence : NMSTemplate
    {
        [NMS(Index = 24)]
        /* 0x000 */ public Colour MissionColourOverride;
        [NMS(Index = 40)]
        /* 0x010 */ public GcTradeData TradingDataOverride;
        [NMS(Index = 32)]
        /* 0x0F8 */ public GcMissionBoardOptions MissionBoardOptions;
        [NMS(Index = 7)]
        /* 0x178 */ public GcSeasonalLogOverrides SeasonalLogTextOverrides;
        [NMS(Index = 27)]
        /* 0x1E8 */ public GcDefaultMissionItemsTable DefaultItems;
        [NMS(Index = 21)]
        /* 0x238 */ public NMSString0x20A MissionPageLocID;
        [NMS(Index = 6)]
        /* 0x258 */ public GcNumberedTextList MissionDescriptions;
        [NMS(Index = 15)]
        /* 0x270 */ public TkTextureResource MissionIcon;
        [NMS(Index = 17)]
        /* 0x288 */ public TkTextureResource MissionIconNotSelected;
        [NMS(Index = 16)]
        /* 0x2A0 */ public TkTextureResource MissionIconSelected;
        [NMS(Index = 10)]
        /* 0x2B8 */ public GcNumberedTextList MissionProcDescriptionA;
        [NMS(Index = 11)]
        /* 0x2D0 */ public GcNumberedTextList MissionProcDescriptionB;
        [NMS(Index = 12)]
        /* 0x2E8 */ public GcNumberedTextList MissionProcDescriptionC;
        [NMS(Index = 9)]
        /* 0x300 */ public GcNumberedTextList MissionProcDescriptionHeader;
        [NMS(Index = 5)]
        /* 0x318 */ public GcNumberedTextList MissionSubtitles;
        [NMS(Index = 4)]
        /* 0x330 */ public GcNumberedTextList MissionTitles;
        [NMS(Index = 45)]
        /* 0x348 */ public List<NMSTemplate> CancelingConditions;
        [NMS(Index = 39)]
        /* 0x358 */ public List<GcCostTableEntry> Costs;
        [NMS(Index = 36)]
        /* 0x368 */ public GcAlienPuzzleTable Dialog;
        [NMS(Index = 46)]
        /* 0x378 */ public List<GcGenericMissionVersionProgress> FinalStageVersions;
        [NMS(Index = 22)]
        /* 0x388 */ public NMSString0x10 MissionBuildMenuHint;
        [NMS(Index = 0)]
        /* 0x398 */ public NMSString0x10 MissionID;
        [NMS(Index = 29)]
        /* 0x3A8 */ public NMSString0x10 NextMissionHint;
        [NMS(Index = 38)]
        /* 0x3B8 */ public List<GcGenericRewardTableEntry> Rewards;
        [NMS(Index = 37)]
        /* 0x3C8 */ public List<GcScanEventData> ScanEvents;
        [NMS(Index = 47)]
        /* 0x3D8 */ public List<GcGenericMissionStage> Stages;
        [NMS(Index = 44)]
        /* 0x3E8 */ public List<NMSTemplate> StartingConditions;
        [NMS(Index = 55)]
        /* 0x3F8 */ public NMSString0x10 UseCommunityMissionForLog;
        [NMS(Index = 26)]
        /* 0x408 */ public List<int> WikiMissionBlockedBySeasons;
        // size: 0x4
        public enum AutoStartEnum : uint {
            None,
            AllModes,
            Seasonal,
            OnSelected,
        }
        [NMS(Index = 33)]
        /* 0x418 */ public AutoStartEnum AutoStart;
        [NMS(Index = 25)]
        /* 0x41C */ public int BeginCheckFrequency;
        [NMS(Index = 42)]
        /* 0x420 */ public GcMissionConditionTest CancelConditionTest;
        // size: 0x3
        public enum MessageCompleteEnum : uint {
            Default,
            Always,
            Never,
        }
        [NMS(Index = 30)]
        /* 0x424 */ public MessageCompleteEnum MessageComplete;
        // size: 0x3
        public enum MessageStartEnum : uint {
            Default,
            Always,
            Never,
        }
        [NMS(Index = 31)]
        /* 0x428 */ public MessageStartEnum MessageStart;
        [NMS(Index = 19)]
        /* 0x42C */ public GcMissionCategory MissionCategory;
        // size: 0xA
        public enum MissionClassEnum : uint {
            Primary,
            Secondary,
            ChainedSecondary,
            Guide,
            Wiki,
            Seasonal,
            Milestone,
            Atlas,
            BlackHole,
            FleetSupport,
        }
        [NMS(Index = 1)]
        /* 0x430 */ public MissionClassEnum MissionClass;
        [NMS(Index = 20)]
        /* 0x434 */ public GcMissionPageHint MissionPageHint;
        [NMS(Index = 18)]
        /* 0x438 */ public int MissionPriority;
        [NMS(Index = 41)]
        /* 0x43C */ public GcMissionConditionTest StartConditionTest;
        [NMS(Index = 8)]
        /* 0x440 */ public NMSString0x20 MissionDescSwitchOverride;
        [NMS(Index = 3)]
        /* 0x460 */ public NMSString0x20 MissionObjective;
        [NMS(Index = 53)]
        /* 0x480 */ public bool BlocksPinning;
        [NMS(Index = 35)]
        /* 0x481 */ public bool CancelSetsComplete;
        [NMS(Index = 54)]
        /* 0x482 */ public bool CanRenounce;
        [NMS(Index = 49)]
        /* 0x483 */ public bool ForcesBuildMenuHint;
        [NMS(Index = 48)]
        /* 0x484 */ public bool ForcesPageHint;
        [NMS(Index = 52)]
        /* 0x485 */ public bool IsLegacy;
        [NMS(Index = 50)]
        /* 0x486 */ public bool IsProceduralAllowed;
        [NMS(Index = 51)]
        /* 0x487 */ public bool IsRecurring;
        [NMS(Index = 23)]
        /* 0x488 */ public bool MissionHasColourOverride;
        [NMS(Index = 2)]
        /* 0x489 */ public bool MissionIsCritical;
        [NMS(Index = 28)]
        /* 0x48A */ public bool PrefixTitle;
        [NMS(Index = 34)]
        /* 0x48B */ public bool RestartOnCompletion;
        [NMS(Index = 43)]
        /* 0x48C */ public bool StartIsCancel;
        [NMS(Index = 56)]
        /* 0x48D */ public bool TakeCommunityMissionIDFromSeasonData;
        [NMS(Index = 57)]
        /* 0x48E */ public bool TelemetryUpload;
        [NMS(Index = 14)]
        /* 0x48F */ public bool UseFirstPurpleSystemDetailsInLogInfo;
        [NMS(Index = 13)]
        /* 0x490 */ public bool UseScanEventDetailsInLogInfo;
        [NMS(Index = 58)]
        /* 0x491 */ public bool UseSeasonTitleOverride;
    }
}
