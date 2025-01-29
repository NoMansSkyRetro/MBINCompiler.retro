namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x96BEE63E4537305C, NameHash = 0x357DD91E)]
    public class GcVehicleData : NMSTemplate
    {
        [NMS(Index = 139, Size = 0xA)]
        /* 0x0000 */ public Vector3f[] WheelGrassPushers;
        [NMS(Index = 21, Size = 0xA)]
        /* 0x00A0 */ public Vector3f[] WheelLocs;
        [NMS(Index = 30)]
        /* 0x0140 */ public Vector3f CollDimensions;
        [NMS(Index = 28)]
        /* 0x0150 */ public Vector3f CollOffset;
        [NMS(Index = 29)]
        /* 0x0160 */ public Vector3f ExtraCollOffset;
        [NMS(Index = 1)]
        /* 0x0170 */ public Vector3f FirstPersonSeatAdjust;
        [NMS(Index = 31)]
        /* 0x0180 */ public Vector3f InertiaDimensions;
        [NMS(Index = 64)]
        /* 0x0190 */ public Vector3f WheelForwardAngularFactor;
        [NMS(Index = 67)]
        /* 0x01A0 */ public Vector3f WheelSideAngularFactor;
        [NMS(Index = 66)]
        /* 0x01B0 */ public Vector3f WheelSuspensionAngularFactor;
        [NMS(Index = 65)]
        /* 0x01C0 */ public Vector3f WheelTurnAngularFactor;
        [NMS(Index = 26, Size = 0xA)]
        /* 0x01D0 */ public NMSString0x10[] SuspensionAnimNames;
        [NMS(Index = 0)]
        /* 0x0270 */ public NMSString0x10 Name;
        [NMS(Index = 85)]
        /* 0x0280 */ public NMSString0x10 SideSkidParticle;
        [NMS(Index = 90)]
        /* 0x0290 */ public NMSString0x10 WheelSpinParticle;
        [NMS(Index = 25, Size = 0xA)]
        /* 0x02A0 */ public float[] WheelRadiusMultiplier;
        [NMS(Index = 24, Size = 0xA)]
        /* 0x02C8 */ public float[] WheelRayFakeWidthFactor;
        [NMS(Index = 119)]
        /* 0x02F0 */ public float AudioImpactSpeedMul;
        [NMS(Index = 118)]
        /* 0x02F4 */ public float AudioImpactSpeedThreshold;
        [NMS(Index = 32)]
        /* 0x02F8 */ public float CollRadius;
        [NMS(Index = 140)]
        /* 0x02FC */ public float CreatureMassScale;
        [NMS(Index = 47)]
        /* 0x0300 */ public float HardStopSpeedThreshold;
        [NMS(Index = 144)]
        /* 0x0304 */ public float HeadlightIntensity;
        [NMS(Index = 33)]
        /* 0x0308 */ public float InertiaMul;
        [NMS(Index = 135)]
        /* 0x030C */ public int NumGrassPushers;
        [NMS(Index = 2)]
        /* 0x0310 */ public int NumWheels;
        [NMS(Index = 87)]
        /* 0x0314 */ public float SideSkidParticleMaxRate;
        [NMS(Index = 89)]
        /* 0x0318 */ public float SideSkidParticleMaxThresh;
        [NMS(Index = 86)]
        /* 0x031C */ public float SideSkidParticleMinRate;
        [NMS(Index = 88)]
        /* 0x0320 */ public float SideSkidParticleMinThresh;
        [NMS(Index = 20)]
        /* 0x0324 */ public float SteeringWheelPushRange;
        [NMS(Index = 19)]
        /* 0x0328 */ public float SteeringWheelSpringMultiplier;
        [NMS(Index = 39)]
        /* 0x032C */ public float TopSpeedForward;
        [NMS(Index = 40)]
        /* 0x0330 */ public float TopSpeedReverse;
        [NMS(Index = 59)]
        /* 0x0334 */ public float TurningWheelForce;
        [NMS(Index = 60)]
        /* 0x0338 */ public float TurningWheelForceDamperVR;
        [NMS(Index = 63)]
        /* 0x033C */ public float TurningWheelFrictionBraking;
        [NMS(Index = 62)]
        /* 0x0340 */ public float TurningWheelFrictionNonBraking;
        [NMS(Index = 61)]
        /* 0x0344 */ public float TurningWheelFrictionOmega;
        [NMS(Index = 14)]
        /* 0x0348 */ public float UnderwaterAlignDir;
        [NMS(Index = 15)]
        /* 0x034C */ public float UnderwaterAlignUp;
        [NMS(Index = 12)]
        /* 0x0350 */ public float UnderwaterEngineDirectionBrake;
        [NMS(Index = 13)]
        /* 0x0354 */ public float UnderwaterEngineDirectionBrakeVertical;
        [NMS(Index = 11)]
        /* 0x0358 */ public float UnderwaterEngineFalloff;
        [NMS(Index = 9)]
        /* 0x035C */ public float UnderwaterEngineMaxSpeed;
        [NMS(Index = 10)]
        /* 0x0360 */ public float UnderwaterEngineMaxSpeedVR;
        [NMS(Index = 7)]
        /* 0x0364 */ public float UnderwaterEnginePower;
        [NMS(Index = 8)]
        /* 0x0368 */ public float UnderwaterEnginePowerVR;
        [NMS(Index = 106)]
        /* 0x036C */ public float VehicleAngularDampingAerial;
        [NMS(Index = 104)]
        /* 0x0370 */ public float VehicleAngularDampingGround;
        [NMS(Index = 108)]
        /* 0x0374 */ public float VehicleAngularDampingWater;
        [NMS(Index = 114)]
        /* 0x0378 */ public float VehicleAudioSideSkidMul;
        [NMS(Index = 115)]
        /* 0x037C */ public float VehicleAudioSideSkidThreshold;
        [NMS(Index = 112)]
        /* 0x0380 */ public float VehicleAudioSpeedMul;
        [NMS(Index = 116)]
        /* 0x0384 */ public float VehicleAudioSpinSkidMul;
        [NMS(Index = 117)]
        /* 0x0388 */ public float VehicleAudioSpinSkidThreshold;
        [NMS(Index = 134)]
        /* 0x038C */ public float VehicleAudioSuspensionScale;
        [NMS(Index = 133)]
        /* 0x0390 */ public float VehicleAudioSuspensionThreshold;
        [NMS(Index = 113)]
        /* 0x0394 */ public float VehicleAudioTorqueMul;
        [NMS(Index = 74)]
        /* 0x0398 */ public float VehicleBoostExtraMaxSpeedAir;
        [NMS(Index = 72)]
        /* 0x039C */ public float VehicleBoostForce;
        [NMS(Index = 73)]
        /* 0x03A0 */ public float VehicleBoostMaxSpeed;
        [NMS(Index = 77)]
        /* 0x03A4 */ public float VehicleBoostRechargeTime;
        [NMS(Index = 75)]
        /* 0x03A8 */ public float VehicleBoostSpeedFalloff;
        [NMS(Index = 76)]
        /* 0x03AC */ public float VehicleBoostTime;
        [NMS(Index = 111)]
        /* 0x03B0 */ public float VehicleComCheat;
        [NMS(Index = 68)]
        /* 0x03B4 */ public float VehicleGravity;
        [NMS(Index = 69)]
        /* 0x03B8 */ public float VehicleGravityWater;
        [NMS(Index = 71)]
        /* 0x03BC */ public float VehicleJumpAirControlForce;
        [NMS(Index = 82)]
        /* 0x03C0 */ public float VehicleJumpAirMaxTorque;
        [NMS(Index = 81)]
        /* 0x03C4 */ public float VehicleJumpAirRotateTimeMax;
        [NMS(Index = 80)]
        /* 0x03C8 */ public float VehicleJumpAirRotateTimeMin;
        [NMS(Index = 78)]
        /* 0x03CC */ public float VehicleJumpAirRotateXAmount;
        [NMS(Index = 79)]
        /* 0x03D0 */ public float VehicleJumpAirRotateZAmount;
        [NMS(Index = 70)]
        /* 0x03D4 */ public float VehicleJumpForce;
        [NMS(Index = 105)]
        /* 0x03D8 */ public float VehicleLinearDampingAerial;
        [NMS(Index = 103)]
        /* 0x03DC */ public float VehicleLinearDampingGround;
        [NMS(Index = 107)]
        /* 0x03E0 */ public float VehicleLinearDampingWater;
        [NMS(Index = 132)]
        /* 0x03E4 */ public float VehicleUnderwaterRotateTime;
        [NMS(Index = 18)]
        /* 0x03E8 */ public float VisualPitchAmount;
        [NMS(Index = 16)]
        /* 0x03EC */ public float VisualRollAmount;
        [NMS(Index = 17)]
        /* 0x03F0 */ public float VisualRollOffsetY;
        [NMS(Index = 46)]
        /* 0x03F4 */ public float WheelDragginess;
        [NMS(Index = 110)]
        /* 0x03F8 */ public float WheelEndHeight;
        [NMS(Index = 49)]
        /* 0x03FC */ public float WheelFrontFrictionDynamic;
        [NMS(Index = 50)]
        /* 0x0400 */ public float WheelFrontFrictionDynamicThreshold;
        [NMS(Index = 48)]
        /* 0x0404 */ public float WheelFrontFrictionOmega;
        [NMS(Index = 51)]
        /* 0x0408 */ public float WheelFrontFrictionStatic;
        [NMS(Index = 52)]
        /* 0x040C */ public float WheelFrontFrictionStaticThreshold;
        [NMS(Index = 138)]
        /* 0x0410 */ public float WheelGrassPusherFrequency;
        [NMS(Index = 136)]
        /* 0x0414 */ public float WheelGrassPusherStrength;
        [NMS(Index = 137)]
        /* 0x0418 */ public float WheelGrassPusherWobble;
        [NMS(Index = 6)]
        /* 0x041C */ public float WheelGuardAdjustUpwards;
        [NMS(Index = 5)]
        /* 0x0420 */ public float WheelGuardExtraHeight;
        [NMS(Index = 4)]
        /* 0x0424 */ public float WheelGuardExtraRadius;
        [NMS(Index = 101)]
        /* 0x0428 */ public float WheelGuardMassScaleMax;
        [NMS(Index = 100)]
        /* 0x042C */ public float WheelGuardMassScaleMin;
        [NMS(Index = 102)]
        /* 0x0430 */ public float WheelGuardMassScaleMinClamp;
        [NMS(Index = 98)]
        /* 0x0434 */ public float WheelGuardPenetrationScaleMax;
        [NMS(Index = 97)]
        /* 0x0438 */ public float WheelGuardPenetrationScaleMin;
        [NMS(Index = 99)]
        /* 0x043C */ public float WheelGuardPenetrationScaleMinClamp;
        [NMS(Index = 96)]
        /* 0x0440 */ public float WheelGuardVerticalResponseMax;
        [NMS(Index = 95)]
        /* 0x0444 */ public float WheelGuardVerticalResponseMin;
        [NMS(Index = 41)]
        /* 0x0448 */ public float WheelMaxAccelForceForward;
        [NMS(Index = 42)]
        /* 0x044C */ public float WheelMaxAccelForceReverse;
        [NMS(Index = 44)]
        /* 0x0450 */ public float WheelMaxDecelForceBraking;
        [NMS(Index = 43)]
        /* 0x0454 */ public float WheelMaxDecelForceNonBraking;
        [NMS(Index = 3)]
        /* 0x0458 */ public float WheelRadius;
        [NMS(Index = 54)]
        /* 0x045C */ public float WheelSideFrictionDynamic;
        [NMS(Index = 55)]
        /* 0x0460 */ public float WheelSideFrictionDynamicThreshold;
        [NMS(Index = 53)]
        /* 0x0464 */ public float WheelSideFrictionOmega;
        [NMS(Index = 56)]
        /* 0x0468 */ public float WheelSideFrictionStatic;
        [NMS(Index = 57)]
        /* 0x046C */ public float WheelSideFrictionStaticThreshold;
        [NMS(Index = 45)]
        /* 0x0470 */ public float WheelSpinniness;
        [NMS(Index = 92)]
        /* 0x0474 */ public float WheelSpinParticleMaxRate;
        [NMS(Index = 94)]
        /* 0x0478 */ public float WheelSpinParticleMaxThresh;
        [NMS(Index = 91)]
        /* 0x047C */ public float WheelSpinParticleMinRate;
        [NMS(Index = 93)]
        /* 0x0480 */ public float WheelSpinParticleMinThresh;
        [NMS(Index = 109)]
        /* 0x0484 */ public float WheelStartHeight;
        [NMS(Index = 38)]
        /* 0x0488 */ public float WheelSuspensionAnimMax;
        [NMS(Index = 37)]
        /* 0x048C */ public float WheelSuspensionAnimMin;
        [NMS(Index = 36)]
        /* 0x0490 */ public float WheelSuspensionDamping;
        [NMS(Index = 35)]
        /* 0x0494 */ public float WheelSuspensionForce;
        [NMS(Index = 34)]
        /* 0x0498 */ public float WheelSuspensionlength;
        [NMS(Index = 143, Size = 0x2)]
        /* 0x049C */ public NMSString0x100[] CockpitHeadlightNames;
        [NMS(Index = 141, Size = 0x2)]
        /* 0x069C */ public NMSString0x100[] HeadlightNames;
        [NMS(Index = 142, Size = 0x2)]
        /* 0x089C */ public NMSString0x100[] VolumetricHeadlightNames;
        [NMS(Index = 22, Size = 0xA)]
        /* 0x0A9C */ public NMSString0x20[] WheelNames;
        [NMS(Index = 23, Size = 0xA)]
        /* 0x0BDC */ public NMSString0x20[] WheelSuspensionNames;
        [NMS(Index = 121)]
        /* 0x0D1C */ public NMSString0x80 AudioBoostStart;
        [NMS(Index = 122)]
        /* 0x0D9C */ public NMSString0x80 AudioBoostStop;
        [NMS(Index = 123)]
        /* 0x0E1C */ public NMSString0x80 AudioHornStart;
        [NMS(Index = 124)]
        /* 0x0E9C */ public NMSString0x80 AudioHornStop;
        [NMS(Index = 125)]
        /* 0x0F1C */ public NMSString0x80 AudioIdleExterior;
        [NMS(Index = 126)]
        /* 0x0F9C */ public NMSString0x80 AudioImpacts;
        [NMS(Index = 130)]
        /* 0x101C */ public NMSString0x80 AudioJump;
        [NMS(Index = 127)]
        /* 0x109C */ public NMSString0x80 AudioStart;
        [NMS(Index = 128)]
        /* 0x111C */ public NMSString0x80 AudioStop;
        [NMS(Index = 129)]
        /* 0x119C */ public NMSString0x80 AudioSuspension;
        [NMS(Index = 27)]
        /* 0x121C */ public bool CustomCollision;
        [NMS(Index = 131)]
        /* 0x121D */ public bool DriveOnTopOfWater;
        [NMS(Index = 58)]
        /* 0x121E */ public bool LockVehicleAxis;
        [NMS(Index = 83)]
        /* 0x121F */ public bool UseBuggySuspensionHack;
        [NMS(Index = 84)]
        /* 0x1220 */ public bool UseRoverWheelHack;
        [NMS(Index = 120)]
        /* 0x1221 */ public bool VehicleAudioSwapSkidAndSpeed;
    }
}
