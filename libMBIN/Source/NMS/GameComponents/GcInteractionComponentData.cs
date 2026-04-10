using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x68BD4E8C3059FF3E, NameHash = 0xBE246A5)]
    public class GcInteractionComponentData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x000 */ public TkModelRendererData Renderer;
        [NMS(Index = 4)]
        /* 0x0C0 */ public TkModelRendererData RendererAlt;
        [NMS(Index = 12)]
        /* 0x180 */ public GcInteractionActivationCost ActivationCost;
        [NMS(Index = 22)]
        /* 0x1E8 */ public GcInteractionActivationCost SecondaryActivationCost;
        [NMS(Index = 30)]
        /* 0x250 */ public GcStoryUtilityOverride StoryUtilityOverrideData;
        [NMS(Index = 29)]
        /* 0x290 */ public List<GcAdditionalOptionMissionOverride> AdditionalOptionsOverrideTable;
        [NMS(Index = 23)]
        /* 0x2A0 */ public List<TkModelRendererData> EventRenderers;
        [NMS(Index = 24)]
        /* 0x2B0 */ public List<TkModelRendererData> EventRenderersAlt;
        [NMS(Index = 25)]
        /* 0x2C0 */ public List<GcInteractionDof> EventRenderersDoF;
        [NMS(Index = 44)]
        /* 0x2D0 */ public NMSTemplate InteractionSpecificData;
        [NMS(Index = 28)]
        /* 0x2E0 */ public List<GcAlienPuzzleMissionOverride> PuzzleMissionOverrideTable;
        [NMS(Index = 40)]
        /* 0x2F0 */ public NMSString0x10 StartMissionOnUse;
        [NMS(Index = 13)]
        /* 0x300 */ public NMSString0x10 TriggerAction;
        [NMS(Index = 14)]
        /* 0x310 */ public NMSString0x10 TriggerActionOnPrepare;
        [NMS(Index = 27)]
        /* 0x320 */ public GcInteractionDof DepthOfField;
        [NMS(Index = 6)]
        /* 0x334 */ public float AttractDistanceSq;
        [NMS(Index = 11)]
        /* 0x338 */ public float BlendFromCameraTime;
        [NMS(Index = 10)]
        /* 0x33C */ public float BlendToCameraTime;
        [NMS(Index = 18)]
        /* 0x340 */ public float InteractAngle;
        [NMS(Index = 19)]
        /* 0x344 */ public float InteractDistance;
        // size: 0x3
        public enum InteractionActionEnum : uint {
            PressButton,
            HoldButton,
            Shoot,
        }
        [NMS(Index = 0)]
        /* 0x348 */ public InteractionActionEnum InteractionAction;
        [NMS(Index = 1)]
        /* 0x34C */ public GcInteractionType InteractionType;
        [NMS(Index = 17)]
        /* 0x350 */ public float InteractMaxHeightDiff;
        [NMS(Index = 37)]
        /* 0x354 */ public float InWorldUIForcedOffset;
        [NMS(Index = 38)]
        /* 0x358 */ public float InWorldUIForcedOffsetV2;
        [NMS(Index = 35)]
        /* 0x35C */ public float InWorldUIMinDistOverride;
        [NMS(Index = 36)]
        /* 0x360 */ public float InWorldUIMinDistOverrideV2;
        [NMS(Index = 34)]
        /* 0x364 */ public float InWorldUIScaler;
        [NMS(Index = 5)]
        /* 0x368 */ public GcAlienRace Race;
        [NMS(Index = 16)]
        /* 0x36C */ public float RangeToAllowAtAnyAngle;
        [NMS(Index = 26)]
        /* 0x370 */ public float SecondaryCameraTransitionTime;
        [NMS(Index = 21)]
        /* 0x374 */ public GcInteractionType SecondaryInteractionType;
        [NMS(Index = 41)]
        /* 0x378 */ public bool AllowMissionUnderwater;
        [NMS(Index = 15)]
        /* 0x379 */ public bool BroadcastTriggerAction;
        [NMS(Index = 20)]
        /* 0x37A */ public bool InteractInvertFace;
        [NMS(Index = 39)]
        /* 0x37B */ public bool InWorldUIUseCameraUp;
        [NMS(Index = 42)]
        /* 0x37C */ public bool OnlyAvailableInAbandonedMode;
        // size: 0x3
        public enum OverrideInteriorExteriorMarkerEnum : byte {
            No,
            Interior,
            Exterior,
        }
        [NMS(Index = 31)]
        /* 0x37D */ public OverrideInteriorExteriorMarkerEnum OverrideInteriorExteriorMarker;
        [NMS(Index = 8)]
        /* 0x37E */ public bool RepeatInteraction;
        [NMS(Index = 32)]
        /* 0x37F */ public bool ReseedAfterRewardSuccess;
        [NMS(Index = 7)]
        /* 0x380 */ public bool SecondaryMeshAlwaysVisible;
        [NMS(Index = 9)]
        /* 0x381 */ public bool UseInteractCamera;
        [NMS(Index = 2)]
        /* 0x382 */ public bool UseIntermediateUI;
        [NMS(Index = 33)]
        /* 0x383 */ public bool UsePersonalPersistentBuffer;
        [NMS(Index = 43)]
        /* 0x384 */ public bool UseUnlockedInteractionIfMaintDone;
    }
}
