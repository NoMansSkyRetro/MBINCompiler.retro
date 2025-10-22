using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xAF2E3B7F6535D6F7, NameHash = 0xFE7187F)]
    public class GcCameraGlobals : NMSTemplate
    {
        [NMS(Index = 378)]
        /* 0x0000 */ public TkModelRendererData CameraCreatureCustomiseBack;
        [NMS(Index = 374)]
        /* 0x00B0 */ public TkModelRendererData CameraCreatureCustomiseDefault;
        [NMS(Index = 377)]
        /* 0x0160 */ public TkModelRendererData CameraCreatureCustomiseFront;
        [NMS(Index = 375)]
        /* 0x0210 */ public TkModelRendererData CameraCreatureCustomiseLeft;
        [NMS(Index = 376)]
        /* 0x02C0 */ public TkModelRendererData CameraCreatureCustomiseRight;
        [NMS(Index = 372)]
        /* 0x0370 */ public TkModelRendererData CameraNPCShipInteraction;
        [NMS(Index = 373)]
        /* 0x0420 */ public TkModelRendererData CameraNPCShopInteraction;
        [NMS(Index = 13)]
        /* 0x04D0 */ public TkModelRendererData FreighterCustomisationStandardCamera;
        [NMS(Index = 14)]
        /* 0x0580 */ public TkModelRendererData FreighterCustomisationStandardCameraAlt;
        [NMS(Index = 321, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x0630 */ public Vector3f[] FirstPersonCamOffset;
        [NMS(Index = 216)]
        /* 0x06C0 */ public GcCameraFreeSettings BaseBuildingFreeCameraSettings;
        [NMS(Index = 217)]
        /* 0x0700 */ public GcCameraFreeSettings ShipConstructionFreeCameraSettings;
        [NMS(Index = 141)]
        /* 0x0740 */ public Vector3f BuildableShipMaxSizeCameraOffset;
        [NMS(Index = 143)]
        /* 0x0750 */ public Vector3f BuildableShipMaxSizeForCamera;
        [NMS(Index = 142)]
        /* 0x0760 */ public Vector3f BuildableShipMinSizeForCamera;
        [NMS(Index = 215)]
        /* 0x0770 */ public Vector3f BuildingModeInitialOffset;
        [NMS(Index = 322)]
        /* 0x0780 */ public Vector3f FirstPersonInShipCamOffset;
        [NMS(Index = 161)]
        /* 0x0790 */ public Vector3f InteractionHailingFocusOffset;
        [NMS(Index = 151)]
        /* 0x07A0 */ public Vector3f InteractionOffset;
        [NMS(Index = 159)]
        /* 0x07B0 */ public Vector3f InteractionOffsetCronus;
        [NMS(Index = 156)]
        /* 0x07C0 */ public Vector3f InteractionOffsetDefault;
        [NMS(Index = 152)]
        /* 0x07D0 */ public Vector3f InteractionOffsetExtraVR;
        [NMS(Index = 153)]
        /* 0x07E0 */ public Vector3f InteractionOffsetExtraVRSeated;
        [NMS(Index = 157)]
        /* 0x07F0 */ public Vector3f InteractionOffsetGek;
        [NMS(Index = 162)]
        /* 0x0800 */ public Vector3f InteractionOffsetRecruitment;
        [NMS(Index = 158)]
        /* 0x0810 */ public Vector3f InteractionOffsetSpiderman;
        [NMS(Index = 160)]
        /* 0x0820 */ public Vector3f InteractionShipFocusOffset;
        [NMS(Index = 36)]
        /* 0x0830 */ public Colour MiniportalFlashColour;
        [NMS(Index = 149)]
        /* 0x0840 */ public Vector3f ModelViewOffset;
        [NMS(Index = 305)]
        /* 0x0850 */ public Vector3f OffsetCamOffset;
        [NMS(Index = 306)]
        /* 0x0860 */ public Vector3f OffsetCamRotation;
        [NMS(Index = 184)]
        /* 0x0870 */ public Vector3f OffsetForFleetInteraction;
        [NMS(Index = 185)]
        /* 0x0880 */ public Vector3f OffsetForFrigateInteraction;
        [NMS(Index = 213)]
        /* 0x0890 */ public Vector3f PhotoModeShipOffset;
        [NMS(Index = 214)]
        /* 0x08A0 */ public Vector3f PhotoModeVRFPOffset;
        [NMS(Index = 154)]
        /* 0x08B0 */ public Vector3f ShopInteractionOffsetExtraVR;
        [NMS(Index = 155)]
        /* 0x08C0 */ public Vector3f ShopInteractionOffsetExtraVRSeated;
        [NMS(Index = 42)]
        /* 0x08D0 */ public Colour VehicleExitFlashColour;
        [NMS(Index = 39)]
        /* 0x08E0 */ public Colour VRGravityChangeFlashColour;
        [NMS(Index = 138)]
        /* 0x08F0 */ public GcCameraFollowSettings AlienShipFollowCam;
        [NMS(Index = 126)]
        /* 0x09F0 */ public GcCameraFollowSettings BikeFollowCam;
        [NMS(Index = 122)]
        /* 0x0AF0 */ public GcCameraFollowSettings BuggyFollowCam;
        [NMS(Index = 144)]
        /* 0x0BF0 */ public GcCameraFollowSettings BuildingIndoorsCam;
        [NMS(Index = 145)]
        /* 0x0CF0 */ public GcCameraFollowSettings BuildingOutdoorsCam;
        [NMS(Index = 146)]
        /* 0x0DF0 */ public GcCameraFollowSettings BuildingUnderwaterCam;
        [NMS(Index = 98)]
        /* 0x0EF0 */ public GcCameraFollowSettings CharacterAbandCam;
        [NMS(Index = 97)]
        /* 0x0FF0 */ public GcCameraFollowSettings CharacterAbandCombatCam;
        [NMS(Index = 100)]
        /* 0x10F0 */ public GcCameraFollowSettings CharacterAirborneCam;
        [NMS(Index = 105)]
        /* 0x11F0 */ public GcCameraFollowSettings CharacterAirborneCombatCam;
        [NMS(Index = 91)]
        /* 0x12F0 */ public GcCameraFollowSettings CharacterCombatCam;
        [NMS(Index = 95)]
        /* 0x13F0 */ public GcCameraFollowSettings CharacterCorvetteCam;
        [NMS(Index = 104)]
        /* 0x14F0 */ public GcCameraFollowSettings CharacterFallingCam;
        [NMS(Index = 93)]
        /* 0x15F0 */ public GcCameraFollowSettings CharacterFishingCam;
        [NMS(Index = 114)]
        /* 0x16F0 */ public GcCameraFollowSettings CharacterGrabbedCam;
        [NMS(Index = 94)]
        /* 0x17F0 */ public GcCameraFollowSettings CharacterIndoorCam;
        [NMS(Index = 101)]
        /* 0x18F0 */ public GcCameraFollowSettings CharacterMeleeBoostCam;
        [NMS(Index = 92)]
        /* 0x19F0 */ public GcCameraFollowSettings CharacterMiningCam;
        [NMS(Index = 99)]
        /* 0x1AF0 */ public GcCameraFollowSettings CharacterNexusCam;
        [NMS(Index = 116)]
        /* 0x1BF0 */ public GcCameraFollowSettings CharacterRideCam;
        [NMS(Index = 119)]
        /* 0x1CF0 */ public GcCameraFollowSettings CharacterRideCamHuge;
        [NMS(Index = 118)]
        /* 0x1DF0 */ public GcCameraFollowSettings CharacterRideCamLarge;
        [NMS(Index = 117)]
        /* 0x1EF0 */ public GcCameraFollowSettings CharacterRideCamMedium;
        [NMS(Index = 102)]
        /* 0x1FF0 */ public GcCameraFollowSettings CharacterRocketBootsCam;
        [NMS(Index = 103)]
        /* 0x20F0 */ public GcCameraFollowSettings CharacterRocketBootsChargeCam;
        [NMS(Index = 90)]
        /* 0x21F0 */ public GcCameraFollowSettings CharacterRunCam;
        [NMS(Index = 115)]
        /* 0x22F0 */ public GcCameraFollowSettings CharacterSitCam;
        [NMS(Index = 106)]
        /* 0x23F0 */ public GcCameraFollowSettings CharacterSpaceCam;
        [NMS(Index = 111)]
        /* 0x24F0 */ public GcCameraFollowSettings CharacterSpacewalkCombatCam;
        [NMS(Index = 107)]
        /* 0x25F0 */ public GcCameraFollowSettings CharacterSteepSlopeCam;
        [NMS(Index = 108)]
        /* 0x26F0 */ public GcCameraFollowSettings CharacterSurfaceWaterCam;
        [NMS(Index = 89)]
        /* 0x27F0 */ public GcCameraFollowSettings CharacterUnarmedCam;
        [NMS(Index = 96)]
        /* 0x28F0 */ public GcCameraFollowSettings CharacterUndergroundCam;
        [NMS(Index = 109)]
        /* 0x29F0 */ public GcCameraFollowSettings CharacterUnderwaterCam;
        [NMS(Index = 110)]
        /* 0x2AF0 */ public GcCameraFollowSettings CharacterUnderwaterCombatCam;
        [NMS(Index = 113)]
        /* 0x2BF0 */ public GcCameraFollowSettings CharacterUnderwaterJetpackAscentCam;
        [NMS(Index = 112)]
        /* 0x2CF0 */ public GcCameraFollowSettings CharacterUnderwaterJetpackCam;
        [NMS(Index = 140)]
        /* 0x2DF0 */ public GcCameraFollowSettings CorvetteFollowCam;
        [NMS(Index = 133)]
        /* 0x2EF0 */ public GcCameraFollowSettings DropshipFollowCam;
        [NMS(Index = 123)]
        /* 0x2FF0 */ public GcCameraFollowSettings HovercraftFollowCam;
        [NMS(Index = 130)]
        /* 0x30F0 */ public GcCameraFollowSettings MechCombatCam;
        [NMS(Index = 18)]
        /* 0x31F0 */ public GcCameraFollowSettings MechFirstPersonCam;
        [NMS(Index = 129)]
        /* 0x32F0 */ public GcCameraFollowSettings MechFollowCam;
        [NMS(Index = 131)]
        /* 0x33F0 */ public GcCameraFollowSettings MechJetpackCam;
        [NMS(Index = 139)]
        /* 0x34F0 */ public GcCameraFollowSettings RobotShipFollowCam;
        [NMS(Index = 135)]
        /* 0x35F0 */ public GcCameraFollowSettings RoyalShipFollowCam;
        [NMS(Index = 136)]
        /* 0x36F0 */ public GcCameraFollowSettings SailShipFollowCam;
        [NMS(Index = 137)]
        /* 0x37F0 */ public GcCameraFollowSettings ScienceShipFollowCam;
        [NMS(Index = 134)]
        /* 0x38F0 */ public GcCameraFollowSettings ShuttleFollowCam;
        [NMS(Index = 132)]
        /* 0x39F0 */ public GcCameraFollowSettings SpaceshipFollowCam;
        [NMS(Index = 124)]
        /* 0x3AF0 */ public GcCameraFollowSettings SubmarineFollowCam;
        [NMS(Index = 125)]
        /* 0x3BF0 */ public GcCameraFollowSettings SubmarineFollowCamSurface;
        [NMS(Index = 128)]
        /* 0x3CF0 */ public GcCameraFollowSettings TruckFollowCam;
        [NMS(Index = 17)]
        /* 0x3DF0 */ public GcCameraFollowSettings VehicleCam;
        [NMS(Index = 16)]
        /* 0x3EF0 */ public GcCameraFollowSettings VehicleCamHmd;
        [NMS(Index = 127)]
        /* 0x3FF0 */ public GcCameraFollowSettings WheeledBikeFollowCam;
        [NMS(Index = 367)]
        /* 0x40F0 */ public GcCameraAnimationData AmbientCameraAnimations;
        [NMS(Index = 368)]
        /* 0x4110 */ public TkModelResource AmbientDroneAnimations;
        [NMS(Index = 9)]
        /* 0x4130 */ public List<GcCameraAerialViewDataTableEntry> AerialViewDataTable;
        [NMS(Index = 369)]
        /* 0x4140 */ public VariableSizeString CameraAmbientAnimationsData;
        [NMS(Index = 15)]
        /* 0x4150 */ public List<GcCameraFollowSettings> Cameras;
        [NMS(Index = 280)]
        /* 0x4160 */ public List<GcCameraShakeData> CameraShakeTable;
        [NMS(Index = 380)]
        /* 0x4170 */ public List<Vector3f> SavedCameraFacing;
        [NMS(Index = 379)]
        /* 0x4180 */ public List<TkBigPosData> SavedCameraPositions;
        [NMS(Index = 382)]
        /* 0x4190 */ public GcCameraWarpSettings CorvetteWarpSettings;
        [NMS(Index = 383)]
        /* 0x41E4 */ public GcCameraWarpSettings FreighterWarpSettings;
        [NMS(Index = 384)]
        /* 0x4238 */ public GcCameraWarpSettings PirateFreighterWarpSettings;
        [NMS(Index = 381)]
        /* 0x428C */ public GcCameraWarpSettings WarpSettings;
        [NMS(Index = 6)]
        /* 0x42E0 */ public GcCameraFocusBuildingControlSettings FocusBuildingModeDistanceControlSettings;
        [NMS(Index = 4)]
        /* 0x4300 */ public GcCameraFocusBuildingControlSettings FocusBuildingModePitchControlSettings;
        [NMS(Index = 7)]
        /* 0x4320 */ public GcCameraFocusBuildingControlSettings FocusBuildingModePlanarControlSettings;
        [NMS(Index = 8)]
        /* 0x4340 */ public GcCameraFocusBuildingControlSettings FocusBuildingModeVerticalControlSettings;
        [NMS(Index = 5)]
        /* 0x4360 */ public GcCameraFocusBuildingControlSettings FocusBuildingModeYawControlSettings;
        [NMS(Index = 150)]
        /* 0x4380 */ public Vector2f ModelViewFocusOffset;
        [NMS(Index = 189)]
        /* 0x4388 */ public Vector2f PitchForFrigateInteraction;
        [NMS(Index = 190)]
        /* 0x4390 */ public Vector2f RotationForFrigateInteraction;
        [NMS(Index = 225)]
        /* 0x4398 */ public float AerialViewBackTime;
        [NMS(Index = 226)]
        /* 0x439C */ public float AerialViewBlendTime;
        [NMS(Index = 222)]
        /* 0x43A0 */ public float AerialViewDownDistance;
        [NMS(Index = 223)]
        /* 0x43A4 */ public float AerialViewPause;
        [NMS(Index = 224)]
        /* 0x43A8 */ public float AerialViewStartTime;
        [NMS(Index = 60)]
        /* 0x43AC */ public float BinocularFlashStrength;
        [NMS(Index = 59)]
        /* 0x43B0 */ public float BinocularFlashTime;
        [NMS(Index = 283)]
        /* 0x43B4 */ public float BobAmount;
        [NMS(Index = 281)]
        /* 0x43B8 */ public float BobAmountAbandFreighter;
        [NMS(Index = 284)]
        /* 0x43BC */ public float BobFactor;
        [NMS(Index = 282)]
        /* 0x43C0 */ public float BobFactorAbandFreighter;
        [NMS(Index = 285)]
        /* 0x43C4 */ public float BobFocus;
        [NMS(Index = 289)]
        /* 0x43C8 */ public float BobFwdAmount;
        [NMS(Index = 287)]
        /* 0x43CC */ public float BobRollAmount;
        [NMS(Index = 286)]
        /* 0x43D0 */ public float BobRollFactor;
        [NMS(Index = 288)]
        /* 0x43D4 */ public float BobRollOffset;
        [NMS(Index = 218)]
        /* 0x43D8 */ public float BuildingModeMaxDistance;
        [NMS(Index = 371)]
        /* 0x43DC */ public float CameraAmbientAutoSwitchMaxTime;
        [NMS(Index = 370)]
        /* 0x43E0 */ public float CameraAmbientAutoSwitchMinTime;
        [NMS(Index = 290)]
        /* 0x43E4 */ public float CamSeed1;
        [NMS(Index = 291)]
        /* 0x43E8 */ public float CamSeed2;
        [NMS(Index = 294)]
        /* 0x43EC */ public float CamWander1Amplitude;
        [NMS(Index = 292)]
        /* 0x43F0 */ public float CamWander1Phase;
        [NMS(Index = 295)]
        /* 0x43F4 */ public float CamWander2Amplitude;
        [NMS(Index = 293)]
        /* 0x43F8 */ public float CamWander2Phase;
        [NMS(Index = 313)]
        /* 0x43FC */ public float CharCamAutoDirStartTime;
        [NMS(Index = 316)]
        /* 0x4400 */ public float CharCamDeflectSpeed;
        [NMS(Index = 308)]
        /* 0x4404 */ public float CharCamFocusHeight;
        [NMS(Index = 311)]
        /* 0x4408 */ public float CharCamHeight;
        [NMS(Index = 314)]
        /* 0x440C */ public float CharCamLookOffset;
        [NMS(Index = 315)]
        /* 0x4410 */ public float CharCamLookOffsetFactor;
        [NMS(Index = 309)]
        /* 0x4414 */ public float CharCamMaxDistance;
        [NMS(Index = 310)]
        /* 0x4418 */ public float CharCamMinDistance;
        [NMS(Index = 317)]
        /* 0x441C */ public float CharCamMinSpeed;
        [NMS(Index = 312)]
        /* 0x4420 */ public float CharCamOffsetTime;
        [NMS(Index = 318)]
        /* 0x4424 */ public float CharCamRightStickX;
        [NMS(Index = 319)]
        /* 0x4428 */ public float CharCamRightStickY;
        [NMS(Index = 323)]
        /* 0x442C */ public float CloseFactorSpring;
        [NMS(Index = 364)]
        /* 0x4430 */ public float CreatureInteractionCamSpring;
        [NMS(Index = 351)]
        /* 0x4434 */ public float CreatureInteractionDistMulMax;
        [NMS(Index = 350)]
        /* 0x4438 */ public float CreatureInteractionDistMulMin;
        [NMS(Index = 358)]
        /* 0x443C */ public float CreatureInteractionDownhillPitchTransfer;
        [NMS(Index = 363)]
        /* 0x4440 */ public float CreatureInteractionFoVMax;
        [NMS(Index = 362)]
        /* 0x4444 */ public float CreatureInteractionFoVMin;
        [NMS(Index = 361)]
        /* 0x4448 */ public float CreatureInteractionFoVSplitSize;
        [NMS(Index = 365)]
        /* 0x444C */ public float CreatureInteractionHeadHeightSpring;
        [NMS(Index = 357)]
        /* 0x4450 */ public float CreatureInteractionMaxDownhillPitchAroundPlayer;
        [NMS(Index = 359)]
        /* 0x4454 */ public float CreatureInteractionMaxUphillPitchAroundPlayer;
        [NMS(Index = 347)]
        /* 0x4458 */ public float CreatureInteractionMinDist;
        [NMS(Index = 356)]
        /* 0x445C */ public float CreatureInteractionPitchMax;
        [NMS(Index = 355)]
        /* 0x4460 */ public float CreatureInteractionPitchMin;
        [NMS(Index = 354)]
        /* 0x4464 */ public float CreatureInteractionPitchSplit;
        [NMS(Index = 349)]
        /* 0x4468 */ public float CreatureInteractionPushCameraDownAmount;
        [NMS(Index = 348)]
        /* 0x446C */ public float CreatureInteractionPushCameraDownForCreatureBiggerThan;
        [NMS(Index = 360)]
        /* 0x4470 */ public float CreatureInteractionUphillPitchTransfer;
        [NMS(Index = 353)]
        /* 0x4474 */ public float CreatureInteractionYawMax;
        [NMS(Index = 352)]
        /* 0x4478 */ public float CreatureInteractionYawMin;
        [NMS(Index = 346)]
        /* 0x447C */ public float CreatureSizeMax;
        [NMS(Index = 345)]
        /* 0x4480 */ public float CreatureSizeMin;
        [NMS(Index = 272)]
        /* 0x4484 */ public float DebugAICamAt;
        [NMS(Index = 271)]
        /* 0x4488 */ public float DebugAICamUp;
        [NMS(Index = 298)]
        /* 0x448C */ public float DebugCameraFastFactor;
        [NMS(Index = 300)]
        /* 0x4490 */ public float DebugCameraHeightForAccelerateBegin;
        [NMS(Index = 302)]
        /* 0x4494 */ public float DebugCameraHeightForAccelerateEnd;
        [NMS(Index = 303)]
        /* 0x4498 */ public float DebugCameraMaxSpeed;
        [NMS(Index = 297)]
        /* 0x449C */ public float DebugCameraSlowFactor;
        [NMS(Index = 299)]
        /* 0x44A0 */ public float DebugCameraSpaceFastFactor;
        [NMS(Index = 301)]
        /* 0x44A4 */ public float DebugCameraSpeedAtPlanetThreshold;
        [NMS(Index = 269)]
        /* 0x44A8 */ public float DebugMoveCamHeight;
        [NMS(Index = 268)]
        /* 0x44AC */ public float DebugMoveCamSpeed;
        [NMS(Index = 28)]
        /* 0x44B0 */ public float DebugPlanetJumpFarHeight;
        [NMS(Index = 27)]
        /* 0x44B4 */ public float DebugPlanetJumpNearHeight;
        [NMS(Index = 296)]
        /* 0x44B8 */ public float DebugSpaceStationTeleportOffset;
        [NMS(Index = 181)]
        /* 0x44BC */ public float DistanceForFleetInteraction;
        [NMS(Index = 182)]
        /* 0x44C0 */ public float DistanceForFrigateInteraction;
        [NMS(Index = 183)]
        /* 0x44C4 */ public float DistanceForFrigatePurchaseInteraction;
        [NMS(Index = 320)]
        /* 0x44C8 */ public float FirstPersonCamHeight;
        [NMS(Index = 324)]
        /* 0x44CC */ public float FirstPersonFoV;
        [NMS(Index = 278)]
        /* 0x44D0 */ public float FirstPersonSlerpAway;
        [NMS(Index = 279)]
        /* 0x44D4 */ public float FirstPersonSlerpTowards;
        [NMS(Index = 328)]
        /* 0x44D8 */ public float FirstPersonZoom1FoV;
        [NMS(Index = 329)]
        /* 0x44DC */ public float FirstPersonZoom2FoV;
        [NMS(Index = 186)]
        /* 0x44E0 */ public float FleetUIOrbitRate;
        [NMS(Index = 188)]
        /* 0x44E4 */ public float FleetUIVerticalMotionAmplitude;
        [NMS(Index = 187)]
        /* 0x44E8 */ public float FleetUIVerticalMotionDuration;
        [NMS(Index = 58)]
        /* 0x44EC */ public float FlybyInVehicleDamper;
        [NMS(Index = 54)]
        /* 0x44F0 */ public float FlybyMinRange;
        [NMS(Index = 56)]
        /* 0x44F4 */ public float FlybyMinRelativeSpeed;
        [NMS(Index = 55)]
        /* 0x44F8 */ public float FlybyRange;
        [NMS(Index = 57)]
        /* 0x44FC */ public float FlybyRelativeSpeedRange;
        [NMS(Index = 3)]
        /* 0x4500 */ public float FocusBuildingModeMaxFOV;
        [NMS(Index = 2)]
        /* 0x4504 */ public float FocusBuildingModeMinFOV;
        [NMS(Index = 1)]
        /* 0x4508 */ public float FocusBuildingModeStartDistance;
        [NMS(Index = 343)]
        /* 0x450C */ public float FoVAdjust;
        [NMS(Index = 340)]
        /* 0x4510 */ public float FoVSpring;
        [NMS(Index = 341)]
        /* 0x4514 */ public float FoVSpringSights;
        [NMS(Index = 342)]
        /* 0x4518 */ public float FoVSpringSightsPassive;
        [NMS(Index = 175)]
        /* 0x451C */ public float FrigateCaptainLateralShiftAmount;
        [NMS(Index = 147)]
        /* 0x4520 */ public float FrontendModelCameraSpringTime;
        [NMS(Index = 23)]
        /* 0x4524 */ public float HmdEyeExtraTurnAngle;
        [NMS(Index = 25)]
        /* 0x4528 */ public float HmdEyeExtraTurnHeadAngleRange;
        [NMS(Index = 24)]
        /* 0x452C */ public float HmdEyeExtraTurnMinHeadAngle;
        [NMS(Index = 22)]
        /* 0x4530 */ public float HmdEyeLookAngle;
        [NMS(Index = 276)]
        /* 0x4534 */ public float IndoorCamShakeDamper;
        [NMS(Index = 164)]
        /* 0x4538 */ public float InteractionHeadHeightCronus;
        [NMS(Index = 163)]
        /* 0x453C */ public float InteractionHeadHeightDefault;
        [NMS(Index = 165)]
        /* 0x4540 */ public float InteractionHeadHeightGek;
        [NMS(Index = 167)]
        /* 0x4544 */ public float InteractionHeadHeightSpiderman;
        [NMS(Index = 166)]
        /* 0x4548 */ public float InteractionHeadHeightVykeen;
        [NMS(Index = 171)]
        /* 0x454C */ public float InteractionHeadPosHeightAdjust;
        [NMS(Index = 174)]
        /* 0x4550 */ public float InteractionHeadPosHeightAdjustCronus;
        [NMS(Index = 173)]
        /* 0x4554 */ public float InteractionHeadPosHeightAdjustSpiderman;
        [NMS(Index = 172)]
        /* 0x4558 */ public float InteractionHeadPosHeightAdjustVykeen;
        [NMS(Index = 191)]
        /* 0x455C */ public float InteractionModeBlendTime;
        [NMS(Index = 192)]
        /* 0x4560 */ public float InteractionModeFocusCamBlend;
        [NMS(Index = 193)]
        /* 0x4564 */ public float InteractionModeFoV;
        [NMS(Index = 170)]
        /* 0x4568 */ public float InteractionPitchAdjustDeadZone;
        [NMS(Index = 169)]
        /* 0x456C */ public float InteractionPitchAdjustStrength;
        [NMS(Index = 168)]
        /* 0x4570 */ public float InteractionPitchAdjustTime;
        [NMS(Index = 179)]
        /* 0x4574 */ public float LocalMissionBoardLateralShiftAmount;
        [NMS(Index = 63)]
        /* 0x4578 */ public float MaxCreatureRidingYaw;
        [NMS(Index = 62)]
        /* 0x457C */ public float MaxFirstPersonCameraPitch;
        [NMS(Index = 87)]
        /* 0x4580 */ public float MechCameraArmShootOffsetY;
        [NMS(Index = 88)]
        /* 0x4584 */ public float MechCameraCombatFakeSpeed;
        [NMS(Index = 86)]
        /* 0x4588 */ public float MechCameraExtraYPostLandingBlendTime;
        [NMS(Index = 85)]
        /* 0x458C */ public float MechCameraNoExtraYTimeAfterLand;
        [NMS(Index = 236)]
        /* 0x4590 */ public float MechCamSpringStrengthMax;
        [NMS(Index = 235)]
        /* 0x4594 */ public float MechCamSpringStrengthMin;
        [NMS(Index = 220)]
        /* 0x4598 */ public float MeleeBoostedFoV;
        [NMS(Index = 221)]
        /* 0x459C */ public float MeleeFoV;
        [NMS(Index = 61)]
        /* 0x45A0 */ public float MinFirstPersonCameraPitch;
        [NMS(Index = 195)]
        /* 0x45A4 */ public float MinInteractFocusAngle;
        [NMS(Index = 35)]
        /* 0x45A8 */ public float MiniportalFlashStrength;
        [NMS(Index = 34)]
        /* 0x45AC */ public float MiniportalFlashTime;
        [NMS(Index = 265)]
        /* 0x45B0 */ public float ModelViewDefaultPitch;
        [NMS(Index = 266)]
        /* 0x45B4 */ public float ModelViewDefaultYaw;
        [NMS(Index = 262)]
        /* 0x45B8 */ public float ModelViewDistSpeed;
        [NMS(Index = 148)]
        /* 0x45BC */ public float ModelViewFlashTime;
        [NMS(Index = 196)]
        /* 0x45C0 */ public float ModelViewInterpTime;
        [NMS(Index = 264)]
        /* 0x45C4 */ public float ModelViewMaxDist;
        [NMS(Index = 263)]
        /* 0x45C8 */ public float ModelViewMinDist;
        [NMS(Index = 261)]
        /* 0x45CC */ public float ModelViewMouseMoveSpeed;
        [NMS(Index = 260)]
        /* 0x45D0 */ public float ModelViewMouseRotateSnapStrength;
        [NMS(Index = 259)]
        /* 0x45D4 */ public float ModelViewMouseRotateSpeed;
        [NMS(Index = 258)]
        /* 0x45D8 */ public float ModelViewRotateSpeed;
        [NMS(Index = 257)]
        /* 0x45DC */ public float MouseSensitivity;
        [NMS(Index = 277)]
        /* 0x45E0 */ public float NoControlCamShakeDamper;
        [NMS(Index = 178)]
        /* 0x45E4 */ public float NPCTradeLateralShiftAmount;
        [NMS(Index = 180)]
        /* 0x45E8 */ public float NPCTradeLateralShiftTime;
        [NMS(Index = 307)]
        /* 0x45EC */ public float ObjectFocusTime;
        [NMS(Index = 304)]
        /* 0x45F0 */ public float OffsetCamFOV;
        [NMS(Index = 12)]
        /* 0x45F4 */ public float OffsetCombatCameraHorizontalAngle;
        [NMS(Index = 274)]
        /* 0x45F8 */ public float PainShakeTime;
        [NMS(Index = 209)]
        /* 0x45FC */ public float PhotoModeCollisionRadius;
        [NMS(Index = 211)]
        /* 0x4600 */ public float PhotoModeFlashDuration;
        [NMS(Index = 212)]
        /* 0x4604 */ public float PhotoModeFlashIntensity;
        [NMS(Index = 205)]
        /* 0x4608 */ public float PhotoModeMaxDistance;
        [NMS(Index = 208)]
        /* 0x460C */ public float PhotoModeMaxDistanceClampBuffer;
        [NMS(Index = 207)]
        /* 0x4610 */ public float PhotoModeMaxDistanceClampForce;
        [NMS(Index = 206)]
        /* 0x4614 */ public float PhotoModeMaxDistanceSpace;
        [NMS(Index = 203)]
        /* 0x4618 */ public float PhotoModeMoveSpeed;
        [NMS(Index = 210)]
        /* 0x461C */ public float PhotoModeRollSpeed;
        [NMS(Index = 204)]
        /* 0x4620 */ public float PhotoModeTurnSpeed;
        [NMS(Index = 202)]
        /* 0x4624 */ public float PhotoModeVelocitySmoothTime;
        [NMS(Index = 176)]
        /* 0x4628 */ public float PilotDetailsLateralShiftAmount;
        [NMS(Index = 177)]
        /* 0x462C */ public float RecruitmentLateralShiftAmount;
        [NMS(Index = 19)]
        /* 0x4630 */ public float RevealedNPCHeadOffset;
        [NMS(Index = 219)]
        /* 0x4634 */ public float RunningFoVAdjust;
        [NMS(Index = 0)]
        /* 0x4638 */ public float ScanCameraLookAtTime;
        [NMS(Index = 10)]
        /* 0x463C */ public float SClassLandingShakeMultiplier;
        [NMS(Index = 232)]
        /* 0x4640 */ public float ScreenshotBackDistance;
        [NMS(Index = 230)]
        /* 0x4644 */ public float ScreenshotBendDownAmount;
        [NMS(Index = 229)]
        /* 0x4648 */ public float ScreenshotHorizonFaceFactor;
        [NMS(Index = 228)]
        /* 0x464C */ public float ScreenshotHorizonHeight;
        [NMS(Index = 233)]
        /* 0x4650 */ public float ScreenshotInTime;
        [NMS(Index = 234)]
        /* 0x4654 */ public float ScreenshotOutTime;
        [NMS(Index = 231)]
        /* 0x4658 */ public float ScreenshotRightDistance;
        [NMS(Index = 194)]
        /* 0x465C */ public float ShipBuilderFoV;
        [NMS(Index = 256)]
        /* 0x4660 */ public float ShipCamAimFOV;
        [NMS(Index = 238)]
        /* 0x4664 */ public float ShipCamFastSpringStrengthMax;
        [NMS(Index = 237)]
        /* 0x4668 */ public float ShipCamFastSpringStrengthMin;
        [NMS(Index = 244)]
        /* 0x466C */ public float ShipCamLookInterp;
        [NMS(Index = 245)]
        /* 0x4670 */ public float ShipCamMinReturnTime;
        [NMS(Index = 252)]
        /* 0x4674 */ public float ShipCamMotionInterp;
        [NMS(Index = 251)]
        /* 0x4678 */ public float ShipCamMotionMaxLagPitchAngle;
        [NMS(Index = 250)]
        /* 0x467C */ public float ShipCamMotionMaxLagTurnAngle;
        [NMS(Index = 248)]
        /* 0x4680 */ public float ShipCamMotionPitch;
        [NMS(Index = 249)]
        /* 0x4684 */ public float ShipCamMotionPitchMod;
        [NMS(Index = 247)]
        /* 0x4688 */ public float ShipCamMotionTurn;
        [NMS(Index = 242)]
        /* 0x468C */ public float ShipCamPitch;
        [NMS(Index = 243)]
        /* 0x4690 */ public float ShipCamPitchMod;
        [NMS(Index = 246)]
        /* 0x4694 */ public float ShipCamReturnTime;
        [NMS(Index = 254)]
        /* 0x4698 */ public float ShipCamRollAmountMax;
        [NMS(Index = 253)]
        /* 0x469C */ public float ShipCamRollAmountMin;
        [NMS(Index = 255)]
        /* 0x46A0 */ public float ShipCamRollSpeedScaler;
        [NMS(Index = 240)]
        /* 0x46A4 */ public float ShipCamSpringStrengthMax;
        [NMS(Index = 239)]
        /* 0x46A8 */ public float ShipCamSpringStrengthMin;
        [NMS(Index = 241)]
        /* 0x46AC */ public float ShipCamTurn;
        [NMS(Index = 51)]
        /* 0x46B0 */ public float ShipFirstPersonBlendOffset;
        [NMS(Index = 50)]
        /* 0x46B4 */ public float ShipFirstPersonBlendTime;
        [NMS(Index = 336)]
        /* 0x46B8 */ public float ShipFoVBoost;
        [NMS(Index = 332)]
        /* 0x46BC */ public float ShipFoVMax;
        [NMS(Index = 335)]
        /* 0x46C0 */ public float ShipFoVMax3rdPerson;
        [NMS(Index = 330)]
        /* 0x46C4 */ public float ShipFoVMin;
        [NMS(Index = 331)]
        /* 0x46C8 */ public float ShipFoVMin2;
        [NMS(Index = 334)]
        /* 0x46CC */ public float ShipFoVMin3rdPerson;
        [NMS(Index = 337)]
        /* 0x46D0 */ public float ShipFoVMiniJump;
        [NMS(Index = 338)]
        /* 0x46D4 */ public float ShipFoVSpring;
        [NMS(Index = 339)]
        /* 0x46D8 */ public float ShipMiniJumpFoVSpring;
        [NMS(Index = 275)]
        /* 0x46DC */ public float ShipShakeDamper;
        [NMS(Index = 47)]
        /* 0x46E0 */ public float ShipThirdPersonBlendOffset;
        [NMS(Index = 49)]
        /* 0x46E4 */ public float ShipThirdPersonBlendOutOffset;
        [NMS(Index = 48)]
        /* 0x46E8 */ public float ShipThirdPersonBlendOutTime;
        [NMS(Index = 45)]
        /* 0x46EC */ public float ShipThirdPersonBlendTime;
        [NMS(Index = 46)]
        /* 0x46F0 */ public float ShipThirdPersonBlendWithOffsetTime;
        [NMS(Index = 53)]
        /* 0x46F4 */ public float ShipThirdPersonEnterBlendOffset;
        [NMS(Index = 52)]
        /* 0x46F8 */ public float ShipThirdPersonEnterBlendTime;
        [NMS(Index = 333)]
        /* 0x46FC */ public float ShipWarpFoV;
        [NMS(Index = 20)]
        /* 0x4700 */ public float SpecialVehicleMouseRecentreTime;
        [NMS(Index = 21)]
        /* 0x4704 */ public float SpecialVehicleMouseRecentreWeaponTime;
        [NMS(Index = 32)]
        /* 0x4708 */ public float ThirdPersonAfterIntroCamBlendTime;
        [NMS(Index = 197)]
        /* 0x470C */ public float ThirdPersonBlendInTime;
        [NMS(Index = 198)]
        /* 0x4710 */ public float ThirdPersonBlendOutTime;
        [NMS(Index = 120)]
        /* 0x4714 */ public float ThirdPersonCameraChangeBlendTime;
        [NMS(Index = 121)]
        /* 0x4718 */ public float ThirdPersonCameraChangeMinimumBlend;
        [NMS(Index = 66)]
        /* 0x471C */ public float ThirdPersonCloseDistance;
        [NMS(Index = 67)]
        /* 0x4720 */ public float ThirdPersonCloseDistanceX;
        [NMS(Index = 65)]
        /* 0x4724 */ public float ThirdPersonClosePitch;
        [NMS(Index = 199)]
        /* 0x4728 */ public float ThirdPersonCollisionPushOffsetReducerStart;
        [NMS(Index = 327)]
        /* 0x472C */ public float ThirdPersonCombatFoV;
        [NMS(Index = 74)]
        /* 0x4730 */ public float ThirdPersonDownhillAdjustMaxAngle;
        [NMS(Index = 78)]
        /* 0x4734 */ public float ThirdPersonDownhillAdjustMaxAnglePrime;
        [NMS(Index = 73)]
        /* 0x4738 */ public float ThirdPersonDownhillAdjustMinAngle;
        [NMS(Index = 77)]
        /* 0x473C */ public float ThirdPersonDownhillAdjustMinAnglePrime;
        [NMS(Index = 72)]
        /* 0x4740 */ public float ThirdPersonDownhillAdjustSpringTimeMax;
        [NMS(Index = 71)]
        /* 0x4744 */ public float ThirdPersonDownhillAdjustSpringTimeMin;
        [NMS(Index = 325)]
        /* 0x4748 */ public float ThirdPersonFoV;
        [NMS(Index = 200)]
        /* 0x474C */ public float ThirdPersonOffsetSpringTime;
        [NMS(Index = 68)]
        /* 0x4750 */ public float ThirdPersonRotationBackAdjustAngleMax;
        [NMS(Index = 64)]
        /* 0x4754 */ public float ThirdPersonRotationBackAdjustAngleMin;
        [NMS(Index = 33)]
        /* 0x4758 */ public float ThirdPersonSkipIntroCamBlendTime;
        [NMS(Index = 82)]
        /* 0x475C */ public float ThirdPersonUphillAdjustCrossSlopeMaxAngle;
        [NMS(Index = 81)]
        /* 0x4760 */ public float ThirdPersonUphillAdjustCrossSlopeMinAngle;
        [NMS(Index = 76)]
        /* 0x4764 */ public float ThirdPersonUphillAdjustMaxAngle;
        [NMS(Index = 80)]
        /* 0x4768 */ public float ThirdPersonUphillAdjustMaxAnglePrime;
        [NMS(Index = 75)]
        /* 0x476C */ public float ThirdPersonUphillAdjustMinAngle;
        [NMS(Index = 79)]
        /* 0x4770 */ public float ThirdPersonUphillAdjustMinAnglePrime;
        [NMS(Index = 70)]
        /* 0x4774 */ public float ThirdPersonUphillAdjustSpringTimeMax;
        [NMS(Index = 69)]
        /* 0x4778 */ public float ThirdPersonUphillAdjustSpringTimeMin;
        [NMS(Index = 29)]
        /* 0x477C */ public float TogglePerspectiveBlendTime;
        [NMS(Index = 31)]
        /* 0x4780 */ public float UnderwaterCameraExtraVertOffset;
        [NMS(Index = 41)]
        /* 0x4784 */ public float VehicleExitFlashStrength;
        [NMS(Index = 40)]
        /* 0x4788 */ public float VehicleExitFlashTime;
        [NMS(Index = 326)]
        /* 0x478C */ public float VehicleFirstPersonFoV;
        [NMS(Index = 43)]
        /* 0x4790 */ public float VehicleFirstToThirdExitOffsetY;
        [NMS(Index = 44)]
        /* 0x4794 */ public float VehicleFirstToThirdExitOffsetZ;
        [NMS(Index = 84)]
        /* 0x4798 */ public float VehicleThirdPersonShootOffsetBlendOutTime;
        [NMS(Index = 83)]
        /* 0x479C */ public float VehicleThirdPersonShootOffsetReturnTime;
        [NMS(Index = 38)]
        /* 0x47A0 */ public float VRGravityChangeMaxFlashTime;
        [NMS(Index = 37)]
        /* 0x47A4 */ public float VRGravityChangeMinFlashTime;
        [NMS(Index = 273)]
        /* 0x47A8 */ public float VRShakeMultiplier;
        [NMS(Index = 227)]
        /* 0x47AC */ public TkCurveType AerialViewCurve;
        [NMS(Index = 344)]
        /* 0x47AD */ public bool CreatureInteractionInterpolateDuringHold;
        [NMS(Index = 270)]
        /* 0x47AE */ public bool DebugAICam;
        [NMS(Index = 267)]
        /* 0x47AF */ public bool DebugMoveCam;
        [NMS(Index = 366)]
        /* 0x47B0 */ public bool FollowDrawCamProbes;
        [NMS(Index = 30)]
        /* 0x47B1 */ public bool LockFollowSpring;
        [NMS(Index = 201)]
        /* 0x47B2 */ public bool MaxBob;
        [NMS(Index = 11)]
        /* 0x47B3 */ public bool OffsetCombatCameraHorizontal;
        [NMS(Index = 26)]
        /* 0x47B4 */ public bool PauseThirdPersonCamInPause;
    }
}
