using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xAEBBBC6B661EEB05, NameHash = 0xF1C0C3FD)]
    public class GcAISpaceshipGlobals : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x000 */ public GcPlayerSquadronConfig PlayerSquadronConfig;
        [NMS(Index = 150)]
        /* 0x230 */ public Colour AlertLightColour;
        [NMS(Index = 148)]
        /* 0x240 */ public Colour FreighterDoorColourActive;
        [NMS(Index = 149)]
        /* 0x250 */ public Colour FreighterDoorColourInactive;
        [NMS(Index = 1)]
        /* 0x260 */ public Colour FreighterEngineGlowDefaultColour;
        [NMS(Index = 157)]
        /* 0x270 */ public Vector3f TurretAlertLightOffset;
        [NMS(Index = 73, Size = 0x7, EnumType = typeof(GcAISpaceshipTypes.ShipTypeEnum))]
        /* 0x280 */ public NMSString0x10[] ProjectileWeaponMuzzleFlashes;
        [NMS(Index = 344, Size = 0x7, EnumType = typeof(GcAISpaceshipTypes.ShipTypeEnum))]
        /* 0x2F0 */ public NMSString0x10[] WarpArriveEffectIDs;
        [NMS(Index = 343, Size = 0x7, EnumType = typeof(GcAISpaceshipTypes.ShipTypeEnum))]
        /* 0x360 */ public NMSString0x10[] WarpStartEffectIDs;
        [NMS(Index = 81)]
        /* 0x3D0 */ public GcSpaceshipTravelData AsteroidMiningPositioningTravelData;
        [NMS(Index = 82)]
        /* 0x418 */ public GcSpaceshipTravelData AsteroidMiningTravelData;
        [NMS(Index = 79)]
        /* 0x460 */ public GcSpaceshipTravelData FallbackTravelData;
        [NMS(Index = 99)]
        /* 0x4A8 */ public GcSpaceshipTravelData OutpostLanding;
        [NMS(Index = 100)]
        /* 0x4F0 */ public GcSpaceshipTravelData PlanetLanding;
        [NMS(Index = 80)]
        /* 0x538 */ public GcSpaceshipTravelData SlowCombatEffectAttackTravel;
        [NMS(Index = 418)]
        /* 0x580 */ public GcShipAIPlanetPatrolData WingmanPathData;
        [NMS(Index = 419)]
        /* 0x5B8 */ public List<GcAIShipDebugSpawnData> DebugShipSpawns;
        [NMS(Index = 34)]
        /* 0x5C8 */ public VariableSizeString EnergyShield;
        [NMS(Index = 35)]
        /* 0x5D8 */ public NMSString0x10 EnergyShieldDepletedEffect;
        [NMS(Index = 36)]
        /* 0x5E8 */ public NMSString0x10 EnergyShieldStartRechargeEffect;
        [NMS(Index = 37)]
        /* 0x5F8 */ public NMSString0x10 EnergyShieldStartRechargeFromDepletedEffect;
        [NMS(Index = 145)]
        /* 0x608 */ public VariableSizeString HangarFilename;
        [NMS(Index = 144)]
        /* 0x618 */ public VariableSizeString LegacyHangarFilename;
        [NMS(Index = 132)]
        /* 0x628 */ public List<Vector2f> SpaceBattleGuardsRange;
        [NMS(Index = 131)]
        /* 0x638 */ public List<Vector2f> SpaceBattlePirateRange;
        [NMS(Index = 125)]
        /* 0x648 */ public List<Vector2f> SpaceBattleSpawnAngle;
        [NMS(Index = 127)]
        /* 0x658 */ public List<Vector2f> SpaceBattleSpawnOffset;
        [NMS(Index = 126)]
        /* 0x668 */ public List<Vector2f> SpaceBattleSpawnPitch;
        [NMS(Index = 130)]
        /* 0x678 */ public List<Vector2f> SpaceBattleSpawnRange;
        [NMS(Index = 129)]
        /* 0x688 */ public List<Vector2f> SpaceBattleSunAroundAngle;
        [NMS(Index = 128)]
        /* 0x698 */ public List<Vector2f> SpaceBattleSunHeightAngle;
        [NMS(Index = 276)]
        /* 0x6A8 */ public List<Colour> TradeRouteColours;
        [NMS(Index = 78)]
        /* 0x6B8 */ public GcCombatEffectsComponentData CombatEffectsComponentData;
        [NMS(Index = 360)]
        /* 0x700 */ public GcProjectileLineData ShipBullet;
        [NMS(Index = 417)]
        /* 0x728 */ public GcShipAIDeathData Death;
        [NMS(Index = 151)]
        /* 0x744 */ public TkHitCurveData FreighterLightHitCurve;
        [NMS(Index = 139)]
        /* 0x750 */ public Vector2f ConeSpawnOffsetFactor;
        [NMS(Index = 180)]
        /* 0x758 */ public Vector2f FreighterMiniSpeeds;
        [NMS(Index = 177)]
        /* 0x760 */ public Vector2f PirateFreighterAttackRange;
        [NMS(Index = 281)]
        /* 0x768 */ public Vector2f PoliceSideOffset;
        [NMS(Index = 282)]
        /* 0x770 */ public Vector2f PoliceUpOffset;
        [NMS(Index = 203)]
        /* 0x778 */ public float AbandonedSystemShipSpawnProbablity;
        [NMS(Index = 254)]
        /* 0x77C */ public float ArrivalStaggerOffset;
        [NMS(Index = 84)]
        /* 0x780 */ public float AsteroidMiningMaxAsteroidRadius;
        [NMS(Index = 90)]
        /* 0x784 */ public float AsteroidMiningMaxMiningTime;
        [NMS(Index = 87)]
        /* 0x788 */ public float AsteroidMiningMaxViewAnglePitch;
        [NMS(Index = 85)]
        /* 0x78C */ public float AsteroidMiningMaxViewAngleYaw;
        [NMS(Index = 88)]
        /* 0x790 */ public float AsteroidMiningMinDistFromPlayer;
        [NMS(Index = 89)]
        /* 0x794 */ public float AsteroidMiningMinMiningAngle;
        [NMS(Index = 86)]
        /* 0x798 */ public float AsteroidMiningMinViewAnglePitch;
        [NMS(Index = 83)]
        /* 0x79C */ public float AsteroidMiningSearchRadius;
        [NMS(Index = 195)]
        /* 0x7A0 */ public float AsteroidShootAngle;
        [NMS(Index = 409)]
        /* 0x7A4 */ public float AtmosphereEffectMax;
        [NMS(Index = 408)]
        /* 0x7A8 */ public float AtmosphereEffectMin;
        [NMS(Index = 402)]
        /* 0x7AC */ public float AtmosphereTerminalSpeed;
        [NMS(Index = 179)]
        /* 0x7B0 */ public float AttackAfterSpawnTime;
        [NMS(Index = 313)]
        /* 0x7B4 */ public float AttackAimTime;
        [NMS(Index = 182)]
        /* 0x7B8 */ public float AttackBuildingApproachDistance;
        [NMS(Index = 184)]
        /* 0x7BC */ public float AttackBuildingAttackRunDistTolerance;
        [NMS(Index = 186)]
        /* 0x7C0 */ public float AttackBuildingBugOutDistance;
        [NMS(Index = 188)]
        /* 0x7C4 */ public float AttackBuildingBugOutSpeedUp;
        [NMS(Index = 187)]
        /* 0x7C8 */ public float AttackBuildingBugOutTurnUp;
        [NMS(Index = 185)]
        /* 0x7CC */ public float AttackBuildingFiringAngleTolerance;
        [NMS(Index = 181)]
        /* 0x7D0 */ public float AttackBuildingGetThereBoost;
        [NMS(Index = 192)]
        /* 0x7D4 */ public float AttackBuildingNextRunAngleDeltaMax;
        [NMS(Index = 191)]
        /* 0x7D8 */ public float AttackBuildingNextRunAngleDeltaMin;
        [NMS(Index = 190)]
        /* 0x7DC */ public float AttackBuildingRunAngleMax;
        [NMS(Index = 189)]
        /* 0x7E0 */ public float AttackBuildingRunAngleMin;
        [NMS(Index = 183)]
        /* 0x7E4 */ public float AttackBuildingRunStartDistance;
        [NMS(Index = 194)]
        /* 0x7E8 */ public float AttackBuildingTargetGroundOffsetScaleEnd;
        [NMS(Index = 193)]
        /* 0x7EC */ public float AttackBuildingTargetGroundOffsetScaleStart;
        [NMS(Index = 173)]
        /* 0x7F0 */ public float AttackFreighterAngle;
        [NMS(Index = 160)]
        /* 0x7F4 */ public float AttackFreighterApproach;
        [NMS(Index = 163)]
        /* 0x7F8 */ public float AttackFreighterApproachDistance;
        [NMS(Index = 164)]
        /* 0x7FC */ public float AttackFreighterAttackRunStartDistance;
        [NMS(Index = 165)]
        /* 0x800 */ public float AttackFreighterBugOutDistance;
        [NMS(Index = 167)]
        /* 0x804 */ public float AttackFreighterButOutSpeedUp;
        [NMS(Index = 166)]
        /* 0x808 */ public float AttackFreighterButOutTurnUp;
        [NMS(Index = 159)]
        /* 0x80C */ public float AttackFreighterGetThereBoost;
        [NMS(Index = 174)]
        /* 0x810 */ public float AttackFreighterRunOffset;
        [NMS(Index = 161)]
        /* 0x814 */ public float AttackFreighterWingmanAlignMinDist;
        [NMS(Index = 162)]
        /* 0x818 */ public float AttackFreighterWingmanAlignRange;
        [NMS(Index = 171)]
        /* 0x81C */ public float AttackFreighterWingmanLock;
        [NMS(Index = 170)]
        /* 0x820 */ public float AttackFreighterWingmanLockAlign;
        [NMS(Index = 172)]
        /* 0x824 */ public float AttackFreighterWingmanMaxForce;
        [NMS(Index = 169)]
        /* 0x828 */ public float AttackFreighterWingmanOffset;
        [NMS(Index = 168)]
        /* 0x82C */ public float AttackFreighterWingmanRadius;
        [NMS(Index = 175)]
        /* 0x830 */ public float AttackFreighterWingmanStart;
        [NMS(Index = 92)]
        /* 0x834 */ public float AttackMinimumTimeBeforeTargetSwitch;
        [NMS(Index = 314)]
        /* 0x838 */ public float AttackRunSlowdown;
        [NMS(Index = 91)]
        /* 0x83C */ public float AttackShipAvoidStartTime;
        [NMS(Index = 72)]
        /* 0x840 */ public float AttackTooCloseMinRelSpeed;
        [NMS(Index = 240)]
        /* 0x844 */ public float BattleSpawnStationMinDistance;
        [NMS(Index = 205)]
        /* 0x848 */ public float BountySpawnAngle;
        [NMS(Index = 403)]
        /* 0x84C */ public float CircleApproachDistance;
        [NMS(Index = 98)]
        /* 0x850 */ public float CollisionRayLengthMax;
        [NMS(Index = 97)]
        /* 0x854 */ public float CollisionRayLengthMin;
        [NMS(Index = 234)]
        /* 0x858 */ public float CollisionReactionTime;
        [NMS(Index = 141)]
        /* 0x85C */ public float ConeSpawnFlattenDown;
        [NMS(Index = 140)]
        /* 0x860 */ public float ConeSpawnFlattenUp;
        [NMS(Index = 56)]
        /* 0x864 */ public float CrashedShipBrokenSlotChance;
        [NMS(Index = 57)]
        /* 0x868 */ public float CrashedShipBrokenTechChance;
        [NMS(Index = 59)]
        /* 0x86C */ public float CrashedShipGeneralCostDiscount;
        [NMS(Index = 54)]
        /* 0x870 */ public int CrashedShipMinNonBrokenSlots;
        [NMS(Index = 58)]
        /* 0x874 */ public float CrashedShipRepairSlotCostIncreaseFactor;
        [NMS(Index = 60)]
        /* 0x878 */ public float CrashedShipTechSlotsCostDiscount;
        [NMS(Index = 279)]
        /* 0x87C */ public float DirectionBrakeThresholdSq;
        [NMS(Index = 69)]
        /* 0x880 */ public float DistanceFlareFlickerAmp;
        [NMS(Index = 68)]
        /* 0x884 */ public float DistanceFlareFlickerFreq;
        [NMS(Index = 65)]
        /* 0x888 */ public float DistanceFlareMaxScale;
        [NMS(Index = 62)]
        /* 0x88C */ public float DistanceFlareMinDistance;
        [NMS(Index = 64)]
        /* 0x890 */ public float DistanceFlareMinScale;
        [NMS(Index = 66)]
        /* 0x894 */ public float DistanceFlareMinSpeed;
        [NMS(Index = 63)]
        /* 0x898 */ public float DistanceFlareRange;
        [NMS(Index = 67)]
        /* 0x89C */ public float DistanceFlareSpeedRange;
        [NMS(Index = 390)]
        /* 0x8A0 */ public float DockingLandingBounceHeight;
        [NMS(Index = 389)]
        /* 0x8A4 */ public float DockingLandingBounceTime;
        [NMS(Index = 386)]
        /* 0x8A8 */ public float DockingLandingTime;
        [NMS(Index = 387)]
        /* 0x8AC */ public float DockingLandingTimeDirectional;
        [NMS(Index = 392)]
        /* 0x8B0 */ public float DockingRotateSpeed;
        [NMS(Index = 391)]
        /* 0x8B4 */ public float DockingRotateStartTime;
        [NMS(Index = 388)]
        /* 0x8B8 */ public float DockingSpringTime;
        [NMS(Index = 26)]
        /* 0x8BC */ public float DockingWaitDistance;
        [NMS(Index = 394)]
        /* 0x8C0 */ public float DockWaitMaxTime;
        [NMS(Index = 393)]
        /* 0x8C4 */ public float DockWaitMinTime;
        [NMS(Index = 42)]
        /* 0x8C8 */ public float EnergyShieldFadeInRate;
        [NMS(Index = 39)]
        /* 0x8CC */ public float EnergyShieldFadeMinOpacityInCombat;
        [NMS(Index = 41)]
        /* 0x8D0 */ public float EnergyShieldFadeNonPlayerHitOpacity;
        [NMS(Index = 43)]
        /* 0x8D4 */ public float EnergyShieldFadeOutRate;
        [NMS(Index = 40)]
        /* 0x8D8 */ public float EnergyShieldFreighterFadeMinOpacityInCombat;
        [NMS(Index = 311)]
        /* 0x8DC */ public float EngineFireSize;
        [NMS(Index = 305)]
        /* 0x8E0 */ public float EngineFlareAccelMax;
        [NMS(Index = 304)]
        /* 0x8E4 */ public float EngineFlareAccelMin;
        [NMS(Index = 310)]
        /* 0x8E8 */ public float EngineFlareOffset;
        [NMS(Index = 307)]
        /* 0x8EC */ public float EngineFlareSizeMax;
        [NMS(Index = 306)]
        /* 0x8F0 */ public float EngineFlareSizeMin;
        [NMS(Index = 308)]
        /* 0x8F4 */ public float EngineFlareVibrateAmp;
        [NMS(Index = 309)]
        /* 0x8F8 */ public float EngineFlareVibrateFreq;
        [NMS(Index = 53)]
        /* 0x8FC */ public float EscapeRoll;
        [NMS(Index = 52)]
        /* 0x900 */ public float EscapeRollPlanet;
        [NMS(Index = 51)]
        /* 0x904 */ public float EscapeRollTime;
        [NMS(Index = 50)]
        /* 0x908 */ public float EscapeRollTimePlanet;
        [NMS(Index = 414)]
        /* 0x90C */ public float FinalDeathExplosionScale;
        [NMS(Index = 415)]
        /* 0x910 */ public float FinalDeathExplosionTime;
        [NMS(Index = 416)]
        /* 0x914 */ public float FinalDeathFadeTime;
        [NMS(Index = 204)]
        /* 0x918 */ public int FlybyCloseOdds;
        [NMS(Index = 358)]
        /* 0x91C */ public float FlybyHeight;
        [NMS(Index = 357)]
        /* 0x920 */ public float FlybyLength;
        [NMS(Index = 359)]
        /* 0x924 */ public float FlybyOffset;
        [NMS(Index = 77)]
        /* 0x928 */ public float FlybyPlanetLandingProbability;
        [NMS(Index = 143)]
        /* 0x92C */ public float FreighterAlertLightCapitalSize;
        [NMS(Index = 153)]
        /* 0x930 */ public float FreighterAlertLightIntensity;
        [NMS(Index = 152)]
        /* 0x934 */ public float FreighterAlertLightTime;
        [NMS(Index = 287)]
        /* 0x938 */ public float FreighterAlertThreshold;
        [NMS(Index = 291)]
        /* 0x93C */ public float FreighterAlertTimeOutMinTime;
        [NMS(Index = 290)]
        /* 0x940 */ public float FreighterAlertTimeOutRate;
        [NMS(Index = 289)]
        /* 0x944 */ public float FreighterAttackAlertThreshold;
        [NMS(Index = 288)]
        /* 0x948 */ public float FreighterAttackDisengageDistance;
        [NMS(Index = 286)]
        /* 0x94C */ public float FreighterImpactScale;
        [NMS(Index = 294)]
        /* 0x950 */ public float FreighterLaunchStartTime;
        [NMS(Index = 293)]
        /* 0x954 */ public float FreighterLaunchTime;
        [NMS(Index = 297)]
        /* 0x958 */ public int FreighterMaxNumLaunchedShips;
        [NMS(Index = 296)]
        /* 0x95C */ public float FreighterRegisterHitCooldown;
        [NMS(Index = 235)]
        /* 0x960 */ public float FreighterScale;
        [NMS(Index = 292)]
        /* 0x964 */ public float FreighterShipLaunchSpeed;
        [NMS(Index = 298)]
        /* 0x968 */ public float FreighterSpawnMargin;
        [NMS(Index = 299)]
        /* 0x96C */ public float FreighterSpawnRadius;
        [NMS(Index = 300)]
        /* 0x970 */ public float FreighterSpawnRate;
        [NMS(Index = 301)]
        /* 0x974 */ public float FreighterSpawnViewAngle;
        [NMS(Index = 302)]
        /* 0x978 */ public float FreighterSpawnVisibleFreightersDistance;
        [NMS(Index = 303)]
        /* 0x97C */ public float FrigateSpawnMargin;
        [NMS(Index = 405)]
        /* 0x980 */ public float GroundCircleHeight;
        [NMS(Index = 406)]
        /* 0x984 */ public float GroundCircleHeightMax;
        [NMS(Index = 229)]
        /* 0x988 */ public float HeightTestSampleDistance;
        [NMS(Index = 230)]
        /* 0x98C */ public float HeightTestSampleTime;
        [NMS(Index = 401)]
        /* 0x990 */ public float LandingDirectionalHoverPointReachedDistance;
        [NMS(Index = 400)]
        /* 0x994 */ public float LandingHoverPointReachedDistance;
        [NMS(Index = 124)]
        /* 0x998 */ public float LandingLongTipAngle;
        [NMS(Index = 399)]
        /* 0x99C */ public float LandingManeuvreAlignTime;
        [NMS(Index = 398)]
        /* 0x9A0 */ public float LandingManuevreTime;
        [NMS(Index = 123)]
        /* 0x9A4 */ public float LandingTipAngle;
        [NMS(Index = 278)]
        /* 0x9A8 */ public float LaserHitOffset;
        [NMS(Index = 14)]
        /* 0x9AC */ public float MaxDifficultySpaceCombatSpeedExtra;
        [NMS(Index = 13)]
        /* 0x9B0 */ public float MaxDifficultySpaceCombatTurnExtra;
        [NMS(Index = 29)]
        /* 0x9B4 */ public int MaxNumActivePolice;
        [NMS(Index = 30)]
        /* 0x9B8 */ public float MaxNumActivePoliceRadius;
        [NMS(Index = 28)]
        /* 0x9BC */ public float MaxNumActiveTraderRadius;
        [NMS(Index = 27)]
        /* 0x9C0 */ public int MaxNumActiveTraders;
        [NMS(Index = 237)]
        /* 0x9C4 */ public int MaxNumFreighters;
        [NMS(Index = 154)]
        /* 0x9C8 */ public int MaxNumTurretMissiles;
        [NMS(Index = 410)]
        /* 0x9CC */ public float MaxTorque;
        [NMS(Index = 31)]
        /* 0x9D0 */ public int MinAggroDamage;
        [NMS(Index = 15)]
        /* 0x9D4 */ public float MinimumCircleTimeBeforeLanding;
        [NMS(Index = 16)]
        /* 0x9D8 */ public float MinimumTimeBetweenOutpostLandings;
        [NMS(Index = 44)]
        /* 0x9DC */ public float MinLaserFireTime;
        [NMS(Index = 178)]
        /* 0x9E0 */ public float MissileLaunchSpeed;
        [NMS(Index = 147)]
        /* 0x9E4 */ public float MissileRange;
        [NMS(Index = 317)]
        /* 0x9E8 */ public float MoveAvoidRange;
        [NMS(Index = 316)]
        /* 0x9EC */ public float MoveHeightAdjust;
        [NMS(Index = 320)]
        /* 0x9F0 */ public float MoveHeightCheckTime;
        [NMS(Index = 318)]
        /* 0x9F4 */ public int MoveHeightNumSamples;
        [NMS(Index = 319)]
        /* 0x9F8 */ public float MoveHeightSampleSectionSize;
        [NMS(Index = 407)]
        /* 0x9FC */ public float OrbitHeight;
        [NMS(Index = 116)]
        /* 0xA00 */ public float OutpostDockAIApproachSpeedForce;
        [NMS(Index = 115)]
        /* 0xA04 */ public float OutpostDockAIGetToApproachBrakeForce;
        [NMS(Index = 114)]
        /* 0xA08 */ public float OutpostDockAIGetToApproachForce;
        [NMS(Index = 112)]
        /* 0xA0C */ public float OutpostDockApproachDistance;
        [NMS(Index = 122)]
        /* 0xA10 */ public float OutpostDockApproachRenderFlickerOffset;
        [NMS(Index = 121)]
        /* 0xA14 */ public float OutpostDockApproachRenderRadius;
        [NMS(Index = 111)]
        /* 0xA18 */ public float OutpostDockApproachSpeedForce;
        [NMS(Index = 113)]
        /* 0xA1C */ public float OutpostDockApproachSpeedUpDamper;
        [NMS(Index = 120)]
        /* 0xA20 */ public float OutpostDockApproachUpAmount;
        [NMS(Index = 109)]
        /* 0xA24 */ public float OutpostDockGetToApproachBrakeForce;
        [NMS(Index = 110)]
        /* 0xA28 */ public float OutpostDockGetToApproachExtraBrakeForce;
        [NMS(Index = 108)]
        /* 0xA2C */ public float OutpostDockGetToApproachForce;
        [NMS(Index = 106)]
        /* 0xA30 */ public float OutpostDockMaxApproachSpeed;
        [NMS(Index = 117)]
        /* 0xA34 */ public float OutpostDockMaxForce;
        [NMS(Index = 119)]
        /* 0xA38 */ public float OutpostDockMaxTipLength;
        [NMS(Index = 118)]
        /* 0xA3C */ public float OutpostDockMinTipLength;
        [NMS(Index = 107)]
        /* 0xA40 */ public float OutpostDockOverspeedBrake;
        [NMS(Index = 105)]
        /* 0xA44 */ public float OutpostDockUpAlignMaxAngle;
        [NMS(Index = 104)]
        /* 0xA48 */ public float OutpostDockUpAlignMaxAngleFirstPerson;
        [NMS(Index = 102)]
        /* 0xA4C */ public float OutpostLandingNoiseAmp;
        [NMS(Index = 101)]
        /* 0xA50 */ public float OutpostLandingNoiseFreq;
        [NMS(Index = 103)]
        /* 0xA54 */ public float OutpostLandingNoiseOffset;
        [NMS(Index = 231)]
        /* 0xA58 */ public float OutpostToLandingDistance;
        [NMS(Index = 221)]
        /* 0xA5C */ public float PirateArriveTime;
        [NMS(Index = 225)]
        /* 0xA60 */ public float PirateBattleInterestTime;
        [NMS(Index = 220)]
        /* 0xA64 */ public float PirateBattleMaxTime;
        [NMS(Index = 223)]
        /* 0xA68 */ public float PirateBattleStartSpeed;
        [NMS(Index = 93)]
        /* 0xA6C */ public float PirateExtraDamage;
        [NMS(Index = 356)]
        /* 0xA70 */ public float PirateFlybyLength;
        [NMS(Index = 226)]
        /* 0xA74 */ public float PirateFreighterBattleDistance;
        [NMS(Index = 216)]
        /* 0xA78 */ public float PirateFreighterSpawnAttackAngle;
        [NMS(Index = 217)]
        /* 0xA7C */ public float PirateFreighterSpawnAttackOffset;
        [NMS(Index = 218)]
        /* 0xA80 */ public float PirateFreighterSpawnAttackSpread;
        [NMS(Index = 176)]
        /* 0xA84 */ public float PirateFreighterWarpOffset;
        [NMS(Index = 224)]
        /* 0xA88 */ public float PirateInterestTime;
        [NMS(Index = 95)]
        /* 0xA8C */ public float PirateMaintainBuildingTargetTime;
        [NMS(Index = 315)]
        /* 0xA90 */ public float PiratePlayerAttackRange;
        [NMS(Index = 219)]
        /* 0xA94 */ public float PirateSpawnAngle;
        [NMS(Index = 61)]
        /* 0xA98 */ public float PirateSpawnSpacing;
        [NMS(Index = 222)]
        /* 0xA9C */ public float PirateStartSpeed;
        [NMS(Index = 312)]
        /* 0xAA0 */ public float PitchFlip;
        [NMS(Index = 46)]
        /* 0xAA4 */ public float PlanetaryPirateHostileShipPerceptionRange;
        [NMS(Index = 47)]
        /* 0xAA8 */ public float PlanetaryPirateRaidFocusBuildingsTime;
        [NMS(Index = 49)]
        /* 0xAAC */ public int PlanetaryPirateRaidMaxTradersJoinCombat;
        [NMS(Index = 48)]
        /* 0xAB0 */ public float PlanetaryPirateRaidTradersEngageTime;
        [NMS(Index = 233)]
        /* 0xAB4 */ public float PlanetUpAlignTime;
        [NMS(Index = 252)]
        /* 0xAB8 */ public float PoliceAbortRange;
        [NMS(Index = 251)]
        /* 0xABC */ public float PoliceArriveTime;
        [NMS(Index = 249)]
        /* 0xAC0 */ public float PoliceEntranceCargoAttackWaitTime;
        [NMS(Index = 248)]
        /* 0xAC4 */ public float PoliceEntranceCargoOpenCommsWaitTime;
        [NMS(Index = 247)]
        /* 0xAC8 */ public float PoliceEntranceCargoProbingTime;
        [NMS(Index = 250)]
        /* 0xACC */ public float PoliceEntranceCargoScanHailNotificationWaitTime;
        [NMS(Index = 246)]
        /* 0xAD0 */ public float PoliceEntranceCargoScanStartTime;
        [NMS(Index = 245)]
        /* 0xAD4 */ public float PoliceEntranceEscalateIncomingTime;
        [NMS(Index = 244)]
        /* 0xAD8 */ public float PoliceEntranceEscalateProbingTime;
        [NMS(Index = 243)]
        /* 0xADC */ public float PoliceEntranceProbe;
        [NMS(Index = 242)]
        /* 0xAE0 */ public float PoliceEntranceStartTime;
        [NMS(Index = 211)]
        /* 0xAE4 */ public float PoliceEscapeMinTime;
        [NMS(Index = 210)]
        /* 0xAE8 */ public float PoliceEscapeTime;
        [NMS(Index = 5)]
        /* 0xAEC */ public float PoliceFreighterLaserActiveTime;
        [NMS(Index = 4)]
        /* 0xAF0 */ public float PoliceFreighterLaserRandomExtraPauseMax;
        [NMS(Index = 2)]
        /* 0xAF4 */ public float PoliceFreighterLaserRange;
        [NMS(Index = 3)]
        /* 0xAF8 */ public float PoliceFreighterLaserShootTime;
        [NMS(Index = 7)]
        /* 0xAFC */ public int PoliceFreighterProjectileBurstCount;
        [NMS(Index = 8)]
        /* 0xB00 */ public float PoliceFreighterProjectileBurstTime;
        [NMS(Index = 11)]
        /* 0xB04 */ public int PoliceFreighterProjectileModulo;
        [NMS(Index = 9)]
        /* 0xB08 */ public float PoliceFreighterProjectilePauseTime;
        [NMS(Index = 10)]
        /* 0xB0C */ public float PoliceFreighterProjectileRandomExtraPauseMax;
        [NMS(Index = 6)]
        /* 0xB10 */ public float PoliceFreighterProjectileRange;
        [NMS(Index = 146)]
        /* 0xB14 */ public float PoliceFreighterWarpOutRange;
        [NMS(Index = 323)]
        /* 0xB18 */ public float PoliceLaunchDistance;
        [NMS(Index = 206)]
        /* 0xB1C */ public float PoliceLaunchSpeed;
        [NMS(Index = 207)]
        /* 0xB20 */ public float PoliceLaunchTime;
        [NMS(Index = 280)]
        /* 0xB24 */ public int PoliceNumPerTarget;
        [NMS(Index = 208)]
        /* 0xB28 */ public float PolicePauseTime;
        [NMS(Index = 209)]
        /* 0xB2C */ public float PolicePauseTimeSpaceBattle;
        [NMS(Index = 241)]
        /* 0xB30 */ public float PoliceSpawnViewAngle;
        [NMS(Index = 213)]
        /* 0xB34 */ public float PoliceStationEngageRange;
        [NMS(Index = 214)]
        /* 0xB38 */ public int PoliceStationNumToLaunch;
        [NMS(Index = 212)]
        /* 0xB3C */ public float PoliceStationWaveTimer;
        [NMS(Index = 253)]
        /* 0xB40 */ public float PoliceWarnBeaconPulseTime;
        [NMS(Index = 76)]
        /* 0xB44 */ public float RewardLootAngularSpeed;
        [NMS(Index = 74)]
        /* 0xB48 */ public float RewardLootOffset;
        [NMS(Index = 75)]
        /* 0xB4C */ public float RewardLootOffsetSpeed;
        [NMS(Index = 412)]
        /* 0xB50 */ public float RollAmount;
        [NMS(Index = 413)]
        /* 0xB54 */ public float RollMinTurnAngle;
        [NMS(Index = 24)]
        /* 0xB58 */ public float SalvageRemovalTime;
        [NMS(Index = 23)]
        /* 0xB5C */ public float SalvageTime;
        [NMS(Index = 25)]
        /* 0xB60 */ public float SalvageValueMultiplier;
        [NMS(Index = 329)]
        /* 0xB64 */ public float ScaleHeightMax;
        [NMS(Index = 328)]
        /* 0xB68 */ public float ScaleHeightMin;
        [NMS(Index = 324)]
        /* 0xB6C */ public float Scaler;
        [NMS(Index = 327)]
        /* 0xB70 */ public float ScalerMaxDist;
        [NMS(Index = 326)]
        /* 0xB74 */ public float ScalerMinDist;
        [NMS(Index = 325)]
        /* 0xB78 */ public float ScaleTime;
        [NMS(Index = 55)]
        /* 0xB7C */ public float SentinelGunBrokenSlotChance;
        [NMS(Index = 96)]
        /* 0xB80 */ public float ShieldCollisionRadiusMultiplier;
        [NMS(Index = 45)]
        /* 0xB84 */ public float ShipAlertPirateRange;
        [NMS(Index = 411)]
        /* 0xB88 */ public float ShipAngularFactor;
        [NMS(Index = 345)]
        /* 0xB8C */ public float ShipEscapeTimeBeforeWarpOut;
        [NMS(Index = 350)]
        /* 0xB90 */ public float ShipEscortBackForceTime;
        [NMS(Index = 355)]
        /* 0xB94 */ public float ShipEscortForwardOffsetScaleMax;
        [NMS(Index = 354)]
        /* 0xB98 */ public float ShipEscortForwardOffsetScaleMin;
        [NMS(Index = 349)]
        /* 0xB9C */ public float ShipEscortFwdForceTime;
        [NMS(Index = 346)]
        /* 0xBA0 */ public float ShipEscortLockOnDistance;
        [NMS(Index = 351)]
        /* 0xBA4 */ public float ShipEscortPerpForceTime;
        [NMS(Index = 353)]
        /* 0xBA8 */ public float ShipEscortRadialOffsetScaleMax;
        [NMS(Index = 352)]
        /* 0xBAC */ public float ShipEscortRadialOffsetScaleMin;
        [NMS(Index = 347)]
        /* 0xBB0 */ public float ShipEscortVelocityBand;
        [NMS(Index = 348)]
        /* 0xBB4 */ public float ShipEscortVelocityBandForce;
        [NMS(Index = 239)]
        /* 0xBB8 */ public float ShipSpawnAnomalyRadius;
        [NMS(Index = 238)]
        /* 0xBBC */ public float ShipSpawnStationRadius;
        [NMS(Index = 138)]
        /* 0xBC0 */ public float SpaceBattleFlybyTime;
        [NMS(Index = 133)]
        /* 0xBC4 */ public float SpaceBattleGuardOffset;
        [NMS(Index = 134)]
        /* 0xBC8 */ public float SpaceBattleGuardUpOffset;
        [NMS(Index = 136)]
        /* 0xBCC */ public float SpaceBattleInitialPirateOffset;
        [NMS(Index = 135)]
        /* 0xBD0 */ public float SpaceBattleInitialPirateUpOffset;
        [NMS(Index = 137)]
        /* 0xBD4 */ public float SpaceBattleObstructionRadius;
        [NMS(Index = 202)]
        /* 0xBD8 */ public float SpaceStationTraderRequestTime;
        [NMS(Index = 396)]
        /* 0xBDC */ public float TakeOffExitHeightOffset;
        [NMS(Index = 397)]
        /* 0xBE0 */ public float TakeOffExtraAIHeight;
        [NMS(Index = 395)]
        /* 0xBE4 */ public float TakeOffHoverPointReachedDistance;
        [NMS(Index = 227)]
        /* 0xBE8 */ public float TraderArriveSpeed;
        [NMS(Index = 228)]
        /* 0xBEC */ public float TraderArriveTime;
        [NMS(Index = 376)]
        /* 0xBF0 */ public float TraderAtTime;
        [NMS(Index = 377)]
        /* 0xBF4 */ public float TraderAtTimeBack;
        [NMS(Index = 215)]
        /* 0xBF8 */ public int TraderIgnoreHits;
        [NMS(Index = 272)]
        /* 0xBFC */ public int TradeRouteDivisions;
        [NMS(Index = 274)]
        /* 0xC00 */ public float TradeRouteFlickerAmp;
        [NMS(Index = 273)]
        /* 0xC04 */ public float TradeRouteFlickerFreq;
        [NMS(Index = 262)]
        /* 0xC08 */ public float TradeRouteFollowOffset;
        [NMS(Index = 275)]
        /* 0xC0C */ public int TradeRouteMaxNum;
        [NMS(Index = 261)]
        /* 0xC10 */ public float TradeRouteSeekOutpostRange;
        [NMS(Index = 270)]
        /* 0xC14 */ public float TradeRouteSlowRange;
        [NMS(Index = 271)]
        /* 0xC18 */ public float TradeRouteSlowSpeed;
        [NMS(Index = 264)]
        /* 0xC1C */ public float TradeRouteSpawnDistance;
        [NMS(Index = 269)]
        /* 0xC20 */ public float TradeRouteSpeed;
        [NMS(Index = 268)]
        /* 0xC24 */ public float TradeRouteStationRadius;
        [NMS(Index = 265)]
        /* 0xC28 */ public float TradeRouteTrailDrawDistance;
        [NMS(Index = 266)]
        /* 0xC2C */ public float TradeRouteTrailFadeTime;
        [NMS(Index = 267)]
        /* 0xC30 */ public float TradeRouteTrailTimeOffset;
        [NMS(Index = 378)]
        /* 0xC34 */ public float TraderPerpTime;
        [NMS(Index = 198)]
        /* 0xC38 */ public float TraderPostCombatRequestTime;
        [NMS(Index = 197)]
        /* 0xC3C */ public float TraderRequestTime;
        [NMS(Index = 379)]
        /* 0xC40 */ public float TraderVelocityBand;
        [NMS(Index = 380)]
        /* 0xC44 */ public float TraderVelocityBandForce;
        [NMS(Index = 196)]
        /* 0xC48 */ public float TraderWantedTime;
        [NMS(Index = 200)]
        /* 0xC4C */ public float TradingPostTraderRange;
        [NMS(Index = 201)]
        /* 0xC50 */ public float TradingPostTraderRangeSpace;
        [NMS(Index = 199)]
        /* 0xC54 */ public float TradingPostTraderRequestTime;
        [NMS(Index = 32)]
        /* 0xC58 */ public float TrailLandingFadeTime;
        [NMS(Index = 256)]
        /* 0xC5C */ public float TrailScale;
        [NMS(Index = 259)]
        /* 0xC60 */ public float TrailScaleFreighterMaxScale;
        [NMS(Index = 258)]
        /* 0xC64 */ public float TrailScaleMaxScale;
        [NMS(Index = 255)]
        /* 0xC68 */ public float TrailScaleMinDistance;
        [NMS(Index = 257)]
        /* 0xC6C */ public float TrailScaleRange;
        [NMS(Index = 385)]
        /* 0xC70 */ public float TrailSpeedFadeFalloff;
        [NMS(Index = 384)]
        /* 0xC74 */ public float TrailSpeedFadeMinSpeed;
        [NMS(Index = 404)]
        /* 0xC78 */ public float TravelMinBoostTime;
        [NMS(Index = 156)]
        /* 0xC7C */ public float TurretAlertLightIntensity;
        [NMS(Index = 155)]
        /* 0xC80 */ public float TurretOriginOffset;
        [NMS(Index = 322)]
        /* 0xC84 */ public float TurretRandomAIShipOffset;
        [NMS(Index = 321)]
        /* 0xC88 */ public float TurretRandomOffset;
        [NMS(Index = 17)]
        /* 0xC8C */ public float VisibleDistance;
        [NMS(Index = 334)]
        /* 0xC90 */ public float WarpFadeInTime;
        [NMS(Index = 383)]
        /* 0xC94 */ public float WarpForce;
        [NMS(Index = 341)]
        /* 0xC98 */ public float WarpInAudioFXDelay;
        [NMS(Index = 338)]
        /* 0xC9C */ public float WarpInDistance;
        [NMS(Index = 332)]
        /* 0xCA0 */ public float WarpInPlayerLocatorMinOffset;
        [NMS(Index = 331)]
        /* 0xCA4 */ public float WarpInPlayerLocatorTime;
        [NMS(Index = 339)]
        /* 0xCA8 */ public float WarpInPostSpeed;
        [NMS(Index = 340)]
        /* 0xCAC */ public float WarpInPostSpeedFreighter;
        [NMS(Index = 333)]
        /* 0xCB0 */ public float WarpInTime;
        [NMS(Index = 335)]
        /* 0xCB4 */ public float WarpInTimeFreighter;
        [NMS(Index = 337)]
        /* 0xCB8 */ public float WarpInVariance;
        [NMS(Index = 342)]
        /* 0xCBC */ public float WarpOutDistance;
        [NMS(Index = 382)]
        /* 0xCC0 */ public float WarpSpeed;
        [NMS(Index = 381)]
        /* 0xCC4 */ public float WingmanAlign;
        [NMS(Index = 371)]
        /* 0xCC8 */ public float WingmanAtTime;
        [NMS(Index = 372)]
        /* 0xCCC */ public float WingmanAtTimeBack;
        [NMS(Index = 365)]
        /* 0xCD0 */ public float WingmanHeightAdjust;
        [NMS(Index = 363)]
        /* 0xCD4 */ public float WingmanLockArriveTime;
        [NMS(Index = 362)]
        /* 0xCD8 */ public float WingmanLockBetweenTime;
        [NMS(Index = 361)]
        /* 0xCDC */ public float WingmanLockDistance;
        [NMS(Index = 364)]
        /* 0xCE0 */ public float WingmanMinHeight;
        [NMS(Index = 368)]
        /* 0xCE4 */ public float WingmanOffset;
        [NMS(Index = 367)]
        /* 0xCE8 */ public float WingmanOffsetStart;
        [NMS(Index = 373)]
        /* 0xCEC */ public float WingmanPerpTime;
        [NMS(Index = 370)]
        /* 0xCF0 */ public float WingmanRotate;
        [NMS(Index = 369)]
        /* 0xCF4 */ public float WingmanSideOffset;
        [NMS(Index = 366)]
        /* 0xCF8 */ public float WingmanStartTime;
        [NMS(Index = 374)]
        /* 0xCFC */ public float WingmanVelocityBand;
        [NMS(Index = 375)]
        /* 0xD00 */ public float WingmanVelocityBandForce;
        [NMS(Index = 283)]
        /* 0xD04 */ public float WitnessHearingRange;
        [NMS(Index = 285)]
        /* 0xD08 */ public float WitnessSightAngle;
        [NMS(Index = 284)]
        /* 0xD0C */ public float WitnessSightRange;
        [NMS(Index = 263)]
        /* 0xD10 */ public NMSString0x100 TradeRouteIcon;
        [NMS(Index = 94, Size = 0x37, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0xE10 */ public bool[] PirateAttackableBuildingClasses;
        [NMS(Index = 21)]
        /* 0xE47 */ public bool AtmosphereEffectEnabled;
        [NMS(Index = 70)]
        /* 0xE48 */ public bool AttackRepositionBoost;
        [NMS(Index = 71)]
        /* 0xE49 */ public bool AttackShipsFollowLeader;
        [NMS(Index = 158)]
        /* 0xE4A */ public bool DisableTradeRoutes;
        [NMS(Index = 12)]
        /* 0xE4B */ public bool DisplayShipAttackTypes;
        [NMS(Index = 277)]
        /* 0xE4C */ public bool EnableLoot;
        [NMS(Index = 38)]
        /* 0xE4D */ public bool EnergyShieldAlwaysVisible;
        [NMS(Index = 33)]
        /* 0xE4E */ public bool EnergyShieldsEnabled;
        [NMS(Index = 22)]
        /* 0xE4F */ public bool FillUpOutposts;
        [NMS(Index = 142)]
        /* 0xE50 */ public bool FreighterAlertLights;
        [NMS(Index = 295)]
        /* 0xE51 */ public bool FreighterIgnorePlayer;
        [NMS(Index = 19)]
        /* 0xE52 */ public bool FreightersAlwaysAttackPlayer;
        [NMS(Index = 232)]
        /* 0xE53 */ public bool FreightersSamePalette;
        [NMS(Index = 20)]
        /* 0xE54 */ public bool GroundEffectEnabled;
        [NMS(Index = 236)]
        /* 0xE55 */ public bool PoliceSpawnEffect;
        [NMS(Index = 330)]
        /* 0xE56 */ public bool ScaleDisabledWhenOnFreighter;
        [NMS(Index = 18)]
        /* 0xE57 */ public bool TradersAttackPirates;
        [NMS(Index = 260)]
        /* 0xE58 */ public TkCurveType TrailScaleCurve;
        [NMS(Index = 336)]
        /* 0xE59 */ public TkCurveType WarpInCurve;
    }
}
