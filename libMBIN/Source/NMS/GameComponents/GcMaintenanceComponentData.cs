using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2C2A5F77A8E60819, NameHash = 0xDEC89720)]
    public class GcMaintenanceComponentData : NMSTemplate
    {
        [NMS(Index = 23)]
        /* 0x000 */ public TkModelRendererData ModelRenderData;
        [NMS(Index = 24)]
        /* 0x0B0 */ public TkModelRendererData ModelRenderDataAlt;
        [NMS(Index = 54)]
        /* 0x160 */ public GcMaintenanceGroupInstallData GroupInstallSetup;
        [NMS(Index = 30)]
        /* 0x1F0 */ public NMSString0x20A ActionButtonOverride;
        [NMS(Index = 31)]
        /* 0x210 */ public NMSString0x20A ActionDescriptionOverride;
        [NMS(Index = 38)]
        /* 0x230 */ public NMSString0x20A ActionWarningOverride;
        [NMS(Index = 36)]
        /* 0x250 */ public NMSString0x20A ChargeButtonOverride;
        [NMS(Index = 37)]
        /* 0x270 */ public NMSString0x20A ChargeDescriptionOverride;
        [NMS(Index = 29)]
        /* 0x290 */ public NMSString0x20A Description;
        [NMS(Index = 34)]
        /* 0x2B0 */ public NMSString0x20A DiscardButtonOverride;
        [NMS(Index = 35)]
        /* 0x2D0 */ public NMSString0x20A DiscardDescriptionOverride;
        [NMS(Index = 28)]
        /* 0x2F0 */ public NMSString0x20A Title;
        [NMS(Index = 32)]
        /* 0x310 */ public NMSString0x20A TransferButtonOverride;
        [NMS(Index = 33)]
        /* 0x330 */ public NMSString0x20A TransferDescriptionOverride;
        [NMS(Index = 50)]
        /* 0x350 */ public List<NMSString0x10> ForceDamageDuringMissions;
        [NMS(Index = 49)]
        /* 0x360 */ public NMSString0x10 GiveRewardOnCompletion;
        [NMS(Index = 0)]
        /* 0x370 */ public List<GcMaintenanceElement> PreInstalledTech;
        [NMS(Index = 48)]
        /* 0x380 */ public NMSString0x10 StartMissionOnCompletion;
        [NMS(Index = 47)]
        /* 0x390 */ public NMSString0x10 StartMissionOnUse;
        [NMS(Index = 26)]
        /* 0x3A0 */ public GcInteractionDof DepthOfField;
        [NMS(Index = 15)]
        /* 0x3B4 */ public Vector2f CustomIconCentre;
        [NMS(Index = 53)]
        /* 0x3BC */ public GcAudioWwiseEvents AudioIDOnSuccess;
        [NMS(Index = 27)]
        /* 0x3C0 */ public GcBroadcastLevel BroadcastLevel;
        [NMS(Index = 20)]
        /* 0x3C4 */ public float CompletedTransitionDelay;
        // size: 0x4
        public enum InteractableEnum : uint {
            OnlyWhenComplete,
            OnlyWhenNotComplete,
            Always,
            Never,
        }
        [NMS(Index = 18)]
        /* 0x3C8 */ public InteractableEnum Interactable;
        [NMS(Index = 43)]
        /* 0x3CC */ public float InWorldUIForcedOffset;
        [NMS(Index = 44)]
        /* 0x3D0 */ public float InWorldUIForcedOffsetV2;
        [NMS(Index = 41)]
        /* 0x3D4 */ public float InWorldUIMinDistOverride;
        [NMS(Index = 42)]
        /* 0x3D8 */ public float InWorldUIMinDistOverrideV2;
        [NMS(Index = 40)]
        /* 0x3DC */ public float InWorldUIScaler;
        // size: 0x2
        public enum ModelRendererResourceEnum : uint {
            ModelNode,
            MasterModelNode,
        }
        [NMS(Index = 25)]
        /* 0x3E0 */ public ModelRendererResourceEnum ModelRendererResource;
        [NMS(Index = 1)]
        /* 0x3E4 */ public int VisibleMaintenanceSlots;
        [NMS(Index = 3)]
        /* 0x3E8 */ public bool AllowCharge;
        [NMS(Index = 7)]
        /* 0x3E9 */ public bool AllowCraftProduct;
        [NMS(Index = 5)]
        /* 0x3EA */ public bool AllowDiscard;
        [NMS(Index = 4)]
        /* 0x3EB */ public bool AllowDismantle;
        [NMS(Index = 6)]
        /* 0x3EC */ public bool AllowInstallTech;
        [NMS(Index = 9)]
        /* 0x3ED */ public bool AllowMoveAndStack;
        [NMS(Index = 11)]
        /* 0x3EE */ public bool AllowPinning;
        [NMS(Index = 2)]
        /* 0x3EF */ public bool AllowRepair;
        [NMS(Index = 8)]
        /* 0x3F0 */ public bool AllowTransfer;
        [NMS(Index = 10)]
        /* 0x3F1 */ public bool AllowTransferIn;
        [NMS(Index = 12)]
        /* 0x3F2 */ public bool AutoCompleteOnStart;
        [NMS(Index = 56)]
        /* 0x3F3 */ public bool CanUseOutsideOfBase;
        [NMS(Index = 55)]
        /* 0x3F4 */ public bool DisableSynchronise;
        [NMS(Index = 19)]
        /* 0x3F5 */ public bool ForceNoninteraction;
        [NMS(Index = 52)]
        /* 0x3F6 */ public bool ForceOneClickRepair;
        [NMS(Index = 16)]
        /* 0x3F7 */ public bool ForceRemoveUIRenderLayer;
        [NMS(Index = 17)]
        /* 0x3F8 */ public bool HideMaxAmountOnProductSlots;
        [NMS(Index = 46)]
        /* 0x3F9 */ public bool InteractionRequiresPower;
        [NMS(Index = 45)]
        /* 0x3FA */ public bool InWorldUIUseCameraUp;
        [NMS(Index = 51)]
        /* 0x3FB */ public bool OpenInteractionOnQuit;
        [NMS(Index = 21)]
        /* 0x3FC */ public bool ShareInteractionModelRender;
        [NMS(Index = 39)]
        /* 0x3FD */ public bool SilenceSuitVOIAlerts;
        [NMS(Index = 14)]
        /* 0x3FE */ public bool UseBoundsForIconCentre;
        [NMS(Index = 22)]
        /* 0x3FF */ public bool UseInteractionStyleCameraEvent;
        [NMS(Index = 13)]
        /* 0x400 */ public bool UseModelResourceRenderer;
        [NMS(Index = 57)]
        /* 0x401 */ public bool UseNetworkLock;
    }
}
