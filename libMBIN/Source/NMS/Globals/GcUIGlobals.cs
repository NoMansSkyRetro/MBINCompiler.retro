using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x44F9AE10596A7CA8, NameHash = 0xD1FA1B1C)]
    public class GcUIGlobals : NMSTemplate
    {
        [NMS(Index = 1095)]
        /* 0x0000 */ public GcModelViewCollection ModelViews;
        [NMS(Index = 1094, Size = 0xB, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x23C0 */ public TkModelRendererData[] ShipThumbnailRenderSettings;
        [NMS(Index = 1093)]
        /* 0x2B50 */ public TkModelRendererData HoverShipThumbnailModelView;
        [NMS(Index = 1091)]
        /* 0x2C00 */ public TkModelRendererData LargeMultitoolThumbnailModelView;
        [NMS(Index = 1090)]
        /* 0x2CB0 */ public TkModelRendererData MultitoolThumbnailModelView;
        [NMS(Index = 1089)]
        /* 0x2D60 */ public TkModelRendererData PetThumbnailModelView;
        [NMS(Index = 467)]
        /* 0x2E10 */ public TkModelRendererData RepairBackpackCamera;
        [NMS(Index = 465)]
        /* 0x2EC0 */ public TkModelRendererData RepairCamera;
        [NMS(Index = 468)]
        /* 0x2F70 */ public TkModelRendererData RepairShipCameraInWorld;
        [NMS(Index = 469)]
        /* 0x3020 */ public TkModelRendererData RepairShipCameraModelView;
        [NMS(Index = 470)]
        /* 0x30D0 */ public TkModelRendererData RepairShipCameraVR;
        [NMS(Index = 466)]
        /* 0x3180 */ public TkModelRendererData RepairWeaponCamera;
        [NMS(Index = 1092)]
        /* 0x3230 */ public TkModelRendererData SpookShipThumbnailModelView;
        [NMS(Index = 1425)]
        /* 0x32E0 */ public TkNGuiTreeViewTemplate FileBrowserTreeViewTemplate;
        [NMS(Index = 1424)]
        /* 0x3360 */ public TkNGuiTreeViewTemplate SceneInfoTreeViewTemplate;
        [NMS(Index = 1426)]
        /* 0x33E0 */ public TkNGuiTreeViewTemplate SkeletonToolsTreeViewTemplate;
        [NMS(Index = 573)]
        /* 0x3460 */ public GcScanEffectData DebugEditorPreviewEffect;
        [NMS(Index = 659)]
        /* 0x34B0 */ public GcScanEffectData FreighterSummonScanEffect;
        [NMS(Index = 333)]
        /* 0x3500 */ public GcHUDEffectRewardData OSDEpicItemRewardEffect;
        [NMS(Index = 332)]
        /* 0x3550 */ public GcHUDEffectRewardData OSDRareItemRewardEffect;
        [NMS(Index = 874, Size = 0x5, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x35A0 */ public Colour[] SystemHooverLEDColours;
        [NMS(Index = 875, Size = 0x5, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x35F0 */ public Colour[] SystemHooverStatusBarColours;
        [NMS(Index = 560)]
        /* 0x3640 */ public GcScanEffectData TargetDisplayScanEffect;
        [NMS(Index = 1283)]
        /* 0x3690 */ public GcSpaceMapObjectData SpaceMapAtlasData;
        [NMS(Index = 1284)]
        /* 0x36C0 */ public GcSpaceMapObjectData SpaceMapBlackHoleData;
        [NMS(Index = 1286)]
        /* 0x36F0 */ public GcSpaceMapObjectData SpaceMapFreighterData;
        [NMS(Index = 1279)]
        /* 0x3720 */ public GcSpaceMapObjectData SpaceMapMarkerData;
        [NMS(Index = 1282)]
        /* 0x3750 */ public GcSpaceMapObjectData SpaceMapNexusData;
        [NMS(Index = 1280)]
        /* 0x3780 */ public GcSpaceMapObjectData SpaceMapPlanetData;
        [NMS(Index = 1287)]
        /* 0x37B0 */ public GcSpaceMapObjectData SpaceMapPulseEncounterData;
        [NMS(Index = 1285)]
        /* 0x37E0 */ public GcSpaceMapObjectData SpaceMapShipData;
        [NMS(Index = 1281)]
        /* 0x3810 */ public GcSpaceMapObjectData SpaceMapStationData;
        [NMS(Index = 1357)]
        /* 0x3840 */ public Colour AltimeterBandColour1;
        [NMS(Index = 1358)]
        /* 0x3850 */ public Colour AltimeterBandColour2;
        [NMS(Index = 1359)]
        /* 0x3860 */ public Colour AltimeterColour1;
        [NMS(Index = 1360)]
        /* 0x3870 */ public Colour AltimeterColour2;
        [NMS(Index = 395)]
        /* 0x3880 */ public Colour BaseComplexityDangerColour;
        [NMS(Index = 393)]
        /* 0x3890 */ public Colour BaseComplexityDefaultColour;
        [NMS(Index = 394)]
        /* 0x38A0 */ public Colour BaseComplexityWarningColour;
        [NMS(Index = 179)]
        /* 0x38B0 */ public Vector3f BinocularPanelLinePointOffset;
        [NMS(Index = 403)]
        /* 0x38C0 */ public Colour BuildMenuErrorTextColour;
        [NMS(Index = 405)]
        /* 0x38D0 */ public Colour BuildMenuErrorTextFlashColour;
        [NMS(Index = 404)]
        /* 0x38E0 */ public Colour BuildMenuErrorTextOutlineColour;
        [NMS(Index = 406)]
        /* 0x38F0 */ public Colour BuildMenuErrorTextOutlineFlashColour;
        [NMS(Index = 407)]
        /* 0x3900 */ public Colour BuildMenuInfoTextColour;
        [NMS(Index = 408)]
        /* 0x3910 */ public Colour BuildMenuInfoTextOutlineColour;
        [NMS(Index = 401)]
        /* 0x3920 */ public Colour BuildMenuPassiveErrorTextColour;
        [NMS(Index = 402)]
        /* 0x3930 */ public Colour BuildMenuPassiveErrorTextOutlineColour;
        [NMS(Index = 1144)]
        /* 0x3940 */ public Colour ByteBeatArpGridActiveColour;
        [NMS(Index = 1143)]
        /* 0x3950 */ public Colour ByteBeatArpGridInactiveColour;
        [NMS(Index = 1146)]
        /* 0x3960 */ public Colour ByteBeatArpPipActiveColour;
        [NMS(Index = 1145)]
        /* 0x3970 */ public Colour ByteBeatArpPipInactiveColour;
        [NMS(Index = 1162)]
        /* 0x3980 */ public Colour ByteBeatRhythmColour0Active;
        [NMS(Index = 1163)]
        /* 0x3990 */ public Colour ByteBeatRhythmColour0Inactive;
        [NMS(Index = 1164)]
        /* 0x39A0 */ public Colour ByteBeatRhythmColour1Active;
        [NMS(Index = 1165)]
        /* 0x39B0 */ public Colour ByteBeatRhythmColour1Inactive;
        [NMS(Index = 1166)]
        /* 0x39C0 */ public Colour ByteBeatRhythmColour2Active;
        [NMS(Index = 1167)]
        /* 0x39D0 */ public Colour ByteBeatRhythmColour2Inactive;
        [NMS(Index = 1158)]
        /* 0x39E0 */ public Colour ByteBeatSequencerBGColourActive;
        [NMS(Index = 1159)]
        /* 0x39F0 */ public Colour ByteBeatSequencerBGColourInactive;
        [NMS(Index = 1168)]
        /* 0x3A00 */ public Colour ByteBeatSequencerHighlightColour;
        [NMS(Index = 1160)]
        /* 0x3A10 */ public Colour ByteBeatSequencerRimColourActive;
        [NMS(Index = 1161)]
        /* 0x3A20 */ public Colour ByteBeatSequencerRimColourInactive;
        [NMS(Index = 1157)]
        /* 0x3A30 */ public Colour ByteBeatSequencerUnpoweredTint;
        [NMS(Index = 1173)]
        /* 0x3A40 */ public Colour ByteBeatSliderFGColour;
        [NMS(Index = 1174)]
        /* 0x3A50 */ public Colour ByteBeatSliderTextActiveColour;
        [NMS(Index = 1175)]
        /* 0x3A60 */ public Colour ByteBeatSliderTextInactiveColour;
        [NMS(Index = 1134)]
        /* 0x3A70 */ public Colour ByteBeatTreeLineColour;
        [NMS(Index = 1137)]
        /* 0x3A80 */ public Colour ByteBeatVisGridColour;
        [NMS(Index = 1136)]
        /* 0x3A90 */ public Colour ByteBeatVisLineColour;
        [NMS(Index = 563)]
        /* 0x3AA0 */ public Colour CommunicatorMessageColour;
        [NMS(Index = 716)]
        /* 0x3AB0 */ public Colour CrosshairColour;
        [NMS(Index = 705)]
        /* 0x3AC0 */ public Colour CrosshairLeadPassiveColour;
        [NMS(Index = 704)]
        /* 0x3AD0 */ public Colour CrosshairLeadThreatColour;
        [NMS(Index = 1096)]
        /* 0x3AE0 */ public Colour CursorColour;
        [NMS(Index = 1097)]
        /* 0x3AF0 */ public Colour CursorConfirmColour;
        [NMS(Index = 1099)]
        /* 0x3B00 */ public Colour CursorDeleteColour;
        [NMS(Index = 1098)]
        /* 0x3B10 */ public Colour CursorTransferUploadColour;
        [NMS(Index = 628)]
        /* 0x3B20 */ public Colour DamageNumberCriticalColour;
        [NMS(Index = 629)]
        /* 0x3B30 */ public Colour DamageNumberIneffectiveColour;
        [NMS(Index = 630)]
        /* 0x3B40 */ public Colour DamageNumberIneffectiveWarningColour;
        [NMS(Index = 944)]
        /* 0x3B50 */ public Colour DeathMessageColour;
        [NMS(Index = 292)]
        /* 0x3B60 */ public Colour DebugEditorAxisColourAtActive;
        [NMS(Index = 291)]
        /* 0x3B70 */ public Colour DebugEditorAxisColourAtInactive;
        [NMS(Index = 290)]
        /* 0x3B80 */ public Colour DebugEditorAxisColourRightActive;
        [NMS(Index = 289)]
        /* 0x3B90 */ public Colour DebugEditorAxisColourRightInactive;
        [NMS(Index = 288)]
        /* 0x3BA0 */ public Colour DebugEditorAxisColourUpActive;
        [NMS(Index = 287)]
        /* 0x3BB0 */ public Colour DebugEditorAxisColourUpInactive;
        [NMS(Index = 483)]
        /* 0x3BC0 */ public Vector3f DefaultRefinerOffsetIn;
        [NMS(Index = 484)]
        /* 0x3BD0 */ public Vector3f DefaultRefinerOffsetOut;
        [NMS(Index = 1062)]
        /* 0x3BE0 */ public Colour EnergyBgColour;
        [NMS(Index = 1063)]
        /* 0x3BF0 */ public Colour EnergyBgPulseColour;
        [NMS(Index = 210)]
        /* 0x3C00 */ public Vector3f FaceLockedScreenOffset;
        [NMS(Index = 660)]
        /* 0x3C10 */ public Colour FreighterSummonScanEffectColourBlocked;
        [NMS(Index = 661)]
        /* 0x3C20 */ public Colour FreighterSummonScanEffectColourHighlight;
        [NMS(Index = 295)]
        /* 0x3C30 */ public Colour FrontendCursorBackgroundColour;
        [NMS(Index = 633)]
        /* 0x3C40 */ public Colour FuelBgColour;
        [NMS(Index = 501)]
        /* 0x3C50 */ public Colour GridBackgroundNegativeColour;
        [NMS(Index = 499)]
        /* 0x3C60 */ public Colour GridBackgroundNeutralColour;
        [NMS(Index = 500)]
        /* 0x3C70 */ public Colour GridBackgroundPositiveColour;
        [NMS(Index = 496)]
        /* 0x3C80 */ public Colour GridDisconnectedColour;
        [NMS(Index = 498)]
        /* 0x3C90 */ public Colour GridOfflineColour;
        [NMS(Index = 497)]
        /* 0x3CA0 */ public Colour GridOnlineColour;
        [NMS(Index = 1064)]
        /* 0x3CB0 */ public Colour HazardBgPulseColour;
        [NMS(Index = 1065)]
        /* 0x3CC0 */ public Colour HazardDamagePulseColour;
        [NMS(Index = 298)]
        /* 0x3CD0 */ public Vector3f HmdFramerateScreenOffset;
        [NMS(Index = 1298)]
        /* 0x3CE0 */ public Colour HUDMarkerColour;
        [NMS(Index = 871)]
        /* 0x3CF0 */ public Colour HUDNotifyColour;
        [NMS(Index = 1302)]
        /* 0x3D00 */ public Colour HUDOutpostColour;
        [NMS(Index = 835)]
        /* 0x3D10 */ public Colour HUDPlayerTrackArrowDamageGlowHullHitMaxColour;
        [NMS(Index = 836)]
        /* 0x3D20 */ public Colour HUDPlayerTrackArrowDamageGlowHullHitMinColour;
        [NMS(Index = 839)]
        /* 0x3D30 */ public Colour HUDPlayerTrackArrowDamageGlowShieldHitMaxColour;
        [NMS(Index = 840)]
        /* 0x3D40 */ public Colour HUDPlayerTrackArrowDamageGlowShieldHitMinColour;
        [NMS(Index = 866)]
        /* 0x3D50 */ public Colour HUDPlayerTrackArrowDotColour;
        [NMS(Index = 868)]
        /* 0x3D60 */ public Colour HUDPlayerTrackArrowDotColourPirate;
        [NMS(Index = 867)]
        /* 0x3D70 */ public Colour HUDPlayerTrackArrowDotColourPolice;
        [NMS(Index = 869)]
        /* 0x3D80 */ public Colour HUDPlayerTrackArrowDotColourTrader;
        [NMS(Index = 827)]
        /* 0x3D90 */ public Colour HUDPlayerTrackArrowEnergyShieldColour;
        [NMS(Index = 848)]
        /* 0x3DA0 */ public Colour HUDPlayerTrackArrowEnergyShieldDepletedGlowMaxColour;
        [NMS(Index = 849)]
        /* 0x3DB0 */ public Colour HUDPlayerTrackArrowEnergyShieldDepletedGlowMinColour;
        [NMS(Index = 828)]
        /* 0x3DC0 */ public Colour HUDPlayerTrackArrowEnergyShieldLowColour;
        [NMS(Index = 853)]
        /* 0x3DD0 */ public Colour HUDPlayerTrackArrowEnergyShieldStartChargeGlowMaxColour;
        [NMS(Index = 854)]
        /* 0x3DE0 */ public Colour HUDPlayerTrackArrowEnergyShieldStartChargeGlowMinColour;
        [NMS(Index = 824)]
        /* 0x3DF0 */ public Colour HUDPlayerTrackArrowTextColour;
        [NMS(Index = 1300)]
        /* 0x3E00 */ public Colour HUDRelicMarkerColourDiscovered;
        [NMS(Index = 1301)]
        /* 0x3E10 */ public Colour HUDRelicMarkerColourUnknown;
        [NMS(Index = 1299)]
        /* 0x3E20 */ public Colour HUDSpaceshipColour;
        [NMS(Index = 870)]
        /* 0x3E30 */ public Colour HUDWarningColour;
        [NMS(Index = 414)]
        /* 0x3E40 */ public Colour IconGlowColourActive;
        [NMS(Index = 413)]
        /* 0x3E50 */ public Colour IconGlowColourError;
        [NMS(Index = 416)]
        /* 0x3E60 */ public Colour IconGlowColourHighlight;
        [NMS(Index = 415)]
        /* 0x3E70 */ public Colour IconGlowColourNeutral;
        [NMS(Index = 473)]
        /* 0x3E80 */ public Colour InteractionLabelCostColour;
        [NMS(Index = 474)]
        /* 0x3E90 */ public Colour InteractionLabelPickupColour;
        [NMS(Index = 475)]
        /* 0x3EA0 */ public Colour InteractionLabelPickupFillColour;
        [NMS(Index = 73)]
        /* 0x3EB0 */ public Colour InvSlotGradientBaseColour;
        [NMS(Index = 144)]
        /* 0x3EC0 */ public Vector3f InWorldInteractLabelCentreOffset;
        [NMS(Index = 146)]
        /* 0x3ED0 */ public Vector3f InWorldInteractLabelLineOffset;
        [NMS(Index = 145)]
        /* 0x3EE0 */ public Vector3f InWorldInteractLabelTopOffset;
        [NMS(Index = 203)]
        /* 0x3EF0 */ public Vector3f InWorldNGuiScreenRotation;
        [NMS(Index = 147)]
        /* 0x3F00 */ public Vector3f InWorldStaffBinocsScreenOffset;
        [NMS(Index = 980)]
        /* 0x3F10 */ public Colour ItemSlotColourPartiallyInstalled;
        [NMS(Index = 982)]
        /* 0x3F20 */ public Colour ItemSlotColourProduct;
        [NMS(Index = 976)]
        /* 0x3F30 */ public Colour ItemSlotColourSubstance;
        [NMS(Index = 977)]
        /* 0x3F40 */ public Colour ItemSlotColourTech;
        [NMS(Index = 978)]
        /* 0x3F50 */ public Colour ItemSlotColourTechCharge;
        [NMS(Index = 979)]
        /* 0x3F60 */ public Colour ItemSlotColourTechDamage;
        [NMS(Index = 985)]
        /* 0x3F70 */ public Colour ItemSlotTextColourProduct;
        [NMS(Index = 983)]
        /* 0x3F80 */ public Colour ItemSlotTextColourSubstance;
        [NMS(Index = 984)]
        /* 0x3F90 */ public Colour ItemSlotTextColourTech;
        [NMS(Index = 72)]
        /* 0x3FA0 */ public Colour JoaoBoxCompletedObjectiveColour;
        [NMS(Index = 1363)]
        /* 0x3FB0 */ public Colour LockOnMarkerActiveColour;
        [NMS(Index = 199)]
        /* 0x3FC0 */ public Vector3f LowerHelmetScreenOffset;
        [NMS(Index = 448)]
        /* 0x3FD0 */ public Colour MarkerRingBGColour;
        [NMS(Index = 525)]
        /* 0x3FE0 */ public Colour MissionOSDMessageBarColour;
        [NMS(Index = 344)]
        /* 0x3FF0 */ public Colour MultiplayerMissionParticipantsColour;
        [NMS(Index = 55)]
        /* 0x4000 */ public Colour NetworkPopupTextDisabledColour;
        [NMS(Index = 54)]
        /* 0x4010 */ public Colour NetworkPopupTextEnabledColour;
        [NMS(Index = 1381)]
        /* 0x4020 */ public Vector3f NGuiModelTranslationFactors;
        [NMS(Index = 1382)]
        /* 0x4030 */ public Vector3f NGuiModelTranslationFactorsInteraction;
        [NMS(Index = 1383)]
        /* 0x4040 */ public Vector3f NGuiThumbnailModelTranslationFactors;
        [NMS(Index = 527)]
        /* 0x4050 */ public Colour NotificationDangerColour;
        [NMS(Index = 526)]
        /* 0x4060 */ public Colour NotificationDefaultColour;
        [NMS(Index = 528)]
        /* 0x4070 */ public Colour NotificationInfoColour;
        [NMS(Index = 529)]
        /* 0x4080 */ public Colour NotificationUrgentColour;
        [NMS(Index = 5)]
        /* 0x4090 */ public Vector3f OutpostReturnMarkerOffset;
        [NMS(Index = 631)]
        /* 0x40A0 */ public Colour PhotoModeSelectedColour;
        [NMS(Index = 632)]
        /* 0x40B0 */ public Colour PhotoModeUnselectedColour;
        [NMS(Index = 343)]
        /* 0x40C0 */ public Colour PickedItemBorderColour;
        [NMS(Index = 945)]
        /* 0x40D0 */ public Colour PinnedRecipeBorder;
        [NMS(Index = 339)]
        /* 0x40E0 */ public Colour ProcProductColourCommon;
        [NMS(Index = 341)]
        /* 0x40F0 */ public Colour ProcProductColourRare;
        [NMS(Index = 340)]
        /* 0x4100 */ public Colour ProcProductColourUncommon;
        [NMS(Index = 809)]
        /* 0x4110 */ public Colour PulseAlertColour;
        [NMS(Index = 808)]
        /* 0x4120 */ public Colour PulseDamageColour;
        [NMS(Index = 293)]
        /* 0x4130 */ public Colour QuickMenuSelectedItemColour1;
        [NMS(Index = 294)]
        /* 0x4140 */ public Colour QuickMenuSelectedItemColour2;
        [NMS(Index = 1182)]
        /* 0x4150 */ public Colour RadialMenuInnerColourDisabled;
        [NMS(Index = 1178)]
        /* 0x4160 */ public Colour RadialMenuInnerColourSelected;
        [NMS(Index = 1180)]
        /* 0x4170 */ public Colour RadialMenuInnerColourUnselected;
        [NMS(Index = 1183)]
        /* 0x4180 */ public Colour RadialMenuOuterColourDisabled;
        [NMS(Index = 1179)]
        /* 0x4190 */ public Colour RadialMenuOuterColourSelected;
        [NMS(Index = 1181)]
        /* 0x41A0 */ public Colour RadialMenuOuterColourUnselected;
        [NMS(Index = 494)]
        /* 0x41B0 */ public Colour RefinerBackgroundColour;
        [NMS(Index = 495)]
        /* 0x41C0 */ public Colour RefinerErrorBackgroundColour;
        [NMS(Index = 722)]
        /* 0x41D0 */ public Colour RemappedControlColour;
        [NMS(Index = 721)]
        /* 0x41E0 */ public Colour SelectedControlColour;
        [NMS(Index = 1431)]
        /* 0x41F0 */ public Colour SettlementStatBackgroundColour;
        [NMS(Index = 1430)]
        /* 0x4200 */ public Colour SettlementStatColour;
        [NMS(Index = 1068)]
        /* 0x4210 */ public Colour ShieldBgColour;
        [NMS(Index = 1066)]
        /* 0x4220 */ public Colour ShieldColour;
        [NMS(Index = 1069)]
        /* 0x4230 */ public Colour ShieldDamageBgColour;
        [NMS(Index = 1067)]
        /* 0x4240 */ public Colour ShieldDamageColour;
        [NMS(Index = 20)]
        /* 0x4250 */ public Colour ShipBuilderLineColour;
        [NMS(Index = 19)]
        /* 0x4260 */ public Colour ShipBuilderLineColourHologram;
        [NMS(Index = 1010)]
        /* 0x4270 */ public Colour ShipHUDAimTargetColour;
        [NMS(Index = 1011)]
        /* 0x4280 */ public Colour ShipHUDAimTargetCritColour;
        [NMS(Index = 1008)]
        /* 0x4290 */ public Colour ShipHUDTargetArrowsColourLocal;
        [NMS(Index = 1006)]
        /* 0x42A0 */ public Colour ShipHUDTargetArrowsColourOutOfRange;
        [NMS(Index = 1007)]
        /* 0x42B0 */ public Colour ShipHUDTargetArrowsColourThreat;
        [NMS(Index = 4)]
        /* 0x42C0 */ public Vector3f ShipTeleportPadMarkerOffset;
        [NMS(Index = 1271)]
        /* 0x42D0 */ public Colour SpaceEnemyShipLineColour;
        [NMS(Index = 1270)]
        /* 0x42E0 */ public Colour SpaceFriendlyShipLineColour;
        [NMS(Index = 1273)]
        /* 0x42F0 */ public Colour SpaceMapAttackColour;
        [NMS(Index = 542)]
        /* 0x4300 */ public Vector3f SpaceMapCockpitOffset;
        [NMS(Index = 1278)]
        /* 0x4310 */ public Colour SpaceMapDeathPointColour;
        [NMS(Index = 1276)]
        /* 0x4320 */ public Colour SpaceMapNeutralColour;
        [NMS(Index = 1274)]
        /* 0x4330 */ public Colour SpaceMapOtherPlayerColour;
        [NMS(Index = 1272)]
        /* 0x4340 */ public Vector3f SpaceMapPosScaler;
        [NMS(Index = 1277)]
        /* 0x4350 */ public Colour SpaceMapSquadronColour;
        [NMS(Index = 1275)]
        /* 0x4360 */ public Colour SpaceMapThreatColour;
        [NMS(Index = 1454)]
        /* 0x4370 */ public Colour SpookMeterColour;
        [NMS(Index = 31)]
        /* 0x4380 */ public Colour StoreDialFillColour;
        [NMS(Index = 79)]
        /* 0x4390 */ public Colour SuperchargeGradientBaseColour;
        [NMS(Index = 80)]
        /* 0x43A0 */ public Colour SuperchargeGradientBlendColour;
        [NMS(Index = 81)]
        /* 0x43B0 */ public Colour SuperchargeGradientTechColour;
        [NMS(Index = 78)]
        /* 0x43C0 */ public Colour SuperchargePopupColour;
        [NMS(Index = 557)]
        /* 0x43D0 */ public Vector3f TargetDisplayShipOffset;
        [NMS(Index = 558)]
        /* 0x43E0 */ public Vector3f TargetDisplayTorpedoOffset;
        [NMS(Index = 1207)]
        /* 0x43F0 */ public Colour TargetMarkerColour;
        [NMS(Index = 1208)]
        /* 0x4400 */ public Colour TargetMarkerHighlightColour;
        [NMS(Index = 25)]
        /* 0x4410 */ public Colour TouchButtonChargeIndicatorColour;
        [NMS(Index = 502)]
        /* 0x4420 */ public Colour TransferSendPopupColour;
        [NMS(Index = 318)]
        /* 0x4430 */ public Colour TravelLineColour;
        [NMS(Index = 321)]
        /* 0x4440 */ public Colour TravelLineInvalidColour;
        [NMS(Index = 322)]
        /* 0x4450 */ public Colour TravelLineNotAllowedColour;
        [NMS(Index = 319)]
        /* 0x4460 */ public Colour TravelLineTooFarColour;
        [NMS(Index = 320)]
        /* 0x4470 */ public Colour TravelLineTooSteepColour;
        [NMS(Index = 323)]
        /* 0x4480 */ public Colour TravelTargetColour;
        [NMS(Index = 1217)]
        /* 0x4490 */ public Colour UnseenItemColour;
        [NMS(Index = 1216)]
        /* 0x44A0 */ public Colour WantedColour;
        [NMS(Index = 46)]
        /* 0x44B0 */ public Colour WristMenuDefaultBorderColour;
        [NMS(Index = 47)]
        /* 0x44C0 */ public Colour WristMenuRepositionableBorderColour;
        [NMS(Index = 65, Size = 0xF, EnumType = typeof(GcWonderCreatureCategory.WonderCreatureCategoryEnum))]
        /* 0x44D0 */ public GcWonderCategoryConfig[] WonderCreatureCategoryConfig;
        [NMS(Index = 68, Size = 0xD, EnumType = typeof(GcWonderTreasureCategory.WonderTreasureCategoryEnum))]
        /* 0x4818 */ public GcWonderCategoryConfig[] WonderTreasureCategoryConfig;
        [NMS(Index = 398, Size = 0x15, EnumType = typeof(GcBuildMenuOption.BuildMenuOptionEnum))]
        /* 0x4AF0 */ public NMSString0x20A[] BuildMenuOnActionDisabledLocIDs;
        [NMS(Index = 399, Size = 0x15, EnumType = typeof(GcBuildMenuOption.BuildMenuOptionEnum))]
        /* 0x4D90 */ public NMSString0x20A[] BuildMenuOnActionErrorLocIDs;
        [NMS(Index = 397, Size = 0x15, EnumType = typeof(GcBuildMenuOption.BuildMenuOptionEnum))]
        /* 0x5030 */ public NMSString0x20A[] BuildMenuOnActionLocIDs;
        [NMS(Index = 70, Size = 0xC, EnumType = typeof(GcWonderCustomCategory.WonderCustomCategoryEnum))]
        /* 0x52D0 */ public GcWonderCategoryConfig[] WonderCustomCategoryConfig;
        [NMS(Index = 64, Size = 0xB, EnumType = typeof(GcWonderPlanetCategory.WonderPlanetCategoryEnum))]
        /* 0x5570 */ public GcWonderCategoryConfig[] WonderPlanetCategoryConfig;
        [NMS(Index = 69, Size = 0xB, EnumType = typeof(GcWonderWeirdBasePartCategory.WonderWeirdBasePartCategoryEnum))]
        /* 0x57D8 */ public GcWonderCategoryConfig[] WonderWeirdBasePartCategoryConfig;
        [NMS(Index = 66, Size = 0x8, EnumType = typeof(GcWonderFloraCategory.WonderFloraCategoryEnum))]
        /* 0x5A40 */ public GcWonderCategoryConfig[] WonderFloraCategoryConfig;
        [NMS(Index = 67, Size = 0x8, EnumType = typeof(GcWonderMineralCategory.WonderMineralCategoryEnum))]
        /* 0x5C00 */ public GcWonderCategoryConfig[] WonderMineralCategoryConfig;
        [NMS(Index = 1399)]
        /* 0x5DC0 */ public GcHUDStartupTable IntroTiming;
        [NMS(Index = 1400)]
        /* 0x5F10 */ public GcHUDStartupTable IntroTimingFreighter;
        [NMS(Index = 1401)]
        /* 0x6060 */ public GcHUDStartupTable IntroTimingFreighterRepaired;
        [NMS(Index = 1433, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x61B0 */ public NMSString0x20A[] SettlementStatFormatLoc;
        [NMS(Index = 1432, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x62B0 */ public NMSString0x20A[] SettlementStatLoc;
        [NMS(Index = 1434, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x63B0 */ public TkTextureResource[] SettlementStatBasicImages;
        [NMS(Index = 1436, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x6470 */ public TkTextureResource[] SettlementStatNegativeImages;
        [NMS(Index = 1435, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x6530 */ public TkTextureResource[] SettlementStatPositiveImages;
        [NMS(Index = 59, Size = 0x7, EnumType = typeof(GcWonderType.WonderTypeEnum))]
        /* 0x65F0 */ public TkTextureResource[] WonderTypeIcons;
        [NMS(Index = 443)]
        /* 0x6698 */ public TkTextureResource BaseBuildingPartsGridExpandableIcon;
        [NMS(Index = 444)]
        /* 0x66B0 */ public TkTextureResource BaseBuildingPartsGridExpandedIcon;
        [NMS(Index = 445)]
        /* 0x66C8 */ public TkTextureResource BaseBuildingPartsGridRetractableIcon;
        [NMS(Index = 478)]
        /* 0x66E0 */ public TkTextureResource RefinerPopupEmptyOutputIcon;
        [NMS(Index = 1060)]
        /* 0x66F8 */ public GcFilename CamoNormalTexture;
        [NMS(Index = 1059)]
        /* 0x6708 */ public GcFilename CamoTexture;
        [NMS(Index = 88)]
        /* 0x6718 */ public NMSString0x10 DebugInventoryHint;
        [NMS(Index = 120)]
        /* 0x6728 */ public NMSString0x10 ExplorationLogMissionID;
        [NMS(Index = 1058)]
        /* 0x6738 */ public List<Vector4f> HazardDistortionParams;
        [NMS(Index = 1054)]
        /* 0x6748 */ public List<GcFilename> HazardHeightmaps;
        [NMS(Index = 1057)]
        /* 0x6758 */ public List<GcFilename> HazardHeightmapsVR;
        [NMS(Index = 1053)]
        /* 0x6768 */ public List<GcFilename> HazardNormalMaps;
        [NMS(Index = 1056)]
        /* 0x6778 */ public List<GcFilename> HazardNormalMapsVR;
        [NMS(Index = 1052)]
        /* 0x6788 */ public List<GcFilename> HazardTextures;
        [NMS(Index = 1055)]
        /* 0x6798 */ public List<GcFilename> HazardTexturesVR;
        [NMS(Index = 342)]
        /* 0x67A8 */ public List<Vector2f> InventoryIconPositions;
        [NMS(Index = 346)]
        /* 0x67B8 */ public NMSString0x10 MultiplayerMissionInteractEndTrigger;
        [NMS(Index = 345)]
        /* 0x67C8 */ public NMSString0x10 MultiplayerMissionInteractStartTrigger;
        [NMS(Index = 108)]
        /* 0x67D8 */ public List<GcSeasonalRingArray> SeasonalRingTable;
        [NMS(Index = 1009)]
        /* 0x67E8 */ public List<Colour> ShipHUDTargetArrowsColour;
        [NMS(Index = 813)]
        /* 0x67F8 */ public NMSString0x10 ShowStatWithDeathQuote;
        [NMS(Index = 885)]
        /* 0x6808 */ public List<GcFilename> StatIcons;
        [NMS(Index = 471)]
        /* 0x6818 */ public List<TkModelRendererData> VehicleTypeRepairCamera;
        [NMS(Index = 713, Size = 0x15, EnumType = typeof(GcPlayerWeapons.WeaponModeEnum))]
        /* 0x6828 */ public float[] CrosshairTargetLockSizeSpecific;
        [NMS(Index = 967)]
        /* 0x687C */ public GcWorldUISettings WorldUISettings;
        [NMS(Index = 61, Size = 0xF, EnumType = typeof(GcWonderCreatureCategory.WonderCreatureCategoryEnum))]
        /* 0x68CC */ public float[] WonderValueModifiersCreature;
        [NMS(Index = 60, Size = 0xB, EnumType = typeof(GcWonderPlanetCategory.WonderPlanetCategoryEnum))]
        /* 0x6908 */ public float[] WonderValueModifiersPlanet;
        [NMS(Index = 62, Size = 0x8, EnumType = typeof(GcWonderFloraCategory.WonderFloraCategoryEnum))]
        /* 0x6934 */ public float[] WonderValueModifiersFlora;
        [NMS(Index = 63, Size = 0x8, EnumType = typeof(GcWonderMineralCategory.WonderMineralCategoryEnum))]
        /* 0x6954 */ public float[] WonderValueModifiersMineral;
        [NMS(Index = 1403)]
        /* 0x6974 */ public GcInventorySlotActionData BuildProductSlotAction;
        [NMS(Index = 1404)]
        /* 0x6990 */ public GcInventorySlotActionData ChargeSlotAction;
        [NMS(Index = 1402)]
        /* 0x69AC */ public GcInventorySlotActionData InstallTechSlotAction;
        [NMS(Index = 1408)]
        /* 0x69C8 */ public GcInventorySlotActionData InventoryHintAction;
        [NMS(Index = 1409)]
        /* 0x69E4 */ public GcInventorySlotActionData InventoryHintActionNoGlow;
        [NMS(Index = 1407)]
        /* 0x6A00 */ public GcInventorySlotActionData NewSlotPulseAction;
        [NMS(Index = 1406)]
        /* 0x6A1C */ public GcInventorySlotActionData NewSlotRevealAction;
        [NMS(Index = 1405)]
        /* 0x6A38 */ public GcInventorySlotActionData RepairSlotAction;
        [NMS(Index = 0)]
        /* 0x6A54 */ public GcInteractionDof InteractionDOFDisabled;
        [NMS(Index = 806)]
        /* 0x6A68 */ public TkNGuiRectanglePulseEffect PulseBarData;
        [NMS(Index = 807)]
        /* 0x6A78 */ public TkNGuiRectanglePulseEffect PulseIconData;
        [NMS(Index = 717)]
        /* 0x6A88 */ public TkHitCurveData CrosshairLeadHitCurve;
        [NMS(Index = 1398)]
        /* 0x6A94 */ public GcDiscoveryHelperTimings DiscoveryHelperTimings;
        [NMS(Index = 718)]
        /* 0x6AA0 */ public TkHitCurveData ShootableHitCurve;
        [NMS(Index = 164)]
        /* 0x6AAC */ public Vector2f BinocularEdgeFade;
        [NMS(Index = 472)]
        /* 0x6AB4 */ public Vector2f BinocularsDiscoveryPos;
        [NMS(Index = 375)]
        /* 0x6ABC */ public Vector2f CompassCentre;
        [NMS(Index = 94)]
        /* 0x6AC4 */ public Vector2f ControlsPageParallax;
        [NMS(Index = 537)]
        /* 0x6ACC */ public Vector2f CursorlessDialogPageCursorOffset;
        [NMS(Index = 623)]
        /* 0x6AD4 */ public Vector2f DamageNumberSideSpeed;
        [NMS(Index = 535)]
        /* 0x6ADC */ public Vector2f DialogPageCursorOffset;
        [NMS(Index = 1304)]
        /* 0x6AE4 */ public Vector2f HUDMarkerCompassPrimaryIndicatorOffset;
        [NMS(Index = 1303)]
        /* 0x6AEC */ public Vector2f HUDMarkerPrimaryIndicatorOffset;
        [NMS(Index = 487)]
        /* 0x6AF4 */ public Vector2f HUDPlayerSentinelPulseFreq;
        [NMS(Index = 488)]
        /* 0x6AFC */ public Vector2f HUDPlayerSentinelPulseSize;
        [NMS(Index = 842)]
        /* 0x6B04 */ public Vector2f HUDPlayerTrackArrowDamageGlowSize;
        [NMS(Index = 844)]
        /* 0x6B0C */ public Vector2f HUDPlayerTrackArrowEnergyShieldGlowSize;
        [NMS(Index = 831)]
        /* 0x6B14 */ public Vector2f HUDPlayerTrackArrowEnergyShieldSize;
        [NMS(Index = 826)]
        /* 0x6B1C */ public Vector2f HUDPlayerTrackArrowHealthSize;
        [NMS(Index = 779)]
        /* 0x6B24 */ public Vector2f HUDPlayerTrackArrowIconPulseSize;
        [NMS(Index = 791)]
        /* 0x6B2C */ public Vector2f HUDPlayerTrackIconOffset;
        [NMS(Index = 1290)]
        /* 0x6B34 */ public Vector2f HUDTargetHealthIconOffset;
        [NMS(Index = 1288)]
        /* 0x6B3C */ public Vector2f HUDTargetHealthOffset;
        [NMS(Index = 1289)]
        /* 0x6B44 */ public Vector2f HUDTargetHealthSize;
        [NMS(Index = 1071)]
        /* 0x6B4C */ public Vector2f InteractionLabelOffset;
        [NMS(Index = 1072)]
        /* 0x6B54 */ public Vector2f InteractionLabelOffset_1;
        [NMS(Index = 1075)]
        /* 0x6B5C */ public Vector2f InteractionLabelScreenMax;
        [NMS(Index = 1074)]
        /* 0x6B64 */ public Vector2f InteractionLabelScreenMin;
        [NMS(Index = 1076)]
        /* 0x6B6C */ public Vector2f InteractionLabelSize;
        [NMS(Index = 1078)]
        /* 0x6B74 */ public Vector2f InteractionLabelTouchAreaMax;
        [NMS(Index = 1077)]
        /* 0x6B7C */ public Vector2f InteractionLabelTouchAreaMin;
        [NMS(Index = 1392)]
        /* 0x6B84 */ public Vector2f InteractionWorldParallax;
        [NMS(Index = 536)]
        /* 0x6B8C */ public Vector2f IntermediateInteractionPageCursorOffset;
        [NMS(Index = 205)]
        /* 0x6B94 */ public Vector2f InWorldGameGuiAlignment;
        [NMS(Index = 143)]
        /* 0x6B9C */ public Vector2f InWorldInteractLabelAlignment;
        [NMS(Index = 204)]
        /* 0x6BA4 */ public Vector2f InWorldNGuiParallax;
        [NMS(Index = 520)]
        /* 0x6BAC */ public Vector2f MainMenuSaveIconPosition;
        [NMS(Index = 195)]
        /* 0x6BB4 */ public Vector2f MarkerDistanceVRAlignment;
        [NMS(Index = 486)]
        /* 0x6BBC */ public Vector2f ModelViewWorldParallax;
        [NMS(Index = 1389)]
        /* 0x6BC4 */ public Vector2f NGuiMax2DParallax;
        [NMS(Index = 1388)]
        /* 0x6BCC */ public Vector2f NGuiMin2DParallax;
        [NMS(Index = 1390)]
        /* 0x6BD4 */ public Vector2f NGuiModelParallax;
        [NMS(Index = 1391)]
        /* 0x6BDC */ public Vector2f NGuiShipInteractParallax;
        [NMS(Index = 1206)]
        /* 0x6BE4 */ public Vector2f NGuiTouchPadSensitivity;
        [NMS(Index = 933)]
        /* 0x6BEC */ public Vector2f NotificationMissionHintPauseTime;
        [NMS(Index = 934)]
        /* 0x6BF4 */ public Vector2f NotificationMissionHintPauseTimeCritical;
        [NMS(Index = 935)]
        /* 0x6BFC */ public Vector2f NotificationMissionHintPauseTimeSecondary;
        [NMS(Index = 476)]
        /* 0x6C04 */ public Vector2f PersonalRefinerInputPos;
        [NMS(Index = 477)]
        /* 0x6C0C */ public Vector2f PersonalRefinerOutputPos;
        [NMS(Index = 93)]
        /* 0x6C14 */ public Vector2f PickingCursorOffset;
        [NMS(Index = 969)]
        /* 0x6C1C */ public Vector2f PlanetLabelOffset;
        [NMS(Index = 973)]
        /* 0x6C24 */ public Vector2f PlanetLineOffset;
        [NMS(Index = 970)]
        /* 0x6C2C */ public Vector2f PlanetMeasureOffset;
        [NMS(Index = 971)]
        /* 0x6C34 */ public Vector2f PlanetMeasureOffsetBigText;
        [NMS(Index = 972)]
        /* 0x6C3C */ public Vector2f PlanetMeasureOffsetMoonExtra;
        [NMS(Index = 485)]
        /* 0x6C44 */ public Vector2f RefinerParallax;
        [NMS(Index = 519)]
        /* 0x6C4C */ public Vector2f SaveIconPosition;
        [NMS(Index = 1070)]
        /* 0x6C54 */ public Vector2f ScanLabelOffset;
        [NMS(Index = 1016)]
        /* 0x6C5C */ public Vector2f TargetScreenCamOffset;
        [NMS(Index = 769)]
        /* 0x6C64 */ public Vector2f TrackCriticalHitOffset;
        [NMS(Index = 733)]
        /* 0x6C6C */ public Vector2f TrackTypeIconOffset;
        [NMS(Index = 1423)]
        /* 0x6C74 */ public int AbandonedFreighterAirlockRoomNumber;
        [NMS(Index = 1441)]
        /* 0x6C78 */ public float AccessibleUIHUDPopupScale;
        [NMS(Index = 1439)]
        /* 0x6C7C */ public float AccessibleUIPopupScale;
        [NMS(Index = 178)]
        /* 0x6C80 */ public float AlignmentRequiredToDisableFrostedGlass;
        [NMS(Index = 1351)]
        /* 0x6C84 */ public float AltimeterLineSpacing;
        [NMS(Index = 1354)]
        /* 0x6C88 */ public float AltimeterMax;
        [NMS(Index = 1353)]
        /* 0x6C8C */ public float AltimeterMin;
        [NMS(Index = 1356)]
        /* 0x6C90 */ public float AltimeterMinValue;
        [NMS(Index = 1350)]
        /* 0x6C94 */ public float AltimeterResolution;
        [NMS(Index = 1355)]
        /* 0x6C98 */ public float AltimeterTextSize;
        [NMS(Index = 1352)]
        /* 0x6C9C */ public float AltimeterWidth;
        [NMS(Index = 1045)]
        /* 0x6CA0 */ public float AlwaysOnHazardMultiplierCold;
        [NMS(Index = 1043)]
        /* 0x6CA4 */ public float AlwaysOnHazardMultiplierHeat;
        [NMS(Index = 1044)]
        /* 0x6CA8 */ public float AlwaysOnHazardMultiplierRad;
        [NMS(Index = 1050)]
        /* 0x6CAC */ public float AlwaysOnHazardMultiplierSpook;
        [NMS(Index = 1042)]
        /* 0x6CB0 */ public float AlwaysOnHazardMultiplierTox;
        [NMS(Index = 1040)]
        /* 0x6CB4 */ public float AlwaysOnHazardStrengthCold;
        [NMS(Index = 1038)]
        /* 0x6CB8 */ public float AlwaysOnHazardStrengthHeat;
        [NMS(Index = 1039)]
        /* 0x6CBC */ public float AlwaysOnHazardStrengthRad;
        [NMS(Index = 1041)]
        /* 0x6CC0 */ public float AlwaysOnHazardStrengthSpook;
        [NMS(Index = 1037)]
        /* 0x6CC4 */ public float AlwaysOnHazardStrengthTox;
        [NMS(Index = 1036)]
        /* 0x6CC8 */ public float AlwaysOnHazardThreshold;
        [NMS(Index = 678)]
        /* 0x6CCC */ public float AlwaysShowIconFadeDistance;
        [NMS(Index = 679)]
        /* 0x6CD0 */ public float AlwaysShowIconFadeRange;
        [NMS(Index = 1414)]
        /* 0x6CD4 */ public float AmbientModeFadeTime;
        [NMS(Index = 673)]
        /* 0x6CD8 */ public float ArrowBounceLeftRate1;
        [NMS(Index = 674)]
        /* 0x6CDC */ public float ArrowBounceLeftRate2;
        [NMS(Index = 675)]
        /* 0x6CE0 */ public float ArrowBounceLeftRate3;
        [NMS(Index = 668)]
        /* 0x6CE4 */ public float ArrowBounceLength;
        [NMS(Index = 669)]
        /* 0x6CE8 */ public float ArrowBounceRate;
        [NMS(Index = 670)]
        /* 0x6CEC */ public float ArrowBounceRightRate1;
        [NMS(Index = 671)]
        /* 0x6CF0 */ public float ArrowBounceRightRate2;
        [NMS(Index = 1365)]
        /* 0x6CF4 */ public float AsteroidMarkerMinDisplayAngleDegrees;
        [NMS(Index = 1364)]
        /* 0x6CF8 */ public float AsteroidMarkerMinDisplayDistance;
        [NMS(Index = 427)]
        /* 0x6CFC */ public float BaseBuildingFreeRotateDelayBeforeAudioStops;
        [NMS(Index = 426)]
        /* 0x6D00 */ public float BaseBuildingFreeRotateDelayBeforeReset;
        [NMS(Index = 425)]
        /* 0x6D04 */ public float BaseBuildingFreeRotateSpeedPadMultiplier;
        [NMS(Index = 419)]
        /* 0x6D08 */ public float BaseBuildingInputHighlightAlpha;
        [NMS(Index = 418)]
        /* 0x6D0C */ public float BaseBuildingInputHighlightDuration;
        [NMS(Index = 422)]
        /* 0x6D10 */ public float BaseBuildingMaxFreeRotateSpeed;
        [NMS(Index = 421)]
        /* 0x6D14 */ public float BaseBuildingMinFreeRotateSpeed;
        [NMS(Index = 438)]
        /* 0x6D18 */ public float BaseBuildingPartsGridBreadcrumbFlashDuration;
        [NMS(Index = 437)]
        /* 0x6D1C */ public float BaseBuildingPartsGridMaxCursorRestorationTime;
        [NMS(Index = 439)]
        /* 0x6D20 */ public float BaseBuildingPartsGridMinVisibilityForActive;
        [NMS(Index = 442)]
        /* 0x6D24 */ public float BaseBuildingPartsGridPopupDelay;
        [NMS(Index = 440)]
        /* 0x6D28 */ public float BaseBuildingPartsGridScrollSpeed;
        [NMS(Index = 441)]
        /* 0x6D2C */ public float BaseBuildingPartsGridScrollSpeedPad;
        [NMS(Index = 417)]
        /* 0x6D30 */ public float BaseBuildingPinHighlightDuration;
        [NMS(Index = 424)]
        /* 0x6D34 */ public float BaseBuildingRotationResetRate;
        [NMS(Index = 420)]
        /* 0x6D38 */ public float BaseBuildingScaleSpeed;
        [NMS(Index = 423)]
        /* 0x6D3C */ public float BaseBuildingTimeToMaxRotationSpeed;
        [NMS(Index = 436)]
        /* 0x6D40 */ public float BaseBuildingUIAdjustTime;
        [NMS(Index = 435)]
        /* 0x6D44 */ public float BaseBuildingUIErrorFadeTime;
        [NMS(Index = 429)]
        /* 0x6D48 */ public float BaseBuildingUIHorizontalSafeArea;
        [NMS(Index = 432)]
        /* 0x6D4C */ public float BaseBuildingUIVerticalOffset;
        [NMS(Index = 433)]
        /* 0x6D50 */ public float BaseBuildingUIVerticalOffsetEdit;
        [NMS(Index = 434)]
        /* 0x6D54 */ public float BaseBuildingUIVerticalOffsetFromBB;
        [NMS(Index = 431)]
        /* 0x6D58 */ public float BaseBuildingUIVerticalPosWiring;
        [NMS(Index = 430)]
        /* 0x6D5C */ public float BaseBuildingUIVerticalSafeArea;
        [NMS(Index = 391)]
        /* 0x6D60 */ public float BaseComplexityDangerFactor;
        [NMS(Index = 392)]
        /* 0x6D64 */ public float BaseComplexityWarningFactor;
        [NMS(Index = 6)]
        /* 0x6D68 */ public float BattleHUDBarInterpTime;
        [NMS(Index = 163)]
        /* 0x6D6C */ public float BeaconHUDMarkerOffset;
        [NMS(Index = 167)]
        /* 0x6D70 */ public float BinocularMarkerSideAngle;
        [NMS(Index = 168)]
        /* 0x6D74 */ public float BinocularMarkerUpAngle;
        [NMS(Index = 177)]
        /* 0x6D78 */ public float BinocularsAltUIRescaleFactor;
        [NMS(Index = 165)]
        /* 0x6D7C */ public float BinocularScreenOffset;
        [NMS(Index = 166)]
        /* 0x6D80 */ public float BinocularScreenScale;
        [NMS(Index = 175)]
        /* 0x6D84 */ public float BinocularsFarIconDist;
        [NMS(Index = 176)]
        /* 0x6D88 */ public float BinocularsFarIconFadeDist;
        [NMS(Index = 174)]
        /* 0x6D8C */ public float BinocularsFarIconOpacity;
        [NMS(Index = 173)]
        /* 0x6D90 */ public float BinocularsMidIconOpacity;
        [NMS(Index = 171)]
        /* 0x6D94 */ public float BinocularsNearIconDist;
        [NMS(Index = 172)]
        /* 0x6D98 */ public float BinocularsNearIconFadeDist;
        [NMS(Index = 170)]
        /* 0x6D9C */ public float BinocularsNearIconOpacity;
        [NMS(Index = 503)]
        /* 0x6DA0 */ public float BountyMarkerOffset;
        [NMS(Index = 1419)]
        /* 0x6DA4 */ public int BuildingShopMaxItems;
        [NMS(Index = 396)]
        /* 0x6DA8 */ public float BuildMenuActionMessageDuration;
        [NMS(Index = 260)]
        /* 0x6DAC */ public float BuildMenuItemNavAnimTime;
        [NMS(Index = 261)]
        /* 0x6DB0 */ public float BuildMenuItemNextNavAnimTime;
        [NMS(Index = 262)]
        /* 0x6DB4 */ public float BuildMenuItemNextNavAnimWait;
        [NMS(Index = 1140)]
        /* 0x6DB8 */ public float ByteBeatArpLineWidth;
        [NMS(Index = 1142)]
        /* 0x6DBC */ public float ByteBeatArpPad;
        [NMS(Index = 1141)]
        /* 0x6DC0 */ public float ByteBeatArpRadius;
        [NMS(Index = 1138)]
        /* 0x6DC4 */ public float ByteBeatIconLineWidth;
        [NMS(Index = 1139)]
        /* 0x6DC8 */ public float ByteBeatIconPad;
        [NMS(Index = 1149)]
        /* 0x6DCC */ public float ByteBeatPartSequencerPad;
        [NMS(Index = 1151)]
        /* 0x6DD0 */ public float ByteBeatRhythmBeatPad;
        [NMS(Index = 1155)]
        /* 0x6DD4 */ public float ByteBeatRhythmSequencerActiveSaturation;
        [NMS(Index = 1154)]
        /* 0x6DD8 */ public float ByteBeatRhythmSequencerInactiveSaturation;
        [NMS(Index = 1153)]
        /* 0x6DDC */ public float ByteBeatSequencerActiveSaturation;
        [NMS(Index = 1150)]
        /* 0x6DE0 */ public float ByteBeatSequencerCornerRadius;
        [NMS(Index = 1169)]
        /* 0x6DE4 */ public float ByteBeatSequencerHighlightLineWidth;
        [NMS(Index = 1152)]
        /* 0x6DE8 */ public float ByteBeatSequencerInactiveSaturation;
        [NMS(Index = 1147)]
        /* 0x6DEC */ public float ByteBeatSequencerLineWidth;
        [NMS(Index = 1148)]
        /* 0x6DF0 */ public float ByteBeatSequencerPad;
        [NMS(Index = 1156)]
        /* 0x6DF4 */ public float ByteBeatSequencerUnpoweredTintStrength;
        [NMS(Index = 1172)]
        /* 0x6DF8 */ public float ByteBeatSliderCornerRadius;
        [NMS(Index = 1170)]
        /* 0x6DFC */ public float ByteBeatSliderLineWidth;
        [NMS(Index = 1171)]
        /* 0x6E00 */ public float ByteBeatSliderPad;
        [NMS(Index = 1176)]
        /* 0x6E04 */ public float ByteBeatSwitchPanelAlpha;
        [NMS(Index = 1177)]
        /* 0x6E08 */ public float ByteBeatSwitchPanelSplit;
        [NMS(Index = 1133)]
        /* 0x6E0C */ public float ByteBeatTreeLineWidth;
        [NMS(Index = 1135)]
        /* 0x6E10 */ public float ByteBeatVisLineWidth;
        [NMS(Index = 126)]
        /* 0x6E14 */ public float ClosestDoorMarkerBuffer;
        [NMS(Index = 190)]
        /* 0x6E18 */ public float CockpitGlassDefrostTime;
        [NMS(Index = 189)]
        /* 0x6E1C */ public float CockpitGlassFrostTime;
        [NMS(Index = 562)]
        /* 0x6E20 */ public float CommunicatorMessageTime;
        [NMS(Index = 387)]
        /* 0x6E24 */ public float CompassAngleClamp;
        [NMS(Index = 390)]
        /* 0x6E28 */ public float CompassAngleClampSpace;
        [NMS(Index = 388)]
        /* 0x6E2C */ public float CompassAngleFade;
        [NMS(Index = 384)]
        /* 0x6E30 */ public float CompassDistanceMarkerMinScale;
        [NMS(Index = 385)]
        /* 0x6E34 */ public float CompassDistanceMaxAngle;
        [NMS(Index = 382)]
        /* 0x6E38 */ public float CompassDistanceScale;
        [NMS(Index = 378)]
        /* 0x6E3C */ public float CompassDistanceScaleMin;
        [NMS(Index = 379)]
        /* 0x6E40 */ public float CompassDistanceScaleRange;
        [NMS(Index = 383)]
        /* 0x6E44 */ public float CompassDistanceShipMinScale;
        [NMS(Index = 380)]
        /* 0x6E48 */ public float CompassDistanceSpaceScaleMin;
        [NMS(Index = 381)]
        /* 0x6E4C */ public float CompassDistanceSpaceScaleRange;
        [NMS(Index = 386)]
        /* 0x6E50 */ public float CompassDistanceYOffset;
        [NMS(Index = 376)]
        /* 0x6E54 */ public float CompassHeight;
        [NMS(Index = 196)]
        /* 0x6E58 */ public float CompassIconOffsetVR;
        [NMS(Index = 217)]
        /* 0x6E5C */ public float CompassLineContractionEndAngle;
        [NMS(Index = 216)]
        /* 0x6E60 */ public float CompassLineContractionStartAngle;
        [NMS(Index = 218)]
        /* 0x6E64 */ public float CompassLineContractionTargetAngle;
        [NMS(Index = 222)]
        /* 0x6E68 */ public float CompassLineNotchAngleRange;
        [NMS(Index = 224)]
        /* 0x6E6C */ public float CompassLineNotchLength;
        [NMS(Index = 223)]
        /* 0x6E70 */ public float CompassLineNotchThickness;
        [NMS(Index = 219)]
        /* 0x6E74 */ public int CompassLineNumNotches;
        [NMS(Index = 221)]
        /* 0x6E78 */ public float CompassLineOffset;
        [NMS(Index = 220)]
        /* 0x6E7C */ public float CompassLineThickness;
        [NMS(Index = 215)]
        /* 0x6E80 */ public int CompassScreenHeight;
        [NMS(Index = 214)]
        /* 0x6E84 */ public int CompassScreenWidth;
        [NMS(Index = 377)]
        /* 0x6E88 */ public float CompassWidth;
        [NMS(Index = 592)]
        /* 0x6E8C */ public float ConsoleTextSpeed;
        [NMS(Index = 594)]
        /* 0x6E90 */ public float ConsoleTextTimeMax;
        [NMS(Index = 593)]
        /* 0x6E94 */ public float ConsoleTextTimeMin;
        [NMS(Index = 720)]
        /* 0x6E98 */ public float ControlScrollDistance;
        [NMS(Index = 719)]
        /* 0x6E9C */ public int ControlScrollSteps;
        [NMS(Index = 605)]
        /* 0x6EA0 */ public float CreatureDistanceAlpha;
        [NMS(Index = 603)]
        /* 0x6EA4 */ public float CreatureDistanceDisplayAngle;
        [NMS(Index = 604)]
        /* 0x6EA8 */ public float CreatureDistanceFadeTime;
        [NMS(Index = 601)]
        /* 0x6EAC */ public float CreatureDistanceOffsetY;
        [NMS(Index = 602)]
        /* 0x6EB0 */ public float CreatureDistanceShadowOffset;
        [NMS(Index = 600)]
        /* 0x6EB4 */ public float CreatureDistanceSize;
        [NMS(Index = 368)]
        /* 0x6EB8 */ public float CreatureIconMergeAngle;
        [NMS(Index = 637)]
        /* 0x6EBC */ public float CreatureIconOffset;
        [NMS(Index = 638)]
        /* 0x6EC0 */ public float CreatureIconOffsetPhysics;
        [NMS(Index = 759)]
        /* 0x6EC4 */ public float CreatureInteractLabelOffsetY;
        [NMS(Index = 755)]
        /* 0x6EC8 */ public float CreatureReticuleScale;
        [NMS(Index = 725)]
        /* 0x6ECC */ public float CreatureRoutineMarkerTime;
        [NMS(Index = 726)]
        /* 0x6ED0 */ public int CreatureRoutineRegionsPerFrame;
        [NMS(Index = 811)]
        /* 0x6ED4 */ public float CriticalMessageTime;
        [NMS(Index = 687)]
        /* 0x6ED8 */ public float CrosshairAimOffTime;
        [NMS(Index = 686)]
        /* 0x6EDC */ public float CrosshairAimTime;
        [NMS(Index = 688)]
        /* 0x6EE0 */ public float CrosshairInnerMinFade;
        [NMS(Index = 689)]
        /* 0x6EE4 */ public float CrosshairInnerMinFadeRange;
        [NMS(Index = 710)]
        /* 0x6EE8 */ public float CrosshairInterceptAlpha;
        [NMS(Index = 707)]
        /* 0x6EEC */ public float CrosshairInterceptBaseSize;
        [NMS(Index = 708)]
        /* 0x6EF0 */ public float CrosshairInterceptCentreBaseSize;
        [NMS(Index = 711)]
        /* 0x6EF4 */ public float CrosshairInterceptLockRange;
        [NMS(Index = 706)]
        /* 0x6EF8 */ public float CrosshairInterceptSize;
        [NMS(Index = 709)]
        /* 0x6EFC */ public float CrosshairInterceptSpringTime;
        [NMS(Index = 693)]
        /* 0x6F00 */ public float CrosshairLeadCornerOffset;
        [NMS(Index = 702)]
        /* 0x6F04 */ public float CrosshairLeadFadeRange;
        [NMS(Index = 703)]
        /* 0x6F08 */ public float CrosshairLeadFadeSize;
        [NMS(Index = 691)]
        /* 0x6F0C */ public float CrosshairLeadInDelay;
        [NMS(Index = 692)]
        /* 0x6F10 */ public float CrosshairLeadInTime;
        [NMS(Index = 696)]
        /* 0x6F14 */ public float CrosshairLeadPulseSize;
        [NMS(Index = 690)]
        /* 0x6F18 */ public float CrosshairLeadScaleIn;
        [NMS(Index = 700)]
        /* 0x6F1C */ public float CrosshairLeadSpring;
        [NMS(Index = 701)]
        /* 0x6F20 */ public float CrosshairLeadSpringOff;
        [NMS(Index = 695)]
        /* 0x6F24 */ public float CrosshairLeadTopLock;
        [NMS(Index = 694)]
        /* 0x6F28 */ public float CrosshairLeadTopOffset;
        [NMS(Index = 300)]
        /* 0x6F2C */ public float CrosshairOffsetHmd;
        [NMS(Index = 301)]
        /* 0x6F30 */ public float CrosshairOffsetHmdUp;
        [NMS(Index = 299)]
        /* 0x6F34 */ public float CrosshairScaleHmd;
        [NMS(Index = 303)]
        /* 0x6F38 */ public int CrosshairScreenHeight;
        [NMS(Index = 302)]
        /* 0x6F3C */ public int CrosshairScreenWidth;
        [NMS(Index = 699)]
        /* 0x6F40 */ public float CrosshairSpringAimTime;
        [NMS(Index = 698)]
        /* 0x6F44 */ public float CrosshairSpringTime;
        [NMS(Index = 712)]
        /* 0x6F48 */ public float CrosshairTargetLockSize;
        [NMS(Index = 1102)]
        /* 0x6F4C */ public float CursorHoverSlowFactor;
        [NMS(Index = 1103)]
        /* 0x6F50 */ public float CursorHoverSlowFactorMin;
        [NMS(Index = 1100)]
        /* 0x6F54 */ public float CursorHoverSlowFixedValue;
        [NMS(Index = 534)]
        /* 0x6F58 */ public float DamageDirectionIndicatorOnScreenRadiusMultiplier;
        [NMS(Index = 607)]
        /* 0x6F5C */ public float DamageImpactMergeTime;
        [NMS(Index = 609)]
        /* 0x6F60 */ public float DamageImpactMinDistance;
        [NMS(Index = 608)]
        /* 0x6F64 */ public float DamageImpactTimeBetweenNumbers;
        [NMS(Index = 618)]
        /* 0x6F68 */ public float DamageNumberBlackAlpha;
        [NMS(Index = 624)]
        /* 0x6F6C */ public float DamageNumberFadeIn;
        [NMS(Index = 625)]
        /* 0x6F70 */ public float DamageNumberFadeOut;
        [NMS(Index = 617)]
        /* 0x6F74 */ public float DamageNumberLaserMaxDamage;
        [NMS(Index = 616)]
        /* 0x6F78 */ public float DamageNumberLaserMinDamage;
        [NMS(Index = 621)]
        /* 0x6F7C */ public float DamageNumberOffsetX;
        [NMS(Index = 622)]
        /* 0x6F80 */ public float DamageNumberOffsetY;
        [NMS(Index = 619)]
        /* 0x6F84 */ public float DamageNumberOutline;
        [NMS(Index = 620)]
        /* 0x6F88 */ public float DamageNumberOutline2;
        [NMS(Index = 613)]
        /* 0x6F8C */ public float DamageNumberSize;
        [NMS(Index = 614)]
        /* 0x6F90 */ public float DamageNumberSizeCritMultiplier;
        [NMS(Index = 612)]
        /* 0x6F94 */ public float DamageNumberSizeInShip;
        [NMS(Index = 615)]
        /* 0x6F98 */ public float DamageNumberSizeLaserMultiplier;
        [NMS(Index = 611)]
        /* 0x6F9C */ public float DamageNumberTime;
        [NMS(Index = 626)]
        /* 0x6FA0 */ public float DamageNumberUpOffset;
        [NMS(Index = 610)]
        /* 0x6FA4 */ public float DamagePerSecondSampleTime;
        [NMS(Index = 456)]
        /* 0x6FA8 */ public float DamageScannableHighlightTime;
        [NMS(Index = 457)]
        /* 0x6FAC */ public float DamageTrackArrowTime;
        [NMS(Index = 942)]
        /* 0x6FB0 */ public float DeathMessageSwitchTime;
        [NMS(Index = 943)]
        /* 0x6FB4 */ public float DeathMessageTotalTime;
        [NMS(Index = 58)]
        /* 0x6FB8 */ public int DebugMedalRank;
        [NMS(Index = 1049)]
        /* 0x6FBC */ public float DeepSeaHazardMultiplierCold;
        [NMS(Index = 1047)]
        /* 0x6FC0 */ public float DeepSeaHazardMultiplierHeat;
        [NMS(Index = 1048)]
        /* 0x6FC4 */ public float DeepSeaHazardMultiplierRad;
        [NMS(Index = 1046)]
        /* 0x6FC8 */ public float DeepSeaHazardMultiplierTox;
        [NMS(Index = 639)]
        /* 0x6FCC */ public float DelayBeforeHidingHangarAfterGalaxyMap;
        [NMS(Index = 640)]
        /* 0x6FD0 */ public float DelayBeforeShowingHangarIntoGalaxyMap;
        [NMS(Index = 587)]
        /* 0x6FD4 */ public float DescriptionTextDelay;
        [NMS(Index = 588)]
        /* 0x6FD8 */ public float DescriptionTextSpeed;
        [NMS(Index = 589)]
        /* 0x6FDC */ public float DescriptionTextSpeedProgressive;
        [NMS(Index = 591)]
        /* 0x6FE0 */ public float DescriptionTextTimeMax;
        [NMS(Index = 590)]
        /* 0x6FE4 */ public float DescriptionTextTimeMin;
        [NMS(Index = 1442)]
        /* 0x6FE8 */ public float DetailMessageDismissTime;
        [NMS(Index = 350)]
        /* 0x6FEC */ public float DroneIndicatorCentreRadiusMax;
        [NMS(Index = 351)]
        /* 0x6FF0 */ public float DroneIndicatorCentreRadiusMin;
        [NMS(Index = 352)]
        /* 0x6FF4 */ public float DroneIndicatorFadeRange;
        [NMS(Index = 349)]
        /* 0x6FF8 */ public float DroneIndicatorRadius;
        [NMS(Index = 106)]
        /* 0x6FFC */ public float EggModifiyAnimLoopTime;
        [NMS(Index = 105)]
        /* 0x7000 */ public float EggModifiyAnimMaxSize;
        [NMS(Index = 116)]
        /* 0x7004 */ public float EndOfSeasonAlertDelay;
        [NMS(Index = 155)]
        /* 0x7008 */ public float ExocraftHUDMarkerHideDistance;
        [NMS(Index = 156)]
        /* 0x700C */ public float ExocraftHUDMarkerOffset;
        [NMS(Index = 113)]
        /* 0x7010 */ public float ExpeditionStageChangeTime;
        [NMS(Index = 52)]
        /* 0x7014 */ public float EyeTrackingCursorBlendRate;
        [NMS(Index = 51)]
        /* 0x7018 */ public float EyeTrackingCursorBlendRateGameModeSelect;
        [NMS(Index = 50)]
        /* 0x701C */ public float EyeTrackingPopupLookAwayTime;
        [NMS(Index = 53)]
        /* 0x7020 */ public float EyeTrackingStickyHoverTime;
        [NMS(Index = 49)]
        /* 0x7024 */ public float EyeTrackingTimeBeforePopupsActivate;
        [NMS(Index = 1450)]
        /* 0x7028 */ public float FeedFrigateAnimAlphaChange;
        [NMS(Index = 1448)]
        /* 0x702C */ public int FeedFrigateAnimNumPeriods;
        [NMS(Index = 1447)]
        /* 0x7030 */ public float FeedFrigateAnimPeriod;
        [NMS(Index = 1449)]
        /* 0x7034 */ public float FeedFrigateAnimScaleChange;
        [NMS(Index = 121)]
        /* 0x7038 */ public int ForceOpenHazardProtInventoryThreshold;
        [NMS(Index = 652)]
        /* 0x703C */ public float FreighterCommanderMarkerMinDistance;
        [NMS(Index = 683)]
        /* 0x7040 */ public float FreighterEntranceOffset;
        [NMS(Index = 658)]
        /* 0x7044 */ public float FreighterHighlightRange;
        [NMS(Index = 682)]
        /* 0x7048 */ public float FreighterLeaderIconDistance;
        [NMS(Index = 95)]
        /* 0x704C */ public float FreighterMegaWarpTransitionTime;
        [NMS(Index = 648)]
        /* 0x7050 */ public float FreighterSummonDelay;
        [NMS(Index = 651)]
        /* 0x7054 */ public float FreighterSummonGridSize;
        [NMS(Index = 657)]
        /* 0x7058 */ public float FreighterSummonLookTime;
        [NMS(Index = 643)]
        /* 0x705C */ public float FreighterSummonOffset;
        [NMS(Index = 644)]
        /* 0x7060 */ public float FreighterSummonOffsetPulse;
        [NMS(Index = 642)]
        /* 0x7064 */ public float FreighterSummonPitch;
        [NMS(Index = 656)]
        /* 0x7068 */ public float FreighterSummonPlanetOffset;
        [NMS(Index = 655)]
        /* 0x706C */ public float FreighterSummonPulseFadeAmount;
        [NMS(Index = 654)]
        /* 0x7070 */ public float FreighterSummonPulseRate;
        [NMS(Index = 641)]
        /* 0x7074 */ public float FreighterSummonTurn;
        [NMS(Index = 650)]
        /* 0x7078 */ public float FreighterSummonTurnAngleIncrement;
        [NMS(Index = 649)]
        /* 0x707C */ public int FreighterSummonTurnNumTries;
        [NMS(Index = 653)]
        /* 0x7080 */ public float FreighterSurfaceMinAngle;
        [NMS(Index = 681)]
        /* 0x7084 */ public float FrigateDamageIconVisibilityDistance;
        [NMS(Index = 636)]
        /* 0x7088 */ public float FrigateIconOffset;
        [NMS(Index = 680)]
        /* 0x708C */ public float FrigatePurchaseNotificationResetDistanceMultiplier;
        [NMS(Index = 1122)]
        /* 0x7090 */ public float FrontendActivateSplit;
        [NMS(Index = 1121)]
        /* 0x7094 */ public float FrontendActivateTime;
        [NMS(Index = 1106)]
        /* 0x7098 */ public float FrontendBGAlpha;
        [NMS(Index = 1126)]
        /* 0x709C */ public float FrontendBootBarTime;
        [NMS(Index = 1125)]
        /* 0x70A0 */ public float FrontendBootTime;
        [NMS(Index = 1110)]
        /* 0x70A4 */ public float FrontendConfirmTime;
        [NMS(Index = 1108)]
        /* 0x70A8 */ public float FrontendConfirmTimeFast;
        [NMS(Index = 1107)]
        /* 0x70AC */ public float FrontendConfirmTimeMouseMultiplier;
        [NMS(Index = 1111)]
        /* 0x70B0 */ public float FrontendConfirmTimeSlow;
        [NMS(Index = 1114)]
        /* 0x70B4 */ public float FrontendCursorOffset;
        [NMS(Index = 1113)]
        /* 0x70B8 */ public float FrontendCursorSize;
        [NMS(Index = 1118)]
        /* 0x70BC */ public float FrontendCursorWidth;
        [NMS(Index = 1120)]
        /* 0x70C0 */ public float FrontendDeactivateSplit;
        [NMS(Index = 1119)]
        /* 0x70C4 */ public float FrontendDeactivateTime;
        [NMS(Index = 1198)]
        /* 0x70C8 */ public float FrontendDoFBlurMultiplier;
        [NMS(Index = 1196)]
        /* 0x70CC */ public float FrontendDoFFarPlane;
        [NMS(Index = 1197)]
        /* 0x70D0 */ public float FrontendDoFFarPlaneFade;
        [NMS(Index = 1195)]
        /* 0x70D4 */ public float FrontendDoFNearPlane;
        [NMS(Index = 181)]
        /* 0x70D8 */ public float FrontendOffsetVR;
        [NMS(Index = 1200)]
        /* 0x70DC */ public float FrontendShineSpeed;
        [NMS(Index = 1123)]
        /* 0x70E0 */ public float FrontendStatCircleWidth;
        [NMS(Index = 1124)]
        /* 0x70E4 */ public float FrontendStatCircleWidthExtra;
        [NMS(Index = 1203)]
        /* 0x70E8 */ public float FrontendTitleFontSpacing;
        [NMS(Index = 1201)]
        /* 0x70EC */ public float FrontendToolbarTextHeight;
        [NMS(Index = 1202)]
        /* 0x70F0 */ public float FrontendToolbarTextHeightSelected;
        [NMS(Index = 1109)]
        /* 0x70F4 */ public float FrontendTouchConfirmTimeFastMultiplier;
        [NMS(Index = 582)]
        /* 0x70F8 */ public float FrontendWaitFadeProgressiveDialogOut;
        [NMS(Index = 581)]
        /* 0x70FC */ public float FrontendWaitFadeTextFrameOut;
        [NMS(Index = 580)]
        /* 0x7100 */ public float FrontendWaitFadeTextOut;
        [NMS(Index = 578)]
        /* 0x7104 */ public float FrontendWaitInitial;
        [NMS(Index = 579)]
        /* 0x7108 */ public float FrontendWaitInitialTerminal;
        [NMS(Index = 577)]
        /* 0x710C */ public float FrontendWaitResponse;
        [NMS(Index = 583)]
        /* 0x7110 */ public float FrontendWaitResponseOffset;
        [NMS(Index = 876)]
        /* 0x7114 */ public float GalaxyMapRadialBorder;
        [NMS(Index = 877)]
        /* 0x7118 */ public float GalaxyMapRadialTargetDist;
        [NMS(Index = 180)]
        /* 0x711C */ public float GalmapDiscoveryOffsetVR;
        [NMS(Index = 104)]
        /* 0x7120 */ public float GameModeSelectColourFadeTime;
        [NMS(Index = 1456)]
        /* 0x7124 */ public float GDKHandheldMinFontHeight;
        [NMS(Index = 85)]
        /* 0x7128 */ public float GridDecayRateSwitchValue;
        [NMS(Index = 566)]
        /* 0x712C */ public float GridFlickerAmp;
        [NMS(Index = 564)]
        /* 0x7130 */ public float GridFlickerBaseAlpha;
        [NMS(Index = 565)]
        /* 0x7134 */ public float GridFlickerFreq;
        [NMS(Index = 243)]
        /* 0x7138 */ public float HandButtonClickTime;
        [NMS(Index = 239)]
        /* 0x713C */ public float HandButtonCursorScale;
        [NMS(Index = 247)]
        /* 0x7140 */ public float HandButtonDotRadius;
        [NMS(Index = 245)]
        /* 0x7144 */ public float HandButtonFrontendCursorScale;
        [NMS(Index = 241)]
        /* 0x7148 */ public float HandButtonNearDistance;
        [NMS(Index = 236)]
        /* 0x714C */ public float HandButtonPostClickTime;
        [NMS(Index = 248)]
        /* 0x7150 */ public float HandButtonPulseRadius;
        [NMS(Index = 249)]
        /* 0x7154 */ public float HandButtonPulseThickness;
        [NMS(Index = 240)]
        /* 0x7158 */ public float HandButtonPushDistance;
        [NMS(Index = 232)]
        /* 0x715C */ public float HandButtonRadius;
        [NMS(Index = 242)]
        /* 0x7160 */ public float HandButtonRadiusClick;
        [NMS(Index = 233)]
        /* 0x7164 */ public float HandButtonRadiusTouch;
        [NMS(Index = 234)]
        /* 0x7168 */ public float HandButtonRadiusTouchNear;
        [NMS(Index = 235)]
        /* 0x716C */ public float HandButtonRadiusTouchNearActive;
        [NMS(Index = 237)]
        /* 0x7170 */ public float HandButtonReleaseThreshold;
        [NMS(Index = 238)]
        /* 0x7174 */ public float HandButtonReleaseThresholdInit;
        [NMS(Index = 246)]
        /* 0x7178 */ public float HandButtonThickness;
        [NMS(Index = 244)]
        /* 0x717C */ public float HandButtonTouchReturnTime;
        [NMS(Index = 269)]
        /* 0x7180 */ public float HandControlButtonSize;
        [NMS(Index = 276)]
        /* 0x7184 */ public float HandControlMenuAngle;
        [NMS(Index = 226)]
        /* 0x7188 */ public float HandControlMenuCursorScale;
        [NMS(Index = 282)]
        /* 0x718C */ public float HandControlMenuDepth;
        [NMS(Index = 275)]
        /* 0x7190 */ public float HandControlMenuMoveActionDistance;
        [NMS(Index = 272)]
        /* 0x7194 */ public float HandControlMenuMoveDistance;
        [NMS(Index = 273)]
        /* 0x7198 */ public float HandControlMenuMoveDistanceScroll;
        [NMS(Index = 274)]
        /* 0x719C */ public float HandControlMenuMoveDistanceVertical;
        [NMS(Index = 278)]
        /* 0x71A0 */ public float HandControlMenuSelectRadius;
        [NMS(Index = 279)]
        /* 0x71A4 */ public float HandControlMenuSelectRadius1;
        [NMS(Index = 280)]
        /* 0x71A8 */ public float HandControlMenuSelectRadius2;
        [NMS(Index = 277)]
        /* 0x71AC */ public float HandControlMenuSurfaceOffset;
        [NMS(Index = 271)]
        /* 0x71B0 */ public float HandControlPointActiveMargin;
        [NMS(Index = 270)]
        /* 0x71B4 */ public float HandControlPointMargin;
        [NMS(Index = 281)]
        /* 0x71B8 */ public float HandControlTopMenuSelectRadius;
        [NMS(Index = 129)]
        /* 0x71BC */ public float HandheldHUDZoomFactor;
        [NMS(Index = 230)]
        /* 0x71C0 */ public float HandScreenGraphicsHeight;
        [NMS(Index = 229)]
        /* 0x71C4 */ public float HandScreenGraphicsWidth;
        [NMS(Index = 286)]
        /* 0x71C8 */ public int HandScreenHeight;
        [NMS(Index = 231)]
        /* 0x71CC */ public float HandScreenNearActivateDistance;
        [NMS(Index = 284)]
        /* 0x71D0 */ public int HandScreenWeaponHeight;
        [NMS(Index = 283)]
        /* 0x71D4 */ public int HandScreenWeaponWidth;
        [NMS(Index = 285)]
        /* 0x71D8 */ public int HandScreenWidth;
        [NMS(Index = 1193)]
        /* 0x71DC */ public float HatchAlphaBase;
        [NMS(Index = 1194)]
        /* 0x71E0 */ public float HatchAlphaCursor;
        [NMS(Index = 1192)]
        /* 0x71E4 */ public float HatchAlphaMain;
        [NMS(Index = 1190)]
        /* 0x71E8 */ public int HatchCount;
        [NMS(Index = 1191)]
        /* 0x71EC */ public float HatchCursorRadius;
        [NMS(Index = 1189)]
        /* 0x71F0 */ public float HatchPulsePauseTime;
        [NMS(Index = 1187)]
        /* 0x71F4 */ public float HatchPulseSpeed;
        [NMS(Index = 1188)]
        /* 0x71F8 */ public float HatchPulseWidth;
        [NMS(Index = 666)]
        /* 0x71FC */ public float HazardArrowsLevel2Threshold;
        [NMS(Index = 667)]
        /* 0x7200 */ public float HazardArrowsLevel3Threshold;
        [NMS(Index = 1025)]
        /* 0x7204 */ public float HazardBarPulseTime;
        [NMS(Index = 1030)]
        /* 0x7208 */ public float HazardPainPulseStrength;
        [NMS(Index = 1051)]
        /* 0x720C */ public float HazardPulseRate;
        [NMS(Index = 1022)]
        /* 0x7210 */ public float HazardScreenEffectPulseRate;
        [NMS(Index = 1026)]
        /* 0x7214 */ public float HazardScreenEffectPulseTime;
        [NMS(Index = 1027)]
        /* 0x7218 */ public float HazardScreenEffectStrength;
        [NMS(Index = 1029)]
        /* 0x721C */ public float HazardWarningPulseStrength;
        [NMS(Index = 1028)]
        /* 0x7220 */ public float HazardWarningPulseTime;
        [NMS(Index = 1213)]
        /* 0x7224 */ public float HitMarkerPulseSize;
        [NMS(Index = 1214)]
        /* 0x7228 */ public float HitMarkerPulseSizeStatic;
        [NMS(Index = 1215)]
        /* 0x722C */ public float HitMarkerPulseTime;
        [NMS(Index = 297)]
        /* 0x7230 */ public float HmdFramerateScreenPitch;
        [NMS(Index = 1018)]
        /* 0x7234 */ public float HoldTimerResetTime;
        [NMS(Index = 595)]
        /* 0x7238 */ public float HoverOffscreenBorder;
        [NMS(Index = 596)]
        /* 0x723C */ public float HoverOffscreenBorderXVR;
        [NMS(Index = 597)]
        /* 0x7240 */ public float HoverOffscreenBorderYAltUI;
        [NMS(Index = 45)]
        /* 0x7244 */ public float HoverPopAnimDuration;
        [NMS(Index = 44)]
        /* 0x7248 */ public float HoverPopScaleModification;
        [NMS(Index = 816)]
        /* 0x724C */ public float HUDDisplayTime;
        [NMS(Index = 762)]
        /* 0x7250 */ public float HUDDroneCombatPulse;
        [NMS(Index = 760)]
        /* 0x7254 */ public float HUDDroneHealingPulse;
        [NMS(Index = 761)]
        /* 0x7258 */ public float HUDDroneSummoningPulse;
        [NMS(Index = 954)]
        /* 0x725C */ public float HUDElementsOffsetHMDBottom;
        [NMS(Index = 952)]
        /* 0x7260 */ public float HUDElementsOffsetHMDSide;
        [NMS(Index = 953)]
        /* 0x7264 */ public float HUDElementsOffsetHMDTop;
        [NMS(Index = 955)]
        /* 0x7268 */ public float HUDElementsOffsetX_0;
        [NMS(Index = 957)]
        /* 0x726C */ public float HUDElementsOffsetX_1;
        [NMS(Index = 959)]
        /* 0x7270 */ public float HUDElementsOffsetX_2;
        [NMS(Index = 961)]
        /* 0x7274 */ public float HUDElementsOffsetX_3;
        [NMS(Index = 963)]
        /* 0x7278 */ public float HUDElementsOffsetX_4;
        [NMS(Index = 965)]
        /* 0x727C */ public float HUDElementsOffsetX_5;
        [NMS(Index = 956)]
        /* 0x7280 */ public float HUDElementsOffsetY_0;
        [NMS(Index = 958)]
        /* 0x7284 */ public float HUDElementsOffsetY_1;
        [NMS(Index = 960)]
        /* 0x7288 */ public float HUDElementsOffsetY_2;
        [NMS(Index = 962)]
        /* 0x728C */ public float HUDElementsOffsetY_3;
        [NMS(Index = 964)]
        /* 0x7290 */ public float HUDElementsOffsetY_4;
        [NMS(Index = 966)]
        /* 0x7294 */ public float HUDElementsOffsetY_5;
        [NMS(Index = 1347)]
        /* 0x7298 */ public float HUDMarkerActiveTime;
        [NMS(Index = 1342)]
        /* 0x729C */ public float HUDMarkerAlpha;
        [NMS(Index = 1317)]
        /* 0x72A0 */ public float HUDMarkerAnimLoopTime;
        [NMS(Index = 1316)]
        /* 0x72A4 */ public float HUDMarkerAnimOffset;
        [NMS(Index = 1315)]
        /* 0x72A8 */ public float HUDMarkerAnimScale;
        [NMS(Index = 1314)]
        /* 0x72AC */ public float HUDMarkerAnimSpeed;
        [NMS(Index = 460)]
        /* 0x72B0 */ public float HUDMarkerDistanceOrTimeDistance;
        [NMS(Index = 1335)]
        /* 0x72B4 */ public float HUDMarkerFarDistance;
        [NMS(Index = 1336)]
        /* 0x72B8 */ public float HUDMarkerFarFadeRange;
        [NMS(Index = 1341)]
        /* 0x72BC */ public float HUDMarkerHorizonBlendRange;
        [NMS(Index = 1323)]
        /* 0x72C0 */ public float HUDMarkerHoverAngleTestGround;
        [NMS(Index = 304)]
        /* 0x72C4 */ public float HUDMarkerHoverAngleTestGroundHmd;
        [NMS(Index = 1327)]
        /* 0x72C8 */ public float HUDMarkerHoverAngleTestShip;
        [NMS(Index = 1328)]
        /* 0x72CC */ public float HUDMarkerHoverShowLargeAngleTest;
        [NMS(Index = 1349)]
        /* 0x72D0 */ public float HUDMarkerIconHoverMinScale;
        [NMS(Index = 569)]
        /* 0x72D4 */ public float HUDMarkerLabelArriveDistance;
        [NMS(Index = 568)]
        /* 0x72D8 */ public float HUDMarkerLabelBaseWidth;
        [NMS(Index = 570)]
        /* 0x72DC */ public float HUDMarkerLabelDisplayDistance;
        [NMS(Index = 567)]
        /* 0x72E0 */ public float HUDMarkerLabelWidthMultiplier;
        [NMS(Index = 1344)]
        /* 0x72E4 */ public float HUDMarkerModelFadeMinHeight;
        [NMS(Index = 1343)]
        /* 0x72E8 */ public float HUDMarkerModelFadeRange;
        [NMS(Index = 1333)]
        /* 0x72EC */ public float HUDMarkerNearFadeDistance;
        [NMS(Index = 1334)]
        /* 0x72F0 */ public float HUDMarkerNearFadeRange;
        [NMS(Index = 571)]
        /* 0x72F4 */ public float HUDMarkerNonActiveMissionAlpha;
        [NMS(Index = 459)]
        /* 0x72F8 */ public float HUDMarkerObjectMinScreenDistance;
        [NMS(Index = 1297)]
        /* 0x72FC */ public float HUDMarkerOffset;
        [NMS(Index = 1320)]
        /* 0x7300 */ public float HUDMarkerPrimaryIndicatorSize;
        [NMS(Index = 1337)]
        /* 0x7304 */ public float HUDMarkerScalerMin;
        [NMS(Index = 1338)]
        /* 0x7308 */ public float HUDMarkerScalerRange;
        [NMS(Index = 1340)]
        /* 0x730C */ public float HUDMarkerScalerSizeMax;
        [NMS(Index = 1339)]
        /* 0x7310 */ public float HUDMarkerScalerSizeMin;
        [NMS(Index = 1331)]
        /* 0x7314 */ public float HUDMarkerShipOffsetMaxDist;
        [NMS(Index = 1332)]
        /* 0x7318 */ public float HUDMarkerShipOffsetMinDist;
        [NMS(Index = 1345)]
        /* 0x731C */ public float HUDMarkerShowActualIconDistance;
        [NMS(Index = 1346)]
        /* 0x7320 */ public float HUDMarkerShowActualSpaceIconDistance;
        [NMS(Index = 1326)]
        /* 0x7324 */ public float HUDMarkerWideHoverAngleTest;
        [NMS(Index = 305)]
        /* 0x7328 */ public float HUDMarkerWideHoverAngleTestHmd;
        [NMS(Index = 1325)]
        /* 0x732C */ public float HUDNetworkMarkerHoverAngleTestGround;
        [NMS(Index = 1330)]
        /* 0x7330 */ public float HUDNetworkMarkerHoverAngleVRMul;
        [NMS(Index = 1329)]
        /* 0x7334 */ public float HUDNetworkMarkerHoverShowLargeAngleTest;
        [NMS(Index = 1324)]
        /* 0x7338 */ public float HUDPetCentreScreenAngle;
        [NMS(Index = 1321)]
        /* 0x733C */ public float HUDPetMarkerAngleTest;
        [NMS(Index = 1322)]
        /* 0x7340 */ public float HUDPetMarkerAngleVRMul;
        [NMS(Index = 492)]
        /* 0x7344 */ public float HUDPlayerPhonePulseScanFreq;
        [NMS(Index = 491)]
        /* 0x7348 */ public float HUDPlayerSentinelPulseScanFreq;
        [NMS(Index = 489)]
        /* 0x734C */ public float HUDPlayerSentinelPulseWidth;
        [NMS(Index = 490)]
        /* 0x7350 */ public float HUDPlayerSentinelRangeFactor;
        [NMS(Index = 864)]
        /* 0x7354 */ public float HUDPlayerTrackArrowArrowSize;
        [NMS(Index = 833)]
        /* 0x7358 */ public float HUDPlayerTrackArrowDamageGlowHullHitCriticalOpacityScale;
        [NMS(Index = 834)]
        /* 0x735C */ public float HUDPlayerTrackArrowDamageGlowHullHitOpacityScale;
        [NMS(Index = 841)]
        /* 0x7360 */ public float HUDPlayerTrackArrowDamageGlowOffset;
        [NMS(Index = 837)]
        /* 0x7364 */ public float HUDPlayerTrackArrowDamageGlowShieldHitCriticalOpacityScale;
        [NMS(Index = 838)]
        /* 0x7368 */ public float HUDPlayerTrackArrowDamageGlowShieldHitOpacityScale;
        [NMS(Index = 865)]
        /* 0x736C */ public float HUDPlayerTrackArrowDotSize;
        [NMS(Index = 845)]
        /* 0x7370 */ public float HUDPlayerTrackArrowEnergyShieldDepletedGlowOpacityScale;
        [NMS(Index = 846)]
        /* 0x7374 */ public float HUDPlayerTrackArrowEnergyShieldDepletedTime;
        [NMS(Index = 843)]
        /* 0x7378 */ public float HUDPlayerTrackArrowEnergyShieldGlowOffset;
        [NMS(Index = 829)]
        /* 0x737C */ public float HUDPlayerTrackArrowEnergyShieldLowThreshold;
        [NMS(Index = 830)]
        /* 0x7380 */ public float HUDPlayerTrackArrowEnergyShieldOffset;
        [NMS(Index = 850)]
        /* 0x7384 */ public float HUDPlayerTrackArrowEnergyShieldStartChargeGlowOpacityScale;
        [NMS(Index = 851)]
        /* 0x7388 */ public float HUDPlayerTrackArrowEnergyShieldStartChargeTime;
        [NMS(Index = 873)]
        /* 0x738C */ public float HUDPlayerTrackArrowFadeRange;
        [NMS(Index = 832)]
        /* 0x7390 */ public float HUDPlayerTrackArrowGlowBaseOpacity;
        [NMS(Index = 825)]
        /* 0x7394 */ public float HUDPlayerTrackArrowHealthOffset;
        [NMS(Index = 788)]
        /* 0x7398 */ public float HUDPlayerTrackArrowIconBorderReducerShip;
        [NMS(Index = 785)]
        /* 0x739C */ public float HUDPlayerTrackArrowIconFadeDist;
        [NMS(Index = 784)]
        /* 0x73A0 */ public float HUDPlayerTrackArrowIconFadeDistDrone;
        [NMS(Index = 783)]
        /* 0x73A4 */ public float HUDPlayerTrackArrowIconFadeDistShip;
        [NMS(Index = 786)]
        /* 0x73A8 */ public float HUDPlayerTrackArrowIconFadeRange;
        [NMS(Index = 787)]
        /* 0x73AC */ public float HUDPlayerTrackArrowIconFadeRangeShip;
        [NMS(Index = 778)]
        /* 0x73B0 */ public float HUDPlayerTrackArrowIconFadeTime;
        [NMS(Index = 782)]
        /* 0x73B4 */ public float HUDPlayerTrackArrowIconPulse2Alpha;
        [NMS(Index = 776)]
        /* 0x73B8 */ public float HUDPlayerTrackArrowIconPulseTime;
        [NMS(Index = 780)]
        /* 0x73BC */ public float HUDPlayerTrackArrowIconPulseWidth1;
        [NMS(Index = 781)]
        /* 0x73C0 */ public float HUDPlayerTrackArrowIconPulseWidth2;
        [NMS(Index = 777)]
        /* 0x73C4 */ public float HUDPlayerTrackArrowIconShowTime;
        [NMS(Index = 862)]
        /* 0x73C8 */ public float HUDPlayerTrackArrowIconSize;
        [NMS(Index = 872)]
        /* 0x73CC */ public float HUDPlayerTrackArrowMinFadeDist;
        [NMS(Index = 857)]
        /* 0x73D0 */ public float HUDPlayerTrackArrowOffset;
        [NMS(Index = 789)]
        /* 0x73D4 */ public float HUDPlayerTrackArrowPulseOffset;
        [NMS(Index = 790)]
        /* 0x73D8 */ public float HUDPlayerTrackArrowPulseRate;
        [NMS(Index = 858)]
        /* 0x73DC */ public float HUDPlayerTrackArrowScreenBorder;
        [NMS(Index = 775)]
        /* 0x73E0 */ public float HUDPlayerTrackArrowShipLabelOffset;
        [NMS(Index = 859)]
        /* 0x73E4 */ public float HUDPlayerTrackArrowSize;
        [NMS(Index = 861)]
        /* 0x73E8 */ public float HUDPlayerTrackArrowSizeMax;
        [NMS(Index = 860)]
        /* 0x73EC */ public float HUDPlayerTrackArrowSizeMin;
        [NMS(Index = 863)]
        /* 0x73F0 */ public float HUDPlayerTrackArrowSmallIconSize;
        [NMS(Index = 856)]
        /* 0x73F4 */ public float HUDPlayerTrackArrowTargetDist;
        [NMS(Index = 855)]
        /* 0x73F8 */ public float HUDPlayerTrackArrowTargetDistShip;
        [NMS(Index = 821)]
        /* 0x73FC */ public float HUDPlayerTrackArrowTextExtraHeight;
        [NMS(Index = 822)]
        /* 0x7400 */ public float HUDPlayerTrackArrowTextExtraOffsetX;
        [NMS(Index = 823)]
        /* 0x7404 */ public float HUDPlayerTrackArrowTextExtraOffsetY;
        [NMS(Index = 819)]
        /* 0x7408 */ public float HUDPlayerTrackArrowTextHeight;
        [NMS(Index = 818)]
        /* 0x740C */ public float HUDPlayerTrackArrowTextOffset;
        [NMS(Index = 817)]
        /* 0x7410 */ public float HUDPlayerTrackDangerPulse;
        [NMS(Index = 763)]
        /* 0x7414 */ public float HUDPlayerTrackNoSightPulse;
        [NMS(Index = 766)]
        /* 0x7418 */ public float HUDPlayerTrackTimerEnd;
        [NMS(Index = 767)]
        /* 0x741C */ public float HUDPlayerTrackTimerPulseRate;
        [NMS(Index = 764)]
        /* 0x7420 */ public float HUDPlayerTrackTimerStart;
        [NMS(Index = 765)]
        /* 0x7424 */ public float HUDPlayerTrackTimerStartFade;
        [NMS(Index = 1292)]
        /* 0x7428 */ public float HUDTargetHealthDangerTime;
        [NMS(Index = 1291)]
        /* 0x742C */ public float HUDTargetHealthIconSize;
        [NMS(Index = 1295)]
        /* 0x7430 */ public float HUDTargetIconOffset;
        [NMS(Index = 1296)]
        /* 0x7434 */ public float HUDTargetIconSize;
        [NMS(Index = 1293)]
        /* 0x7438 */ public float HUDTargetMarkerOffset;
        [NMS(Index = 1294)]
        /* 0x743C */ public float HUDTargetMarkerSize;
        [NMS(Index = 878)]
        /* 0x7440 */ public float IconBackgroundAlpha;
        [NMS(Index = 410)]
        /* 0x7444 */ public float IconGlowStrengthActive;
        [NMS(Index = 409)]
        /* 0x7448 */ public float IconGlowStrengthError;
        [NMS(Index = 412)]
        /* 0x744C */ public float IconGlowStrengthHighlight;
        [NMS(Index = 411)]
        /* 0x7450 */ public float IconGlowStrengthNeutral;
        [NMS(Index = 1061)]
        /* 0x7454 */ public float IconPulseRate;
        [NMS(Index = 1445)]
        /* 0x7458 */ public float InfoPortalGuideCycleTime;
        [NMS(Index = 1446)]
        /* 0x745C */ public float InfoPortalMilestonesCycleTime;
        [NMS(Index = 1082)]
        /* 0x7460 */ public float InteractionIconInnerRadius;
        [NMS(Index = 1083)]
        /* 0x7464 */ public float InteractionIconOuterRadius;
        [NMS(Index = 308)]
        /* 0x7468 */ public float InteractionInWorldMinScreenDistance;
        [NMS(Index = 309)]
        /* 0x746C */ public float InteractionInWorldMinScreenDistanceV2;
        [NMS(Index = 307)]
        /* 0x7470 */ public float InteractionInWorldPitchDistance;
        [NMS(Index = 310)]
        /* 0x7474 */ public float InteractionInWorldSeatedNPCHeightAdjust;
        [NMS(Index = 311)]
        /* 0x7478 */ public float InteractionInWorldSeatedNPCHeightAdjustV2;
        [NMS(Index = 1080)]
        /* 0x747C */ public float InteractionLabelHeight;
        [NMS(Index = 1073)]
        /* 0x7480 */ public float InteractionLabelHorizontalLineLength;
        [NMS(Index = 1081)]
        /* 0x7484 */ public float InteractionLabelLineAlpha;
        [NMS(Index = 1085)]
        /* 0x7488 */ public float InteractionLabelPixelHeightMax;
        [NMS(Index = 1084)]
        /* 0x748C */ public float InteractionLabelPixelHeightMin;
        [NMS(Index = 1079)]
        /* 0x7490 */ public float InteractionLabelRadiusScaler;
        [NMS(Index = 1087)]
        /* 0x7494 */ public float InteractionLabelSpeedClose;
        [NMS(Index = 1086)]
        /* 0x7498 */ public float InteractionLabelSpeedOpen;
        [NMS(Index = 988)]
        /* 0x749C */ public float InteractionScanDisplayTime;
        [NMS(Index = 987)]
        /* 0x74A0 */ public float InteractionScanMinTime;
        [NMS(Index = 986)]
        /* 0x74A4 */ public float InteractionScanScanTime;
        [NMS(Index = 991)]
        /* 0x74A8 */ public float InteractionScanSlapOverallTime;
        [NMS(Index = 990)]
        /* 0x74AC */ public float InteractionScanSlapScale;
        [NMS(Index = 989)]
        /* 0x74B0 */ public float InteractionScanSlapTime;
        [NMS(Index = 1017)]
        /* 0x74B4 */ public float InventoryFullMessageRepeatTime;
        [NMS(Index = 938)]
        /* 0x74B8 */ public float InventoryIconTime;
        [NMS(Index = 75)]
        /* 0x74BC */ public float InvSlotGradientFactor;
        [NMS(Index = 74)]
        /* 0x74C0 */ public float InvSlotGradientFactorMin;
        [NMS(Index = 76)]
        /* 0x74C4 */ public float InvSlotGradientTime;
        [NMS(Index = 254)]
        /* 0x74C8 */ public float InWorldInteractionScreenScale;
        [NMS(Index = 151)]
        /* 0x74CC */ public float InWorldInteractLabelFarDistance;
        [NMS(Index = 152)]
        /* 0x74D0 */ public float InWorldInteractLabelFarRange;
        [NMS(Index = 207)]
        /* 0x74D4 */ public int InWorldInteractLabelHeight;
        [NMS(Index = 148)]
        /* 0x74D8 */ public float InWorldInteractLabelMinHeadOffset;
        [NMS(Index = 149)]
        /* 0x74DC */ public float InWorldInteractLabelNearDistance;
        [NMS(Index = 150)]
        /* 0x74E0 */ public float InWorldInteractLabelNearRange;
        [NMS(Index = 140)]
        /* 0x74E4 */ public float InWorldInteractLabelScale;
        [NMS(Index = 141)]
        /* 0x74E8 */ public float InWorldInteractLabelScaleV2;
        [NMS(Index = 206)]
        /* 0x74EC */ public int InWorldInteractLabelWidth;
        [NMS(Index = 202)]
        /* 0x74F0 */ public float InWorldNGuiScreenScale;
        [NMS(Index = 255)]
        /* 0x74F4 */ public float InWorldNPCInteractionScreenScale;
        [NMS(Index = 201)]
        /* 0x74F8 */ public float InWorldScreenForwardOffset;
        [NMS(Index = 200)]
        /* 0x74FC */ public float InWorldScreenMinScreenDistance;
        [NMS(Index = 142)]
        /* 0x7500 */ public float InWorldScreenScaleDistance;
        [NMS(Index = 48)]
        /* 0x7504 */ public float InWorldUIInteractionDistanceWithEyeTrackingEnabled;
        [NMS(Index = 941)]
        /* 0x7508 */ public float ItemReceivedMessageTimeToAdd;
        [NMS(Index = 981)]
        /* 0x750C */ public float ItemSlotColourTechChargeRate;
        [NMS(Index = 1023)]
        /* 0x7510 */ public float KeepHazardBarActiveTime;
        [NMS(Index = 1024)]
        /* 0x7514 */ public float KeepSecondHazardBarActiveTime;
        [NMS(Index = 916)]
        /* 0x7518 */ public float LandNotifyHeightThreshold;
        [NMS(Index = 915)]
        /* 0x751C */ public float LandNotifySpeedThreshold;
        [NMS(Index = 917)]
        /* 0x7520 */ public float LandNotifyTimeThreshold;
        [NMS(Index = 729)]
        /* 0x7524 */ public float LargeSpaceIconSize;
        [NMS(Index = 348)]
        /* 0x7528 */ public float LoadFadeInDefaultTime;
        [NMS(Index = 135)]
        /* 0x752C */ public float LoadingScreenTime;
        [NMS(Index = 134)]
        /* 0x7530 */ public float LoadingScreenTravelSpeed;
        [NMS(Index = 133)]
        /* 0x7534 */ public float LoadingTravelDistance;
        [NMS(Index = 1361)]
        /* 0x7538 */ public float LockOnMarkerSize;
        [NMS(Index = 1362)]
        /* 0x753C */ public float LockOnMarkerSizeLock;
        [NMS(Index = 198)]
        /* 0x7540 */ public float LowerHelmetScreenPitch;
        [NMS(Index = 197)]
        /* 0x7544 */ public float LowerHelmetScreenScale;
        [NMS(Index = 510)]
        /* 0x7548 */ public float LowHealthShieldFactor;
        [NMS(Index = 509)]
        /* 0x754C */ public float LowHealthShieldMin;
        [NMS(Index = 463)]
        /* 0x7550 */ public float MaintenanceIconFadeStart;
        [NMS(Index = 464)]
        /* 0x7554 */ public float MaintenanceIconFadeTime;
        [NMS(Index = 936)]
        /* 0x7558 */ public float ManualNotificationPauseTime;
        [NMS(Index = 1444)]
        /* 0x755C */ public float ManualScrollChangePerInputMax;
        [NMS(Index = 1443)]
        /* 0x7560 */ public float ManualScrollChangePerInputMin;
        [NMS(Index = 461)]
        /* 0x7564 */ public float MarkerComponentOffset;
        [NMS(Index = 358)]
        /* 0x7568 */ public float MarkerHorizonApproachAngle;
        [NMS(Index = 357)]
        /* 0x756C */ public float MarkerHorizonMinOffset;
        [NMS(Index = 364)]
        /* 0x7570 */ public float MarkerHorizonOffPlanetLightBeamAngle;
        [NMS(Index = 356)]
        /* 0x7574 */ public float MarkerHorizonOffsetAngle;
        [NMS(Index = 365)]
        /* 0x7578 */ public float MarkerHorizonShipApproachOffset;
        [NMS(Index = 359)]
        /* 0x757C */ public float MarkerOffsetTypeAngle;
        [NMS(Index = 363)]
        /* 0x7580 */ public float MarkerOffsetTypeAngleAsteroid;
        [NMS(Index = 360)]
        /* 0x7584 */ public float MarkerOffsetTypeAngleBattle;
        [NMS(Index = 361)]
        /* 0x7588 */ public float MarkerOffsetTypeAngleBounty;
        [NMS(Index = 362)]
        /* 0x758C */ public float MarkerOffsetTypeAnglePlayerShip;
        [NMS(Index = 446)]
        /* 0x7590 */ public float MarkerRingInnerRadius;
        [NMS(Index = 447)]
        /* 0x7594 */ public float MarkerRingOuterRadius;
        [NMS(Index = 374)]
        /* 0x7598 */ public float MarkerTagAppearDelay;
        [NMS(Index = 513)]
        /* 0x759C */ public int MaxDialogCharSizeIdeographic;
        [NMS(Index = 511)]
        /* 0x75A0 */ public int MaxDialogCharSizeRoman;
        [NMS(Index = 369)]
        /* 0x75A4 */ public int MaxNumMessageBeaconIcons;
        [NMS(Index = 183)]
        /* 0x75A8 */ public float MaxProjectorDistanceFromDefault;
        [NMS(Index = 186)]
        /* 0x75AC */ public float MaxProjectorGrabDistance;
        [NMS(Index = 89)]
        /* 0x75B0 */ public int MaxSubstanceMaxAmountForAmountFraction;
        [NMS(Index = 939)]
        /* 0x75B4 */ public float MessageNotificationTime;
        [NMS(Index = 940)]
        /* 0x75B8 */ public float MessageTimeQuick;
        [NMS(Index = 114)]
        /* 0x75BC */ public float MilestoneStingDisplayTime;
        [NMS(Index = 1437)]
        /* 0x75C0 */ public float MinimumHoldFill;
        [NMS(Index = 112)]
        /* 0x75C4 */ public float MinSeasonPlayTimeInDays;
        [NMS(Index = 742)]
        /* 0x75C8 */ public float MissileCentreOffset;
        [NMS(Index = 1367)]
        /* 0x75CC */ public float MissileIconAttackPulseAmount;
        [NMS(Index = 1366)]
        /* 0x75D0 */ public float MissileIconAttackPulseTime;
        [NMS(Index = 723)]
        /* 0x75D4 */ public float MissionCompassIconScaler;
        [NMS(Index = 373)]
        /* 0x75D8 */ public float MissionDetailsPageBaseHeight;
        [NMS(Index = 539)]
        /* 0x75DC */ public int MissionLoopCount;
        [NMS(Index = 540)]
        /* 0x75E0 */ public int MissionLoopCountPirate;
        [NMS(Index = 724)]
        /* 0x75E4 */ public float MissionMarkerSize;
        [NMS(Index = 370)]
        /* 0x75E8 */ public float MissionObjectiveBaseHeight;
        [NMS(Index = 371)]
        /* 0x75EC */ public float MissionObjectiveDoneHeight;
        [NMS(Index = 372)]
        /* 0x75F0 */ public float MissionObjectiveScrollingExtra;
        [NMS(Index = 541)]
        /* 0x75F4 */ public int MissionSeedOffset;
        [NMS(Index = 538)]
        /* 0x75F8 */ public int MissionSpecificMissionPercent;
        [NMS(Index = 522)]
        /* 0x75FC */ public float MissionStartEndOSDTime;
        [NMS(Index = 523)]
        /* 0x7600 */ public float MissionStartEndOSDTimeProcedural;
        [NMS(Index = 521)]
        /* 0x7604 */ public float MissionStartEndTime;
        [NMS(Index = 43)]
        /* 0x7608 */ public float ModularCustomisationApplyTime;
        [NMS(Index = 1452)]
        /* 0x760C */ public float MouseRotateCameraSensitivity;
        [NMS(Index = 1422)]
        /* 0x7610 */ public float MultiplayerTeleportEffectAppearTime;
        [NMS(Index = 1421)]
        /* 0x7614 */ public float MultiplayerTeleportEffectDisappearTime;
        [NMS(Index = 1387)]
        /* 0x7618 */ public float NGuiActiveAreaOffsetTime;
        [NMS(Index = 1378)]
        /* 0x761C */ public float NGuiAltPlacementDistanceScrollSpeed;
        [NMS(Index = 1386)]
        /* 0x7620 */ public float NGuiCursorOffsetMultiplier;
        [NMS(Index = 296)]
        /* 0x7624 */ public float NGuiHmdOffset;
        [NMS(Index = 1368)]
        /* 0x7628 */ public float NGuiModelRotationDegreesX;
        [NMS(Index = 1369)]
        /* 0x762C */ public float NGuiModelRotationDegreesY;
        [NMS(Index = 1370)]
        /* 0x7630 */ public float NGuiModelRotationDegreesZ;
        [NMS(Index = 1377)]
        /* 0x7634 */ public float NGuiModelViewCdSmoothTime;
        [NMS(Index = 1375)]
        /* 0x7638 */ public float NGuiModelViewDistanceDiscoveryPage;
        [NMS(Index = 1371)]
        /* 0x763C */ public float NGuiModelViewDistanceGlobal;
        [NMS(Index = 1374)]
        /* 0x7640 */ public float NGuiModelViewDistanceShipPage;
        [NMS(Index = 1372)]
        /* 0x7644 */ public float NGuiModelViewDistanceSuitPage;
        [NMS(Index = 1373)]
        /* 0x7648 */ public float NGuiModelViewDistanceWeaponPage;
        [NMS(Index = 1395)]
        /* 0x764C */ public float NGuiModelViewFadeInAfterRenderTime;
        [NMS(Index = 1376)]
        /* 0x7650 */ public float NGuiModelViewFov;
        [NMS(Index = 1380)]
        /* 0x7654 */ public float NGuiModelViewFractionOfBBHeightAboveReflectivePlane;
        [NMS(Index = 1205)]
        /* 0x7658 */ public float NGuiMouseSensitivity;
        [NMS(Index = 1204)]
        /* 0x765C */ public float NGuiPadSensitivity;
        [NMS(Index = 1379)]
        /* 0x7660 */ public float NGuiPlacementAngleScrollSpeed;
        [NMS(Index = 1384)]
        /* 0x7664 */ public float NGuiThumbnailModelRotationDegreesY;
        [NMS(Index = 1385)]
        /* 0x7668 */ public float NGuiThumbnailModelViewDistance;
        [NMS(Index = 891)]
        /* 0x766C */ public float NotificationBackgroundGradientAlphaInShip;
        [NMS(Index = 890)]
        /* 0x7670 */ public float NotificationBackgroundGradientEndOffsetPercentInShip;
        [NMS(Index = 924)]
        /* 0x7674 */ public float NotificationBridgeReachDistance;
        [NMS(Index = 898)]
        /* 0x7678 */ public float NotificationBuildHintStartTime;
        [NMS(Index = 903)]
        /* 0x767C */ public float NotificationCantFireTime;
        [NMS(Index = 904)]
        /* 0x7680 */ public float NotificationDangerTime;
        [NMS(Index = 929)]
        /* 0x7684 */ public float NotificationDeviceIdleTime;
        [NMS(Index = 925)]
        /* 0x7688 */ public float NotificationDiscoveryIdleTime;
        [NMS(Index = 922)]
        /* 0x768C */ public float NotificationFinalMissionWait;
        [NMS(Index = 920)]
        /* 0x7690 */ public float NotificationGoToSpaceStationWait;
        [NMS(Index = 347)]
        /* 0x7694 */ public float NotificationHazardMinTimeAfterRecharge;
        [NMS(Index = 895)]
        /* 0x7698 */ public float NotificationHazardSafeThreshold;
        [NMS(Index = 896)]
        /* 0x769C */ public float NotificationHazardTimer;
        [NMS(Index = 926)]
        /* 0x76A0 */ public float NotificationInfoIdleTime;
        [NMS(Index = 897)]
        /* 0x76A4 */ public float NotificationInteractHintStartTime;
        [NMS(Index = 899)]
        /* 0x76A8 */ public float NotificationJetpackTime;
        [NMS(Index = 908)]
        /* 0x76AC */ public float NotificationMaxPageHintTime;
        [NMS(Index = 907)]
        /* 0x76B0 */ public float NotificationMessageCycleTime;
        [NMS(Index = 894)]
        /* 0x76B4 */ public float NotificationMinVisibleTime;
        [NMS(Index = 930)]
        /* 0x76B8 */ public float NotificationMissionHintTime;
        [NMS(Index = 931)]
        /* 0x76BC */ public float NotificationMissionHintTimeCritical;
        [NMS(Index = 932)]
        /* 0x76C0 */ public float NotificationMissionHintTimeSecondary;
        [NMS(Index = 921)]
        /* 0x76C4 */ public float NotificationMonolithMissionWait;
        [NMS(Index = 927)]
        /* 0x76C8 */ public float NotificationNewTechIdleTime;
        [NMS(Index = 928)]
        /* 0x76CC */ public float NotificationScanEventMissionIdleTime;
        [NMS(Index = 905)]
        /* 0x76D0 */ public float NotificationScanTime;
        [NMS(Index = 906)]
        /* 0x76D4 */ public float NotificationScanTimeCutoff;
        [NMS(Index = 900)]
        /* 0x76D8 */ public float NotificationShieldTime;
        [NMS(Index = 912)]
        /* 0x76DC */ public float NotificationShipBoostMinTime;
        [NMS(Index = 913)]
        /* 0x76E0 */ public float NotificationShipBoostReminderTime;
        [NMS(Index = 914)]
        /* 0x76E4 */ public float NotificationShipBoostReminderTimeTutorial;
        [NMS(Index = 901)]
        /* 0x76E8 */ public float NotificationShipBoostTime;
        [NMS(Index = 902)]
        /* 0x76EC */ public float NotificationShipBoostTimeVR;
        [NMS(Index = 909)]
        /* 0x76F0 */ public float NotificationShipJumpMinTime;
        [NMS(Index = 910)]
        /* 0x76F4 */ public float NotificationShipJumpReminderTime;
        [NMS(Index = 911)]
        /* 0x76F8 */ public float NotificationShipJumpReminderTutorial;
        [NMS(Index = 892)]
        /* 0x76FC */ public int NotificationsResourceExtractHintCount;
        [NMS(Index = 893)]
        /* 0x7700 */ public float NotificationStaminaHintDistanceWalked;
        [NMS(Index = 918)]
        /* 0x7704 */ public float NotificationTimeBeforeHeridiumMarker;
        [NMS(Index = 919)]
        /* 0x7708 */ public float NotificationUrgentMessageTime;
        [NMS(Index = 923)]
        /* 0x770C */ public float NotificationWaypointReachDistance;
        [NMS(Index = 812)]
        /* 0x7710 */ public int NumDeathQuotes;
        [NMS(Index = 533)]
        /* 0x7714 */ public float OnFootDamageDirectionIndicatorFadeRange;
        [NMS(Index = 532)]
        /* 0x7718 */ public float OnFootDamageDirectionIndicatorRadius;
        [NMS(Index = 136)]
        /* 0x771C */ public float OSDMessagePauseOffscreenAngle;
        [NMS(Index = 336)]
        /* 0x7720 */ public int OSDMessageQueueMax;
        [NMS(Index = 335)]
        /* 0x7724 */ public int OSDMessageQueueMin;
        [NMS(Index = 334)]
        /* 0x7728 */ public float OSDMessageQueueSpeedMultiplier;
        [NMS(Index = 3)]
        /* 0x772C */ public float OutpostPortalMarkerDistance;
        [NMS(Index = 1104)]
        /* 0x7730 */ public float PadCursorAcceleration;
        [NMS(Index = 1105)]
        /* 0x7734 */ public float PadCursorMaxSpeedModifier;
        [NMS(Index = 86)]
        /* 0x7738 */ public float PadCursorUICurveStrength;
        [NMS(Index = 1451)]
        /* 0x773C */ public float PadRotateCameraSensitivity;
        [NMS(Index = 506)]
        /* 0x7740 */ public float PageTurnTime;
        [NMS(Index = 102)]
        /* 0x7744 */ public float ParagraphAutoScrollSpeed;
        [NMS(Index = 968)]
        /* 0x7748 */ public float PauseMenuHoldTime;
        [NMS(Index = 731)]
        /* 0x774C */ public float PetHoverIconSize;
        [NMS(Index = 158)]
        /* 0x7750 */ public float PetHUDMarkerExtraFollowInfoDistance;
        [NMS(Index = 159)]
        /* 0x7754 */ public float PetHUDMarkerHideDistance;
        [NMS(Index = 160)]
        /* 0x7758 */ public float PetHUDMarkerHideDistanceShort;
        [NMS(Index = 161)]
        /* 0x775C */ public float PetHUDMarkerOffset;
        [NMS(Index = 732)]
        /* 0x7760 */ public float PetIconSize;
        [NMS(Index = 162)]
        /* 0x7764 */ public float PetMoodMarkerOffset;
        [NMS(Index = 157)]
        /* 0x7768 */ public float PetSlotUnlockBounceTime;
        [NMS(Index = 635)]
        /* 0x776C */ public float PhotoModeTimeofDayChange;
        [NMS(Index = 634)]
        /* 0x7770 */ public float PhotoModeValueAlpha;
        [NMS(Index = 664)]
        /* 0x7774 */ public float PirateAttackIndicatorRadius;
        [NMS(Index = 663)]
        /* 0x7778 */ public float PirateAttackIndicatorWidth;
        [NMS(Index = 665)]
        /* 0x777C */ public float PirateAttackProbeDisplayFinishFactor;
        [NMS(Index = 662)]
        /* 0x7780 */ public float PirateCountdownTime;
        [NMS(Index = 647)]
        /* 0x7784 */ public float PirateFreighterSummonAtOffset;
        [NMS(Index = 645)]
        /* 0x7788 */ public float PirateFreighterSummonOffset;
        [NMS(Index = 646)]
        /* 0x778C */ public float PirateFreighterSummonOffsetPulse;
        [NMS(Index = 132)]
        /* 0x7790 */ public float PlacedMarkerFadeTime;
        [NMS(Index = 122)]
        /* 0x7794 */ public float PlanetDataExtraRadius;
        [NMS(Index = 975)]
        /* 0x7798 */ public float PlanetLabelAngle;
        [NMS(Index = 974)]
        /* 0x779C */ public float PlanetLabelTime;
        [NMS(Index = 1219)]
        /* 0x77A0 */ public float PlanetPoleEastWestDistanceFromPlayer;
        [NMS(Index = 1218)]
        /* 0x77A4 */ public float PlanetPoleMaxDotProduct;
        [NMS(Index = 504)]
        /* 0x77A8 */ public float PlanetRaidMarkerOffset;
        [NMS(Index = 677)]
        /* 0x77AC */ public float PlanetScanDelayTime;
        [NMS(Index = 1129)]
        /* 0x77B0 */ public float PopupActivateTime;
        [NMS(Index = 1130)]
        /* 0x77B4 */ public float PopupDeactivateTime;
        [NMS(Index = 1128)]
        /* 0x77B8 */ public float PopupDebounceTime;
        [NMS(Index = 1117)]
        /* 0x77BC */ public float PopupSlotWidthOffset;
        [NMS(Index = 77)]
        /* 0x77C0 */ public float PopupTitleGradientFactor;
        [NMS(Index = 337)]
        /* 0x77C4 */ public float PopupValueSectionBaseHeight;
        [NMS(Index = 338)]
        /* 0x77C8 */ public float PopupValueSectionHeight;
        [NMS(Index = 1115)]
        /* 0x77CC */ public float PopupXClampOffset;
        [NMS(Index = 1116)]
        /* 0x77D0 */ public float PopupXClampOffsetRightAligned;
        [NMS(Index = 188)]
        /* 0x77D4 */ public float ProjectorGrabBorderPercent;
        [NMS(Index = 187)]
        /* 0x77D8 */ public float ProjectorGrabDistanceBias;
        [NMS(Index = 184)]
        /* 0x77DC */ public float ProjectorGrabResetTime;
        [NMS(Index = 182)]
        /* 0x77E0 */ public float ProjectorScale;
        [NMS(Index = 228)]
        /* 0x77E4 */ public float QuickMenuAlpha;
        [NMS(Index = 137)]
        /* 0x77E8 */ public float QuickMenuCentrePos;
        [NMS(Index = 139)]
        /* 0x77EC */ public float QuickMenuCentreSideOffset;
        [NMS(Index = 575)]
        /* 0x77F0 */ public float QuickMenuCloseTime;
        [NMS(Index = 227)]
        /* 0x77F4 */ public float QuickMenuCursorScale;
        [NMS(Index = 576)]
        /* 0x77F8 */ public float QuickMenuErrorTime;
        [NMS(Index = 267)]
        /* 0x77FC */ public float QuickMenuHighlightRate;
        [NMS(Index = 268)]
        /* 0x7800 */ public float QuickMenuHoldNavTime;
        [NMS(Index = 263)]
        /* 0x7804 */ public float QuickMenuInteractAdjustX;
        [NMS(Index = 264)]
        /* 0x7808 */ public float QuickMenuInteractAdjustY;
        [NMS(Index = 266)]
        /* 0x780C */ public int QuickMenuScreenHeight;
        [NMS(Index = 265)]
        /* 0x7810 */ public int QuickMenuScreenWidth;
        [NMS(Index = 138)]
        /* 0x7814 */ public float QuickMenuSideOffset;
        [NMS(Index = 259)]
        /* 0x7818 */ public float QuickMenuSwipeHeightMax;
        [NMS(Index = 258)]
        /* 0x781C */ public float QuickMenuSwipeHeightMin;
        [NMS(Index = 1184)]
        /* 0x7820 */ public float RadialMenuInnerRadius;
        [NMS(Index = 1185)]
        /* 0x7824 */ public float RadialMenuInnerRadiusCursor;
        [NMS(Index = 1186)]
        /* 0x7828 */ public float RadialMenuWedgeOffset;
        [NMS(Index = 493)]
        /* 0x782C */ public float RefinerAutoCloseTime;
        [NMS(Index = 481)]
        /* 0x7830 */ public float RefinerBeginDialInnerRadius;
        [NMS(Index = 480)]
        /* 0x7834 */ public float RefinerPadStartDecayTime;
        [NMS(Index = 479)]
        /* 0x7838 */ public float RefinerPadStartTime;
        [NMS(Index = 482)]
        /* 0x783C */ public float RefinerProgressDialInnerRadius;
        [NMS(Index = 462)]
        /* 0x7840 */ public float RepairTechLabelOffset;
        [NMS(Index = 451)]
        /* 0x7844 */ public float RepairTechRepairedMessageTime;
        [NMS(Index = 449)]
        /* 0x7848 */ public float RepairTechRepairedWaitTime1;
        [NMS(Index = 450)]
        /* 0x784C */ public float RepairTechRepairedWaitTime2;
        [NMS(Index = 1412)]
        /* 0x7850 */ public float ReportBaseFlashDelay;
        [NMS(Index = 1411)]
        /* 0x7854 */ public float ReportBaseFlashIntensity;
        [NMS(Index = 1410)]
        /* 0x7858 */ public float ReportBaseFlashTime;
        [NMS(Index = 1413)]
        /* 0x785C */ public float ReportCameraSpeed;
        [NMS(Index = 131)]
        /* 0x7860 */ public float ROGAllyFrontendZoomFactor;
        [NMS(Index = 800)]
        /* 0x7864 */ public float ScanEventArrowOffsetMultiplier;
        [NMS(Index = 802)]
        /* 0x7868 */ public float ScanEventArrowOffsetMultiplierFresh;
        [NMS(Index = 803)]
        /* 0x786C */ public float ScanEventArrowOffsetMultiplierLerpTime;
        [NMS(Index = 801)]
        /* 0x7870 */ public float ScanEventArrowOffsetMultiplierOneEvent;
        [NMS(Index = 799)]
        /* 0x7874 */ public float ScanEventArrowPlayerFadeDistance;
        [NMS(Index = 798)]
        /* 0x7878 */ public float ScanEventArrowPlayerFadeRange;
        [NMS(Index = 804)]
        /* 0x787C */ public float ScanEventArrowSecondaryAlpha;
        [NMS(Index = 797)]
        /* 0x7880 */ public float ScanEventArrowShipFadeDistance;
        [NMS(Index = 796)]
        /* 0x7884 */ public float ScanEventArrowShipFadeRange;
        [NMS(Index = 805)]
        /* 0x7888 */ public GcAudioWwiseEvents ScanEventIconAudio;
        [NMS(Index = 367)]
        /* 0x788C */ public float ScannableIconMergeAngle;
        [NMS(Index = 1088)]
        /* 0x7890 */ public float ScanTime;
        [NMS(Index = 111)]
        /* 0x7894 */ public float SeasonalRingChangeTime;
        [NMS(Index = 109)]
        /* 0x7898 */ public float SeasonalRingMultiplier;
        [NMS(Index = 110)]
        /* 0x789C */ public float SeasonalRingPulseTime;
        [NMS(Index = 41)]
        /* 0x78A0 */ public float SeasonEndAutoHighlightDuration;
        [NMS(Index = 42)]
        /* 0x78A4 */ public float SeasonEndAutoHighlightDurationMilestone;
        [NMS(Index = 40)]
        /* 0x78A8 */ public GcAudioWwiseEvents SeasonEndAutoHighlightSFX;
        [NMS(Index = 39)]
        /* 0x78AC */ public float SeasonEndRewardsMaxScrollRate;
        [NMS(Index = 38)]
        /* 0x78B0 */ public float SeasonEndRewardsPageOpenDelayTime;
        [NMS(Index = 107)]
        /* 0x78B4 */ public int SeasonFinalStageIndex;
        [NMS(Index = 888)]
        /* 0x78B8 */ public float SeasonMessageDelayTime;
        [NMS(Index = 100)]
        /* 0x78BC */ public float SentinelsDisabledHUDMessageTime;
        [NMS(Index = 1427)]
        /* 0x78C0 */ public float SettlementStatFlashSpeed;
        [NMS(Index = 1428)]
        /* 0x78C4 */ public float SettlementStatInnerRadius;
        [NMS(Index = 1429)]
        /* 0x78C8 */ public float SettlementStatOuterRadius;
        [NMS(Index = 1033)]
        /* 0x78CC */ public float ShieldHazardPulseRate;
        [NMS(Index = 1035)]
        /* 0x78D0 */ public float ShieldHazardPulseThreshold;
        [NMS(Index = 1032)]
        /* 0x78D4 */ public float ShieldPulseTime;
        [NMS(Index = 1031)]
        /* 0x78D8 */ public float ShieldSpringTime;
        [NMS(Index = 7)]
        /* 0x78DC */ public float ShipBuilderBarTime;
        [NMS(Index = 14)]
        /* 0x78E0 */ public float ShipBuilderEndCircleRadius;
        [NMS(Index = 18)]
        /* 0x78E4 */ public float ShipBuilderLineLengthFadeMax;
        [NMS(Index = 17)]
        /* 0x78E8 */ public float ShipBuilderLineLengthFadeMin;
        [NMS(Index = 16)]
        /* 0x78EC */ public float ShipBuilderLineMinFade;
        [NMS(Index = 15)]
        /* 0x78F0 */ public float ShipBuilderLineWidth;
        [NMS(Index = 12)]
        /* 0x78F4 */ public float ShipBuilderSlotDropLength;
        [NMS(Index = 8)]
        /* 0x78F8 */ public float ShipBuilderSlotLineDefaultWidthFactor;
        [NMS(Index = 10)]
        /* 0x78FC */ public float ShipBuilderSlotLineMaxFactor;
        [NMS(Index = 9)]
        /* 0x7900 */ public float ShipBuilderSlotLineMinFactor;
        [NMS(Index = 11)]
        /* 0x7904 */ public float ShipBuilderSlotStartOffset;
        [NMS(Index = 13)]
        /* 0x7908 */ public float ShipBuilderStartCircleRadius;
        [NMS(Index = 531)]
        /* 0x790C */ public float ShipDamageDirectionIndicatorFadeRange;
        [NMS(Index = 530)]
        /* 0x7910 */ public float ShipDamageDirectionIndicatorRadius;
        [NMS(Index = 794)]
        /* 0x7914 */ public float ShipDesatDamper;
        [NMS(Index = 793)]
        /* 0x7918 */ public float ShipFullscreenDamper;
        [NMS(Index = 792)]
        /* 0x791C */ public float ShipFullscreenDamperMin;
        [NMS(Index = 684)]
        /* 0x7920 */ public float ShipHeadsUpDisplayDistance;
        [NMS(Index = 685)]
        /* 0x7924 */ public float ShipHeadsUpLineFadeTime;
        [NMS(Index = 312)]
        /* 0x7928 */ public float ShipHologramInWorldUIHeightAdjust;
        [NMS(Index = 313)]
        /* 0x792C */ public float ShipHologramInWorldUIHeightAdjustV2;
        [NMS(Index = 1013)]
        /* 0x7930 */ public float ShipHUDHitPointSize;
        [NMS(Index = 1012)]
        /* 0x7934 */ public float ShipHUDHitPointTime;
        [NMS(Index = 153)]
        /* 0x7938 */ public float ShipHUDMarkerHideDistance;
        [NMS(Index = 154)]
        /* 0x793C */ public float ShipHUDMarkerOffset;
        [NMS(Index = 997)]
        /* 0x7940 */ public float ShipHUDMaxOffscreenTargetDist;
        [NMS(Index = 994)]
        /* 0x7944 */ public float ShipHUDMissileLockSizeMax;
        [NMS(Index = 993)]
        /* 0x7948 */ public float ShipHUDMissileLockSizeMin;
        [NMS(Index = 996)]
        /* 0x794C */ public float ShipHUDMissileLockSpringFast;
        [NMS(Index = 995)]
        /* 0x7950 */ public float ShipHUDMissileLockSpringSlow;
        [NMS(Index = 1000)]
        /* 0x7954 */ public float ShipHUDTargetAlpha;
        [NMS(Index = 1001)]
        /* 0x7958 */ public float ShipHUDTargetArrowLength;
        [NMS(Index = 1005)]
        /* 0x795C */ public float ShipHUDTargetArrowsRotationRate;
        [NMS(Index = 1002)]
        /* 0x7960 */ public float ShipHUDTargetMinDist;
        [NMS(Index = 998)]
        /* 0x7964 */ public float ShipHUDTargetRadius;
        [NMS(Index = 1003)]
        /* 0x7968 */ public float ShipHUDTargetRange;
        [NMS(Index = 1004)]
        /* 0x796C */ public float ShipHUDTargetScale;
        [NMS(Index = 999)]
        /* 0x7970 */ public float ShipHUDTargetTriangleRadius;
        [NMS(Index = 516)]
        /* 0x7974 */ public float ShipOverheatSwitchMessageTime;
        [NMS(Index = 515)]
        /* 0x7978 */ public float ShipOverheatSwitchMessageWait;
        [NMS(Index = 1420)]
        /* 0x797C */ public float ShipScreenTexScale;
        [NMS(Index = 250)]
        /* 0x7980 */ public float ShipSideScreenHeight;
        [NMS(Index = 2)]
        /* 0x7984 */ public float ShipTeleportPadMarkerDistance;
        [NMS(Index = 1)]
        /* 0x7988 */ public float ShipTeleportPadMinDistance;
        [NMS(Index = 314)]
        /* 0x798C */ public float ShopInteractionInWorldForcedOffset;
        [NMS(Index = 315)]
        /* 0x7990 */ public float ShopInteractionInWorldForcedOffsetV2;
        [NMS(Index = 118)]
        /* 0x7994 */ public int ShowDaysIfLessThan;
        [NMS(Index = 117)]
        /* 0x7998 */ public int ShowHoursIfLessThan;
        [NMS(Index = 119)]
        /* 0x799C */ public int ShowWeeksIfLessThan;
        [NMS(Index = 730)]
        /* 0x79A0 */ public float SmallSpaceIconSize;
        [NMS(Index = 252)]
        /* 0x79A4 */ public float SolidPointerLengthScale;
        [NMS(Index = 253)]
        /* 0x79A8 */ public float SolidPointerMaxLength;
        [NMS(Index = 251)]
        /* 0x79AC */ public float SolidPointerScale;
        [NMS(Index = 1253)]
        /* 0x79B0 */ public float SpaceMapActionScale;
        [NMS(Index = 1249)]
        /* 0x79B4 */ public float SpaceMapAnomalyScale;
        [NMS(Index = 1239)]
        /* 0x79B8 */ public float SpaceMapAspectRatio;
        [NMS(Index = 1265)]
        /* 0x79BC */ public float SpaceMapCamAngle;
        [NMS(Index = 1266)]
        /* 0x79C0 */ public float SpaceMapCamDistance;
        [NMS(Index = 1264)]
        /* 0x79C4 */ public float SpaceMapCamHeight;
        [NMS(Index = 553)]
        /* 0x79C8 */ public float SpaceMapCockpitAngle;
        [NMS(Index = 543)]
        /* 0x79CC */ public float SpaceMapCockpitScale;
        [NMS(Index = 550)]
        /* 0x79D0 */ public float SpaceMapCockpitScaleAdjustAlien;
        [NMS(Index = 552)]
        /* 0x79D4 */ public float SpaceMapCockpitScaleAdjustCorvette;
        [NMS(Index = 544)]
        /* 0x79D8 */ public float SpaceMapCockpitScaleAdjustDropShip;
        [NMS(Index = 545)]
        /* 0x79DC */ public float SpaceMapCockpitScaleAdjustFighter;
        [NMS(Index = 551)]
        /* 0x79E0 */ public float SpaceMapCockpitScaleAdjustRobot;
        [NMS(Index = 548)]
        /* 0x79E4 */ public float SpaceMapCockpitScaleAdjustRoyal;
        [NMS(Index = 549)]
        /* 0x79E8 */ public float SpaceMapCockpitScaleAdjustSail;
        [NMS(Index = 546)]
        /* 0x79EC */ public float SpaceMapCockpitScaleAdjustScientific;
        [NMS(Index = 547)]
        /* 0x79F0 */ public float SpaceMapCockpitScaleAdjustShuttle;
        [NMS(Index = 1258)]
        /* 0x79F4 */ public float SpaceMapDistance;
        [NMS(Index = 1241)]
        /* 0x79F8 */ public float SpaceMapDistanceLogScaler;
        [NMS(Index = 1260)]
        /* 0x79FC */ public float SpaceMapDistanceMultiplier;
        [NMS(Index = 1240)]
        /* 0x7A00 */ public float SpaceMapDistanceScale;
        [NMS(Index = 1263)]
        /* 0x7A04 */ public float SpaceMapFadeAngleMax;
        [NMS(Index = 1262)]
        /* 0x7A08 */ public float SpaceMapFadeAngleMin;
        [NMS(Index = 1238)]
        /* 0x7A0C */ public float SpaceMapFoV;
        [NMS(Index = 1247)]
        /* 0x7A10 */ public float SpaceMapFreighterScale;
        [NMS(Index = 1261)]
        /* 0x7A14 */ public float SpaceMapHorizonThickness;
        [NMS(Index = 1268)]
        /* 0x7A18 */ public float SpaceMapLightPitch;
        [NMS(Index = 1269)]
        /* 0x7A1C */ public float SpaceMapLightYaw;
        [NMS(Index = 1222)]
        /* 0x7A20 */ public float SpaceMapLineBaseFade;
        [NMS(Index = 1221)]
        /* 0x7A24 */ public float SpaceMapLineBaseScale;
        [NMS(Index = 1220)]
        /* 0x7A28 */ public float SpaceMapLineWidth;
        [NMS(Index = 1257)]
        /* 0x7A2C */ public float SpaceMapMarkerScale;
        [NMS(Index = 1259)]
        /* 0x7A30 */ public float SpaceMapMaxTraderDistance;
        [NMS(Index = 1252)]
        /* 0x7A34 */ public float SpaceMapMoonScale;
        [NMS(Index = 1246)]
        /* 0x7A38 */ public float SpaceMapObjectScale;
        [NMS(Index = 1256)]
        /* 0x7A3C */ public float SpaceMapPirateFreighterScale;
        [NMS(Index = 1255)]
        /* 0x7A40 */ public float SpaceMapPirateFrigateScale;
        [NMS(Index = 1251)]
        /* 0x7A44 */ public float SpaceMapPlanetLineOffset;
        [NMS(Index = 1250)]
        /* 0x7A48 */ public float SpaceMapPlanetScale;
        [NMS(Index = 1243)]
        /* 0x7A4C */ public float SpaceMapScaleMin;
        [NMS(Index = 1245)]
        /* 0x7A50 */ public float SpaceMapScaleRangeMax;
        [NMS(Index = 1244)]
        /* 0x7A54 */ public float SpaceMapScaleRangeMin;
        [NMS(Index = 1223)]
        /* 0x7A58 */ public float SpaceMapShipCombineDistance;
        [NMS(Index = 1254)]
        /* 0x7A5C */ public float SpaceMapShipScale;
        [NMS(Index = 1267)]
        /* 0x7A60 */ public float SpaceMapShipScaleMin;
        [NMS(Index = 1248)]
        /* 0x7A64 */ public float SpaceMapStationScale;
        [NMS(Index = 728)]
        /* 0x7A68 */ public float SpaceMarkersBattleOffset;
        [NMS(Index = 727)]
        /* 0x7A6C */ public float SpaceMarkersOffset;
        [NMS(Index = 125)]
        /* 0x7A70 */ public float StackSizeChangeMaxRate;
        [NMS(Index = 124)]
        /* 0x7A74 */ public float StackSizeChangeMinRate;
        [NMS(Index = 123)]
        /* 0x7A78 */ public float StackSizeRateChangeRate;
        [NMS(Index = 115)]
        /* 0x7A7C */ public float StageStingDisplayTime;
        [NMS(Index = 524)]
        /* 0x7A80 */ public float StandingRewardOSDTime;
        [NMS(Index = 887)]
        /* 0x7A84 */ public float StatsMessageDelayTime;
        [NMS(Index = 130)]
        /* 0x7A88 */ public float SteamDeckFrontendZoomFactor;
        [NMS(Index = 1455)]
        /* 0x7A8C */ public float SteamDeckMinFontHeight;
        [NMS(Index = 28)]
        /* 0x7A90 */ public float StoreDialDecayTime;
        [NMS(Index = 27)]
        /* 0x7A94 */ public float StoreDialHoldTime;
        [NMS(Index = 29)]
        /* 0x7A98 */ public float StoreDialInnerRadius;
        [NMS(Index = 30)]
        /* 0x7A9C */ public float StoreDialOuterRadius;
        [NMS(Index = 83)]
        /* 0x7AA0 */ public float SuperchargeGradientFactor;
        [NMS(Index = 82)]
        /* 0x7AA4 */ public float SuperchargeGradientFactorMin;
        [NMS(Index = 84)]
        /* 0x7AA8 */ public float SuperchargeGradientTime;
        [NMS(Index = 795)]
        /* 0x7AAC */ public float SurveyObjectArrowOffsetMultiplier;
        [NMS(Index = 355)]
        /* 0x7AB0 */ public float TakeoffFuelMessageTime;
        [NMS(Index = 584)]
        /* 0x7AB4 */ public float TalkBoxAlienTextSpeed;
        [NMS(Index = 586)]
        /* 0x7AB8 */ public float TalkBoxAlienTextTimeMax;
        [NMS(Index = 585)]
        /* 0x7ABC */ public float TalkBoxAlienTextTimeMin;
        [NMS(Index = 559)]
        /* 0x7AC0 */ public float TargetDisplayDamageFlashTime;
        [NMS(Index = 554)]
        /* 0x7AC4 */ public float TargetDisplayScale;
        [NMS(Index = 556)]
        /* 0x7AC8 */ public float TargetDisplayShipScale;
        [NMS(Index = 555)]
        /* 0x7ACC */ public float TargetDisplayTorpedoScale;
        [NMS(Index = 1211)]
        /* 0x7AD0 */ public float TargetMarkerFadeAngleMin;
        [NMS(Index = 1212)]
        /* 0x7AD4 */ public float TargetMarkerFadeAngleRange;
        [NMS(Index = 1210)]
        /* 0x7AD8 */ public float TargetMarkerScaleEnd;
        [NMS(Index = 1209)]
        /* 0x7ADC */ public float TargetMarkerScaleStart;
        [NMS(Index = 1394)]
        /* 0x7AE0 */ public float TargetParallaxMaintenancePageMultiplier;
        [NMS(Index = 1393)]
        /* 0x7AE4 */ public float TargetParallaxMouseMultiplier;
        [NMS(Index = 1015)]
        /* 0x7AE8 */ public float TargetScreenDistance;
        [NMS(Index = 1014)]
        /* 0x7AEC */ public float TargetScreenFoV;
        [NMS(Index = 810)]
        /* 0x7AF0 */ public float TechDisplayDelayTime;
        [NMS(Index = 454)]
        /* 0x7AF4 */ public float TechPopupBuildLayerHeight;
        [NMS(Index = 452)]
        /* 0x7AF8 */ public float TechPopupInstallLayerHeight;
        [NMS(Index = 453)]
        /* 0x7AFC */ public float TechPopupRepairLayerHeight;
        [NMS(Index = 455)]
        /* 0x7B00 */ public float TechPopupRequirementHeight;
        [NMS(Index = 1417)]
        /* 0x7B04 */ public float TextChatMaxDisplayTime;
        [NMS(Index = 1418)]
        /* 0x7B08 */ public float TextChatStayBigAfterTextInput;
        [NMS(Index = 191)]
        /* 0x7B0C */ public float TextPrintoutMultiplier;
        [NMS(Index = 192)]
        /* 0x7B10 */ public float TextPrintoutMultiplierAlien;
        [NMS(Index = 23)]
        /* 0x7B14 */ public float TextTouchScrollCap;
        [NMS(Index = 773)]
        /* 0x7B18 */ public float ThirdPersonCrosshairCircle1Distance;
        [NMS(Index = 774)]
        /* 0x7B1C */ public float ThirdPersonCrosshairCircle2Distance;
        [NMS(Index = 772)]
        /* 0x7B20 */ public float ThirdPersonCrosshairDistance;
        [NMS(Index = 599)]
        /* 0x7B24 */ public float TimedEventLookTime;
        [NMS(Index = 937)]
        /* 0x7B28 */ public float TooltipTime;
        [NMS(Index = 24)]
        /* 0x7B2C */ public float TouchScrollChangePageThreshold;
        [NMS(Index = 21)]
        /* 0x7B30 */ public float TouchScrollMaxDelta;
        [NMS(Index = 22)]
        /* 0x7B34 */ public float TouchScrollSpeedMul;
        [NMS(Index = 770)]
        /* 0x7B38 */ public float TrackCriticalHitSize;
        [NMS(Index = 771)]
        /* 0x7B3C */ public float TrackCriticalPulseTime;
        [NMS(Index = 746)]
        /* 0x7B40 */ public float TrackLeadTargetInScale;
        [NMS(Index = 743)]
        /* 0x7B44 */ public float TrackMissileTargetPulseRate;
        [NMS(Index = 736)]
        /* 0x7B48 */ public float TrackPoliceFreighterCentreOffset;
        [NMS(Index = 735)]
        /* 0x7B4C */ public float TrackPrimaryCentreOffset;
        [NMS(Index = 748)]
        /* 0x7B50 */ public float TrackReticuleAngle;
        [NMS(Index = 750)]
        /* 0x7B54 */ public float TrackReticuleInactiveTime;
        [NMS(Index = 749)]
        /* 0x7B58 */ public float TrackReticuleInTime;
        [NMS(Index = 752)]
        /* 0x7B5C */ public float TrackReticuleRandomDelay;
        [NMS(Index = 751)]
        /* 0x7B60 */ public float TrackReticuleRandomTime;
        [NMS(Index = 747)]
        /* 0x7B64 */ public float TrackReticuleScale;
        [NMS(Index = 744)]
        /* 0x7B68 */ public float TrackScaleCritical;
        [NMS(Index = 745)]
        /* 0x7B6C */ public float TrackScaleHit;
        [NMS(Index = 737)]
        /* 0x7B70 */ public float TrackTimerAlpha;
        [NMS(Index = 741)]
        /* 0x7B74 */ public float TrackTimerIconExclaimRadius;
        [NMS(Index = 740)]
        /* 0x7B78 */ public float TrackTimerIconInnerRadius;
        [NMS(Index = 739)]
        /* 0x7B7C */ public float TrackTimerIconOuterRadius;
        [NMS(Index = 738)]
        /* 0x7B80 */ public float TrackTimerRadarPulseSize;
        [NMS(Index = 734)]
        /* 0x7B84 */ public float TrackTypeIconSize;
        [NMS(Index = 26)]
        /* 0x7B88 */ public float TradePageNotifyOffset;
        [NMS(Index = 366)]
        /* 0x7B8C */ public float TransferPopupCursorOffsetFactor;
        [NMS(Index = 598)]
        /* 0x7B90 */ public float TransferSendOffscreenBorder;
        [NMS(Index = 505)]
        /* 0x7B94 */ public float TransitionOffset;
        [NMS(Index = 317)]
        /* 0x7B98 */ public float TravelLineThickness;
        [NMS(Index = 316)]
        /* 0x7B9C */ public float TravelTargetRadius;
        [NMS(Index = 33)]
        /* 0x7BA0 */ public float TrialUpsellDeclineDecayTimeQuick;
        [NMS(Index = 35)]
        /* 0x7BA4 */ public float TrialUpsellDeclineDecayTimeSlow;
        [NMS(Index = 36)]
        /* 0x7BA8 */ public float TrialUpsellDeclineDialInnerRadius;
        [NMS(Index = 37)]
        /* 0x7BAC */ public float TrialUpsellDeclineDialOuterRadius;
        [NMS(Index = 32)]
        /* 0x7BB0 */ public float TrialUpsellDeclineHoldTimeQuick;
        [NMS(Index = 34)]
        /* 0x7BB4 */ public float TrialUpsellDeclineHoldTimeSlow;
        [NMS(Index = 98)]
        /* 0x7BB8 */ public int UnknownWordsToShowInCatalogue;
        [NMS(Index = 1457)]
        /* 0x7BBC */ public float UnlockableTreeDefaultGroupGap;
        [NMS(Index = 1459)]
        /* 0x7BC0 */ public float UnlockableTreeDefaultRowGap;
        [NMS(Index = 1458)]
        /* 0x7BC4 */ public float UnlockableTreeNarrowGroupGap;
        [NMS(Index = 1460)]
        /* 0x7BC8 */ public float UnlockableTreeNarrowRowGap;
        [NMS(Index = 101)]
        /* 0x7BCC */ public float UseZoomedOutBuildCamRadius;
        [NMS(Index = 212)]
        /* 0x7BD0 */ public int VRFaceLockedScreenHeight;
        [NMS(Index = 211)]
        /* 0x7BD4 */ public int VRFaceLockedScreenWidth;
        [NMS(Index = 353)]
        /* 0x7BD8 */ public float WantedDetectMessageTime;
        [NMS(Index = 354)]
        /* 0x7BDC */ public float WantedDetectMinTimeout;
        [NMS(Index = 883)]
        /* 0x7BE0 */ public float WantedLevelScanAlpha;
        [NMS(Index = 884)]
        /* 0x7BE4 */ public float WantedLevelScannedRate;
        [NMS(Index = 881)]
        /* 0x7BE8 */ public float WantedLevelTimeoutPulseRate;
        [NMS(Index = 882)]
        /* 0x7BEC */ public float WantedLevelWitnessAlpha;
        [NMS(Index = 880)]
        /* 0x7BF0 */ public float WantedLevelWitnessOffset;
        [NMS(Index = 879)]
        /* 0x7BF4 */ public float WantedLevelWitnessPulseRate;
        [NMS(Index = 1440)]
        /* 0x7BF8 */ public float WinGDKHandheldPopupScale;
        [NMS(Index = 128)]
        /* 0x7BFC */ public float ZoomFactorOverride;
        [NMS(Index = 949)]
        /* 0x7C00 */ public float ZoomHUDElementsOffsetX;
        [NMS(Index = 950)]
        /* 0x7C04 */ public float ZoomHUDElementsOffsetY;
        [NMS(Index = 951)]
        /* 0x7C08 */ public float ZoomHUDElementTime;
        [NMS(Index = 1313)]
        /* 0x7C0C */ public NMSString0x100 HUDCircleAnimIcon;
        [NMS(Index = 1311)]
        /* 0x7D0C */ public NMSString0x100 HUDDeathPointIcon;
        [NMS(Index = 1312)]
        /* 0x7E0C */ public NMSString0x100 HUDHexAnimIcon;
        [NMS(Index = 1307)]
        /* 0x7F0C */ public NMSString0x100 HUDMarkerColourIcon;
        [NMS(Index = 1305)]
        /* 0x800C */ public NMSString0x100 HUDMarkerIcon;
        [NMS(Index = 1306)]
        /* 0x810C */ public NMSString0x100 HUDMarkerPrimaryIndicatorIcon;
        [NMS(Index = 1308)]
        /* 0x820C */ public NMSString0x100 HUDPointIcon;
        [NMS(Index = 1310)]
        /* 0x830C */ public NMSString0x100 HUDSaveIcon;
        [NMS(Index = 1309)]
        /* 0x840C */ public NMSString0x100 HUDSpaceshipIcon;
        [NMS(Index = 947)]
        /* 0x850C */ public NMSString0x20 DistanceUnitKM;
        [NMS(Index = 946)]
        /* 0x852C */ public NMSString0x20 DistanceUnitM;
        [NMS(Index = 948)]
        /* 0x854C */ public NMSString0x20 DistanceUnitMpS;
        [NMS(Index = 514)]
        /* 0x856C */ public NMSString0x20 MaxDialogCharSizeIdeographicString;
        [NMS(Index = 512)]
        /* 0x858C */ public NMSString0x20 MaxDialogCharSizeRomanString;
        [NMS(Index = 208)]
        /* 0x85AC */ public NMSString0x20 VRDistanceWarningUIFile;
        [NMS(Index = 400, Size = 0x15, EnumType = typeof(GcBuildMenuOption.BuildMenuOptionEnum))]
        /* 0x85CC */ public bool[] BuildMenuUseSmallIconOnPad;
        [NMS(Index = 1453)]
        /* 0x85E1 */ public bool AllowInventorySorting;
        [NMS(Index = 194)]
        /* 0x85E2 */ public bool AllowInWorldDebugBorders;
        [NMS(Index = 185)]
        /* 0x85E3 */ public bool AllowProjectorRepositioning;
        [NMS(Index = 324)]
        /* 0x85E4 */ public bool AlwaysCloseQuickMenu;
        [NMS(Index = 676)]
        /* 0x85E5 */ public TkCurveType ArrowBounceLeftCurve;
        [NMS(Index = 672)]
        /* 0x85E6 */ public TkCurveType ArrowBounceRightCurve;
        [NMS(Index = 103)]
        /* 0x85E7 */ public bool AutoScrollParagraphs;
        [NMS(Index = 428)]
        /* 0x85E8 */ public bool BaseBuildingSmoothMenuWhileSnapped;
        [NMS(Index = 91)]
        /* 0x85E9 */ public bool BigPicking;
        [NMS(Index = 92)]
        /* 0x85EA */ public bool BigPickingUsesNumbers;
        [NMS(Index = 169)]
        /* 0x85EB */ public bool BinocularScanScreen;
        [NMS(Index = 389)]
        /* 0x85EC */ public TkCurveType CompassCurve;
        [NMS(Index = 758)]
        /* 0x85ED */ public bool CreatureInteractLabelUseBB;
        [NMS(Index = 757)]
        /* 0x85EE */ public TkCurveType CreatureReticuleAlphaCurve;
        [NMS(Index = 756)]
        /* 0x85EF */ public TkCurveType CreatureReticuleScaleCurve;
        [NMS(Index = 697)]
        /* 0x85F0 */ public TkCurveType CrosshairLeadScaleCurve;
        [NMS(Index = 715)]
        /* 0x85F1 */ public TkCurveType CrosshairTargetLockAlphaCurve;
        [NMS(Index = 714)]
        /* 0x85F2 */ public TkCurveType CrosshairTargetLockCurve;
        [NMS(Index = 627)]
        /* 0x85F3 */ public TkCurveType DamageNumberUpCurve;
        [NMS(Index = 330)]
        /* 0x85F4 */ public bool DebugInventoryIndices;
        [NMS(Index = 572)]
        /* 0x85F5 */ public bool DebugMarkerLabels;
        [NMS(Index = 327)]
        /* 0x85F6 */ public bool DebugMissionLogText;
        [NMS(Index = 329)]
        /* 0x85F7 */ public bool DebugPopupSizes;
        [NMS(Index = 328)]
        /* 0x85F8 */ public bool DebugShowMaintenanceScreenCentre;
        [NMS(Index = 1438)]
        /* 0x85F9 */ public bool EnableAccessibleUIOnSwitch;
        [NMS(Index = 458)]
        /* 0x85FA */ public bool EnableBlackouts;
        [NMS(Index = 814)]
        /* 0x85FB */ public bool EnableBuilderRobotGreekConversion;
        [NMS(Index = 256)]
        /* 0x85FC */ public bool EnableCraftingTree;
        [NMS(Index = 193)]
        /* 0x85FD */ public bool EnableHandMenuButtons;
        [NMS(Index = 225)]
        /* 0x85FE */ public bool EnableHandMenuDebug;
        [NMS(Index = 815)]
        /* 0x85FF */ public bool EnableKanaConversion;
        [NMS(Index = 96)]
        /* 0x8600 */ public bool EnablePopupUses;
        [NMS(Index = 331)]
        /* 0x8601 */ public bool FixedInventoryIconPositions;
        [NMS(Index = 1127)]
        /* 0x8602 */ public TkCurveType FrontendBootBarCurve;
        [NMS(Index = 1112)]
        /* 0x8603 */ public TkCurveType FrontendConfirmCurve;
        [NMS(Index = 1199)]
        /* 0x8604 */ public TkCurveType FrontendDoFCurve;
        [NMS(Index = 889)]
        /* 0x8605 */ public bool HideExtremePlanetNotifications;
        [NMS(Index = 1415)]
        /* 0x8606 */ public bool HideQuickMenuControls;
        [NMS(Index = 1348)]
        /* 0x8607 */ public TkCurveType HUDMarkerActiveCurve;
        [NMS(Index = 1318)]
        /* 0x8608 */ public TkCurveType HUDMarkerAnimAlphaCurve;
        [NMS(Index = 1319)]
        /* 0x8609 */ public TkCurveType HUDMarkerAnimCurve;
        [NMS(Index = 847)]
        /* 0x860A */ public TkCurveType HUDPlayerTrackArrowEnergyShieldDepletedCurve;
        [NMS(Index = 852)]
        /* 0x860B */ public TkCurveType HUDPlayerTrackArrowEnergyShieldStartChargeCurve;
        [NMS(Index = 306)]
        /* 0x860C */ public bool InteractionInWorldPlayerCamAlways;
        [NMS(Index = 992)]
        /* 0x860D */ public TkCurveType InteractionScanSlapCurve;
        [NMS(Index = 517)]
        /* 0x860E */ public bool LeadTargetEnabled;
        [NMS(Index = 1019)]
        /* 0x860F */ public bool ModelRendererBGPass;
        [NMS(Index = 1020)]
        /* 0x8610 */ public bool ModelRendererPass1;
        [NMS(Index = 1021)]
        /* 0x8611 */ public bool ModelRendererPass2;
        [NMS(Index = 1396)]
        /* 0x8612 */ public TkCurveType NGuiModelViewFadeInAfterRenderCurve;
        [NMS(Index = 1397)]
        /* 0x8613 */ public bool NGuiUseSeparateLayersForModelAndReflection;
        [NMS(Index = 213)]
        /* 0x8614 */ public bool OnlyShowEjectHandlesInVR;
        [NMS(Index = 71)]
        /* 0x8615 */ public TkCurveType PadCursorUICurve;
        [NMS(Index = 507)]
        /* 0x8616 */ public TkCurveType PageTurnCurve;
        [NMS(Index = 508)]
        /* 0x8617 */ public TkCurveType PageTurnFadeCurve;
        [NMS(Index = 1131)]
        /* 0x8618 */ public TkCurveType PopupActivateCurve1;
        [NMS(Index = 1132)]
        /* 0x8619 */ public TkCurveType PopupActivateCurve2;
        [NMS(Index = 561)]
        /* 0x861A */ public bool ProgressiveDialogStyle;
        [NMS(Index = 1416)]
        /* 0x861B */ public bool QuickMenuAllowCycle;
        [NMS(Index = 257)]
        /* 0x861C */ public bool QuickMenuEnableSwipe;
        [NMS(Index = 326)]
        /* 0x861D */ public bool RepairTechUseTechIcon;
        [NMS(Index = 87)]
        /* 0x861E */ public bool ReplaceItemBarWithNumbers;
        [NMS(Index = 1034)]
        /* 0x861F */ public bool ShieldHUDAlwaysOn;
        [NMS(Index = 574)]
        /* 0x8620 */ public bool ShowDamageNumbers;
        [NMS(Index = 56)]
        /* 0x8621 */ public bool ShowDifficultyForBases;
        [NMS(Index = 886)]
        /* 0x8622 */ public bool ShowJetpackNotificationForNonTerrain;
        [NMS(Index = 606)]
        /* 0x8623 */ public bool ShowOnscreenPredatorMarkers;
        [NMS(Index = 57)]
        /* 0x8624 */ public bool ShowPadlockForLockedSettings;
        [NMS(Index = 209)]
        /* 0x8625 */ public bool ShowVRDistanceWarning;
        [NMS(Index = 127)]
        /* 0x8626 */ public bool SkipShopIntro;
        [NMS(Index = 1242)]
        /* 0x8627 */ public TkCurveType SpaceMapDistanceCurve;
        [NMS(Index = 1228)]
        /* 0x8628 */ public bool SpaceMapShowAnomaly;
        [NMS(Index = 1229)]
        /* 0x8629 */ public bool SpaceMapShowAnomalyLines;
        [NMS(Index = 1235)]
        /* 0x862A */ public bool SpaceMapShowFrieghterLines;
        [NMS(Index = 1234)]
        /* 0x862B */ public bool SpaceMapShowFrieghters;
        [NMS(Index = 1230)]
        /* 0x862C */ public bool SpaceMapShowNexus;
        [NMS(Index = 1231)]
        /* 0x862D */ public bool SpaceMapShowNexusLines;
        [NMS(Index = 1225)]
        /* 0x862E */ public bool SpaceMapShowPlanetLines;
        [NMS(Index = 1224)]
        /* 0x862F */ public bool SpaceMapShowPlanets;
        [NMS(Index = 1237)]
        /* 0x8630 */ public bool SpaceMapShowPulseEncounterLines;
        [NMS(Index = 1236)]
        /* 0x8631 */ public bool SpaceMapShowPulseEncounters;
        [NMS(Index = 1233)]
        /* 0x8632 */ public bool SpaceMapShowShipLines;
        [NMS(Index = 1232)]
        /* 0x8633 */ public bool SpaceMapShowShips;
        [NMS(Index = 1226)]
        /* 0x8634 */ public bool SpaceMapShowStation;
        [NMS(Index = 1227)]
        /* 0x8635 */ public bool SpaceMapShowStationLines;
        [NMS(Index = 518)]
        /* 0x8636 */ public bool SpaceOnlyLeadTargetEnabled;
        [NMS(Index = 97)]
        /* 0x8637 */ public bool TechBoxesCanStack;
        [NMS(Index = 768)]
        /* 0x8638 */ public TkCurveType TrackCritCurve;
        [NMS(Index = 754)]
        /* 0x8639 */ public TkCurveType TrackReticuleInAngleCurve;
        [NMS(Index = 753)]
        /* 0x863A */ public TkCurveType TrackReticuleInCurve;
        [NMS(Index = 1101)]
        /* 0x863B */ public bool UseCursorHoverSlowFixedValue;
        [NMS(Index = 99)]
        /* 0x863C */ public bool UseIntermediateMissionGiverOptions;
        [NMS(Index = 820)]
        /* 0x863D */ public bool UseNamesOnShipHUD;
        [NMS(Index = 90)]
        /* 0x863E */ public bool UseSquareSlots;
        [NMS(Index = 325)]
        /* 0x863F */ public bool UseWorldNodesForRepair;
    }
}
