using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xAE6DBAA77A717E18, NameHash = 0xFE7187F)]
    public class GcCameraGlobals : NMSTemplate
    {
        [NMS(Index = 364)]
        /* 0x0000 */ public TkModelRendererData CameraCreatureCustomiseBack;
        [NMS(Index = 360)]
        /* 0x00B0 */ public TkModelRendererData CameraCreatureCustomiseDefault;
        [NMS(Index = 363)]
        /* 0x0160 */ public TkModelRendererData CameraCreatureCustomiseFront;
        [NMS(Index = 361)]
        /* 0x0210 */ public TkModelRendererData CameraCreatureCustomiseLeft;
        [NMS(Index = 362)]
        /* 0x02C0 */ public TkModelRendererData CameraCreatureCustomiseRight;
        [NMS(Index = 358)]
        /* 0x0370 */ public TkModelRendererData CameraNPCShipInteraction;
        [NMS(Index = 359)]
        /* 0x0420 */ public TkModelRendererData CameraNPCShopInteraction;
        [NMS(Index = 13)]
        /* 0x04D0 */ public TkModelRendererData FreighterCustomisationStandardCamera;
        [NMS(Index = 14)]
        /* 0x0580 */ public TkModelRendererData FreighterCustomisationStandardCameraAlt;
        [NMS(Index = 307, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x0630 */ public Vector3f[] FirstPersonCamOffset;
        [NMS(Index = 205)]
        /* 0x06C0 */ public Vector3f BuildingModeInitialOffset;
        [NMS(Index = 308)]
        /* 0x06D0 */ public Vector3f FirstPersonInShipCamOffset;
        [NMS(Index = 151)]
        /* 0x06E0 */ public Vector3f InteractionHailingFocusOffset;
        [NMS(Index = 141)]
        /* 0x06F0 */ public Vector3f InteractionOffset;
        [NMS(Index = 149)]
        /* 0x0700 */ public Vector3f InteractionOffsetCronus;
        [NMS(Index = 146)]
        /* 0x0710 */ public Vector3f InteractionOffsetDefault;
        [NMS(Index = 142)]
        /* 0x0720 */ public Vector3f InteractionOffsetExtraVR;
        [NMS(Index = 143)]
        /* 0x0730 */ public Vector3f InteractionOffsetExtraVRSeated;
        [NMS(Index = 147)]
        /* 0x0740 */ public Vector3f InteractionOffsetGek;
        [NMS(Index = 152)]
        /* 0x0750 */ public Vector3f InteractionOffsetRecruitment;
        [NMS(Index = 148)]
        /* 0x0760 */ public Vector3f InteractionOffsetSpiderman;
        [NMS(Index = 150)]
        /* 0x0770 */ public Vector3f InteractionShipFocusOffset;
        [NMS(Index = 36)]
        /* 0x0780 */ public Colour MiniportalFlashColour;
        [NMS(Index = 139)]
        /* 0x0790 */ public Vector3f ModelViewOffset;
        [NMS(Index = 291)]
        /* 0x07A0 */ public Vector3f OffsetCamOffset;
        [NMS(Index = 292)]
        /* 0x07B0 */ public Vector3f OffsetCamRotation;
        [NMS(Index = 174)]
        /* 0x07C0 */ public Vector3f OffsetForFleetInteraction;
        [NMS(Index = 175)]
        /* 0x07D0 */ public Vector3f OffsetForFrigateInteraction;
        [NMS(Index = 203)]
        /* 0x07E0 */ public Vector3f PhotoModeShipOffset;
        [NMS(Index = 204)]
        /* 0x07F0 */ public Vector3f PhotoModeVRFPOffset;
        [NMS(Index = 144)]
        /* 0x0800 */ public Vector3f ShopInteractionOffsetExtraVR;
        [NMS(Index = 145)]
        /* 0x0810 */ public Vector3f ShopInteractionOffsetExtraVRSeated;
        [NMS(Index = 39)]
        /* 0x0820 */ public Colour VehicleExitFlashColour;
        [NMS(Index = 132)]
        /* 0x0830 */ public GcCameraFollowSettings AlienShipFollowCam;
        [NMS(Index = 120)]
        /* 0x0928 */ public GcCameraFollowSettings BikeFollowCam;
        [NMS(Index = 117)]
        /* 0x0A20 */ public GcCameraFollowSettings BuggyFollowCam;
        [NMS(Index = 134)]
        /* 0x0B18 */ public GcCameraFollowSettings BuildingIndoorsCam;
        [NMS(Index = 135)]
        /* 0x0C10 */ public GcCameraFollowSettings BuildingOutdoorsCam;
        [NMS(Index = 136)]
        /* 0x0D08 */ public GcCameraFollowSettings BuildingUnderwaterCam;
        [NMS(Index = 94)]
        /* 0x0E00 */ public GcCameraFollowSettings CharacterAbandCam;
        [NMS(Index = 93)]
        /* 0x0EF8 */ public GcCameraFollowSettings CharacterAbandCombatCam;
        [NMS(Index = 96)]
        /* 0x0FF0 */ public GcCameraFollowSettings CharacterAirborneCam;
        [NMS(Index = 101)]
        /* 0x10E8 */ public GcCameraFollowSettings CharacterAirborneCombatCam;
        [NMS(Index = 88)]
        /* 0x11E0 */ public GcCameraFollowSettings CharacterCombatCam;
        [NMS(Index = 100)]
        /* 0x12D8 */ public GcCameraFollowSettings CharacterFallingCam;
        [NMS(Index = 90)]
        /* 0x13D0 */ public GcCameraFollowSettings CharacterFishingCam;
        [NMS(Index = 109)]
        /* 0x14C8 */ public GcCameraFollowSettings CharacterGrabbedCam;
        [NMS(Index = 91)]
        /* 0x15C0 */ public GcCameraFollowSettings CharacterIndoorCam;
        [NMS(Index = 97)]
        /* 0x16B8 */ public GcCameraFollowSettings CharacterMeleeBoostCam;
        [NMS(Index = 89)]
        /* 0x17B0 */ public GcCameraFollowSettings CharacterMiningCam;
        [NMS(Index = 95)]
        /* 0x18A8 */ public GcCameraFollowSettings CharacterNexusCam;
        [NMS(Index = 111)]
        /* 0x19A0 */ public GcCameraFollowSettings CharacterRideCam;
        [NMS(Index = 114)]
        /* 0x1A98 */ public GcCameraFollowSettings CharacterRideCamHuge;
        [NMS(Index = 113)]
        /* 0x1B90 */ public GcCameraFollowSettings CharacterRideCamLarge;
        [NMS(Index = 112)]
        /* 0x1C88 */ public GcCameraFollowSettings CharacterRideCamMedium;
        [NMS(Index = 98)]
        /* 0x1D80 */ public GcCameraFollowSettings CharacterRocketBootsCam;
        [NMS(Index = 99)]
        /* 0x1E78 */ public GcCameraFollowSettings CharacterRocketBootsChargeCam;
        [NMS(Index = 87)]
        /* 0x1F70 */ public GcCameraFollowSettings CharacterRunCam;
        [NMS(Index = 110)]
        /* 0x2068 */ public GcCameraFollowSettings CharacterSitCam;
        [NMS(Index = 102)]
        /* 0x2160 */ public GcCameraFollowSettings CharacterSpaceCam;
        [NMS(Index = 103)]
        /* 0x2258 */ public GcCameraFollowSettings CharacterSteepSlopeCam;
        [NMS(Index = 104)]
        /* 0x2350 */ public GcCameraFollowSettings CharacterSurfaceWaterCam;
        [NMS(Index = 86)]
        /* 0x2448 */ public GcCameraFollowSettings CharacterUnarmedCam;
        [NMS(Index = 92)]
        /* 0x2540 */ public GcCameraFollowSettings CharacterUndergroundCam;
        [NMS(Index = 105)]
        /* 0x2638 */ public GcCameraFollowSettings CharacterUnderwaterCam;
        [NMS(Index = 106)]
        /* 0x2730 */ public GcCameraFollowSettings CharacterUnderwaterCombatCam;
        [NMS(Index = 108)]
        /* 0x2828 */ public GcCameraFollowSettings CharacterUnderwaterJetpackAscentCam;
        [NMS(Index = 107)]
        /* 0x2920 */ public GcCameraFollowSettings CharacterUnderwaterJetpackCam;
        [NMS(Index = 127)]
        /* 0x2A18 */ public GcCameraFollowSettings DropshipFollowCam;
        [NMS(Index = 118)]
        /* 0x2B10 */ public GcCameraFollowSettings HovercraftFollowCam;
        [NMS(Index = 124)]
        /* 0x2C08 */ public GcCameraFollowSettings MechCombatCam;
        [NMS(Index = 18)]
        /* 0x2D00 */ public GcCameraFollowSettings MechFirstPersonCam;
        [NMS(Index = 123)]
        /* 0x2DF8 */ public GcCameraFollowSettings MechFollowCam;
        [NMS(Index = 125)]
        /* 0x2EF0 */ public GcCameraFollowSettings MechJetpackCam;
        [NMS(Index = 133)]
        /* 0x2FE8 */ public GcCameraFollowSettings RobotShipFollowCam;
        [NMS(Index = 129)]
        /* 0x30E0 */ public GcCameraFollowSettings RoyalShipFollowCam;
        [NMS(Index = 130)]
        /* 0x31D8 */ public GcCameraFollowSettings SailShipFollowCam;
        [NMS(Index = 131)]
        /* 0x32D0 */ public GcCameraFollowSettings ScienceShipFollowCam;
        [NMS(Index = 128)]
        /* 0x33C8 */ public GcCameraFollowSettings ShuttleFollowCam;
        [NMS(Index = 126)]
        /* 0x34C0 */ public GcCameraFollowSettings SpaceshipFollowCam;
        [NMS(Index = 119)]
        /* 0x35B8 */ public GcCameraFollowSettings SubmarineFollowCam;
        [NMS(Index = 122)]
        /* 0x36B0 */ public GcCameraFollowSettings TruckFollowCam;
        [NMS(Index = 17)]
        /* 0x37A8 */ public GcCameraFollowSettings VehicleCam;
        [NMS(Index = 16)]
        /* 0x38A0 */ public GcCameraFollowSettings VehicleCamHmd;
        [NMS(Index = 121)]
        /* 0x3998 */ public GcCameraFollowSettings WheeledBikeFollowCam;
        [NMS(Index = 353)]
        /* 0x3A90 */ public GcCameraAnimationData AmbientCameraAnimations;
        [NMS(Index = 354)]
        /* 0x3AB0 */ public TkModelResource AmbientDroneAnimations;
        [NMS(Index = 9)]
        /* 0x3AD0 */ public List<GcCameraAerialViewDataTableEntry> AerialViewDataTable;
        [NMS(Index = 355)]
        /* 0x3AE0 */ public VariableSizeString CameraAmbientAnimationsData;
        [NMS(Index = 15)]
        /* 0x3AF0 */ public List<GcCameraFollowSettings> Cameras;
        [NMS(Index = 266)]
        /* 0x3B00 */ public List<GcCameraShakeData> CameraShakeTable;
        [NMS(Index = 366)]
        /* 0x3B10 */ public List<Vector3f> SavedCameraFacing;
        [NMS(Index = 365)]
        /* 0x3B20 */ public List<TkPhysRelVectorData> SavedCameraPositions;
        [NMS(Index = 368)]
        /* 0x3B30 */ public GcCameraWarpSettings FreighterWarpSettings;
        [NMS(Index = 369)]
        /* 0x3B84 */ public GcCameraWarpSettings PirateFreighterWarpSettings;
        [NMS(Index = 367)]
        /* 0x3BD8 */ public GcCameraWarpSettings WarpSettings;
        [NMS(Index = 6)]
        /* 0x3C2C */ public GcCameraFocusBuildingControlSettings FocusBuildingModeDistanceControlSettings;
        [NMS(Index = 4)]
        /* 0x3C4C */ public GcCameraFocusBuildingControlSettings FocusBuildingModePitchControlSettings;
        [NMS(Index = 7)]
        /* 0x3C6C */ public GcCameraFocusBuildingControlSettings FocusBuildingModePlanarControlSettings;
        [NMS(Index = 8)]
        /* 0x3C8C */ public GcCameraFocusBuildingControlSettings FocusBuildingModeVerticalControlSettings;
        [NMS(Index = 5)]
        /* 0x3CAC */ public GcCameraFocusBuildingControlSettings FocusBuildingModeYawControlSettings;
        [NMS(Index = 140)]
        /* 0x3CCC */ public Vector2f ModelViewFocusOffset;
        [NMS(Index = 179)]
        /* 0x3CD4 */ public Vector2f PitchForFrigateInteraction;
        [NMS(Index = 180)]
        /* 0x3CDC */ public Vector2f RotationForFrigateInteraction;
        [NMS(Index = 213)]
        /* 0x3CE4 */ public float AerialViewBackTime;
        [NMS(Index = 214)]
        /* 0x3CE8 */ public float AerialViewBlendTime;
        [NMS(Index = 210)]
        /* 0x3CEC */ public float AerialViewDownDistance;
        [NMS(Index = 211)]
        /* 0x3CF0 */ public float AerialViewPause;
        [NMS(Index = 212)]
        /* 0x3CF4 */ public float AerialViewStartTime;
        [NMS(Index = 57)]
        /* 0x3CF8 */ public float BinocularFlashStrength;
        [NMS(Index = 56)]
        /* 0x3CFC */ public float BinocularFlashTime;
        [NMS(Index = 269)]
        /* 0x3D00 */ public float BobAmount;
        [NMS(Index = 267)]
        /* 0x3D04 */ public float BobAmountAbandFreighter;
        [NMS(Index = 270)]
        /* 0x3D08 */ public float BobFactor;
        [NMS(Index = 268)]
        /* 0x3D0C */ public float BobFactorAbandFreighter;
        [NMS(Index = 271)]
        /* 0x3D10 */ public float BobFocus;
        [NMS(Index = 275)]
        /* 0x3D14 */ public float BobFwdAmount;
        [NMS(Index = 273)]
        /* 0x3D18 */ public float BobRollAmount;
        [NMS(Index = 272)]
        /* 0x3D1C */ public float BobRollFactor;
        [NMS(Index = 274)]
        /* 0x3D20 */ public float BobRollOffset;
        [NMS(Index = 206)]
        /* 0x3D24 */ public float BuildingModeMaxDistance;
        [NMS(Index = 357)]
        /* 0x3D28 */ public float CameraAmbientAutoSwitchMaxTime;
        [NMS(Index = 356)]
        /* 0x3D2C */ public float CameraAmbientAutoSwitchMinTime;
        [NMS(Index = 276)]
        /* 0x3D30 */ public float CamSeed1;
        [NMS(Index = 277)]
        /* 0x3D34 */ public float CamSeed2;
        [NMS(Index = 280)]
        /* 0x3D38 */ public float CamWander1Amplitude;
        [NMS(Index = 278)]
        /* 0x3D3C */ public float CamWander1Phase;
        [NMS(Index = 281)]
        /* 0x3D40 */ public float CamWander2Amplitude;
        [NMS(Index = 279)]
        /* 0x3D44 */ public float CamWander2Phase;
        [NMS(Index = 299)]
        /* 0x3D48 */ public float CharCamAutoDirStartTime;
        [NMS(Index = 302)]
        /* 0x3D4C */ public float CharCamDeflectSpeed;
        [NMS(Index = 294)]
        /* 0x3D50 */ public float CharCamFocusHeight;
        [NMS(Index = 297)]
        /* 0x3D54 */ public float CharCamHeight;
        [NMS(Index = 300)]
        /* 0x3D58 */ public float CharCamLookOffset;
        [NMS(Index = 301)]
        /* 0x3D5C */ public float CharCamLookOffsetFactor;
        [NMS(Index = 295)]
        /* 0x3D60 */ public float CharCamMaxDistance;
        [NMS(Index = 296)]
        /* 0x3D64 */ public float CharCamMinDistance;
        [NMS(Index = 303)]
        /* 0x3D68 */ public float CharCamMinSpeed;
        [NMS(Index = 298)]
        /* 0x3D6C */ public float CharCamOffsetTime;
        [NMS(Index = 304)]
        /* 0x3D70 */ public float CharCamRightStickX;
        [NMS(Index = 305)]
        /* 0x3D74 */ public float CharCamRightStickY;
        [NMS(Index = 309)]
        /* 0x3D78 */ public float CloseFactorSpring;
        [NMS(Index = 350)]
        /* 0x3D7C */ public float CreatureInteractionCamSpring;
        [NMS(Index = 337)]
        /* 0x3D80 */ public float CreatureInteractionDistMulMax;
        [NMS(Index = 336)]
        /* 0x3D84 */ public float CreatureInteractionDistMulMin;
        [NMS(Index = 344)]
        /* 0x3D88 */ public float CreatureInteractionDownhillPitchTransfer;
        [NMS(Index = 349)]
        /* 0x3D8C */ public float CreatureInteractionFoVMax;
        [NMS(Index = 348)]
        /* 0x3D90 */ public float CreatureInteractionFoVMin;
        [NMS(Index = 347)]
        /* 0x3D94 */ public float CreatureInteractionFoVSplitSize;
        [NMS(Index = 351)]
        /* 0x3D98 */ public float CreatureInteractionHeadHeightSpring;
        [NMS(Index = 343)]
        /* 0x3D9C */ public float CreatureInteractionMaxDownhillPitchAroundPlayer;
        [NMS(Index = 345)]
        /* 0x3DA0 */ public float CreatureInteractionMaxUphillPitchAroundPlayer;
        [NMS(Index = 333)]
        /* 0x3DA4 */ public float CreatureInteractionMinDist;
        [NMS(Index = 342)]
        /* 0x3DA8 */ public float CreatureInteractionPitchMax;
        [NMS(Index = 341)]
        /* 0x3DAC */ public float CreatureInteractionPitchMin;
        [NMS(Index = 340)]
        /* 0x3DB0 */ public float CreatureInteractionPitchSplit;
        [NMS(Index = 335)]
        /* 0x3DB4 */ public float CreatureInteractionPushCameraDownAmount;
        [NMS(Index = 334)]
        /* 0x3DB8 */ public float CreatureInteractionPushCameraDownForCreatureBiggerThan;
        [NMS(Index = 346)]
        /* 0x3DBC */ public float CreatureInteractionUphillPitchTransfer;
        [NMS(Index = 339)]
        /* 0x3DC0 */ public float CreatureInteractionYawMax;
        [NMS(Index = 338)]
        /* 0x3DC4 */ public float CreatureInteractionYawMin;
        [NMS(Index = 332)]
        /* 0x3DC8 */ public float CreatureSizeMax;
        [NMS(Index = 331)]
        /* 0x3DCC */ public float CreatureSizeMin;
        [NMS(Index = 258)]
        /* 0x3DD0 */ public float DebugAICamAt;
        [NMS(Index = 257)]
        /* 0x3DD4 */ public float DebugAICamUp;
        [NMS(Index = 284)]
        /* 0x3DD8 */ public float DebugCameraFastFactor;
        [NMS(Index = 286)]
        /* 0x3DDC */ public float DebugCameraHeightForAccelerateBegin;
        [NMS(Index = 288)]
        /* 0x3DE0 */ public float DebugCameraHeightForAccelerateEnd;
        [NMS(Index = 289)]
        /* 0x3DE4 */ public float DebugCameraMaxSpeed;
        [NMS(Index = 283)]
        /* 0x3DE8 */ public float DebugCameraSlowFactor;
        [NMS(Index = 285)]
        /* 0x3DEC */ public float DebugCameraSpaceFastFactor;
        [NMS(Index = 287)]
        /* 0x3DF0 */ public float DebugCameraSpeedAtPlanetThreshold;
        [NMS(Index = 255)]
        /* 0x3DF4 */ public float DebugMoveCamHeight;
        [NMS(Index = 254)]
        /* 0x3DF8 */ public float DebugMoveCamSpeed;
        [NMS(Index = 28)]
        /* 0x3DFC */ public float DebugPlanetJumpFarHeight;
        [NMS(Index = 27)]
        /* 0x3E00 */ public float DebugPlanetJumpNearHeight;
        [NMS(Index = 282)]
        /* 0x3E04 */ public float DebugSpaceStationTeleportOffset;
        [NMS(Index = 171)]
        /* 0x3E08 */ public float DistanceForFleetInteraction;
        [NMS(Index = 172)]
        /* 0x3E0C */ public float DistanceForFrigateInteraction;
        [NMS(Index = 173)]
        /* 0x3E10 */ public float DistanceForFrigatePurchaseInteraction;
        [NMS(Index = 306)]
        /* 0x3E14 */ public float FirstPersonCamHeight;
        [NMS(Index = 310)]
        /* 0x3E18 */ public float FirstPersonFoV;
        [NMS(Index = 264)]
        /* 0x3E1C */ public float FirstPersonSlerpAway;
        [NMS(Index = 265)]
        /* 0x3E20 */ public float FirstPersonSlerpTowards;
        [NMS(Index = 314)]
        /* 0x3E24 */ public float FirstPersonZoom1FoV;
        [NMS(Index = 315)]
        /* 0x3E28 */ public float FirstPersonZoom2FoV;
        [NMS(Index = 176)]
        /* 0x3E2C */ public float FleetUIOrbitRate;
        [NMS(Index = 178)]
        /* 0x3E30 */ public float FleetUIVerticalMotionAmplitude;
        [NMS(Index = 177)]
        /* 0x3E34 */ public float FleetUIVerticalMotionDuration;
        [NMS(Index = 55)]
        /* 0x3E38 */ public float FlybyInVehicleDamper;
        [NMS(Index = 51)]
        /* 0x3E3C */ public float FlybyMinRange;
        [NMS(Index = 53)]
        /* 0x3E40 */ public float FlybyMinRelativeSpeed;
        [NMS(Index = 52)]
        /* 0x3E44 */ public float FlybyRange;
        [NMS(Index = 54)]
        /* 0x3E48 */ public float FlybyRelativeSpeedRange;
        [NMS(Index = 3)]
        /* 0x3E4C */ public float FocusBuildingModeMaxFOV;
        [NMS(Index = 2)]
        /* 0x3E50 */ public float FocusBuildingModeMinFOV;
        [NMS(Index = 1)]
        /* 0x3E54 */ public float FocusBuildingModeStartDistance;
        [NMS(Index = 329)]
        /* 0x3E58 */ public float FoVAdjust;
        [NMS(Index = 326)]
        /* 0x3E5C */ public float FoVSpring;
        [NMS(Index = 327)]
        /* 0x3E60 */ public float FoVSpringSights;
        [NMS(Index = 328)]
        /* 0x3E64 */ public float FoVSpringSightsPassive;
        [NMS(Index = 165)]
        /* 0x3E68 */ public float FrigateCaptainLateralShiftAmount;
        [NMS(Index = 137)]
        /* 0x3E6C */ public float FrontendModelCameraSpringTime;
        [NMS(Index = 23)]
        /* 0x3E70 */ public float HmdEyeExtraTurnAngle;
        [NMS(Index = 25)]
        /* 0x3E74 */ public float HmdEyeExtraTurnHeadAngleRange;
        [NMS(Index = 24)]
        /* 0x3E78 */ public float HmdEyeExtraTurnMinHeadAngle;
        [NMS(Index = 22)]
        /* 0x3E7C */ public float HmdEyeLookAngle;
        [NMS(Index = 262)]
        /* 0x3E80 */ public float IndoorCamShakeDamper;
        [NMS(Index = 154)]
        /* 0x3E84 */ public float InteractionHeadHeightCronus;
        [NMS(Index = 153)]
        /* 0x3E88 */ public float InteractionHeadHeightDefault;
        [NMS(Index = 155)]
        /* 0x3E8C */ public float InteractionHeadHeightGek;
        [NMS(Index = 157)]
        /* 0x3E90 */ public float InteractionHeadHeightSpiderman;
        [NMS(Index = 156)]
        /* 0x3E94 */ public float InteractionHeadHeightVykeen;
        [NMS(Index = 161)]
        /* 0x3E98 */ public float InteractionHeadPosHeightAdjust;
        [NMS(Index = 164)]
        /* 0x3E9C */ public float InteractionHeadPosHeightAdjustCronus;
        [NMS(Index = 163)]
        /* 0x3EA0 */ public float InteractionHeadPosHeightAdjustSpiderman;
        [NMS(Index = 162)]
        /* 0x3EA4 */ public float InteractionHeadPosHeightAdjustVykeen;
        [NMS(Index = 181)]
        /* 0x3EA8 */ public float InteractionModeBlendTime;
        [NMS(Index = 182)]
        /* 0x3EAC */ public float InteractionModeFocusCamBlend;
        [NMS(Index = 183)]
        /* 0x3EB0 */ public float InteractionModeFoV;
        [NMS(Index = 160)]
        /* 0x3EB4 */ public float InteractionPitchAdjustDeadZone;
        [NMS(Index = 159)]
        /* 0x3EB8 */ public float InteractionPitchAdjustStrength;
        [NMS(Index = 158)]
        /* 0x3EBC */ public float InteractionPitchAdjustTime;
        [NMS(Index = 169)]
        /* 0x3EC0 */ public float LocalMissionBoardLateralShiftAmount;
        [NMS(Index = 60)]
        /* 0x3EC4 */ public float MaxCreatureRidingYaw;
        [NMS(Index = 59)]
        /* 0x3EC8 */ public float MaxFirstPersonCameraPitch;
        [NMS(Index = 84)]
        /* 0x3ECC */ public float MechCameraArmShootOffsetY;
        [NMS(Index = 85)]
        /* 0x3ED0 */ public float MechCameraCombatFakeSpeed;
        [NMS(Index = 83)]
        /* 0x3ED4 */ public float MechCameraExtraYPostLandingBlendTime;
        [NMS(Index = 82)]
        /* 0x3ED8 */ public float MechCameraNoExtraYTimeAfterLand;
        [NMS(Index = 224)]
        /* 0x3EDC */ public float MechCamSpringStrengthMax;
        [NMS(Index = 223)]
        /* 0x3EE0 */ public float MechCamSpringStrengthMin;
        [NMS(Index = 208)]
        /* 0x3EE4 */ public float MeleeBoostedFoV;
        [NMS(Index = 209)]
        /* 0x3EE8 */ public float MeleeFoV;
        [NMS(Index = 58)]
        /* 0x3EEC */ public float MinFirstPersonCameraPitch;
        [NMS(Index = 185)]
        /* 0x3EF0 */ public float MinInteractFocusAngle;
        [NMS(Index = 35)]
        /* 0x3EF4 */ public float MiniportalFlashStrength;
        [NMS(Index = 34)]
        /* 0x3EF8 */ public float MiniportalFlashTime;
        [NMS(Index = 251)]
        /* 0x3EFC */ public float ModelViewDefaultPitch;
        [NMS(Index = 252)]
        /* 0x3F00 */ public float ModelViewDefaultYaw;
        [NMS(Index = 248)]
        /* 0x3F04 */ public float ModelViewDistSpeed;
        [NMS(Index = 138)]
        /* 0x3F08 */ public float ModelViewFlashTime;
        [NMS(Index = 186)]
        /* 0x3F0C */ public float ModelViewInterpTime;
        [NMS(Index = 250)]
        /* 0x3F10 */ public float ModelViewMaxDist;
        [NMS(Index = 249)]
        /* 0x3F14 */ public float ModelViewMinDist;
        [NMS(Index = 247)]
        /* 0x3F18 */ public float ModelViewMouseMoveSpeed;
        [NMS(Index = 246)]
        /* 0x3F1C */ public float ModelViewMouseRotateSnapStrength;
        [NMS(Index = 245)]
        /* 0x3F20 */ public float ModelViewMouseRotateSpeed;
        [NMS(Index = 244)]
        /* 0x3F24 */ public float ModelViewRotateSpeed;
        [NMS(Index = 243)]
        /* 0x3F28 */ public float MouseSensitivity;
        [NMS(Index = 263)]
        /* 0x3F2C */ public float NoControlCamShakeDamper;
        [NMS(Index = 168)]
        /* 0x3F30 */ public float NPCTradeLateralShiftAmount;
        [NMS(Index = 170)]
        /* 0x3F34 */ public float NPCTradeLateralShiftTime;
        [NMS(Index = 293)]
        /* 0x3F38 */ public float ObjectFocusTime;
        [NMS(Index = 290)]
        /* 0x3F3C */ public float OffsetCamFOV;
        [NMS(Index = 12)]
        /* 0x3F40 */ public float OffsetCombatCameraHorizontalAngle;
        [NMS(Index = 260)]
        /* 0x3F44 */ public float PainShakeTime;
        [NMS(Index = 199)]
        /* 0x3F48 */ public float PhotoModeCollisionRadius;
        [NMS(Index = 201)]
        /* 0x3F4C */ public float PhotoModeFlashDuration;
        [NMS(Index = 202)]
        /* 0x3F50 */ public float PhotoModeFlashIntensity;
        [NMS(Index = 195)]
        /* 0x3F54 */ public float PhotoModeMaxDistance;
        [NMS(Index = 198)]
        /* 0x3F58 */ public float PhotoModeMaxDistanceClampBuffer;
        [NMS(Index = 197)]
        /* 0x3F5C */ public float PhotoModeMaxDistanceClampForce;
        [NMS(Index = 196)]
        /* 0x3F60 */ public float PhotoModeMaxDistanceSpace;
        [NMS(Index = 193)]
        /* 0x3F64 */ public float PhotoModeMoveSpeed;
        [NMS(Index = 200)]
        /* 0x3F68 */ public float PhotoModeRollSpeed;
        [NMS(Index = 194)]
        /* 0x3F6C */ public float PhotoModeTurnSpeed;
        [NMS(Index = 192)]
        /* 0x3F70 */ public float PhotoModeVelocitySmoothTime;
        [NMS(Index = 166)]
        /* 0x3F74 */ public float PilotDetailsLateralShiftAmount;
        [NMS(Index = 167)]
        /* 0x3F78 */ public float RecruitmentLateralShiftAmount;
        [NMS(Index = 19)]
        /* 0x3F7C */ public float RevealedNPCHeadOffset;
        [NMS(Index = 207)]
        /* 0x3F80 */ public float RunningFoVAdjust;
        [NMS(Index = 0)]
        /* 0x3F84 */ public float ScanCameraLookAtTime;
        [NMS(Index = 10)]
        /* 0x3F88 */ public float SClassLandingShakeMultiplier;
        [NMS(Index = 220)]
        /* 0x3F8C */ public float ScreenshotBackDistance;
        [NMS(Index = 218)]
        /* 0x3F90 */ public float ScreenshotBendDownAmount;
        [NMS(Index = 217)]
        /* 0x3F94 */ public float ScreenshotHorizonFaceFactor;
        [NMS(Index = 216)]
        /* 0x3F98 */ public float ScreenshotHorizonHeight;
        [NMS(Index = 221)]
        /* 0x3F9C */ public float ScreenshotInTime;
        [NMS(Index = 222)]
        /* 0x3FA0 */ public float ScreenshotOutTime;
        [NMS(Index = 219)]
        /* 0x3FA4 */ public float ScreenshotRightDistance;
        [NMS(Index = 184)]
        /* 0x3FA8 */ public float ShipBuilderFoV;
        [NMS(Index = 242)]
        /* 0x3FAC */ public float ShipCamAimFOV;
        [NMS(Index = 230)]
        /* 0x3FB0 */ public float ShipCamLookInterp;
        [NMS(Index = 231)]
        /* 0x3FB4 */ public float ShipCamMinReturnTime;
        [NMS(Index = 238)]
        /* 0x3FB8 */ public float ShipCamMotionInterp;
        [NMS(Index = 237)]
        /* 0x3FBC */ public float ShipCamMotionMaxLagPitchAngle;
        [NMS(Index = 236)]
        /* 0x3FC0 */ public float ShipCamMotionMaxLagTurnAngle;
        [NMS(Index = 234)]
        /* 0x3FC4 */ public float ShipCamMotionPitch;
        [NMS(Index = 235)]
        /* 0x3FC8 */ public float ShipCamMotionPitchMod;
        [NMS(Index = 233)]
        /* 0x3FCC */ public float ShipCamMotionTurn;
        [NMS(Index = 228)]
        /* 0x3FD0 */ public float ShipCamPitch;
        [NMS(Index = 229)]
        /* 0x3FD4 */ public float ShipCamPitchMod;
        [NMS(Index = 232)]
        /* 0x3FD8 */ public float ShipCamReturnTime;
        [NMS(Index = 240)]
        /* 0x3FDC */ public float ShipCamRollAmountMax;
        [NMS(Index = 239)]
        /* 0x3FE0 */ public float ShipCamRollAmountMin;
        [NMS(Index = 241)]
        /* 0x3FE4 */ public float ShipCamRollSpeedScaler;
        [NMS(Index = 226)]
        /* 0x3FE8 */ public float ShipCamSpringStrengthMax;
        [NMS(Index = 225)]
        /* 0x3FEC */ public float ShipCamSpringStrengthMin;
        [NMS(Index = 227)]
        /* 0x3FF0 */ public float ShipCamTurn;
        [NMS(Index = 48)]
        /* 0x3FF4 */ public float ShipFirstPersonBlendOffset;
        [NMS(Index = 47)]
        /* 0x3FF8 */ public float ShipFirstPersonBlendTime;
        [NMS(Index = 322)]
        /* 0x3FFC */ public float ShipFoVBoost;
        [NMS(Index = 318)]
        /* 0x4000 */ public float ShipFoVMax;
        [NMS(Index = 321)]
        /* 0x4004 */ public float ShipFoVMax3rdPerson;
        [NMS(Index = 316)]
        /* 0x4008 */ public float ShipFoVMin;
        [NMS(Index = 317)]
        /* 0x400C */ public float ShipFoVMin2;
        [NMS(Index = 320)]
        /* 0x4010 */ public float ShipFoVMin3rdPerson;
        [NMS(Index = 323)]
        /* 0x4014 */ public float ShipFoVMiniJump;
        [NMS(Index = 324)]
        /* 0x4018 */ public float ShipFoVSpring;
        [NMS(Index = 325)]
        /* 0x401C */ public float ShipMiniJumpFoVSpring;
        [NMS(Index = 261)]
        /* 0x4020 */ public float ShipShakeDamper;
        [NMS(Index = 44)]
        /* 0x4024 */ public float ShipThirdPersonBlendOffset;
        [NMS(Index = 46)]
        /* 0x4028 */ public float ShipThirdPersonBlendOutOffset;
        [NMS(Index = 45)]
        /* 0x402C */ public float ShipThirdPersonBlendOutTime;
        [NMS(Index = 42)]
        /* 0x4030 */ public float ShipThirdPersonBlendTime;
        [NMS(Index = 43)]
        /* 0x4034 */ public float ShipThirdPersonBlendWithOffsetTime;
        [NMS(Index = 50)]
        /* 0x4038 */ public float ShipThirdPersonEnterBlendOffset;
        [NMS(Index = 49)]
        /* 0x403C */ public float ShipThirdPersonEnterBlendTime;
        [NMS(Index = 319)]
        /* 0x4040 */ public float ShipWarpFoV;
        [NMS(Index = 20)]
        /* 0x4044 */ public float SpecialVehicleMouseRecentreTime;
        [NMS(Index = 21)]
        /* 0x4048 */ public float SpecialVehicleMouseRecentreWeaponTime;
        [NMS(Index = 32)]
        /* 0x404C */ public float ThirdPersonAfterIntroCamBlendTime;
        [NMS(Index = 187)]
        /* 0x4050 */ public float ThirdPersonBlendInTime;
        [NMS(Index = 188)]
        /* 0x4054 */ public float ThirdPersonBlendOutTime;
        [NMS(Index = 115)]
        /* 0x4058 */ public float ThirdPersonCameraChangeBlendTime;
        [NMS(Index = 116)]
        /* 0x405C */ public float ThirdPersonCameraChangeMinimumBlend;
        [NMS(Index = 63)]
        /* 0x4060 */ public float ThirdPersonCloseDistance;
        [NMS(Index = 64)]
        /* 0x4064 */ public float ThirdPersonCloseDistanceX;
        [NMS(Index = 62)]
        /* 0x4068 */ public float ThirdPersonClosePitch;
        [NMS(Index = 189)]
        /* 0x406C */ public float ThirdPersonCollisionPushOffsetReducerStart;
        [NMS(Index = 313)]
        /* 0x4070 */ public float ThirdPersonCombatFoV;
        [NMS(Index = 71)]
        /* 0x4074 */ public float ThirdPersonDownhillAdjustMaxAngle;
        [NMS(Index = 75)]
        /* 0x4078 */ public float ThirdPersonDownhillAdjustMaxAnglePrime;
        [NMS(Index = 70)]
        /* 0x407C */ public float ThirdPersonDownhillAdjustMinAngle;
        [NMS(Index = 74)]
        /* 0x4080 */ public float ThirdPersonDownhillAdjustMinAnglePrime;
        [NMS(Index = 69)]
        /* 0x4084 */ public float ThirdPersonDownhillAdjustSpringTimeMax;
        [NMS(Index = 68)]
        /* 0x4088 */ public float ThirdPersonDownhillAdjustSpringTimeMin;
        [NMS(Index = 311)]
        /* 0x408C */ public float ThirdPersonFoV;
        [NMS(Index = 190)]
        /* 0x4090 */ public float ThirdPersonOffsetSpringTime;
        [NMS(Index = 65)]
        /* 0x4094 */ public float ThirdPersonRotationBackAdjustAngleMax;
        [NMS(Index = 61)]
        /* 0x4098 */ public float ThirdPersonRotationBackAdjustAngleMin;
        [NMS(Index = 33)]
        /* 0x409C */ public float ThirdPersonSkipIntroCamBlendTime;
        [NMS(Index = 79)]
        /* 0x40A0 */ public float ThirdPersonUphillAdjustCrossSlopeMaxAngle;
        [NMS(Index = 78)]
        /* 0x40A4 */ public float ThirdPersonUphillAdjustCrossSlopeMinAngle;
        [NMS(Index = 73)]
        /* 0x40A8 */ public float ThirdPersonUphillAdjustMaxAngle;
        [NMS(Index = 77)]
        /* 0x40AC */ public float ThirdPersonUphillAdjustMaxAnglePrime;
        [NMS(Index = 72)]
        /* 0x40B0 */ public float ThirdPersonUphillAdjustMinAngle;
        [NMS(Index = 76)]
        /* 0x40B4 */ public float ThirdPersonUphillAdjustMinAnglePrime;
        [NMS(Index = 67)]
        /* 0x40B8 */ public float ThirdPersonUphillAdjustSpringTimeMax;
        [NMS(Index = 66)]
        /* 0x40BC */ public float ThirdPersonUphillAdjustSpringTimeMin;
        [NMS(Index = 29)]
        /* 0x40C0 */ public float TogglePerspectiveBlendTime;
        [NMS(Index = 31)]
        /* 0x40C4 */ public float UnderwaterCameraExtraVertOffset;
        [NMS(Index = 38)]
        /* 0x40C8 */ public float VehicleExitFlashStrength;
        [NMS(Index = 37)]
        /* 0x40CC */ public float VehicleExitFlashTime;
        [NMS(Index = 312)]
        /* 0x40D0 */ public float VehicleFirstPersonFoV;
        [NMS(Index = 40)]
        /* 0x40D4 */ public float VehicleFirstToThirdExitOffsetY;
        [NMS(Index = 41)]
        /* 0x40D8 */ public float VehicleFirstToThirdExitOffsetZ;
        [NMS(Index = 81)]
        /* 0x40DC */ public float VehicleThirdPersonShootOffsetBlendOutTime;
        [NMS(Index = 80)]
        /* 0x40E0 */ public float VehicleThirdPersonShootOffsetReturnTime;
        [NMS(Index = 259)]
        /* 0x40E4 */ public float VRShakeMultiplier;
        [NMS(Index = 215)]
        /* 0x40E8 */ public TkCurveType AerialViewCurve;
        [NMS(Index = 330)]
        /* 0x40E9 */ public bool CreatureInteractionInterpolateDuringHold;
        [NMS(Index = 256)]
        /* 0x40EA */ public bool DebugAICam;
        [NMS(Index = 253)]
        /* 0x40EB */ public bool DebugMoveCam;
        [NMS(Index = 352)]
        /* 0x40EC */ public bool FollowDrawCamProbes;
        [NMS(Index = 30)]
        /* 0x40ED */ public bool LockFollowSpring;
        [NMS(Index = 191)]
        /* 0x40EE */ public bool MaxBob;
        [NMS(Index = 11)]
        /* 0x40EF */ public bool OffsetCombatCameraHorizontal;
        [NMS(Index = 26)]
        /* 0x40F0 */ public bool PauseThirdPersonCamInPause;
    }
}
