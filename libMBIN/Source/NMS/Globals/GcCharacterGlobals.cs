using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x6E3D4032F817D723, NameHash = 0x72EA4972)]
    public class GcCharacterGlobals : NMSTemplate
    {
        [NMS(Index = 13)]
        /* 0x000 */ public VariableSizeString CharacterFile;
        [NMS(Index = 14)]
        /* 0x010 */ public GcSeed CharacterSeedOverride;
        [NMS(Index = 49)]
        /* 0x020 */ public NMSString0x10 LadderClimbDown;
        [NMS(Index = 47)]
        /* 0x030 */ public NMSString0x10 LadderClimbIdle;
        [NMS(Index = 48)]
        /* 0x040 */ public NMSString0x10 LadderClimbUp;
        [NMS(Index = 51)]
        /* 0x050 */ public NMSString0x10 LadderDismountBottom;
        [NMS(Index = 53)]
        /* 0x060 */ public NMSString0x10 LadderDismountTop;
        [NMS(Index = 50)]
        /* 0x070 */ public NMSString0x10 LadderMountBottom;
        [NMS(Index = 52)]
        /* 0x080 */ public NMSString0x10 LadderMountTop;
        [NMS(Index = 1)]
        /* 0x090 */ public NMSString0x10 NPCStaffPropTag;
        [NMS(Index = 8)]
        /* 0x0A0 */ public NMSString0x10 WaterEffectBodyID;
        [NMS(Index = 10)]
        /* 0x0B0 */ public NMSString0x10 WaterEffectLeftHandID;
        [NMS(Index = 9)]
        /* 0x0C0 */ public NMSString0x10 WaterEffectRightHandID;
        [NMS(Index = 30)]
        /* 0x0D0 */ public float AimPitchAnimScale;
        [NMS(Index = 32)]
        /* 0x0D4 */ public float AimPitchInterpSpeed;
        [NMS(Index = 31)]
        /* 0x0D8 */ public float AimYawAnimScale;
        [NMS(Index = 66)]
        /* 0x0DC */ public float BankingMaxStrength;
        [NMS(Index = 65)]
        /* 0x0E0 */ public float BankingMinimumSpeed;
        [NMS(Index = 67)]
        /* 0x0E4 */ public float BankingSpeedForMaxStrength;
        [NMS(Index = 74)]
        /* 0x0E8 */ public float BlendToNewFeetSpeed;
        [NMS(Index = 19)]
        /* 0x0EC */ public float CharacterJetpackTurnAimSpeed;
        [NMS(Index = 18)]
        /* 0x0F0 */ public float CharacterJetpackTurnSpeed;
        [NMS(Index = 11)]
        /* 0x0F4 */ public float CharacterRotationOffsetY;
        [NMS(Index = 12)]
        /* 0x0F8 */ public float CharacterRoughHeadHeight;
        [NMS(Index = 17)]
        /* 0x0FC */ public float CharacterRunTurnSpeed;
        [NMS(Index = 22)]
        /* 0x100 */ public float CharacterSwimmingTurnAimSpeed;
        [NMS(Index = 21)]
        /* 0x104 */ public float CharacterSwimmingTurnSpeed;
        [NMS(Index = 20)]
        /* 0x108 */ public float CharacterTurnAimSpeed;
        [NMS(Index = 16)]
        /* 0x10C */ public float CharacterTurnSpeed;
        [NMS(Index = 15)]
        /* 0x110 */ public float DontShowCharacterWithinCameraDistance;
        [NMS(Index = 26)]
        /* 0x114 */ public float FeetShiftOnTurnMaxSpeed;
        [NMS(Index = 25)]
        /* 0x118 */ public float FeetShiftOnTurnSpeed;
        [NMS(Index = 72)]
        /* 0x11C */ public float FootPlantedTolerance;
        [NMS(Index = 73)]
        /* 0x120 */ public float FootPlantSpring;
        [NMS(Index = 29)]
        /* 0x124 */ public float GunRotationSpeed;
        [NMS(Index = 0)]
        /* 0x128 */ public float HoldWeaponAsPropXRotationDegrees;
        [NMS(Index = 71)]
        /* 0x12C */ public float IkBlendStrengthSpeed;
        [NMS(Index = 70)]
        /* 0x130 */ public float IKLegStretchStrength;
        [NMS(Index = 36)]
        /* 0x134 */ public float JetpackSwimmingPitchRotation;
        [NMS(Index = 46)]
        /* 0x138 */ public float LadderCooldownAfterBeforeAutoClimb;
        [NMS(Index = 45)]
        /* 0x13C */ public float LadderDistanceToAutoMount;
        [NMS(Index = 60)]
        /* 0x140 */ public float MaxAnkleRotationAngle;
        [NMS(Index = 34)]
        /* 0x144 */ public float MaxSwimmingPitchRotation;
        [NMS(Index = 39)]
        /* 0x148 */ public float MaxSwimmingRollRotation;
        [NMS(Index = 68)]
        /* 0x14C */ public float MinimumIdleToJogAnimSpeed;
        [NMS(Index = 84)]
        /* 0x150 */ public float MinStickForIntoJogAnim;
        [NMS(Index = 33)]
        /* 0x154 */ public float MinSwimmingPitchRotation;
        [NMS(Index = 38)]
        /* 0x158 */ public float MinSwimmingRollRotation;
        [NMS(Index = 27)]
        /* 0x15C */ public float MinTurnAngle;
        [NMS(Index = 131)]
        /* 0x160 */ public float NPCActiveListenChance;
        [NMS(Index = 105)]
        /* 0x164 */ public float NPCAnimSpeedMax;
        [NMS(Index = 104)]
        /* 0x168 */ public float NPCAnimSpeedMin;
        [NMS(Index = 117)]
        /* 0x16C */ public float NPCArriveDist;
        [NMS(Index = 106)]
        /* 0x170 */ public float NPCBehaviourTimeModifier;
        [NMS(Index = 163)]
        /* 0x174 */ public float NPCBlockedDestRadius;
        [NMS(Index = 126)]
        /* 0x178 */ public float NPCCamoScanRevealTime;
        [NMS(Index = 125)]
        /* 0x17C */ public float NPCCamoWipeEffectTime;
        [NMS(Index = 122)]
        /* 0x180 */ public float NPCDecelerateStrength;
        [NMS(Index = 175)]
        /* 0x184 */ public float NPCDisplayThoughtsMaxDistance;
        [NMS(Index = 174)]
        /* 0x188 */ public float NPCDisplayThoughtsMaxDuration;
        [NMS(Index = 177)]
        /* 0x18C */ public float NPCDisplayThoughtsProbability;
        [NMS(Index = 176)]
        /* 0x190 */ public float NPCDisplayThoughtsRefreshInterval;
        [NMS(Index = 128)]
        /* 0x194 */ public float NPCFastStaticTurnAngle;
        [NMS(Index = 165)]
        /* 0x198 */ public float NPCFlavourIdleTimeMax;
        [NMS(Index = 164)]
        /* 0x19C */ public float NPCFlavourIdleTimeMin;
        [NMS(Index = 94)]
        /* 0x1A0 */ public GcNPCPropType NPCForceProp;
        [NMS(Index = 179)]
        /* 0x1A4 */ public float NPCHackMoveUpToStopFallingThoughFloor;
        [NMS(Index = 100)]
        /* 0x1A8 */ public float NPCIKBodyWeightNormal;
        [NMS(Index = 99)]
        /* 0x1AC */ public float NPCIKBodyWeightNormalGek;
        [NMS(Index = 101)]
        /* 0x1B0 */ public float NPCIKBodyWeightSeated;
        [NMS(Index = 118)]
        /* 0x1B4 */ public float NPCIncreasedSteeringDist;
        [NMS(Index = 140)]
        /* 0x1B8 */ public float NPCLookAtTerminateAngle;
        [NMS(Index = 132)]
        /* 0x1BC */ public float NPCLookAtThingChance;
        [NMS(Index = 135)]
        /* 0x1C0 */ public float NPCLookAtThingTimeMax;
        [NMS(Index = 134)]
        /* 0x1C4 */ public float NPCLookAtThingTimeMin;
        [NMS(Index = 137)]
        /* 0x1C8 */ public float NPCLookAwayTimeMax;
        [NMS(Index = 136)]
        /* 0x1CC */ public float NPCLookAwayTimeMin;
        [NMS(Index = 144)]
        /* 0x1D0 */ public float NPCMaxFreighterInteractionSearchDist;
        [NMS(Index = 143)]
        /* 0x1D4 */ public float NPCMaxInteractionSearchDist;
        [NMS(Index = 138)]
        /* 0x1D8 */ public float NPCMaxLookAtAngleMoving;
        [NMS(Index = 139)]
        /* 0x1DC */ public float NPCMaxLookAtAngleStatic;
        [NMS(Index = 160)]
        /* 0x1E0 */ public float NPCMaxRandomNavPathMaxIndoorOffset;
        [NMS(Index = 162)]
        /* 0x1E4 */ public float NPCMaxRandomNavPathMaxOutdoorOffset;
        [NMS(Index = 159)]
        /* 0x1E8 */ public float NPCMaxRandomNavPathMinIndoorOffset;
        [NMS(Index = 161)]
        /* 0x1EC */ public float NPCMaxRandomNavPathMinOutdoorOffset;
        [NMS(Index = 145)]
        /* 0x1F0 */ public float NPCMaxSettlementInteractionSearchDist;
        [NMS(Index = 130)]
        /* 0x1F4 */ public float NPCMaxStaticTurnSpeed;
        [NMS(Index = 120)]
        /* 0x1F8 */ public float NPCMaxTurnSpeed;
        [NMS(Index = 142)]
        /* 0x1FC */ public float NPCMinInteractionSearchDist;
        [NMS(Index = 127)]
        /* 0x200 */ public float NPCMinStaticTurnAngle;
        [NMS(Index = 119)]
        /* 0x204 */ public float NPCMinTurnSpeed;
        [NMS(Index = 121)]
        /* 0x208 */ public float NPCMinTurnSpeedMech;
        [NMS(Index = 166)]
        /* 0x20C */ public float NPCMoodIdleDelayChance;
        [NMS(Index = 167)]
        /* 0x210 */ public float NPCMoodIdleLowIntensityChance;
        [NMS(Index = 111)]
        /* 0x214 */ public int NPCNumNavFailuresUntilNoPhysFallback;
        [NMS(Index = 147)]
        /* 0x218 */ public float NPCPerceptionRadius;
        [NMS(Index = 110)]
        /* 0x21C */ public float NPCPermittedNavigationDelayFactor;
        [NMS(Index = 178)]
        /* 0x220 */ public float NPCPOISelectionNearbyNPCBaseMultiplier;
        [NMS(Index = 95)]
        /* 0x224 */ public float NPCPropScaleTime;
        [NMS(Index = 97)]
        /* 0x228 */ public float NPCReactCooldown;
        [NMS(Index = 96)]
        /* 0x22C */ public float NPCReactionChance;
        [NMS(Index = 170)]
        /* 0x230 */ public float NPCReactToPlayerPresenceDist;
        [NMS(Index = 172)]
        /* 0x234 */ public float NPCReactToPlayerPresenceGloablCooldown;
        [NMS(Index = 171)]
        /* 0x238 */ public float NPCReactToPlayerPresenceIndividualCooldown;
        [NMS(Index = 173)]
        /* 0x23C */ public float NPCReactToPlayerPresenceStaticTimer;
        [NMS(Index = 115)]
        /* 0x240 */ public float NPCRunSpeed;
        [NMS(Index = 116)]
        /* 0x244 */ public float NPCRunSpeedGek;
        [NMS(Index = 2)]
        /* 0x248 */ public float NPCScalingMaxRandomVariance;
        [NMS(Index = 141)]
        /* 0x24C */ public float NPCSeatedLookAtLateralReduction;
        [NMS(Index = 129)]
        /* 0x250 */ public float NPCSlowStaticTurnAngle;
        [NMS(Index = 102)]
        /* 0x254 */ public float NPCSpineAdjustGek;
        [NMS(Index = 103)]
        /* 0x258 */ public float NPCSpineAdjustVykeen;
        [NMS(Index = 108)]
        /* 0x25C */ public float NPCStaticDistance;
        [NMS(Index = 109)]
        /* 0x260 */ public float NPCStaticTimeUntilFail;
        [NMS(Index = 123)]
        /* 0x264 */ public float NPCStaticTurnTime;
        [NMS(Index = 150)]
        /* 0x268 */ public float NPCSteeringAvoidStrength;
        [NMS(Index = 154)]
        /* 0x26C */ public float NPCSteeringCollisionAvoidAngle;
        [NMS(Index = 155)]
        /* 0x270 */ public float NPCSteeringCollisionAvoidStrength;
        [NMS(Index = 153)]
        /* 0x274 */ public float NPCSteeringComingTowardsDegrees;
        [NMS(Index = 149)]
        /* 0x278 */ public float NPCSteeringFollowStrength;
        [NMS(Index = 148)]
        /* 0x27C */ public float NPCSteeringObstacleAvoidStrength;
        [NMS(Index = 151)]
        /* 0x280 */ public float NPCSteeringRadius;
        [NMS(Index = 157)]
        /* 0x284 */ public float NPCSteeringRayLength;
        [NMS(Index = 158)]
        /* 0x288 */ public float NPCSteeringRaySphereSize;
        [NMS(Index = 156)]
        /* 0x28C */ public float NPCSteeringRaySpread;
        [NMS(Index = 152)]
        /* 0x290 */ public float NPCSteeringRepelDist;
        [NMS(Index = 146)]
        /* 0x294 */ public float NPCSteeringSpringTime;
        [NMS(Index = 124)]
        /* 0x298 */ public float NPCTeleportEffectTime;
        [NMS(Index = 113)]
        /* 0x29C */ public float NPCWalkSpeed;
        [NMS(Index = 114)]
        /* 0x2A0 */ public float NPCWalkSpeedGek;
        [NMS(Index = 112)]
        /* 0x2A4 */ public float NPCWalkSpeedMech;
        [NMS(Index = 98)]
        /* 0x2A8 */ public float NPCWithScanEventReactCooldown;
        [NMS(Index = 168)]
        /* 0x2AC */ public float NPCWithScanEventReactToPlayerPresenceDist;
        [NMS(Index = 169)]
        /* 0x2B0 */ public float NPCWithScanEventReactToPlayerPresenceIndividualCooldown;
        [NMS(Index = 3)]
        /* 0x2B4 */ public float PitchTest;
        [NMS(Index = 80)]
        /* 0x2B8 */ public float RagdollConeLimit;
        [NMS(Index = 79)]
        /* 0x2BC */ public float RagdollDamping;
        [NMS(Index = 83)]
        /* 0x2C0 */ public float RagdollMotorFadeEnd;
        [NMS(Index = 82)]
        /* 0x2C4 */ public float RagdollMotorFadeStart;
        [NMS(Index = 78)]
        /* 0x2C8 */ public float RagdollTau;
        [NMS(Index = 81)]
        /* 0x2CC */ public float RagdollTwistLimit;
        [NMS(Index = 23)]
        /* 0x2D0 */ public float RocketBootsLandedTurnSpeed;
        [NMS(Index = 24)]
        /* 0x2D4 */ public float RocketBootsTurnSpeed;
        [NMS(Index = 4)]
        /* 0x2D8 */ public float RollTest;
        [NMS(Index = 69)]
        /* 0x2DC */ public float RootedAnimInterpolationTime;
        [NMS(Index = 61)]
        /* 0x2E0 */ public float RotateToFaceSlopeSpeed;
        [NMS(Index = 37)]
        /* 0x2E4 */ public float RoughSeaIdleSwimmingPitchRotation;
        [NMS(Index = 91)]
        /* 0x2E8 */ public float SitPostureChangeTimeMax;
        [NMS(Index = 90)]
        /* 0x2EC */ public float SitPostureChangeTimeMin;
        [NMS(Index = 56)]
        /* 0x2F0 */ public float SlidingBrake;
        [NMS(Index = 55)]
        /* 0x2F4 */ public float SlopeAngleForDownhillClimb;
        [NMS(Index = 57)]
        /* 0x2F8 */ public float SlopeAngleForSlide;
        [NMS(Index = 54)]
        /* 0x2FC */ public float SlopeAngleForUphillClimb;
        [NMS(Index = 85)]
        /* 0x300 */ public float SmoothVelocitySpeed;
        [NMS(Index = 35)]
        /* 0x304 */ public float SwimmingPitchRotationSurfaceExtra;
        [NMS(Index = 43)]
        /* 0x308 */ public float SwimmingRollSmoothTime;
        [NMS(Index = 44)]
        /* 0x30C */ public float SwimmingRollSmoothTimeWithWeapon;
        [NMS(Index = 41)]
        /* 0x310 */ public float SwimmingSmoothTime;
        [NMS(Index = 40)]
        /* 0x314 */ public float SwimmingSmoothTimeMin;
        [NMS(Index = 42)]
        /* 0x318 */ public float SwimmingSmoothTimeWithWeapon;
        [NMS(Index = 76)]
        /* 0x31C */ public float TimeAfterDeathRagdollIsEnabledBackward;
        [NMS(Index = 75)]
        /* 0x320 */ public float TimeAfterDeathRagdollIsEnabledForward;
        [NMS(Index = 77)]
        /* 0x324 */ public float TimeAfterDeathRagdollIsEnabledWhenBlocked;
        [NMS(Index = 64)]
        /* 0x328 */ public float TimeFallingUntilPanic;
        [NMS(Index = 62)]
        /* 0x32C */ public float TimeNotOnGroundToBeConsideredInAir;
        [NMS(Index = 63)]
        /* 0x330 */ public float TimeNotOnGroundToUseFallingCamera;
        [NMS(Index = 86)]
        /* 0x334 */ public float TimeToShowSplashEffect;
        [NMS(Index = 59)]
        /* 0x338 */ public float TrudgeUphillSpeed;
        [NMS(Index = 87)]
        /* 0x33C */ public float UnderwaterToAirTolerance;
        [NMS(Index = 58)]
        /* 0x340 */ public float UphillSpeedMultiplier;
        [NMS(Index = 88)]
        /* 0x344 */ public float WaterBottomSmoothPushUp;
        [NMS(Index = 89)]
        /* 0x348 */ public float WaterBottomSmoothPushUpDepth;
        [NMS(Index = 5)]
        /* 0x34C */ public float WaterEffectFadeSpring;
        [NMS(Index = 6)]
        /* 0x350 */ public float WaterEffectSpeedFadeMax;
        [NMS(Index = 7)]
        /* 0x354 */ public float WaterEffectSpeedFadeMin;
        [NMS(Index = 28)]
        /* 0x358 */ public float YawPullSpeed;
        [NMS(Index = 107)]
        /* 0x35C */ public bool NPCBehaviourInfo;
        [NMS(Index = 93)]
        /* 0x35D */ public bool NPCLightsAlwaysOn;
        [NMS(Index = 133)]
        /* 0x35E */ public bool NPCLookAtEnabled;
        [NMS(Index = 92)]
        /* 0x35F */ public bool NPCUseBehaviourTree;
    }
}
