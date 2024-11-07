using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x39A6BCD8031E88A0, NameHash = 0xD1FA1B1C)]
    public class GcUIGlobals : NMSTemplate
    {
        [NMS(Index = 1069)]
        /* 0x0000 */ public GcModelViewCollection ModelViews;
        [NMS(Index = 287)]
        /* 0x1EF0 */ public TkModelRendererData LargeMultitoolThumbnailModelView;
        [NMS(Index = 286)]
        /* 0x1FA0 */ public TkModelRendererData MultitoolThumbnailModelView;
        [NMS(Index = 285)]
        /* 0x2050 */ public TkModelRendererData PetThumbnailModelView;
        [NMS(Index = 458)]
        /* 0x2100 */ public TkModelRendererData RepairBackpackCamera;
        [NMS(Index = 456)]
        /* 0x21B0 */ public TkModelRendererData RepairCamera;
        [NMS(Index = 459)]
        /* 0x2260 */ public TkModelRendererData RepairShipCameraInWorld;
        [NMS(Index = 460)]
        /* 0x2310 */ public TkModelRendererData RepairShipCameraModelView;
        [NMS(Index = 461)]
        /* 0x23C0 */ public TkModelRendererData RepairShipCameraVR;
        [NMS(Index = 457)]
        /* 0x2470 */ public TkModelRendererData RepairWeaponCamera;
        [NMS(Index = 284)]
        /* 0x2520 */ public TkModelRendererData ShipThumbnailModelView;
        [NMS(Index = 1400)]
        /* 0x25D0 */ public TkNGuiTreeViewTemplate FileBrowserTreeViewTemplate;
        [NMS(Index = 1399)]
        /* 0x2650 */ public TkNGuiTreeViewTemplate SceneInfoTreeViewTemplate;
        [NMS(Index = 1401)]
        /* 0x26D0 */ public TkNGuiTreeViewTemplate SkeletonToolsTreeViewTemplate;
        [NMS(Index = 563)]
        /* 0x2750 */ public GcScanEffectData DebugEditorPreviewEffect;
        [NMS(Index = 649)]
        /* 0x27A0 */ public GcScanEffectData FreighterSummonScanEffect;
        [NMS(Index = 326)]
        /* 0x27F0 */ public GcHUDEffectRewardData OSDEpicItemRewardEffect;
        [NMS(Index = 325)]
        /* 0x2840 */ public GcHUDEffectRewardData OSDRareItemRewardEffect;
        [NMS(Index = 860, Size = 0x5, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x2890 */ public Colour[] SystemHooverLEDColours;
        [NMS(Index = 861, Size = 0x5, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x28E0 */ public Colour[] SystemHooverStatusBarColours;
        [NMS(Index = 550)]
        /* 0x2930 */ public GcScanEffectData TargetDisplayScanEffect;
        [NMS(Index = 1258)]
        /* 0x2980 */ public GcSpaceMapObjectData SpaceMapAtlasData;
        [NMS(Index = 1259)]
        /* 0x29B0 */ public GcSpaceMapObjectData SpaceMapBlackHoleData;
        [NMS(Index = 1261)]
        /* 0x29E0 */ public GcSpaceMapObjectData SpaceMapFreighterData;
        [NMS(Index = 1254)]
        /* 0x2A10 */ public GcSpaceMapObjectData SpaceMapMarkerData;
        [NMS(Index = 1257)]
        /* 0x2A40 */ public GcSpaceMapObjectData SpaceMapNexusData;
        [NMS(Index = 1255)]
        /* 0x2A70 */ public GcSpaceMapObjectData SpaceMapPlanetData;
        [NMS(Index = 1262)]
        /* 0x2AA0 */ public GcSpaceMapObjectData SpaceMapPulseEncounterData;
        [NMS(Index = 1260)]
        /* 0x2AD0 */ public GcSpaceMapObjectData SpaceMapShipData;
        [NMS(Index = 1256)]
        /* 0x2B00 */ public GcSpaceMapObjectData SpaceMapStationData;
        [NMS(Index = 1332)]
        /* 0x2B30 */ public Colour AltimeterBandColour1;
        [NMS(Index = 1333)]
        /* 0x2B40 */ public Colour AltimeterBandColour2;
        [NMS(Index = 1334)]
        /* 0x2B50 */ public Colour AltimeterColour1;
        [NMS(Index = 1335)]
        /* 0x2B60 */ public Colour AltimeterColour2;
        [NMS(Index = 388)]
        /* 0x2B70 */ public Colour BaseComplexityDangerColour;
        [NMS(Index = 386)]
        /* 0x2B80 */ public Colour BaseComplexityDefaultColour;
        [NMS(Index = 387)]
        /* 0x2B90 */ public Colour BaseComplexityWarningColour;
        [NMS(Index = 168)]
        /* 0x2BA0 */ public Vector3f BinocularPanelLinePointOffset;
        [NMS(Index = 396)]
        /* 0x2BB0 */ public Colour BuildMenuErrorTextColour;
        [NMS(Index = 398)]
        /* 0x2BC0 */ public Colour BuildMenuErrorTextFlashColour;
        [NMS(Index = 397)]
        /* 0x2BD0 */ public Colour BuildMenuErrorTextOutlineColour;
        [NMS(Index = 399)]
        /* 0x2BE0 */ public Colour BuildMenuErrorTextOutlineFlashColour;
        [NMS(Index = 400)]
        /* 0x2BF0 */ public Colour BuildMenuInfoTextColour;
        [NMS(Index = 401)]
        /* 0x2C00 */ public Colour BuildMenuInfoTextOutlineColour;
        [NMS(Index = 394)]
        /* 0x2C10 */ public Colour BuildMenuPassiveErrorTextColour;
        [NMS(Index = 395)]
        /* 0x2C20 */ public Colour BuildMenuPassiveErrorTextOutlineColour;
        [NMS(Index = 1116)]
        /* 0x2C30 */ public Colour ByteBeatArpGridActiveColour;
        [NMS(Index = 1115)]
        /* 0x2C40 */ public Colour ByteBeatArpGridInactiveColour;
        [NMS(Index = 1118)]
        /* 0x2C50 */ public Colour ByteBeatArpPipActiveColour;
        [NMS(Index = 1117)]
        /* 0x2C60 */ public Colour ByteBeatArpPipInactiveColour;
        [NMS(Index = 1134)]
        /* 0x2C70 */ public Colour ByteBeatRhythmColour0Active;
        [NMS(Index = 1135)]
        /* 0x2C80 */ public Colour ByteBeatRhythmColour0Inactive;
        [NMS(Index = 1136)]
        /* 0x2C90 */ public Colour ByteBeatRhythmColour1Active;
        [NMS(Index = 1137)]
        /* 0x2CA0 */ public Colour ByteBeatRhythmColour1Inactive;
        [NMS(Index = 1138)]
        /* 0x2CB0 */ public Colour ByteBeatRhythmColour2Active;
        [NMS(Index = 1139)]
        /* 0x2CC0 */ public Colour ByteBeatRhythmColour2Inactive;
        [NMS(Index = 1130)]
        /* 0x2CD0 */ public Colour ByteBeatSequencerBGColourActive;
        [NMS(Index = 1131)]
        /* 0x2CE0 */ public Colour ByteBeatSequencerBGColourInactive;
        [NMS(Index = 1140)]
        /* 0x2CF0 */ public Colour ByteBeatSequencerHighlightColour;
        [NMS(Index = 1132)]
        /* 0x2D00 */ public Colour ByteBeatSequencerRimColourActive;
        [NMS(Index = 1133)]
        /* 0x2D10 */ public Colour ByteBeatSequencerRimColourInactive;
        [NMS(Index = 1129)]
        /* 0x2D20 */ public Colour ByteBeatSequencerUnpoweredTint;
        [NMS(Index = 1145)]
        /* 0x2D30 */ public Colour ByteBeatSliderFGColour;
        [NMS(Index = 1146)]
        /* 0x2D40 */ public Colour ByteBeatSliderTextActiveColour;
        [NMS(Index = 1147)]
        /* 0x2D50 */ public Colour ByteBeatSliderTextInactiveColour;
        [NMS(Index = 1106)]
        /* 0x2D60 */ public Colour ByteBeatTreeLineColour;
        [NMS(Index = 1109)]
        /* 0x2D70 */ public Colour ByteBeatVisGridColour;
        [NMS(Index = 1108)]
        /* 0x2D80 */ public Colour ByteBeatVisLineColour;
        [NMS(Index = 553)]
        /* 0x2D90 */ public Colour CommunicatorMessageColour;
        [NMS(Index = 706)]
        /* 0x2DA0 */ public Colour CrosshairColour;
        [NMS(Index = 695)]
        /* 0x2DB0 */ public Colour CrosshairLeadPassiveColour;
        [NMS(Index = 694)]
        /* 0x2DC0 */ public Colour CrosshairLeadThreatColour;
        [NMS(Index = 1070)]
        /* 0x2DD0 */ public Colour CursorColour;
        [NMS(Index = 1071)]
        /* 0x2DE0 */ public Colour CursorConfirmColour;
        [NMS(Index = 1073)]
        /* 0x2DF0 */ public Colour CursorDeleteColour;
        [NMS(Index = 1072)]
        /* 0x2E00 */ public Colour CursorTransferUploadColour;
        [NMS(Index = 618)]
        /* 0x2E10 */ public Colour DamageNumberCriticalColour;
        [NMS(Index = 619)]
        /* 0x2E20 */ public Colour DamageNumberIneffectiveColour;
        [NMS(Index = 620)]
        /* 0x2E30 */ public Colour DamageNumberIneffectiveWarningColour;
        [NMS(Index = 930)]
        /* 0x2E40 */ public Colour DeathMessageColour;
        [NMS(Index = 281)]
        /* 0x2E50 */ public Colour DebugEditorAxisColourAtActive;
        [NMS(Index = 280)]
        /* 0x2E60 */ public Colour DebugEditorAxisColourAtInactive;
        [NMS(Index = 279)]
        /* 0x2E70 */ public Colour DebugEditorAxisColourRightActive;
        [NMS(Index = 278)]
        /* 0x2E80 */ public Colour DebugEditorAxisColourRightInactive;
        [NMS(Index = 277)]
        /* 0x2E90 */ public Colour DebugEditorAxisColourUpActive;
        [NMS(Index = 276)]
        /* 0x2EA0 */ public Colour DebugEditorAxisColourUpInactive;
        [NMS(Index = 474)]
        /* 0x2EB0 */ public Vector3f DefaultRefinerOffsetIn;
        [NMS(Index = 475)]
        /* 0x2EC0 */ public Vector3f DefaultRefinerOffsetOut;
        [NMS(Index = 1042)]
        /* 0x2ED0 */ public Colour EnergyBgColour;
        [NMS(Index = 1043)]
        /* 0x2EE0 */ public Colour EnergyBgPulseColour;
        [NMS(Index = 199)]
        /* 0x2EF0 */ public Vector3f FaceLockedScreenOffset;
        [NMS(Index = 650)]
        /* 0x2F00 */ public Colour FreighterSummonScanEffectColourBlocked;
        [NMS(Index = 651)]
        /* 0x2F10 */ public Colour FreighterSummonScanEffectColourHighlight;
        [NMS(Index = 288)]
        /* 0x2F20 */ public Colour FrontendCursorBackgroundColour;
        [NMS(Index = 623)]
        /* 0x2F30 */ public Colour FuelBgColour;
        [NMS(Index = 492)]
        /* 0x2F40 */ public Colour GridBackgroundNegativeColour;
        [NMS(Index = 490)]
        /* 0x2F50 */ public Colour GridBackgroundNeutralColour;
        [NMS(Index = 491)]
        /* 0x2F60 */ public Colour GridBackgroundPositiveColour;
        [NMS(Index = 487)]
        /* 0x2F70 */ public Colour GridDisconnectedColour;
        [NMS(Index = 489)]
        /* 0x2F80 */ public Colour GridOfflineColour;
        [NMS(Index = 488)]
        /* 0x2F90 */ public Colour GridOnlineColour;
        [NMS(Index = 1044)]
        /* 0x2FA0 */ public Colour HazardBgPulseColour;
        [NMS(Index = 1045)]
        /* 0x2FB0 */ public Colour HazardDamagePulseColour;
        [NMS(Index = 291)]
        /* 0x2FC0 */ public Vector3f HmdFramerateScreenOffset;
        [NMS(Index = 1273)]
        /* 0x2FD0 */ public Colour HUDMarkerColour;
        [NMS(Index = 857)]
        /* 0x2FE0 */ public Colour HUDNotifyColour;
        [NMS(Index = 1277)]
        /* 0x2FF0 */ public Colour HUDOutpostColour;
        [NMS(Index = 821)]
        /* 0x3000 */ public Colour HUDPlayerTrackArrowDamageGlowHullHitMaxColour;
        [NMS(Index = 822)]
        /* 0x3010 */ public Colour HUDPlayerTrackArrowDamageGlowHullHitMinColour;
        [NMS(Index = 825)]
        /* 0x3020 */ public Colour HUDPlayerTrackArrowDamageGlowShieldHitMaxColour;
        [NMS(Index = 826)]
        /* 0x3030 */ public Colour HUDPlayerTrackArrowDamageGlowShieldHitMinColour;
        [NMS(Index = 852)]
        /* 0x3040 */ public Colour HUDPlayerTrackArrowDotColour;
        [NMS(Index = 854)]
        /* 0x3050 */ public Colour HUDPlayerTrackArrowDotColourPirate;
        [NMS(Index = 853)]
        /* 0x3060 */ public Colour HUDPlayerTrackArrowDotColourPolice;
        [NMS(Index = 855)]
        /* 0x3070 */ public Colour HUDPlayerTrackArrowDotColourTrader;
        [NMS(Index = 813)]
        /* 0x3080 */ public Colour HUDPlayerTrackArrowEnergyShieldColour;
        [NMS(Index = 834)]
        /* 0x3090 */ public Colour HUDPlayerTrackArrowEnergyShieldDepletedGlowMaxColour;
        [NMS(Index = 835)]
        /* 0x30A0 */ public Colour HUDPlayerTrackArrowEnergyShieldDepletedGlowMinColour;
        [NMS(Index = 814)]
        /* 0x30B0 */ public Colour HUDPlayerTrackArrowEnergyShieldLowColour;
        [NMS(Index = 839)]
        /* 0x30C0 */ public Colour HUDPlayerTrackArrowEnergyShieldStartChargeGlowMaxColour;
        [NMS(Index = 840)]
        /* 0x30D0 */ public Colour HUDPlayerTrackArrowEnergyShieldStartChargeGlowMinColour;
        [NMS(Index = 810)]
        /* 0x30E0 */ public Colour HUDPlayerTrackArrowTextColour;
        [NMS(Index = 1275)]
        /* 0x30F0 */ public Colour HUDRelicMarkerColourDiscovered;
        [NMS(Index = 1276)]
        /* 0x3100 */ public Colour HUDRelicMarkerColourUnknown;
        [NMS(Index = 1274)]
        /* 0x3110 */ public Colour HUDSpaceshipColour;
        [NMS(Index = 856)]
        /* 0x3120 */ public Colour HUDWarningColour;
        [NMS(Index = 407)]
        /* 0x3130 */ public Colour IconGlowColourActive;
        [NMS(Index = 406)]
        /* 0x3140 */ public Colour IconGlowColourError;
        [NMS(Index = 409)]
        /* 0x3150 */ public Colour IconGlowColourHighlight;
        [NMS(Index = 408)]
        /* 0x3160 */ public Colour IconGlowColourNeutral;
        [NMS(Index = 464)]
        /* 0x3170 */ public Colour InteractionLabelCostColour;
        [NMS(Index = 465)]
        /* 0x3180 */ public Colour InteractionLabelPickupColour;
        [NMS(Index = 466)]
        /* 0x3190 */ public Colour InteractionLabelPickupFillColour;
        [NMS(Index = 67)]
        /* 0x31A0 */ public Colour InvSlotGradientBaseColour;
        [NMS(Index = 133)]
        /* 0x31B0 */ public Vector3f InWorldInteractLabelCentreOffset;
        [NMS(Index = 135)]
        /* 0x31C0 */ public Vector3f InWorldInteractLabelLineOffset;
        [NMS(Index = 134)]
        /* 0x31D0 */ public Vector3f InWorldInteractLabelTopOffset;
        [NMS(Index = 192)]
        /* 0x31E0 */ public Vector3f InWorldNGuiScreenRotation;
        [NMS(Index = 136)]
        /* 0x31F0 */ public Vector3f InWorldStaffBinocsScreenOffset;
        [NMS(Index = 964)]
        /* 0x3200 */ public Colour ItemSlotColourPartiallyInstalled;
        [NMS(Index = 966)]
        /* 0x3210 */ public Colour ItemSlotColourProduct;
        [NMS(Index = 960)]
        /* 0x3220 */ public Colour ItemSlotColourSubstance;
        [NMS(Index = 961)]
        /* 0x3230 */ public Colour ItemSlotColourTech;
        [NMS(Index = 962)]
        /* 0x3240 */ public Colour ItemSlotColourTechCharge;
        [NMS(Index = 963)]
        /* 0x3250 */ public Colour ItemSlotColourTechDamage;
        [NMS(Index = 969)]
        /* 0x3260 */ public Colour ItemSlotTextColourProduct;
        [NMS(Index = 967)]
        /* 0x3270 */ public Colour ItemSlotTextColourSubstance;
        [NMS(Index = 968)]
        /* 0x3280 */ public Colour ItemSlotTextColourTech;
        [NMS(Index = 66)]
        /* 0x3290 */ public Colour JoaoBoxCompletedObjectiveColour;
        [NMS(Index = 1338)]
        /* 0x32A0 */ public Colour LockOnMarkerActiveColour;
        [NMS(Index = 188)]
        /* 0x32B0 */ public Vector3f LowerHelmetScreenOffset;
        [NMS(Index = 440)]
        /* 0x32C0 */ public Colour MarkerRingBGColour;
        [NMS(Index = 516)]
        /* 0x32D0 */ public Colour MissionOSDMessageBarColour;
        [NMS(Index = 337)]
        /* 0x32E0 */ public Colour MultiplayerMissionParticipantsColour;
        [NMS(Index = 49)]
        /* 0x32F0 */ public Colour NetworkPopupTextDisabledColour;
        [NMS(Index = 48)]
        /* 0x3300 */ public Colour NetworkPopupTextEnabledColour;
        [NMS(Index = 1356)]
        /* 0x3310 */ public Vector3f NGuiModelTranslationFactors;
        [NMS(Index = 1357)]
        /* 0x3320 */ public Vector3f NGuiModelTranslationFactorsInteraction;
        [NMS(Index = 1358)]
        /* 0x3330 */ public Vector3f NGuiThumbnailModelTranslationFactors;
        [NMS(Index = 518)]
        /* 0x3340 */ public Colour NotificationDangerColour;
        [NMS(Index = 517)]
        /* 0x3350 */ public Colour NotificationDefaultColour;
        [NMS(Index = 519)]
        /* 0x3360 */ public Colour NotificationInfoColour;
        [NMS(Index = 520)]
        /* 0x3370 */ public Colour NotificationUrgentColour;
        [NMS(Index = 621)]
        /* 0x3380 */ public Colour PhotoModeSelectedColour;
        [NMS(Index = 622)]
        /* 0x3390 */ public Colour PhotoModeUnselectedColour;
        [NMS(Index = 336)]
        /* 0x33A0 */ public Colour PickedItemBorderColour;
        [NMS(Index = 931)]
        /* 0x33B0 */ public Colour PinnedRecipeBorder;
        [NMS(Index = 332)]
        /* 0x33C0 */ public Colour ProcProductColourCommon;
        [NMS(Index = 334)]
        /* 0x33D0 */ public Colour ProcProductColourRare;
        [NMS(Index = 333)]
        /* 0x33E0 */ public Colour ProcProductColourUncommon;
        [NMS(Index = 799)]
        /* 0x33F0 */ public Colour PulseAlertColour;
        [NMS(Index = 798)]
        /* 0x3400 */ public Colour PulseDamageColour;
        [NMS(Index = 282)]
        /* 0x3410 */ public Colour QuickMenuSelectedItemColour1;
        [NMS(Index = 283)]
        /* 0x3420 */ public Colour QuickMenuSelectedItemColour2;
        [NMS(Index = 1154)]
        /* 0x3430 */ public Colour RadialMenuInnerColourDisabled;
        [NMS(Index = 1150)]
        /* 0x3440 */ public Colour RadialMenuInnerColourSelected;
        [NMS(Index = 1152)]
        /* 0x3450 */ public Colour RadialMenuInnerColourUnselected;
        [NMS(Index = 1155)]
        /* 0x3460 */ public Colour RadialMenuOuterColourDisabled;
        [NMS(Index = 1151)]
        /* 0x3470 */ public Colour RadialMenuOuterColourSelected;
        [NMS(Index = 1153)]
        /* 0x3480 */ public Colour RadialMenuOuterColourUnselected;
        [NMS(Index = 485)]
        /* 0x3490 */ public Colour RefinerBackgroundColour;
        [NMS(Index = 486)]
        /* 0x34A0 */ public Colour RefinerErrorBackgroundColour;
        [NMS(Index = 712)]
        /* 0x34B0 */ public Colour RemappedControlColour;
        [NMS(Index = 711)]
        /* 0x34C0 */ public Colour SelectedControlColour;
        [NMS(Index = 1405)]
        /* 0x34D0 */ public Colour SettlementStatBackgroundColour;
        [NMS(Index = 1404)]
        /* 0x34E0 */ public Colour SettlementStatColour;
        [NMS(Index = 1048)]
        /* 0x34F0 */ public Colour ShieldBgColour;
        [NMS(Index = 1046)]
        /* 0x3500 */ public Colour ShieldColour;
        [NMS(Index = 1049)]
        /* 0x3510 */ public Colour ShieldDamageBgColour;
        [NMS(Index = 1047)]
        /* 0x3520 */ public Colour ShieldDamageColour;
        [NMS(Index = 14)]
        /* 0x3530 */ public Colour ShipBuilderLineColour;
        [NMS(Index = 13)]
        /* 0x3540 */ public Colour ShipBuilderLineColourHologram;
        [NMS(Index = 994)]
        /* 0x3550 */ public Colour ShipHUDAimTargetColour;
        [NMS(Index = 995)]
        /* 0x3560 */ public Colour ShipHUDAimTargetCritColour;
        [NMS(Index = 992)]
        /* 0x3570 */ public Colour ShipHUDTargetArrowsColourLocal;
        [NMS(Index = 990)]
        /* 0x3580 */ public Colour ShipHUDTargetArrowsColourOutOfRange;
        [NMS(Index = 991)]
        /* 0x3590 */ public Colour ShipHUDTargetArrowsColourThreat;
        [NMS(Index = 1246)]
        /* 0x35A0 */ public Colour SpaceEnemyShipLineColour;
        [NMS(Index = 1245)]
        /* 0x35B0 */ public Colour SpaceFriendlyShipLineColour;
        [NMS(Index = 1248)]
        /* 0x35C0 */ public Colour SpaceMapAttackColour;
        [NMS(Index = 533)]
        /* 0x35D0 */ public Vector3f SpaceMapCockpitOffset;
        [NMS(Index = 1253)]
        /* 0x35E0 */ public Colour SpaceMapDeathPointColour;
        [NMS(Index = 1251)]
        /* 0x35F0 */ public Colour SpaceMapNeutralColour;
        [NMS(Index = 1249)]
        /* 0x3600 */ public Colour SpaceMapOtherPlayerColour;
        [NMS(Index = 1247)]
        /* 0x3610 */ public Vector3f SpaceMapPosScaler;
        [NMS(Index = 1252)]
        /* 0x3620 */ public Colour SpaceMapSquadronColour;
        [NMS(Index = 1250)]
        /* 0x3630 */ public Colour SpaceMapThreatColour;
        [NMS(Index = 1426)]
        /* 0x3640 */ public Colour SpookMeterColour;
        [NMS(Index = 25)]
        /* 0x3650 */ public Colour StoreDialFillColour;
        [NMS(Index = 72)]
        /* 0x3660 */ public Colour SuperchargeGradientBaseColour;
        [NMS(Index = 73)]
        /* 0x3670 */ public Colour SuperchargeGradientBlendColour;
        [NMS(Index = 74)]
        /* 0x3680 */ public Colour SuperchargeGradientTechColour;
        [NMS(Index = 71)]
        /* 0x3690 */ public Colour SuperchargePopupColour;
        [NMS(Index = 547)]
        /* 0x36A0 */ public Vector3f TargetDisplayShipOffset;
        [NMS(Index = 548)]
        /* 0x36B0 */ public Vector3f TargetDisplayTorpedoOffset;
        [NMS(Index = 1183)]
        /* 0x36C0 */ public Colour TargetMarkerColour;
        [NMS(Index = 1184)]
        /* 0x36D0 */ public Colour TargetMarkerHighlightColour;
        [NMS(Index = 19)]
        /* 0x36E0 */ public Colour TouchButtonChargeIndicatorColour;
        [NMS(Index = 493)]
        /* 0x36F0 */ public Colour TransferSendPopupColour;
        [NMS(Index = 311)]
        /* 0x3700 */ public Colour TravelLineColour;
        [NMS(Index = 314)]
        /* 0x3710 */ public Colour TravelLineInvalidColour;
        [NMS(Index = 315)]
        /* 0x3720 */ public Colour TravelLineNotAllowedColour;
        [NMS(Index = 312)]
        /* 0x3730 */ public Colour TravelLineTooFarColour;
        [NMS(Index = 313)]
        /* 0x3740 */ public Colour TravelLineTooSteepColour;
        [NMS(Index = 316)]
        /* 0x3750 */ public Colour TravelTargetColour;
        [NMS(Index = 1193)]
        /* 0x3760 */ public Colour UnseenItemColour;
        [NMS(Index = 1192)]
        /* 0x3770 */ public Colour WantedColour;
        [NMS(Index = 40)]
        /* 0x3780 */ public Colour WristMenuDefaultBorderColour;
        [NMS(Index = 41)]
        /* 0x3790 */ public Colour WristMenuRepositionableBorderColour;
        [NMS(Index = 59, Size = 0xF, EnumType = typeof(GcWonderCreatureCategory.WonderCreatureCategoryEnum))]
        /* 0x37A0 */ public GcWonderCategoryConfig[] WonderCreatureCategoryConfig;
        [NMS(Index = 62, Size = 0xD, EnumType = typeof(GcWonderTreasureCategory.WonderTreasureCategoryEnum))]
        /* 0x3AE8 */ public GcWonderCategoryConfig[] WonderTreasureCategoryConfig;
        [NMS(Index = 64, Size = 0xC, EnumType = typeof(GcWonderCustomCategory.WonderCustomCategoryEnum))]
        /* 0x3DC0 */ public GcWonderCategoryConfig[] WonderCustomCategoryConfig;
        [NMS(Index = 58, Size = 0xB, EnumType = typeof(GcWonderPlanetCategory.WonderPlanetCategoryEnum))]
        /* 0x4060 */ public GcWonderCategoryConfig[] WonderPlanetCategoryConfig;
        [NMS(Index = 63, Size = 0xB, EnumType = typeof(GcWonderWeirdBasePartCategory.WonderWeirdBasePartCategoryEnum))]
        /* 0x42C8 */ public GcWonderCategoryConfig[] WonderWeirdBasePartCategoryConfig;
        [NMS(Index = 391, Size = 0x10, EnumType = typeof(GcBuildMenuOption.BuildMenuOptionEnum))]
        /* 0x4530 */ public NMSString0x20A[] BuildMenuOnActionDisabledLocIDs;
        [NMS(Index = 392, Size = 0x10, EnumType = typeof(GcBuildMenuOption.BuildMenuOptionEnum))]
        /* 0x4730 */ public NMSString0x20A[] BuildMenuOnActionErrorLocIDs;
        [NMS(Index = 390, Size = 0x10, EnumType = typeof(GcBuildMenuOption.BuildMenuOptionEnum))]
        /* 0x4930 */ public NMSString0x20A[] BuildMenuOnActionLocIDs;
        [NMS(Index = 60, Size = 0x8, EnumType = typeof(GcWonderFloraCategory.WonderFloraCategoryEnum))]
        /* 0x4B30 */ public GcWonderCategoryConfig[] WonderFloraCategoryConfig;
        [NMS(Index = 61, Size = 0x8, EnumType = typeof(GcWonderMineralCategory.WonderMineralCategoryEnum))]
        /* 0x4CF0 */ public GcWonderCategoryConfig[] WonderMineralCategoryConfig;
        [NMS(Index = 1374)]
        /* 0x4EB0 */ public GcHUDStartupTable IntroTiming;
        [NMS(Index = 1375)]
        /* 0x5000 */ public GcHUDStartupTable IntroTimingFreighter;
        [NMS(Index = 1376)]
        /* 0x5150 */ public GcHUDStartupTable IntroTimingFreighterRepaired;
        [NMS(Index = 1407, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x52A0 */ public NMSString0x20A[] SettlementStatFormatLoc;
        [NMS(Index = 1406, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x5380 */ public NMSString0x20A[] SettlementStatLoc;
        [NMS(Index = 1408, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x5460 */ public TkTextureResource[] SettlementStatBasicImages;
        [NMS(Index = 1410, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x5508 */ public TkTextureResource[] SettlementStatNegativeImages;
        [NMS(Index = 1409, Size = 0x7, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x55B0 */ public TkTextureResource[] SettlementStatPositiveImages;
        [NMS(Index = 53, Size = 0x7, EnumType = typeof(GcWonderType.WonderTypeEnum))]
        /* 0x5658 */ public TkTextureResource[] WonderTypeIcons;
        [NMS(Index = 435)]
        /* 0x5700 */ public TkTextureResource BaseBuildingPartsGridExpandableIcon;
        [NMS(Index = 436)]
        /* 0x5718 */ public TkTextureResource BaseBuildingPartsGridExpandedIcon;
        [NMS(Index = 437)]
        /* 0x5730 */ public TkTextureResource BaseBuildingPartsGridRetractableIcon;
        [NMS(Index = 469)]
        /* 0x5748 */ public TkTextureResource RefinerPopupEmptyOutputIcon;
        [NMS(Index = 1040)]
        /* 0x5760 */ public VariableSizeString CamoNormalTexture;
        [NMS(Index = 1039)]
        /* 0x5770 */ public VariableSizeString CamoTexture;
        [NMS(Index = 81)]
        /* 0x5780 */ public NMSString0x10 DebugInventoryHint;
        [NMS(Index = 111)]
        /* 0x5790 */ public NMSString0x10 ExplorationLogMissionID;
        [NMS(Index = 1038)]
        /* 0x57A0 */ public List<Vector4f> HazardDistortionParams;
        [NMS(Index = 1034)]
        /* 0x57B0 */ public List<VariableSizeString> HazardHeightmaps;
        [NMS(Index = 1037)]
        /* 0x57C0 */ public List<VariableSizeString> HazardHeightmapsVR;
        [NMS(Index = 1033)]
        /* 0x57D0 */ public List<VariableSizeString> HazardNormalMaps;
        [NMS(Index = 1036)]
        /* 0x57E0 */ public List<VariableSizeString> HazardNormalMapsVR;
        [NMS(Index = 1032)]
        /* 0x57F0 */ public List<VariableSizeString> HazardTextures;
        [NMS(Index = 1035)]
        /* 0x5800 */ public List<VariableSizeString> HazardTexturesVR;
        [NMS(Index = 335)]
        /* 0x5810 */ public List<Vector2f> InventoryIconPositions;
        [NMS(Index = 339)]
        /* 0x5820 */ public NMSString0x10 MultiplayerMissionInteractEndTrigger;
        [NMS(Index = 338)]
        /* 0x5830 */ public NMSString0x10 MultiplayerMissionInteractStartTrigger;
        [NMS(Index = 99)]
        /* 0x5840 */ public List<GcSeasonalRingArray> SeasonalRingTable;
        [NMS(Index = 993)]
        /* 0x5850 */ public List<Colour> ShipHUDTargetArrowsColour;
        [NMS(Index = 803)]
        /* 0x5860 */ public NMSString0x10 ShowStatWithDeathQuote;
        [NMS(Index = 871)]
        /* 0x5870 */ public List<VariableSizeString> StatIcons;
        [NMS(Index = 462)]
        /* 0x5880 */ public List<TkModelRendererData> VehicleTypeRepairCamera;
        [NMS(Index = 703, Size = 0x14, EnumType = typeof(GcPlayerWeapons.WeaponModeEnum))]
        /* 0x5890 */ public float[] CrosshairTargetLockSizeSpecific;
        [NMS(Index = 953)]
        /* 0x58E0 */ public GcWorldUISettings WorldUISettings;
        [NMS(Index = 55, Size = 0xF, EnumType = typeof(GcWonderCreatureCategory.WonderCreatureCategoryEnum))]
        /* 0x5930 */ public float[] WonderValueModifiersCreature;
        [NMS(Index = 54, Size = 0xB, EnumType = typeof(GcWonderPlanetCategory.WonderPlanetCategoryEnum))]
        /* 0x596C */ public float[] WonderValueModifiersPlanet;
        [NMS(Index = 56, Size = 0x8, EnumType = typeof(GcWonderFloraCategory.WonderFloraCategoryEnum))]
        /* 0x5998 */ public float[] WonderValueModifiersFlora;
        [NMS(Index = 57, Size = 0x8, EnumType = typeof(GcWonderMineralCategory.WonderMineralCategoryEnum))]
        /* 0x59B8 */ public float[] WonderValueModifiersMineral;
        [NMS(Index = 1378)]
        /* 0x59D8 */ public GcInventorySlotActionData BuildProductSlotAction;
        [NMS(Index = 1379)]
        /* 0x59F4 */ public GcInventorySlotActionData ChargeSlotAction;
        [NMS(Index = 1377)]
        /* 0x5A10 */ public GcInventorySlotActionData InstallTechSlotAction;
        [NMS(Index = 1383)]
        /* 0x5A2C */ public GcInventorySlotActionData InventoryHintAction;
        [NMS(Index = 1384)]
        /* 0x5A48 */ public GcInventorySlotActionData InventoryHintActionNoGlow;
        [NMS(Index = 1382)]
        /* 0x5A64 */ public GcInventorySlotActionData NewSlotPulseAction;
        [NMS(Index = 1381)]
        /* 0x5A80 */ public GcInventorySlotActionData NewSlotRevealAction;
        [NMS(Index = 1380)]
        /* 0x5A9C */ public GcInventorySlotActionData RepairSlotAction;
        [NMS(Index = 796)]
        /* 0x5AB8 */ public TkNGuiRectanglePulseEffect PulseBarData;
        [NMS(Index = 797)]
        /* 0x5AC8 */ public TkNGuiRectanglePulseEffect PulseIconData;
        [NMS(Index = 707)]
        /* 0x5AD8 */ public TkHitCurveData CrosshairLeadHitCurve;
        [NMS(Index = 1373)]
        /* 0x5AE4 */ public GcDiscoveryHelperTimings DiscoveryHelperTimings;
        [NMS(Index = 708)]
        /* 0x5AF0 */ public TkHitCurveData ShootableHitCurve;
        [NMS(Index = 153)]
        /* 0x5AFC */ public Vector2f BinocularEdgeFade;
        [NMS(Index = 463)]
        /* 0x5B04 */ public Vector2f BinocularsDiscoveryPos;
        [NMS(Index = 368)]
        /* 0x5B0C */ public Vector2f CompassCentre;
        [NMS(Index = 528)]
        /* 0x5B14 */ public Vector2f CursorlessDialogPageCursorOffset;
        [NMS(Index = 613)]
        /* 0x5B1C */ public Vector2f DamageNumberSideSpeed;
        [NMS(Index = 526)]
        /* 0x5B24 */ public Vector2f DialogPageCursorOffset;
        [NMS(Index = 1279)]
        /* 0x5B2C */ public Vector2f HUDMarkerCompassPrimaryIndicatorOffset;
        [NMS(Index = 1278)]
        /* 0x5B34 */ public Vector2f HUDMarkerPrimaryIndicatorOffset;
        [NMS(Index = 478)]
        /* 0x5B3C */ public Vector2f HUDPlayerSentinelPulseFreq;
        [NMS(Index = 479)]
        /* 0x5B44 */ public Vector2f HUDPlayerSentinelPulseSize;
        [NMS(Index = 828)]
        /* 0x5B4C */ public Vector2f HUDPlayerTrackArrowDamageGlowSize;
        [NMS(Index = 830)]
        /* 0x5B54 */ public Vector2f HUDPlayerTrackArrowEnergyShieldGlowSize;
        [NMS(Index = 817)]
        /* 0x5B5C */ public Vector2f HUDPlayerTrackArrowEnergyShieldSize;
        [NMS(Index = 812)]
        /* 0x5B64 */ public Vector2f HUDPlayerTrackArrowHealthSize;
        [NMS(Index = 769)]
        /* 0x5B6C */ public Vector2f HUDPlayerTrackArrowIconPulseSize;
        [NMS(Index = 781)]
        /* 0x5B74 */ public Vector2f HUDPlayerTrackIconOffset;
        [NMS(Index = 1265)]
        /* 0x5B7C */ public Vector2f HUDTargetHealthIconOffset;
        [NMS(Index = 1263)]
        /* 0x5B84 */ public Vector2f HUDTargetHealthOffset;
        [NMS(Index = 1264)]
        /* 0x5B8C */ public Vector2f HUDTargetHealthSize;
        [NMS(Index = 1051)]
        /* 0x5B94 */ public Vector2f InteractionLabelOffset;
        [NMS(Index = 1052)]
        /* 0x5B9C */ public Vector2f InteractionLabelOffset_1;
        [NMS(Index = 1055)]
        /* 0x5BA4 */ public Vector2f InteractionLabelScreenMax;
        [NMS(Index = 1054)]
        /* 0x5BAC */ public Vector2f InteractionLabelScreenMin;
        [NMS(Index = 1056)]
        /* 0x5BB4 */ public Vector2f InteractionLabelSize;
        [NMS(Index = 1058)]
        /* 0x5BBC */ public Vector2f InteractionLabelTouchAreaMax;
        [NMS(Index = 1057)]
        /* 0x5BC4 */ public Vector2f InteractionLabelTouchAreaMin;
        [NMS(Index = 1367)]
        /* 0x5BCC */ public Vector2f InteractionWorldParallax;
        [NMS(Index = 527)]
        /* 0x5BD4 */ public Vector2f IntermediateInteractionPageCursorOffset;
        [NMS(Index = 194)]
        /* 0x5BDC */ public Vector2f InWorldGameGuiAlignment;
        [NMS(Index = 132)]
        /* 0x5BE4 */ public Vector2f InWorldInteractLabelAlignment;
        [NMS(Index = 193)]
        /* 0x5BEC */ public Vector2f InWorldNGuiParallax;
        [NMS(Index = 511)]
        /* 0x5BF4 */ public Vector2f MainMenuSaveIconPosition;
        [NMS(Index = 184)]
        /* 0x5BFC */ public Vector2f MarkerDistanceVRAlignment;
        [NMS(Index = 477)]
        /* 0x5C04 */ public Vector2f ModelViewWorldParallax;
        [NMS(Index = 1364)]
        /* 0x5C0C */ public Vector2f NGuiMax2DParallax;
        [NMS(Index = 1363)]
        /* 0x5C14 */ public Vector2f NGuiMin2DParallax;
        [NMS(Index = 1365)]
        /* 0x5C1C */ public Vector2f NGuiModelParallax;
        [NMS(Index = 1366)]
        /* 0x5C24 */ public Vector2f NGuiShipInteractParallax;
        [NMS(Index = 1182)]
        /* 0x5C2C */ public Vector2f NGuiTouchPadSensitivity;
        [NMS(Index = 919)]
        /* 0x5C34 */ public Vector2f NotificationMissionHintPauseTime;
        [NMS(Index = 920)]
        /* 0x5C3C */ public Vector2f NotificationMissionHintPauseTimeCritical;
        [NMS(Index = 921)]
        /* 0x5C44 */ public Vector2f NotificationMissionHintPauseTimeSecondary;
        [NMS(Index = 467)]
        /* 0x5C4C */ public Vector2f PersonalRefinerInputPos;
        [NMS(Index = 468)]
        /* 0x5C54 */ public Vector2f PersonalRefinerOutputPos;
        [NMS(Index = 955)]
        /* 0x5C5C */ public Vector2f PlanetLabelOffset;
        [NMS(Index = 957)]
        /* 0x5C64 */ public Vector2f PlanetLineOffset;
        [NMS(Index = 956)]
        /* 0x5C6C */ public Vector2f PlanetMeasureOffset;
        [NMS(Index = 476)]
        /* 0x5C74 */ public Vector2f RefinerParallax;
        [NMS(Index = 510)]
        /* 0x5C7C */ public Vector2f SaveIconPosition;
        [NMS(Index = 1050)]
        /* 0x5C84 */ public Vector2f ScanLabelOffset;
        [NMS(Index = 1000)]
        /* 0x5C8C */ public Vector2f TargetScreenCamOffset;
        [NMS(Index = 759)]
        /* 0x5C94 */ public Vector2f TrackCriticalHitOffset;
        [NMS(Index = 723)]
        /* 0x5C9C */ public Vector2f TrackTypeIconOffset;
        [NMS(Index = 1398)]
        /* 0x5CA4 */ public int AbandonedFreighterAirlockRoomNumber;
        [NMS(Index = 1414)]
        /* 0x5CA8 */ public float AccessibleUIHUDPopupScale;
        [NMS(Index = 1413)]
        /* 0x5CAC */ public float AccessibleUIPopupScale;
        [NMS(Index = 167)]
        /* 0x5CB0 */ public float AlignmentRequiredToDisableFrostedGlass;
        [NMS(Index = 1326)]
        /* 0x5CB4 */ public float AltimeterLineSpacing;
        [NMS(Index = 1329)]
        /* 0x5CB8 */ public float AltimeterMax;
        [NMS(Index = 1328)]
        /* 0x5CBC */ public float AltimeterMin;
        [NMS(Index = 1331)]
        /* 0x5CC0 */ public float AltimeterMinValue;
        [NMS(Index = 1325)]
        /* 0x5CC4 */ public float AltimeterResolution;
        [NMS(Index = 1330)]
        /* 0x5CC8 */ public float AltimeterTextSize;
        [NMS(Index = 1327)]
        /* 0x5CCC */ public float AltimeterWidth;
        [NMS(Index = 1029)]
        /* 0x5CD0 */ public float AlwaysOnHazardMultiplierCold;
        [NMS(Index = 1027)]
        /* 0x5CD4 */ public float AlwaysOnHazardMultiplierHeat;
        [NMS(Index = 1028)]
        /* 0x5CD8 */ public float AlwaysOnHazardMultiplierRad;
        [NMS(Index = 1030)]
        /* 0x5CDC */ public float AlwaysOnHazardMultiplierSpook;
        [NMS(Index = 1026)]
        /* 0x5CE0 */ public float AlwaysOnHazardMultiplierTox;
        [NMS(Index = 1024)]
        /* 0x5CE4 */ public float AlwaysOnHazardStrengthCold;
        [NMS(Index = 1022)]
        /* 0x5CE8 */ public float AlwaysOnHazardStrengthHeat;
        [NMS(Index = 1023)]
        /* 0x5CEC */ public float AlwaysOnHazardStrengthRad;
        [NMS(Index = 1025)]
        /* 0x5CF0 */ public float AlwaysOnHazardStrengthSpook;
        [NMS(Index = 1021)]
        /* 0x5CF4 */ public float AlwaysOnHazardStrengthTox;
        [NMS(Index = 1020)]
        /* 0x5CF8 */ public float AlwaysOnHazardThreshold;
        [NMS(Index = 668)]
        /* 0x5CFC */ public float AlwaysShowIconFadeDistance;
        [NMS(Index = 669)]
        /* 0x5D00 */ public float AlwaysShowIconFadeRange;
        [NMS(Index = 1389)]
        /* 0x5D04 */ public float AmbientModeFadeTime;
        [NMS(Index = 663)]
        /* 0x5D08 */ public float ArrowBounceLeftRate1;
        [NMS(Index = 664)]
        /* 0x5D0C */ public float ArrowBounceLeftRate2;
        [NMS(Index = 665)]
        /* 0x5D10 */ public float ArrowBounceLeftRate3;
        [NMS(Index = 658)]
        /* 0x5D14 */ public float ArrowBounceLength;
        [NMS(Index = 659)]
        /* 0x5D18 */ public float ArrowBounceRate;
        [NMS(Index = 660)]
        /* 0x5D1C */ public float ArrowBounceRightRate1;
        [NMS(Index = 661)]
        /* 0x5D20 */ public float ArrowBounceRightRate2;
        [NMS(Index = 1340)]
        /* 0x5D24 */ public float AsteroidMarkerMinDisplayAngleDegrees;
        [NMS(Index = 1339)]
        /* 0x5D28 */ public float AsteroidMarkerMinDisplayDistance;
        [NMS(Index = 420)]
        /* 0x5D2C */ public float BaseBuildingFreeRotateDelayBeforeAudioStops;
        [NMS(Index = 419)]
        /* 0x5D30 */ public float BaseBuildingFreeRotateDelayBeforeReset;
        [NMS(Index = 418)]
        /* 0x5D34 */ public float BaseBuildingFreeRotateSpeedPadMultiplier;
        [NMS(Index = 412)]
        /* 0x5D38 */ public float BaseBuildingInputHighlightAlpha;
        [NMS(Index = 411)]
        /* 0x5D3C */ public float BaseBuildingInputHighlightDuration;
        [NMS(Index = 415)]
        /* 0x5D40 */ public float BaseBuildingMaxFreeRotateSpeed;
        [NMS(Index = 414)]
        /* 0x5D44 */ public float BaseBuildingMinFreeRotateSpeed;
        [NMS(Index = 431)]
        /* 0x5D48 */ public float BaseBuildingPartsGridBreadcrumbFlashDuration;
        [NMS(Index = 430)]
        /* 0x5D4C */ public float BaseBuildingPartsGridMaxCursorRestorationTime;
        [NMS(Index = 432)]
        /* 0x5D50 */ public float BaseBuildingPartsGridMinVisibilityForActive;
        [NMS(Index = 434)]
        /* 0x5D54 */ public float BaseBuildingPartsGridPopupDelay;
        [NMS(Index = 433)]
        /* 0x5D58 */ public float BaseBuildingPartsGridScrollSpeed;
        [NMS(Index = 410)]
        /* 0x5D5C */ public float BaseBuildingPinHighlightDuration;
        [NMS(Index = 417)]
        /* 0x5D60 */ public float BaseBuildingRotationResetRate;
        [NMS(Index = 413)]
        /* 0x5D64 */ public float BaseBuildingScaleSpeed;
        [NMS(Index = 416)]
        /* 0x5D68 */ public float BaseBuildingTimeToMaxRotationSpeed;
        [NMS(Index = 429)]
        /* 0x5D6C */ public float BaseBuildingUIAdjustTime;
        [NMS(Index = 428)]
        /* 0x5D70 */ public float BaseBuildingUIErrorFadeTime;
        [NMS(Index = 422)]
        /* 0x5D74 */ public float BaseBuildingUIHorizontalSafeArea;
        [NMS(Index = 425)]
        /* 0x5D78 */ public float BaseBuildingUIVerticalOffset;
        [NMS(Index = 426)]
        /* 0x5D7C */ public float BaseBuildingUIVerticalOffsetEdit;
        [NMS(Index = 427)]
        /* 0x5D80 */ public float BaseBuildingUIVerticalOffsetFromBB;
        [NMS(Index = 424)]
        /* 0x5D84 */ public float BaseBuildingUIVerticalPosWiring;
        [NMS(Index = 423)]
        /* 0x5D88 */ public float BaseBuildingUIVerticalSafeArea;
        [NMS(Index = 384)]
        /* 0x5D8C */ public float BaseComplexityDangerFactor;
        [NMS(Index = 385)]
        /* 0x5D90 */ public float BaseComplexityWarningFactor;
        [NMS(Index = 0)]
        /* 0x5D94 */ public float BattleHUDBarInterpTime;
        [NMS(Index = 152)]
        /* 0x5D98 */ public float BeaconHUDMarkerOffset;
        [NMS(Index = 156)]
        /* 0x5D9C */ public float BinocularMarkerSideAngle;
        [NMS(Index = 157)]
        /* 0x5DA0 */ public float BinocularMarkerUpAngle;
        [NMS(Index = 166)]
        /* 0x5DA4 */ public float BinocularsAltUIRescaleFactor;
        [NMS(Index = 154)]
        /* 0x5DA8 */ public float BinocularScreenOffset;
        [NMS(Index = 155)]
        /* 0x5DAC */ public float BinocularScreenScale;
        [NMS(Index = 164)]
        /* 0x5DB0 */ public float BinocularsFarIconDist;
        [NMS(Index = 165)]
        /* 0x5DB4 */ public float BinocularsFarIconFadeDist;
        [NMS(Index = 163)]
        /* 0x5DB8 */ public float BinocularsFarIconOpacity;
        [NMS(Index = 162)]
        /* 0x5DBC */ public float BinocularsMidIconOpacity;
        [NMS(Index = 160)]
        /* 0x5DC0 */ public float BinocularsNearIconDist;
        [NMS(Index = 161)]
        /* 0x5DC4 */ public float BinocularsNearIconFadeDist;
        [NMS(Index = 159)]
        /* 0x5DC8 */ public float BinocularsNearIconOpacity;
        [NMS(Index = 494)]
        /* 0x5DCC */ public float BountyMarkerOffset;
        [NMS(Index = 1394)]
        /* 0x5DD0 */ public int BuildingShopMaxItems;
        [NMS(Index = 389)]
        /* 0x5DD4 */ public float BuildMenuActionMessageDuration;
        [NMS(Index = 249)]
        /* 0x5DD8 */ public float BuildMenuItemNavAnimTime;
        [NMS(Index = 250)]
        /* 0x5DDC */ public float BuildMenuItemNextNavAnimTime;
        [NMS(Index = 251)]
        /* 0x5DE0 */ public float BuildMenuItemNextNavAnimWait;
        [NMS(Index = 1112)]
        /* 0x5DE4 */ public float ByteBeatArpLineWidth;
        [NMS(Index = 1114)]
        /* 0x5DE8 */ public float ByteBeatArpPad;
        [NMS(Index = 1113)]
        /* 0x5DEC */ public float ByteBeatArpRadius;
        [NMS(Index = 1110)]
        /* 0x5DF0 */ public float ByteBeatIconLineWidth;
        [NMS(Index = 1111)]
        /* 0x5DF4 */ public float ByteBeatIconPad;
        [NMS(Index = 1121)]
        /* 0x5DF8 */ public float ByteBeatPartSequencerPad;
        [NMS(Index = 1123)]
        /* 0x5DFC */ public float ByteBeatRhythmBeatPad;
        [NMS(Index = 1127)]
        /* 0x5E00 */ public float ByteBeatRhythmSequencerActiveSaturation;
        [NMS(Index = 1126)]
        /* 0x5E04 */ public float ByteBeatRhythmSequencerInactiveSaturation;
        [NMS(Index = 1125)]
        /* 0x5E08 */ public float ByteBeatSequencerActiveSaturation;
        [NMS(Index = 1122)]
        /* 0x5E0C */ public float ByteBeatSequencerCornerRadius;
        [NMS(Index = 1141)]
        /* 0x5E10 */ public float ByteBeatSequencerHighlightLineWidth;
        [NMS(Index = 1124)]
        /* 0x5E14 */ public float ByteBeatSequencerInactiveSaturation;
        [NMS(Index = 1119)]
        /* 0x5E18 */ public float ByteBeatSequencerLineWidth;
        [NMS(Index = 1120)]
        /* 0x5E1C */ public float ByteBeatSequencerPad;
        [NMS(Index = 1128)]
        /* 0x5E20 */ public float ByteBeatSequencerUnpoweredTintStrength;
        [NMS(Index = 1144)]
        /* 0x5E24 */ public float ByteBeatSliderCornerRadius;
        [NMS(Index = 1142)]
        /* 0x5E28 */ public float ByteBeatSliderLineWidth;
        [NMS(Index = 1143)]
        /* 0x5E2C */ public float ByteBeatSliderPad;
        [NMS(Index = 1148)]
        /* 0x5E30 */ public float ByteBeatSwitchPanelAlpha;
        [NMS(Index = 1149)]
        /* 0x5E34 */ public float ByteBeatSwitchPanelSplit;
        [NMS(Index = 1105)]
        /* 0x5E38 */ public float ByteBeatTreeLineWidth;
        [NMS(Index = 1107)]
        /* 0x5E3C */ public float ByteBeatVisLineWidth;
        [NMS(Index = 117)]
        /* 0x5E40 */ public float ClosestDoorMarkerBuffer;
        [NMS(Index = 179)]
        /* 0x5E44 */ public float CockpitGlassDefrostTime;
        [NMS(Index = 178)]
        /* 0x5E48 */ public float CockpitGlassFrostTime;
        [NMS(Index = 552)]
        /* 0x5E4C */ public float CommunicatorMessageTime;
        [NMS(Index = 380)]
        /* 0x5E50 */ public float CompassAngleClamp;
        [NMS(Index = 383)]
        /* 0x5E54 */ public float CompassAngleClampSpace;
        [NMS(Index = 381)]
        /* 0x5E58 */ public float CompassAngleFade;
        [NMS(Index = 377)]
        /* 0x5E5C */ public float CompassDistanceMarkerMinScale;
        [NMS(Index = 378)]
        /* 0x5E60 */ public float CompassDistanceMaxAngle;
        [NMS(Index = 375)]
        /* 0x5E64 */ public float CompassDistanceScale;
        [NMS(Index = 371)]
        /* 0x5E68 */ public float CompassDistanceScaleMin;
        [NMS(Index = 372)]
        /* 0x5E6C */ public float CompassDistanceScaleRange;
        [NMS(Index = 376)]
        /* 0x5E70 */ public float CompassDistanceShipMinScale;
        [NMS(Index = 373)]
        /* 0x5E74 */ public float CompassDistanceSpaceScaleMin;
        [NMS(Index = 374)]
        /* 0x5E78 */ public float CompassDistanceSpaceScaleRange;
        [NMS(Index = 379)]
        /* 0x5E7C */ public float CompassDistanceYOffset;
        [NMS(Index = 369)]
        /* 0x5E80 */ public float CompassHeight;
        [NMS(Index = 185)]
        /* 0x5E84 */ public float CompassIconOffsetVR;
        [NMS(Index = 206)]
        /* 0x5E88 */ public float CompassLineContractionEndAngle;
        [NMS(Index = 205)]
        /* 0x5E8C */ public float CompassLineContractionStartAngle;
        [NMS(Index = 207)]
        /* 0x5E90 */ public float CompassLineContractionTargetAngle;
        [NMS(Index = 211)]
        /* 0x5E94 */ public float CompassLineNotchAngleRange;
        [NMS(Index = 213)]
        /* 0x5E98 */ public float CompassLineNotchLength;
        [NMS(Index = 212)]
        /* 0x5E9C */ public float CompassLineNotchThickness;
        [NMS(Index = 208)]
        /* 0x5EA0 */ public int CompassLineNumNotches;
        [NMS(Index = 210)]
        /* 0x5EA4 */ public float CompassLineOffset;
        [NMS(Index = 209)]
        /* 0x5EA8 */ public float CompassLineThickness;
        [NMS(Index = 204)]
        /* 0x5EAC */ public int CompassScreenHeight;
        [NMS(Index = 203)]
        /* 0x5EB0 */ public int CompassScreenWidth;
        [NMS(Index = 370)]
        /* 0x5EB4 */ public float CompassWidth;
        [NMS(Index = 582)]
        /* 0x5EB8 */ public float ConsoleTextSpeed;
        [NMS(Index = 584)]
        /* 0x5EBC */ public float ConsoleTextTimeMax;
        [NMS(Index = 583)]
        /* 0x5EC0 */ public float ConsoleTextTimeMin;
        [NMS(Index = 710)]
        /* 0x5EC4 */ public float ControlScrollDistance;
        [NMS(Index = 709)]
        /* 0x5EC8 */ public int ControlScrollSteps;
        [NMS(Index = 595)]
        /* 0x5ECC */ public float CreatureDistanceAlpha;
        [NMS(Index = 593)]
        /* 0x5ED0 */ public float CreatureDistanceDisplayAngle;
        [NMS(Index = 594)]
        /* 0x5ED4 */ public float CreatureDistanceFadeTime;
        [NMS(Index = 591)]
        /* 0x5ED8 */ public float CreatureDistanceOffsetY;
        [NMS(Index = 592)]
        /* 0x5EDC */ public float CreatureDistanceShadowOffset;
        [NMS(Index = 590)]
        /* 0x5EE0 */ public float CreatureDistanceSize;
        [NMS(Index = 361)]
        /* 0x5EE4 */ public float CreatureIconMergeAngle;
        [NMS(Index = 627)]
        /* 0x5EE8 */ public float CreatureIconOffset;
        [NMS(Index = 628)]
        /* 0x5EEC */ public float CreatureIconOffsetPhysics;
        [NMS(Index = 749)]
        /* 0x5EF0 */ public float CreatureInteractLabelOffsetY;
        [NMS(Index = 745)]
        /* 0x5EF4 */ public float CreatureReticuleScale;
        [NMS(Index = 715)]
        /* 0x5EF8 */ public float CreatureRoutineMarkerTime;
        [NMS(Index = 716)]
        /* 0x5EFC */ public int CreatureRoutineRegionsPerFrame;
        [NMS(Index = 801)]
        /* 0x5F00 */ public float CriticalMessageTime;
        [NMS(Index = 677)]
        /* 0x5F04 */ public float CrosshairAimOffTime;
        [NMS(Index = 676)]
        /* 0x5F08 */ public float CrosshairAimTime;
        [NMS(Index = 678)]
        /* 0x5F0C */ public float CrosshairInnerMinFade;
        [NMS(Index = 679)]
        /* 0x5F10 */ public float CrosshairInnerMinFadeRange;
        [NMS(Index = 700)]
        /* 0x5F14 */ public float CrosshairInterceptAlpha;
        [NMS(Index = 697)]
        /* 0x5F18 */ public float CrosshairInterceptBaseSize;
        [NMS(Index = 698)]
        /* 0x5F1C */ public float CrosshairInterceptCentreBaseSize;
        [NMS(Index = 701)]
        /* 0x5F20 */ public float CrosshairInterceptLockRange;
        [NMS(Index = 696)]
        /* 0x5F24 */ public float CrosshairInterceptSize;
        [NMS(Index = 699)]
        /* 0x5F28 */ public float CrosshairInterceptSpringTime;
        [NMS(Index = 683)]
        /* 0x5F2C */ public float CrosshairLeadCornerOffset;
        [NMS(Index = 692)]
        /* 0x5F30 */ public float CrosshairLeadFadeRange;
        [NMS(Index = 693)]
        /* 0x5F34 */ public float CrosshairLeadFadeSize;
        [NMS(Index = 681)]
        /* 0x5F38 */ public float CrosshairLeadInDelay;
        [NMS(Index = 682)]
        /* 0x5F3C */ public float CrosshairLeadInTime;
        [NMS(Index = 686)]
        /* 0x5F40 */ public float CrosshairLeadPulseSize;
        [NMS(Index = 680)]
        /* 0x5F44 */ public float CrosshairLeadScaleIn;
        [NMS(Index = 690)]
        /* 0x5F48 */ public float CrosshairLeadSpring;
        [NMS(Index = 691)]
        /* 0x5F4C */ public float CrosshairLeadSpringOff;
        [NMS(Index = 685)]
        /* 0x5F50 */ public float CrosshairLeadTopLock;
        [NMS(Index = 684)]
        /* 0x5F54 */ public float CrosshairLeadTopOffset;
        [NMS(Index = 293)]
        /* 0x5F58 */ public float CrosshairOffsetHmd;
        [NMS(Index = 294)]
        /* 0x5F5C */ public float CrosshairOffsetHmdUp;
        [NMS(Index = 292)]
        /* 0x5F60 */ public float CrosshairScaleHmd;
        [NMS(Index = 296)]
        /* 0x5F64 */ public int CrosshairScreenHeight;
        [NMS(Index = 295)]
        /* 0x5F68 */ public int CrosshairScreenWidth;
        [NMS(Index = 689)]
        /* 0x5F6C */ public float CrosshairSpringAimTime;
        [NMS(Index = 688)]
        /* 0x5F70 */ public float CrosshairSpringTime;
        [NMS(Index = 702)]
        /* 0x5F74 */ public float CrosshairTargetLockSize;
        [NMS(Index = 1074)]
        /* 0x5F78 */ public float CursorHoverSlowFactor;
        [NMS(Index = 1075)]
        /* 0x5F7C */ public float CursorHoverSlowFactorMin;
        [NMS(Index = 525)]
        /* 0x5F80 */ public float DamageDirectionIndicatorOnScreenRadiusMultiplier;
        [NMS(Index = 597)]
        /* 0x5F84 */ public float DamageImpactMergeTime;
        [NMS(Index = 599)]
        /* 0x5F88 */ public float DamageImpactMinDistance;
        [NMS(Index = 598)]
        /* 0x5F8C */ public float DamageImpactTimeBetweenNumbers;
        [NMS(Index = 608)]
        /* 0x5F90 */ public float DamageNumberBlackAlpha;
        [NMS(Index = 614)]
        /* 0x5F94 */ public float DamageNumberFadeIn;
        [NMS(Index = 615)]
        /* 0x5F98 */ public float DamageNumberFadeOut;
        [NMS(Index = 607)]
        /* 0x5F9C */ public float DamageNumberLaserMaxDamage;
        [NMS(Index = 606)]
        /* 0x5FA0 */ public float DamageNumberLaserMinDamage;
        [NMS(Index = 611)]
        /* 0x5FA4 */ public float DamageNumberOffsetX;
        [NMS(Index = 612)]
        /* 0x5FA8 */ public float DamageNumberOffsetY;
        [NMS(Index = 609)]
        /* 0x5FAC */ public float DamageNumberOutline;
        [NMS(Index = 610)]
        /* 0x5FB0 */ public float DamageNumberOutline2;
        [NMS(Index = 603)]
        /* 0x5FB4 */ public float DamageNumberSize;
        [NMS(Index = 604)]
        /* 0x5FB8 */ public float DamageNumberSizeCritMultiplier;
        [NMS(Index = 602)]
        /* 0x5FBC */ public float DamageNumberSizeInShip;
        [NMS(Index = 605)]
        /* 0x5FC0 */ public float DamageNumberSizeLaserMultiplier;
        [NMS(Index = 601)]
        /* 0x5FC4 */ public float DamageNumberTime;
        [NMS(Index = 616)]
        /* 0x5FC8 */ public float DamageNumberUpOffset;
        [NMS(Index = 600)]
        /* 0x5FCC */ public float DamagePerSecondSampleTime;
        [NMS(Index = 447)]
        /* 0x5FD0 */ public float DamageScannableHighlightTime;
        [NMS(Index = 448)]
        /* 0x5FD4 */ public float DamageTrackArrowTime;
        [NMS(Index = 928)]
        /* 0x5FD8 */ public float DeathMessageSwitchTime;
        [NMS(Index = 929)]
        /* 0x5FDC */ public float DeathMessageTotalTime;
        [NMS(Index = 52)]
        /* 0x5FE0 */ public int DebugMedalRank;
        [NMS(Index = 629)]
        /* 0x5FE4 */ public float DelayBeforeHidingHangarAfterGalaxyMap;
        [NMS(Index = 630)]
        /* 0x5FE8 */ public float DelayBeforeShowingHangarIntoGalaxyMap;
        [NMS(Index = 577)]
        /* 0x5FEC */ public float DescriptionTextDelay;
        [NMS(Index = 578)]
        /* 0x5FF0 */ public float DescriptionTextSpeed;
        [NMS(Index = 579)]
        /* 0x5FF4 */ public float DescriptionTextSpeedProgressive;
        [NMS(Index = 581)]
        /* 0x5FF8 */ public float DescriptionTextTimeMax;
        [NMS(Index = 580)]
        /* 0x5FFC */ public float DescriptionTextTimeMin;
        [NMS(Index = 1415)]
        /* 0x6000 */ public float DetailMessageDismissTime;
        [NMS(Index = 343)]
        /* 0x6004 */ public float DroneIndicatorCentreRadiusMax;
        [NMS(Index = 344)]
        /* 0x6008 */ public float DroneIndicatorCentreRadiusMin;
        [NMS(Index = 345)]
        /* 0x600C */ public float DroneIndicatorFadeRange;
        [NMS(Index = 342)]
        /* 0x6010 */ public float DroneIndicatorRadius;
        [NMS(Index = 97)]
        /* 0x6014 */ public float EggModifiyAnimLoopTime;
        [NMS(Index = 96)]
        /* 0x6018 */ public float EggModifiyAnimMaxSize;
        [NMS(Index = 107)]
        /* 0x601C */ public float EndOfSeasonAlertDelay;
        [NMS(Index = 144)]
        /* 0x6020 */ public float ExocraftHUDMarkerHideDistance;
        [NMS(Index = 145)]
        /* 0x6024 */ public float ExocraftHUDMarkerOffset;
        [NMS(Index = 104)]
        /* 0x6028 */ public float ExpeditionStageChangeTime;
        [NMS(Index = 46)]
        /* 0x602C */ public float EyeTrackingCursorBlendRate;
        [NMS(Index = 45)]
        /* 0x6030 */ public float EyeTrackingCursorBlendRateGameModeSelect;
        [NMS(Index = 44)]
        /* 0x6034 */ public float EyeTrackingPopupLookAwayTime;
        [NMS(Index = 47)]
        /* 0x6038 */ public float EyeTrackingStickyHoverTime;
        [NMS(Index = 43)]
        /* 0x603C */ public float EyeTrackingTimeBeforePopupsActivate;
        [NMS(Index = 1423)]
        /* 0x6040 */ public float FeedFrigateAnimAlphaChange;
        [NMS(Index = 1421)]
        /* 0x6044 */ public int FeedFrigateAnimNumPeriods;
        [NMS(Index = 1420)]
        /* 0x6048 */ public float FeedFrigateAnimPeriod;
        [NMS(Index = 1422)]
        /* 0x604C */ public float FeedFrigateAnimScaleChange;
        [NMS(Index = 112)]
        /* 0x6050 */ public int ForceOpenHazardProtInventoryThreshold;
        [NMS(Index = 642)]
        /* 0x6054 */ public float FreighterCommanderMarkerMinDistance;
        [NMS(Index = 673)]
        /* 0x6058 */ public float FreighterEntranceOffset;
        [NMS(Index = 648)]
        /* 0x605C */ public float FreighterHighlightRange;
        [NMS(Index = 672)]
        /* 0x6060 */ public float FreighterLeaderIconDistance;
        [NMS(Index = 86)]
        /* 0x6064 */ public float FreighterMegaWarpTransitionTime;
        [NMS(Index = 638)]
        /* 0x6068 */ public float FreighterSummonDelay;
        [NMS(Index = 641)]
        /* 0x606C */ public float FreighterSummonGridSize;
        [NMS(Index = 647)]
        /* 0x6070 */ public float FreighterSummonLookTime;
        [NMS(Index = 633)]
        /* 0x6074 */ public float FreighterSummonOffset;
        [NMS(Index = 634)]
        /* 0x6078 */ public float FreighterSummonOffsetPulse;
        [NMS(Index = 632)]
        /* 0x607C */ public float FreighterSummonPitch;
        [NMS(Index = 646)]
        /* 0x6080 */ public float FreighterSummonPlanetOffset;
        [NMS(Index = 645)]
        /* 0x6084 */ public float FreighterSummonPulseFadeAmount;
        [NMS(Index = 644)]
        /* 0x6088 */ public float FreighterSummonPulseRate;
        [NMS(Index = 631)]
        /* 0x608C */ public float FreighterSummonTurn;
        [NMS(Index = 640)]
        /* 0x6090 */ public float FreighterSummonTurnAngleIncrement;
        [NMS(Index = 639)]
        /* 0x6094 */ public int FreighterSummonTurnNumTries;
        [NMS(Index = 643)]
        /* 0x6098 */ public float FreighterSurfaceMinAngle;
        [NMS(Index = 671)]
        /* 0x609C */ public float FrigateDamageIconVisibilityDistance;
        [NMS(Index = 626)]
        /* 0x60A0 */ public float FrigateIconOffset;
        [NMS(Index = 670)]
        /* 0x60A4 */ public float FrigatePurchaseNotificationResetDistanceMultiplier;
        [NMS(Index = 1094)]
        /* 0x60A8 */ public float FrontendActivateSplit;
        [NMS(Index = 1093)]
        /* 0x60AC */ public float FrontendActivateTime;
        [NMS(Index = 1078)]
        /* 0x60B0 */ public float FrontendBGAlpha;
        [NMS(Index = 1098)]
        /* 0x60B4 */ public float FrontendBootBarTime;
        [NMS(Index = 1097)]
        /* 0x60B8 */ public float FrontendBootTime;
        [NMS(Index = 1082)]
        /* 0x60BC */ public float FrontendConfirmTime;
        [NMS(Index = 1080)]
        /* 0x60C0 */ public float FrontendConfirmTimeFast;
        [NMS(Index = 1079)]
        /* 0x60C4 */ public float FrontendConfirmTimeMouseMultiplier;
        [NMS(Index = 1083)]
        /* 0x60C8 */ public float FrontendConfirmTimeSlow;
        [NMS(Index = 1086)]
        /* 0x60CC */ public float FrontendCursorOffset;
        [NMS(Index = 1085)]
        /* 0x60D0 */ public float FrontendCursorSize;
        [NMS(Index = 1090)]
        /* 0x60D4 */ public float FrontendCursorWidth;
        [NMS(Index = 1092)]
        /* 0x60D8 */ public float FrontendDeactivateSplit;
        [NMS(Index = 1091)]
        /* 0x60DC */ public float FrontendDeactivateTime;
        [NMS(Index = 1173)]
        /* 0x60E0 */ public float FrontendDoFBlurMultiplier;
        [NMS(Index = 1172)]
        /* 0x60E4 */ public float FrontendDoFFarPlaneFadeMax;
        [NMS(Index = 1171)]
        /* 0x60E8 */ public float FrontendDoFFarPlaneFadeMin;
        [NMS(Index = 1170)]
        /* 0x60EC */ public float FrontendDoFFarPlaneMax;
        [NMS(Index = 1169)]
        /* 0x60F0 */ public float FrontendDoFFarPlaneMin;
        [NMS(Index = 1168)]
        /* 0x60F4 */ public float FrontendDoFNearPlaneMax;
        [NMS(Index = 1167)]
        /* 0x60F8 */ public float FrontendDoFNearPlaneMin;
        [NMS(Index = 170)]
        /* 0x60FC */ public float FrontendOffsetVR;
        [NMS(Index = 1176)]
        /* 0x6100 */ public float FrontendShineSpeed;
        [NMS(Index = 1095)]
        /* 0x6104 */ public float FrontendStatCircleWidth;
        [NMS(Index = 1096)]
        /* 0x6108 */ public float FrontendStatCircleWidthExtra;
        [NMS(Index = 1179)]
        /* 0x610C */ public float FrontendTitleFontSpacing;
        [NMS(Index = 1177)]
        /* 0x6110 */ public float FrontendToolbarTextHeight;
        [NMS(Index = 1178)]
        /* 0x6114 */ public float FrontendToolbarTextHeightSelected;
        [NMS(Index = 1081)]
        /* 0x6118 */ public float FrontendTouchConfirmTimeFastMultiplier;
        [NMS(Index = 572)]
        /* 0x611C */ public float FrontendWaitFadeProgressiveDialogOut;
        [NMS(Index = 571)]
        /* 0x6120 */ public float FrontendWaitFadeTextFrameOut;
        [NMS(Index = 570)]
        /* 0x6124 */ public float FrontendWaitFadeTextOut;
        [NMS(Index = 568)]
        /* 0x6128 */ public float FrontendWaitInitial;
        [NMS(Index = 569)]
        /* 0x612C */ public float FrontendWaitInitialTerminal;
        [NMS(Index = 567)]
        /* 0x6130 */ public float FrontendWaitResponse;
        [NMS(Index = 573)]
        /* 0x6134 */ public float FrontendWaitResponseOffset;
        [NMS(Index = 862)]
        /* 0x6138 */ public float GalaxyMapRadialBorder;
        [NMS(Index = 863)]
        /* 0x613C */ public float GalaxyMapRadialTargetDist;
        [NMS(Index = 169)]
        /* 0x6140 */ public float GalmapDiscoveryOffsetVR;
        [NMS(Index = 95)]
        /* 0x6144 */ public float GameModeSelectColourFadeTime;
        [NMS(Index = 78)]
        /* 0x6148 */ public float GridDecayRateSwitchValue;
        [NMS(Index = 556)]
        /* 0x614C */ public float GridFlickerAmp;
        [NMS(Index = 554)]
        /* 0x6150 */ public float GridFlickerBaseAlpha;
        [NMS(Index = 555)]
        /* 0x6154 */ public float GridFlickerFreq;
        [NMS(Index = 232)]
        /* 0x6158 */ public float HandButtonClickTime;
        [NMS(Index = 228)]
        /* 0x615C */ public float HandButtonCursorScale;
        [NMS(Index = 236)]
        /* 0x6160 */ public float HandButtonDotRadius;
        [NMS(Index = 234)]
        /* 0x6164 */ public float HandButtonFrontendCursorScale;
        [NMS(Index = 230)]
        /* 0x6168 */ public float HandButtonNearDistance;
        [NMS(Index = 225)]
        /* 0x616C */ public float HandButtonPostClickTime;
        [NMS(Index = 237)]
        /* 0x6170 */ public float HandButtonPulseRadius;
        [NMS(Index = 238)]
        /* 0x6174 */ public float HandButtonPulseThickness;
        [NMS(Index = 229)]
        /* 0x6178 */ public float HandButtonPushDistance;
        [NMS(Index = 221)]
        /* 0x617C */ public float HandButtonRadius;
        [NMS(Index = 231)]
        /* 0x6180 */ public float HandButtonRadiusClick;
        [NMS(Index = 222)]
        /* 0x6184 */ public float HandButtonRadiusTouch;
        [NMS(Index = 223)]
        /* 0x6188 */ public float HandButtonRadiusTouchNear;
        [NMS(Index = 224)]
        /* 0x618C */ public float HandButtonRadiusTouchNearActive;
        [NMS(Index = 226)]
        /* 0x6190 */ public float HandButtonReleaseThreshold;
        [NMS(Index = 227)]
        /* 0x6194 */ public float HandButtonReleaseThresholdInit;
        [NMS(Index = 235)]
        /* 0x6198 */ public float HandButtonThickness;
        [NMS(Index = 233)]
        /* 0x619C */ public float HandButtonTouchReturnTime;
        [NMS(Index = 258)]
        /* 0x61A0 */ public float HandControlButtonSize;
        [NMS(Index = 265)]
        /* 0x61A4 */ public float HandControlMenuAngle;
        [NMS(Index = 215)]
        /* 0x61A8 */ public float HandControlMenuCursorScale;
        [NMS(Index = 271)]
        /* 0x61AC */ public float HandControlMenuDepth;
        [NMS(Index = 264)]
        /* 0x61B0 */ public float HandControlMenuMoveActionDistance;
        [NMS(Index = 261)]
        /* 0x61B4 */ public float HandControlMenuMoveDistance;
        [NMS(Index = 262)]
        /* 0x61B8 */ public float HandControlMenuMoveDistanceScroll;
        [NMS(Index = 263)]
        /* 0x61BC */ public float HandControlMenuMoveDistanceVertical;
        [NMS(Index = 267)]
        /* 0x61C0 */ public float HandControlMenuSelectRadius;
        [NMS(Index = 268)]
        /* 0x61C4 */ public float HandControlMenuSelectRadius1;
        [NMS(Index = 269)]
        /* 0x61C8 */ public float HandControlMenuSelectRadius2;
        [NMS(Index = 266)]
        /* 0x61CC */ public float HandControlMenuSurfaceOffset;
        [NMS(Index = 260)]
        /* 0x61D0 */ public float HandControlPointActiveMargin;
        [NMS(Index = 259)]
        /* 0x61D4 */ public float HandControlPointMargin;
        [NMS(Index = 270)]
        /* 0x61D8 */ public float HandControlTopMenuSelectRadius;
        [NMS(Index = 120)]
        /* 0x61DC */ public float HandheldZoomFactor;
        [NMS(Index = 219)]
        /* 0x61E0 */ public float HandScreenGraphicsHeight;
        [NMS(Index = 218)]
        /* 0x61E4 */ public float HandScreenGraphicsWidth;
        [NMS(Index = 275)]
        /* 0x61E8 */ public int HandScreenHeight;
        [NMS(Index = 220)]
        /* 0x61EC */ public float HandScreenNearActivateDistance;
        [NMS(Index = 273)]
        /* 0x61F0 */ public int HandScreenWeaponHeight;
        [NMS(Index = 272)]
        /* 0x61F4 */ public int HandScreenWeaponWidth;
        [NMS(Index = 274)]
        /* 0x61F8 */ public int HandScreenWidth;
        [NMS(Index = 1165)]
        /* 0x61FC */ public float HatchAlphaBase;
        [NMS(Index = 1166)]
        /* 0x6200 */ public float HatchAlphaCursor;
        [NMS(Index = 1164)]
        /* 0x6204 */ public float HatchAlphaMain;
        [NMS(Index = 1162)]
        /* 0x6208 */ public int HatchCount;
        [NMS(Index = 1163)]
        /* 0x620C */ public float HatchCursorRadius;
        [NMS(Index = 1161)]
        /* 0x6210 */ public float HatchPulsePauseTime;
        [NMS(Index = 1159)]
        /* 0x6214 */ public float HatchPulseSpeed;
        [NMS(Index = 1160)]
        /* 0x6218 */ public float HatchPulseWidth;
        [NMS(Index = 656)]
        /* 0x621C */ public float HazardArrowsLevel2Threshold;
        [NMS(Index = 657)]
        /* 0x6220 */ public float HazardArrowsLevel3Threshold;
        [NMS(Index = 1009)]
        /* 0x6224 */ public float HazardBarPulseTime;
        [NMS(Index = 1014)]
        /* 0x6228 */ public float HazardPainPulseStrength;
        [NMS(Index = 1031)]
        /* 0x622C */ public float HazardPulseRate;
        [NMS(Index = 1006)]
        /* 0x6230 */ public float HazardScreenEffectPulseRate;
        [NMS(Index = 1010)]
        /* 0x6234 */ public float HazardScreenEffectPulseTime;
        [NMS(Index = 1011)]
        /* 0x6238 */ public float HazardScreenEffectStrength;
        [NMS(Index = 1013)]
        /* 0x623C */ public float HazardWarningPulseStrength;
        [NMS(Index = 1012)]
        /* 0x6240 */ public float HazardWarningPulseTime;
        [NMS(Index = 1189)]
        /* 0x6244 */ public float HitMarkerPulseSize;
        [NMS(Index = 1190)]
        /* 0x6248 */ public float HitMarkerPulseSizeStatic;
        [NMS(Index = 1191)]
        /* 0x624C */ public float HitMarkerPulseTime;
        [NMS(Index = 290)]
        /* 0x6250 */ public float HmdFramerateScreenPitch;
        [NMS(Index = 1002)]
        /* 0x6254 */ public float HoldTimerResetTime;
        [NMS(Index = 585)]
        /* 0x6258 */ public float HoverOffscreenBorder;
        [NMS(Index = 586)]
        /* 0x625C */ public float HoverOffscreenBorderXVR;
        [NMS(Index = 587)]
        /* 0x6260 */ public float HoverOffscreenBorderYAltUI;
        [NMS(Index = 39)]
        /* 0x6264 */ public float HoverPopAnimDuration;
        [NMS(Index = 38)]
        /* 0x6268 */ public float HoverPopScaleModification;
        [NMS(Index = 806)]
        /* 0x626C */ public float HUDDisplayTime;
        [NMS(Index = 752)]
        /* 0x6270 */ public float HUDDroneCombatPulse;
        [NMS(Index = 750)]
        /* 0x6274 */ public float HUDDroneHealingPulse;
        [NMS(Index = 751)]
        /* 0x6278 */ public float HUDDroneSummoningPulse;
        [NMS(Index = 940)]
        /* 0x627C */ public float HUDElementsOffsetHMDBottom;
        [NMS(Index = 938)]
        /* 0x6280 */ public float HUDElementsOffsetHMDSide;
        [NMS(Index = 939)]
        /* 0x6284 */ public float HUDElementsOffsetHMDTop;
        [NMS(Index = 941)]
        /* 0x6288 */ public float HUDElementsOffsetX_0;
        [NMS(Index = 943)]
        /* 0x628C */ public float HUDElementsOffsetX_1;
        [NMS(Index = 945)]
        /* 0x6290 */ public float HUDElementsOffsetX_2;
        [NMS(Index = 947)]
        /* 0x6294 */ public float HUDElementsOffsetX_3;
        [NMS(Index = 949)]
        /* 0x6298 */ public float HUDElementsOffsetX_4;
        [NMS(Index = 951)]
        /* 0x629C */ public float HUDElementsOffsetX_5;
        [NMS(Index = 942)]
        /* 0x62A0 */ public float HUDElementsOffsetY_0;
        [NMS(Index = 944)]
        /* 0x62A4 */ public float HUDElementsOffsetY_1;
        [NMS(Index = 946)]
        /* 0x62A8 */ public float HUDElementsOffsetY_2;
        [NMS(Index = 948)]
        /* 0x62AC */ public float HUDElementsOffsetY_3;
        [NMS(Index = 950)]
        /* 0x62B0 */ public float HUDElementsOffsetY_4;
        [NMS(Index = 952)]
        /* 0x62B4 */ public float HUDElementsOffsetY_5;
        [NMS(Index = 1322)]
        /* 0x62B8 */ public float HUDMarkerActiveTime;
        [NMS(Index = 1317)]
        /* 0x62BC */ public float HUDMarkerAlpha;
        [NMS(Index = 1292)]
        /* 0x62C0 */ public float HUDMarkerAnimLoopTime;
        [NMS(Index = 1291)]
        /* 0x62C4 */ public float HUDMarkerAnimOffset;
        [NMS(Index = 1290)]
        /* 0x62C8 */ public float HUDMarkerAnimScale;
        [NMS(Index = 1289)]
        /* 0x62CC */ public float HUDMarkerAnimSpeed;
        [NMS(Index = 451)]
        /* 0x62D0 */ public float HUDMarkerDistanceOrTimeDistance;
        [NMS(Index = 1310)]
        /* 0x62D4 */ public float HUDMarkerFarDistance;
        [NMS(Index = 1311)]
        /* 0x62D8 */ public float HUDMarkerFarFadeRange;
        [NMS(Index = 1316)]
        /* 0x62DC */ public float HUDMarkerHorizonBlendRange;
        [NMS(Index = 1298)]
        /* 0x62E0 */ public float HUDMarkerHoverAngleTestGround;
        [NMS(Index = 297)]
        /* 0x62E4 */ public float HUDMarkerHoverAngleTestGroundHmd;
        [NMS(Index = 1302)]
        /* 0x62E8 */ public float HUDMarkerHoverAngleTestShip;
        [NMS(Index = 1303)]
        /* 0x62EC */ public float HUDMarkerHoverShowLargeAngleTest;
        [NMS(Index = 1324)]
        /* 0x62F0 */ public float HUDMarkerIconHoverMinScale;
        [NMS(Index = 559)]
        /* 0x62F4 */ public float HUDMarkerLabelArriveDistance;
        [NMS(Index = 558)]
        /* 0x62F8 */ public float HUDMarkerLabelBaseWidth;
        [NMS(Index = 560)]
        /* 0x62FC */ public float HUDMarkerLabelDisplayDistance;
        [NMS(Index = 557)]
        /* 0x6300 */ public float HUDMarkerLabelWidthMultiplier;
        [NMS(Index = 1319)]
        /* 0x6304 */ public float HUDMarkerModelFadeMinHeight;
        [NMS(Index = 1318)]
        /* 0x6308 */ public float HUDMarkerModelFadeRange;
        [NMS(Index = 1308)]
        /* 0x630C */ public float HUDMarkerNearFadeDistance;
        [NMS(Index = 1309)]
        /* 0x6310 */ public float HUDMarkerNearFadeRange;
        [NMS(Index = 561)]
        /* 0x6314 */ public float HUDMarkerNonActiveMissionAlpha;
        [NMS(Index = 450)]
        /* 0x6318 */ public float HUDMarkerObjectMinScreenDistance;
        [NMS(Index = 1272)]
        /* 0x631C */ public float HUDMarkerOffset;
        [NMS(Index = 1295)]
        /* 0x6320 */ public float HUDMarkerPrimaryIndicatorSize;
        [NMS(Index = 1312)]
        /* 0x6324 */ public float HUDMarkerScalerMin;
        [NMS(Index = 1313)]
        /* 0x6328 */ public float HUDMarkerScalerRange;
        [NMS(Index = 1315)]
        /* 0x632C */ public float HUDMarkerScalerSizeMax;
        [NMS(Index = 1314)]
        /* 0x6330 */ public float HUDMarkerScalerSizeMin;
        [NMS(Index = 1306)]
        /* 0x6334 */ public float HUDMarkerShipOffsetMaxDist;
        [NMS(Index = 1307)]
        /* 0x6338 */ public float HUDMarkerShipOffsetMinDist;
        [NMS(Index = 1320)]
        /* 0x633C */ public float HUDMarkerShowActualIconDistance;
        [NMS(Index = 1321)]
        /* 0x6340 */ public float HUDMarkerShowActualSpaceIconDistance;
        [NMS(Index = 1301)]
        /* 0x6344 */ public float HUDMarkerWideHoverAngleTest;
        [NMS(Index = 298)]
        /* 0x6348 */ public float HUDMarkerWideHoverAngleTestHmd;
        [NMS(Index = 1300)]
        /* 0x634C */ public float HUDNetworkMarkerHoverAngleTestGround;
        [NMS(Index = 1305)]
        /* 0x6350 */ public float HUDNetworkMarkerHoverAngleVRMul;
        [NMS(Index = 1304)]
        /* 0x6354 */ public float HUDNetworkMarkerHoverShowLargeAngleTest;
        [NMS(Index = 1299)]
        /* 0x6358 */ public float HUDPetCentreScreenAngle;
        [NMS(Index = 1296)]
        /* 0x635C */ public float HUDPetMarkerAngleTest;
        [NMS(Index = 1297)]
        /* 0x6360 */ public float HUDPetMarkerAngleVRMul;
        [NMS(Index = 483)]
        /* 0x6364 */ public float HUDPlayerPhonePulseScanFreq;
        [NMS(Index = 482)]
        /* 0x6368 */ public float HUDPlayerSentinelPulseScanFreq;
        [NMS(Index = 480)]
        /* 0x636C */ public float HUDPlayerSentinelPulseWidth;
        [NMS(Index = 481)]
        /* 0x6370 */ public float HUDPlayerSentinelRangeFactor;
        [NMS(Index = 850)]
        /* 0x6374 */ public float HUDPlayerTrackArrowArrowSize;
        [NMS(Index = 819)]
        /* 0x6378 */ public float HUDPlayerTrackArrowDamageGlowHullHitCriticalOpacityScale;
        [NMS(Index = 820)]
        /* 0x637C */ public float HUDPlayerTrackArrowDamageGlowHullHitOpacityScale;
        [NMS(Index = 827)]
        /* 0x6380 */ public float HUDPlayerTrackArrowDamageGlowOffset;
        [NMS(Index = 823)]
        /* 0x6384 */ public float HUDPlayerTrackArrowDamageGlowShieldHitCriticalOpacityScale;
        [NMS(Index = 824)]
        /* 0x6388 */ public float HUDPlayerTrackArrowDamageGlowShieldHitOpacityScale;
        [NMS(Index = 851)]
        /* 0x638C */ public float HUDPlayerTrackArrowDotSize;
        [NMS(Index = 831)]
        /* 0x6390 */ public float HUDPlayerTrackArrowEnergyShieldDepletedGlowOpacityScale;
        [NMS(Index = 832)]
        /* 0x6394 */ public float HUDPlayerTrackArrowEnergyShieldDepletedTime;
        [NMS(Index = 829)]
        /* 0x6398 */ public float HUDPlayerTrackArrowEnergyShieldGlowOffset;
        [NMS(Index = 815)]
        /* 0x639C */ public float HUDPlayerTrackArrowEnergyShieldLowThreshold;
        [NMS(Index = 816)]
        /* 0x63A0 */ public float HUDPlayerTrackArrowEnergyShieldOffset;
        [NMS(Index = 836)]
        /* 0x63A4 */ public float HUDPlayerTrackArrowEnergyShieldStartChargeGlowOpacityScale;
        [NMS(Index = 837)]
        /* 0x63A8 */ public float HUDPlayerTrackArrowEnergyShieldStartChargeTime;
        [NMS(Index = 859)]
        /* 0x63AC */ public float HUDPlayerTrackArrowFadeRange;
        [NMS(Index = 818)]
        /* 0x63B0 */ public float HUDPlayerTrackArrowGlowBaseOpacity;
        [NMS(Index = 811)]
        /* 0x63B4 */ public float HUDPlayerTrackArrowHealthOffset;
        [NMS(Index = 778)]
        /* 0x63B8 */ public float HUDPlayerTrackArrowIconBorderReducerShip;
        [NMS(Index = 775)]
        /* 0x63BC */ public float HUDPlayerTrackArrowIconFadeDist;
        [NMS(Index = 774)]
        /* 0x63C0 */ public float HUDPlayerTrackArrowIconFadeDistDrone;
        [NMS(Index = 773)]
        /* 0x63C4 */ public float HUDPlayerTrackArrowIconFadeDistShip;
        [NMS(Index = 776)]
        /* 0x63C8 */ public float HUDPlayerTrackArrowIconFadeRange;
        [NMS(Index = 777)]
        /* 0x63CC */ public float HUDPlayerTrackArrowIconFadeRangeShip;
        [NMS(Index = 768)]
        /* 0x63D0 */ public float HUDPlayerTrackArrowIconFadeTime;
        [NMS(Index = 772)]
        /* 0x63D4 */ public float HUDPlayerTrackArrowIconPulse2Alpha;
        [NMS(Index = 766)]
        /* 0x63D8 */ public float HUDPlayerTrackArrowIconPulseTime;
        [NMS(Index = 770)]
        /* 0x63DC */ public float HUDPlayerTrackArrowIconPulseWidth1;
        [NMS(Index = 771)]
        /* 0x63E0 */ public float HUDPlayerTrackArrowIconPulseWidth2;
        [NMS(Index = 767)]
        /* 0x63E4 */ public float HUDPlayerTrackArrowIconShowTime;
        [NMS(Index = 848)]
        /* 0x63E8 */ public float HUDPlayerTrackArrowIconSize;
        [NMS(Index = 858)]
        /* 0x63EC */ public float HUDPlayerTrackArrowMinFadeDist;
        [NMS(Index = 843)]
        /* 0x63F0 */ public float HUDPlayerTrackArrowOffset;
        [NMS(Index = 779)]
        /* 0x63F4 */ public float HUDPlayerTrackArrowPulseOffset;
        [NMS(Index = 780)]
        /* 0x63F8 */ public float HUDPlayerTrackArrowPulseRate;
        [NMS(Index = 844)]
        /* 0x63FC */ public float HUDPlayerTrackArrowScreenBorder;
        [NMS(Index = 765)]
        /* 0x6400 */ public float HUDPlayerTrackArrowShipLabelOffset;
        [NMS(Index = 845)]
        /* 0x6404 */ public float HUDPlayerTrackArrowSize;
        [NMS(Index = 847)]
        /* 0x6408 */ public float HUDPlayerTrackArrowSizeMax;
        [NMS(Index = 846)]
        /* 0x640C */ public float HUDPlayerTrackArrowSizeMin;
        [NMS(Index = 849)]
        /* 0x6410 */ public float HUDPlayerTrackArrowSmallIconSize;
        [NMS(Index = 842)]
        /* 0x6414 */ public float HUDPlayerTrackArrowTargetDist;
        [NMS(Index = 841)]
        /* 0x6418 */ public float HUDPlayerTrackArrowTargetDistShip;
        [NMS(Index = 809)]
        /* 0x641C */ public float HUDPlayerTrackArrowTextHeight;
        [NMS(Index = 808)]
        /* 0x6420 */ public float HUDPlayerTrackArrowTextOffset;
        [NMS(Index = 807)]
        /* 0x6424 */ public float HUDPlayerTrackDangerPulse;
        [NMS(Index = 753)]
        /* 0x6428 */ public float HUDPlayerTrackNoSightPulse;
        [NMS(Index = 756)]
        /* 0x642C */ public float HUDPlayerTrackTimerEnd;
        [NMS(Index = 757)]
        /* 0x6430 */ public float HUDPlayerTrackTimerPulseRate;
        [NMS(Index = 754)]
        /* 0x6434 */ public float HUDPlayerTrackTimerStart;
        [NMS(Index = 755)]
        /* 0x6438 */ public float HUDPlayerTrackTimerStartFade;
        [NMS(Index = 1267)]
        /* 0x643C */ public float HUDTargetHealthDangerTime;
        [NMS(Index = 1266)]
        /* 0x6440 */ public float HUDTargetHealthIconSize;
        [NMS(Index = 1270)]
        /* 0x6444 */ public float HUDTargetIconOffset;
        [NMS(Index = 1271)]
        /* 0x6448 */ public float HUDTargetIconSize;
        [NMS(Index = 1268)]
        /* 0x644C */ public float HUDTargetMarkerOffset;
        [NMS(Index = 1269)]
        /* 0x6450 */ public float HUDTargetMarkerSize;
        [NMS(Index = 864)]
        /* 0x6454 */ public float IconBackgroundAlpha;
        [NMS(Index = 403)]
        /* 0x6458 */ public float IconGlowStrengthActive;
        [NMS(Index = 402)]
        /* 0x645C */ public float IconGlowStrengthError;
        [NMS(Index = 405)]
        /* 0x6460 */ public float IconGlowStrengthHighlight;
        [NMS(Index = 404)]
        /* 0x6464 */ public float IconGlowStrengthNeutral;
        [NMS(Index = 1041)]
        /* 0x6468 */ public float IconPulseRate;
        [NMS(Index = 1418)]
        /* 0x646C */ public float InfoPortalGuideCycleTime;
        [NMS(Index = 1419)]
        /* 0x6470 */ public float InfoPortalMilestonesCycleTime;
        [NMS(Index = 1062)]
        /* 0x6474 */ public float InteractionIconInnerRadius;
        [NMS(Index = 1063)]
        /* 0x6478 */ public float InteractionIconOuterRadius;
        [NMS(Index = 301)]
        /* 0x647C */ public float InteractionInWorldMinScreenDistance;
        [NMS(Index = 302)]
        /* 0x6480 */ public float InteractionInWorldMinScreenDistanceV2;
        [NMS(Index = 300)]
        /* 0x6484 */ public float InteractionInWorldPitchDistance;
        [NMS(Index = 303)]
        /* 0x6488 */ public float InteractionInWorldSeatedNPCHeightAdjust;
        [NMS(Index = 304)]
        /* 0x648C */ public float InteractionInWorldSeatedNPCHeightAdjustV2;
        [NMS(Index = 1060)]
        /* 0x6490 */ public float InteractionLabelHeight;
        [NMS(Index = 1053)]
        /* 0x6494 */ public float InteractionLabelHorizontalLineLength;
        [NMS(Index = 1061)]
        /* 0x6498 */ public float InteractionLabelLineAlpha;
        [NMS(Index = 1065)]
        /* 0x649C */ public float InteractionLabelPixelHeightMax;
        [NMS(Index = 1064)]
        /* 0x64A0 */ public float InteractionLabelPixelHeightMin;
        [NMS(Index = 1059)]
        /* 0x64A4 */ public float InteractionLabelRadiusScaler;
        [NMS(Index = 1067)]
        /* 0x64A8 */ public float InteractionLabelSpeedClose;
        [NMS(Index = 1066)]
        /* 0x64AC */ public float InteractionLabelSpeedOpen;
        [NMS(Index = 972)]
        /* 0x64B0 */ public float InteractionScanDisplayTime;
        [NMS(Index = 971)]
        /* 0x64B4 */ public float InteractionScanMinTime;
        [NMS(Index = 970)]
        /* 0x64B8 */ public float InteractionScanScanTime;
        [NMS(Index = 975)]
        /* 0x64BC */ public float InteractionScanSlapOverallTime;
        [NMS(Index = 974)]
        /* 0x64C0 */ public float InteractionScanSlapScale;
        [NMS(Index = 973)]
        /* 0x64C4 */ public float InteractionScanSlapTime;
        [NMS(Index = 1001)]
        /* 0x64C8 */ public float InventoryFullMessageRepeatTime;
        [NMS(Index = 924)]
        /* 0x64CC */ public float InventoryIconTime;
        [NMS(Index = 69)]
        /* 0x64D0 */ public float InvSlotGradientFactor;
        [NMS(Index = 68)]
        /* 0x64D4 */ public float InvSlotGradientFactorMin;
        [NMS(Index = 70)]
        /* 0x64D8 */ public float InvSlotGradientTime;
        [NMS(Index = 243)]
        /* 0x64DC */ public float InWorldInteractionScreenScale;
        [NMS(Index = 140)]
        /* 0x64E0 */ public float InWorldInteractLabelFarDistance;
        [NMS(Index = 141)]
        /* 0x64E4 */ public float InWorldInteractLabelFarRange;
        [NMS(Index = 196)]
        /* 0x64E8 */ public int InWorldInteractLabelHeight;
        [NMS(Index = 137)]
        /* 0x64EC */ public float InWorldInteractLabelMinHeadOffset;
        [NMS(Index = 138)]
        /* 0x64F0 */ public float InWorldInteractLabelNearDistance;
        [NMS(Index = 139)]
        /* 0x64F4 */ public float InWorldInteractLabelNearRange;
        [NMS(Index = 129)]
        /* 0x64F8 */ public float InWorldInteractLabelScale;
        [NMS(Index = 130)]
        /* 0x64FC */ public float InWorldInteractLabelScaleV2;
        [NMS(Index = 195)]
        /* 0x6500 */ public int InWorldInteractLabelWidth;
        [NMS(Index = 191)]
        /* 0x6504 */ public float InWorldNGuiScreenScale;
        [NMS(Index = 244)]
        /* 0x6508 */ public float InWorldNPCInteractionScreenScale;
        [NMS(Index = 190)]
        /* 0x650C */ public float InWorldScreenForwardOffset;
        [NMS(Index = 189)]
        /* 0x6510 */ public float InWorldScreenMinScreenDistance;
        [NMS(Index = 131)]
        /* 0x6514 */ public float InWorldScreenScaleDistance;
        [NMS(Index = 42)]
        /* 0x6518 */ public float InWorldUIInteractionDistanceWithEyeTrackingEnabled;
        [NMS(Index = 927)]
        /* 0x651C */ public float ItemReceivedMessageTimeToAdd;
        [NMS(Index = 965)]
        /* 0x6520 */ public float ItemSlotColourTechChargeRate;
        [NMS(Index = 1007)]
        /* 0x6524 */ public float KeepHazardBarActiveTime;
        [NMS(Index = 1008)]
        /* 0x6528 */ public float KeepSecondHazardBarActiveTime;
        [NMS(Index = 902)]
        /* 0x652C */ public float LandNotifyHeightThreshold;
        [NMS(Index = 901)]
        /* 0x6530 */ public float LandNotifySpeedThreshold;
        [NMS(Index = 903)]
        /* 0x6534 */ public float LandNotifyTimeThreshold;
        [NMS(Index = 719)]
        /* 0x6538 */ public float LargeSpaceIconSize;
        [NMS(Index = 341)]
        /* 0x653C */ public float LoadFadeInDefaultTime;
        [NMS(Index = 124)]
        /* 0x6540 */ public float LoadingScreenTime;
        [NMS(Index = 123)]
        /* 0x6544 */ public float LoadingScreenTravelSpeed;
        [NMS(Index = 122)]
        /* 0x6548 */ public float LoadingTravelDistance;
        [NMS(Index = 1336)]
        /* 0x654C */ public float LockOnMarkerSize;
        [NMS(Index = 1337)]
        /* 0x6550 */ public float LockOnMarkerSizeLock;
        [NMS(Index = 187)]
        /* 0x6554 */ public float LowerHelmetScreenPitch;
        [NMS(Index = 186)]
        /* 0x6558 */ public float LowerHelmetScreenScale;
        [NMS(Index = 501)]
        /* 0x655C */ public float LowHealthShieldFactor;
        [NMS(Index = 500)]
        /* 0x6560 */ public float LowHealthShieldMin;
        [NMS(Index = 454)]
        /* 0x6564 */ public float MaintenanceIconFadeStart;
        [NMS(Index = 455)]
        /* 0x6568 */ public float MaintenanceIconFadeTime;
        [NMS(Index = 922)]
        /* 0x656C */ public float ManualNotificationPauseTime;
        [NMS(Index = 1417)]
        /* 0x6570 */ public float ManualScrollChangePerInputMax;
        [NMS(Index = 1416)]
        /* 0x6574 */ public float ManualScrollChangePerInputMin;
        [NMS(Index = 452)]
        /* 0x6578 */ public float MarkerComponentOffset;
        [NMS(Index = 351)]
        /* 0x657C */ public float MarkerHorizonApproachAngle;
        [NMS(Index = 350)]
        /* 0x6580 */ public float MarkerHorizonMinOffset;
        [NMS(Index = 357)]
        /* 0x6584 */ public float MarkerHorizonOffPlanetLightBeamAngle;
        [NMS(Index = 349)]
        /* 0x6588 */ public float MarkerHorizonOffsetAngle;
        [NMS(Index = 358)]
        /* 0x658C */ public float MarkerHorizonShipApproachOffset;
        [NMS(Index = 352)]
        /* 0x6590 */ public float MarkerOffsetTypeAngle;
        [NMS(Index = 356)]
        /* 0x6594 */ public float MarkerOffsetTypeAngleAsteroid;
        [NMS(Index = 353)]
        /* 0x6598 */ public float MarkerOffsetTypeAngleBattle;
        [NMS(Index = 354)]
        /* 0x659C */ public float MarkerOffsetTypeAngleBounty;
        [NMS(Index = 355)]
        /* 0x65A0 */ public float MarkerOffsetTypeAnglePlayerShip;
        [NMS(Index = 438)]
        /* 0x65A4 */ public float MarkerRingInnerRadius;
        [NMS(Index = 439)]
        /* 0x65A8 */ public float MarkerRingOuterRadius;
        [NMS(Index = 367)]
        /* 0x65AC */ public float MarkerTagAppearDelay;
        [NMS(Index = 504)]
        /* 0x65B0 */ public int MaxDialogCharSizeIdeographic;
        [NMS(Index = 502)]
        /* 0x65B4 */ public int MaxDialogCharSizeRoman;
        [NMS(Index = 362)]
        /* 0x65B8 */ public int MaxNumMessageBeaconIcons;
        [NMS(Index = 172)]
        /* 0x65BC */ public float MaxProjectorDistanceFromDefault;
        [NMS(Index = 175)]
        /* 0x65C0 */ public float MaxProjectorGrabDistance;
        [NMS(Index = 82)]
        /* 0x65C4 */ public int MaxSubstanceMaxAmountForAmountFraction;
        [NMS(Index = 925)]
        /* 0x65C8 */ public float MessageNotificationTime;
        [NMS(Index = 926)]
        /* 0x65CC */ public float MessageTimeQuick;
        [NMS(Index = 105)]
        /* 0x65D0 */ public float MilestoneStingDisplayTime;
        [NMS(Index = 1411)]
        /* 0x65D4 */ public float MinimumHoldFill;
        [NMS(Index = 103)]
        /* 0x65D8 */ public float MinSeasonPlayTimeInDays;
        [NMS(Index = 732)]
        /* 0x65DC */ public float MissileCentreOffset;
        [NMS(Index = 1342)]
        /* 0x65E0 */ public float MissileIconAttackPulseAmount;
        [NMS(Index = 1341)]
        /* 0x65E4 */ public float MissileIconAttackPulseTime;
        [NMS(Index = 713)]
        /* 0x65E8 */ public float MissionCompassIconScaler;
        [NMS(Index = 366)]
        /* 0x65EC */ public float MissionDetailsPageBaseHeight;
        [NMS(Index = 530)]
        /* 0x65F0 */ public int MissionLoopCount;
        [NMS(Index = 531)]
        /* 0x65F4 */ public int MissionLoopCountPirate;
        [NMS(Index = 714)]
        /* 0x65F8 */ public float MissionMarkerSize;
        [NMS(Index = 363)]
        /* 0x65FC */ public float MissionObjectiveBaseHeight;
        [NMS(Index = 364)]
        /* 0x6600 */ public float MissionObjectiveDoneHeight;
        [NMS(Index = 365)]
        /* 0x6604 */ public float MissionObjectiveScrollingExtra;
        [NMS(Index = 532)]
        /* 0x6608 */ public int MissionSeedOffset;
        [NMS(Index = 529)]
        /* 0x660C */ public int MissionSpecificMissionPercent;
        [NMS(Index = 513)]
        /* 0x6610 */ public float MissionStartEndOSDTime;
        [NMS(Index = 514)]
        /* 0x6614 */ public float MissionStartEndOSDTimeProcedural;
        [NMS(Index = 512)]
        /* 0x6618 */ public float MissionStartEndTime;
        [NMS(Index = 37)]
        /* 0x661C */ public float ModularCustomisationApplyTime;
        [NMS(Index = 1425)]
        /* 0x6620 */ public float MouseRotateCameraSensitivity;
        [NMS(Index = 1397)]
        /* 0x6624 */ public float MultiplayerTeleportEffectAppearTime;
        [NMS(Index = 1396)]
        /* 0x6628 */ public float MultiplayerTeleportEffectDisappearTime;
        [NMS(Index = 1362)]
        /* 0x662C */ public float NGuiActiveAreaOffsetTime;
        [NMS(Index = 1353)]
        /* 0x6630 */ public float NGuiAltPlacementDistanceScrollSpeed;
        [NMS(Index = 1361)]
        /* 0x6634 */ public float NGuiCursorOffsetMultiplier;
        [NMS(Index = 289)]
        /* 0x6638 */ public float NGuiHmdOffset;
        [NMS(Index = 1343)]
        /* 0x663C */ public float NGuiModelRotationDegreesX;
        [NMS(Index = 1344)]
        /* 0x6640 */ public float NGuiModelRotationDegreesY;
        [NMS(Index = 1345)]
        /* 0x6644 */ public float NGuiModelRotationDegreesZ;
        [NMS(Index = 1352)]
        /* 0x6648 */ public float NGuiModelViewCdSmoothTime;
        [NMS(Index = 1350)]
        /* 0x664C */ public float NGuiModelViewDistanceDiscoveryPage;
        [NMS(Index = 1346)]
        /* 0x6650 */ public float NGuiModelViewDistanceGlobal;
        [NMS(Index = 1349)]
        /* 0x6654 */ public float NGuiModelViewDistanceShipPage;
        [NMS(Index = 1347)]
        /* 0x6658 */ public float NGuiModelViewDistanceSuitPage;
        [NMS(Index = 1348)]
        /* 0x665C */ public float NGuiModelViewDistanceWeaponPage;
        [NMS(Index = 1370)]
        /* 0x6660 */ public float NGuiModelViewFadeInAfterRenderTime;
        [NMS(Index = 1351)]
        /* 0x6664 */ public float NGuiModelViewFov;
        [NMS(Index = 1355)]
        /* 0x6668 */ public float NGuiModelViewFractionOfBBHeightAboveReflectivePlane;
        [NMS(Index = 1181)]
        /* 0x666C */ public float NGuiMouseSensitivity;
        [NMS(Index = 1180)]
        /* 0x6670 */ public float NGuiPadSensitivity;
        [NMS(Index = 1354)]
        /* 0x6674 */ public float NGuiPlacementAngleScrollSpeed;
        [NMS(Index = 1359)]
        /* 0x6678 */ public float NGuiThumbnailModelRotationDegreesY;
        [NMS(Index = 1360)]
        /* 0x667C */ public float NGuiThumbnailModelViewDistance;
        [NMS(Index = 877)]
        /* 0x6680 */ public float NotificationBackgroundGradientAlphaInShip;
        [NMS(Index = 876)]
        /* 0x6684 */ public float NotificationBackgroundGradientEndOffsetPercentInShip;
        [NMS(Index = 910)]
        /* 0x6688 */ public float NotificationBridgeReachDistance;
        [NMS(Index = 884)]
        /* 0x668C */ public float NotificationBuildHintStartTime;
        [NMS(Index = 889)]
        /* 0x6690 */ public float NotificationCantFireTime;
        [NMS(Index = 890)]
        /* 0x6694 */ public float NotificationDangerTime;
        [NMS(Index = 915)]
        /* 0x6698 */ public float NotificationDeviceIdleTime;
        [NMS(Index = 911)]
        /* 0x669C */ public float NotificationDiscoveryIdleTime;
        [NMS(Index = 908)]
        /* 0x66A0 */ public float NotificationFinalMissionWait;
        [NMS(Index = 906)]
        /* 0x66A4 */ public float NotificationGoToSpaceStationWait;
        [NMS(Index = 340)]
        /* 0x66A8 */ public float NotificationHazardMinTimeAfterRecharge;
        [NMS(Index = 881)]
        /* 0x66AC */ public float NotificationHazardSafeThreshold;
        [NMS(Index = 882)]
        /* 0x66B0 */ public float NotificationHazardTimer;
        [NMS(Index = 912)]
        /* 0x66B4 */ public float NotificationInfoIdleTime;
        [NMS(Index = 883)]
        /* 0x66B8 */ public float NotificationInteractHintStartTime;
        [NMS(Index = 885)]
        /* 0x66BC */ public float NotificationJetpackTime;
        [NMS(Index = 894)]
        /* 0x66C0 */ public float NotificationMaxPageHintTime;
        [NMS(Index = 893)]
        /* 0x66C4 */ public float NotificationMessageCycleTime;
        [NMS(Index = 880)]
        /* 0x66C8 */ public float NotificationMinVisibleTime;
        [NMS(Index = 916)]
        /* 0x66CC */ public float NotificationMissionHintTime;
        [NMS(Index = 917)]
        /* 0x66D0 */ public float NotificationMissionHintTimeCritical;
        [NMS(Index = 918)]
        /* 0x66D4 */ public float NotificationMissionHintTimeSecondary;
        [NMS(Index = 907)]
        /* 0x66D8 */ public float NotificationMonolithMissionWait;
        [NMS(Index = 913)]
        /* 0x66DC */ public float NotificationNewTechIdleTime;
        [NMS(Index = 914)]
        /* 0x66E0 */ public float NotificationScanEventMissionIdleTime;
        [NMS(Index = 891)]
        /* 0x66E4 */ public float NotificationScanTime;
        [NMS(Index = 892)]
        /* 0x66E8 */ public float NotificationScanTimeCutoff;
        [NMS(Index = 886)]
        /* 0x66EC */ public float NotificationShieldTime;
        [NMS(Index = 898)]
        /* 0x66F0 */ public float NotificationShipBoostMinTime;
        [NMS(Index = 899)]
        /* 0x66F4 */ public float NotificationShipBoostReminderTime;
        [NMS(Index = 900)]
        /* 0x66F8 */ public float NotificationShipBoostReminderTimeTutorial;
        [NMS(Index = 887)]
        /* 0x66FC */ public float NotificationShipBoostTime;
        [NMS(Index = 888)]
        /* 0x6700 */ public float NotificationShipBoostTimeVR;
        [NMS(Index = 895)]
        /* 0x6704 */ public float NotificationShipJumpMinTime;
        [NMS(Index = 896)]
        /* 0x6708 */ public float NotificationShipJumpReminderTime;
        [NMS(Index = 897)]
        /* 0x670C */ public float NotificationShipJumpReminderTutorial;
        [NMS(Index = 878)]
        /* 0x6710 */ public int NotificationsResourceExtractHintCount;
        [NMS(Index = 879)]
        /* 0x6714 */ public float NotificationStaminaHintDistanceWalked;
        [NMS(Index = 904)]
        /* 0x6718 */ public float NotificationTimeBeforeHeridiumMarker;
        [NMS(Index = 905)]
        /* 0x671C */ public float NotificationUrgentMessageTime;
        [NMS(Index = 909)]
        /* 0x6720 */ public float NotificationWaypointReachDistance;
        [NMS(Index = 802)]
        /* 0x6724 */ public int NumDeathQuotes;
        [NMS(Index = 524)]
        /* 0x6728 */ public float OnFootDamageDirectionIndicatorFadeRange;
        [NMS(Index = 523)]
        /* 0x672C */ public float OnFootDamageDirectionIndicatorRadius;
        [NMS(Index = 125)]
        /* 0x6730 */ public float OSDMessagePauseOffscreenAngle;
        [NMS(Index = 329)]
        /* 0x6734 */ public int OSDMessageQueueMax;
        [NMS(Index = 328)]
        /* 0x6738 */ public int OSDMessageQueueMin;
        [NMS(Index = 327)]
        /* 0x673C */ public float OSDMessageQueueSpeedMultiplier;
        [NMS(Index = 1076)]
        /* 0x6740 */ public float PadCursorAcceleration;
        [NMS(Index = 1077)]
        /* 0x6744 */ public float PadCursorMaxSpeedModifier;
        [NMS(Index = 79)]
        /* 0x6748 */ public float PadCursorUICurveStrength;
        [NMS(Index = 1424)]
        /* 0x674C */ public float PadRotateCameraSensitivity;
        [NMS(Index = 497)]
        /* 0x6750 */ public float PageTurnTime;
        [NMS(Index = 93)]
        /* 0x6754 */ public float ParagraphAutoScrollSpeed;
        [NMS(Index = 954)]
        /* 0x6758 */ public float PauseMenuHoldTime;
        [NMS(Index = 721)]
        /* 0x675C */ public float PetHoverIconSize;
        [NMS(Index = 147)]
        /* 0x6760 */ public float PetHUDMarkerExtraFollowInfoDistance;
        [NMS(Index = 148)]
        /* 0x6764 */ public float PetHUDMarkerHideDistance;
        [NMS(Index = 149)]
        /* 0x6768 */ public float PetHUDMarkerHideDistanceShort;
        [NMS(Index = 150)]
        /* 0x676C */ public float PetHUDMarkerOffset;
        [NMS(Index = 722)]
        /* 0x6770 */ public float PetIconSize;
        [NMS(Index = 151)]
        /* 0x6774 */ public float PetMoodMarkerOffset;
        [NMS(Index = 146)]
        /* 0x6778 */ public float PetSlotUnlockBounceTime;
        [NMS(Index = 625)]
        /* 0x677C */ public float PhotoModeTimeofDayChange;
        [NMS(Index = 624)]
        /* 0x6780 */ public float PhotoModeValueAlpha;
        [NMS(Index = 654)]
        /* 0x6784 */ public float PirateAttackIndicatorRadius;
        [NMS(Index = 653)]
        /* 0x6788 */ public float PirateAttackIndicatorWidth;
        [NMS(Index = 655)]
        /* 0x678C */ public float PirateAttackProbeDisplayFinishFactor;
        [NMS(Index = 652)]
        /* 0x6790 */ public float PirateCountdownTime;
        [NMS(Index = 637)]
        /* 0x6794 */ public float PirateFreighterSummonAtOffset;
        [NMS(Index = 635)]
        /* 0x6798 */ public float PirateFreighterSummonOffset;
        [NMS(Index = 636)]
        /* 0x679C */ public float PirateFreighterSummonOffsetPulse;
        [NMS(Index = 121)]
        /* 0x67A0 */ public float PlacedMarkerFadeTime;
        [NMS(Index = 113)]
        /* 0x67A4 */ public float PlanetDataExtraRadius;
        [NMS(Index = 959)]
        /* 0x67A8 */ public float PlanetLabelAngle;
        [NMS(Index = 958)]
        /* 0x67AC */ public float PlanetLabelTime;
        [NMS(Index = 1194)]
        /* 0x67B0 */ public float PlanetPoleMaxDotProduct;
        [NMS(Index = 495)]
        /* 0x67B4 */ public float PlanetRaidMarkerOffset;
        [NMS(Index = 667)]
        /* 0x67B8 */ public float PlanetScanDelayTime;
        [NMS(Index = 1101)]
        /* 0x67BC */ public float PopupActivateTime;
        [NMS(Index = 1102)]
        /* 0x67C0 */ public float PopupDeactivateTime;
        [NMS(Index = 1100)]
        /* 0x67C4 */ public float PopupDebounceTime;
        [NMS(Index = 1089)]
        /* 0x67C8 */ public float PopupSlotWidthOffset;
        [NMS(Index = 330)]
        /* 0x67CC */ public float PopupValueSectionBaseHeight;
        [NMS(Index = 331)]
        /* 0x67D0 */ public float PopupValueSectionHeight;
        [NMS(Index = 1087)]
        /* 0x67D4 */ public float PopupXClampOffset;
        [NMS(Index = 1088)]
        /* 0x67D8 */ public float PopupXClampOffsetRightAligned;
        [NMS(Index = 177)]
        /* 0x67DC */ public float ProjectorGrabBorderPercent;
        [NMS(Index = 176)]
        /* 0x67E0 */ public float ProjectorGrabDistanceBias;
        [NMS(Index = 173)]
        /* 0x67E4 */ public float ProjectorGrabResetTime;
        [NMS(Index = 171)]
        /* 0x67E8 */ public float ProjectorScale;
        [NMS(Index = 217)]
        /* 0x67EC */ public float QuickMenuAlpha;
        [NMS(Index = 126)]
        /* 0x67F0 */ public float QuickMenuCentrePos;
        [NMS(Index = 128)]
        /* 0x67F4 */ public float QuickMenuCentreSideOffset;
        [NMS(Index = 565)]
        /* 0x67F8 */ public float QuickMenuCloseTime;
        [NMS(Index = 216)]
        /* 0x67FC */ public float QuickMenuCursorScale;
        [NMS(Index = 566)]
        /* 0x6800 */ public float QuickMenuErrorTime;
        [NMS(Index = 256)]
        /* 0x6804 */ public float QuickMenuHighlightRate;
        [NMS(Index = 257)]
        /* 0x6808 */ public float QuickMenuHoldNavTime;
        [NMS(Index = 252)]
        /* 0x680C */ public float QuickMenuInteractAdjustX;
        [NMS(Index = 253)]
        /* 0x6810 */ public float QuickMenuInteractAdjustY;
        [NMS(Index = 255)]
        /* 0x6814 */ public int QuickMenuScreenHeight;
        [NMS(Index = 254)]
        /* 0x6818 */ public int QuickMenuScreenWidth;
        [NMS(Index = 127)]
        /* 0x681C */ public float QuickMenuSideOffset;
        [NMS(Index = 248)]
        /* 0x6820 */ public float QuickMenuSwipeHeightMax;
        [NMS(Index = 247)]
        /* 0x6824 */ public float QuickMenuSwipeHeightMin;
        [NMS(Index = 1156)]
        /* 0x6828 */ public float RadialMenuInnerRadius;
        [NMS(Index = 1157)]
        /* 0x682C */ public float RadialMenuInnerRadiusCursor;
        [NMS(Index = 1158)]
        /* 0x6830 */ public float RadialMenuWedgeOffset;
        [NMS(Index = 484)]
        /* 0x6834 */ public float RefinerAutoCloseTime;
        [NMS(Index = 472)]
        /* 0x6838 */ public float RefinerBeginDialInnerRadius;
        [NMS(Index = 471)]
        /* 0x683C */ public float RefinerPadStartDecayTime;
        [NMS(Index = 470)]
        /* 0x6840 */ public float RefinerPadStartTime;
        [NMS(Index = 473)]
        /* 0x6844 */ public float RefinerProgressDialInnerRadius;
        [NMS(Index = 453)]
        /* 0x6848 */ public float RepairTechLabelOffset;
        [NMS(Index = 443)]
        /* 0x684C */ public float RepairTechRepairedMessageTime;
        [NMS(Index = 441)]
        /* 0x6850 */ public float RepairTechRepairedWaitTime1;
        [NMS(Index = 442)]
        /* 0x6854 */ public float RepairTechRepairedWaitTime2;
        [NMS(Index = 1387)]
        /* 0x6858 */ public float ReportBaseFlashDelay;
        [NMS(Index = 1386)]
        /* 0x685C */ public float ReportBaseFlashIntensity;
        [NMS(Index = 1385)]
        /* 0x6860 */ public float ReportBaseFlashTime;
        [NMS(Index = 1388)]
        /* 0x6864 */ public float ReportCameraSpeed;
        [NMS(Index = 790)]
        /* 0x6868 */ public float ScanEventArrowOffsetMultiplier;
        [NMS(Index = 792)]
        /* 0x686C */ public float ScanEventArrowOffsetMultiplierFresh;
        [NMS(Index = 793)]
        /* 0x6870 */ public float ScanEventArrowOffsetMultiplierLerpTime;
        [NMS(Index = 791)]
        /* 0x6874 */ public float ScanEventArrowOffsetMultiplierOneEvent;
        [NMS(Index = 789)]
        /* 0x6878 */ public float ScanEventArrowPlayerFadeDistance;
        [NMS(Index = 788)]
        /* 0x687C */ public float ScanEventArrowPlayerFadeRange;
        [NMS(Index = 794)]
        /* 0x6880 */ public float ScanEventArrowSecondaryAlpha;
        [NMS(Index = 787)]
        /* 0x6884 */ public float ScanEventArrowShipFadeDistance;
        [NMS(Index = 786)]
        /* 0x6888 */ public float ScanEventArrowShipFadeRange;
        [NMS(Index = 795)]
        /* 0x688C */ public GcAudioWwiseEvents ScanEventIconAudio;
        [NMS(Index = 360)]
        /* 0x6890 */ public float ScannableIconMergeAngle;
        [NMS(Index = 1068)]
        /* 0x6894 */ public float ScanTime;
        [NMS(Index = 102)]
        /* 0x6898 */ public float SeasonalRingChangeTime;
        [NMS(Index = 100)]
        /* 0x689C */ public float SeasonalRingMultiplier;
        [NMS(Index = 101)]
        /* 0x68A0 */ public float SeasonalRingPulseTime;
        [NMS(Index = 35)]
        /* 0x68A4 */ public float SeasonEndAutoHighlightDuration;
        [NMS(Index = 36)]
        /* 0x68A8 */ public float SeasonEndAutoHighlightDurationMilestone;
        [NMS(Index = 34)]
        /* 0x68AC */ public GcAudioWwiseEvents SeasonEndAutoHighlightSFX;
        [NMS(Index = 33)]
        /* 0x68B0 */ public float SeasonEndRewardsMaxScrollRate;
        [NMS(Index = 32)]
        /* 0x68B4 */ public float SeasonEndRewardsPageOpenDelayTime;
        [NMS(Index = 98)]
        /* 0x68B8 */ public int SeasonFinalStageIndex;
        [NMS(Index = 874)]
        /* 0x68BC */ public float SeasonMessageDelayTime;
        [NMS(Index = 91)]
        /* 0x68C0 */ public float SentinelsDisabledHUDMessageTime;
        [NMS(Index = 1402)]
        /* 0x68C4 */ public float SettlementStatInnerRadius;
        [NMS(Index = 1403)]
        /* 0x68C8 */ public float SettlementStatOuterRadius;
        [NMS(Index = 1017)]
        /* 0x68CC */ public float ShieldHazardPulseRate;
        [NMS(Index = 1019)]
        /* 0x68D0 */ public float ShieldHazardPulseThreshold;
        [NMS(Index = 1016)]
        /* 0x68D4 */ public float ShieldPulseTime;
        [NMS(Index = 1015)]
        /* 0x68D8 */ public float ShieldSpringTime;
        [NMS(Index = 1)]
        /* 0x68DC */ public float ShipBuilderBarTime;
        [NMS(Index = 8)]
        /* 0x68E0 */ public float ShipBuilderEndCircleRadius;
        [NMS(Index = 12)]
        /* 0x68E4 */ public float ShipBuilderLineLengthFadeMax;
        [NMS(Index = 11)]
        /* 0x68E8 */ public float ShipBuilderLineLengthFadeMin;
        [NMS(Index = 10)]
        /* 0x68EC */ public float ShipBuilderLineMinFade;
        [NMS(Index = 9)]
        /* 0x68F0 */ public float ShipBuilderLineWidth;
        [NMS(Index = 6)]
        /* 0x68F4 */ public float ShipBuilderSlotDropLength;
        [NMS(Index = 2)]
        /* 0x68F8 */ public float ShipBuilderSlotLineDefaultWidthFactor;
        [NMS(Index = 4)]
        /* 0x68FC */ public float ShipBuilderSlotLineMaxFactor;
        [NMS(Index = 3)]
        /* 0x6900 */ public float ShipBuilderSlotLineMinFactor;
        [NMS(Index = 5)]
        /* 0x6904 */ public float ShipBuilderSlotStartOffset;
        [NMS(Index = 7)]
        /* 0x6908 */ public float ShipBuilderStartCircleRadius;
        [NMS(Index = 522)]
        /* 0x690C */ public float ShipDamageDirectionIndicatorFadeRange;
        [NMS(Index = 521)]
        /* 0x6910 */ public float ShipDamageDirectionIndicatorRadius;
        [NMS(Index = 784)]
        /* 0x6914 */ public float ShipDesatDamper;
        [NMS(Index = 783)]
        /* 0x6918 */ public float ShipFullscreenDamper;
        [NMS(Index = 782)]
        /* 0x691C */ public float ShipFullscreenDamperMin;
        [NMS(Index = 674)]
        /* 0x6920 */ public float ShipHeadsUpDisplayDistance;
        [NMS(Index = 675)]
        /* 0x6924 */ public float ShipHeadsUpLineFadeTime;
        [NMS(Index = 305)]
        /* 0x6928 */ public float ShipHologramInWorldUIHeightAdjust;
        [NMS(Index = 306)]
        /* 0x692C */ public float ShipHologramInWorldUIHeightAdjustV2;
        [NMS(Index = 997)]
        /* 0x6930 */ public float ShipHUDHitPointSize;
        [NMS(Index = 996)]
        /* 0x6934 */ public float ShipHUDHitPointTime;
        [NMS(Index = 142)]
        /* 0x6938 */ public float ShipHUDMarkerHideDistance;
        [NMS(Index = 143)]
        /* 0x693C */ public float ShipHUDMarkerOffset;
        [NMS(Index = 981)]
        /* 0x6940 */ public float ShipHUDMaxOffscreenTargetDist;
        [NMS(Index = 978)]
        /* 0x6944 */ public float ShipHUDMissileLockSizeMax;
        [NMS(Index = 977)]
        /* 0x6948 */ public float ShipHUDMissileLockSizeMin;
        [NMS(Index = 980)]
        /* 0x694C */ public float ShipHUDMissileLockSpringFast;
        [NMS(Index = 979)]
        /* 0x6950 */ public float ShipHUDMissileLockSpringSlow;
        [NMS(Index = 984)]
        /* 0x6954 */ public float ShipHUDTargetAlpha;
        [NMS(Index = 985)]
        /* 0x6958 */ public float ShipHUDTargetArrowLength;
        [NMS(Index = 989)]
        /* 0x695C */ public float ShipHUDTargetArrowsRotationRate;
        [NMS(Index = 986)]
        /* 0x6960 */ public float ShipHUDTargetMinDist;
        [NMS(Index = 982)]
        /* 0x6964 */ public float ShipHUDTargetRadius;
        [NMS(Index = 987)]
        /* 0x6968 */ public float ShipHUDTargetRange;
        [NMS(Index = 988)]
        /* 0x696C */ public float ShipHUDTargetScale;
        [NMS(Index = 983)]
        /* 0x6970 */ public float ShipHUDTargetTriangleRadius;
        [NMS(Index = 507)]
        /* 0x6974 */ public float ShipOverheatSwitchMessageTime;
        [NMS(Index = 506)]
        /* 0x6978 */ public float ShipOverheatSwitchMessageWait;
        [NMS(Index = 1395)]
        /* 0x697C */ public float ShipScreenTexScale;
        [NMS(Index = 239)]
        /* 0x6980 */ public float ShipSideScreenHeight;
        [NMS(Index = 307)]
        /* 0x6984 */ public float ShopInteractionInWorldForcedOffset;
        [NMS(Index = 308)]
        /* 0x6988 */ public float ShopInteractionInWorldForcedOffsetV2;
        [NMS(Index = 109)]
        /* 0x698C */ public int ShowDaysIfLessThan;
        [NMS(Index = 108)]
        /* 0x6990 */ public int ShowHoursIfLessThan;
        [NMS(Index = 110)]
        /* 0x6994 */ public int ShowWeeksIfLessThan;
        [NMS(Index = 720)]
        /* 0x6998 */ public float SmallSpaceIconSize;
        [NMS(Index = 241)]
        /* 0x699C */ public float SolidPointerLengthScale;
        [NMS(Index = 242)]
        /* 0x69A0 */ public float SolidPointerMaxLength;
        [NMS(Index = 240)]
        /* 0x69A4 */ public float SolidPointerScale;
        [NMS(Index = 1228)]
        /* 0x69A8 */ public float SpaceMapActionScale;
        [NMS(Index = 1224)]
        /* 0x69AC */ public float SpaceMapAnomalyScale;
        [NMS(Index = 1214)]
        /* 0x69B0 */ public float SpaceMapAspectRatio;
        [NMS(Index = 1240)]
        /* 0x69B4 */ public float SpaceMapCamAngle;
        [NMS(Index = 1241)]
        /* 0x69B8 */ public float SpaceMapCamDistance;
        [NMS(Index = 1239)]
        /* 0x69BC */ public float SpaceMapCamHeight;
        [NMS(Index = 543)]
        /* 0x69C0 */ public float SpaceMapCockpitAngle;
        [NMS(Index = 534)]
        /* 0x69C4 */ public float SpaceMapCockpitScale;
        [NMS(Index = 541)]
        /* 0x69C8 */ public float SpaceMapCockpitScaleAdjustAlien;
        [NMS(Index = 535)]
        /* 0x69CC */ public float SpaceMapCockpitScaleAdjustDropShip;
        [NMS(Index = 536)]
        /* 0x69D0 */ public float SpaceMapCockpitScaleAdjustFighter;
        [NMS(Index = 542)]
        /* 0x69D4 */ public float SpaceMapCockpitScaleAdjustRobot;
        [NMS(Index = 539)]
        /* 0x69D8 */ public float SpaceMapCockpitScaleAdjustRoyal;
        [NMS(Index = 540)]
        /* 0x69DC */ public float SpaceMapCockpitScaleAdjustSail;
        [NMS(Index = 537)]
        /* 0x69E0 */ public float SpaceMapCockpitScaleAdjustScientific;
        [NMS(Index = 538)]
        /* 0x69E4 */ public float SpaceMapCockpitScaleAdjustShuttle;
        [NMS(Index = 1233)]
        /* 0x69E8 */ public float SpaceMapDistance;
        [NMS(Index = 1216)]
        /* 0x69EC */ public float SpaceMapDistanceLogScaler;
        [NMS(Index = 1235)]
        /* 0x69F0 */ public float SpaceMapDistanceMultiplier;
        [NMS(Index = 1215)]
        /* 0x69F4 */ public float SpaceMapDistanceScale;
        [NMS(Index = 1238)]
        /* 0x69F8 */ public float SpaceMapFadeAngleMax;
        [NMS(Index = 1237)]
        /* 0x69FC */ public float SpaceMapFadeAngleMin;
        [NMS(Index = 1213)]
        /* 0x6A00 */ public float SpaceMapFoV;
        [NMS(Index = 1222)]
        /* 0x6A04 */ public float SpaceMapFreighterScale;
        [NMS(Index = 1236)]
        /* 0x6A08 */ public float SpaceMapHorizonThickness;
        [NMS(Index = 1243)]
        /* 0x6A0C */ public float SpaceMapLightPitch;
        [NMS(Index = 1244)]
        /* 0x6A10 */ public float SpaceMapLightYaw;
        [NMS(Index = 1197)]
        /* 0x6A14 */ public float SpaceMapLineBaseFade;
        [NMS(Index = 1196)]
        /* 0x6A18 */ public float SpaceMapLineBaseScale;
        [NMS(Index = 1195)]
        /* 0x6A1C */ public float SpaceMapLineWidth;
        [NMS(Index = 1232)]
        /* 0x6A20 */ public float SpaceMapMarkerScale;
        [NMS(Index = 1234)]
        /* 0x6A24 */ public float SpaceMapMaxTraderDistance;
        [NMS(Index = 1227)]
        /* 0x6A28 */ public float SpaceMapMoonScale;
        [NMS(Index = 1221)]
        /* 0x6A2C */ public float SpaceMapObjectScale;
        [NMS(Index = 1231)]
        /* 0x6A30 */ public float SpaceMapPirateFreighterScale;
        [NMS(Index = 1230)]
        /* 0x6A34 */ public float SpaceMapPirateFrigateScale;
        [NMS(Index = 1226)]
        /* 0x6A38 */ public float SpaceMapPlanetLineOffset;
        [NMS(Index = 1225)]
        /* 0x6A3C */ public float SpaceMapPlanetScale;
        [NMS(Index = 1218)]
        /* 0x6A40 */ public float SpaceMapScaleMin;
        [NMS(Index = 1220)]
        /* 0x6A44 */ public float SpaceMapScaleRangeMax;
        [NMS(Index = 1219)]
        /* 0x6A48 */ public float SpaceMapScaleRangeMin;
        [NMS(Index = 1198)]
        /* 0x6A4C */ public float SpaceMapShipCombineDistance;
        [NMS(Index = 1229)]
        /* 0x6A50 */ public float SpaceMapShipScale;
        [NMS(Index = 1242)]
        /* 0x6A54 */ public float SpaceMapShipScaleMin;
        [NMS(Index = 1223)]
        /* 0x6A58 */ public float SpaceMapStationScale;
        [NMS(Index = 718)]
        /* 0x6A5C */ public float SpaceMarkersBattleOffset;
        [NMS(Index = 717)]
        /* 0x6A60 */ public float SpaceMarkersOffset;
        [NMS(Index = 116)]
        /* 0x6A64 */ public float StackSizeChangeMaxRate;
        [NMS(Index = 115)]
        /* 0x6A68 */ public float StackSizeChangeMinRate;
        [NMS(Index = 114)]
        /* 0x6A6C */ public float StackSizeRateChangeRate;
        [NMS(Index = 106)]
        /* 0x6A70 */ public float StageStingDisplayTime;
        [NMS(Index = 515)]
        /* 0x6A74 */ public float StandingRewardOSDTime;
        [NMS(Index = 873)]
        /* 0x6A78 */ public float StatsMessageDelayTime;
        [NMS(Index = 22)]
        /* 0x6A7C */ public float StoreDialDecayTime;
        [NMS(Index = 21)]
        /* 0x6A80 */ public float StoreDialHoldTime;
        [NMS(Index = 23)]
        /* 0x6A84 */ public float StoreDialInnerRadius;
        [NMS(Index = 24)]
        /* 0x6A88 */ public float StoreDialOuterRadius;
        [NMS(Index = 76)]
        /* 0x6A8C */ public float SuperchargeGradientFactor;
        [NMS(Index = 75)]
        /* 0x6A90 */ public float SuperchargeGradientFactorMin;
        [NMS(Index = 77)]
        /* 0x6A94 */ public float SuperchargeGradientTime;
        [NMS(Index = 785)]
        /* 0x6A98 */ public float SurveyObjectArrowOffsetMultiplier;
        [NMS(Index = 348)]
        /* 0x6A9C */ public float TakeoffFuelMessageTime;
        [NMS(Index = 574)]
        /* 0x6AA0 */ public float TalkBoxAlienTextSpeed;
        [NMS(Index = 576)]
        /* 0x6AA4 */ public float TalkBoxAlienTextTimeMax;
        [NMS(Index = 575)]
        /* 0x6AA8 */ public float TalkBoxAlienTextTimeMin;
        [NMS(Index = 549)]
        /* 0x6AAC */ public float TargetDisplayDamageFlashTime;
        [NMS(Index = 544)]
        /* 0x6AB0 */ public float TargetDisplayScale;
        [NMS(Index = 546)]
        /* 0x6AB4 */ public float TargetDisplayShipScale;
        [NMS(Index = 545)]
        /* 0x6AB8 */ public float TargetDisplayTorpedoScale;
        [NMS(Index = 1187)]
        /* 0x6ABC */ public float TargetMarkerFadeAngleMin;
        [NMS(Index = 1188)]
        /* 0x6AC0 */ public float TargetMarkerFadeAngleRange;
        [NMS(Index = 1186)]
        /* 0x6AC4 */ public float TargetMarkerScaleEnd;
        [NMS(Index = 1185)]
        /* 0x6AC8 */ public float TargetMarkerScaleStart;
        [NMS(Index = 1369)]
        /* 0x6ACC */ public float TargetParallaxMaintenancePageMultiplier;
        [NMS(Index = 1368)]
        /* 0x6AD0 */ public float TargetParallaxMouseMultiplier;
        [NMS(Index = 999)]
        /* 0x6AD4 */ public float TargetScreenDistance;
        [NMS(Index = 998)]
        /* 0x6AD8 */ public float TargetScreenFoV;
        [NMS(Index = 800)]
        /* 0x6ADC */ public float TechDisplayDelayTime;
        [NMS(Index = 445)]
        /* 0x6AE0 */ public float TechPopupBuildLayerHeight;
        [NMS(Index = 444)]
        /* 0x6AE4 */ public float TechPopupRepairLayerHeight;
        [NMS(Index = 446)]
        /* 0x6AE8 */ public float TechPopupRequirementHeight;
        [NMS(Index = 1392)]
        /* 0x6AEC */ public float TextChatMaxDisplayTime;
        [NMS(Index = 1393)]
        /* 0x6AF0 */ public float TextChatStayBigAfterTextInput;
        [NMS(Index = 180)]
        /* 0x6AF4 */ public float TextPrintoutMultiplier;
        [NMS(Index = 181)]
        /* 0x6AF8 */ public float TextPrintoutMultiplierAlien;
        [NMS(Index = 17)]
        /* 0x6AFC */ public float TextTouchScrollCap;
        [NMS(Index = 763)]
        /* 0x6B00 */ public float ThirdPersonCrosshairCircle1Distance;
        [NMS(Index = 764)]
        /* 0x6B04 */ public float ThirdPersonCrosshairCircle2Distance;
        [NMS(Index = 762)]
        /* 0x6B08 */ public float ThirdPersonCrosshairDistance;
        [NMS(Index = 589)]
        /* 0x6B0C */ public float TimedEventLookTime;
        [NMS(Index = 923)]
        /* 0x6B10 */ public float TooltipTime;
        [NMS(Index = 18)]
        /* 0x6B14 */ public float TouchScrollChangePageThreshold;
        [NMS(Index = 15)]
        /* 0x6B18 */ public float TouchScrollMaxDelta;
        [NMS(Index = 16)]
        /* 0x6B1C */ public float TouchScrollSpeedMul;
        [NMS(Index = 760)]
        /* 0x6B20 */ public float TrackCriticalHitSize;
        [NMS(Index = 761)]
        /* 0x6B24 */ public float TrackCriticalPulseTime;
        [NMS(Index = 736)]
        /* 0x6B28 */ public float TrackLeadTargetInScale;
        [NMS(Index = 733)]
        /* 0x6B2C */ public float TrackMissileTargetPulseRate;
        [NMS(Index = 726)]
        /* 0x6B30 */ public float TrackPoliceFreighterCentreOffset;
        [NMS(Index = 725)]
        /* 0x6B34 */ public float TrackPrimaryCentreOffset;
        [NMS(Index = 738)]
        /* 0x6B38 */ public float TrackReticuleAngle;
        [NMS(Index = 740)]
        /* 0x6B3C */ public float TrackReticuleInactiveTime;
        [NMS(Index = 739)]
        /* 0x6B40 */ public float TrackReticuleInTime;
        [NMS(Index = 742)]
        /* 0x6B44 */ public float TrackReticuleRandomDelay;
        [NMS(Index = 741)]
        /* 0x6B48 */ public float TrackReticuleRandomTime;
        [NMS(Index = 737)]
        /* 0x6B4C */ public float TrackReticuleScale;
        [NMS(Index = 734)]
        /* 0x6B50 */ public float TrackScaleCritical;
        [NMS(Index = 735)]
        /* 0x6B54 */ public float TrackScaleHit;
        [NMS(Index = 727)]
        /* 0x6B58 */ public float TrackTimerAlpha;
        [NMS(Index = 731)]
        /* 0x6B5C */ public float TrackTimerIconExclaimRadius;
        [NMS(Index = 730)]
        /* 0x6B60 */ public float TrackTimerIconInnerRadius;
        [NMS(Index = 729)]
        /* 0x6B64 */ public float TrackTimerIconOuterRadius;
        [NMS(Index = 728)]
        /* 0x6B68 */ public float TrackTimerRadarPulseSize;
        [NMS(Index = 724)]
        /* 0x6B6C */ public float TrackTypeIconSize;
        [NMS(Index = 20)]
        /* 0x6B70 */ public float TradePageNotifyOffset;
        [NMS(Index = 359)]
        /* 0x6B74 */ public float TransferPopupCursorOffsetFactor;
        [NMS(Index = 588)]
        /* 0x6B78 */ public float TransferSendOffscreenBorder;
        [NMS(Index = 496)]
        /* 0x6B7C */ public float TransitionOffset;
        [NMS(Index = 310)]
        /* 0x6B80 */ public float TravelLineThickness;
        [NMS(Index = 309)]
        /* 0x6B84 */ public float TravelTargetRadius;
        [NMS(Index = 27)]
        /* 0x6B88 */ public float TrialUpsellDeclineDecayTimeQuick;
        [NMS(Index = 29)]
        /* 0x6B8C */ public float TrialUpsellDeclineDecayTimeSlow;
        [NMS(Index = 30)]
        /* 0x6B90 */ public float TrialUpsellDeclineDialInnerRadius;
        [NMS(Index = 31)]
        /* 0x6B94 */ public float TrialUpsellDeclineDialOuterRadius;
        [NMS(Index = 26)]
        /* 0x6B98 */ public float TrialUpsellDeclineHoldTimeQuick;
        [NMS(Index = 28)]
        /* 0x6B9C */ public float TrialUpsellDeclineHoldTimeSlow;
        [NMS(Index = 89)]
        /* 0x6BA0 */ public int UnknownWordsToShowInCatalogue;
        [NMS(Index = 92)]
        /* 0x6BA4 */ public float UseZoomedOutBuildCamRadius;
        [NMS(Index = 201)]
        /* 0x6BA8 */ public int VRFaceLockedScreenHeight;
        [NMS(Index = 200)]
        /* 0x6BAC */ public int VRFaceLockedScreenWidth;
        [NMS(Index = 346)]
        /* 0x6BB0 */ public float WantedDetectMessageTime;
        [NMS(Index = 347)]
        /* 0x6BB4 */ public float WantedDetectMinTimeout;
        [NMS(Index = 869)]
        /* 0x6BB8 */ public float WantedLevelScanAlpha;
        [NMS(Index = 870)]
        /* 0x6BBC */ public float WantedLevelScannedRate;
        [NMS(Index = 867)]
        /* 0x6BC0 */ public float WantedLevelTimeoutPulseRate;
        [NMS(Index = 868)]
        /* 0x6BC4 */ public float WantedLevelWitnessAlpha;
        [NMS(Index = 866)]
        /* 0x6BC8 */ public float WantedLevelWitnessOffset;
        [NMS(Index = 865)]
        /* 0x6BCC */ public float WantedLevelWitnessPulseRate;
        [NMS(Index = 119)]
        /* 0x6BD0 */ public float ZoomFactorOverride;
        [NMS(Index = 935)]
        /* 0x6BD4 */ public float ZoomHUDElementsOffsetX;
        [NMS(Index = 936)]
        /* 0x6BD8 */ public float ZoomHUDElementsOffsetY;
        [NMS(Index = 937)]
        /* 0x6BDC */ public float ZoomHUDElementTime;
        [NMS(Index = 1288)]
        /* 0x6BE0 */ public NMSString0x100 HUDCircleAnimIcon;
        [NMS(Index = 1286)]
        /* 0x6CE0 */ public NMSString0x100 HUDDeathPointIcon;
        [NMS(Index = 1287)]
        /* 0x6DE0 */ public NMSString0x100 HUDHexAnimIcon;
        [NMS(Index = 1282)]
        /* 0x6EE0 */ public NMSString0x100 HUDMarkerColourIcon;
        [NMS(Index = 1280)]
        /* 0x6FE0 */ public NMSString0x100 HUDMarkerIcon;
        [NMS(Index = 1281)]
        /* 0x70E0 */ public NMSString0x100 HUDMarkerPrimaryIndicatorIcon;
        [NMS(Index = 1283)]
        /* 0x71E0 */ public NMSString0x100 HUDPointIcon;
        [NMS(Index = 1285)]
        /* 0x72E0 */ public NMSString0x100 HUDSaveIcon;
        [NMS(Index = 1284)]
        /* 0x73E0 */ public NMSString0x100 HUDSpaceshipIcon;
        [NMS(Index = 933)]
        /* 0x74E0 */ public NMSString0x20 DistanceUnitKM;
        [NMS(Index = 932)]
        /* 0x7500 */ public NMSString0x20 DistanceUnitM;
        [NMS(Index = 934)]
        /* 0x7520 */ public NMSString0x20 DistanceUnitMpS;
        [NMS(Index = 505)]
        /* 0x7540 */ public NMSString0x20 MaxDialogCharSizeIdeographicString;
        [NMS(Index = 503)]
        /* 0x7560 */ public NMSString0x20 MaxDialogCharSizeRomanString;
        [NMS(Index = 197)]
        /* 0x7580 */ public NMSString0x20 VRDistanceWarningUIFile;
        [NMS(Index = 393, Size = 0x10, EnumType = typeof(GcBuildMenuOption.BuildMenuOptionEnum))]
        /* 0x75A0 */ public bool[] BuildMenuUseSmallIconOnPad;
        [NMS(Index = 183)]
        /* 0x75B0 */ public bool AllowInWorldDebugBorders;
        [NMS(Index = 174)]
        /* 0x75B1 */ public bool AllowProjectorRepositioning;
        [NMS(Index = 317)]
        /* 0x75B2 */ public bool AlwaysCloseQuickMenu;
        [NMS(Index = 666)]
        /* 0x75B3 */ public TkCurveType ArrowBounceLeftCurve;
        [NMS(Index = 662)]
        /* 0x75B4 */ public TkCurveType ArrowBounceRightCurve;
        [NMS(Index = 94)]
        /* 0x75B5 */ public bool AutoScrollParagraphs;
        [NMS(Index = 421)]
        /* 0x75B6 */ public bool BaseBuildingSmoothMenuWhileSnapped;
        [NMS(Index = 84)]
        /* 0x75B7 */ public bool BigPicking;
        [NMS(Index = 85)]
        /* 0x75B8 */ public bool BigPickingUsesNumbers;
        [NMS(Index = 158)]
        /* 0x75B9 */ public bool BinocularScanScreen;
        [NMS(Index = 382)]
        /* 0x75BA */ public TkCurveType CompassCurve;
        [NMS(Index = 748)]
        /* 0x75BB */ public bool CreatureInteractLabelUseBB;
        [NMS(Index = 747)]
        /* 0x75BC */ public TkCurveType CreatureReticuleAlphaCurve;
        [NMS(Index = 746)]
        /* 0x75BD */ public TkCurveType CreatureReticuleScaleCurve;
        [NMS(Index = 687)]
        /* 0x75BE */ public TkCurveType CrosshairLeadScaleCurve;
        [NMS(Index = 705)]
        /* 0x75BF */ public TkCurveType CrosshairTargetLockAlphaCurve;
        [NMS(Index = 704)]
        /* 0x75C0 */ public TkCurveType CrosshairTargetLockCurve;
        [NMS(Index = 617)]
        /* 0x75C1 */ public TkCurveType DamageNumberUpCurve;
        [NMS(Index = 323)]
        /* 0x75C2 */ public bool DebugInventoryIndices;
        [NMS(Index = 562)]
        /* 0x75C3 */ public bool DebugMarkerLabels;
        [NMS(Index = 320)]
        /* 0x75C4 */ public bool DebugMissionLogText;
        [NMS(Index = 322)]
        /* 0x75C5 */ public bool DebugPopupSizes;
        [NMS(Index = 321)]
        /* 0x75C6 */ public bool DebugShowMaintenanceScreenCentre;
        [NMS(Index = 1412)]
        /* 0x75C7 */ public bool EnableAccessibleUIOnSwitch;
        [NMS(Index = 449)]
        /* 0x75C8 */ public bool EnableBlackouts;
        [NMS(Index = 804)]
        /* 0x75C9 */ public bool EnableBuilderRobotGreekConversion;
        [NMS(Index = 245)]
        /* 0x75CA */ public bool EnableCraftingTree;
        [NMS(Index = 182)]
        /* 0x75CB */ public bool EnableHandMenuButtons;
        [NMS(Index = 214)]
        /* 0x75CC */ public bool EnableHandMenuDebug;
        [NMS(Index = 805)]
        /* 0x75CD */ public bool EnableKanaConversion;
        [NMS(Index = 87)]
        /* 0x75CE */ public bool EnablePopupUses;
        [NMS(Index = 324)]
        /* 0x75CF */ public bool FixedInventoryIconPositions;
        [NMS(Index = 1099)]
        /* 0x75D0 */ public TkCurveType FrontendBootBarCurve;
        [NMS(Index = 1084)]
        /* 0x75D1 */ public TkCurveType FrontendConfirmCurve;
        [NMS(Index = 1175)]
        /* 0x75D2 */ public TkCurveType FrontendDoFCurve;
        [NMS(Index = 1174)]
        /* 0x75D3 */ public bool FrontendDoFEnableBokeh;
        [NMS(Index = 875)]
        /* 0x75D4 */ public bool HideExtremePlanetNotifications;
        [NMS(Index = 1390)]
        /* 0x75D5 */ public bool HideQuickMenuControls;
        [NMS(Index = 1323)]
        /* 0x75D6 */ public TkCurveType HUDMarkerActiveCurve;
        [NMS(Index = 1293)]
        /* 0x75D7 */ public TkCurveType HUDMarkerAnimAlphaCurve;
        [NMS(Index = 1294)]
        /* 0x75D8 */ public TkCurveType HUDMarkerAnimCurve;
        [NMS(Index = 833)]
        /* 0x75D9 */ public TkCurveType HUDPlayerTrackArrowEnergyShieldDepletedCurve;
        [NMS(Index = 838)]
        /* 0x75DA */ public TkCurveType HUDPlayerTrackArrowEnergyShieldStartChargeCurve;
        [NMS(Index = 299)]
        /* 0x75DB */ public bool InteractionInWorldPlayerCamAlways;
        [NMS(Index = 976)]
        /* 0x75DC */ public TkCurveType InteractionScanSlapCurve;
        [NMS(Index = 508)]
        /* 0x75DD */ public bool LeadTargetEnabled;
        [NMS(Index = 1003)]
        /* 0x75DE */ public bool ModelRendererBGPass;
        [NMS(Index = 1004)]
        /* 0x75DF */ public bool ModelRendererPass1;
        [NMS(Index = 1005)]
        /* 0x75E0 */ public bool ModelRendererPass2;
        [NMS(Index = 1371)]
        /* 0x75E1 */ public TkCurveType NGuiModelViewFadeInAfterRenderCurve;
        [NMS(Index = 1372)]
        /* 0x75E2 */ public bool NGuiUseSeparateLayersForModelAndReflection;
        [NMS(Index = 202)]
        /* 0x75E3 */ public bool OnlyShowEjectHandlesInVR;
        [NMS(Index = 65)]
        /* 0x75E4 */ public TkCurveType PadCursorUICurve;
        [NMS(Index = 498)]
        /* 0x75E5 */ public TkCurveType PageTurnCurve;
        [NMS(Index = 499)]
        /* 0x75E6 */ public TkCurveType PageTurnFadeCurve;
        [NMS(Index = 1103)]
        /* 0x75E7 */ public TkCurveType PopupActivateCurve1;
        [NMS(Index = 1104)]
        /* 0x75E8 */ public TkCurveType PopupActivateCurve2;
        [NMS(Index = 551)]
        /* 0x75E9 */ public bool ProgressiveDialogStyle;
        [NMS(Index = 1391)]
        /* 0x75EA */ public bool QuickMenuAllowCycle;
        [NMS(Index = 246)]
        /* 0x75EB */ public bool QuickMenuEnableSwipe;
        [NMS(Index = 319)]
        /* 0x75EC */ public bool RepairTechUseTechIcon;
        [NMS(Index = 80)]
        /* 0x75ED */ public bool ReplaceItemBarWithNumbers;
        [NMS(Index = 1018)]
        /* 0x75EE */ public bool ShieldHUDAlwaysOn;
        [NMS(Index = 564)]
        /* 0x75EF */ public bool ShowDamageNumbers;
        [NMS(Index = 50)]
        /* 0x75F0 */ public bool ShowDifficultyForBases;
        [NMS(Index = 872)]
        /* 0x75F1 */ public bool ShowJetpackNotificationForNonTerrain;
        [NMS(Index = 596)]
        /* 0x75F2 */ public bool ShowOnscreenPredatorMarkers;
        [NMS(Index = 51)]
        /* 0x75F3 */ public bool ShowPadlockForLockedSettings;
        [NMS(Index = 198)]
        /* 0x75F4 */ public bool ShowVRDistanceWarning;
        [NMS(Index = 118)]
        /* 0x75F5 */ public bool SkipShopIntro;
        [NMS(Index = 1217)]
        /* 0x75F6 */ public TkCurveType SpaceMapDistanceCurve;
        [NMS(Index = 1203)]
        /* 0x75F7 */ public bool SpaceMapShowAnomaly;
        [NMS(Index = 1204)]
        /* 0x75F8 */ public bool SpaceMapShowAnomalyLines;
        [NMS(Index = 1210)]
        /* 0x75F9 */ public bool SpaceMapShowFrieghterLines;
        [NMS(Index = 1209)]
        /* 0x75FA */ public bool SpaceMapShowFrieghters;
        [NMS(Index = 1205)]
        /* 0x75FB */ public bool SpaceMapShowNexus;
        [NMS(Index = 1206)]
        /* 0x75FC */ public bool SpaceMapShowNexusLines;
        [NMS(Index = 1200)]
        /* 0x75FD */ public bool SpaceMapShowPlanetLines;
        [NMS(Index = 1199)]
        /* 0x75FE */ public bool SpaceMapShowPlanets;
        [NMS(Index = 1212)]
        /* 0x75FF */ public bool SpaceMapShowPulseEncounterLines;
        [NMS(Index = 1211)]
        /* 0x7600 */ public bool SpaceMapShowPulseEncounters;
        [NMS(Index = 1208)]
        /* 0x7601 */ public bool SpaceMapShowShipLines;
        [NMS(Index = 1207)]
        /* 0x7602 */ public bool SpaceMapShowShips;
        [NMS(Index = 1201)]
        /* 0x7603 */ public bool SpaceMapShowStation;
        [NMS(Index = 1202)]
        /* 0x7604 */ public bool SpaceMapShowStationLines;
        [NMS(Index = 509)]
        /* 0x7605 */ public bool SpaceOnlyLeadTargetEnabled;
        [NMS(Index = 88)]
        /* 0x7606 */ public bool TechBoxesCanStack;
        [NMS(Index = 758)]
        /* 0x7607 */ public TkCurveType TrackCritCurve;
        [NMS(Index = 744)]
        /* 0x7608 */ public TkCurveType TrackReticuleInAngleCurve;
        [NMS(Index = 743)]
        /* 0x7609 */ public TkCurveType TrackReticuleInCurve;
        [NMS(Index = 90)]
        /* 0x760A */ public bool UseIntermediateMissionGiverOptions;
        [NMS(Index = 83)]
        /* 0x760B */ public bool UseSquareSlots;
        [NMS(Index = 318)]
        /* 0x760C */ public bool UseWorldNodesForRepair;
    }
}
