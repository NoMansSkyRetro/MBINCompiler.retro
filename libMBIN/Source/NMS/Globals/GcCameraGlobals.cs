using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xCA086C3CB0C1C471, NameHash = 0xFE7187F)]
    public class GcCameraGlobals : NMSTemplate
    {
        [NMS(Index = 384)]
        /* 0x0000 */ public TkModelRendererData CameraCreatureCustomiseBack;
        [NMS(Index = 380)]
        /* 0x00B0 */ public TkModelRendererData CameraCreatureCustomiseDefault;
        [NMS(Index = 383)]
        /* 0x0160 */ public TkModelRendererData CameraCreatureCustomiseFront;
        [NMS(Index = 381)]
        /* 0x0210 */ public TkModelRendererData CameraCreatureCustomiseLeft;
        [NMS(Index = 382)]
        /* 0x02C0 */ public TkModelRendererData CameraCreatureCustomiseRight;
        [NMS(Index = 378)]
        /* 0x0370 */ public TkModelRendererData CameraNPCShipInteraction;
        [NMS(Index = 379)]
        /* 0x0420 */ public TkModelRendererData CameraNPCShopInteraction;
        [NMS(Index = 13)]
        /* 0x04D0 */ public TkModelRendererData FreighterCustomisationStandardCamera;
        [NMS(Index = 14)]
        /* 0x0580 */ public TkModelRendererData FreighterCustomisationStandardCameraAlt;
        [NMS(Index = 327, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x0630 */ public Vector3f[] FirstPersonCamOffset;
        [NMS(Index = 222)]
        /* 0x06C0 */ public GcCameraFreeSettings BaseBuildingFreeCameraSettings;
        [NMS(Index = 223)]
        /* 0x0700 */ public GcCameraFreeSettings ShipConstructionFreeCameraSettings;
        [NMS(Index = 143)]
        /* 0x0740 */ public Vector3f BuildableShipMaxSizeCameraOffset;
        [NMS(Index = 145)]
        /* 0x0750 */ public Vector3f BuildableShipMaxSizeForCamera;
        [NMS(Index = 144)]
        /* 0x0760 */ public Vector3f BuildableShipMinSizeForCamera;
        [NMS(Index = 221)]
        /* 0x0770 */ public Vector3f BuildingModeInitialOffset;
        [NMS(Index = 328)]
        /* 0x0780 */ public Vector3f FirstPersonInShipCamOffset;
        [NMS(Index = 163)]
        /* 0x0790 */ public Vector3f InteractionHailingFocusOffset;
        [NMS(Index = 153)]
        /* 0x07A0 */ public Vector3f InteractionOffset;
        [NMS(Index = 161)]
        /* 0x07B0 */ public Vector3f InteractionOffsetCronus;
        [NMS(Index = 158)]
        /* 0x07C0 */ public Vector3f InteractionOffsetDefault;
        [NMS(Index = 154)]
        /* 0x07D0 */ public Vector3f InteractionOffsetExtraVR;
        [NMS(Index = 155)]
        /* 0x07E0 */ public Vector3f InteractionOffsetExtraVRSeated;
        [NMS(Index = 159)]
        /* 0x07F0 */ public Vector3f InteractionOffsetGek;
        [NMS(Index = 164)]
        /* 0x0800 */ public Vector3f InteractionOffsetRecruitment;
        [NMS(Index = 160)]
        /* 0x0810 */ public Vector3f InteractionOffsetSpiderman;
        [NMS(Index = 162)]
        /* 0x0820 */ public Vector3f InteractionShipFocusOffset;
        [NMS(Index = 36)]
        /* 0x0830 */ public Colour MiniportalFlashColour;
        [NMS(Index = 151)]
        /* 0x0840 */ public Vector3f ModelViewOffset;
        [NMS(Index = 311)]
        /* 0x0850 */ public Vector3f OffsetCamOffset;
        [NMS(Index = 312)]
        /* 0x0860 */ public Vector3f OffsetCamRotation;
        [NMS(Index = 189)]
        /* 0x0870 */ public Vector3f OffsetForFleetInteraction;
        [NMS(Index = 190)]
        /* 0x0880 */ public Vector3f OffsetForFrigateInteraction;
        [NMS(Index = 219)]
        /* 0x0890 */ public Vector3f PhotoModeShipOffset;
        [NMS(Index = 220)]
        /* 0x08A0 */ public Vector3f PhotoModeVRFPOffset;
        [NMS(Index = 156)]
        /* 0x08B0 */ public Vector3f ShopInteractionOffsetExtraVR;
        [NMS(Index = 157)]
        /* 0x08C0 */ public Vector3f ShopInteractionOffsetExtraVRSeated;
        [NMS(Index = 42)]
        /* 0x08D0 */ public Colour VehicleExitFlashColour;
        [NMS(Index = 39)]
        /* 0x08E0 */ public Colour VRGravityChangeFlashColour;
        [NMS(Index = 140)]
        /* 0x08F0 */ public GcCameraFollowSettings AlienShipFollowCam;
        [NMS(Index = 127)]
        /* 0x09F8 */ public GcCameraFollowSettings BikeFollowCam;
        [NMS(Index = 123)]
        /* 0x0B00 */ public GcCameraFollowSettings BuggyFollowCam;
        [NMS(Index = 146)]
        /* 0x0C08 */ public GcCameraFollowSettings BuildingIndoorsCam;
        [NMS(Index = 147)]
        /* 0x0D10 */ public GcCameraFollowSettings BuildingOutdoorsCam;
        [NMS(Index = 148)]
        /* 0x0E18 */ public GcCameraFollowSettings BuildingUnderwaterCam;
        [NMS(Index = 99)]
        /* 0x0F20 */ public GcCameraFollowSettings CharacterAbandCam;
        [NMS(Index = 98)]
        /* 0x1028 */ public GcCameraFollowSettings CharacterAbandCombatCam;
        [NMS(Index = 101)]
        /* 0x1130 */ public GcCameraFollowSettings CharacterAirborneCam;
        [NMS(Index = 106)]
        /* 0x1238 */ public GcCameraFollowSettings CharacterAirborneCombatCam;
        [NMS(Index = 91)]
        /* 0x1340 */ public GcCameraFollowSettings CharacterCombatCam;
        [NMS(Index = 96)]
        /* 0x1448 */ public GcCameraFollowSettings CharacterCorvetteBuildCam;
        [NMS(Index = 95)]
        /* 0x1550 */ public GcCameraFollowSettings CharacterCorvetteCam;
        [NMS(Index = 105)]
        /* 0x1658 */ public GcCameraFollowSettings CharacterFallingCam;
        [NMS(Index = 93)]
        /* 0x1760 */ public GcCameraFollowSettings CharacterFishingCam;
        [NMS(Index = 115)]
        /* 0x1868 */ public GcCameraFollowSettings CharacterGrabbedCam;
        [NMS(Index = 94)]
        /* 0x1970 */ public GcCameraFollowSettings CharacterIndoorCam;
        [NMS(Index = 102)]
        /* 0x1A78 */ public GcCameraFollowSettings CharacterMeleeBoostCam;
        [NMS(Index = 92)]
        /* 0x1B80 */ public GcCameraFollowSettings CharacterMiningCam;
        [NMS(Index = 100)]
        /* 0x1C88 */ public GcCameraFollowSettings CharacterNexusCam;
        [NMS(Index = 117)]
        /* 0x1D90 */ public GcCameraFollowSettings CharacterRideCam;
        [NMS(Index = 120)]
        /* 0x1E98 */ public GcCameraFollowSettings CharacterRideCamHuge;
        [NMS(Index = 119)]
        /* 0x1FA0 */ public GcCameraFollowSettings CharacterRideCamLarge;
        [NMS(Index = 118)]
        /* 0x20A8 */ public GcCameraFollowSettings CharacterRideCamMedium;
        [NMS(Index = 103)]
        /* 0x21B0 */ public GcCameraFollowSettings CharacterRocketBootsCam;
        [NMS(Index = 104)]
        /* 0x22B8 */ public GcCameraFollowSettings CharacterRocketBootsChargeCam;
        [NMS(Index = 90)]
        /* 0x23C0 */ public GcCameraFollowSettings CharacterRunCam;
        [NMS(Index = 116)]
        /* 0x24C8 */ public GcCameraFollowSettings CharacterSitCam;
        [NMS(Index = 107)]
        /* 0x25D0 */ public GcCameraFollowSettings CharacterSpaceCam;
        [NMS(Index = 112)]
        /* 0x26D8 */ public GcCameraFollowSettings CharacterSpacewalkCombatCam;
        [NMS(Index = 108)]
        /* 0x27E0 */ public GcCameraFollowSettings CharacterSteepSlopeCam;
        [NMS(Index = 109)]
        /* 0x28E8 */ public GcCameraFollowSettings CharacterSurfaceWaterCam;
        [NMS(Index = 89)]
        /* 0x29F0 */ public GcCameraFollowSettings CharacterUnarmedCam;
        [NMS(Index = 97)]
        /* 0x2AF8 */ public GcCameraFollowSettings CharacterUndergroundCam;
        [NMS(Index = 110)]
        /* 0x2C00 */ public GcCameraFollowSettings CharacterUnderwaterCam;
        [NMS(Index = 111)]
        /* 0x2D08 */ public GcCameraFollowSettings CharacterUnderwaterCombatCam;
        [NMS(Index = 114)]
        /* 0x2E10 */ public GcCameraFollowSettings CharacterUnderwaterJetpackAscentCam;
        [NMS(Index = 113)]
        /* 0x2F18 */ public GcCameraFollowSettings CharacterUnderwaterJetpackCam;
        [NMS(Index = 142)]
        /* 0x3020 */ public GcCameraFollowSettings CorvetteFollowCam;
        [NMS(Index = 135)]
        /* 0x3128 */ public GcCameraFollowSettings DropshipFollowCam;
        [NMS(Index = 130)]
        /* 0x3230 */ public GcCameraFollowSettings FlatbedFollowCam;
        [NMS(Index = 124)]
        /* 0x3338 */ public GcCameraFollowSettings HovercraftFollowCam;
        [NMS(Index = 132)]
        /* 0x3440 */ public GcCameraFollowSettings MechCombatCam;
        [NMS(Index = 18)]
        /* 0x3548 */ public GcCameraFollowSettings MechFirstPersonCam;
        [NMS(Index = 131)]
        /* 0x3650 */ public GcCameraFollowSettings MechFollowCam;
        [NMS(Index = 133)]
        /* 0x3758 */ public GcCameraFollowSettings MechJetpackCam;
        [NMS(Index = 141)]
        /* 0x3860 */ public GcCameraFollowSettings RobotShipFollowCam;
        [NMS(Index = 137)]
        /* 0x3968 */ public GcCameraFollowSettings RoyalShipFollowCam;
        [NMS(Index = 138)]
        /* 0x3A70 */ public GcCameraFollowSettings SailShipFollowCam;
        [NMS(Index = 139)]
        /* 0x3B78 */ public GcCameraFollowSettings ScienceShipFollowCam;
        [NMS(Index = 136)]
        /* 0x3C80 */ public GcCameraFollowSettings ShuttleFollowCam;
        [NMS(Index = 134)]
        /* 0x3D88 */ public GcCameraFollowSettings SpaceshipFollowCam;
        [NMS(Index = 125)]
        /* 0x3E90 */ public GcCameraFollowSettings SubmarineFollowCam;
        [NMS(Index = 126)]
        /* 0x3F98 */ public GcCameraFollowSettings SubmarineFollowCamSurface;
        [NMS(Index = 129)]
        /* 0x40A0 */ public GcCameraFollowSettings TruckFollowCam;
        [NMS(Index = 17)]
        /* 0x41A8 */ public GcCameraFollowSettings VehicleCam;
        [NMS(Index = 16)]
        /* 0x42B0 */ public GcCameraFollowSettings VehicleCamHmd;
        [NMS(Index = 128)]
        /* 0x43B8 */ public GcCameraFollowSettings WheeledBikeFollowCam;
        [NMS(Index = 373)]
        /* 0x44C0 */ public GcCameraAnimationData AmbientCameraAnimations;
        [NMS(Index = 374)]
        /* 0x44E0 */ public TkModelResource AmbientDroneAnimations;
        [NMS(Index = 9)]
        /* 0x4500 */ public List<GcCameraAerialViewDataTableEntry> AerialViewDataTable;
        [NMS(Index = 375)]
        /* 0x4510 */ public GcFilename CameraAmbientAnimationsData;
        [NMS(Index = 15)]
        /* 0x4520 */ public List<GcCameraFollowSettings> Cameras;
        [NMS(Index = 286)]
        /* 0x4530 */ public List<GcCameraShakeData> CameraShakeTable;
        [NMS(Index = 386)]
        /* 0x4540 */ public List<Vector3f> SavedCameraFacing;
        [NMS(Index = 385)]
        /* 0x4550 */ public List<TkBigPosData> SavedCameraPositions;
        [NMS(Index = 388)]
        /* 0x4560 */ public GcCameraWarpSettings CorvetteWarpSettings;
        [NMS(Index = 389)]
        /* 0x45B4 */ public GcCameraWarpSettings FreighterWarpSettings;
        [NMS(Index = 390)]
        /* 0x4608 */ public GcCameraWarpSettings PirateFreighterWarpSettings;
        [NMS(Index = 387)]
        /* 0x465C */ public GcCameraWarpSettings WarpSettings;
        [NMS(Index = 6)]
        /* 0x46B0 */ public GcCameraFocusBuildingControlSettings FocusBuildingModeDistanceControlSettings;
        [NMS(Index = 4)]
        /* 0x46D0 */ public GcCameraFocusBuildingControlSettings FocusBuildingModePitchControlSettings;
        [NMS(Index = 7)]
        /* 0x46F0 */ public GcCameraFocusBuildingControlSettings FocusBuildingModePlanarControlSettings;
        [NMS(Index = 8)]
        /* 0x4710 */ public GcCameraFocusBuildingControlSettings FocusBuildingModeVerticalControlSettings;
        [NMS(Index = 5)]
        /* 0x4730 */ public GcCameraFocusBuildingControlSettings FocusBuildingModeYawControlSettings;
        [NMS(Index = 152)]
        /* 0x4750 */ public Vector2f ModelViewFocusOffset;
        [NMS(Index = 194)]
        /* 0x4758 */ public Vector2f PitchForFrigateInteraction;
        [NMS(Index = 195)]
        /* 0x4760 */ public Vector2f RotationForFrigateInteraction;
        [NMS(Index = 231)]
        /* 0x4768 */ public float AerialViewBackTime;
        [NMS(Index = 232)]
        /* 0x476C */ public float AerialViewBlendTime;
        [NMS(Index = 228)]
        /* 0x4770 */ public float AerialViewDownDistance;
        [NMS(Index = 229)]
        /* 0x4774 */ public float AerialViewPause;
        [NMS(Index = 230)]
        /* 0x4778 */ public float AerialViewStartTime;
        [NMS(Index = 60)]
        /* 0x477C */ public float BinocularFlashStrength;
        [NMS(Index = 59)]
        /* 0x4780 */ public float BinocularFlashTime;
        [NMS(Index = 289)]
        /* 0x4784 */ public float BobAmount;
        [NMS(Index = 287)]
        /* 0x4788 */ public float BobAmountAbandFreighter;
        [NMS(Index = 290)]
        /* 0x478C */ public float BobFactor;
        [NMS(Index = 288)]
        /* 0x4790 */ public float BobFactorAbandFreighter;
        [NMS(Index = 291)]
        /* 0x4794 */ public float BobFocus;
        [NMS(Index = 295)]
        /* 0x4798 */ public float BobFwdAmount;
        [NMS(Index = 293)]
        /* 0x479C */ public float BobRollAmount;
        [NMS(Index = 292)]
        /* 0x47A0 */ public float BobRollFactor;
        [NMS(Index = 294)]
        /* 0x47A4 */ public float BobRollOffset;
        [NMS(Index = 224)]
        /* 0x47A8 */ public float BuildingModeMaxDistance;
        [NMS(Index = 377)]
        /* 0x47AC */ public float CameraAmbientAutoSwitchMaxTime;
        [NMS(Index = 376)]
        /* 0x47B0 */ public float CameraAmbientAutoSwitchMinTime;
        [NMS(Index = 296)]
        /* 0x47B4 */ public float CamSeed1;
        [NMS(Index = 297)]
        /* 0x47B8 */ public float CamSeed2;
        [NMS(Index = 300)]
        /* 0x47BC */ public float CamWander1Amplitude;
        [NMS(Index = 298)]
        /* 0x47C0 */ public float CamWander1Phase;
        [NMS(Index = 301)]
        /* 0x47C4 */ public float CamWander2Amplitude;
        [NMS(Index = 299)]
        /* 0x47C8 */ public float CamWander2Phase;
        [NMS(Index = 319)]
        /* 0x47CC */ public float CharCamAutoDirStartTime;
        [NMS(Index = 322)]
        /* 0x47D0 */ public float CharCamDeflectSpeed;
        [NMS(Index = 314)]
        /* 0x47D4 */ public float CharCamFocusHeight;
        [NMS(Index = 317)]
        /* 0x47D8 */ public float CharCamHeight;
        [NMS(Index = 320)]
        /* 0x47DC */ public float CharCamLookOffset;
        [NMS(Index = 321)]
        /* 0x47E0 */ public float CharCamLookOffsetFactor;
        [NMS(Index = 315)]
        /* 0x47E4 */ public float CharCamMaxDistance;
        [NMS(Index = 316)]
        /* 0x47E8 */ public float CharCamMinDistance;
        [NMS(Index = 323)]
        /* 0x47EC */ public float CharCamMinSpeed;
        [NMS(Index = 318)]
        /* 0x47F0 */ public float CharCamOffsetTime;
        [NMS(Index = 324)]
        /* 0x47F4 */ public float CharCamRightStickX;
        [NMS(Index = 325)]
        /* 0x47F8 */ public float CharCamRightStickY;
        [NMS(Index = 329)]
        /* 0x47FC */ public float CloseFactorSpring;
        [NMS(Index = 370)]
        /* 0x4800 */ public float CreatureInteractionCamSpring;
        [NMS(Index = 357)]
        /* 0x4804 */ public float CreatureInteractionDistMulMax;
        [NMS(Index = 356)]
        /* 0x4808 */ public float CreatureInteractionDistMulMin;
        [NMS(Index = 364)]
        /* 0x480C */ public float CreatureInteractionDownhillPitchTransfer;
        [NMS(Index = 369)]
        /* 0x4810 */ public float CreatureInteractionFoVMax;
        [NMS(Index = 368)]
        /* 0x4814 */ public float CreatureInteractionFoVMin;
        [NMS(Index = 367)]
        /* 0x4818 */ public float CreatureInteractionFoVSplitSize;
        [NMS(Index = 371)]
        /* 0x481C */ public float CreatureInteractionHeadHeightSpring;
        [NMS(Index = 363)]
        /* 0x4820 */ public float CreatureInteractionMaxDownhillPitchAroundPlayer;
        [NMS(Index = 365)]
        /* 0x4824 */ public float CreatureInteractionMaxUphillPitchAroundPlayer;
        [NMS(Index = 353)]
        /* 0x4828 */ public float CreatureInteractionMinDist;
        [NMS(Index = 362)]
        /* 0x482C */ public float CreatureInteractionPitchMax;
        [NMS(Index = 361)]
        /* 0x4830 */ public float CreatureInteractionPitchMin;
        [NMS(Index = 360)]
        /* 0x4834 */ public float CreatureInteractionPitchSplit;
        [NMS(Index = 355)]
        /* 0x4838 */ public float CreatureInteractionPushCameraDownAmount;
        [NMS(Index = 354)]
        /* 0x483C */ public float CreatureInteractionPushCameraDownForCreatureBiggerThan;
        [NMS(Index = 366)]
        /* 0x4840 */ public float CreatureInteractionUphillPitchTransfer;
        [NMS(Index = 359)]
        /* 0x4844 */ public float CreatureInteractionYawMax;
        [NMS(Index = 358)]
        /* 0x4848 */ public float CreatureInteractionYawMin;
        [NMS(Index = 352)]
        /* 0x484C */ public float CreatureSizeMax;
        [NMS(Index = 351)]
        /* 0x4850 */ public float CreatureSizeMin;
        [NMS(Index = 278)]
        /* 0x4854 */ public float DebugAICamAt;
        [NMS(Index = 277)]
        /* 0x4858 */ public float DebugAICamUp;
        [NMS(Index = 304)]
        /* 0x485C */ public float DebugCameraFastFactor;
        [NMS(Index = 306)]
        /* 0x4860 */ public float DebugCameraHeightForAccelerateBegin;
        [NMS(Index = 308)]
        /* 0x4864 */ public float DebugCameraHeightForAccelerateEnd;
        [NMS(Index = 309)]
        /* 0x4868 */ public float DebugCameraMaxSpeed;
        [NMS(Index = 303)]
        /* 0x486C */ public float DebugCameraSlowFactor;
        [NMS(Index = 305)]
        /* 0x4870 */ public float DebugCameraSpaceFastFactor;
        [NMS(Index = 307)]
        /* 0x4874 */ public float DebugCameraSpeedAtPlanetThreshold;
        [NMS(Index = 275)]
        /* 0x4878 */ public float DebugMoveCamHeight;
        [NMS(Index = 274)]
        /* 0x487C */ public float DebugMoveCamSpeed;
        [NMS(Index = 28)]
        /* 0x4880 */ public float DebugPlanetJumpFarHeight;
        [NMS(Index = 27)]
        /* 0x4884 */ public float DebugPlanetJumpNearHeight;
        [NMS(Index = 302)]
        /* 0x4888 */ public float DebugSpaceStationTeleportOffset;
        [NMS(Index = 186)]
        /* 0x488C */ public float DistanceForFleetInteraction;
        [NMS(Index = 187)]
        /* 0x4890 */ public float DistanceForFrigateInteraction;
        [NMS(Index = 188)]
        /* 0x4894 */ public float DistanceForFrigatePurchaseInteraction;
        [NMS(Index = 326)]
        /* 0x4898 */ public float FirstPersonCamHeight;
        [NMS(Index = 330)]
        /* 0x489C */ public float FirstPersonFoV;
        [NMS(Index = 284)]
        /* 0x48A0 */ public float FirstPersonSlerpAway;
        [NMS(Index = 285)]
        /* 0x48A4 */ public float FirstPersonSlerpTowards;
        [NMS(Index = 334)]
        /* 0x48A8 */ public float FirstPersonZoom1FoV;
        [NMS(Index = 335)]
        /* 0x48AC */ public float FirstPersonZoom2FoV;
        [NMS(Index = 191)]
        /* 0x48B0 */ public float FleetUIOrbitRate;
        [NMS(Index = 193)]
        /* 0x48B4 */ public float FleetUIVerticalMotionAmplitude;
        [NMS(Index = 192)]
        /* 0x48B8 */ public float FleetUIVerticalMotionDuration;
        [NMS(Index = 58)]
        /* 0x48BC */ public float FlybyInVehicleDamper;
        [NMS(Index = 54)]
        /* 0x48C0 */ public float FlybyMinRange;
        [NMS(Index = 56)]
        /* 0x48C4 */ public float FlybyMinRelativeSpeed;
        [NMS(Index = 55)]
        /* 0x48C8 */ public float FlybyRange;
        [NMS(Index = 57)]
        /* 0x48CC */ public float FlybyRelativeSpeedRange;
        [NMS(Index = 3)]
        /* 0x48D0 */ public float FocusBuildingModeMaxFOV;
        [NMS(Index = 2)]
        /* 0x48D4 */ public float FocusBuildingModeMinFOV;
        [NMS(Index = 1)]
        /* 0x48D8 */ public float FocusBuildingModeStartDistance;
        [NMS(Index = 349)]
        /* 0x48DC */ public float FoVAdjust;
        [NMS(Index = 346)]
        /* 0x48E0 */ public float FoVSpring;
        [NMS(Index = 347)]
        /* 0x48E4 */ public float FoVSpringSights;
        [NMS(Index = 348)]
        /* 0x48E8 */ public float FoVSpringSightsPassive;
        [NMS(Index = 180)]
        /* 0x48EC */ public float FrigateCaptainLateralShiftAmount;
        [NMS(Index = 149)]
        /* 0x48F0 */ public float FrontendModelCameraSpringTime;
        [NMS(Index = 23)]
        /* 0x48F4 */ public float HmdEyeExtraTurnAngle;
        [NMS(Index = 25)]
        /* 0x48F8 */ public float HmdEyeExtraTurnHeadAngleRange;
        [NMS(Index = 24)]
        /* 0x48FC */ public float HmdEyeExtraTurnMinHeadAngle;
        [NMS(Index = 22)]
        /* 0x4900 */ public float HmdEyeLookAngle;
        [NMS(Index = 282)]
        /* 0x4904 */ public float IndoorCamShakeDamper;
        [NMS(Index = 166)]
        /* 0x4908 */ public float InteractionHeadHeightCronus;
        [NMS(Index = 165)]
        /* 0x490C */ public float InteractionHeadHeightDefault;
        [NMS(Index = 167)]
        /* 0x4910 */ public float InteractionHeadHeightGek;
        [NMS(Index = 169)]
        /* 0x4914 */ public float InteractionHeadHeightSpiderman;
        [NMS(Index = 168)]
        /* 0x4918 */ public float InteractionHeadHeightVykeen;
        [NMS(Index = 173)]
        /* 0x491C */ public float InteractionHeadPosHeightAdjust;
        [NMS(Index = 176)]
        /* 0x4920 */ public float InteractionHeadPosHeightAdjustCronus;
        [NMS(Index = 175)]
        /* 0x4924 */ public float InteractionHeadPosHeightAdjustSpiderman;
        [NMS(Index = 174)]
        /* 0x4928 */ public float InteractionHeadPosHeightAdjustVykeen;
        [NMS(Index = 196)]
        /* 0x492C */ public float InteractionModeBlendTime;
        [NMS(Index = 197)]
        /* 0x4930 */ public float InteractionModeFocusCamBlend;
        [NMS(Index = 198)]
        /* 0x4934 */ public float InteractionModeFoV;
        [NMS(Index = 172)]
        /* 0x4938 */ public float InteractionPitchAdjustDeadZone;
        [NMS(Index = 171)]
        /* 0x493C */ public float InteractionPitchAdjustStrength;
        [NMS(Index = 170)]
        /* 0x4940 */ public float InteractionPitchAdjustTime;
        [NMS(Index = 184)]
        /* 0x4944 */ public float LocalMissionBoardLateralShiftAmount;
        [NMS(Index = 63)]
        /* 0x4948 */ public float MaxCreatureRidingYaw;
        [NMS(Index = 62)]
        /* 0x494C */ public float MaxFirstPersonCameraPitch;
        [NMS(Index = 87)]
        /* 0x4950 */ public float MechCameraArmShootOffsetY;
        [NMS(Index = 88)]
        /* 0x4954 */ public float MechCameraCombatFakeSpeed;
        [NMS(Index = 86)]
        /* 0x4958 */ public float MechCameraExtraYPostLandingBlendTime;
        [NMS(Index = 85)]
        /* 0x495C */ public float MechCameraNoExtraYTimeAfterLand;
        [NMS(Index = 242)]
        /* 0x4960 */ public float MechCamSpringStrengthMax;
        [NMS(Index = 241)]
        /* 0x4964 */ public float MechCamSpringStrengthMin;
        [NMS(Index = 226)]
        /* 0x4968 */ public float MeleeBoostedFoV;
        [NMS(Index = 227)]
        /* 0x496C */ public float MeleeFoV;
        [NMS(Index = 61)]
        /* 0x4970 */ public float MinFirstPersonCameraPitch;
        [NMS(Index = 200)]
        /* 0x4974 */ public float MinInteractFocusAngle;
        [NMS(Index = 35)]
        /* 0x4978 */ public float MiniportalFlashStrength;
        [NMS(Index = 34)]
        /* 0x497C */ public float MiniportalFlashTime;
        [NMS(Index = 271)]
        /* 0x4980 */ public float ModelViewDefaultPitch;
        [NMS(Index = 272)]
        /* 0x4984 */ public float ModelViewDefaultYaw;
        [NMS(Index = 268)]
        /* 0x4988 */ public float ModelViewDistSpeed;
        [NMS(Index = 150)]
        /* 0x498C */ public float ModelViewFlashTime;
        [NMS(Index = 201)]
        /* 0x4990 */ public float ModelViewInterpTime;
        [NMS(Index = 270)]
        /* 0x4994 */ public float ModelViewMaxDist;
        [NMS(Index = 269)]
        /* 0x4998 */ public float ModelViewMinDist;
        [NMS(Index = 267)]
        /* 0x499C */ public float ModelViewMouseMoveSpeed;
        [NMS(Index = 266)]
        /* 0x49A0 */ public float ModelViewMouseRotateSnapStrength;
        [NMS(Index = 265)]
        /* 0x49A4 */ public float ModelViewMouseRotateSpeed;
        [NMS(Index = 264)]
        /* 0x49A8 */ public float ModelViewRotateSpeed;
        [NMS(Index = 263)]
        /* 0x49AC */ public float MouseSensitivity;
        [NMS(Index = 283)]
        /* 0x49B0 */ public float NoControlCamShakeDamper;
        [NMS(Index = 183)]
        /* 0x49B4 */ public float NPCTradeLateralShiftAmount;
        [NMS(Index = 185)]
        /* 0x49B8 */ public float NPCTradeLateralShiftTime;
        [NMS(Index = 313)]
        /* 0x49BC */ public float ObjectFocusTime;
        [NMS(Index = 310)]
        /* 0x49C0 */ public float OffsetCamFOV;
        [NMS(Index = 12)]
        /* 0x49C4 */ public float OffsetCombatCameraHorizontalAngle;
        [NMS(Index = 280)]
        /* 0x49C8 */ public float PainShakeTime;
        [NMS(Index = 215)]
        /* 0x49CC */ public float PhotoModeCollisionRadius;
        [NMS(Index = 217)]
        /* 0x49D0 */ public float PhotoModeFlashDuration;
        [NMS(Index = 218)]
        /* 0x49D4 */ public float PhotoModeFlashIntensity;
        [NMS(Index = 211)]
        /* 0x49D8 */ public float PhotoModeMaxDistance;
        [NMS(Index = 214)]
        /* 0x49DC */ public float PhotoModeMaxDistanceClampBuffer;
        [NMS(Index = 213)]
        /* 0x49E0 */ public float PhotoModeMaxDistanceClampForce;
        [NMS(Index = 212)]
        /* 0x49E4 */ public float PhotoModeMaxDistanceSpace;
        [NMS(Index = 209)]
        /* 0x49E8 */ public float PhotoModeMoveSpeed;
        [NMS(Index = 216)]
        /* 0x49EC */ public float PhotoModeRollSpeed;
        [NMS(Index = 210)]
        /* 0x49F0 */ public float PhotoModeTurnSpeed;
        [NMS(Index = 208)]
        /* 0x49F4 */ public float PhotoModeVelocitySmoothTime;
        [NMS(Index = 181)]
        /* 0x49F8 */ public float PilotDetailsLateralShiftAmount;
        [NMS(Index = 182)]
        /* 0x49FC */ public float RecruitmentLateralShiftAmount;
        [NMS(Index = 19)]
        /* 0x4A00 */ public float RevealedNPCHeadOffset;
        [NMS(Index = 225)]
        /* 0x4A04 */ public float RunningFoVAdjust;
        [NMS(Index = 0)]
        /* 0x4A08 */ public float ScanCameraLookAtTime;
        [NMS(Index = 10)]
        /* 0x4A0C */ public float SClassLandingShakeMultiplier;
        [NMS(Index = 238)]
        /* 0x4A10 */ public float ScreenshotBackDistance;
        [NMS(Index = 236)]
        /* 0x4A14 */ public float ScreenshotBendDownAmount;
        [NMS(Index = 235)]
        /* 0x4A18 */ public float ScreenshotHorizonFaceFactor;
        [NMS(Index = 234)]
        /* 0x4A1C */ public float ScreenshotHorizonHeight;
        [NMS(Index = 239)]
        /* 0x4A20 */ public float ScreenshotInTime;
        [NMS(Index = 240)]
        /* 0x4A24 */ public float ScreenshotOutTime;
        [NMS(Index = 237)]
        /* 0x4A28 */ public float ScreenshotRightDistance;
        [NMS(Index = 199)]
        /* 0x4A2C */ public float ShipBuilderFoV;
        [NMS(Index = 262)]
        /* 0x4A30 */ public float ShipCamAimFOV;
        [NMS(Index = 244)]
        /* 0x4A34 */ public float ShipCamFastSpringStrengthMax;
        [NMS(Index = 243)]
        /* 0x4A38 */ public float ShipCamFastSpringStrengthMin;
        [NMS(Index = 250)]
        /* 0x4A3C */ public float ShipCamLookInterp;
        [NMS(Index = 251)]
        /* 0x4A40 */ public float ShipCamMinReturnTime;
        [NMS(Index = 258)]
        /* 0x4A44 */ public float ShipCamMotionInterp;
        [NMS(Index = 257)]
        /* 0x4A48 */ public float ShipCamMotionMaxLagPitchAngle;
        [NMS(Index = 256)]
        /* 0x4A4C */ public float ShipCamMotionMaxLagTurnAngle;
        [NMS(Index = 254)]
        /* 0x4A50 */ public float ShipCamMotionPitch;
        [NMS(Index = 255)]
        /* 0x4A54 */ public float ShipCamMotionPitchMod;
        [NMS(Index = 253)]
        /* 0x4A58 */ public float ShipCamMotionTurn;
        [NMS(Index = 248)]
        /* 0x4A5C */ public float ShipCamPitch;
        [NMS(Index = 249)]
        /* 0x4A60 */ public float ShipCamPitchMod;
        [NMS(Index = 252)]
        /* 0x4A64 */ public float ShipCamReturnTime;
        [NMS(Index = 260)]
        /* 0x4A68 */ public float ShipCamRollAmountMax;
        [NMS(Index = 259)]
        /* 0x4A6C */ public float ShipCamRollAmountMin;
        [NMS(Index = 261)]
        /* 0x4A70 */ public float ShipCamRollSpeedScaler;
        [NMS(Index = 246)]
        /* 0x4A74 */ public float ShipCamSpringStrengthMax;
        [NMS(Index = 245)]
        /* 0x4A78 */ public float ShipCamSpringStrengthMin;
        [NMS(Index = 247)]
        /* 0x4A7C */ public float ShipCamTurn;
        [NMS(Index = 51)]
        /* 0x4A80 */ public float ShipFirstPersonBlendOffset;
        [NMS(Index = 50)]
        /* 0x4A84 */ public float ShipFirstPersonBlendTime;
        [NMS(Index = 342)]
        /* 0x4A88 */ public float ShipFoVBoost;
        [NMS(Index = 338)]
        /* 0x4A8C */ public float ShipFoVMax;
        [NMS(Index = 341)]
        /* 0x4A90 */ public float ShipFoVMax3rdPerson;
        [NMS(Index = 336)]
        /* 0x4A94 */ public float ShipFoVMin;
        [NMS(Index = 337)]
        /* 0x4A98 */ public float ShipFoVMin2;
        [NMS(Index = 340)]
        /* 0x4A9C */ public float ShipFoVMin3rdPerson;
        [NMS(Index = 343)]
        /* 0x4AA0 */ public float ShipFoVMiniJump;
        [NMS(Index = 344)]
        /* 0x4AA4 */ public float ShipFoVSpring;
        [NMS(Index = 345)]
        /* 0x4AA8 */ public float ShipMiniJumpFoVSpring;
        [NMS(Index = 281)]
        /* 0x4AAC */ public float ShipShakeDamper;
        [NMS(Index = 47)]
        /* 0x4AB0 */ public float ShipThirdPersonBlendOffset;
        [NMS(Index = 49)]
        /* 0x4AB4 */ public float ShipThirdPersonBlendOutOffset;
        [NMS(Index = 48)]
        /* 0x4AB8 */ public float ShipThirdPersonBlendOutTime;
        [NMS(Index = 45)]
        /* 0x4ABC */ public float ShipThirdPersonBlendTime;
        [NMS(Index = 46)]
        /* 0x4AC0 */ public float ShipThirdPersonBlendWithOffsetTime;
        [NMS(Index = 53)]
        /* 0x4AC4 */ public float ShipThirdPersonEnterBlendOffset;
        [NMS(Index = 52)]
        /* 0x4AC8 */ public float ShipThirdPersonEnterBlendTime;
        [NMS(Index = 339)]
        /* 0x4ACC */ public float ShipWarpFoV;
        [NMS(Index = 20)]
        /* 0x4AD0 */ public float SpecialVehicleMouseRecentreTime;
        [NMS(Index = 21)]
        /* 0x4AD4 */ public float SpecialVehicleMouseRecentreWeaponTime;
        [NMS(Index = 32)]
        /* 0x4AD8 */ public float ThirdPersonAfterIntroCamBlendTime;
        [NMS(Index = 202)]
        /* 0x4ADC */ public float ThirdPersonBlendInTime;
        [NMS(Index = 203)]
        /* 0x4AE0 */ public float ThirdPersonBlendOutTime;
        [NMS(Index = 121)]
        /* 0x4AE4 */ public float ThirdPersonCameraChangeBlendTime;
        [NMS(Index = 122)]
        /* 0x4AE8 */ public float ThirdPersonCameraChangeMinimumBlend;
        [NMS(Index = 66)]
        /* 0x4AEC */ public float ThirdPersonCloseDistance;
        [NMS(Index = 67)]
        /* 0x4AF0 */ public float ThirdPersonCloseDistanceX;
        [NMS(Index = 65)]
        /* 0x4AF4 */ public float ThirdPersonClosePitch;
        [NMS(Index = 204)]
        /* 0x4AF8 */ public float ThirdPersonCollisionPushOffsetReducerStart;
        [NMS(Index = 205)]
        /* 0x4AFC */ public float ThirdPersonCollisionPushOffsetReducerVehicleRearAngle;
        [NMS(Index = 333)]
        /* 0x4B00 */ public float ThirdPersonCombatFoV;
        [NMS(Index = 74)]
        /* 0x4B04 */ public float ThirdPersonDownhillAdjustMaxAngle;
        [NMS(Index = 78)]
        /* 0x4B08 */ public float ThirdPersonDownhillAdjustMaxAnglePrime;
        [NMS(Index = 73)]
        /* 0x4B0C */ public float ThirdPersonDownhillAdjustMinAngle;
        [NMS(Index = 77)]
        /* 0x4B10 */ public float ThirdPersonDownhillAdjustMinAnglePrime;
        [NMS(Index = 72)]
        /* 0x4B14 */ public float ThirdPersonDownhillAdjustSpringTimeMax;
        [NMS(Index = 71)]
        /* 0x4B18 */ public float ThirdPersonDownhillAdjustSpringTimeMin;
        [NMS(Index = 331)]
        /* 0x4B1C */ public float ThirdPersonFoV;
        [NMS(Index = 206)]
        /* 0x4B20 */ public float ThirdPersonOffsetSpringTime;
        [NMS(Index = 68)]
        /* 0x4B24 */ public float ThirdPersonRotationBackAdjustAngleMax;
        [NMS(Index = 64)]
        /* 0x4B28 */ public float ThirdPersonRotationBackAdjustAngleMin;
        [NMS(Index = 33)]
        /* 0x4B2C */ public float ThirdPersonSkipIntroCamBlendTime;
        [NMS(Index = 82)]
        /* 0x4B30 */ public float ThirdPersonUphillAdjustCrossSlopeMaxAngle;
        [NMS(Index = 81)]
        /* 0x4B34 */ public float ThirdPersonUphillAdjustCrossSlopeMinAngle;
        [NMS(Index = 76)]
        /* 0x4B38 */ public float ThirdPersonUphillAdjustMaxAngle;
        [NMS(Index = 80)]
        /* 0x4B3C */ public float ThirdPersonUphillAdjustMaxAnglePrime;
        [NMS(Index = 75)]
        /* 0x4B40 */ public float ThirdPersonUphillAdjustMinAngle;
        [NMS(Index = 79)]
        /* 0x4B44 */ public float ThirdPersonUphillAdjustMinAnglePrime;
        [NMS(Index = 70)]
        /* 0x4B48 */ public float ThirdPersonUphillAdjustSpringTimeMax;
        [NMS(Index = 69)]
        /* 0x4B4C */ public float ThirdPersonUphillAdjustSpringTimeMin;
        [NMS(Index = 29)]
        /* 0x4B50 */ public float TogglePerspectiveBlendTime;
        [NMS(Index = 31)]
        /* 0x4B54 */ public float UnderwaterCameraExtraVertOffset;
        [NMS(Index = 179)]
        /* 0x4B58 */ public float VehicleCameraVertRotationLimitBlendTime;
        [NMS(Index = 178)]
        /* 0x4B5C */ public float VehicleCameraVertRotationMax;
        [NMS(Index = 177)]
        /* 0x4B60 */ public float VehicleCameraVertRotationMin;
        [NMS(Index = 41)]
        /* 0x4B64 */ public float VehicleExitFlashStrength;
        [NMS(Index = 40)]
        /* 0x4B68 */ public float VehicleExitFlashTime;
        [NMS(Index = 332)]
        /* 0x4B6C */ public float VehicleFirstPersonFoV;
        [NMS(Index = 43)]
        /* 0x4B70 */ public float VehicleFirstToThirdExitOffsetY;
        [NMS(Index = 44)]
        /* 0x4B74 */ public float VehicleFirstToThirdExitOffsetZ;
        [NMS(Index = 84)]
        /* 0x4B78 */ public float VehicleThirdPersonShootOffsetBlendOutTime;
        [NMS(Index = 83)]
        /* 0x4B7C */ public float VehicleThirdPersonShootOffsetReturnTime;
        [NMS(Index = 38)]
        /* 0x4B80 */ public float VRGravityChangeMaxFlashTime;
        [NMS(Index = 37)]
        /* 0x4B84 */ public float VRGravityChangeMinFlashTime;
        [NMS(Index = 279)]
        /* 0x4B88 */ public float VRShakeMultiplier;
        [NMS(Index = 233)]
        /* 0x4B8C */ public TkCurveType AerialViewCurve;
        [NMS(Index = 350)]
        /* 0x4B8D */ public bool CreatureInteractionInterpolateDuringHold;
        [NMS(Index = 276)]
        /* 0x4B8E */ public bool DebugAICam;
        [NMS(Index = 273)]
        /* 0x4B8F */ public bool DebugMoveCam;
        [NMS(Index = 372)]
        /* 0x4B90 */ public bool FollowDrawCamProbes;
        [NMS(Index = 30)]
        /* 0x4B91 */ public bool LockFollowSpring;
        [NMS(Index = 207)]
        /* 0x4B92 */ public bool MaxBob;
        [NMS(Index = 11)]
        /* 0x4B93 */ public bool OffsetCombatCameraHorizontal;
        [NMS(Index = 26)]
        /* 0x4B94 */ public bool PauseThirdPersonCamInPause;
    }
}
