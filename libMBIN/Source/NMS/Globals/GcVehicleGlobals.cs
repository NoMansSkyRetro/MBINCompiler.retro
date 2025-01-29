using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xCE0C56502150A165, NameHash = 0x6C7923EF)]
    public class GcVehicleGlobals : NMSTemplate
    {
        [NMS(Index = 232)]
        /* 0x000 */ public Colour CheckpointBeamColourActive;
        [NMS(Index = 233)]
        /* 0x010 */ public Colour CheckpointBeamColourNormal;
        [NMS(Index = 34)]
        /* 0x020 */ public Colour DefaultBoosterColour;
        [NMS(Index = 68)]
        /* 0x030 */ public Vector3f MechCrouchOffset;
        [NMS(Index = 69)]
        /* 0x040 */ public Vector3f MechWalkBackwardsCoGOffset;
        [NMS(Index = 157, Size = 0x5, EnumType = typeof(GcVehicleWeaponMode.VehicleWeaponModeEnum))]
        /* 0x050 */ public GcExoMechWeaponData[] MechWeaponData;
        [NMS(Index = 286, Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x2D0 */ public GcVehicleMuzzleData[] VehicleWeaponMuzzleFlash;
        [NMS(Index = 158)]
        /* 0x500 */ public GcMechMeshPartTable MechMeshPartsTable;
        [NMS(Index = 141)]
        /* 0x6E0 */ public GcMechAudioEventTable MechAudioEventTable;
        [NMS(Index = 10)]
        /* 0x800 */ public NMSString0x20A BugMechRightArmTechNameOverride;
        [NMS(Index = 9)]
        /* 0x820 */ public NMSString0x20A SentinelRightArmTechNameOverride;
        [NMS(Index = 8)]
        /* 0x840 */ public NMSString0x10 BugMechLeftArmTech;
        [NMS(Index = 7)]
        /* 0x850 */ public NMSString0x10 BugMechRightArmTech;
        [NMS(Index = 235)]
        /* 0x860 */ public List<NMSString0x10> DefaultBikeLoadout;
        [NMS(Index = 234)]
        /* 0x870 */ public List<NMSString0x10> DefaultBuggyLoadout;
        [NMS(Index = 236)]
        /* 0x880 */ public List<NMSString0x10> DefaultTruckLoadout;
        [NMS(Index = 59)]
        /* 0x890 */ public NMSString0x10 MechArmPitchAnimLeft;
        [NMS(Index = 60)]
        /* 0x8A0 */ public NMSString0x10 MechArmPitchAnimRight;
        [NMS(Index = 50)]
        /* 0x8B0 */ public NMSString0x10 MechJetpackEffect;
        [NMS(Index = 51)]
        /* 0x8C0 */ public NMSString0x10 MechJetpackLaunchEffect;
        [NMS(Index = 52)]
        /* 0x8D0 */ public NMSString0x10 MechJetpackLaunchGroundEffect;
        [NMS(Index = 49)]
        /* 0x8E0 */ public NMSString0x10 MechLandingImpactEffect;
        [NMS(Index = 4)]
        /* 0x8F0 */ public NMSString0x10 MechStrongLaser;
        [NMS(Index = 6)]
        /* 0x900 */ public NMSString0x10 SentinelLeftArmTech;
        [NMS(Index = 5)]
        /* 0x910 */ public NMSString0x10 SentinelRightArmTech;
        [NMS(Index = 11)]
        /* 0x920 */ public NMSString0x10 SentinelRightLeftArmLaserData;
        [NMS(Index = 187)]
        /* 0x930 */ public List<Vector3f> UnderwaterBubbleOffset;
        [NMS(Index = 288)]
        /* 0x940 */ public List<GcVehicleData> VehicleDataTable;
        [NMS(Index = 285)]
        /* 0x950 */ public NMSString0x10 VehicleLocalScan;
        [NMS(Index = 284)]
        /* 0x960 */ public NMSString0x10 VehicleScan;
        [NMS(Index = 3)]
        /* 0x970 */ public NMSString0x10 VehicleStrongLaser;
        [NMS(Index = 287)]
        /* 0x980 */ public List<GcVehicleWeaponMuzzleData> VehicleWeaponMuzzleDataTable;
        [NMS(Index = 186)]
        /* 0x990 */ public GcSpaceshipAvoidanceData UnderwaterAvoidance;
        [NMS(Index = 37)]
        /* 0x9B4 */ public Vector2f MechLookStickSpeedLimit;
        [NMS(Index = 36)]
        /* 0x9BC */ public Vector2f MechMovementStickSpeedLimit;
        [NMS(Index = 148)]
        /* 0x9C4 */ public float AIMechFlamethrowerFireInterval;
        [NMS(Index = 152)]
        /* 0x9C8 */ public int AIMechFlamethrowerNumShotsMax;
        [NMS(Index = 151)]
        /* 0x9CC */ public int AIMechFlamethrowerNumShotsMin;
        [NMS(Index = 153)]
        /* 0x9D0 */ public float AIMechGunExplosionRadius;
        [NMS(Index = 144)]
        /* 0x9D4 */ public float AIMechGunFireInterval;
        [NMS(Index = 154)]
        /* 0x9D8 */ public float AIMechGunInheritVelocity;
        [NMS(Index = 146)]
        /* 0x9DC */ public int AIMechGunNumShotsMax;
        [NMS(Index = 145)]
        /* 0x9E0 */ public int AIMechGunNumShotsMin;
        [NMS(Index = 143)]
        /* 0x9E4 */ public float AIMechLaserFireDurationMax;
        [NMS(Index = 142)]
        /* 0x9E8 */ public float AIMechLaserFireDurationMin;
        [NMS(Index = 147)]
        /* 0x9EC */ public float AIMechStunGunFireInterval;
        [NMS(Index = 150)]
        /* 0x9F0 */ public int AIMechStunGunNumShotsMax;
        [NMS(Index = 149)]
        /* 0x9F4 */ public int AIMechStunGunNumShotsMin;
        [NMS(Index = 219)]
        /* 0x9F8 */ public float AttractAlign;
        [NMS(Index = 217)]
        /* 0x9FC */ public float AttractAmount;
        [NMS(Index = 220)]
        /* 0xA00 */ public float AttractDirectionBrakeThresholdSq;
        [NMS(Index = 218)]
        /* 0xA04 */ public float AttractMaxSpeed;
        [NMS(Index = 200)]
        /* 0xA08 */ public float BoostPadStrength;
        [NMS(Index = 199)]
        /* 0xA0C */ public float BoostPadTime;
        [NMS(Index = 239)]
        /* 0xA10 */ public float CheckpointBeamOffset;
        [NMS(Index = 238)]
        /* 0xA14 */ public float CheckpointBeamSizeActive;
        [NMS(Index = 237)]
        /* 0xA18 */ public float CheckpointBeamSizeNormal;
        [NMS(Index = 198)]
        /* 0xA1C */ public float CheckpointDeleteAngle;
        [NMS(Index = 197)]
        /* 0xA20 */ public float CheckpointDeleteDistance;
        [NMS(Index = 230)]
        /* 0xA24 */ public float CheckpointFlashDuration;
        [NMS(Index = 231)]
        /* 0xA28 */ public float CheckpointFlashIntensity;
        [NMS(Index = 195)]
        /* 0xA2C */ public float CheckpointPlacementOffset;
        [NMS(Index = 196)]
        /* 0xA30 */ public float CheckpointPlacementRayLength;
        [NMS(Index = 225)]
        /* 0xA34 */ public float CheckpointRadius;
        [NMS(Index = 15)]
        /* 0xA38 */ public float ControlStickRecenterSpeedDegPerSec;
        [NMS(Index = 39)]
        /* 0xA3C */ public float DamageTechMinHitIntervalSeconds;
        [NMS(Index = 38)]
        /* 0xA40 */ public int DamageTechNumHitsRequired;
        [NMS(Index = 201)]
        /* 0xA44 */ public float DisablePhysicsRange;
        [NMS(Index = 222)]
        /* 0xA48 */ public float ExitStopForce;
        [NMS(Index = 221)]
        /* 0xA4C */ public float ExitStopTime;
        [NMS(Index = 164)]
        /* 0xA50 */ public float FirstPersonSteeringAdditionalForward;
        [NMS(Index = 165)]
        /* 0xA54 */ public float FirstPersonSteeringAdditionalForwardThreshold;
        [NMS(Index = 166)]
        /* 0xA58 */ public float FirstPersonSteeringAdditionalReverseThreshold;
        [NMS(Index = 168)]
        /* 0xA5C */ public float FirstPersonSteeringLowSpeedTurnDamping;
        [NMS(Index = 167)]
        /* 0xA60 */ public float FirstPersonSteeringMinThrottleHardLeftRight;
        [NMS(Index = 246)]
        /* 0xA64 */ public int GunBaseDamage;
        [NMS(Index = 249)]
        /* 0xA68 */ public int GunBaseMiningDamage;
        [NMS(Index = 223)]
        /* 0xA6C */ public float GunFireRate;
        [NMS(Index = 188)]
        /* 0xA70 */ public float HeadlightIntensitySpringTime;
        [NMS(Index = 215)]
        /* 0xA74 */ public float HornScareFleeRadius;
        [NMS(Index = 214)]
        /* 0xA78 */ public float HornScareRadius;
        [NMS(Index = 216)]
        /* 0xA7C */ public float HornScareTime;
        [NMS(Index = 13)]
        /* 0xA80 */ public float LevelVehicleCameraFactor;
        [NMS(Index = 54)]
        /* 0xA84 */ public float MechAIGroundTurnSpeed;
        [NMS(Index = 42)]
        /* 0xA88 */ public float MechAIResummonMinSpawnDistance;
        [NMS(Index = 43)]
        /* 0xA8C */ public float MechAIResummonMinSpeedForVelBasedSpawnPos;
        [NMS(Index = 41)]
        /* 0xA90 */ public float MechAIResummonTriggerDistance;
        [NMS(Index = 44)]
        /* 0xA94 */ public float MechAIResummonVelBasedSpawnSpeedMultiplier;
        [NMS(Index = 57)]
        /* 0xA98 */ public float MechArmPitchAngleMax;
        [NMS(Index = 56)]
        /* 0xA9C */ public float MechArmPitchAngleMin;
        [NMS(Index = 58)]
        /* 0xAA0 */ public float MechArmPitchLerpSpeed;
        [NMS(Index = 79)]
        /* 0xAA4 */ public float MechArmSwingAngleFastWalk;
        [NMS(Index = 76)]
        /* 0xAA8 */ public float MechArmSwingAngleWalk;
        [NMS(Index = 80)]
        /* 0xAAC */ public float MechArmSwingPhaseFastWalk;
        [NMS(Index = 77)]
        /* 0xAB0 */ public float MechArmSwingPhaseWalk;
        [NMS(Index = 97)]
        /* 0xAB4 */ public float MechCameraOffsetAmount;
        [NMS(Index = 96)]
        /* 0xAB8 */ public float MechCameraOffsetTime;
        [NMS(Index = 127)]
        /* 0xABC */ public float MechCockPitBobPitch;
        [NMS(Index = 128)]
        /* 0xAC0 */ public float MechCockPitBobRoll;
        [NMS(Index = 125)]
        /* 0xAC4 */ public float MechCockPitBobX;
        [NMS(Index = 126)]
        /* 0xAC8 */ public float MechCockPitBobY;
        [NMS(Index = 129)]
        /* 0xACC */ public float MechCockPitBobYaw;
        [NMS(Index = 130)]
        /* 0xAD0 */ public float MechCockPowerDownY;
        [NMS(Index = 71)]
        /* 0xAD4 */ public float MechCoGAdjustTimeAir;
        [NMS(Index = 72)]
        /* 0xAD8 */ public float MechCoGAdjustTimeLand;
        [NMS(Index = 70)]
        /* 0xADC */ public float MechCoGAdjustTimeWindUp;
        [NMS(Index = 47)]
        /* 0xAE0 */ public float MechContrailAlpha;
        [NMS(Index = 73)]
        /* 0xAE4 */ public float MechCrouchTime;
        [NMS(Index = 100)]
        /* 0xAE8 */ public float MechDefaultBlendTime;
        [NMS(Index = 123)]
        /* 0xAEC */ public float MechFirstPersonCrouchAmount;
        [NMS(Index = 119)]
        /* 0xAF0 */ public float MechFirstPersonDamping;
        [NMS(Index = 114)]
        /* 0xAF4 */ public float MechFirstPersonIgnoreReverseThreshold;
        [NMS(Index = 122)]
        /* 0xAF8 */ public float MechFirstPersonMaxLookTurret;
        [NMS(Index = 121)]
        /* 0xAFC */ public float MechFirstPersonMaxTurnTurret;
        [NMS(Index = 120)]
        /* 0xB00 */ public float MechFirstPersonStickXModerator;
        [NMS(Index = 118)]
        /* 0xB04 */ public float MechFirstPersonTurretAngleThrottleStrength;
        [NMS(Index = 117)]
        /* 0xB08 */ public float MechFirstPersonTurretAngleThrottleThreshold;
        [NMS(Index = 113)]
        /* 0xB0C */ public float MechFirstPersonTurretBaseThrottleThreshold;
        [NMS(Index = 116)]
        /* 0xB10 */ public float MechFirstPersonTurretBaseTurnThreshold;
        [NMS(Index = 110)]
        /* 0xB14 */ public float MechFirstPersonTurretPitchModerator;
        [NMS(Index = 112)]
        /* 0xB18 */ public float MechFirstPersonTurretShootTimer;
        [NMS(Index = 115)]
        /* 0xB1C */ public float MechFirstPersonTurretThrottleLookThreshold;
        [NMS(Index = 109)]
        /* 0xB20 */ public float MechFirstPersonTurretTurnModerator;
        [NMS(Index = 140)]
        /* 0xB24 */ public float MechFootprintFadeDist;
        [NMS(Index = 139)]
        /* 0xB28 */ public float MechFootprintFadeTime;
        [NMS(Index = 106)]
        /* 0xB2C */ public float MechIdleLowBlendTime;
        [NMS(Index = 107)]
        /* 0xB30 */ public float MechIdleLowDelay;
        [NMS(Index = 108)]
        /* 0xB34 */ public float MechIdleStopDelay;
        [NMS(Index = 90)]
        /* 0xB38 */ public float MechJetpackAvoidGroundForce;
        [NMS(Index = 92)]
        /* 0xB3C */ public float MechJetpackAvoidGroundProbeLength;
        [NMS(Index = 86)]
        /* 0xB40 */ public float MechJetpackBrake;
        [NMS(Index = 98)]
        /* 0xB44 */ public float MechJetpackDrainRate;
        [NMS(Index = 91)]
        /* 0xB48 */ public float MechJetpackFallForce;
        [NMS(Index = 99)]
        /* 0xB4C */ public float MechJetpackFillRate;
        [NMS(Index = 85)]
        /* 0xB50 */ public float MechJetpackForce;
        [NMS(Index = 93)]
        /* 0xB54 */ public float MechJetpackIgnitionForce;
        [NMS(Index = 94)]
        /* 0xB58 */ public float MechJetpackIgnitionTime;
        [NMS(Index = 48)]
        /* 0xB5C */ public float MechJetpackJetScaleTime;
        [NMS(Index = 84)]
        /* 0xB60 */ public float MechJetpackLandTime;
        [NMS(Index = 95)]
        /* 0xB64 */ public float MechJetpackMaxCoGAdjustX;
        [NMS(Index = 87)]
        /* 0xB68 */ public float MechJetpackMaxSpeed;
        [NMS(Index = 88)]
        /* 0xB6C */ public float MechJetpackMaxUpSpeed;
        [NMS(Index = 83)]
        /* 0xB70 */ public float MechJetpackStrafeStrength;
        [NMS(Index = 55)]
        /* 0xB74 */ public float MechJetpackTurnSpeed;
        [NMS(Index = 89)]
        /* 0xB78 */ public float MechJetpackUpForce;
        [NMS(Index = 103)]
        /* 0xB7C */ public float MechJumpBlendTime;
        [NMS(Index = 105)]
        /* 0xB80 */ public float MechJumpDownBlendTime;
        [NMS(Index = 104)]
        /* 0xB84 */ public float MechJumpFlyBlendTime;
        [NMS(Index = 102)]
        /* 0xB88 */ public float MechLandBlendTime;
        [NMS(Index = 82)]
        /* 0xB8C */ public float MechLandBrake;
        [NMS(Index = 138)]
        /* 0xB90 */ public float MechLandCameraShakeDist;
        [NMS(Index = 61)]
        /* 0xB94 */ public float MechMaxTurnAngleWhileStationary;
        [NMS(Index = 53)]
        /* 0xB98 */ public float MechPlayerGroundTurnSpeed;
        [NMS(Index = 124)]
        /* 0xB9C */ public float MechPowerUpTime;
        [NMS(Index = 241)]
        /* 0xBA0 */ public float MechSpawnRotation;
        [NMS(Index = 101)]
        /* 0xBA4 */ public float MechSpeedBlendTime;
        [NMS(Index = 137)]
        /* 0xBA8 */ public float MechTitanFallCameraShakeDist;
        [NMS(Index = 131)]
        /* 0xBAC */ public float MechTitanFallHeight;
        [NMS(Index = 135)]
        /* 0xBB0 */ public float MechTitanFallLandIdleTime;
        [NMS(Index = 136)]
        /* 0xBB4 */ public float MechTitanFallLandIntroTime;
        [NMS(Index = 134)]
        /* 0xBB8 */ public float MechTitanFallTerrainEditOffset;
        [NMS(Index = 133)]
        /* 0xBBC */ public float MechTitanFallTerrainEditSize;
        [NMS(Index = 66)]
        /* 0xBC0 */ public float MechTurretMaxAngleAir;
        [NMS(Index = 63)]
        /* 0xBC4 */ public float MechTurretMaxAngleGround;
        [NMS(Index = 67)]
        /* 0xBC8 */ public float MechTurretTimeVRModifier;
        [NMS(Index = 65)]
        /* 0xBCC */ public float MechTurretTurnTimeAir;
        [NMS(Index = 62)]
        /* 0xBD0 */ public float MechTurretTurnTimeGround;
        [NMS(Index = 64)]
        /* 0xBD4 */ public float MechTurretTurnTimeGroundPlayerCombat;
        [NMS(Index = 74)]
        /* 0xBD8 */ public float MechWalkToRunTimeIdle;
        [NMS(Index = 75)]
        /* 0xBDC */ public float MechWalkToRunTimeSkid;
        [NMS(Index = 155)]
        /* 0xBE0 */ public float MechWeaponInterpSpeed;
        [NMS(Index = 244)]
        /* 0xBE4 */ public int MiningLaserDamage;
        [NMS(Index = 204)]
        /* 0xBE8 */ public float MiningLaserDrainSpeed;
        [NMS(Index = 243)]
        /* 0xBEC */ public int MiningLaserMiningDamage;
        [NMS(Index = 242)]
        /* 0xBF0 */ public float MiningLaserRadius;
        [NMS(Index = 245)]
        /* 0xBF4 */ public float MiningLaserSpeed;
        [NMS(Index = 205)]
        /* 0xBF8 */ public float ProjectileDrainPerShot;
        [NMS(Index = 226)]
        /* 0xBFC */ public float RaceCooldown;
        [NMS(Index = 207)]
        /* 0xC00 */ public float RaceInteractRespawnOffset;
        [NMS(Index = 208)]
        /* 0xC04 */ public float RaceInteractRespawnUpOffset;
        [NMS(Index = 203)]
        /* 0xC08 */ public float RaceMultipleStartCaptureRange;
        [NMS(Index = 202)]
        /* 0xC0C */ public float RaceMultipleStartOffset;
        [NMS(Index = 228)]
        /* 0xC10 */ public float RaceResetFlashDuration;
        [NMS(Index = 229)]
        /* 0xC14 */ public float RaceResetFlashIntensity;
        [NMS(Index = 206)]
        /* 0xC18 */ public float RaceStartSpawnUpOffset;
        [NMS(Index = 22)]
        /* 0xC1C */ public float RemoteBoostingEffectTimeout;
        [NMS(Index = 250)]
        /* 0xC20 */ public float ResourceCollectOffset;
        [NMS(Index = 240)]
        /* 0xC24 */ public float SpawnRotation;
        [NMS(Index = 20)]
        /* 0xC28 */ public float SteeringWheelCentreOffset;
        [NMS(Index = 17)]
        /* 0xC2C */ public float SteeringWheelPitchAngle;
        [NMS(Index = 16)]
        /* 0xC30 */ public float SteeringWheelPushRange;
        [NMS(Index = 18)]
        /* 0xC34 */ public float SteeringWheelSpringBothHands;
        [NMS(Index = 19)]
        /* 0xC38 */ public float SteeringWheelSpringOneHand;
        [NMS(Index = 283)]
        /* 0xC3C */ public float StickReverseTurnStiffness;
        [NMS(Index = 282)]
        /* 0xC40 */ public float StickReverseTurnThreshold;
        [NMS(Index = 209)]
        /* 0xC44 */ public float StickTurnReducer;
        [NMS(Index = 212)]
        /* 0xC48 */ public float StickTurnReducerAltNonVR;
        [NMS(Index = 211)]
        /* 0xC4C */ public float StickTurnReducerVR;
        [NMS(Index = 210)]
        /* 0xC50 */ public float StickTurnReducerWater;
        [NMS(Index = 247)]
        /* 0xC54 */ public int StunGunBaseDamage;
        [NMS(Index = 248)]
        /* 0xC58 */ public float StunGunFireRate;
        [NMS(Index = 162)]
        /* 0xC5C */ public float SubmarineEjectDownOffset;
        [NMS(Index = 161)]
        /* 0xC60 */ public float SubmarineEjectRadius;
        [NMS(Index = 163)]
        /* 0xC64 */ public float SubmarineFirstPersonSteeringSensitivity;
        [NMS(Index = 160)]
        /* 0xC68 */ public float SubmarineMinSummonDepth;
        [NMS(Index = 224)]
        /* 0xC6C */ public float SummoningRange;
        [NMS(Index = 254)]
        /* 0xC70 */ public float SuspensionDamping;
        [NMS(Index = 255)]
        /* 0xC74 */ public float SuspensionDampingAngularFactor;
        [NMS(Index = 27)]
        /* 0xC78 */ public float TestAnimBoost;
        [NMS(Index = 26)]
        /* 0xC7C */ public float TestAnimThrust;
        [NMS(Index = 28)]
        /* 0xC80 */ public float TestAnimTurn;
        [NMS(Index = 23)]
        /* 0xC84 */ public float TestFrictionStat;
        [NMS(Index = 24)]
        /* 0xC88 */ public float TestSkidFrictionStat;
        [NMS(Index = 213)]
        /* 0xC8C */ public float TravelSpeedReportReducer;
        [NMS(Index = 171)]
        /* 0xC90 */ public float UnderwaterBuoyancyRangeMax;
        [NMS(Index = 170)]
        /* 0xC94 */ public float UnderwaterBuoyancyRangeMin;
        [NMS(Index = 175)]
        /* 0xC98 */ public float UnderwaterBuoyancyRiseTime;
        [NMS(Index = 169)]
        /* 0xC9C */ public float UnderwaterBuoyancySurfaceOffset;
        [NMS(Index = 185)]
        /* 0xCA0 */ public float UnderwaterDiveForce;
        [NMS(Index = 178)]
        /* 0xCA4 */ public float UnderwaterFlattenMinDepth;
        [NMS(Index = 179)]
        /* 0xCA8 */ public float UnderwaterFlattenRange;
        [NMS(Index = 184)]
        /* 0xCAC */ public float UnderwaterJumpForce;
        [NMS(Index = 173)]
        /* 0xCB0 */ public float UnderwaterMaxSpeedAddedByBuoyancy;
        [NMS(Index = 1)]
        /* 0xCB4 */ public float UnderwaterScannerIconRangeBoost;
        [NMS(Index = 174)]
        /* 0xCB8 */ public float UnderwaterSummonSurfaceOffset;
        [NMS(Index = 180)]
        /* 0xCBC */ public float UnderwaterSurfaceForceFlatteningAngleMin;
        [NMS(Index = 181)]
        /* 0xCC0 */ public float UnderwaterSurfaceForceFlatteningAngleRange;
        [NMS(Index = 177)]
        /* 0xCC4 */ public float UnderwaterSurfaceGravity;
        [NMS(Index = 176)]
        /* 0xCC8 */ public float UnderwaterSurfaceOffset;
        [NMS(Index = 182)]
        /* 0xCCC */ public float UnderwaterSurfaceSplashdownForce;
        [NMS(Index = 183)]
        /* 0xCD0 */ public float UnderwaterSurfaceSplashdownMinSpeed;
        [NMS(Index = 190)]
        /* 0xCD4 */ public float VehicleAltControlStickSmoothInTime;
        [NMS(Index = 191)]
        /* 0xCD8 */ public float VehicleAltControlStickSmoothOutTime;
        [NMS(Index = 272)]
        /* 0xCDC */ public float VehicleBoostFuelRate;
        [NMS(Index = 273)]
        /* 0xCE0 */ public float VehicleBoostFuelRateSurvival;
        [NMS(Index = 192)]
        /* 0xCE4 */ public float VehicleBoostSpeedMultiplierPercent;
        [NMS(Index = 0)]
        /* 0xCE8 */ public float VehicleCollisionScaleFactor;
        [NMS(Index = 271)]
        /* 0xCEC */ public float VehicleDeactivateRange;
        [NMS(Index = 267)]
        /* 0xCF0 */ public float VehicleFadeTime;
        [NMS(Index = 274)]
        /* 0xCF4 */ public float VehicleFuelRate;
        [NMS(Index = 275)]
        /* 0xCF8 */ public float VehicleFuelRateTruckMultiplier;
        [NMS(Index = 194)]
        /* 0xCFC */ public float VehicleGarageHologramFadeRange;
        [NMS(Index = 193)]
        /* 0xD00 */ public float VehicleGarageHologramMinFadeRange;
        [NMS(Index = 278)]
        /* 0xD04 */ public float VehicleJumpCooldown;
        [NMS(Index = 277)]
        /* 0xD08 */ public float VehicleJumpTimeMax;
        [NMS(Index = 276)]
        /* 0xD0C */ public float VehicleJumpTimeMin;
        [NMS(Index = 269)]
        /* 0xD10 */ public float VehicleMaxSummonDistance;
        [NMS(Index = 270)]
        /* 0xD14 */ public float VehicleMaxSummonDistanceUnderwater;
        [NMS(Index = 268)]
        /* 0xD18 */ public float VehicleMinSummonDistance;
        [NMS(Index = 279)]
        /* 0xD1C */ public float VehicleMotionDeadZone;
        [NMS(Index = 2)]
        /* 0xD20 */ public float VehicleSolarRegenFactor;
        [NMS(Index = 264)]
        /* 0xD24 */ public float VehicleSuspensionAudioDelay;
        [NMS(Index = 265)]
        /* 0xD28 */ public float VehicleSuspensionAudioScale;
        [NMS(Index = 263)]
        /* 0xD2C */ public float VehicleSuspensionAudioSpacing;
        [NMS(Index = 266)]
        /* 0xD30 */ public float VehicleSuspensionAudioTrigger;
        [NMS(Index = 260)]
        /* 0xD34 */ public float VehicleTextSize;
        [NMS(Index = 251)]
        /* 0xD38 */ public float VehicleWheelNoise;
        [NMS(Index = 252)]
        /* 0xD3C */ public float VehicleWheelNoiseScale;
        [NMS(Index = 32)]
        /* 0xD40 */ public float VignetteAmountAcceleration;
        [NMS(Index = 33)]
        /* 0xD44 */ public float VignetteAmountTurning;
        [NMS(Index = 30)]
        /* 0xD48 */ public float VisualRollUnderwaterSpring;
        [NMS(Index = 31)]
        /* 0xD4C */ public float VisualTurnSpring;
        [NMS(Index = 29)]
        /* 0xD50 */ public float VisualTurnUnderwaterSpring;
        [NMS(Index = 159)]
        /* 0xD54 */ public float WeaponInterpSpeed;
        [NMS(Index = 35)]
        /* 0xD58 */ public float WheelDustColourLightFactor;
        [NMS(Index = 280)]
        /* 0xD5C */ public float WheelForceHalflife;
        [NMS(Index = 253)]
        /* 0xD60 */ public float WheelSideVerticalFactor;
        [NMS(Index = 156, Size = 0x5, EnumType = typeof(GcMechWeaponLocation.MechWeaponLocationEnum))]
        /* 0xD64 */ public NMSString0x20[] MechWeaponLocatorNames;
        [NMS(Index = 46)]
        /* 0xE04 */ public bool MechAltJumpMode;
        [NMS(Index = 81)]
        /* 0xE05 */ public TkCurveType MechArmSwingCurveFastWalk;
        [NMS(Index = 78)]
        /* 0xE06 */ public TkCurveType MechArmSwingCurveWalk;
        [NMS(Index = 40)]
        /* 0xE07 */ public bool MechCanUpdateMeshWhileMaintenanceUIActive;
        [NMS(Index = 111)]
        /* 0xE08 */ public bool MechFirstPersonTurretTweaksEnabled;
        [NMS(Index = 45)]
        /* 0xE09 */ public bool MechStrafeEnabled;
        [NMS(Index = 132)]
        /* 0xE0A */ public bool MechTitanFallTerrainEditEnabled;
        [NMS(Index = 227)]
        /* 0xE0B */ public bool RaceFinishAtStart;
        [NMS(Index = 14)]
        /* 0xE0C */ public bool ShowAllCheckpoints;
        [NMS(Index = 256)]
        /* 0xE0D */ public bool ShowTempVehicleMesh;
        [NMS(Index = 257)]
        /* 0xE0E */ public bool ShowVehicleDebugging;
        [NMS(Index = 261)]
        /* 0xE0F */ public bool ShowVehicleParticleDebug;
        [NMS(Index = 259)]
        /* 0xE10 */ public bool ShowVehicleText;
        [NMS(Index = 258)]
        /* 0xE11 */ public bool ShowVehicleWheelGuards;
        [NMS(Index = 21)]
        /* 0xE12 */ public TkCurveType SteeringWheelOutputCurve;
        [NMS(Index = 25)]
        /* 0xE13 */ public bool TestAnims;
        [NMS(Index = 281)]
        /* 0xE14 */ public bool ThrottleButtonCamRelative;
        [NMS(Index = 172)]
        /* 0xE15 */ public TkCurveType UnderwaterBuoyancyDepthCurve;
        [NMS(Index = 12)]
        /* 0xE16 */ public bool UseFirstPersonCamera;
        [NMS(Index = 189)]
        /* 0xE17 */ public bool VehicleAltControlScheme;
        [NMS(Index = 262)]
        /* 0xE18 */ public bool VehicleDrawAudioDebug;
    }
}
