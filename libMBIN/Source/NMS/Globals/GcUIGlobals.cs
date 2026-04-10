using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x81E40E256795CE91, NameHash = 0xD1FA1B1C)]
    public class GcUIGlobals : NMSTemplate
    {
        [NMS(Index = 1104)]
        /* 0x0000 */ public GcModelViewCollection ModelViews;
        [NMS(Index = 1103, Size = 0xB, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x2700 */ public TkModelRendererData[] ShipThumbnailRenderSettings;
        [NMS(Index = 1102)]
        /* 0x2F40 */ public TkModelRendererData HoverShipThumbnailModelView;
        [NMS(Index = 1100)]
        /* 0x3000 */ public TkModelRendererData LargeMultitoolThumbnailModelView;
        [NMS(Index = 1099)]
        /* 0x30C0 */ public TkModelRendererData MultitoolThumbnailModelView;
        [NMS(Index = 1098)]
        /* 0x3180 */ public TkModelRendererData PetThumbnailModelView;
        [NMS(Index = 476)]
        /* 0x3240 */ public TkModelRendererData RepairBackpackCamera;
        [NMS(Index = 474)]
        /* 0x3300 */ public TkModelRendererData RepairCamera;
        [NMS(Index = 477)]
        /* 0x33C0 */ public TkModelRendererData RepairShipCameraInWorld;
        [NMS(Index = 478)]
        /* 0x3480 */ public TkModelRendererData RepairShipCameraModelView;
        [NMS(Index = 479)]
        /* 0x3540 */ public TkModelRendererData RepairShipCameraVR;
        [NMS(Index = 475)]
        /* 0x3600 */ public TkModelRendererData RepairWeaponCamera;
        [NMS(Index = 1101)]
        /* 0x36C0 */ public TkModelRendererData SpookShipThumbnailModelView;
        [NMS(Index = 1434)]
        /* 0x3780 */ public TkNGuiTreeViewTemplate FileBrowserTreeViewTemplate;
        [NMS(Index = 1433)]
        /* 0x3800 */ public TkNGuiTreeViewTemplate SceneInfoTreeViewTemplate;
        [NMS(Index = 1435)]
        /* 0x3880 */ public TkNGuiTreeViewTemplate SkeletonToolsTreeViewTemplate;
        [NMS(Index = 582)]
        /* 0x3900 */ public GcScanEffectData DebugEditorPreviewEffect;
        [NMS(Index = 668)]
        /* 0x3950 */ public GcScanEffectData FreighterSummonScanEffect;
        [NMS(Index = 342)]
        /* 0x39A0 */ public GcHUDEffectRewardData OSDEpicItemRewardEffect;
        [NMS(Index = 341)]
        /* 0x39F0 */ public GcHUDEffectRewardData OSDRareItemRewardEffect;
        [NMS(Index = 883, Size = 0x5, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x3A40 */ public Colour[] SystemHooverLEDColours;
        [NMS(Index = 884, Size = 0x5, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x3A90 */ public Colour[] SystemHooverStatusBarColours;
        [NMS(Index = 569)]
        /* 0x3AE0 */ public GcScanEffectData TargetDisplayScanEffect;
        [NMS(Index = 1292)]
        /* 0x3B30 */ public GcSpaceMapObjectData SpaceMapAtlasData;
        [NMS(Index = 1293)]
        /* 0x3B60 */ public GcSpaceMapObjectData SpaceMapBlackHoleData;
        [NMS(Index = 1295)]
        /* 0x3B90 */ public GcSpaceMapObjectData SpaceMapFreighterData;
        [NMS(Index = 1288)]
        /* 0x3BC0 */ public GcSpaceMapObjectData SpaceMapMarkerData;
        [NMS(Index = 1291)]
        /* 0x3BF0 */ public GcSpaceMapObjectData SpaceMapNexusData;
        [NMS(Index = 1289)]
        /* 0x3C20 */ public GcSpaceMapObjectData SpaceMapPlanetData;
        [NMS(Index = 1296)]
        /* 0x3C50 */ public GcSpaceMapObjectData SpaceMapPulseEncounterData;
        [NMS(Index = 1294)]
        /* 0x3C80 */ public GcSpaceMapObjectData SpaceMapShipData;
        [NMS(Index = 1290)]
        /* 0x3CB0 */ public GcSpaceMapObjectData SpaceMapStationData;
        [NMS(Index = 1366)]
        /* 0x3CE0 */ public Colour AltimeterBandColour1;
        [NMS(Index = 1367)]
        /* 0x3CF0 */ public Colour AltimeterBandColour2;
        [NMS(Index = 1368)]
        /* 0x3D00 */ public Colour AltimeterColour1;
        [NMS(Index = 1369)]
        /* 0x3D10 */ public Colour AltimeterColour2;
        [NMS(Index = 404)]
        /* 0x3D20 */ public Colour BaseComplexityDangerColour;
        [NMS(Index = 402)]
        /* 0x3D30 */ public Colour BaseComplexityDefaultColour;
        [NMS(Index = 403)]
        /* 0x3D40 */ public Colour BaseComplexityWarningColour;
        [NMS(Index = 188)]
        /* 0x3D50 */ public Vector3f BinocularPanelLinePointOffset;
        [NMS(Index = 412)]
        /* 0x3D60 */ public Colour BuildMenuErrorTextColour;
        [NMS(Index = 414)]
        /* 0x3D70 */ public Colour BuildMenuErrorTextFlashColour;
        [NMS(Index = 413)]
        /* 0x3D80 */ public Colour BuildMenuErrorTextOutlineColour;
        [NMS(Index = 415)]
        /* 0x3D90 */ public Colour BuildMenuErrorTextOutlineFlashColour;
        [NMS(Index = 416)]
        /* 0x3DA0 */ public Colour BuildMenuInfoTextColour;
        [NMS(Index = 417)]
        /* 0x3DB0 */ public Colour BuildMenuInfoTextOutlineColour;
        [NMS(Index = 410)]
        /* 0x3DC0 */ public Colour BuildMenuPassiveErrorTextColour;
        [NMS(Index = 411)]
        /* 0x3DD0 */ public Colour BuildMenuPassiveErrorTextOutlineColour;
        [NMS(Index = 1153)]
        /* 0x3DE0 */ public Colour ByteBeatArpGridActiveColour;
        [NMS(Index = 1152)]
        /* 0x3DF0 */ public Colour ByteBeatArpGridInactiveColour;
        [NMS(Index = 1155)]
        /* 0x3E00 */ public Colour ByteBeatArpPipActiveColour;
        [NMS(Index = 1154)]
        /* 0x3E10 */ public Colour ByteBeatArpPipInactiveColour;
        [NMS(Index = 1171)]
        /* 0x3E20 */ public Colour ByteBeatRhythmColour0Active;
        [NMS(Index = 1172)]
        /* 0x3E30 */ public Colour ByteBeatRhythmColour0Inactive;
        [NMS(Index = 1173)]
        /* 0x3E40 */ public Colour ByteBeatRhythmColour1Active;
        [NMS(Index = 1174)]
        /* 0x3E50 */ public Colour ByteBeatRhythmColour1Inactive;
        [NMS(Index = 1175)]
        /* 0x3E60 */ public Colour ByteBeatRhythmColour2Active;
        [NMS(Index = 1176)]
        /* 0x3E70 */ public Colour ByteBeatRhythmColour2Inactive;
        [NMS(Index = 1167)]
        /* 0x3E80 */ public Colour ByteBeatSequencerBGColourActive;
        [NMS(Index = 1168)]
        /* 0x3E90 */ public Colour ByteBeatSequencerBGColourInactive;
        [NMS(Index = 1177)]
        /* 0x3EA0 */ public Colour ByteBeatSequencerHighlightColour;
        [NMS(Index = 1169)]
        /* 0x3EB0 */ public Colour ByteBeatSequencerRimColourActive;
        [NMS(Index = 1170)]
        /* 0x3EC0 */ public Colour ByteBeatSequencerRimColourInactive;
        [NMS(Index = 1166)]
        /* 0x3ED0 */ public Colour ByteBeatSequencerUnpoweredTint;
        [NMS(Index = 1182)]
        /* 0x3EE0 */ public Colour ByteBeatSliderFGColour;
        [NMS(Index = 1183)]
        /* 0x3EF0 */ public Colour ByteBeatSliderTextActiveColour;
        [NMS(Index = 1184)]
        /* 0x3F00 */ public Colour ByteBeatSliderTextInactiveColour;
        [NMS(Index = 1143)]
        /* 0x3F10 */ public Colour ByteBeatTreeLineColour;
        [NMS(Index = 1146)]
        /* 0x3F20 */ public Colour ByteBeatVisGridColour;
        [NMS(Index = 1145)]
        /* 0x3F30 */ public Colour ByteBeatVisLineColour;
        [NMS(Index = 572)]
        /* 0x3F40 */ public Colour CommunicatorMessageColour;
        [NMS(Index = 725)]
        /* 0x3F50 */ public Colour CrosshairColour;
        [NMS(Index = 714)]
        /* 0x3F60 */ public Colour CrosshairLeadPassiveColour;
        [NMS(Index = 713)]
        /* 0x3F70 */ public Colour CrosshairLeadThreatColour;
        [NMS(Index = 1105)]
        /* 0x3F80 */ public Colour CursorColour;
        [NMS(Index = 1106)]
        /* 0x3F90 */ public Colour CursorConfirmColour;
        [NMS(Index = 1108)]
        /* 0x3FA0 */ public Colour CursorDeleteColour;
        [NMS(Index = 1107)]
        /* 0x3FB0 */ public Colour CursorTransferUploadColour;
        [NMS(Index = 637)]
        /* 0x3FC0 */ public Colour DamageNumberCriticalColour;
        [NMS(Index = 638)]
        /* 0x3FD0 */ public Colour DamageNumberIneffectiveColour;
        [NMS(Index = 639)]
        /* 0x3FE0 */ public Colour DamageNumberIneffectiveWarningColour;
        [NMS(Index = 953)]
        /* 0x3FF0 */ public Colour DeathMessageColour;
        [NMS(Index = 301)]
        /* 0x4000 */ public Colour DebugEditorAxisColourAtActive;
        [NMS(Index = 300)]
        /* 0x4010 */ public Colour DebugEditorAxisColourAtInactive;
        [NMS(Index = 299)]
        /* 0x4020 */ public Colour DebugEditorAxisColourRightActive;
        [NMS(Index = 298)]
        /* 0x4030 */ public Colour DebugEditorAxisColourRightInactive;
        [NMS(Index = 297)]
        /* 0x4040 */ public Colour DebugEditorAxisColourUpActive;
        [NMS(Index = 296)]
        /* 0x4050 */ public Colour DebugEditorAxisColourUpInactive;
        [NMS(Index = 492)]
        /* 0x4060 */ public Vector3f DefaultRefinerOffsetIn;
        [NMS(Index = 493)]
        /* 0x4070 */ public Vector3f DefaultRefinerOffsetOut;
        [NMS(Index = 1071)]
        /* 0x4080 */ public Colour EnergyBgColour;
        [NMS(Index = 1072)]
        /* 0x4090 */ public Colour EnergyBgPulseColour;
        [NMS(Index = 219)]
        /* 0x40A0 */ public Vector3f FaceLockedScreenOffset;
        [NMS(Index = 669)]
        /* 0x40B0 */ public Colour FreighterSummonScanEffectColourBlocked;
        [NMS(Index = 670)]
        /* 0x40C0 */ public Colour FreighterSummonScanEffectColourHighlight;
        [NMS(Index = 304)]
        /* 0x40D0 */ public Colour FrontendCursorBackgroundColour;
        [NMS(Index = 642)]
        /* 0x40E0 */ public Colour FuelBgColour;
        [NMS(Index = 510)]
        /* 0x40F0 */ public Colour GridBackgroundNegativeColour;
        [NMS(Index = 508)]
        /* 0x4100 */ public Colour GridBackgroundNeutralColour;
        [NMS(Index = 509)]
        /* 0x4110 */ public Colour GridBackgroundPositiveColour;
        [NMS(Index = 505)]
        /* 0x4120 */ public Colour GridDisconnectedColour;
        [NMS(Index = 507)]
        /* 0x4130 */ public Colour GridOfflineColour;
        [NMS(Index = 506)]
        /* 0x4140 */ public Colour GridOnlineColour;
        [NMS(Index = 1073)]
        /* 0x4150 */ public Colour HazardBgPulseColour;
        [NMS(Index = 1074)]
        /* 0x4160 */ public Colour HazardDamagePulseColour;
        [NMS(Index = 307)]
        /* 0x4170 */ public Vector3f HmdFramerateScreenOffset;
        [NMS(Index = 1307)]
        /* 0x4180 */ public Colour HUDMarkerColour;
        [NMS(Index = 880)]
        /* 0x4190 */ public Colour HUDNotifyColour;
        [NMS(Index = 1311)]
        /* 0x41A0 */ public Colour HUDOutpostColour;
        [NMS(Index = 844)]
        /* 0x41B0 */ public Colour HUDPlayerTrackArrowDamageGlowHullHitMaxColour;
        [NMS(Index = 845)]
        /* 0x41C0 */ public Colour HUDPlayerTrackArrowDamageGlowHullHitMinColour;
        [NMS(Index = 848)]
        /* 0x41D0 */ public Colour HUDPlayerTrackArrowDamageGlowShieldHitMaxColour;
        [NMS(Index = 849)]
        /* 0x41E0 */ public Colour HUDPlayerTrackArrowDamageGlowShieldHitMinColour;
        [NMS(Index = 875)]
        /* 0x41F0 */ public Colour HUDPlayerTrackArrowDotColour;
        [NMS(Index = 877)]
        /* 0x4200 */ public Colour HUDPlayerTrackArrowDotColourPirate;
        [NMS(Index = 876)]
        /* 0x4210 */ public Colour HUDPlayerTrackArrowDotColourPolice;
        [NMS(Index = 878)]
        /* 0x4220 */ public Colour HUDPlayerTrackArrowDotColourTrader;
        [NMS(Index = 836)]
        /* 0x4230 */ public Colour HUDPlayerTrackArrowEnergyShieldColour;
        [NMS(Index = 857)]
        /* 0x4240 */ public Colour HUDPlayerTrackArrowEnergyShieldDepletedGlowMaxColour;
        [NMS(Index = 858)]
        /* 0x4250 */ public Colour HUDPlayerTrackArrowEnergyShieldDepletedGlowMinColour;
        [NMS(Index = 837)]
        /* 0x4260 */ public Colour HUDPlayerTrackArrowEnergyShieldLowColour;
        [NMS(Index = 862)]
        /* 0x4270 */ public Colour HUDPlayerTrackArrowEnergyShieldStartChargeGlowMaxColour;
        [NMS(Index = 863)]
        /* 0x4280 */ public Colour HUDPlayerTrackArrowEnergyShieldStartChargeGlowMinColour;
        [NMS(Index = 833)]
        /* 0x4290 */ public Colour HUDPlayerTrackArrowTextColour;
        [NMS(Index = 1309)]
        /* 0x42A0 */ public Colour HUDRelicMarkerColourDiscovered;
        [NMS(Index = 1310)]
        /* 0x42B0 */ public Colour HUDRelicMarkerColourUnknown;
        [NMS(Index = 1308)]
        /* 0x42C0 */ public Colour HUDSpaceshipColour;
        [NMS(Index = 879)]
        /* 0x42D0 */ public Colour HUDWarningColour;
        [NMS(Index = 423)]
        /* 0x42E0 */ public Colour IconGlowColourActive;
        [NMS(Index = 422)]
        /* 0x42F0 */ public Colour IconGlowColourError;
        [NMS(Index = 425)]
        /* 0x4300 */ public Colour IconGlowColourHighlight;
        [NMS(Index = 424)]
        /* 0x4310 */ public Colour IconGlowColourNeutral;
        [NMS(Index = 482)]
        /* 0x4320 */ public Colour InteractionLabelCostColour;
        [NMS(Index = 483)]
        /* 0x4330 */ public Colour InteractionLabelPickupColour;
        [NMS(Index = 484)]
        /* 0x4340 */ public Colour InteractionLabelPickupFillColour;
        [NMS(Index = 79)]
        /* 0x4350 */ public Colour InvSlotGradientBaseColour;
        [NMS(Index = 150)]
        /* 0x4360 */ public Vector3f InWorldInteractLabelCentreOffset;
        [NMS(Index = 152)]
        /* 0x4370 */ public Vector3f InWorldInteractLabelLineOffset;
        [NMS(Index = 151)]
        /* 0x4380 */ public Vector3f InWorldInteractLabelTopOffset;
        [NMS(Index = 212)]
        /* 0x4390 */ public Vector3f InWorldNGuiScreenRotation;
        [NMS(Index = 153)]
        /* 0x43A0 */ public Vector3f InWorldStaffBinocsScreenOffset;
        [NMS(Index = 989)]
        /* 0x43B0 */ public Colour ItemSlotColourPartiallyInstalled;
        [NMS(Index = 991)]
        /* 0x43C0 */ public Colour ItemSlotColourProduct;
        [NMS(Index = 985)]
        /* 0x43D0 */ public Colour ItemSlotColourSubstance;
        [NMS(Index = 986)]
        /* 0x43E0 */ public Colour ItemSlotColourTech;
        [NMS(Index = 987)]
        /* 0x43F0 */ public Colour ItemSlotColourTechCharge;
        [NMS(Index = 988)]
        /* 0x4400 */ public Colour ItemSlotColourTechDamage;
        [NMS(Index = 994)]
        /* 0x4410 */ public Colour ItemSlotTextColourProduct;
        [NMS(Index = 992)]
        /* 0x4420 */ public Colour ItemSlotTextColourSubstance;
        [NMS(Index = 993)]
        /* 0x4430 */ public Colour ItemSlotTextColourTech;
        [NMS(Index = 78)]
        /* 0x4440 */ public Colour JoaoBoxCompletedObjectiveColour;
        [NMS(Index = 1372)]
        /* 0x4450 */ public Colour LockOnMarkerActiveColour;
        [NMS(Index = 208)]
        /* 0x4460 */ public Vector3f LowerHelmetScreenOffset;
        [NMS(Index = 457)]
        /* 0x4470 */ public Colour MarkerRingBGColour;
        [NMS(Index = 534)]
        /* 0x4480 */ public Colour MissionOSDMessageBarColour;
        [NMS(Index = 353)]
        /* 0x4490 */ public Colour MultiplayerMissionParticipantsColour;
        [NMS(Index = 61)]
        /* 0x44A0 */ public Colour NetworkPopupTextDisabledColour;
        [NMS(Index = 60)]
        /* 0x44B0 */ public Colour NetworkPopupTextEnabledColour;
        [NMS(Index = 1390)]
        /* 0x44C0 */ public Vector3f NGuiModelTranslationFactors;
        [NMS(Index = 1391)]
        /* 0x44D0 */ public Vector3f NGuiModelTranslationFactorsInteraction;
        [NMS(Index = 1392)]
        /* 0x44E0 */ public Vector3f NGuiThumbnailModelTranslationFactors;
        [NMS(Index = 536)]
        /* 0x44F0 */ public Colour NotificationDangerColour;
        [NMS(Index = 535)]
        /* 0x4500 */ public Colour NotificationDefaultColour;
        [NMS(Index = 537)]
        /* 0x4510 */ public Colour NotificationInfoColour;
        [NMS(Index = 538)]
        /* 0x4520 */ public Colour NotificationUrgentColour;
        [NMS(Index = 11)]
        /* 0x4530 */ public Vector3f OutpostReturnMarkerOffset;
        [NMS(Index = 3)]
        /* 0x4540 */ public Colour PetGeneIconGlowColourDefault;
        [NMS(Index = 4)]
        /* 0x4550 */ public Colour PetGeneIconGlowColourHighlight;
        [NMS(Index = 1)]
        /* 0x4560 */ public Colour PetLevelProgressColour;
        [NMS(Index = 2)]
        /* 0x4570 */ public Colour PetPointProgresColour;
        [NMS(Index = 640)]
        /* 0x4580 */ public Colour PhotoModeSelectedColour;
        [NMS(Index = 641)]
        /* 0x4590 */ public Colour PhotoModeUnselectedColour;
        [NMS(Index = 352)]
        /* 0x45A0 */ public Colour PickedItemBorderColour;
        [NMS(Index = 954)]
        /* 0x45B0 */ public Colour PinnedRecipeBorder;
        [NMS(Index = 348)]
        /* 0x45C0 */ public Colour ProcProductColourCommon;
        [NMS(Index = 350)]
        /* 0x45D0 */ public Colour ProcProductColourRare;
        [NMS(Index = 349)]
        /* 0x45E0 */ public Colour ProcProductColourUncommon;
        [NMS(Index = 818)]
        /* 0x45F0 */ public Colour PulseAlertColour;
        [NMS(Index = 817)]
        /* 0x4600 */ public Colour PulseDamageColour;
        [NMS(Index = 302)]
        /* 0x4610 */ public Colour QuickMenuSelectedItemColour1;
        [NMS(Index = 303)]
        /* 0x4620 */ public Colour QuickMenuSelectedItemColour2;
        [NMS(Index = 1191)]
        /* 0x4630 */ public Colour RadialMenuInnerColourDisabled;
        [NMS(Index = 1187)]
        /* 0x4640 */ public Colour RadialMenuInnerColourSelected;
        [NMS(Index = 1189)]
        /* 0x4650 */ public Colour RadialMenuInnerColourUnselected;
        [NMS(Index = 1192)]
        /* 0x4660 */ public Colour RadialMenuOuterColourDisabled;
        [NMS(Index = 1188)]
        /* 0x4670 */ public Colour RadialMenuOuterColourSelected;
        [NMS(Index = 1190)]
        /* 0x4680 */ public Colour RadialMenuOuterColourUnselected;
        [NMS(Index = 503)]
        /* 0x4690 */ public Colour RefinerBackgroundColour;
        [NMS(Index = 504)]
        /* 0x46A0 */ public Colour RefinerErrorBackgroundColour;
        [NMS(Index = 731)]
        /* 0x46B0 */ public Colour RemappedControlColour;
        [NMS(Index = 730)]
        /* 0x46C0 */ public Colour SelectedControlColour;
        [NMS(Index = 1440)]
        /* 0x46D0 */ public Colour SettlementStatBackgroundColour;
        [NMS(Index = 1439)]
        /* 0x46E0 */ public Colour SettlementStatColour;
        [NMS(Index = 1077)]
        /* 0x46F0 */ public Colour ShieldBgColour;
        [NMS(Index = 1075)]
        /* 0x4700 */ public Colour ShieldColour;
        [NMS(Index = 1078)]
        /* 0x4710 */ public Colour ShieldDamageBgColour;
        [NMS(Index = 1076)]
        /* 0x4720 */ public Colour ShieldDamageColour;
        [NMS(Index = 26)]
        /* 0x4730 */ public Colour ShipBuilderLineColour;
        [NMS(Index = 25)]
        /* 0x4740 */ public Colour ShipBuilderLineColourHologram;
        [NMS(Index = 1019)]
        /* 0x4750 */ public Colour ShipHUDAimTargetColour;
        [NMS(Index = 1020)]
        /* 0x4760 */ public Colour ShipHUDAimTargetCritColour;
        [NMS(Index = 1017)]
        /* 0x4770 */ public Colour ShipHUDTargetArrowsColourLocal;
        [NMS(Index = 1015)]
        /* 0x4780 */ public Colour ShipHUDTargetArrowsColourOutOfRange;
        [NMS(Index = 1016)]
        /* 0x4790 */ public Colour ShipHUDTargetArrowsColourThreat;
        [NMS(Index = 10)]
        /* 0x47A0 */ public Vector3f ShipTeleportPadMarkerOffset;
        [NMS(Index = 1280)]
        /* 0x47B0 */ public Colour SpaceEnemyShipLineColour;
        [NMS(Index = 1279)]
        /* 0x47C0 */ public Colour SpaceFriendlyShipLineColour;
        [NMS(Index = 1282)]
        /* 0x47D0 */ public Colour SpaceMapAttackColour;
        [NMS(Index = 551)]
        /* 0x47E0 */ public Vector3f SpaceMapCockpitOffset;
        [NMS(Index = 1287)]
        /* 0x47F0 */ public Colour SpaceMapDeathPointColour;
        [NMS(Index = 1285)]
        /* 0x4800 */ public Colour SpaceMapNeutralColour;
        [NMS(Index = 1283)]
        /* 0x4810 */ public Colour SpaceMapOtherPlayerColour;
        [NMS(Index = 1281)]
        /* 0x4820 */ public Vector3f SpaceMapPosScaler;
        [NMS(Index = 1286)]
        /* 0x4830 */ public Colour SpaceMapSquadronColour;
        [NMS(Index = 1284)]
        /* 0x4840 */ public Colour SpaceMapThreatColour;
        [NMS(Index = 1463)]
        /* 0x4850 */ public Colour SpookMeterColour;
        [NMS(Index = 37)]
        /* 0x4860 */ public Colour StoreDialFillColour;
        [NMS(Index = 85)]
        /* 0x4870 */ public Colour SuperchargeGradientBaseColour;
        [NMS(Index = 86)]
        /* 0x4880 */ public Colour SuperchargeGradientBlendColour;
        [NMS(Index = 87)]
        /* 0x4890 */ public Colour SuperchargeGradientTechColour;
        [NMS(Index = 84)]
        /* 0x48A0 */ public Colour SuperchargePopupColour;
        [NMS(Index = 566)]
        /* 0x48B0 */ public Vector3f TargetDisplayShipOffset;
        [NMS(Index = 567)]
        /* 0x48C0 */ public Vector3f TargetDisplayTorpedoOffset;
        [NMS(Index = 1216)]
        /* 0x48D0 */ public Colour TargetMarkerColour;
        [NMS(Index = 1217)]
        /* 0x48E0 */ public Colour TargetMarkerHighlightColour;
        [NMS(Index = 31)]
        /* 0x48F0 */ public Colour TouchButtonChargeIndicatorColour;
        [NMS(Index = 511)]
        /* 0x4900 */ public Colour TransferSendPopupColour;
        [NMS(Index = 327)]
        /* 0x4910 */ public Colour TravelLineColour;
        [NMS(Index = 330)]
        /* 0x4920 */ public Colour TravelLineInvalidColour;
        [NMS(Index = 331)]
        /* 0x4930 */ public Colour TravelLineNotAllowedColour;
        [NMS(Index = 328)]
        /* 0x4940 */ public Colour TravelLineTooFarColour;
        [NMS(Index = 329)]
        /* 0x4950 */ public Colour TravelLineTooSteepColour;
        [NMS(Index = 332)]
        /* 0x4960 */ public Colour TravelTargetColour;
        [NMS(Index = 1226)]
        /* 0x4970 */ public Colour UnseenItemColour;
        [NMS(Index = 1225)]
        /* 0x4980 */ public Colour WantedColour;
        [NMS(Index = 52)]
        /* 0x4990 */ public Colour WristMenuDefaultBorderColour;
        [NMS(Index = 53)]
        /* 0x49A0 */ public Colour WristMenuRepositionableBorderColour;
        [NMS(Index = 71, Size = 0xF, EnumType = typeof(GcWonderCreatureCategory.WonderCreatureCategoryEnum))]
        /* 0x49B0 */ public GcWonderCategoryConfig[] WonderCreatureCategoryConfig;
        [NMS(Index = 74, Size = 0xD, EnumType = typeof(GcWonderTreasureCategory.WonderTreasureCategoryEnum))]
        /* 0x4CF8 */ public GcWonderCategoryConfig[] WonderTreasureCategoryConfig;
        [NMS(Index = 407, Size = 0x15, EnumType = typeof(GcBuildMenuOption.BuildMenuOptionEnum))]
        /* 0x4FD0 */ public NMSString0x20A[] BuildMenuOnActionDisabledLocIDs;
        [NMS(Index = 408, Size = 0x15, EnumType = typeof(GcBuildMenuOption.BuildMenuOptionEnum))]
        /* 0x5270 */ public NMSString0x20A[] BuildMenuOnActionErrorLocIDs;
        [NMS(Index = 406, Size = 0x15, EnumType = typeof(GcBuildMenuOption.BuildMenuOptionEnum))]
        /* 0x5510 */ public NMSString0x20A[] BuildMenuOnActionLocIDs;
        [NMS(Index = 76, Size = 0xC, EnumType = typeof(GcWonderCustomCategory.WonderCustomCategoryEnum))]
        /* 0x57B0 */ public GcWonderCategoryConfig[] WonderCustomCategoryConfig;
        [NMS(Index = 70, Size = 0xB, EnumType = typeof(GcWonderPlanetCategory.WonderPlanetCategoryEnum))]
        /* 0x5A50 */ public GcWonderCategoryConfig[] WonderPlanetCategoryConfig;
        [NMS(Index = 75, Size = 0xB, EnumType = typeof(GcWonderWeirdBasePartCategory.WonderWeirdBasePartCategoryEnum))]
        /* 0x5CB8 */ public GcWonderCategoryConfig[] WonderWeirdBasePartCategoryConfig;
        [NMS(Index = 72, Size = 0x8, EnumType = typeof(GcWonderFloraCategory.WonderFloraCategoryEnum))]
        /* 0x5F20 */ public GcWonderCategoryConfig[] WonderFloraCategoryConfig;
        [NMS(Index = 73, Size = 0x8, EnumType = typeof(GcWonderMineralCategory.WonderMineralCategoryEnum))]
        /* 0x60E0 */ public GcWonderCategoryConfig[] WonderMineralCategoryConfig;
        [NMS(Index = 1408)]
        /* 0x62A0 */ public GcHUDStartupTable IntroTiming;
        [NMS(Index = 1409)]
        /* 0x63F0 */ public GcHUDStartupTable IntroTimingFreighter;
        [NMS(Index = 1410)]
        /* 0x6540 */ public GcHUDStartupTable IntroTimingFreighterRepaired;
        [NMS(Index = 1442, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x6690 */ public NMSString0x20A[] SettlementStatFormatLoc;
        [NMS(Index = 1441, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x6790 */ public NMSString0x20A[] SettlementStatLoc;
        [NMS(Index = 1443, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x6890 */ public TkTextureResource[] SettlementStatBasicImages;
        [NMS(Index = 1445, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x6950 */ public TkTextureResource[] SettlementStatNegativeImages;
        [NMS(Index = 1444, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x6A10 */ public TkTextureResource[] SettlementStatPositiveImages;
        [NMS(Index = 65, Size = 0x7, EnumType = typeof(GcWonderType.WonderTypeEnum))]
        /* 0x6AD0 */ public TkTextureResource[] WonderTypeIcons;
        [NMS(Index = 452)]
        /* 0x6B78 */ public TkTextureResource BaseBuildingPartsGridExpandableIcon;
        [NMS(Index = 453)]
        /* 0x6B90 */ public TkTextureResource BaseBuildingPartsGridExpandedIcon;
        [NMS(Index = 454)]
        /* 0x6BA8 */ public TkTextureResource BaseBuildingPartsGridRetractableIcon;
        [NMS(Index = 487)]
        /* 0x6BC0 */ public TkTextureResource RefinerPopupEmptyOutputIcon;
        [NMS(Index = 1069)]
        /* 0x6BD8 */ public GcFilename CamoNormalTexture;
        [NMS(Index = 1068)]
        /* 0x6BE8 */ public GcFilename CamoTexture;
        [NMS(Index = 94)]
        /* 0x6BF8 */ public NMSString0x10 DebugInventoryHint;
        [NMS(Index = 126)]
        /* 0x6C08 */ public NMSString0x10 ExplorationLogMissionID;
        [NMS(Index = 1067)]
        /* 0x6C18 */ public List<Vector4f> HazardDistortionParams;
        [NMS(Index = 1063)]
        /* 0x6C28 */ public List<GcFilename> HazardHeightmaps;
        [NMS(Index = 1066)]
        /* 0x6C38 */ public List<GcFilename> HazardHeightmapsVR;
        [NMS(Index = 1062)]
        /* 0x6C48 */ public List<GcFilename> HazardNormalMaps;
        [NMS(Index = 1065)]
        /* 0x6C58 */ public List<GcFilename> HazardNormalMapsVR;
        [NMS(Index = 1061)]
        /* 0x6C68 */ public List<GcFilename> HazardTextures;
        [NMS(Index = 1064)]
        /* 0x6C78 */ public List<GcFilename> HazardTexturesVR;
        [NMS(Index = 351)]
        /* 0x6C88 */ public List<Vector2f> InventoryIconPositions;
        [NMS(Index = 355)]
        /* 0x6C98 */ public NMSString0x10 MultiplayerMissionInteractEndTrigger;
        [NMS(Index = 354)]
        /* 0x6CA8 */ public NMSString0x10 MultiplayerMissionInteractStartTrigger;
        [NMS(Index = 114)]
        /* 0x6CB8 */ public List<GcSeasonalRingArray> SeasonalRingTable;
        [NMS(Index = 1018)]
        /* 0x6CC8 */ public List<Colour> ShipHUDTargetArrowsColour;
        [NMS(Index = 822)]
        /* 0x6CD8 */ public NMSString0x10 ShowStatWithDeathQuote;
        [NMS(Index = 894)]
        /* 0x6CE8 */ public List<GcFilename> StatIcons;
        [NMS(Index = 480)]
        /* 0x6CF8 */ public List<TkModelRendererData> VehicleTypeRepairCamera;
        [NMS(Index = 722, Size = 0x15, EnumType = typeof(GcPlayerWeapons.WeaponModeEnum))]
        /* 0x6D08 */ public float[] CrosshairTargetLockSizeSpecific;
        [NMS(Index = 976)]
        /* 0x6D5C */ public GcWorldUISettings WorldUISettings;
        [NMS(Index = 67, Size = 0xF, EnumType = typeof(GcWonderCreatureCategory.WonderCreatureCategoryEnum))]
        /* 0x6DAC */ public float[] WonderValueModifiersCreature;
        [NMS(Index = 66, Size = 0xB, EnumType = typeof(GcWonderPlanetCategory.WonderPlanetCategoryEnum))]
        /* 0x6DE8 */ public float[] WonderValueModifiersPlanet;
        [NMS(Index = 68, Size = 0x8, EnumType = typeof(GcWonderFloraCategory.WonderFloraCategoryEnum))]
        /* 0x6E14 */ public float[] WonderValueModifiersFlora;
        [NMS(Index = 69, Size = 0x8, EnumType = typeof(GcWonderMineralCategory.WonderMineralCategoryEnum))]
        /* 0x6E34 */ public float[] WonderValueModifiersMineral;
        [NMS(Index = 1412)]
        /* 0x6E54 */ public GcInventorySlotActionData BuildProductSlotAction;
        [NMS(Index = 1413)]
        /* 0x6E70 */ public GcInventorySlotActionData ChargeSlotAction;
        [NMS(Index = 1411)]
        /* 0x6E8C */ public GcInventorySlotActionData InstallTechSlotAction;
        [NMS(Index = 1417)]
        /* 0x6EA8 */ public GcInventorySlotActionData InventoryHintAction;
        [NMS(Index = 1418)]
        /* 0x6EC4 */ public GcInventorySlotActionData InventoryHintActionNoGlow;
        [NMS(Index = 1416)]
        /* 0x6EE0 */ public GcInventorySlotActionData NewSlotPulseAction;
        [NMS(Index = 1415)]
        /* 0x6EFC */ public GcInventorySlotActionData NewSlotRevealAction;
        [NMS(Index = 1414)]
        /* 0x6F18 */ public GcInventorySlotActionData RepairSlotAction;
        [NMS(Index = 0)]
        /* 0x6F34 */ public GcInteractionDof InteractionDOFDisabled;
        [NMS(Index = 815)]
        /* 0x6F48 */ public TkNGuiRectanglePulseEffect PulseBarData;
        [NMS(Index = 816)]
        /* 0x6F58 */ public TkNGuiRectanglePulseEffect PulseIconData;
        [NMS(Index = 726)]
        /* 0x6F68 */ public TkHitCurveData CrosshairLeadHitCurve;
        [NMS(Index = 1407)]
        /* 0x6F74 */ public GcDiscoveryHelperTimings DiscoveryHelperTimings;
        [NMS(Index = 727)]
        /* 0x6F80 */ public TkHitCurveData ShootableHitCurve;
        [NMS(Index = 173)]
        /* 0x6F8C */ public Vector2f BinocularEdgeFade;
        [NMS(Index = 481)]
        /* 0x6F94 */ public Vector2f BinocularsDiscoveryPos;
        [NMS(Index = 384)]
        /* 0x6F9C */ public Vector2f CompassCentre;
        [NMS(Index = 100)]
        /* 0x6FA4 */ public Vector2f ControlsPageParallax;
        [NMS(Index = 546)]
        /* 0x6FAC */ public Vector2f CursorlessDialogPageCursorOffset;
        [NMS(Index = 632)]
        /* 0x6FB4 */ public Vector2f DamageNumberSideSpeed;
        [NMS(Index = 544)]
        /* 0x6FBC */ public Vector2f DialogPageCursorOffset;
        [NMS(Index = 1313)]
        /* 0x6FC4 */ public Vector2f HUDMarkerCompassPrimaryIndicatorOffset;
        [NMS(Index = 1312)]
        /* 0x6FCC */ public Vector2f HUDMarkerPrimaryIndicatorOffset;
        [NMS(Index = 496)]
        /* 0x6FD4 */ public Vector2f HUDPlayerSentinelPulseFreq;
        [NMS(Index = 497)]
        /* 0x6FDC */ public Vector2f HUDPlayerSentinelPulseSize;
        [NMS(Index = 851)]
        /* 0x6FE4 */ public Vector2f HUDPlayerTrackArrowDamageGlowSize;
        [NMS(Index = 853)]
        /* 0x6FEC */ public Vector2f HUDPlayerTrackArrowEnergyShieldGlowSize;
        [NMS(Index = 840)]
        /* 0x6FF4 */ public Vector2f HUDPlayerTrackArrowEnergyShieldSize;
        [NMS(Index = 835)]
        /* 0x6FFC */ public Vector2f HUDPlayerTrackArrowHealthSize;
        [NMS(Index = 788)]
        /* 0x7004 */ public Vector2f HUDPlayerTrackArrowIconPulseSize;
        [NMS(Index = 800)]
        /* 0x700C */ public Vector2f HUDPlayerTrackIconOffset;
        [NMS(Index = 1299)]
        /* 0x7014 */ public Vector2f HUDTargetHealthIconOffset;
        [NMS(Index = 1297)]
        /* 0x701C */ public Vector2f HUDTargetHealthOffset;
        [NMS(Index = 1298)]
        /* 0x7024 */ public Vector2f HUDTargetHealthSize;
        [NMS(Index = 1080)]
        /* 0x702C */ public Vector2f InteractionLabelOffset;
        [NMS(Index = 1081)]
        /* 0x7034 */ public Vector2f InteractionLabelOffset_1;
        [NMS(Index = 1084)]
        /* 0x703C */ public Vector2f InteractionLabelScreenMax;
        [NMS(Index = 1083)]
        /* 0x7044 */ public Vector2f InteractionLabelScreenMin;
        [NMS(Index = 1085)]
        /* 0x704C */ public Vector2f InteractionLabelSize;
        [NMS(Index = 1087)]
        /* 0x7054 */ public Vector2f InteractionLabelTouchAreaMax;
        [NMS(Index = 1086)]
        /* 0x705C */ public Vector2f InteractionLabelTouchAreaMin;
        [NMS(Index = 1401)]
        /* 0x7064 */ public Vector2f InteractionWorldParallax;
        [NMS(Index = 545)]
        /* 0x706C */ public Vector2f IntermediateInteractionPageCursorOffset;
        [NMS(Index = 214)]
        /* 0x7074 */ public Vector2f InWorldGameGuiAlignment;
        [NMS(Index = 149)]
        /* 0x707C */ public Vector2f InWorldInteractLabelAlignment;
        [NMS(Index = 213)]
        /* 0x7084 */ public Vector2f InWorldNGuiParallax;
        [NMS(Index = 529)]
        /* 0x708C */ public Vector2f MainMenuSaveIconPosition;
        [NMS(Index = 204)]
        /* 0x7094 */ public Vector2f MarkerDistanceVRAlignment;
        [NMS(Index = 495)]
        /* 0x709C */ public Vector2f ModelViewWorldParallax;
        [NMS(Index = 1398)]
        /* 0x70A4 */ public Vector2f NGuiMax2DParallax;
        [NMS(Index = 1397)]
        /* 0x70AC */ public Vector2f NGuiMin2DParallax;
        [NMS(Index = 1399)]
        /* 0x70B4 */ public Vector2f NGuiModelParallax;
        [NMS(Index = 1400)]
        /* 0x70BC */ public Vector2f NGuiShipInteractParallax;
        [NMS(Index = 1215)]
        /* 0x70C4 */ public Vector2f NGuiTouchPadSensitivity;
        [NMS(Index = 942)]
        /* 0x70CC */ public Vector2f NotificationMissionHintPauseTime;
        [NMS(Index = 943)]
        /* 0x70D4 */ public Vector2f NotificationMissionHintPauseTimeCritical;
        [NMS(Index = 944)]
        /* 0x70DC */ public Vector2f NotificationMissionHintPauseTimeSecondary;
        [NMS(Index = 485)]
        /* 0x70E4 */ public Vector2f PersonalRefinerInputPos;
        [NMS(Index = 486)]
        /* 0x70EC */ public Vector2f PersonalRefinerOutputPos;
        [NMS(Index = 99)]
        /* 0x70F4 */ public Vector2f PickingCursorOffset;
        [NMS(Index = 978)]
        /* 0x70FC */ public Vector2f PlanetLabelOffset;
        [NMS(Index = 982)]
        /* 0x7104 */ public Vector2f PlanetLineOffset;
        [NMS(Index = 979)]
        /* 0x710C */ public Vector2f PlanetMeasureOffset;
        [NMS(Index = 980)]
        /* 0x7114 */ public Vector2f PlanetMeasureOffsetBigText;
        [NMS(Index = 981)]
        /* 0x711C */ public Vector2f PlanetMeasureOffsetMoonExtra;
        [NMS(Index = 494)]
        /* 0x7124 */ public Vector2f RefinerParallax;
        [NMS(Index = 528)]
        /* 0x712C */ public Vector2f SaveIconPosition;
        [NMS(Index = 1079)]
        /* 0x7134 */ public Vector2f ScanLabelOffset;
        [NMS(Index = 1025)]
        /* 0x713C */ public Vector2f TargetScreenCamOffset;
        [NMS(Index = 778)]
        /* 0x7144 */ public Vector2f TrackCriticalHitOffset;
        [NMS(Index = 742)]
        /* 0x714C */ public Vector2f TrackTypeIconOffset;
        [NMS(Index = 1432)]
        /* 0x7154 */ public int AbandonedFreighterAirlockRoomNumber;
        [NMS(Index = 1450)]
        /* 0x7158 */ public float AccessibleUIHUDPopupScale;
        [NMS(Index = 1448)]
        /* 0x715C */ public float AccessibleUIPopupScale;
        [NMS(Index = 187)]
        /* 0x7160 */ public float AlignmentRequiredToDisableFrostedGlass;
        [NMS(Index = 1360)]
        /* 0x7164 */ public float AltimeterLineSpacing;
        [NMS(Index = 1363)]
        /* 0x7168 */ public float AltimeterMax;
        [NMS(Index = 1362)]
        /* 0x716C */ public float AltimeterMin;
        [NMS(Index = 1365)]
        /* 0x7170 */ public float AltimeterMinValue;
        [NMS(Index = 1359)]
        /* 0x7174 */ public float AltimeterResolution;
        [NMS(Index = 1364)]
        /* 0x7178 */ public float AltimeterTextSize;
        [NMS(Index = 1361)]
        /* 0x717C */ public float AltimeterWidth;
        [NMS(Index = 1054)]
        /* 0x7180 */ public float AlwaysOnHazardMultiplierCold;
        [NMS(Index = 1052)]
        /* 0x7184 */ public float AlwaysOnHazardMultiplierHeat;
        [NMS(Index = 1053)]
        /* 0x7188 */ public float AlwaysOnHazardMultiplierRad;
        [NMS(Index = 1059)]
        /* 0x718C */ public float AlwaysOnHazardMultiplierSpook;
        [NMS(Index = 1051)]
        /* 0x7190 */ public float AlwaysOnHazardMultiplierTox;
        [NMS(Index = 1049)]
        /* 0x7194 */ public float AlwaysOnHazardStrengthCold;
        [NMS(Index = 1047)]
        /* 0x7198 */ public float AlwaysOnHazardStrengthHeat;
        [NMS(Index = 1048)]
        /* 0x719C */ public float AlwaysOnHazardStrengthRad;
        [NMS(Index = 1050)]
        /* 0x71A0 */ public float AlwaysOnHazardStrengthSpook;
        [NMS(Index = 1046)]
        /* 0x71A4 */ public float AlwaysOnHazardStrengthTox;
        [NMS(Index = 1045)]
        /* 0x71A8 */ public float AlwaysOnHazardThreshold;
        [NMS(Index = 687)]
        /* 0x71AC */ public float AlwaysShowIconFadeDistance;
        [NMS(Index = 688)]
        /* 0x71B0 */ public float AlwaysShowIconFadeRange;
        [NMS(Index = 1423)]
        /* 0x71B4 */ public float AmbientModeFadeTime;
        [NMS(Index = 682)]
        /* 0x71B8 */ public float ArrowBounceLeftRate1;
        [NMS(Index = 683)]
        /* 0x71BC */ public float ArrowBounceLeftRate2;
        [NMS(Index = 684)]
        /* 0x71C0 */ public float ArrowBounceLeftRate3;
        [NMS(Index = 677)]
        /* 0x71C4 */ public float ArrowBounceLength;
        [NMS(Index = 678)]
        /* 0x71C8 */ public float ArrowBounceRate;
        [NMS(Index = 679)]
        /* 0x71CC */ public float ArrowBounceRightRate1;
        [NMS(Index = 680)]
        /* 0x71D0 */ public float ArrowBounceRightRate2;
        [NMS(Index = 1374)]
        /* 0x71D4 */ public float AsteroidMarkerMinDisplayAngleDegrees;
        [NMS(Index = 1373)]
        /* 0x71D8 */ public float AsteroidMarkerMinDisplayDistance;
        [NMS(Index = 436)]
        /* 0x71DC */ public float BaseBuildingFreeRotateDelayBeforeAudioStops;
        [NMS(Index = 435)]
        /* 0x71E0 */ public float BaseBuildingFreeRotateDelayBeforeReset;
        [NMS(Index = 434)]
        /* 0x71E4 */ public float BaseBuildingFreeRotateSpeedPadMultiplier;
        [NMS(Index = 428)]
        /* 0x71E8 */ public float BaseBuildingInputHighlightAlpha;
        [NMS(Index = 427)]
        /* 0x71EC */ public float BaseBuildingInputHighlightDuration;
        [NMS(Index = 431)]
        /* 0x71F0 */ public float BaseBuildingMaxFreeRotateSpeed;
        [NMS(Index = 430)]
        /* 0x71F4 */ public float BaseBuildingMinFreeRotateSpeed;
        [NMS(Index = 447)]
        /* 0x71F8 */ public float BaseBuildingPartsGridBreadcrumbFlashDuration;
        [NMS(Index = 446)]
        /* 0x71FC */ public float BaseBuildingPartsGridMaxCursorRestorationTime;
        [NMS(Index = 448)]
        /* 0x7200 */ public float BaseBuildingPartsGridMinVisibilityForActive;
        [NMS(Index = 451)]
        /* 0x7204 */ public float BaseBuildingPartsGridPopupDelay;
        [NMS(Index = 449)]
        /* 0x7208 */ public float BaseBuildingPartsGridScrollSpeed;
        [NMS(Index = 450)]
        /* 0x720C */ public float BaseBuildingPartsGridScrollSpeedPad;
        [NMS(Index = 426)]
        /* 0x7210 */ public float BaseBuildingPinHighlightDuration;
        [NMS(Index = 433)]
        /* 0x7214 */ public float BaseBuildingRotationResetRate;
        [NMS(Index = 429)]
        /* 0x7218 */ public float BaseBuildingScaleSpeed;
        [NMS(Index = 432)]
        /* 0x721C */ public float BaseBuildingTimeToMaxRotationSpeed;
        [NMS(Index = 445)]
        /* 0x7220 */ public float BaseBuildingUIAdjustTime;
        [NMS(Index = 444)]
        /* 0x7224 */ public float BaseBuildingUIErrorFadeTime;
        [NMS(Index = 438)]
        /* 0x7228 */ public float BaseBuildingUIHorizontalSafeArea;
        [NMS(Index = 441)]
        /* 0x722C */ public float BaseBuildingUIVerticalOffset;
        [NMS(Index = 442)]
        /* 0x7230 */ public float BaseBuildingUIVerticalOffsetEdit;
        [NMS(Index = 443)]
        /* 0x7234 */ public float BaseBuildingUIVerticalOffsetFromBB;
        [NMS(Index = 440)]
        /* 0x7238 */ public float BaseBuildingUIVerticalPosWiring;
        [NMS(Index = 439)]
        /* 0x723C */ public float BaseBuildingUIVerticalSafeArea;
        [NMS(Index = 400)]
        /* 0x7240 */ public float BaseComplexityDangerFactor;
        [NMS(Index = 401)]
        /* 0x7244 */ public float BaseComplexityWarningFactor;
        [NMS(Index = 12)]
        /* 0x7248 */ public float BattleHUDBarInterpTime;
        [NMS(Index = 172)]
        /* 0x724C */ public float BeaconHUDMarkerOffset;
        [NMS(Index = 176)]
        /* 0x7250 */ public float BinocularMarkerSideAngle;
        [NMS(Index = 177)]
        /* 0x7254 */ public float BinocularMarkerUpAngle;
        [NMS(Index = 186)]
        /* 0x7258 */ public float BinocularsAltUIRescaleFactor;
        [NMS(Index = 174)]
        /* 0x725C */ public float BinocularScreenOffset;
        [NMS(Index = 175)]
        /* 0x7260 */ public float BinocularScreenScale;
        [NMS(Index = 184)]
        /* 0x7264 */ public float BinocularsFarIconDist;
        [NMS(Index = 185)]
        /* 0x7268 */ public float BinocularsFarIconFadeDist;
        [NMS(Index = 183)]
        /* 0x726C */ public float BinocularsFarIconOpacity;
        [NMS(Index = 182)]
        /* 0x7270 */ public float BinocularsMidIconOpacity;
        [NMS(Index = 180)]
        /* 0x7274 */ public float BinocularsNearIconDist;
        [NMS(Index = 181)]
        /* 0x7278 */ public float BinocularsNearIconFadeDist;
        [NMS(Index = 179)]
        /* 0x727C */ public float BinocularsNearIconOpacity;
        [NMS(Index = 512)]
        /* 0x7280 */ public float BountyMarkerOffset;
        [NMS(Index = 1428)]
        /* 0x7284 */ public int BuildingShopMaxItems;
        [NMS(Index = 405)]
        /* 0x7288 */ public float BuildMenuActionMessageDuration;
        [NMS(Index = 269)]
        /* 0x728C */ public float BuildMenuItemNavAnimTime;
        [NMS(Index = 270)]
        /* 0x7290 */ public float BuildMenuItemNextNavAnimTime;
        [NMS(Index = 271)]
        /* 0x7294 */ public float BuildMenuItemNextNavAnimWait;
        [NMS(Index = 1149)]
        /* 0x7298 */ public float ByteBeatArpLineWidth;
        [NMS(Index = 1151)]
        /* 0x729C */ public float ByteBeatArpPad;
        [NMS(Index = 1150)]
        /* 0x72A0 */ public float ByteBeatArpRadius;
        [NMS(Index = 1147)]
        /* 0x72A4 */ public float ByteBeatIconLineWidth;
        [NMS(Index = 1148)]
        /* 0x72A8 */ public float ByteBeatIconPad;
        [NMS(Index = 1158)]
        /* 0x72AC */ public float ByteBeatPartSequencerPad;
        [NMS(Index = 1160)]
        /* 0x72B0 */ public float ByteBeatRhythmBeatPad;
        [NMS(Index = 1164)]
        /* 0x72B4 */ public float ByteBeatRhythmSequencerActiveSaturation;
        [NMS(Index = 1163)]
        /* 0x72B8 */ public float ByteBeatRhythmSequencerInactiveSaturation;
        [NMS(Index = 1162)]
        /* 0x72BC */ public float ByteBeatSequencerActiveSaturation;
        [NMS(Index = 1159)]
        /* 0x72C0 */ public float ByteBeatSequencerCornerRadius;
        [NMS(Index = 1178)]
        /* 0x72C4 */ public float ByteBeatSequencerHighlightLineWidth;
        [NMS(Index = 1161)]
        /* 0x72C8 */ public float ByteBeatSequencerInactiveSaturation;
        [NMS(Index = 1156)]
        /* 0x72CC */ public float ByteBeatSequencerLineWidth;
        [NMS(Index = 1157)]
        /* 0x72D0 */ public float ByteBeatSequencerPad;
        [NMS(Index = 1165)]
        /* 0x72D4 */ public float ByteBeatSequencerUnpoweredTintStrength;
        [NMS(Index = 1181)]
        /* 0x72D8 */ public float ByteBeatSliderCornerRadius;
        [NMS(Index = 1179)]
        /* 0x72DC */ public float ByteBeatSliderLineWidth;
        [NMS(Index = 1180)]
        /* 0x72E0 */ public float ByteBeatSliderPad;
        [NMS(Index = 1185)]
        /* 0x72E4 */ public float ByteBeatSwitchPanelAlpha;
        [NMS(Index = 1186)]
        /* 0x72E8 */ public float ByteBeatSwitchPanelSplit;
        [NMS(Index = 1142)]
        /* 0x72EC */ public float ByteBeatTreeLineWidth;
        [NMS(Index = 1144)]
        /* 0x72F0 */ public float ByteBeatVisLineWidth;
        [NMS(Index = 132)]
        /* 0x72F4 */ public float ClosestDoorMarkerBuffer;
        [NMS(Index = 199)]
        /* 0x72F8 */ public float CockpitGlassDefrostTime;
        [NMS(Index = 198)]
        /* 0x72FC */ public float CockpitGlassFrostTime;
        [NMS(Index = 571)]
        /* 0x7300 */ public float CommunicatorMessageTime;
        [NMS(Index = 396)]
        /* 0x7304 */ public float CompassAngleClamp;
        [NMS(Index = 399)]
        /* 0x7308 */ public float CompassAngleClampSpace;
        [NMS(Index = 397)]
        /* 0x730C */ public float CompassAngleFade;
        [NMS(Index = 393)]
        /* 0x7310 */ public float CompassDistanceMarkerMinScale;
        [NMS(Index = 394)]
        /* 0x7314 */ public float CompassDistanceMaxAngle;
        [NMS(Index = 391)]
        /* 0x7318 */ public float CompassDistanceScale;
        [NMS(Index = 387)]
        /* 0x731C */ public float CompassDistanceScaleMin;
        [NMS(Index = 388)]
        /* 0x7320 */ public float CompassDistanceScaleRange;
        [NMS(Index = 392)]
        /* 0x7324 */ public float CompassDistanceShipMinScale;
        [NMS(Index = 389)]
        /* 0x7328 */ public float CompassDistanceSpaceScaleMin;
        [NMS(Index = 390)]
        /* 0x732C */ public float CompassDistanceSpaceScaleRange;
        [NMS(Index = 395)]
        /* 0x7330 */ public float CompassDistanceYOffset;
        [NMS(Index = 385)]
        /* 0x7334 */ public float CompassHeight;
        [NMS(Index = 205)]
        /* 0x7338 */ public float CompassIconOffsetVR;
        [NMS(Index = 226)]
        /* 0x733C */ public float CompassLineContractionEndAngle;
        [NMS(Index = 225)]
        /* 0x7340 */ public float CompassLineContractionStartAngle;
        [NMS(Index = 227)]
        /* 0x7344 */ public float CompassLineContractionTargetAngle;
        [NMS(Index = 231)]
        /* 0x7348 */ public float CompassLineNotchAngleRange;
        [NMS(Index = 233)]
        /* 0x734C */ public float CompassLineNotchLength;
        [NMS(Index = 232)]
        /* 0x7350 */ public float CompassLineNotchThickness;
        [NMS(Index = 228)]
        /* 0x7354 */ public int CompassLineNumNotches;
        [NMS(Index = 230)]
        /* 0x7358 */ public float CompassLineOffset;
        [NMS(Index = 229)]
        /* 0x735C */ public float CompassLineThickness;
        [NMS(Index = 224)]
        /* 0x7360 */ public int CompassScreenHeight;
        [NMS(Index = 223)]
        /* 0x7364 */ public int CompassScreenWidth;
        [NMS(Index = 386)]
        /* 0x7368 */ public float CompassWidth;
        [NMS(Index = 601)]
        /* 0x736C */ public float ConsoleTextSpeed;
        [NMS(Index = 603)]
        /* 0x7370 */ public float ConsoleTextTimeMax;
        [NMS(Index = 602)]
        /* 0x7374 */ public float ConsoleTextTimeMin;
        [NMS(Index = 729)]
        /* 0x7378 */ public float ControlScrollDistance;
        [NMS(Index = 728)]
        /* 0x737C */ public int ControlScrollSteps;
        [NMS(Index = 614)]
        /* 0x7380 */ public float CreatureDistanceAlpha;
        [NMS(Index = 612)]
        /* 0x7384 */ public float CreatureDistanceDisplayAngle;
        [NMS(Index = 613)]
        /* 0x7388 */ public float CreatureDistanceFadeTime;
        [NMS(Index = 610)]
        /* 0x738C */ public float CreatureDistanceOffsetY;
        [NMS(Index = 611)]
        /* 0x7390 */ public float CreatureDistanceShadowOffset;
        [NMS(Index = 609)]
        /* 0x7394 */ public float CreatureDistanceSize;
        [NMS(Index = 377)]
        /* 0x7398 */ public float CreatureIconMergeAngle;
        [NMS(Index = 646)]
        /* 0x739C */ public float CreatureIconOffset;
        [NMS(Index = 647)]
        /* 0x73A0 */ public float CreatureIconOffsetPhysics;
        [NMS(Index = 768)]
        /* 0x73A4 */ public float CreatureInteractLabelOffsetY;
        [NMS(Index = 764)]
        /* 0x73A8 */ public float CreatureReticuleScale;
        [NMS(Index = 734)]
        /* 0x73AC */ public float CreatureRoutineMarkerTime;
        [NMS(Index = 735)]
        /* 0x73B0 */ public int CreatureRoutineRegionsPerFrame;
        [NMS(Index = 820)]
        /* 0x73B4 */ public float CriticalMessageTime;
        [NMS(Index = 696)]
        /* 0x73B8 */ public float CrosshairAimOffTime;
        [NMS(Index = 695)]
        /* 0x73BC */ public float CrosshairAimTime;
        [NMS(Index = 697)]
        /* 0x73C0 */ public float CrosshairInnerMinFade;
        [NMS(Index = 698)]
        /* 0x73C4 */ public float CrosshairInnerMinFadeRange;
        [NMS(Index = 719)]
        /* 0x73C8 */ public float CrosshairInterceptAlpha;
        [NMS(Index = 716)]
        /* 0x73CC */ public float CrosshairInterceptBaseSize;
        [NMS(Index = 717)]
        /* 0x73D0 */ public float CrosshairInterceptCentreBaseSize;
        [NMS(Index = 720)]
        /* 0x73D4 */ public float CrosshairInterceptLockRange;
        [NMS(Index = 715)]
        /* 0x73D8 */ public float CrosshairInterceptSize;
        [NMS(Index = 718)]
        /* 0x73DC */ public float CrosshairInterceptSpringTime;
        [NMS(Index = 702)]
        /* 0x73E0 */ public float CrosshairLeadCornerOffset;
        [NMS(Index = 711)]
        /* 0x73E4 */ public float CrosshairLeadFadeRange;
        [NMS(Index = 712)]
        /* 0x73E8 */ public float CrosshairLeadFadeSize;
        [NMS(Index = 700)]
        /* 0x73EC */ public float CrosshairLeadInDelay;
        [NMS(Index = 701)]
        /* 0x73F0 */ public float CrosshairLeadInTime;
        [NMS(Index = 705)]
        /* 0x73F4 */ public float CrosshairLeadPulseSize;
        [NMS(Index = 699)]
        /* 0x73F8 */ public float CrosshairLeadScaleIn;
        [NMS(Index = 709)]
        /* 0x73FC */ public float CrosshairLeadSpring;
        [NMS(Index = 710)]
        /* 0x7400 */ public float CrosshairLeadSpringOff;
        [NMS(Index = 704)]
        /* 0x7404 */ public float CrosshairLeadTopLock;
        [NMS(Index = 703)]
        /* 0x7408 */ public float CrosshairLeadTopOffset;
        [NMS(Index = 309)]
        /* 0x740C */ public float CrosshairOffsetHmd;
        [NMS(Index = 310)]
        /* 0x7410 */ public float CrosshairOffsetHmdUp;
        [NMS(Index = 308)]
        /* 0x7414 */ public float CrosshairScaleHmd;
        [NMS(Index = 312)]
        /* 0x7418 */ public int CrosshairScreenHeight;
        [NMS(Index = 311)]
        /* 0x741C */ public int CrosshairScreenWidth;
        [NMS(Index = 708)]
        /* 0x7420 */ public float CrosshairSpringAimTime;
        [NMS(Index = 707)]
        /* 0x7424 */ public float CrosshairSpringTime;
        [NMS(Index = 721)]
        /* 0x7428 */ public float CrosshairTargetLockSize;
        [NMS(Index = 1111)]
        /* 0x742C */ public float CursorHoverSlowFactor;
        [NMS(Index = 1112)]
        /* 0x7430 */ public float CursorHoverSlowFactorMin;
        [NMS(Index = 1109)]
        /* 0x7434 */ public float CursorHoverSlowFixedValue;
        [NMS(Index = 543)]
        /* 0x7438 */ public float DamageDirectionIndicatorOnScreenRadiusMultiplier;
        [NMS(Index = 616)]
        /* 0x743C */ public float DamageImpactMergeTime;
        [NMS(Index = 618)]
        /* 0x7440 */ public float DamageImpactMinDistance;
        [NMS(Index = 617)]
        /* 0x7444 */ public float DamageImpactTimeBetweenNumbers;
        [NMS(Index = 627)]
        /* 0x7448 */ public float DamageNumberBlackAlpha;
        [NMS(Index = 633)]
        /* 0x744C */ public float DamageNumberFadeIn;
        [NMS(Index = 634)]
        /* 0x7450 */ public float DamageNumberFadeOut;
        [NMS(Index = 626)]
        /* 0x7454 */ public float DamageNumberLaserMaxDamage;
        [NMS(Index = 625)]
        /* 0x7458 */ public float DamageNumberLaserMinDamage;
        [NMS(Index = 630)]
        /* 0x745C */ public float DamageNumberOffsetX;
        [NMS(Index = 631)]
        /* 0x7460 */ public float DamageNumberOffsetY;
        [NMS(Index = 628)]
        /* 0x7464 */ public float DamageNumberOutline;
        [NMS(Index = 629)]
        /* 0x7468 */ public float DamageNumberOutline2;
        [NMS(Index = 622)]
        /* 0x746C */ public float DamageNumberSize;
        [NMS(Index = 623)]
        /* 0x7470 */ public float DamageNumberSizeCritMultiplier;
        [NMS(Index = 621)]
        /* 0x7474 */ public float DamageNumberSizeInShip;
        [NMS(Index = 624)]
        /* 0x7478 */ public float DamageNumberSizeLaserMultiplier;
        [NMS(Index = 620)]
        /* 0x747C */ public float DamageNumberTime;
        [NMS(Index = 635)]
        /* 0x7480 */ public float DamageNumberUpOffset;
        [NMS(Index = 619)]
        /* 0x7484 */ public float DamagePerSecondSampleTime;
        [NMS(Index = 465)]
        /* 0x7488 */ public float DamageScannableHighlightTime;
        [NMS(Index = 466)]
        /* 0x748C */ public float DamageTrackArrowTime;
        [NMS(Index = 951)]
        /* 0x7490 */ public float DeathMessageSwitchTime;
        [NMS(Index = 952)]
        /* 0x7494 */ public float DeathMessageTotalTime;
        [NMS(Index = 64)]
        /* 0x7498 */ public int DebugMedalRank;
        [NMS(Index = 1058)]
        /* 0x749C */ public float DeepSeaHazardMultiplierCold;
        [NMS(Index = 1056)]
        /* 0x74A0 */ public float DeepSeaHazardMultiplierHeat;
        [NMS(Index = 1057)]
        /* 0x74A4 */ public float DeepSeaHazardMultiplierRad;
        [NMS(Index = 1055)]
        /* 0x74A8 */ public float DeepSeaHazardMultiplierTox;
        [NMS(Index = 648)]
        /* 0x74AC */ public float DelayBeforeHidingHangarAfterGalaxyMap;
        [NMS(Index = 649)]
        /* 0x74B0 */ public float DelayBeforeShowingHangarIntoGalaxyMap;
        [NMS(Index = 596)]
        /* 0x74B4 */ public float DescriptionTextDelay;
        [NMS(Index = 597)]
        /* 0x74B8 */ public float DescriptionTextSpeed;
        [NMS(Index = 598)]
        /* 0x74BC */ public float DescriptionTextSpeedProgressive;
        [NMS(Index = 600)]
        /* 0x74C0 */ public float DescriptionTextTimeMax;
        [NMS(Index = 599)]
        /* 0x74C4 */ public float DescriptionTextTimeMin;
        [NMS(Index = 1451)]
        /* 0x74C8 */ public float DetailMessageDismissTime;
        [NMS(Index = 359)]
        /* 0x74CC */ public float DroneIndicatorCentreRadiusMax;
        [NMS(Index = 360)]
        /* 0x74D0 */ public float DroneIndicatorCentreRadiusMin;
        [NMS(Index = 361)]
        /* 0x74D4 */ public float DroneIndicatorFadeRange;
        [NMS(Index = 358)]
        /* 0x74D8 */ public float DroneIndicatorRadius;
        [NMS(Index = 112)]
        /* 0x74DC */ public float EggModifiyAnimLoopTime;
        [NMS(Index = 111)]
        /* 0x74E0 */ public float EggModifiyAnimMaxSize;
        [NMS(Index = 122)]
        /* 0x74E4 */ public float EndOfSeasonAlertDelay;
        [NMS(Index = 161)]
        /* 0x74E8 */ public float ExocraftHUDMarkerHideDistance;
        [NMS(Index = 162)]
        /* 0x74EC */ public float ExocraftHUDMarkerOffset;
        [NMS(Index = 119)]
        /* 0x74F0 */ public float ExpeditionStageChangeTime;
        [NMS(Index = 58)]
        /* 0x74F4 */ public float EyeTrackingCursorBlendRate;
        [NMS(Index = 57)]
        /* 0x74F8 */ public float EyeTrackingCursorBlendRateGameModeSelect;
        [NMS(Index = 56)]
        /* 0x74FC */ public float EyeTrackingPopupLookAwayTime;
        [NMS(Index = 59)]
        /* 0x7500 */ public float EyeTrackingStickyHoverTime;
        [NMS(Index = 55)]
        /* 0x7504 */ public float EyeTrackingTimeBeforePopupsActivate;
        [NMS(Index = 1459)]
        /* 0x7508 */ public float FeedFrigateAnimAlphaChange;
        [NMS(Index = 1457)]
        /* 0x750C */ public int FeedFrigateAnimNumPeriods;
        [NMS(Index = 1456)]
        /* 0x7510 */ public float FeedFrigateAnimPeriod;
        [NMS(Index = 1458)]
        /* 0x7514 */ public float FeedFrigateAnimScaleChange;
        [NMS(Index = 127)]
        /* 0x7518 */ public int ForceOpenHazardProtInventoryThreshold;
        [NMS(Index = 661)]
        /* 0x751C */ public float FreighterCommanderMarkerMinDistance;
        [NMS(Index = 692)]
        /* 0x7520 */ public float FreighterEntranceOffset;
        [NMS(Index = 667)]
        /* 0x7524 */ public float FreighterHighlightRange;
        [NMS(Index = 691)]
        /* 0x7528 */ public float FreighterLeaderIconDistance;
        [NMS(Index = 101)]
        /* 0x752C */ public float FreighterMegaWarpTransitionTime;
        [NMS(Index = 657)]
        /* 0x7530 */ public float FreighterSummonDelay;
        [NMS(Index = 660)]
        /* 0x7534 */ public float FreighterSummonGridSize;
        [NMS(Index = 666)]
        /* 0x7538 */ public float FreighterSummonLookTime;
        [NMS(Index = 652)]
        /* 0x753C */ public float FreighterSummonOffset;
        [NMS(Index = 653)]
        /* 0x7540 */ public float FreighterSummonOffsetPulse;
        [NMS(Index = 651)]
        /* 0x7544 */ public float FreighterSummonPitch;
        [NMS(Index = 665)]
        /* 0x7548 */ public float FreighterSummonPlanetOffset;
        [NMS(Index = 664)]
        /* 0x754C */ public float FreighterSummonPulseFadeAmount;
        [NMS(Index = 663)]
        /* 0x7550 */ public float FreighterSummonPulseRate;
        [NMS(Index = 650)]
        /* 0x7554 */ public float FreighterSummonTurn;
        [NMS(Index = 659)]
        /* 0x7558 */ public float FreighterSummonTurnAngleIncrement;
        [NMS(Index = 658)]
        /* 0x755C */ public int FreighterSummonTurnNumTries;
        [NMS(Index = 662)]
        /* 0x7560 */ public float FreighterSurfaceMinAngle;
        [NMS(Index = 690)]
        /* 0x7564 */ public float FrigateDamageIconVisibilityDistance;
        [NMS(Index = 645)]
        /* 0x7568 */ public float FrigateIconOffset;
        [NMS(Index = 689)]
        /* 0x756C */ public float FrigatePurchaseNotificationResetDistanceMultiplier;
        [NMS(Index = 1131)]
        /* 0x7570 */ public float FrontendActivateSplit;
        [NMS(Index = 1130)]
        /* 0x7574 */ public float FrontendActivateTime;
        [NMS(Index = 1115)]
        /* 0x7578 */ public float FrontendBGAlpha;
        [NMS(Index = 1135)]
        /* 0x757C */ public float FrontendBootBarTime;
        [NMS(Index = 1134)]
        /* 0x7580 */ public float FrontendBootTime;
        [NMS(Index = 1119)]
        /* 0x7584 */ public float FrontendConfirmTime;
        [NMS(Index = 1117)]
        /* 0x7588 */ public float FrontendConfirmTimeFast;
        [NMS(Index = 1116)]
        /* 0x758C */ public float FrontendConfirmTimeMouseMultiplier;
        [NMS(Index = 1120)]
        /* 0x7590 */ public float FrontendConfirmTimeSlow;
        [NMS(Index = 1123)]
        /* 0x7594 */ public float FrontendCursorOffset;
        [NMS(Index = 1122)]
        /* 0x7598 */ public float FrontendCursorSize;
        [NMS(Index = 1127)]
        /* 0x759C */ public float FrontendCursorWidth;
        [NMS(Index = 1129)]
        /* 0x75A0 */ public float FrontendDeactivateSplit;
        [NMS(Index = 1128)]
        /* 0x75A4 */ public float FrontendDeactivateTime;
        [NMS(Index = 1207)]
        /* 0x75A8 */ public float FrontendDoFBlurMultiplier;
        [NMS(Index = 1205)]
        /* 0x75AC */ public float FrontendDoFFarPlane;
        [NMS(Index = 1206)]
        /* 0x75B0 */ public float FrontendDoFFarPlaneFade;
        [NMS(Index = 1204)]
        /* 0x75B4 */ public float FrontendDoFNearPlane;
        [NMS(Index = 190)]
        /* 0x75B8 */ public float FrontendOffsetVR;
        [NMS(Index = 1209)]
        /* 0x75BC */ public float FrontendShineSpeed;
        [NMS(Index = 1132)]
        /* 0x75C0 */ public float FrontendStatCircleWidth;
        [NMS(Index = 1133)]
        /* 0x75C4 */ public float FrontendStatCircleWidthExtra;
        [NMS(Index = 1212)]
        /* 0x75C8 */ public float FrontendTitleFontSpacing;
        [NMS(Index = 1210)]
        /* 0x75CC */ public float FrontendToolbarTextHeight;
        [NMS(Index = 1211)]
        /* 0x75D0 */ public float FrontendToolbarTextHeightSelected;
        [NMS(Index = 1118)]
        /* 0x75D4 */ public float FrontendTouchConfirmTimeFastMultiplier;
        [NMS(Index = 591)]
        /* 0x75D8 */ public float FrontendWaitFadeProgressiveDialogOut;
        [NMS(Index = 590)]
        /* 0x75DC */ public float FrontendWaitFadeTextFrameOut;
        [NMS(Index = 589)]
        /* 0x75E0 */ public float FrontendWaitFadeTextOut;
        [NMS(Index = 587)]
        /* 0x75E4 */ public float FrontendWaitInitial;
        [NMS(Index = 588)]
        /* 0x75E8 */ public float FrontendWaitInitialTerminal;
        [NMS(Index = 586)]
        /* 0x75EC */ public float FrontendWaitResponse;
        [NMS(Index = 592)]
        /* 0x75F0 */ public float FrontendWaitResponseOffset;
        [NMS(Index = 885)]
        /* 0x75F4 */ public float GalaxyMapRadialBorder;
        [NMS(Index = 886)]
        /* 0x75F8 */ public float GalaxyMapRadialTargetDist;
        [NMS(Index = 189)]
        /* 0x75FC */ public float GalmapDiscoveryOffsetVR;
        [NMS(Index = 110)]
        /* 0x7600 */ public float GameModeSelectColourFadeTime;
        [NMS(Index = 1465)]
        /* 0x7604 */ public float GDKHandheldMinFontHeight;
        [NMS(Index = 91)]
        /* 0x7608 */ public float GridDecayRateSwitchValue;
        [NMS(Index = 575)]
        /* 0x760C */ public float GridFlickerAmp;
        [NMS(Index = 573)]
        /* 0x7610 */ public float GridFlickerBaseAlpha;
        [NMS(Index = 574)]
        /* 0x7614 */ public float GridFlickerFreq;
        [NMS(Index = 252)]
        /* 0x7618 */ public float HandButtonClickTime;
        [NMS(Index = 248)]
        /* 0x761C */ public float HandButtonCursorScale;
        [NMS(Index = 256)]
        /* 0x7620 */ public float HandButtonDotRadius;
        [NMS(Index = 254)]
        /* 0x7624 */ public float HandButtonFrontendCursorScale;
        [NMS(Index = 250)]
        /* 0x7628 */ public float HandButtonNearDistance;
        [NMS(Index = 245)]
        /* 0x762C */ public float HandButtonPostClickTime;
        [NMS(Index = 257)]
        /* 0x7630 */ public float HandButtonPulseRadius;
        [NMS(Index = 258)]
        /* 0x7634 */ public float HandButtonPulseThickness;
        [NMS(Index = 249)]
        /* 0x7638 */ public float HandButtonPushDistance;
        [NMS(Index = 241)]
        /* 0x763C */ public float HandButtonRadius;
        [NMS(Index = 251)]
        /* 0x7640 */ public float HandButtonRadiusClick;
        [NMS(Index = 242)]
        /* 0x7644 */ public float HandButtonRadiusTouch;
        [NMS(Index = 243)]
        /* 0x7648 */ public float HandButtonRadiusTouchNear;
        [NMS(Index = 244)]
        /* 0x764C */ public float HandButtonRadiusTouchNearActive;
        [NMS(Index = 246)]
        /* 0x7650 */ public float HandButtonReleaseThreshold;
        [NMS(Index = 247)]
        /* 0x7654 */ public float HandButtonReleaseThresholdInit;
        [NMS(Index = 255)]
        /* 0x7658 */ public float HandButtonThickness;
        [NMS(Index = 253)]
        /* 0x765C */ public float HandButtonTouchReturnTime;
        [NMS(Index = 278)]
        /* 0x7660 */ public float HandControlButtonSize;
        [NMS(Index = 285)]
        /* 0x7664 */ public float HandControlMenuAngle;
        [NMS(Index = 235)]
        /* 0x7668 */ public float HandControlMenuCursorScale;
        [NMS(Index = 291)]
        /* 0x766C */ public float HandControlMenuDepth;
        [NMS(Index = 284)]
        /* 0x7670 */ public float HandControlMenuMoveActionDistance;
        [NMS(Index = 281)]
        /* 0x7674 */ public float HandControlMenuMoveDistance;
        [NMS(Index = 282)]
        /* 0x7678 */ public float HandControlMenuMoveDistanceScroll;
        [NMS(Index = 283)]
        /* 0x767C */ public float HandControlMenuMoveDistanceVertical;
        [NMS(Index = 287)]
        /* 0x7680 */ public float HandControlMenuSelectRadius;
        [NMS(Index = 288)]
        /* 0x7684 */ public float HandControlMenuSelectRadius1;
        [NMS(Index = 289)]
        /* 0x7688 */ public float HandControlMenuSelectRadius2;
        [NMS(Index = 286)]
        /* 0x768C */ public float HandControlMenuSurfaceOffset;
        [NMS(Index = 280)]
        /* 0x7690 */ public float HandControlPointActiveMargin;
        [NMS(Index = 279)]
        /* 0x7694 */ public float HandControlPointMargin;
        [NMS(Index = 290)]
        /* 0x7698 */ public float HandControlTopMenuSelectRadius;
        [NMS(Index = 135)]
        /* 0x769C */ public float HandheldHUDZoomFactor;
        [NMS(Index = 239)]
        /* 0x76A0 */ public float HandScreenGraphicsHeight;
        [NMS(Index = 238)]
        /* 0x76A4 */ public float HandScreenGraphicsWidth;
        [NMS(Index = 295)]
        /* 0x76A8 */ public int HandScreenHeight;
        [NMS(Index = 240)]
        /* 0x76AC */ public float HandScreenNearActivateDistance;
        [NMS(Index = 293)]
        /* 0x76B0 */ public int HandScreenWeaponHeight;
        [NMS(Index = 292)]
        /* 0x76B4 */ public int HandScreenWeaponWidth;
        [NMS(Index = 294)]
        /* 0x76B8 */ public int HandScreenWidth;
        [NMS(Index = 1202)]
        /* 0x76BC */ public float HatchAlphaBase;
        [NMS(Index = 1203)]
        /* 0x76C0 */ public float HatchAlphaCursor;
        [NMS(Index = 1201)]
        /* 0x76C4 */ public float HatchAlphaMain;
        [NMS(Index = 1199)]
        /* 0x76C8 */ public int HatchCount;
        [NMS(Index = 1200)]
        /* 0x76CC */ public float HatchCursorRadius;
        [NMS(Index = 1198)]
        /* 0x76D0 */ public float HatchPulsePauseTime;
        [NMS(Index = 1196)]
        /* 0x76D4 */ public float HatchPulseSpeed;
        [NMS(Index = 1197)]
        /* 0x76D8 */ public float HatchPulseWidth;
        [NMS(Index = 675)]
        /* 0x76DC */ public float HazardArrowsLevel2Threshold;
        [NMS(Index = 676)]
        /* 0x76E0 */ public float HazardArrowsLevel3Threshold;
        [NMS(Index = 1034)]
        /* 0x76E4 */ public float HazardBarPulseTime;
        [NMS(Index = 1039)]
        /* 0x76E8 */ public float HazardPainPulseStrength;
        [NMS(Index = 1060)]
        /* 0x76EC */ public float HazardPulseRate;
        [NMS(Index = 1031)]
        /* 0x76F0 */ public float HazardScreenEffectPulseRate;
        [NMS(Index = 1035)]
        /* 0x76F4 */ public float HazardScreenEffectPulseTime;
        [NMS(Index = 1036)]
        /* 0x76F8 */ public float HazardScreenEffectStrength;
        [NMS(Index = 1038)]
        /* 0x76FC */ public float HazardWarningPulseStrength;
        [NMS(Index = 1037)]
        /* 0x7700 */ public float HazardWarningPulseTime;
        [NMS(Index = 1222)]
        /* 0x7704 */ public float HitMarkerPulseSize;
        [NMS(Index = 1223)]
        /* 0x7708 */ public float HitMarkerPulseSizeStatic;
        [NMS(Index = 1224)]
        /* 0x770C */ public float HitMarkerPulseTime;
        [NMS(Index = 306)]
        /* 0x7710 */ public float HmdFramerateScreenPitch;
        [NMS(Index = 1027)]
        /* 0x7714 */ public float HoldTimerResetTime;
        [NMS(Index = 604)]
        /* 0x7718 */ public float HoverOffscreenBorder;
        [NMS(Index = 605)]
        /* 0x771C */ public float HoverOffscreenBorderXVR;
        [NMS(Index = 606)]
        /* 0x7720 */ public float HoverOffscreenBorderYAltUI;
        [NMS(Index = 51)]
        /* 0x7724 */ public float HoverPopAnimDuration;
        [NMS(Index = 50)]
        /* 0x7728 */ public float HoverPopScaleModification;
        [NMS(Index = 825)]
        /* 0x772C */ public float HUDDisplayTime;
        [NMS(Index = 771)]
        /* 0x7730 */ public float HUDDroneCombatPulse;
        [NMS(Index = 769)]
        /* 0x7734 */ public float HUDDroneHealingPulse;
        [NMS(Index = 770)]
        /* 0x7738 */ public float HUDDroneSummoningPulse;
        [NMS(Index = 963)]
        /* 0x773C */ public float HUDElementsOffsetHMDBottom;
        [NMS(Index = 961)]
        /* 0x7740 */ public float HUDElementsOffsetHMDSide;
        [NMS(Index = 962)]
        /* 0x7744 */ public float HUDElementsOffsetHMDTop;
        [NMS(Index = 964)]
        /* 0x7748 */ public float HUDElementsOffsetX_0;
        [NMS(Index = 966)]
        /* 0x774C */ public float HUDElementsOffsetX_1;
        [NMS(Index = 968)]
        /* 0x7750 */ public float HUDElementsOffsetX_2;
        [NMS(Index = 970)]
        /* 0x7754 */ public float HUDElementsOffsetX_3;
        [NMS(Index = 972)]
        /* 0x7758 */ public float HUDElementsOffsetX_4;
        [NMS(Index = 974)]
        /* 0x775C */ public float HUDElementsOffsetX_5;
        [NMS(Index = 965)]
        /* 0x7760 */ public float HUDElementsOffsetY_0;
        [NMS(Index = 967)]
        /* 0x7764 */ public float HUDElementsOffsetY_1;
        [NMS(Index = 969)]
        /* 0x7768 */ public float HUDElementsOffsetY_2;
        [NMS(Index = 971)]
        /* 0x776C */ public float HUDElementsOffsetY_3;
        [NMS(Index = 973)]
        /* 0x7770 */ public float HUDElementsOffsetY_4;
        [NMS(Index = 975)]
        /* 0x7774 */ public float HUDElementsOffsetY_5;
        [NMS(Index = 1356)]
        /* 0x7778 */ public float HUDMarkerActiveTime;
        [NMS(Index = 1351)]
        /* 0x777C */ public float HUDMarkerAlpha;
        [NMS(Index = 1326)]
        /* 0x7780 */ public float HUDMarkerAnimLoopTime;
        [NMS(Index = 1325)]
        /* 0x7784 */ public float HUDMarkerAnimOffset;
        [NMS(Index = 1324)]
        /* 0x7788 */ public float HUDMarkerAnimScale;
        [NMS(Index = 1323)]
        /* 0x778C */ public float HUDMarkerAnimSpeed;
        [NMS(Index = 469)]
        /* 0x7790 */ public float HUDMarkerDistanceOrTimeDistance;
        [NMS(Index = 1344)]
        /* 0x7794 */ public float HUDMarkerFarDistance;
        [NMS(Index = 1345)]
        /* 0x7798 */ public float HUDMarkerFarFadeRange;
        [NMS(Index = 1350)]
        /* 0x779C */ public float HUDMarkerHorizonBlendRange;
        [NMS(Index = 1332)]
        /* 0x77A0 */ public float HUDMarkerHoverAngleTestGround;
        [NMS(Index = 313)]
        /* 0x77A4 */ public float HUDMarkerHoverAngleTestGroundHmd;
        [NMS(Index = 1336)]
        /* 0x77A8 */ public float HUDMarkerHoverAngleTestShip;
        [NMS(Index = 1337)]
        /* 0x77AC */ public float HUDMarkerHoverShowLargeAngleTest;
        [NMS(Index = 1358)]
        /* 0x77B0 */ public float HUDMarkerIconHoverMinScale;
        [NMS(Index = 578)]
        /* 0x77B4 */ public float HUDMarkerLabelArriveDistance;
        [NMS(Index = 577)]
        /* 0x77B8 */ public float HUDMarkerLabelBaseWidth;
        [NMS(Index = 579)]
        /* 0x77BC */ public float HUDMarkerLabelDisplayDistance;
        [NMS(Index = 576)]
        /* 0x77C0 */ public float HUDMarkerLabelWidthMultiplier;
        [NMS(Index = 1353)]
        /* 0x77C4 */ public float HUDMarkerModelFadeMinHeight;
        [NMS(Index = 1352)]
        /* 0x77C8 */ public float HUDMarkerModelFadeRange;
        [NMS(Index = 1342)]
        /* 0x77CC */ public float HUDMarkerNearFadeDistance;
        [NMS(Index = 1343)]
        /* 0x77D0 */ public float HUDMarkerNearFadeRange;
        [NMS(Index = 580)]
        /* 0x77D4 */ public float HUDMarkerNonActiveMissionAlpha;
        [NMS(Index = 468)]
        /* 0x77D8 */ public float HUDMarkerObjectMinScreenDistance;
        [NMS(Index = 1306)]
        /* 0x77DC */ public float HUDMarkerOffset;
        [NMS(Index = 1329)]
        /* 0x77E0 */ public float HUDMarkerPrimaryIndicatorSize;
        [NMS(Index = 1346)]
        /* 0x77E4 */ public float HUDMarkerScalerMin;
        [NMS(Index = 1347)]
        /* 0x77E8 */ public float HUDMarkerScalerRange;
        [NMS(Index = 1349)]
        /* 0x77EC */ public float HUDMarkerScalerSizeMax;
        [NMS(Index = 1348)]
        /* 0x77F0 */ public float HUDMarkerScalerSizeMin;
        [NMS(Index = 1340)]
        /* 0x77F4 */ public float HUDMarkerShipOffsetMaxDist;
        [NMS(Index = 1341)]
        /* 0x77F8 */ public float HUDMarkerShipOffsetMinDist;
        [NMS(Index = 1354)]
        /* 0x77FC */ public float HUDMarkerShowActualIconDistance;
        [NMS(Index = 1355)]
        /* 0x7800 */ public float HUDMarkerShowActualSpaceIconDistance;
        [NMS(Index = 1335)]
        /* 0x7804 */ public float HUDMarkerWideHoverAngleTest;
        [NMS(Index = 314)]
        /* 0x7808 */ public float HUDMarkerWideHoverAngleTestHmd;
        [NMS(Index = 1334)]
        /* 0x780C */ public float HUDNetworkMarkerHoverAngleTestGround;
        [NMS(Index = 1339)]
        /* 0x7810 */ public float HUDNetworkMarkerHoverAngleVRMul;
        [NMS(Index = 1338)]
        /* 0x7814 */ public float HUDNetworkMarkerHoverShowLargeAngleTest;
        [NMS(Index = 1333)]
        /* 0x7818 */ public float HUDPetCentreScreenAngle;
        [NMS(Index = 1330)]
        /* 0x781C */ public float HUDPetMarkerAngleTest;
        [NMS(Index = 1331)]
        /* 0x7820 */ public float HUDPetMarkerAngleVRMul;
        [NMS(Index = 501)]
        /* 0x7824 */ public float HUDPlayerPhonePulseScanFreq;
        [NMS(Index = 500)]
        /* 0x7828 */ public float HUDPlayerSentinelPulseScanFreq;
        [NMS(Index = 498)]
        /* 0x782C */ public float HUDPlayerSentinelPulseWidth;
        [NMS(Index = 499)]
        /* 0x7830 */ public float HUDPlayerSentinelRangeFactor;
        [NMS(Index = 873)]
        /* 0x7834 */ public float HUDPlayerTrackArrowArrowSize;
        [NMS(Index = 842)]
        /* 0x7838 */ public float HUDPlayerTrackArrowDamageGlowHullHitCriticalOpacityScale;
        [NMS(Index = 843)]
        /* 0x783C */ public float HUDPlayerTrackArrowDamageGlowHullHitOpacityScale;
        [NMS(Index = 850)]
        /* 0x7840 */ public float HUDPlayerTrackArrowDamageGlowOffset;
        [NMS(Index = 846)]
        /* 0x7844 */ public float HUDPlayerTrackArrowDamageGlowShieldHitCriticalOpacityScale;
        [NMS(Index = 847)]
        /* 0x7848 */ public float HUDPlayerTrackArrowDamageGlowShieldHitOpacityScale;
        [NMS(Index = 874)]
        /* 0x784C */ public float HUDPlayerTrackArrowDotSize;
        [NMS(Index = 854)]
        /* 0x7850 */ public float HUDPlayerTrackArrowEnergyShieldDepletedGlowOpacityScale;
        [NMS(Index = 855)]
        /* 0x7854 */ public float HUDPlayerTrackArrowEnergyShieldDepletedTime;
        [NMS(Index = 852)]
        /* 0x7858 */ public float HUDPlayerTrackArrowEnergyShieldGlowOffset;
        [NMS(Index = 838)]
        /* 0x785C */ public float HUDPlayerTrackArrowEnergyShieldLowThreshold;
        [NMS(Index = 839)]
        /* 0x7860 */ public float HUDPlayerTrackArrowEnergyShieldOffset;
        [NMS(Index = 859)]
        /* 0x7864 */ public float HUDPlayerTrackArrowEnergyShieldStartChargeGlowOpacityScale;
        [NMS(Index = 860)]
        /* 0x7868 */ public float HUDPlayerTrackArrowEnergyShieldStartChargeTime;
        [NMS(Index = 882)]
        /* 0x786C */ public float HUDPlayerTrackArrowFadeRange;
        [NMS(Index = 841)]
        /* 0x7870 */ public float HUDPlayerTrackArrowGlowBaseOpacity;
        [NMS(Index = 834)]
        /* 0x7874 */ public float HUDPlayerTrackArrowHealthOffset;
        [NMS(Index = 797)]
        /* 0x7878 */ public float HUDPlayerTrackArrowIconBorderReducerShip;
        [NMS(Index = 794)]
        /* 0x787C */ public float HUDPlayerTrackArrowIconFadeDist;
        [NMS(Index = 793)]
        /* 0x7880 */ public float HUDPlayerTrackArrowIconFadeDistDrone;
        [NMS(Index = 792)]
        /* 0x7884 */ public float HUDPlayerTrackArrowIconFadeDistShip;
        [NMS(Index = 795)]
        /* 0x7888 */ public float HUDPlayerTrackArrowIconFadeRange;
        [NMS(Index = 796)]
        /* 0x788C */ public float HUDPlayerTrackArrowIconFadeRangeShip;
        [NMS(Index = 787)]
        /* 0x7890 */ public float HUDPlayerTrackArrowIconFadeTime;
        [NMS(Index = 791)]
        /* 0x7894 */ public float HUDPlayerTrackArrowIconPulse2Alpha;
        [NMS(Index = 785)]
        /* 0x7898 */ public float HUDPlayerTrackArrowIconPulseTime;
        [NMS(Index = 789)]
        /* 0x789C */ public float HUDPlayerTrackArrowIconPulseWidth1;
        [NMS(Index = 790)]
        /* 0x78A0 */ public float HUDPlayerTrackArrowIconPulseWidth2;
        [NMS(Index = 786)]
        /* 0x78A4 */ public float HUDPlayerTrackArrowIconShowTime;
        [NMS(Index = 871)]
        /* 0x78A8 */ public float HUDPlayerTrackArrowIconSize;
        [NMS(Index = 881)]
        /* 0x78AC */ public float HUDPlayerTrackArrowMinFadeDist;
        [NMS(Index = 866)]
        /* 0x78B0 */ public float HUDPlayerTrackArrowOffset;
        [NMS(Index = 798)]
        /* 0x78B4 */ public float HUDPlayerTrackArrowPulseOffset;
        [NMS(Index = 799)]
        /* 0x78B8 */ public float HUDPlayerTrackArrowPulseRate;
        [NMS(Index = 867)]
        /* 0x78BC */ public float HUDPlayerTrackArrowScreenBorder;
        [NMS(Index = 784)]
        /* 0x78C0 */ public float HUDPlayerTrackArrowShipLabelOffset;
        [NMS(Index = 868)]
        /* 0x78C4 */ public float HUDPlayerTrackArrowSize;
        [NMS(Index = 870)]
        /* 0x78C8 */ public float HUDPlayerTrackArrowSizeMax;
        [NMS(Index = 869)]
        /* 0x78CC */ public float HUDPlayerTrackArrowSizeMin;
        [NMS(Index = 872)]
        /* 0x78D0 */ public float HUDPlayerTrackArrowSmallIconSize;
        [NMS(Index = 865)]
        /* 0x78D4 */ public float HUDPlayerTrackArrowTargetDist;
        [NMS(Index = 864)]
        /* 0x78D8 */ public float HUDPlayerTrackArrowTargetDistShip;
        [NMS(Index = 830)]
        /* 0x78DC */ public float HUDPlayerTrackArrowTextExtraHeight;
        [NMS(Index = 831)]
        /* 0x78E0 */ public float HUDPlayerTrackArrowTextExtraOffsetX;
        [NMS(Index = 832)]
        /* 0x78E4 */ public float HUDPlayerTrackArrowTextExtraOffsetY;
        [NMS(Index = 828)]
        /* 0x78E8 */ public float HUDPlayerTrackArrowTextHeight;
        [NMS(Index = 827)]
        /* 0x78EC */ public float HUDPlayerTrackArrowTextOffset;
        [NMS(Index = 826)]
        /* 0x78F0 */ public float HUDPlayerTrackDangerPulse;
        [NMS(Index = 772)]
        /* 0x78F4 */ public float HUDPlayerTrackNoSightPulse;
        [NMS(Index = 775)]
        /* 0x78F8 */ public float HUDPlayerTrackTimerEnd;
        [NMS(Index = 776)]
        /* 0x78FC */ public float HUDPlayerTrackTimerPulseRate;
        [NMS(Index = 773)]
        /* 0x7900 */ public float HUDPlayerTrackTimerStart;
        [NMS(Index = 774)]
        /* 0x7904 */ public float HUDPlayerTrackTimerStartFade;
        [NMS(Index = 1301)]
        /* 0x7908 */ public float HUDTargetHealthDangerTime;
        [NMS(Index = 1300)]
        /* 0x790C */ public float HUDTargetHealthIconSize;
        [NMS(Index = 1304)]
        /* 0x7910 */ public float HUDTargetIconOffset;
        [NMS(Index = 1305)]
        /* 0x7914 */ public float HUDTargetIconSize;
        [NMS(Index = 1302)]
        /* 0x7918 */ public float HUDTargetMarkerOffset;
        [NMS(Index = 1303)]
        /* 0x791C */ public float HUDTargetMarkerSize;
        [NMS(Index = 887)]
        /* 0x7920 */ public float IconBackgroundAlpha;
        [NMS(Index = 419)]
        /* 0x7924 */ public float IconGlowStrengthActive;
        [NMS(Index = 418)]
        /* 0x7928 */ public float IconGlowStrengthError;
        [NMS(Index = 421)]
        /* 0x792C */ public float IconGlowStrengthHighlight;
        [NMS(Index = 420)]
        /* 0x7930 */ public float IconGlowStrengthNeutral;
        [NMS(Index = 1070)]
        /* 0x7934 */ public float IconPulseRate;
        [NMS(Index = 1454)]
        /* 0x7938 */ public float InfoPortalGuideCycleTime;
        [NMS(Index = 1455)]
        /* 0x793C */ public float InfoPortalMilestonesCycleTime;
        [NMS(Index = 1091)]
        /* 0x7940 */ public float InteractionIconInnerRadius;
        [NMS(Index = 1092)]
        /* 0x7944 */ public float InteractionIconOuterRadius;
        [NMS(Index = 317)]
        /* 0x7948 */ public float InteractionInWorldMinScreenDistance;
        [NMS(Index = 318)]
        /* 0x794C */ public float InteractionInWorldMinScreenDistanceV2;
        [NMS(Index = 316)]
        /* 0x7950 */ public float InteractionInWorldPitchDistance;
        [NMS(Index = 319)]
        /* 0x7954 */ public float InteractionInWorldSeatedNPCHeightAdjust;
        [NMS(Index = 320)]
        /* 0x7958 */ public float InteractionInWorldSeatedNPCHeightAdjustV2;
        [NMS(Index = 1089)]
        /* 0x795C */ public float InteractionLabelHeight;
        [NMS(Index = 1082)]
        /* 0x7960 */ public float InteractionLabelHorizontalLineLength;
        [NMS(Index = 1090)]
        /* 0x7964 */ public float InteractionLabelLineAlpha;
        [NMS(Index = 1094)]
        /* 0x7968 */ public float InteractionLabelPixelHeightMax;
        [NMS(Index = 1093)]
        /* 0x796C */ public float InteractionLabelPixelHeightMin;
        [NMS(Index = 1088)]
        /* 0x7970 */ public float InteractionLabelRadiusScaler;
        [NMS(Index = 1096)]
        /* 0x7974 */ public float InteractionLabelSpeedClose;
        [NMS(Index = 1095)]
        /* 0x7978 */ public float InteractionLabelSpeedOpen;
        [NMS(Index = 997)]
        /* 0x797C */ public float InteractionScanDisplayTime;
        [NMS(Index = 996)]
        /* 0x7980 */ public float InteractionScanMinTime;
        [NMS(Index = 995)]
        /* 0x7984 */ public float InteractionScanScanTime;
        [NMS(Index = 1000)]
        /* 0x7988 */ public float InteractionScanSlapOverallTime;
        [NMS(Index = 999)]
        /* 0x798C */ public float InteractionScanSlapScale;
        [NMS(Index = 998)]
        /* 0x7990 */ public float InteractionScanSlapTime;
        [NMS(Index = 1026)]
        /* 0x7994 */ public float InventoryFullMessageRepeatTime;
        [NMS(Index = 947)]
        /* 0x7998 */ public float InventoryIconTime;
        [NMS(Index = 81)]
        /* 0x799C */ public float InvSlotGradientFactor;
        [NMS(Index = 80)]
        /* 0x79A0 */ public float InvSlotGradientFactorMin;
        [NMS(Index = 82)]
        /* 0x79A4 */ public float InvSlotGradientTime;
        [NMS(Index = 263)]
        /* 0x79A8 */ public float InWorldInteractionScreenScale;
        [NMS(Index = 157)]
        /* 0x79AC */ public float InWorldInteractLabelFarDistance;
        [NMS(Index = 158)]
        /* 0x79B0 */ public float InWorldInteractLabelFarRange;
        [NMS(Index = 216)]
        /* 0x79B4 */ public int InWorldInteractLabelHeight;
        [NMS(Index = 154)]
        /* 0x79B8 */ public float InWorldInteractLabelMinHeadOffset;
        [NMS(Index = 155)]
        /* 0x79BC */ public float InWorldInteractLabelNearDistance;
        [NMS(Index = 156)]
        /* 0x79C0 */ public float InWorldInteractLabelNearRange;
        [NMS(Index = 146)]
        /* 0x79C4 */ public float InWorldInteractLabelScale;
        [NMS(Index = 147)]
        /* 0x79C8 */ public float InWorldInteractLabelScaleV2;
        [NMS(Index = 215)]
        /* 0x79CC */ public int InWorldInteractLabelWidth;
        [NMS(Index = 211)]
        /* 0x79D0 */ public float InWorldNGuiScreenScale;
        [NMS(Index = 264)]
        /* 0x79D4 */ public float InWorldNPCInteractionScreenScale;
        [NMS(Index = 210)]
        /* 0x79D8 */ public float InWorldScreenForwardOffset;
        [NMS(Index = 209)]
        /* 0x79DC */ public float InWorldScreenMinScreenDistance;
        [NMS(Index = 148)]
        /* 0x79E0 */ public float InWorldScreenScaleDistance;
        [NMS(Index = 54)]
        /* 0x79E4 */ public float InWorldUIInteractionDistanceWithEyeTrackingEnabled;
        [NMS(Index = 950)]
        /* 0x79E8 */ public float ItemReceivedMessageTimeToAdd;
        [NMS(Index = 990)]
        /* 0x79EC */ public float ItemSlotColourTechChargeRate;
        [NMS(Index = 1032)]
        /* 0x79F0 */ public float KeepHazardBarActiveTime;
        [NMS(Index = 1033)]
        /* 0x79F4 */ public float KeepSecondHazardBarActiveTime;
        [NMS(Index = 925)]
        /* 0x79F8 */ public float LandNotifyHeightThreshold;
        [NMS(Index = 924)]
        /* 0x79FC */ public float LandNotifySpeedThreshold;
        [NMS(Index = 926)]
        /* 0x7A00 */ public float LandNotifyTimeThreshold;
        [NMS(Index = 738)]
        /* 0x7A04 */ public float LargeSpaceIconSize;
        [NMS(Index = 357)]
        /* 0x7A08 */ public float LoadFadeInDefaultTime;
        [NMS(Index = 141)]
        /* 0x7A0C */ public float LoadingScreenTime;
        [NMS(Index = 140)]
        /* 0x7A10 */ public float LoadingScreenTravelSpeed;
        [NMS(Index = 139)]
        /* 0x7A14 */ public float LoadingTravelDistance;
        [NMS(Index = 1370)]
        /* 0x7A18 */ public float LockOnMarkerSize;
        [NMS(Index = 1371)]
        /* 0x7A1C */ public float LockOnMarkerSizeLock;
        [NMS(Index = 207)]
        /* 0x7A20 */ public float LowerHelmetScreenPitch;
        [NMS(Index = 206)]
        /* 0x7A24 */ public float LowerHelmetScreenScale;
        [NMS(Index = 519)]
        /* 0x7A28 */ public float LowHealthShieldFactor;
        [NMS(Index = 518)]
        /* 0x7A2C */ public float LowHealthShieldMin;
        [NMS(Index = 472)]
        /* 0x7A30 */ public float MaintenanceIconFadeStart;
        [NMS(Index = 473)]
        /* 0x7A34 */ public float MaintenanceIconFadeTime;
        [NMS(Index = 945)]
        /* 0x7A38 */ public float ManualNotificationPauseTime;
        [NMS(Index = 1453)]
        /* 0x7A3C */ public float ManualScrollChangePerInputMax;
        [NMS(Index = 1452)]
        /* 0x7A40 */ public float ManualScrollChangePerInputMin;
        [NMS(Index = 470)]
        /* 0x7A44 */ public float MarkerComponentOffset;
        [NMS(Index = 367)]
        /* 0x7A48 */ public float MarkerHorizonApproachAngle;
        [NMS(Index = 366)]
        /* 0x7A4C */ public float MarkerHorizonMinOffset;
        [NMS(Index = 373)]
        /* 0x7A50 */ public float MarkerHorizonOffPlanetLightBeamAngle;
        [NMS(Index = 365)]
        /* 0x7A54 */ public float MarkerHorizonOffsetAngle;
        [NMS(Index = 374)]
        /* 0x7A58 */ public float MarkerHorizonShipApproachOffset;
        [NMS(Index = 368)]
        /* 0x7A5C */ public float MarkerOffsetTypeAngle;
        [NMS(Index = 372)]
        /* 0x7A60 */ public float MarkerOffsetTypeAngleAsteroid;
        [NMS(Index = 369)]
        /* 0x7A64 */ public float MarkerOffsetTypeAngleBattle;
        [NMS(Index = 370)]
        /* 0x7A68 */ public float MarkerOffsetTypeAngleBounty;
        [NMS(Index = 371)]
        /* 0x7A6C */ public float MarkerOffsetTypeAnglePlayerShip;
        [NMS(Index = 455)]
        /* 0x7A70 */ public float MarkerRingInnerRadius;
        [NMS(Index = 456)]
        /* 0x7A74 */ public float MarkerRingOuterRadius;
        [NMS(Index = 383)]
        /* 0x7A78 */ public float MarkerTagAppearDelay;
        [NMS(Index = 522)]
        /* 0x7A7C */ public int MaxDialogCharSizeIdeographic;
        [NMS(Index = 520)]
        /* 0x7A80 */ public int MaxDialogCharSizeRoman;
        [NMS(Index = 378)]
        /* 0x7A84 */ public int MaxNumMessageBeaconIcons;
        [NMS(Index = 192)]
        /* 0x7A88 */ public float MaxProjectorDistanceFromDefault;
        [NMS(Index = 195)]
        /* 0x7A8C */ public float MaxProjectorGrabDistance;
        [NMS(Index = 95)]
        /* 0x7A90 */ public int MaxSubstanceMaxAmountForAmountFraction;
        [NMS(Index = 948)]
        /* 0x7A94 */ public float MessageNotificationTime;
        [NMS(Index = 949)]
        /* 0x7A98 */ public float MessageTimeQuick;
        [NMS(Index = 120)]
        /* 0x7A9C */ public float MilestoneStingDisplayTime;
        [NMS(Index = 1446)]
        /* 0x7AA0 */ public float MinimumHoldFill;
        [NMS(Index = 118)]
        /* 0x7AA4 */ public float MinSeasonPlayTimeInDays;
        [NMS(Index = 751)]
        /* 0x7AA8 */ public float MissileCentreOffset;
        [NMS(Index = 1376)]
        /* 0x7AAC */ public float MissileIconAttackPulseAmount;
        [NMS(Index = 1375)]
        /* 0x7AB0 */ public float MissileIconAttackPulseTime;
        [NMS(Index = 732)]
        /* 0x7AB4 */ public float MissionCompassIconScaler;
        [NMS(Index = 382)]
        /* 0x7AB8 */ public float MissionDetailsPageBaseHeight;
        [NMS(Index = 548)]
        /* 0x7ABC */ public int MissionLoopCount;
        [NMS(Index = 549)]
        /* 0x7AC0 */ public int MissionLoopCountPirate;
        [NMS(Index = 733)]
        /* 0x7AC4 */ public float MissionMarkerSize;
        [NMS(Index = 379)]
        /* 0x7AC8 */ public float MissionObjectiveBaseHeight;
        [NMS(Index = 380)]
        /* 0x7ACC */ public float MissionObjectiveDoneHeight;
        [NMS(Index = 381)]
        /* 0x7AD0 */ public float MissionObjectiveScrollingExtra;
        [NMS(Index = 550)]
        /* 0x7AD4 */ public int MissionSeedOffset;
        [NMS(Index = 547)]
        /* 0x7AD8 */ public int MissionSpecificMissionPercent;
        [NMS(Index = 531)]
        /* 0x7ADC */ public float MissionStartEndOSDTime;
        [NMS(Index = 532)]
        /* 0x7AE0 */ public float MissionStartEndOSDTimeProcedural;
        [NMS(Index = 530)]
        /* 0x7AE4 */ public float MissionStartEndTime;
        [NMS(Index = 49)]
        /* 0x7AE8 */ public float ModularCustomisationApplyTime;
        [NMS(Index = 1461)]
        /* 0x7AEC */ public float MouseRotateCameraSensitivity;
        [NMS(Index = 1431)]
        /* 0x7AF0 */ public float MultiplayerTeleportEffectAppearTime;
        [NMS(Index = 1430)]
        /* 0x7AF4 */ public float MultiplayerTeleportEffectDisappearTime;
        [NMS(Index = 1396)]
        /* 0x7AF8 */ public float NGuiActiveAreaOffsetTime;
        [NMS(Index = 1387)]
        /* 0x7AFC */ public float NGuiAltPlacementDistanceScrollSpeed;
        [NMS(Index = 1395)]
        /* 0x7B00 */ public float NGuiCursorOffsetMultiplier;
        [NMS(Index = 305)]
        /* 0x7B04 */ public float NGuiHmdOffset;
        [NMS(Index = 1377)]
        /* 0x7B08 */ public float NGuiModelRotationDegreesX;
        [NMS(Index = 1378)]
        /* 0x7B0C */ public float NGuiModelRotationDegreesY;
        [NMS(Index = 1379)]
        /* 0x7B10 */ public float NGuiModelRotationDegreesZ;
        [NMS(Index = 1386)]
        /* 0x7B14 */ public float NGuiModelViewCdSmoothTime;
        [NMS(Index = 1384)]
        /* 0x7B18 */ public float NGuiModelViewDistanceDiscoveryPage;
        [NMS(Index = 1380)]
        /* 0x7B1C */ public float NGuiModelViewDistanceGlobal;
        [NMS(Index = 1383)]
        /* 0x7B20 */ public float NGuiModelViewDistanceShipPage;
        [NMS(Index = 1381)]
        /* 0x7B24 */ public float NGuiModelViewDistanceSuitPage;
        [NMS(Index = 1382)]
        /* 0x7B28 */ public float NGuiModelViewDistanceWeaponPage;
        [NMS(Index = 1404)]
        /* 0x7B2C */ public float NGuiModelViewFadeInAfterRenderTime;
        [NMS(Index = 1385)]
        /* 0x7B30 */ public float NGuiModelViewFov;
        [NMS(Index = 1389)]
        /* 0x7B34 */ public float NGuiModelViewFractionOfBBHeightAboveReflectivePlane;
        [NMS(Index = 1214)]
        /* 0x7B38 */ public float NGuiMouseSensitivity;
        [NMS(Index = 1213)]
        /* 0x7B3C */ public float NGuiPadSensitivity;
        [NMS(Index = 1388)]
        /* 0x7B40 */ public float NGuiPlacementAngleScrollSpeed;
        [NMS(Index = 1393)]
        /* 0x7B44 */ public float NGuiThumbnailModelRotationDegreesY;
        [NMS(Index = 1394)]
        /* 0x7B48 */ public float NGuiThumbnailModelViewDistance;
        [NMS(Index = 900)]
        /* 0x7B4C */ public float NotificationBackgroundGradientAlphaInShip;
        [NMS(Index = 899)]
        /* 0x7B50 */ public float NotificationBackgroundGradientEndOffsetPercentInShip;
        [NMS(Index = 933)]
        /* 0x7B54 */ public float NotificationBridgeReachDistance;
        [NMS(Index = 907)]
        /* 0x7B58 */ public float NotificationBuildHintStartTime;
        [NMS(Index = 912)]
        /* 0x7B5C */ public float NotificationCantFireTime;
        [NMS(Index = 913)]
        /* 0x7B60 */ public float NotificationDangerTime;
        [NMS(Index = 938)]
        /* 0x7B64 */ public float NotificationDeviceIdleTime;
        [NMS(Index = 934)]
        /* 0x7B68 */ public float NotificationDiscoveryIdleTime;
        [NMS(Index = 931)]
        /* 0x7B6C */ public float NotificationFinalMissionWait;
        [NMS(Index = 929)]
        /* 0x7B70 */ public float NotificationGoToSpaceStationWait;
        [NMS(Index = 356)]
        /* 0x7B74 */ public float NotificationHazardMinTimeAfterRecharge;
        [NMS(Index = 904)]
        /* 0x7B78 */ public float NotificationHazardSafeThreshold;
        [NMS(Index = 905)]
        /* 0x7B7C */ public float NotificationHazardTimer;
        [NMS(Index = 935)]
        /* 0x7B80 */ public float NotificationInfoIdleTime;
        [NMS(Index = 906)]
        /* 0x7B84 */ public float NotificationInteractHintStartTime;
        [NMS(Index = 908)]
        /* 0x7B88 */ public float NotificationJetpackTime;
        [NMS(Index = 917)]
        /* 0x7B8C */ public float NotificationMaxPageHintTime;
        [NMS(Index = 916)]
        /* 0x7B90 */ public float NotificationMessageCycleTime;
        [NMS(Index = 903)]
        /* 0x7B94 */ public float NotificationMinVisibleTime;
        [NMS(Index = 939)]
        /* 0x7B98 */ public float NotificationMissionHintTime;
        [NMS(Index = 940)]
        /* 0x7B9C */ public float NotificationMissionHintTimeCritical;
        [NMS(Index = 941)]
        /* 0x7BA0 */ public float NotificationMissionHintTimeSecondary;
        [NMS(Index = 930)]
        /* 0x7BA4 */ public float NotificationMonolithMissionWait;
        [NMS(Index = 936)]
        /* 0x7BA8 */ public float NotificationNewTechIdleTime;
        [NMS(Index = 937)]
        /* 0x7BAC */ public float NotificationScanEventMissionIdleTime;
        [NMS(Index = 914)]
        /* 0x7BB0 */ public float NotificationScanTime;
        [NMS(Index = 915)]
        /* 0x7BB4 */ public float NotificationScanTimeCutoff;
        [NMS(Index = 909)]
        /* 0x7BB8 */ public float NotificationShieldTime;
        [NMS(Index = 921)]
        /* 0x7BBC */ public float NotificationShipBoostMinTime;
        [NMS(Index = 922)]
        /* 0x7BC0 */ public float NotificationShipBoostReminderTime;
        [NMS(Index = 923)]
        /* 0x7BC4 */ public float NotificationShipBoostReminderTimeTutorial;
        [NMS(Index = 910)]
        /* 0x7BC8 */ public float NotificationShipBoostTime;
        [NMS(Index = 911)]
        /* 0x7BCC */ public float NotificationShipBoostTimeVR;
        [NMS(Index = 918)]
        /* 0x7BD0 */ public float NotificationShipJumpMinTime;
        [NMS(Index = 919)]
        /* 0x7BD4 */ public float NotificationShipJumpReminderTime;
        [NMS(Index = 920)]
        /* 0x7BD8 */ public float NotificationShipJumpReminderTutorial;
        [NMS(Index = 901)]
        /* 0x7BDC */ public int NotificationsResourceExtractHintCount;
        [NMS(Index = 902)]
        /* 0x7BE0 */ public float NotificationStaminaHintDistanceWalked;
        [NMS(Index = 927)]
        /* 0x7BE4 */ public float NotificationTimeBeforeHeridiumMarker;
        [NMS(Index = 928)]
        /* 0x7BE8 */ public float NotificationUrgentMessageTime;
        [NMS(Index = 932)]
        /* 0x7BEC */ public float NotificationWaypointReachDistance;
        [NMS(Index = 821)]
        /* 0x7BF0 */ public int NumDeathQuotes;
        [NMS(Index = 542)]
        /* 0x7BF4 */ public float OnFootDamageDirectionIndicatorFadeRange;
        [NMS(Index = 541)]
        /* 0x7BF8 */ public float OnFootDamageDirectionIndicatorRadius;
        [NMS(Index = 142)]
        /* 0x7BFC */ public float OSDMessagePauseOffscreenAngle;
        [NMS(Index = 345)]
        /* 0x7C00 */ public int OSDMessageQueueMax;
        [NMS(Index = 344)]
        /* 0x7C04 */ public int OSDMessageQueueMin;
        [NMS(Index = 343)]
        /* 0x7C08 */ public float OSDMessageQueueSpeedMultiplier;
        [NMS(Index = 9)]
        /* 0x7C0C */ public float OutpostPortalMarkerDistance;
        [NMS(Index = 1113)]
        /* 0x7C10 */ public float PadCursorAcceleration;
        [NMS(Index = 1114)]
        /* 0x7C14 */ public float PadCursorMaxSpeedModifier;
        [NMS(Index = 92)]
        /* 0x7C18 */ public float PadCursorUICurveStrength;
        [NMS(Index = 1460)]
        /* 0x7C1C */ public float PadRotateCameraSensitivity;
        [NMS(Index = 515)]
        /* 0x7C20 */ public float PageTurnTime;
        [NMS(Index = 108)]
        /* 0x7C24 */ public float ParagraphAutoScrollSpeed;
        [NMS(Index = 977)]
        /* 0x7C28 */ public float PauseMenuHoldTime;
        [NMS(Index = 164)]
        /* 0x7C2C */ public float PetBattleStatUnlockBounceTime;
        [NMS(Index = 166)]
        /* 0x7C30 */ public float PetBattleStatUnlockMessageTime;
        [NMS(Index = 165)]
        /* 0x7C34 */ public float PetBattleStatUrgentBounceTime;
        [NMS(Index = 5)]
        /* 0x7C38 */ public float PetGeneIconGlowTimeNormal;
        [NMS(Index = 6)]
        /* 0x7C3C */ public float PetGeneIconGlowTimeUrgent;
        [NMS(Index = 740)]
        /* 0x7C40 */ public float PetHoverIconSize;
        [NMS(Index = 167)]
        /* 0x7C44 */ public float PetHUDMarkerExtraFollowInfoDistance;
        [NMS(Index = 168)]
        /* 0x7C48 */ public float PetHUDMarkerHideDistance;
        [NMS(Index = 169)]
        /* 0x7C4C */ public float PetHUDMarkerHideDistanceShort;
        [NMS(Index = 170)]
        /* 0x7C50 */ public float PetHUDMarkerOffset;
        [NMS(Index = 741)]
        /* 0x7C54 */ public float PetIconSize;
        [NMS(Index = 171)]
        /* 0x7C58 */ public float PetMoodMarkerOffset;
        [NMS(Index = 163)]
        /* 0x7C5C */ public float PetSlotUnlockBounceTime;
        [NMS(Index = 644)]
        /* 0x7C60 */ public float PhotoModeTimeofDayChange;
        [NMS(Index = 643)]
        /* 0x7C64 */ public float PhotoModeValueAlpha;
        [NMS(Index = 673)]
        /* 0x7C68 */ public float PirateAttackIndicatorRadius;
        [NMS(Index = 672)]
        /* 0x7C6C */ public float PirateAttackIndicatorWidth;
        [NMS(Index = 674)]
        /* 0x7C70 */ public float PirateAttackProbeDisplayFinishFactor;
        [NMS(Index = 671)]
        /* 0x7C74 */ public float PirateCountdownTime;
        [NMS(Index = 656)]
        /* 0x7C78 */ public float PirateFreighterSummonAtOffset;
        [NMS(Index = 654)]
        /* 0x7C7C */ public float PirateFreighterSummonOffset;
        [NMS(Index = 655)]
        /* 0x7C80 */ public float PirateFreighterSummonOffsetPulse;
        [NMS(Index = 138)]
        /* 0x7C84 */ public float PlacedMarkerFadeTime;
        [NMS(Index = 128)]
        /* 0x7C88 */ public float PlanetDataExtraRadius;
        [NMS(Index = 984)]
        /* 0x7C8C */ public float PlanetLabelAngle;
        [NMS(Index = 983)]
        /* 0x7C90 */ public float PlanetLabelTime;
        [NMS(Index = 1228)]
        /* 0x7C94 */ public float PlanetPoleEastWestDistanceFromPlayer;
        [NMS(Index = 1227)]
        /* 0x7C98 */ public float PlanetPoleMaxDotProduct;
        [NMS(Index = 513)]
        /* 0x7C9C */ public float PlanetRaidMarkerOffset;
        [NMS(Index = 686)]
        /* 0x7CA0 */ public float PlanetScanDelayTime;
        [NMS(Index = 1138)]
        /* 0x7CA4 */ public float PopupActivateTime;
        [NMS(Index = 1139)]
        /* 0x7CA8 */ public float PopupDeactivateTime;
        [NMS(Index = 1137)]
        /* 0x7CAC */ public float PopupDebounceTime;
        [NMS(Index = 1126)]
        /* 0x7CB0 */ public float PopupSlotWidthOffset;
        [NMS(Index = 83)]
        /* 0x7CB4 */ public float PopupTitleGradientFactor;
        [NMS(Index = 346)]
        /* 0x7CB8 */ public float PopupValueSectionBaseHeight;
        [NMS(Index = 347)]
        /* 0x7CBC */ public float PopupValueSectionHeight;
        [NMS(Index = 1124)]
        /* 0x7CC0 */ public float PopupXClampOffset;
        [NMS(Index = 1125)]
        /* 0x7CC4 */ public float PopupXClampOffsetRightAligned;
        [NMS(Index = 197)]
        /* 0x7CC8 */ public float ProjectorGrabBorderPercent;
        [NMS(Index = 196)]
        /* 0x7CCC */ public float ProjectorGrabDistanceBias;
        [NMS(Index = 193)]
        /* 0x7CD0 */ public float ProjectorGrabResetTime;
        [NMS(Index = 191)]
        /* 0x7CD4 */ public float ProjectorScale;
        [NMS(Index = 237)]
        /* 0x7CD8 */ public float QuickMenuAlpha;
        [NMS(Index = 143)]
        /* 0x7CDC */ public float QuickMenuCentrePos;
        [NMS(Index = 145)]
        /* 0x7CE0 */ public float QuickMenuCentreSideOffset;
        [NMS(Index = 584)]
        /* 0x7CE4 */ public float QuickMenuCloseTime;
        [NMS(Index = 236)]
        /* 0x7CE8 */ public float QuickMenuCursorScale;
        [NMS(Index = 585)]
        /* 0x7CEC */ public float QuickMenuErrorTime;
        [NMS(Index = 276)]
        /* 0x7CF0 */ public float QuickMenuHighlightRate;
        [NMS(Index = 277)]
        /* 0x7CF4 */ public float QuickMenuHoldNavTime;
        [NMS(Index = 272)]
        /* 0x7CF8 */ public float QuickMenuInteractAdjustX;
        [NMS(Index = 273)]
        /* 0x7CFC */ public float QuickMenuInteractAdjustY;
        [NMS(Index = 275)]
        /* 0x7D00 */ public int QuickMenuScreenHeight;
        [NMS(Index = 274)]
        /* 0x7D04 */ public int QuickMenuScreenWidth;
        [NMS(Index = 144)]
        /* 0x7D08 */ public float QuickMenuSideOffset;
        [NMS(Index = 268)]
        /* 0x7D0C */ public float QuickMenuSwipeHeightMax;
        [NMS(Index = 267)]
        /* 0x7D10 */ public float QuickMenuSwipeHeightMin;
        [NMS(Index = 1193)]
        /* 0x7D14 */ public float RadialMenuInnerRadius;
        [NMS(Index = 1194)]
        /* 0x7D18 */ public float RadialMenuInnerRadiusCursor;
        [NMS(Index = 1195)]
        /* 0x7D1C */ public float RadialMenuWedgeOffset;
        [NMS(Index = 502)]
        /* 0x7D20 */ public float RefinerAutoCloseTime;
        [NMS(Index = 490)]
        /* 0x7D24 */ public float RefinerBeginDialInnerRadius;
        [NMS(Index = 489)]
        /* 0x7D28 */ public float RefinerPadStartDecayTime;
        [NMS(Index = 488)]
        /* 0x7D2C */ public float RefinerPadStartTime;
        [NMS(Index = 491)]
        /* 0x7D30 */ public float RefinerProgressDialInnerRadius;
        [NMS(Index = 471)]
        /* 0x7D34 */ public float RepairTechLabelOffset;
        [NMS(Index = 460)]
        /* 0x7D38 */ public float RepairTechRepairedMessageTime;
        [NMS(Index = 458)]
        /* 0x7D3C */ public float RepairTechRepairedWaitTime1;
        [NMS(Index = 459)]
        /* 0x7D40 */ public float RepairTechRepairedWaitTime2;
        [NMS(Index = 1421)]
        /* 0x7D44 */ public float ReportBaseFlashDelay;
        [NMS(Index = 1420)]
        /* 0x7D48 */ public float ReportBaseFlashIntensity;
        [NMS(Index = 1419)]
        /* 0x7D4C */ public float ReportBaseFlashTime;
        [NMS(Index = 1422)]
        /* 0x7D50 */ public float ReportCameraSpeed;
        [NMS(Index = 137)]
        /* 0x7D54 */ public float ROGAllyFrontendZoomFactor;
        [NMS(Index = 809)]
        /* 0x7D58 */ public float ScanEventArrowOffsetMultiplier;
        [NMS(Index = 811)]
        /* 0x7D5C */ public float ScanEventArrowOffsetMultiplierFresh;
        [NMS(Index = 812)]
        /* 0x7D60 */ public float ScanEventArrowOffsetMultiplierLerpTime;
        [NMS(Index = 810)]
        /* 0x7D64 */ public float ScanEventArrowOffsetMultiplierOneEvent;
        [NMS(Index = 808)]
        /* 0x7D68 */ public float ScanEventArrowPlayerFadeDistance;
        [NMS(Index = 807)]
        /* 0x7D6C */ public float ScanEventArrowPlayerFadeRange;
        [NMS(Index = 813)]
        /* 0x7D70 */ public float ScanEventArrowSecondaryAlpha;
        [NMS(Index = 806)]
        /* 0x7D74 */ public float ScanEventArrowShipFadeDistance;
        [NMS(Index = 805)]
        /* 0x7D78 */ public float ScanEventArrowShipFadeRange;
        [NMS(Index = 814)]
        /* 0x7D7C */ public GcAudioWwiseEvents ScanEventIconAudio;
        [NMS(Index = 376)]
        /* 0x7D80 */ public float ScannableIconMergeAngle;
        [NMS(Index = 1097)]
        /* 0x7D84 */ public float ScanTime;
        [NMS(Index = 117)]
        /* 0x7D88 */ public float SeasonalRingChangeTime;
        [NMS(Index = 115)]
        /* 0x7D8C */ public float SeasonalRingMultiplier;
        [NMS(Index = 116)]
        /* 0x7D90 */ public float SeasonalRingPulseTime;
        [NMS(Index = 47)]
        /* 0x7D94 */ public float SeasonEndAutoHighlightDuration;
        [NMS(Index = 48)]
        /* 0x7D98 */ public float SeasonEndAutoHighlightDurationMilestone;
        [NMS(Index = 46)]
        /* 0x7D9C */ public GcAudioWwiseEvents SeasonEndAutoHighlightSFX;
        [NMS(Index = 45)]
        /* 0x7DA0 */ public float SeasonEndRewardsMaxScrollRate;
        [NMS(Index = 44)]
        /* 0x7DA4 */ public float SeasonEndRewardsPageOpenDelayTime;
        [NMS(Index = 113)]
        /* 0x7DA8 */ public int SeasonFinalStageIndex;
        [NMS(Index = 897)]
        /* 0x7DAC */ public float SeasonMessageDelayTime;
        [NMS(Index = 106)]
        /* 0x7DB0 */ public float SentinelsDisabledHUDMessageTime;
        [NMS(Index = 1436)]
        /* 0x7DB4 */ public float SettlementStatFlashSpeed;
        [NMS(Index = 1437)]
        /* 0x7DB8 */ public float SettlementStatInnerRadius;
        [NMS(Index = 1438)]
        /* 0x7DBC */ public float SettlementStatOuterRadius;
        [NMS(Index = 1042)]
        /* 0x7DC0 */ public float ShieldHazardPulseRate;
        [NMS(Index = 1044)]
        /* 0x7DC4 */ public float ShieldHazardPulseThreshold;
        [NMS(Index = 1041)]
        /* 0x7DC8 */ public float ShieldPulseTime;
        [NMS(Index = 1040)]
        /* 0x7DCC */ public float ShieldSpringTime;
        [NMS(Index = 13)]
        /* 0x7DD0 */ public float ShipBuilderBarTime;
        [NMS(Index = 20)]
        /* 0x7DD4 */ public float ShipBuilderEndCircleRadius;
        [NMS(Index = 24)]
        /* 0x7DD8 */ public float ShipBuilderLineLengthFadeMax;
        [NMS(Index = 23)]
        /* 0x7DDC */ public float ShipBuilderLineLengthFadeMin;
        [NMS(Index = 22)]
        /* 0x7DE0 */ public float ShipBuilderLineMinFade;
        [NMS(Index = 21)]
        /* 0x7DE4 */ public float ShipBuilderLineWidth;
        [NMS(Index = 18)]
        /* 0x7DE8 */ public float ShipBuilderSlotDropLength;
        [NMS(Index = 14)]
        /* 0x7DEC */ public float ShipBuilderSlotLineDefaultWidthFactor;
        [NMS(Index = 16)]
        /* 0x7DF0 */ public float ShipBuilderSlotLineMaxFactor;
        [NMS(Index = 15)]
        /* 0x7DF4 */ public float ShipBuilderSlotLineMinFactor;
        [NMS(Index = 17)]
        /* 0x7DF8 */ public float ShipBuilderSlotStartOffset;
        [NMS(Index = 19)]
        /* 0x7DFC */ public float ShipBuilderStartCircleRadius;
        [NMS(Index = 540)]
        /* 0x7E00 */ public float ShipDamageDirectionIndicatorFadeRange;
        [NMS(Index = 539)]
        /* 0x7E04 */ public float ShipDamageDirectionIndicatorRadius;
        [NMS(Index = 803)]
        /* 0x7E08 */ public float ShipDesatDamper;
        [NMS(Index = 802)]
        /* 0x7E0C */ public float ShipFullscreenDamper;
        [NMS(Index = 801)]
        /* 0x7E10 */ public float ShipFullscreenDamperMin;
        [NMS(Index = 693)]
        /* 0x7E14 */ public float ShipHeadsUpDisplayDistance;
        [NMS(Index = 694)]
        /* 0x7E18 */ public float ShipHeadsUpLineFadeTime;
        [NMS(Index = 321)]
        /* 0x7E1C */ public float ShipHologramInWorldUIHeightAdjust;
        [NMS(Index = 322)]
        /* 0x7E20 */ public float ShipHologramInWorldUIHeightAdjustV2;
        [NMS(Index = 1022)]
        /* 0x7E24 */ public float ShipHUDHitPointSize;
        [NMS(Index = 1021)]
        /* 0x7E28 */ public float ShipHUDHitPointTime;
        [NMS(Index = 159)]
        /* 0x7E2C */ public float ShipHUDMarkerHideDistance;
        [NMS(Index = 160)]
        /* 0x7E30 */ public float ShipHUDMarkerOffset;
        [NMS(Index = 1006)]
        /* 0x7E34 */ public float ShipHUDMaxOffscreenTargetDist;
        [NMS(Index = 1003)]
        /* 0x7E38 */ public float ShipHUDMissileLockSizeMax;
        [NMS(Index = 1002)]
        /* 0x7E3C */ public float ShipHUDMissileLockSizeMin;
        [NMS(Index = 1005)]
        /* 0x7E40 */ public float ShipHUDMissileLockSpringFast;
        [NMS(Index = 1004)]
        /* 0x7E44 */ public float ShipHUDMissileLockSpringSlow;
        [NMS(Index = 1009)]
        /* 0x7E48 */ public float ShipHUDTargetAlpha;
        [NMS(Index = 1010)]
        /* 0x7E4C */ public float ShipHUDTargetArrowLength;
        [NMS(Index = 1014)]
        /* 0x7E50 */ public float ShipHUDTargetArrowsRotationRate;
        [NMS(Index = 1011)]
        /* 0x7E54 */ public float ShipHUDTargetMinDist;
        [NMS(Index = 1007)]
        /* 0x7E58 */ public float ShipHUDTargetRadius;
        [NMS(Index = 1012)]
        /* 0x7E5C */ public float ShipHUDTargetRange;
        [NMS(Index = 1013)]
        /* 0x7E60 */ public float ShipHUDTargetScale;
        [NMS(Index = 1008)]
        /* 0x7E64 */ public float ShipHUDTargetTriangleRadius;
        [NMS(Index = 525)]
        /* 0x7E68 */ public float ShipOverheatSwitchMessageTime;
        [NMS(Index = 524)]
        /* 0x7E6C */ public float ShipOverheatSwitchMessageWait;
        [NMS(Index = 1429)]
        /* 0x7E70 */ public float ShipScreenTexScale;
        [NMS(Index = 259)]
        /* 0x7E74 */ public float ShipSideScreenHeight;
        [NMS(Index = 8)]
        /* 0x7E78 */ public float ShipTeleportPadMarkerDistance;
        [NMS(Index = 7)]
        /* 0x7E7C */ public float ShipTeleportPadMinDistance;
        [NMS(Index = 323)]
        /* 0x7E80 */ public float ShopInteractionInWorldForcedOffset;
        [NMS(Index = 324)]
        /* 0x7E84 */ public float ShopInteractionInWorldForcedOffsetV2;
        [NMS(Index = 124)]
        /* 0x7E88 */ public int ShowDaysIfLessThan;
        [NMS(Index = 123)]
        /* 0x7E8C */ public int ShowHoursIfLessThan;
        [NMS(Index = 125)]
        /* 0x7E90 */ public int ShowWeeksIfLessThan;
        [NMS(Index = 739)]
        /* 0x7E94 */ public float SmallSpaceIconSize;
        [NMS(Index = 261)]
        /* 0x7E98 */ public float SolidPointerLengthScale;
        [NMS(Index = 262)]
        /* 0x7E9C */ public float SolidPointerMaxLength;
        [NMS(Index = 260)]
        /* 0x7EA0 */ public float SolidPointerScale;
        [NMS(Index = 1262)]
        /* 0x7EA4 */ public float SpaceMapActionScale;
        [NMS(Index = 1258)]
        /* 0x7EA8 */ public float SpaceMapAnomalyScale;
        [NMS(Index = 1248)]
        /* 0x7EAC */ public float SpaceMapAspectRatio;
        [NMS(Index = 1274)]
        /* 0x7EB0 */ public float SpaceMapCamAngle;
        [NMS(Index = 1275)]
        /* 0x7EB4 */ public float SpaceMapCamDistance;
        [NMS(Index = 1273)]
        /* 0x7EB8 */ public float SpaceMapCamHeight;
        [NMS(Index = 562)]
        /* 0x7EBC */ public float SpaceMapCockpitAngle;
        [NMS(Index = 552)]
        /* 0x7EC0 */ public float SpaceMapCockpitScale;
        [NMS(Index = 559)]
        /* 0x7EC4 */ public float SpaceMapCockpitScaleAdjustAlien;
        [NMS(Index = 561)]
        /* 0x7EC8 */ public float SpaceMapCockpitScaleAdjustCorvette;
        [NMS(Index = 553)]
        /* 0x7ECC */ public float SpaceMapCockpitScaleAdjustDropShip;
        [NMS(Index = 554)]
        /* 0x7ED0 */ public float SpaceMapCockpitScaleAdjustFighter;
        [NMS(Index = 560)]
        /* 0x7ED4 */ public float SpaceMapCockpitScaleAdjustRobot;
        [NMS(Index = 557)]
        /* 0x7ED8 */ public float SpaceMapCockpitScaleAdjustRoyal;
        [NMS(Index = 558)]
        /* 0x7EDC */ public float SpaceMapCockpitScaleAdjustSail;
        [NMS(Index = 555)]
        /* 0x7EE0 */ public float SpaceMapCockpitScaleAdjustScientific;
        [NMS(Index = 556)]
        /* 0x7EE4 */ public float SpaceMapCockpitScaleAdjustShuttle;
        [NMS(Index = 1267)]
        /* 0x7EE8 */ public float SpaceMapDistance;
        [NMS(Index = 1250)]
        /* 0x7EEC */ public float SpaceMapDistanceLogScaler;
        [NMS(Index = 1269)]
        /* 0x7EF0 */ public float SpaceMapDistanceMultiplier;
        [NMS(Index = 1249)]
        /* 0x7EF4 */ public float SpaceMapDistanceScale;
        [NMS(Index = 1272)]
        /* 0x7EF8 */ public float SpaceMapFadeAngleMax;
        [NMS(Index = 1271)]
        /* 0x7EFC */ public float SpaceMapFadeAngleMin;
        [NMS(Index = 1247)]
        /* 0x7F00 */ public float SpaceMapFoV;
        [NMS(Index = 1256)]
        /* 0x7F04 */ public float SpaceMapFreighterScale;
        [NMS(Index = 1270)]
        /* 0x7F08 */ public float SpaceMapHorizonThickness;
        [NMS(Index = 1277)]
        /* 0x7F0C */ public float SpaceMapLightPitch;
        [NMS(Index = 1278)]
        /* 0x7F10 */ public float SpaceMapLightYaw;
        [NMS(Index = 1231)]
        /* 0x7F14 */ public float SpaceMapLineBaseFade;
        [NMS(Index = 1230)]
        /* 0x7F18 */ public float SpaceMapLineBaseScale;
        [NMS(Index = 1229)]
        /* 0x7F1C */ public float SpaceMapLineWidth;
        [NMS(Index = 1266)]
        /* 0x7F20 */ public float SpaceMapMarkerScale;
        [NMS(Index = 1268)]
        /* 0x7F24 */ public float SpaceMapMaxTraderDistance;
        [NMS(Index = 1261)]
        /* 0x7F28 */ public float SpaceMapMoonScale;
        [NMS(Index = 1255)]
        /* 0x7F2C */ public float SpaceMapObjectScale;
        [NMS(Index = 1265)]
        /* 0x7F30 */ public float SpaceMapPirateFreighterScale;
        [NMS(Index = 1264)]
        /* 0x7F34 */ public float SpaceMapPirateFrigateScale;
        [NMS(Index = 1260)]
        /* 0x7F38 */ public float SpaceMapPlanetLineOffset;
        [NMS(Index = 1259)]
        /* 0x7F3C */ public float SpaceMapPlanetScale;
        [NMS(Index = 1252)]
        /* 0x7F40 */ public float SpaceMapScaleMin;
        [NMS(Index = 1254)]
        /* 0x7F44 */ public float SpaceMapScaleRangeMax;
        [NMS(Index = 1253)]
        /* 0x7F48 */ public float SpaceMapScaleRangeMin;
        [NMS(Index = 1232)]
        /* 0x7F4C */ public float SpaceMapShipCombineDistance;
        [NMS(Index = 1263)]
        /* 0x7F50 */ public float SpaceMapShipScale;
        [NMS(Index = 1276)]
        /* 0x7F54 */ public float SpaceMapShipScaleMin;
        [NMS(Index = 1257)]
        /* 0x7F58 */ public float SpaceMapStationScale;
        [NMS(Index = 737)]
        /* 0x7F5C */ public float SpaceMarkersBattleOffset;
        [NMS(Index = 736)]
        /* 0x7F60 */ public float SpaceMarkersOffset;
        [NMS(Index = 131)]
        /* 0x7F64 */ public float StackSizeChangeMaxRate;
        [NMS(Index = 130)]
        /* 0x7F68 */ public float StackSizeChangeMinRate;
        [NMS(Index = 129)]
        /* 0x7F6C */ public float StackSizeRateChangeRate;
        [NMS(Index = 121)]
        /* 0x7F70 */ public float StageStingDisplayTime;
        [NMS(Index = 533)]
        /* 0x7F74 */ public float StandingRewardOSDTime;
        [NMS(Index = 896)]
        /* 0x7F78 */ public float StatsMessageDelayTime;
        [NMS(Index = 136)]
        /* 0x7F7C */ public float SteamDeckFrontendZoomFactor;
        [NMS(Index = 1464)]
        /* 0x7F80 */ public float SteamDeckMinFontHeight;
        [NMS(Index = 34)]
        /* 0x7F84 */ public float StoreDialDecayTime;
        [NMS(Index = 33)]
        /* 0x7F88 */ public float StoreDialHoldTime;
        [NMS(Index = 35)]
        /* 0x7F8C */ public float StoreDialInnerRadius;
        [NMS(Index = 36)]
        /* 0x7F90 */ public float StoreDialOuterRadius;
        [NMS(Index = 89)]
        /* 0x7F94 */ public float SuperchargeGradientFactor;
        [NMS(Index = 88)]
        /* 0x7F98 */ public float SuperchargeGradientFactorMin;
        [NMS(Index = 90)]
        /* 0x7F9C */ public float SuperchargeGradientTime;
        [NMS(Index = 804)]
        /* 0x7FA0 */ public float SurveyObjectArrowOffsetMultiplier;
        [NMS(Index = 364)]
        /* 0x7FA4 */ public float TakeoffFuelMessageTime;
        [NMS(Index = 593)]
        /* 0x7FA8 */ public float TalkBoxAlienTextSpeed;
        [NMS(Index = 595)]
        /* 0x7FAC */ public float TalkBoxAlienTextTimeMax;
        [NMS(Index = 594)]
        /* 0x7FB0 */ public float TalkBoxAlienTextTimeMin;
        [NMS(Index = 568)]
        /* 0x7FB4 */ public float TargetDisplayDamageFlashTime;
        [NMS(Index = 563)]
        /* 0x7FB8 */ public float TargetDisplayScale;
        [NMS(Index = 565)]
        /* 0x7FBC */ public float TargetDisplayShipScale;
        [NMS(Index = 564)]
        /* 0x7FC0 */ public float TargetDisplayTorpedoScale;
        [NMS(Index = 1220)]
        /* 0x7FC4 */ public float TargetMarkerFadeAngleMin;
        [NMS(Index = 1221)]
        /* 0x7FC8 */ public float TargetMarkerFadeAngleRange;
        [NMS(Index = 1219)]
        /* 0x7FCC */ public float TargetMarkerScaleEnd;
        [NMS(Index = 1218)]
        /* 0x7FD0 */ public float TargetMarkerScaleStart;
        [NMS(Index = 1403)]
        /* 0x7FD4 */ public float TargetParallaxMaintenancePageMultiplier;
        [NMS(Index = 1402)]
        /* 0x7FD8 */ public float TargetParallaxMouseMultiplier;
        [NMS(Index = 1024)]
        /* 0x7FDC */ public float TargetScreenDistance;
        [NMS(Index = 1023)]
        /* 0x7FE0 */ public float TargetScreenFoV;
        [NMS(Index = 819)]
        /* 0x7FE4 */ public float TechDisplayDelayTime;
        [NMS(Index = 463)]
        /* 0x7FE8 */ public float TechPopupBuildLayerHeight;
        [NMS(Index = 461)]
        /* 0x7FEC */ public float TechPopupInstallLayerHeight;
        [NMS(Index = 462)]
        /* 0x7FF0 */ public float TechPopupRepairLayerHeight;
        [NMS(Index = 464)]
        /* 0x7FF4 */ public float TechPopupRequirementHeight;
        [NMS(Index = 1426)]
        /* 0x7FF8 */ public float TextChatMaxDisplayTime;
        [NMS(Index = 1427)]
        /* 0x7FFC */ public float TextChatStayBigAfterTextInput;
        [NMS(Index = 200)]
        /* 0x8000 */ public float TextPrintoutMultiplier;
        [NMS(Index = 201)]
        /* 0x8004 */ public float TextPrintoutMultiplierAlien;
        [NMS(Index = 29)]
        /* 0x8008 */ public float TextTouchScrollCap;
        [NMS(Index = 782)]
        /* 0x800C */ public float ThirdPersonCrosshairCircle1Distance;
        [NMS(Index = 783)]
        /* 0x8010 */ public float ThirdPersonCrosshairCircle2Distance;
        [NMS(Index = 781)]
        /* 0x8014 */ public float ThirdPersonCrosshairDistance;
        [NMS(Index = 608)]
        /* 0x8018 */ public float TimedEventLookTime;
        [NMS(Index = 946)]
        /* 0x801C */ public float TooltipTime;
        [NMS(Index = 30)]
        /* 0x8020 */ public float TouchScrollChangePageThreshold;
        [NMS(Index = 27)]
        /* 0x8024 */ public float TouchScrollMaxDelta;
        [NMS(Index = 28)]
        /* 0x8028 */ public float TouchScrollSpeedMul;
        [NMS(Index = 779)]
        /* 0x802C */ public float TrackCriticalHitSize;
        [NMS(Index = 780)]
        /* 0x8030 */ public float TrackCriticalPulseTime;
        [NMS(Index = 755)]
        /* 0x8034 */ public float TrackLeadTargetInScale;
        [NMS(Index = 752)]
        /* 0x8038 */ public float TrackMissileTargetPulseRate;
        [NMS(Index = 745)]
        /* 0x803C */ public float TrackPoliceFreighterCentreOffset;
        [NMS(Index = 744)]
        /* 0x8040 */ public float TrackPrimaryCentreOffset;
        [NMS(Index = 757)]
        /* 0x8044 */ public float TrackReticuleAngle;
        [NMS(Index = 759)]
        /* 0x8048 */ public float TrackReticuleInactiveTime;
        [NMS(Index = 758)]
        /* 0x804C */ public float TrackReticuleInTime;
        [NMS(Index = 761)]
        /* 0x8050 */ public float TrackReticuleRandomDelay;
        [NMS(Index = 760)]
        /* 0x8054 */ public float TrackReticuleRandomTime;
        [NMS(Index = 756)]
        /* 0x8058 */ public float TrackReticuleScale;
        [NMS(Index = 753)]
        /* 0x805C */ public float TrackScaleCritical;
        [NMS(Index = 754)]
        /* 0x8060 */ public float TrackScaleHit;
        [NMS(Index = 746)]
        /* 0x8064 */ public float TrackTimerAlpha;
        [NMS(Index = 750)]
        /* 0x8068 */ public float TrackTimerIconExclaimRadius;
        [NMS(Index = 749)]
        /* 0x806C */ public float TrackTimerIconInnerRadius;
        [NMS(Index = 748)]
        /* 0x8070 */ public float TrackTimerIconOuterRadius;
        [NMS(Index = 747)]
        /* 0x8074 */ public float TrackTimerRadarPulseSize;
        [NMS(Index = 743)]
        /* 0x8078 */ public float TrackTypeIconSize;
        [NMS(Index = 32)]
        /* 0x807C */ public float TradePageNotifyOffset;
        [NMS(Index = 375)]
        /* 0x8080 */ public float TransferPopupCursorOffsetFactor;
        [NMS(Index = 607)]
        /* 0x8084 */ public float TransferSendOffscreenBorder;
        [NMS(Index = 514)]
        /* 0x8088 */ public float TransitionOffset;
        [NMS(Index = 326)]
        /* 0x808C */ public float TravelLineThickness;
        [NMS(Index = 325)]
        /* 0x8090 */ public float TravelTargetRadius;
        [NMS(Index = 39)]
        /* 0x8094 */ public float TrialUpsellDeclineDecayTimeQuick;
        [NMS(Index = 41)]
        /* 0x8098 */ public float TrialUpsellDeclineDecayTimeSlow;
        [NMS(Index = 42)]
        /* 0x809C */ public float TrialUpsellDeclineDialInnerRadius;
        [NMS(Index = 43)]
        /* 0x80A0 */ public float TrialUpsellDeclineDialOuterRadius;
        [NMS(Index = 38)]
        /* 0x80A4 */ public float TrialUpsellDeclineHoldTimeQuick;
        [NMS(Index = 40)]
        /* 0x80A8 */ public float TrialUpsellDeclineHoldTimeSlow;
        [NMS(Index = 104)]
        /* 0x80AC */ public int UnknownWordsToShowInCatalogue;
        [NMS(Index = 1466)]
        /* 0x80B0 */ public float UnlockableTreeDefaultGroupGap;
        [NMS(Index = 1468)]
        /* 0x80B4 */ public float UnlockableTreeDefaultRowGap;
        [NMS(Index = 1467)]
        /* 0x80B8 */ public float UnlockableTreeNarrowGroupGap;
        [NMS(Index = 1469)]
        /* 0x80BC */ public float UnlockableTreeNarrowRowGap;
        [NMS(Index = 107)]
        /* 0x80C0 */ public float UseZoomedOutBuildCamRadius;
        [NMS(Index = 221)]
        /* 0x80C4 */ public int VRFaceLockedScreenHeight;
        [NMS(Index = 220)]
        /* 0x80C8 */ public int VRFaceLockedScreenWidth;
        [NMS(Index = 362)]
        /* 0x80CC */ public float WantedDetectMessageTime;
        [NMS(Index = 363)]
        /* 0x80D0 */ public float WantedDetectMinTimeout;
        [NMS(Index = 892)]
        /* 0x80D4 */ public float WantedLevelScanAlpha;
        [NMS(Index = 893)]
        /* 0x80D8 */ public float WantedLevelScannedRate;
        [NMS(Index = 890)]
        /* 0x80DC */ public float WantedLevelTimeoutPulseRate;
        [NMS(Index = 891)]
        /* 0x80E0 */ public float WantedLevelWitnessAlpha;
        [NMS(Index = 889)]
        /* 0x80E4 */ public float WantedLevelWitnessOffset;
        [NMS(Index = 888)]
        /* 0x80E8 */ public float WantedLevelWitnessPulseRate;
        [NMS(Index = 1449)]
        /* 0x80EC */ public float WinGDKHandheldPopupScale;
        [NMS(Index = 134)]
        /* 0x80F0 */ public float ZoomFactorOverride;
        [NMS(Index = 958)]
        /* 0x80F4 */ public float ZoomHUDElementsOffsetX;
        [NMS(Index = 959)]
        /* 0x80F8 */ public float ZoomHUDElementsOffsetY;
        [NMS(Index = 960)]
        /* 0x80FC */ public float ZoomHUDElementTime;
        [NMS(Index = 1322)]
        /* 0x8100 */ public NMSString0x100 HUDCircleAnimIcon;
        [NMS(Index = 1320)]
        /* 0x8200 */ public NMSString0x100 HUDDeathPointIcon;
        [NMS(Index = 1321)]
        /* 0x8300 */ public NMSString0x100 HUDHexAnimIcon;
        [NMS(Index = 1316)]
        /* 0x8400 */ public NMSString0x100 HUDMarkerColourIcon;
        [NMS(Index = 1314)]
        /* 0x8500 */ public NMSString0x100 HUDMarkerIcon;
        [NMS(Index = 1315)]
        /* 0x8600 */ public NMSString0x100 HUDMarkerPrimaryIndicatorIcon;
        [NMS(Index = 1317)]
        /* 0x8700 */ public NMSString0x100 HUDPointIcon;
        [NMS(Index = 1319)]
        /* 0x8800 */ public NMSString0x100 HUDSaveIcon;
        [NMS(Index = 1318)]
        /* 0x8900 */ public NMSString0x100 HUDSpaceshipIcon;
        [NMS(Index = 956)]
        /* 0x8A00 */ public NMSString0x20 DistanceUnitKM;
        [NMS(Index = 955)]
        /* 0x8A20 */ public NMSString0x20 DistanceUnitM;
        [NMS(Index = 957)]
        /* 0x8A40 */ public NMSString0x20 DistanceUnitMpS;
        [NMS(Index = 523)]
        /* 0x8A60 */ public NMSString0x20 MaxDialogCharSizeIdeographicString;
        [NMS(Index = 521)]
        /* 0x8A80 */ public NMSString0x20 MaxDialogCharSizeRomanString;
        [NMS(Index = 217)]
        /* 0x8AA0 */ public NMSString0x20 VRDistanceWarningUIFile;
        [NMS(Index = 409, Size = 0x15, EnumType = typeof(GcBuildMenuOption.BuildMenuOptionEnum))]
        /* 0x8AC0 */ public bool[] BuildMenuUseSmallIconOnPad;
        [NMS(Index = 1462)]
        /* 0x8AD5 */ public bool AllowInventorySorting;
        [NMS(Index = 203)]
        /* 0x8AD6 */ public bool AllowInWorldDebugBorders;
        [NMS(Index = 194)]
        /* 0x8AD7 */ public bool AllowProjectorRepositioning;
        [NMS(Index = 333)]
        /* 0x8AD8 */ public bool AlwaysCloseQuickMenu;
        [NMS(Index = 685)]
        /* 0x8AD9 */ public TkCurveType ArrowBounceLeftCurve;
        [NMS(Index = 681)]
        /* 0x8ADA */ public TkCurveType ArrowBounceRightCurve;
        [NMS(Index = 109)]
        /* 0x8ADB */ public bool AutoScrollParagraphs;
        [NMS(Index = 437)]
        /* 0x8ADC */ public bool BaseBuildingSmoothMenuWhileSnapped;
        [NMS(Index = 97)]
        /* 0x8ADD */ public bool BigPicking;
        [NMS(Index = 98)]
        /* 0x8ADE */ public bool BigPickingUsesNumbers;
        [NMS(Index = 178)]
        /* 0x8ADF */ public bool BinocularScanScreen;
        [NMS(Index = 398)]
        /* 0x8AE0 */ public TkCurveType CompassCurve;
        [NMS(Index = 767)]
        /* 0x8AE1 */ public bool CreatureInteractLabelUseBB;
        [NMS(Index = 766)]
        /* 0x8AE2 */ public TkCurveType CreatureReticuleAlphaCurve;
        [NMS(Index = 765)]
        /* 0x8AE3 */ public TkCurveType CreatureReticuleScaleCurve;
        [NMS(Index = 706)]
        /* 0x8AE4 */ public TkCurveType CrosshairLeadScaleCurve;
        [NMS(Index = 724)]
        /* 0x8AE5 */ public TkCurveType CrosshairTargetLockAlphaCurve;
        [NMS(Index = 723)]
        /* 0x8AE6 */ public TkCurveType CrosshairTargetLockCurve;
        [NMS(Index = 636)]
        /* 0x8AE7 */ public TkCurveType DamageNumberUpCurve;
        [NMS(Index = 339)]
        /* 0x8AE8 */ public bool DebugInventoryIndices;
        [NMS(Index = 581)]
        /* 0x8AE9 */ public bool DebugMarkerLabels;
        [NMS(Index = 336)]
        /* 0x8AEA */ public bool DebugMissionLogText;
        [NMS(Index = 338)]
        /* 0x8AEB */ public bool DebugPopupSizes;
        [NMS(Index = 337)]
        /* 0x8AEC */ public bool DebugShowMaintenanceScreenCentre;
        [NMS(Index = 1447)]
        /* 0x8AED */ public bool EnableAccessibleUIOnSwitch;
        [NMS(Index = 467)]
        /* 0x8AEE */ public bool EnableBlackouts;
        [NMS(Index = 823)]
        /* 0x8AEF */ public bool EnableBuilderRobotGreekConversion;
        [NMS(Index = 265)]
        /* 0x8AF0 */ public bool EnableCraftingTree;
        [NMS(Index = 202)]
        /* 0x8AF1 */ public bool EnableHandMenuButtons;
        [NMS(Index = 234)]
        /* 0x8AF2 */ public bool EnableHandMenuDebug;
        [NMS(Index = 824)]
        /* 0x8AF3 */ public bool EnableKanaConversion;
        [NMS(Index = 102)]
        /* 0x8AF4 */ public bool EnablePopupUses;
        [NMS(Index = 340)]
        /* 0x8AF5 */ public bool FixedInventoryIconPositions;
        [NMS(Index = 1136)]
        /* 0x8AF6 */ public TkCurveType FrontendBootBarCurve;
        [NMS(Index = 1121)]
        /* 0x8AF7 */ public TkCurveType FrontendConfirmCurve;
        [NMS(Index = 1208)]
        /* 0x8AF8 */ public TkCurveType FrontendDoFCurve;
        [NMS(Index = 898)]
        /* 0x8AF9 */ public bool HideExtremePlanetNotifications;
        [NMS(Index = 1424)]
        /* 0x8AFA */ public bool HideQuickMenuControls;
        [NMS(Index = 1357)]
        /* 0x8AFB */ public TkCurveType HUDMarkerActiveCurve;
        [NMS(Index = 1327)]
        /* 0x8AFC */ public TkCurveType HUDMarkerAnimAlphaCurve;
        [NMS(Index = 1328)]
        /* 0x8AFD */ public TkCurveType HUDMarkerAnimCurve;
        [NMS(Index = 856)]
        /* 0x8AFE */ public TkCurveType HUDPlayerTrackArrowEnergyShieldDepletedCurve;
        [NMS(Index = 861)]
        /* 0x8AFF */ public TkCurveType HUDPlayerTrackArrowEnergyShieldStartChargeCurve;
        [NMS(Index = 315)]
        /* 0x8B00 */ public bool InteractionInWorldPlayerCamAlways;
        [NMS(Index = 1001)]
        /* 0x8B01 */ public TkCurveType InteractionScanSlapCurve;
        [NMS(Index = 526)]
        /* 0x8B02 */ public bool LeadTargetEnabled;
        [NMS(Index = 1028)]
        /* 0x8B03 */ public bool ModelRendererBGPass;
        [NMS(Index = 1029)]
        /* 0x8B04 */ public bool ModelRendererPass1;
        [NMS(Index = 1030)]
        /* 0x8B05 */ public bool ModelRendererPass2;
        [NMS(Index = 1405)]
        /* 0x8B06 */ public TkCurveType NGuiModelViewFadeInAfterRenderCurve;
        [NMS(Index = 1406)]
        /* 0x8B07 */ public bool NGuiUseSeparateLayersForModelAndReflection;
        [NMS(Index = 222)]
        /* 0x8B08 */ public bool OnlyShowEjectHandlesInVR;
        [NMS(Index = 77)]
        /* 0x8B09 */ public TkCurveType PadCursorUICurve;
        [NMS(Index = 516)]
        /* 0x8B0A */ public TkCurveType PageTurnCurve;
        [NMS(Index = 517)]
        /* 0x8B0B */ public TkCurveType PageTurnFadeCurve;
        [NMS(Index = 1140)]
        /* 0x8B0C */ public TkCurveType PopupActivateCurve1;
        [NMS(Index = 1141)]
        /* 0x8B0D */ public TkCurveType PopupActivateCurve2;
        [NMS(Index = 570)]
        /* 0x8B0E */ public bool ProgressiveDialogStyle;
        [NMS(Index = 1425)]
        /* 0x8B0F */ public bool QuickMenuAllowCycle;
        [NMS(Index = 266)]
        /* 0x8B10 */ public bool QuickMenuEnableSwipe;
        [NMS(Index = 335)]
        /* 0x8B11 */ public bool RepairTechUseTechIcon;
        [NMS(Index = 93)]
        /* 0x8B12 */ public bool ReplaceItemBarWithNumbers;
        [NMS(Index = 1043)]
        /* 0x8B13 */ public bool ShieldHUDAlwaysOn;
        [NMS(Index = 583)]
        /* 0x8B14 */ public bool ShowDamageNumbers;
        [NMS(Index = 62)]
        /* 0x8B15 */ public bool ShowDifficultyForBases;
        [NMS(Index = 895)]
        /* 0x8B16 */ public bool ShowJetpackNotificationForNonTerrain;
        [NMS(Index = 615)]
        /* 0x8B17 */ public bool ShowOnscreenPredatorMarkers;
        [NMS(Index = 63)]
        /* 0x8B18 */ public bool ShowPadlockForLockedSettings;
        [NMS(Index = 218)]
        /* 0x8B19 */ public bool ShowVRDistanceWarning;
        [NMS(Index = 133)]
        /* 0x8B1A */ public bool SkipShopIntro;
        [NMS(Index = 1251)]
        /* 0x8B1B */ public TkCurveType SpaceMapDistanceCurve;
        [NMS(Index = 1237)]
        /* 0x8B1C */ public bool SpaceMapShowAnomaly;
        [NMS(Index = 1238)]
        /* 0x8B1D */ public bool SpaceMapShowAnomalyLines;
        [NMS(Index = 1244)]
        /* 0x8B1E */ public bool SpaceMapShowFrieghterLines;
        [NMS(Index = 1243)]
        /* 0x8B1F */ public bool SpaceMapShowFrieghters;
        [NMS(Index = 1239)]
        /* 0x8B20 */ public bool SpaceMapShowNexus;
        [NMS(Index = 1240)]
        /* 0x8B21 */ public bool SpaceMapShowNexusLines;
        [NMS(Index = 1234)]
        /* 0x8B22 */ public bool SpaceMapShowPlanetLines;
        [NMS(Index = 1233)]
        /* 0x8B23 */ public bool SpaceMapShowPlanets;
        [NMS(Index = 1246)]
        /* 0x8B24 */ public bool SpaceMapShowPulseEncounterLines;
        [NMS(Index = 1245)]
        /* 0x8B25 */ public bool SpaceMapShowPulseEncounters;
        [NMS(Index = 1242)]
        /* 0x8B26 */ public bool SpaceMapShowShipLines;
        [NMS(Index = 1241)]
        /* 0x8B27 */ public bool SpaceMapShowShips;
        [NMS(Index = 1235)]
        /* 0x8B28 */ public bool SpaceMapShowStation;
        [NMS(Index = 1236)]
        /* 0x8B29 */ public bool SpaceMapShowStationLines;
        [NMS(Index = 527)]
        /* 0x8B2A */ public bool SpaceOnlyLeadTargetEnabled;
        [NMS(Index = 103)]
        /* 0x8B2B */ public bool TechBoxesCanStack;
        [NMS(Index = 777)]
        /* 0x8B2C */ public TkCurveType TrackCritCurve;
        [NMS(Index = 763)]
        /* 0x8B2D */ public TkCurveType TrackReticuleInAngleCurve;
        [NMS(Index = 762)]
        /* 0x8B2E */ public TkCurveType TrackReticuleInCurve;
        [NMS(Index = 1110)]
        /* 0x8B2F */ public bool UseCursorHoverSlowFixedValue;
        [NMS(Index = 105)]
        /* 0x8B30 */ public bool UseIntermediateMissionGiverOptions;
        [NMS(Index = 829)]
        /* 0x8B31 */ public bool UseNamesOnShipHUD;
        [NMS(Index = 96)]
        /* 0x8B32 */ public bool UseSquareSlots;
        [NMS(Index = 334)]
        /* 0x8B33 */ public bool UseWorldNodesForRepair;
    }
}
