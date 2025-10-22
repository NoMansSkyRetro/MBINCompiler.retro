using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x8613300931794E9B, NameHash = 0x6C7923EF)]
    public class GcVehicleGlobals : NMSTemplate
    {
        [NMS(Index = 230)]
        /* 0x000 */ public Colour CheckpointBeamColourActive;
        [NMS(Index = 231)]
        /* 0x010 */ public Colour CheckpointBeamColourNormal;
        [NMS(Index = 34)]
        /* 0x020 */ public Colour DefaultBoosterColour;
        [NMS(Index = 64)]
        /* 0x030 */ public Vector3f MechCrouchOffset;
        [NMS(Index = 65)]
        /* 0x040 */ public Vector3f MechWalkBackwardsCoGOffset;
        [NMS(Index = 155)]
        /* 0x050 */ public GcMechMeshPartTable MechMeshPartsTable;
        [NMS(Index = 154, Size = 0x5, EnumType = typeof(GcVehicleWeaponMode.VehicleWeaponModeEnum))]
        /* 0x2D0 */ public GcExoMechWeaponData[] MechWeaponData;
        [NMS(Index = 284, Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x550 */ public GcVehicleMuzzleData[] VehicleWeaponMuzzleFlash;
        [NMS(Index = 138)]
        /* 0x780 */ public GcMechAudioEventTable MechAudioEventTable;
        [NMS(Index = 137)]
        /* 0x8A0 */ public GcMechEffectTable MechEffectTable;
        [NMS(Index = 10)]
        /* 0x940 */ public NMSString0x20A BugMechRightArmTechNameOverride;
        [NMS(Index = 9)]
        /* 0x960 */ public NMSString0x20A SentinelRightArmTechNameOverride;
        [NMS(Index = 8)]
        /* 0x980 */ public NMSString0x10 BugMechLeftArmTech;
        [NMS(Index = 7)]
        /* 0x990 */ public NMSString0x10 BugMechRightArmTech;
        [NMS(Index = 233)]
        /* 0x9A0 */ public List<NMSString0x10> DefaultBikeLoadout;
        [NMS(Index = 232)]
        /* 0x9B0 */ public List<NMSString0x10> DefaultBuggyLoadout;
        [NMS(Index = 234)]
        /* 0x9C0 */ public List<NMSString0x10> DefaultTruckLoadout;
        [NMS(Index = 55)]
        /* 0x9D0 */ public NMSString0x10 MechArmPitchAnimLeft;
        [NMS(Index = 56)]
        /* 0x9E0 */ public NMSString0x10 MechArmPitchAnimRight;
        [NMS(Index = 4)]
        /* 0x9F0 */ public NMSString0x10 MechStrongLaser;
        [NMS(Index = 6)]
        /* 0xA00 */ public NMSString0x10 SentinelLeftArmTech;
        [NMS(Index = 5)]
        /* 0xA10 */ public NMSString0x10 SentinelRightArmTech;
        [NMS(Index = 11)]
        /* 0xA20 */ public NMSString0x10 SentinelRightLeftArmLaserData;
        [NMS(Index = 185)]
        /* 0xA30 */ public List<Vector3f> UnderwaterBubbleOffset;
        [NMS(Index = 286)]
        /* 0xA40 */ public List<GcVehicleData> VehicleDataTable;
        [NMS(Index = 283)]
        /* 0xA50 */ public NMSString0x10 VehicleLocalScan;
        [NMS(Index = 282)]
        /* 0xA60 */ public NMSString0x10 VehicleScan;
        [NMS(Index = 3)]
        /* 0xA70 */ public NMSString0x10 VehicleStrongLaser;
        [NMS(Index = 285)]
        /* 0xA80 */ public List<GcVehicleWeaponMuzzleData> VehicleWeaponMuzzleDataTable;
        [NMS(Index = 184)]
        /* 0xA90 */ public GcSpaceshipAvoidanceData UnderwaterAvoidance;
        [NMS(Index = 37)]
        /* 0xAB4 */ public Vector2f MechLookStickSpeedLimit;
        [NMS(Index = 36)]
        /* 0xABC */ public Vector2f MechMovementStickSpeedLimit;
        [NMS(Index = 145)]
        /* 0xAC4 */ public float AIMechFlamethrowerFireInterval;
        [NMS(Index = 149)]
        /* 0xAC8 */ public int AIMechFlamethrowerNumShotsMax;
        [NMS(Index = 148)]
        /* 0xACC */ public int AIMechFlamethrowerNumShotsMin;
        [NMS(Index = 150)]
        /* 0xAD0 */ public float AIMechGunExplosionRadius;
        [NMS(Index = 141)]
        /* 0xAD4 */ public float AIMechGunFireInterval;
        [NMS(Index = 151)]
        /* 0xAD8 */ public float AIMechGunInheritVelocity;
        [NMS(Index = 143)]
        /* 0xADC */ public int AIMechGunNumShotsMax;
        [NMS(Index = 142)]
        /* 0xAE0 */ public int AIMechGunNumShotsMin;
        [NMS(Index = 140)]
        /* 0xAE4 */ public float AIMechLaserFireDurationMax;
        [NMS(Index = 139)]
        /* 0xAE8 */ public float AIMechLaserFireDurationMin;
        [NMS(Index = 144)]
        /* 0xAEC */ public float AIMechStunGunFireInterval;
        [NMS(Index = 147)]
        /* 0xAF0 */ public int AIMechStunGunNumShotsMax;
        [NMS(Index = 146)]
        /* 0xAF4 */ public int AIMechStunGunNumShotsMin;
        [NMS(Index = 217)]
        /* 0xAF8 */ public float AttractAlign;
        [NMS(Index = 215)]
        /* 0xAFC */ public float AttractAmount;
        [NMS(Index = 218)]
        /* 0xB00 */ public float AttractDirectionBrakeThresholdSq;
        [NMS(Index = 216)]
        /* 0xB04 */ public float AttractMaxSpeed;
        [NMS(Index = 198)]
        /* 0xB08 */ public float BoostPadStrength;
        [NMS(Index = 197)]
        /* 0xB0C */ public float BoostPadTime;
        [NMS(Index = 167)]
        /* 0xB10 */ public float BuoyancyMaxDownForce;
        [NMS(Index = 168)]
        /* 0xB14 */ public float BuoyancyMaxUpForce;
        [NMS(Index = 170)]
        /* 0xB18 */ public float BuoyancySurfaceFudge;
        [NMS(Index = 169)]
        /* 0xB1C */ public float BuoyancySurfacingTime;
        [NMS(Index = 166)]
        /* 0xB20 */ public float BuoyancyUnderwaterSphereRadius;
        [NMS(Index = 237)]
        /* 0xB24 */ public float CheckpointBeamOffset;
        [NMS(Index = 236)]
        /* 0xB28 */ public float CheckpointBeamSizeActive;
        [NMS(Index = 235)]
        /* 0xB2C */ public float CheckpointBeamSizeNormal;
        [NMS(Index = 196)]
        /* 0xB30 */ public float CheckpointDeleteAngle;
        [NMS(Index = 195)]
        /* 0xB34 */ public float CheckpointDeleteDistance;
        [NMS(Index = 228)]
        /* 0xB38 */ public float CheckpointFlashDuration;
        [NMS(Index = 229)]
        /* 0xB3C */ public float CheckpointFlashIntensity;
        [NMS(Index = 193)]
        /* 0xB40 */ public float CheckpointPlacementOffset;
        [NMS(Index = 194)]
        /* 0xB44 */ public float CheckpointPlacementRayLength;
        [NMS(Index = 223)]
        /* 0xB48 */ public float CheckpointRadius;
        [NMS(Index = 15)]
        /* 0xB4C */ public float ControlStickRecenterSpeedDegPerSec;
        [NMS(Index = 39)]
        /* 0xB50 */ public float DamageTechMinHitIntervalSeconds;
        [NMS(Index = 38)]
        /* 0xB54 */ public int DamageTechNumHitsRequired;
        [NMS(Index = 199)]
        /* 0xB58 */ public float DisablePhysicsRange;
        [NMS(Index = 220)]
        /* 0xB5C */ public float ExitStopForce;
        [NMS(Index = 219)]
        /* 0xB60 */ public float ExitStopTime;
        [NMS(Index = 161)]
        /* 0xB64 */ public float FirstPersonSteeringAdditionalForward;
        [NMS(Index = 162)]
        /* 0xB68 */ public float FirstPersonSteeringAdditionalForwardThreshold;
        [NMS(Index = 163)]
        /* 0xB6C */ public float FirstPersonSteeringAdditionalReverseThreshold;
        [NMS(Index = 165)]
        /* 0xB70 */ public float FirstPersonSteeringLowSpeedTurnDamping;
        [NMS(Index = 164)]
        /* 0xB74 */ public float FirstPersonSteeringMinThrottleHardLeftRight;
        [NMS(Index = 244)]
        /* 0xB78 */ public int GunBaseDamage;
        [NMS(Index = 247)]
        /* 0xB7C */ public int GunBaseMiningDamage;
        [NMS(Index = 221)]
        /* 0xB80 */ public float GunFireRate;
        [NMS(Index = 186)]
        /* 0xB84 */ public float HeadlightIntensitySpringTime;
        [NMS(Index = 213)]
        /* 0xB88 */ public float HornScareFleeRadius;
        [NMS(Index = 212)]
        /* 0xB8C */ public float HornScareRadius;
        [NMS(Index = 214)]
        /* 0xB90 */ public float HornScareTime;
        [NMS(Index = 13)]
        /* 0xB94 */ public float LevelVehicleCameraFactor;
        [NMS(Index = 50)]
        /* 0xB98 */ public float MechAIGroundTurnSpeed;
        [NMS(Index = 42)]
        /* 0xB9C */ public float MechAIResummonMinSpawnDistance;
        [NMS(Index = 43)]
        /* 0xBA0 */ public float MechAIResummonMinSpeedForVelBasedSpawnPos;
        [NMS(Index = 41)]
        /* 0xBA4 */ public float MechAIResummonTriggerDistance;
        [NMS(Index = 44)]
        /* 0xBA8 */ public float MechAIResummonVelBasedSpawnSpeedMultiplier;
        [NMS(Index = 53)]
        /* 0xBAC */ public float MechArmPitchAngleMax;
        [NMS(Index = 52)]
        /* 0xBB0 */ public float MechArmPitchAngleMin;
        [NMS(Index = 54)]
        /* 0xBB4 */ public float MechArmPitchLerpSpeed;
        [NMS(Index = 75)]
        /* 0xBB8 */ public float MechArmSwingAngleFastWalk;
        [NMS(Index = 72)]
        /* 0xBBC */ public float MechArmSwingAngleWalk;
        [NMS(Index = 76)]
        /* 0xBC0 */ public float MechArmSwingPhaseFastWalk;
        [NMS(Index = 73)]
        /* 0xBC4 */ public float MechArmSwingPhaseWalk;
        [NMS(Index = 93)]
        /* 0xBC8 */ public float MechCameraOffsetAmount;
        [NMS(Index = 92)]
        /* 0xBCC */ public float MechCameraOffsetTime;
        [NMS(Index = 123)]
        /* 0xBD0 */ public float MechCockPitBobPitch;
        [NMS(Index = 124)]
        /* 0xBD4 */ public float MechCockPitBobRoll;
        [NMS(Index = 121)]
        /* 0xBD8 */ public float MechCockPitBobX;
        [NMS(Index = 122)]
        /* 0xBDC */ public float MechCockPitBobY;
        [NMS(Index = 125)]
        /* 0xBE0 */ public float MechCockPitBobYaw;
        [NMS(Index = 126)]
        /* 0xBE4 */ public float MechCockPowerDownY;
        [NMS(Index = 67)]
        /* 0xBE8 */ public float MechCoGAdjustTimeAir;
        [NMS(Index = 68)]
        /* 0xBEC */ public float MechCoGAdjustTimeLand;
        [NMS(Index = 66)]
        /* 0xBF0 */ public float MechCoGAdjustTimeWindUp;
        [NMS(Index = 47)]
        /* 0xBF4 */ public float MechContrailAlpha;
        [NMS(Index = 69)]
        /* 0xBF8 */ public float MechCrouchTime;
        [NMS(Index = 96)]
        /* 0xBFC */ public float MechDefaultBlendTime;
        [NMS(Index = 119)]
        /* 0xC00 */ public float MechFirstPersonCrouchAmount;
        [NMS(Index = 115)]
        /* 0xC04 */ public float MechFirstPersonDamping;
        [NMS(Index = 110)]
        /* 0xC08 */ public float MechFirstPersonIgnoreReverseThreshold;
        [NMS(Index = 118)]
        /* 0xC0C */ public float MechFirstPersonMaxLookTurret;
        [NMS(Index = 117)]
        /* 0xC10 */ public float MechFirstPersonMaxTurnTurret;
        [NMS(Index = 116)]
        /* 0xC14 */ public float MechFirstPersonStickXModerator;
        [NMS(Index = 114)]
        /* 0xC18 */ public float MechFirstPersonTurretAngleThrottleStrength;
        [NMS(Index = 113)]
        /* 0xC1C */ public float MechFirstPersonTurretAngleThrottleThreshold;
        [NMS(Index = 109)]
        /* 0xC20 */ public float MechFirstPersonTurretBaseThrottleThreshold;
        [NMS(Index = 112)]
        /* 0xC24 */ public float MechFirstPersonTurretBaseTurnThreshold;
        [NMS(Index = 106)]
        /* 0xC28 */ public float MechFirstPersonTurretPitchModerator;
        [NMS(Index = 108)]
        /* 0xC2C */ public float MechFirstPersonTurretShootTimer;
        [NMS(Index = 111)]
        /* 0xC30 */ public float MechFirstPersonTurretThrottleLookThreshold;
        [NMS(Index = 105)]
        /* 0xC34 */ public float MechFirstPersonTurretTurnModerator;
        [NMS(Index = 136)]
        /* 0xC38 */ public float MechFootprintFadeDist;
        [NMS(Index = 135)]
        /* 0xC3C */ public float MechFootprintFadeTime;
        [NMS(Index = 102)]
        /* 0xC40 */ public float MechIdleLowBlendTime;
        [NMS(Index = 103)]
        /* 0xC44 */ public float MechIdleLowDelay;
        [NMS(Index = 104)]
        /* 0xC48 */ public float MechIdleStopDelay;
        [NMS(Index = 86)]
        /* 0xC4C */ public float MechJetpackAvoidGroundForce;
        [NMS(Index = 88)]
        /* 0xC50 */ public float MechJetpackAvoidGroundProbeLength;
        [NMS(Index = 82)]
        /* 0xC54 */ public float MechJetpackBrake;
        [NMS(Index = 94)]
        /* 0xC58 */ public float MechJetpackDrainRate;
        [NMS(Index = 87)]
        /* 0xC5C */ public float MechJetpackFallForce;
        [NMS(Index = 95)]
        /* 0xC60 */ public float MechJetpackFillRate;
        [NMS(Index = 81)]
        /* 0xC64 */ public float MechJetpackForce;
        [NMS(Index = 89)]
        /* 0xC68 */ public float MechJetpackIgnitionForce;
        [NMS(Index = 90)]
        /* 0xC6C */ public float MechJetpackIgnitionTime;
        [NMS(Index = 48)]
        /* 0xC70 */ public float MechJetpackJetScaleTime;
        [NMS(Index = 80)]
        /* 0xC74 */ public float MechJetpackLandTime;
        [NMS(Index = 91)]
        /* 0xC78 */ public float MechJetpackMaxCoGAdjustX;
        [NMS(Index = 83)]
        /* 0xC7C */ public float MechJetpackMaxSpeed;
        [NMS(Index = 84)]
        /* 0xC80 */ public float MechJetpackMaxUpSpeed;
        [NMS(Index = 79)]
        /* 0xC84 */ public float MechJetpackStrafeStrength;
        [NMS(Index = 51)]
        /* 0xC88 */ public float MechJetpackTurnSpeed;
        [NMS(Index = 85)]
        /* 0xC8C */ public float MechJetpackUpForce;
        [NMS(Index = 99)]
        /* 0xC90 */ public float MechJumpBlendTime;
        [NMS(Index = 101)]
        /* 0xC94 */ public float MechJumpDownBlendTime;
        [NMS(Index = 100)]
        /* 0xC98 */ public float MechJumpFlyBlendTime;
        [NMS(Index = 98)]
        /* 0xC9C */ public float MechLandBlendTime;
        [NMS(Index = 78)]
        /* 0xCA0 */ public float MechLandBrake;
        [NMS(Index = 134)]
        /* 0xCA4 */ public float MechLandCameraShakeDist;
        [NMS(Index = 57)]
        /* 0xCA8 */ public float MechMaxTurnAngleWhileStationary;
        [NMS(Index = 49)]
        /* 0xCAC */ public float MechPlayerGroundTurnSpeed;
        [NMS(Index = 120)]
        /* 0xCB0 */ public float MechPowerUpTime;
        [NMS(Index = 239)]
        /* 0xCB4 */ public float MechSpawnRotation;
        [NMS(Index = 97)]
        /* 0xCB8 */ public float MechSpeedBlendTime;
        [NMS(Index = 133)]
        /* 0xCBC */ public float MechTitanFallCameraShakeDist;
        [NMS(Index = 127)]
        /* 0xCC0 */ public float MechTitanFallHeight;
        [NMS(Index = 131)]
        /* 0xCC4 */ public float MechTitanFallLandIdleTime;
        [NMS(Index = 132)]
        /* 0xCC8 */ public float MechTitanFallLandIntroTime;
        [NMS(Index = 130)]
        /* 0xCCC */ public float MechTitanFallTerrainEditOffset;
        [NMS(Index = 129)]
        /* 0xCD0 */ public float MechTitanFallTerrainEditSize;
        [NMS(Index = 62)]
        /* 0xCD4 */ public float MechTurretMaxAngleAir;
        [NMS(Index = 59)]
        /* 0xCD8 */ public float MechTurretMaxAngleGround;
        [NMS(Index = 63)]
        /* 0xCDC */ public float MechTurretTimeVRModifier;
        [NMS(Index = 61)]
        /* 0xCE0 */ public float MechTurretTurnTimeAir;
        [NMS(Index = 58)]
        /* 0xCE4 */ public float MechTurretTurnTimeGround;
        [NMS(Index = 60)]
        /* 0xCE8 */ public float MechTurretTurnTimeGroundPlayerCombat;
        [NMS(Index = 70)]
        /* 0xCEC */ public float MechWalkToRunTimeIdle;
        [NMS(Index = 71)]
        /* 0xCF0 */ public float MechWalkToRunTimeSkid;
        [NMS(Index = 152)]
        /* 0xCF4 */ public float MechWeaponInterpSpeed;
        [NMS(Index = 242)]
        /* 0xCF8 */ public int MiningLaserDamage;
        [NMS(Index = 202)]
        /* 0xCFC */ public float MiningLaserDrainSpeed;
        [NMS(Index = 241)]
        /* 0xD00 */ public int MiningLaserMiningDamage;
        [NMS(Index = 240)]
        /* 0xD04 */ public float MiningLaserRadius;
        [NMS(Index = 243)]
        /* 0xD08 */ public float MiningLaserSpeed;
        [NMS(Index = 203)]
        /* 0xD0C */ public float ProjectileDrainPerShot;
        [NMS(Index = 224)]
        /* 0xD10 */ public float RaceCooldown;
        [NMS(Index = 205)]
        /* 0xD14 */ public float RaceInteractRespawnOffset;
        [NMS(Index = 206)]
        /* 0xD18 */ public float RaceInteractRespawnUpOffset;
        [NMS(Index = 201)]
        /* 0xD1C */ public float RaceMultipleStartCaptureRange;
        [NMS(Index = 200)]
        /* 0xD20 */ public float RaceMultipleStartOffset;
        [NMS(Index = 226)]
        /* 0xD24 */ public float RaceResetFlashDuration;
        [NMS(Index = 227)]
        /* 0xD28 */ public float RaceResetFlashIntensity;
        [NMS(Index = 204)]
        /* 0xD2C */ public float RaceStartSpawnUpOffset;
        [NMS(Index = 22)]
        /* 0xD30 */ public float RemoteBoostingEffectTimeout;
        [NMS(Index = 248)]
        /* 0xD34 */ public float ResourceCollectOffset;
        [NMS(Index = 238)]
        /* 0xD38 */ public float SpawnRotation;
        [NMS(Index = 20)]
        /* 0xD3C */ public float SteeringWheelCentreOffset;
        [NMS(Index = 17)]
        /* 0xD40 */ public float SteeringWheelPitchAngle;
        [NMS(Index = 16)]
        /* 0xD44 */ public float SteeringWheelPushRange;
        [NMS(Index = 18)]
        /* 0xD48 */ public float SteeringWheelSpringBothHands;
        [NMS(Index = 19)]
        /* 0xD4C */ public float SteeringWheelSpringOneHand;
        [NMS(Index = 281)]
        /* 0xD50 */ public float StickReverseTurnStiffness;
        [NMS(Index = 280)]
        /* 0xD54 */ public float StickReverseTurnThreshold;
        [NMS(Index = 207)]
        /* 0xD58 */ public float StickTurnReducer;
        [NMS(Index = 210)]
        /* 0xD5C */ public float StickTurnReducerAltNonVR;
        [NMS(Index = 209)]
        /* 0xD60 */ public float StickTurnReducerVR;
        [NMS(Index = 208)]
        /* 0xD64 */ public float StickTurnReducerWater;
        [NMS(Index = 245)]
        /* 0xD68 */ public int StunGunBaseDamage;
        [NMS(Index = 246)]
        /* 0xD6C */ public float StunGunFireRate;
        [NMS(Index = 159)]
        /* 0xD70 */ public float SubmarineEjectDownOffset;
        [NMS(Index = 158)]
        /* 0xD74 */ public float SubmarineEjectRadius;
        [NMS(Index = 160)]
        /* 0xD78 */ public float SubmarineFirstPersonSteeringSensitivity;
        [NMS(Index = 157)]
        /* 0xD7C */ public float SubmarineMinSummonDepth;
        [NMS(Index = 222)]
        /* 0xD80 */ public float SummoningRange;
        [NMS(Index = 252)]
        /* 0xD84 */ public float SuspensionDamping;
        [NMS(Index = 253)]
        /* 0xD88 */ public float SuspensionDampingAngularFactor;
        [NMS(Index = 27)]
        /* 0xD8C */ public float TestAnimBoost;
        [NMS(Index = 26)]
        /* 0xD90 */ public float TestAnimThrust;
        [NMS(Index = 28)]
        /* 0xD94 */ public float TestAnimTurn;
        [NMS(Index = 23)]
        /* 0xD98 */ public float TestFrictionStat;
        [NMS(Index = 24)]
        /* 0xD9C */ public float TestSkidFrictionStat;
        [NMS(Index = 211)]
        /* 0xDA0 */ public float TravelSpeedReportReducer;
        [NMS(Index = 172)]
        /* 0xDA4 */ public float UnderwaterBuoyancyRangeMax;
        [NMS(Index = 171)]
        /* 0xDA8 */ public float UnderwaterBuoyancyRangeMin;
        [NMS(Index = 183)]
        /* 0xDAC */ public float UnderwaterDiveForce;
        [NMS(Index = 176)]
        /* 0xDB0 */ public float UnderwaterFlattenMinDepth;
        [NMS(Index = 177)]
        /* 0xDB4 */ public float UnderwaterFlattenRange;
        [NMS(Index = 182)]
        /* 0xDB8 */ public float UnderwaterJumpForce;
        [NMS(Index = 1)]
        /* 0xDBC */ public float UnderwaterScannerIconRangeBoost;
        [NMS(Index = 174)]
        /* 0xDC0 */ public float UnderwaterSummonSurfaceOffset;
        [NMS(Index = 178)]
        /* 0xDC4 */ public float UnderwaterSurfaceForceFlatteningAngleMin;
        [NMS(Index = 179)]
        /* 0xDC8 */ public float UnderwaterSurfaceForceFlatteningAngleRange;
        [NMS(Index = 175)]
        /* 0xDCC */ public float UnderwaterSurfaceOffset;
        [NMS(Index = 180)]
        /* 0xDD0 */ public float UnderwaterSurfaceSplashdownForce;
        [NMS(Index = 181)]
        /* 0xDD4 */ public float UnderwaterSurfaceSplashdownMinSpeed;
        [NMS(Index = 188)]
        /* 0xDD8 */ public float VehicleAltControlStickSmoothInTime;
        [NMS(Index = 189)]
        /* 0xDDC */ public float VehicleAltControlStickSmoothOutTime;
        [NMS(Index = 270)]
        /* 0xDE0 */ public float VehicleBoostFuelRate;
        [NMS(Index = 271)]
        /* 0xDE4 */ public float VehicleBoostFuelRateSurvival;
        [NMS(Index = 190)]
        /* 0xDE8 */ public float VehicleBoostSpeedMultiplierPercent;
        [NMS(Index = 0)]
        /* 0xDEC */ public float VehicleCollisionScaleFactor;
        [NMS(Index = 269)]
        /* 0xDF0 */ public float VehicleDeactivateRange;
        [NMS(Index = 265)]
        /* 0xDF4 */ public float VehicleFadeTime;
        [NMS(Index = 272)]
        /* 0xDF8 */ public float VehicleFuelRate;
        [NMS(Index = 273)]
        /* 0xDFC */ public float VehicleFuelRateTruckMultiplier;
        [NMS(Index = 192)]
        /* 0xE00 */ public float VehicleGarageHologramFadeRange;
        [NMS(Index = 191)]
        /* 0xE04 */ public float VehicleGarageHologramMinFadeRange;
        [NMS(Index = 276)]
        /* 0xE08 */ public float VehicleJumpCooldown;
        [NMS(Index = 275)]
        /* 0xE0C */ public float VehicleJumpTimeMax;
        [NMS(Index = 274)]
        /* 0xE10 */ public float VehicleJumpTimeMin;
        [NMS(Index = 267)]
        /* 0xE14 */ public float VehicleMaxSummonDistance;
        [NMS(Index = 268)]
        /* 0xE18 */ public float VehicleMaxSummonDistanceUnderwater;
        [NMS(Index = 266)]
        /* 0xE1C */ public float VehicleMinSummonDistance;
        [NMS(Index = 277)]
        /* 0xE20 */ public float VehicleMotionDeadZone;
        [NMS(Index = 2)]
        /* 0xE24 */ public float VehicleSolarRegenFactor;
        [NMS(Index = 262)]
        /* 0xE28 */ public float VehicleSuspensionAudioDelay;
        [NMS(Index = 263)]
        /* 0xE2C */ public float VehicleSuspensionAudioScale;
        [NMS(Index = 261)]
        /* 0xE30 */ public float VehicleSuspensionAudioSpacing;
        [NMS(Index = 264)]
        /* 0xE34 */ public float VehicleSuspensionAudioTrigger;
        [NMS(Index = 258)]
        /* 0xE38 */ public float VehicleTextSize;
        [NMS(Index = 249)]
        /* 0xE3C */ public float VehicleWheelNoise;
        [NMS(Index = 250)]
        /* 0xE40 */ public float VehicleWheelNoiseScale;
        [NMS(Index = 32)]
        /* 0xE44 */ public float VignetteAmountAcceleration;
        [NMS(Index = 33)]
        /* 0xE48 */ public float VignetteAmountTurning;
        [NMS(Index = 30)]
        /* 0xE4C */ public float VisualRollUnderwaterSpring;
        [NMS(Index = 31)]
        /* 0xE50 */ public float VisualTurnSpring;
        [NMS(Index = 29)]
        /* 0xE54 */ public float VisualTurnUnderwaterSpring;
        [NMS(Index = 156)]
        /* 0xE58 */ public float WeaponInterpSpeed;
        [NMS(Index = 35)]
        /* 0xE5C */ public float WheelDustColourLightFactor;
        [NMS(Index = 278)]
        /* 0xE60 */ public float WheelForceHalflife;
        [NMS(Index = 251)]
        /* 0xE64 */ public float WheelSideVerticalFactor;
        [NMS(Index = 153, Size = 0x5, EnumType = typeof(GcMechWeaponLocation.MechWeaponLocationEnum))]
        /* 0xE68 */ public NMSString0x20[] MechWeaponLocatorNames;
        [NMS(Index = 46)]
        /* 0xF08 */ public bool MechAltJumpMode;
        [NMS(Index = 77)]
        /* 0xF09 */ public TkCurveType MechArmSwingCurveFastWalk;
        [NMS(Index = 74)]
        /* 0xF0A */ public TkCurveType MechArmSwingCurveWalk;
        [NMS(Index = 40)]
        /* 0xF0B */ public bool MechCanUpdateMeshWhileMaintenanceUIActive;
        [NMS(Index = 107)]
        /* 0xF0C */ public bool MechFirstPersonTurretTweaksEnabled;
        [NMS(Index = 45)]
        /* 0xF0D */ public bool MechStrafeEnabled;
        [NMS(Index = 128)]
        /* 0xF0E */ public bool MechTitanFallTerrainEditEnabled;
        [NMS(Index = 225)]
        /* 0xF0F */ public bool RaceFinishAtStart;
        [NMS(Index = 14)]
        /* 0xF10 */ public bool ShowAllCheckpoints;
        [NMS(Index = 254)]
        /* 0xF11 */ public bool ShowTempVehicleMesh;
        [NMS(Index = 255)]
        /* 0xF12 */ public bool ShowVehicleDebugging;
        [NMS(Index = 259)]
        /* 0xF13 */ public bool ShowVehicleParticleDebug;
        [NMS(Index = 257)]
        /* 0xF14 */ public bool ShowVehicleText;
        [NMS(Index = 256)]
        /* 0xF15 */ public bool ShowVehicleWheelGuards;
        [NMS(Index = 21)]
        /* 0xF16 */ public TkCurveType SteeringWheelOutputCurve;
        [NMS(Index = 25)]
        /* 0xF17 */ public bool TestAnims;
        [NMS(Index = 279)]
        /* 0xF18 */ public bool ThrottleButtonCamRelative;
        [NMS(Index = 173)]
        /* 0xF19 */ public TkCurveType UnderwaterBuoyancyDepthCurve;
        [NMS(Index = 12)]
        /* 0xF1A */ public bool UseFirstPersonCamera;
        [NMS(Index = 187)]
        /* 0xF1B */ public bool VehicleAltControlScheme;
        [NMS(Index = 260)]
        /* 0xF1C */ public bool VehicleDrawAudioDebug;
    }
}
