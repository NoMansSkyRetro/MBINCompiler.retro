using System;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x30751F332C0AB1AC, NameHash = 0xD42BEC5C)]
    public class TkGlobals : NMSTemplate
    {
        // size: 0x4
        public enum AssertsLevelEnum : uint {
            Disabled,
            Ignored,
            Skipped,
            Enabled,
        }
        [NMS(Index = 0)]
        /* 0x000 */ public AssertsLevelEnum AssertsLevel;
        // size: 0x9
        [Flags]
        public enum EnabledChannelsEnum : uint {
            None = 0x0,
            Default = 0x1,
            Note = 0x2,
            Error = 0x4,
            Warning = 0x8,
            Info = 0x10,
            Alt = 0x20,
            AltWarn = 0x40,
            AltError = 0x80,
        }
        [NMS(Index = 2)]
        /* 0x004 */ public EnabledChannelsEnum EnabledChannels;
        // size: 0xD
        public enum ForceGPUPresetToEnum : uint {
            PC_Low,
            PC_Medium,
            PC_High,
            PC_Ultra,
            PS4,
            PS4VR,
            PS4Pro,
            PS4ProVR,
            XB1,
            XB1X,
            Oberon,
            MacOS,
            iOS,
        }
        [NMS(Index = 27)]
        /* 0x008 */ public ForceGPUPresetToEnum ForceGPUPresetTo;
        [NMS(Index = 79)]
        /* 0x00C */ public int FrameFlipRateDefault;
        [NMS(Index = 81)]
        /* 0x010 */ public int FrameFlipRateGame;
        [NMS(Index = 80)]
        /* 0x014 */ public int FrameFlipRateLoad;
        // size: 0x5
        public enum GameWindowModeEnum : uint {
            Bordered,
            Borderless,
            Fullscreen,
            Maximised,
            Minimised,
        }
        [NMS(Index = 43)]
        /* 0x018 */ public GameWindowModeEnum GameWindowMode;
        [NMS(Index = 24)]
        /* 0x01C */ public int HighlightPlacementIndex;
        [NMS(Index = 75)]
        /* 0x020 */ public int HmdEyeBufferHeight;
        [NMS(Index = 74)]
        /* 0x024 */ public int HmdEyeBufferWidth;
        [NMS(Index = 76)]
        /* 0x028 */ public float HmdEyeScalePos;
        [NMS(Index = 77)]
        /* 0x02C */ public float HmdHeadScalePos;
        [NMS(Index = 78)]
        /* 0x030 */ public float HmdImmersionFactor;
        [NMS(Index = 73)]
        /* 0x034 */ public int HmdMonitor;
        [NMS(Index = 69)]
        /* 0x038 */ public int HmdPreviewScale;
        [NMS(Index = 5)]
        /* 0x03C */ public int LoadBalanceTimeoutMS;
        [NMS(Index = 21)]
        /* 0x040 */ public int LODOverride;
        [NMS(Index = 82)]
        /* 0x044 */ public float MaxFrameRate;
        [NMS(Index = 44)]
        /* 0x048 */ public int Monitor;
        [NMS(Index = 59)]
        /* 0x04C */ public int OctahedralImpostersViewCount;
        [NMS(Index = 7)]
        /* 0x050 */ public int PSVR2LoadBalanceTimeoutMS;
        [NMS(Index = 88)]
        /* 0x054 */ public float ScratchpadInstanceScale;
        [NMS(Index = 90)]
        /* 0x058 */ public int ScratchpadInstancesCap;
        [NMS(Index = 87)]
        /* 0x05C */ public float ScratchpadInstanceSpacing;
        [NMS(Index = 89)]
        /* 0x060 */ public int ScratchpadInstancesPerSide;
        [NMS(Index = 91)]
        /* 0x064 */ public float ScratchpadInstancesRandomness;
        [NMS(Index = 84)]
        /* 0x068 */ public int ScratchpadModelSeed;
        [NMS(Index = 41)]
        /* 0x06C */ public int ScreenHeight;
        [NMS(Index = 40)]
        /* 0x070 */ public int ScreenWidth;
        [NMS(Index = 46)]
        /* 0x074 */ public int TiledWindowsIndex;
        [NMS(Index = 45)]
        /* 0x078 */ public int TiledWindowsSplitCount;
        [NMS(Index = 9)]
        /* 0x07C */ public float TitlebarMenuOffset;
        [NMS(Index = 17)]
        /* 0x080 */ public float TouchScreenSwipeTime;
        [NMS(Index = 16)]
        /* 0x084 */ public float TouchScreenSwipeTravelThreshold;
        // size: 0x3
        public enum TrialStatusEnum : uint {
            SystemDefault,
            ForceTrial,
            ForceFullGame,
        }
        [NMS(Index = 66)]
        /* 0x088 */ public TrialStatusEnum TrialStatus;
        [NMS(Index = 62)]
        /* 0x08C */ public float UpdatePeriod;
        [NMS(Index = 63)]
        /* 0x090 */ public float UpdatePeriodSteam;
        [NMS(Index = 64)]
        /* 0x094 */ public float VoiceUpdatePeriod;
        [NMS(Index = 65)]
        /* 0x098 */ public float VoiceUpdatePeriodSteam;
        [NMS(Index = 6)]
        /* 0x09C */ public int VRLoadBalanceTimeoutMS;
        [NMS(Index = 37)]
        /* 0x0A0 */ public int WindowPositionX;
        [NMS(Index = 38)]
        /* 0x0A4 */ public int WindowPositionY;
        [NMS(Index = 31)]
        /* 0x0A8 */ public float WwiseVibrationMultiplierPrimary;
        [NMS(Index = 32)]
        /* 0x0AC */ public float WwiseVibrationMultiplierSecondary;
        [NMS(Index = 49)]
        /* 0x0B0 */ public NMSString0x100 EditorLayout;
        [NMS(Index = 4)]
        /* 0x1B0 */ public NMSString0x100 ExcludeLogFilter;
        [NMS(Index = 3)]
        /* 0x2B0 */ public NMSString0x100 IncludeLogFilter;
        [NMS(Index = 83)]
        /* 0x3B0 */ public NMSString0x100 ScratchpadModel;
        [NMS(Index = 8)]
        /* 0x4B0 */ public bool AllowInPlaceNGuiElementRenaming;
        [NMS(Index = 11)]
        /* 0x4B1 */ public bool AutoTabNewlyOpenedWindows;
        [NMS(Index = 22)]
        /* 0x4B2 */ public bool ColourLODs;
        [NMS(Index = 23)]
        /* 0x4B3 */ public bool ColourVertexDensity;
        [NMS(Index = 60)]
        /* 0x4B4 */ public bool CompressImposterTextures;
        [NMS(Index = 30)]
        /* 0x4B5 */ public bool CrashOnFailedCriticalAssertion;
        [NMS(Index = 1)]
        /* 0x4B6 */ public bool DefaultSelectIgnoreAsserts;
        [NMS(Index = 35)]
        /* 0x4B7 */ public bool DisableMultiplayer;
        [NMS(Index = 20)]
        /* 0x4B8 */ public bool DisableResScaling;
        [NMS(Index = 18)]
        /* 0x4B9 */ public bool DisableSwitchingAwayFromPad;
        [NMS(Index = 61)]
        /* 0x4BA */ public bool DisableUndergrowthInstanceRendering;
        [NMS(Index = 42)]
        /* 0x4BB */ public bool DisableVSync;
        [NMS(Index = 54)]
        /* 0x4BC */ public bool EnableGpuBreadcrumbs;
        [NMS(Index = 55)]
        /* 0x4BD */ public bool EnableInstancedModelImposters;
        [NMS(Index = 53)]
        /* 0x4BE */ public bool EnableNvidiaAftermath;
        [NMS(Index = 51)]
        /* 0x4BF */ public bool EnableRenderdoc;
        [NMS(Index = 19)]
        /* 0x4C0 */ public bool EnableShaderReload;
        [NMS(Index = 15)]
        /* 0x4C1 */ public bool EnableVirtualTouchScreen;
        [NMS(Index = 12)]
        /* 0x4C2 */ public bool FavouritesAndUndoEnabledByDefault;
        [NMS(Index = 10)]
        /* 0x4C3 */ public bool FilterTranslatedTextWhenSearching;
        [NMS(Index = 26)]
        /* 0x4C4 */ public bool ForceGPUPreset;
        [NMS(Index = 29)]
        /* 0x4C5 */ public bool FreezeCulling;
        [NMS(Index = 52)]
        /* 0x4C6 */ public bool HideRenderdocOverlay;
        [NMS(Index = 72)]
        /* 0x4C7 */ public bool HmdDistortionPassthru;
        [NMS(Index = 67)]
        /* 0x4C8 */ public bool HmdEnable;
        [NMS(Index = 68)]
        /* 0x4C9 */ public bool HmdFoveated;
        [NMS(Index = 71)]
        /* 0x4CA */ public bool HmdStereoRender;
        [NMS(Index = 70)]
        /* 0x4CB */ public bool HmdTracking;
        [NMS(Index = 50)]
        /* 0x4CC */ public bool LoadRelativeEditorLayouts;
        [NMS(Index = 14)]
        /* 0x4CD */ public bool LogInputChanges;
        [NMS(Index = 13)]
        /* 0x4CE */ public bool LogInputSetup;
        [NMS(Index = 28)]
        /* 0x4CF */ public bool MakeUnusedUniformsNaN;
        [NMS(Index = 25)]
        /* 0x4D0 */ public bool MinGPUMode;
        [NMS(Index = 57)]
        /* 0x4D1 */ public bool OctahedralImpostersDisable;
        [NMS(Index = 56)]
        /* 0x4D2 */ public bool OctahedralImpostersEnable;
        [NMS(Index = 58)]
        /* 0x4D3 */ public bool OctahedralImpostersViewFromSpace;
        [NMS(Index = 47)]
        /* 0x4D4 */ public bool SampleCollisionWithCamera;
        [NMS(Index = 85)]
        /* 0x4D5 */ public bool ScratchpadInstanced;
        [NMS(Index = 86)]
        /* 0x4D6 */ public bool ScratchpadWind;
        [NMS(Index = 48)]
        /* 0x4D7 */ public bool ShowPlayerCollisions;
        [NMS(Index = 34)]
        /* 0x4D8 */ public bool SimulateDisabledParticleRefractions;
        [NMS(Index = 36)]
        /* 0x4D9 */ public bool SmokeTestSmokeBotAutoStart;
        [NMS(Index = 39)]
        /* 0x4DA */ public bool UseDebugScreenSettings;
        [NMS(Index = 33)]
        /* 0x4DB */ public bool UseHeavyAir;
    }
}
