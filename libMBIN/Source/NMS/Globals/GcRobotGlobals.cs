using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x4FD56F9FF57BB9E8, NameHash = 0x29022DE4)]
    public class GcRobotGlobals : NMSTemplate
    {
        [NMS(Index = 109)]
        /* 0x0000 */ public GcScanEffectData DroneScanEffect;
        [NMS(Index = 309)]
        /* 0x0050 */ public GcRobotLaserData QuadLaser;
        [NMS(Index = 308)]
        /* 0x00A0 */ public GcRobotLaserData WalkerLaser;
        [NMS(Index = 76)]
        /* 0x00F0 */ public Vector3f DroneCriticalOffset;
        [NMS(Index = 45)]
        /* 0x0100 */ public Vector3f DroneRepairOffset;
        [NMS(Index = 75)]
        /* 0x0110 */ public Vector3f QuadCriticalOffset;
        [NMS(Index = 77)]
        /* 0x0120 */ public Vector3f WalkerGunOffset1;
        [NMS(Index = 78)]
        /* 0x0130 */ public Vector3f WalkerGunOffset2;
        [NMS(Index = 223)]
        /* 0x0140 */ public Vector3f WalkerHeadEyeOffset;
        [NMS(Index = 313, Size = 0xD, EnumType = typeof(GcSentinelTypes.SentinelTypeEnum))]
        /* 0x0150 */ public GcSentinelDamagedData[] DamageData;
        [NMS(Index = 311, Size = 0x4, EnumType = typeof(GcSentinelQuadWeaponMode.SentinelQuadWeaponModeEnum))]
        /* 0x0490 */ public GcSentinelQuadWeaponData[] QuadWeapons;
        [NMS(Index = 111, Size = 0xD, EnumType = typeof(GcSentinelTypes.SentinelTypeEnum))]
        /* 0x07B0 */ public GcSentinelResource[] SentinelResources;
        [NMS(Index = 1)]
        /* 0x09B8 */ public GcCamouflageData RobotCamoData;
        [NMS(Index = 83)]
        /* 0x09E8 */ public NMSString0x10 AttackScan;
        [NMS(Index = 310)]
        /* 0x09F8 */ public List<GcDroneDataWithId> DroneControlData;
        [NMS(Index = 312)]
        /* 0x0A08 */ public List<GcDroneWeaponData> DroneWeapons;
        [NMS(Index = 2)]
        /* 0x0A18 */ public NMSString0x10 ForceDroneWeapon;
        [NMS(Index = 151)]
        /* 0x0A28 */ public NMSString0x10 RepairEffect;
        [NMS(Index = 182)]
        /* 0x0A38 */ public List<NMSString0x10> SentinelMechAvailableWeapons;
        [NMS(Index = 184)]
        /* 0x0A48 */ public List<GcSentinelMechWeaponData> SentinelMechWeaponData;
        [NMS(Index = 183)]
        /* 0x0A58 */ public List<NMSString0x10> StoneMechAvailableWeapons;
        [NMS(Index = 295)]
        /* 0x0A68 */ public NMSString0x10 SummonerDroneBuildupEffect;
        [NMS(Index = 296)]
        /* 0x0A78 */ public NMSString0x10 SummonerDroneSpawnEffect;
        [NMS(Index = 209)]
        /* 0x0A88 */ public List<NMSString0x20> WalkerLeftLegArmourNodes;
        [NMS(Index = 210)]
        /* 0x0A98 */ public List<NMSString0x20> WalkerRightLegArmourNodes;
        [NMS(Index = 206)]
        /* 0x0AA8 */ public NMSString0x10 WalkerTitanFallEffect;
        [NMS(Index = 208)]
        /* 0x0AB8 */ public NMSString0x10 WalkerTitanFallShake;
        [NMS(Index = 314, Size = 0xD, EnumType = typeof(GcSentinelTypes.SentinelTypeEnum))]
        /* 0x0AC8 */ public GcSentinelPounceBalance[] PounceData;
        [NMS(Index = 307, Size = 0xD, EnumType = typeof(GcSentinelTypes.SentinelTypeEnum))]
        /* 0x0C68 */ public float[] FireRateModifierScores;
        [NMS(Index = 110, Size = 0xD, EnumType = typeof(GcSentinelTypes.SentinelTypeEnum))]
        /* 0x0C9C */ public int[] SentinelSpawnLimits;
        [NMS(Index = 165)]
        /* 0x0CD0 */ public GcMechTargetSelectionWeightingSettings MechTargetSelectionWeightingSettings;
        [NMS(Index = 181)]
        /* 0x0D00 */ public Vector2f MechPatrolPauseTime;
        [NMS(Index = 51)]
        /* 0x0D08 */ public Vector2f QuadAttackTurnSpeeds;
        [NMS(Index = 48)]
        /* 0x0D10 */ public Vector2f QuadLookTurnSpeeds;
        [NMS(Index = 270)]
        /* 0x0D18 */ public Vector2f QuadPatrolPauseTime;
        [NMS(Index = 287)]
        /* 0x0D20 */ public float AttackMoveArrivalDistance;
        [NMS(Index = 286)]
        /* 0x0D24 */ public float AttackMoveMaxTime;
        [NMS(Index = 6)]
        /* 0x0D28 */ public int AttackSentinelWantedValue;
        [NMS(Index = 114)]
        /* 0x0D2C */ public float CollisionDistance;
        [NMS(Index = 93)]
        /* 0x0D30 */ public float CombatSpawnSquadRadiusDrones;
        [NMS(Index = 94)]
        /* 0x0D34 */ public float CombatSpawnSquadRadiusRobots;
        [NMS(Index = 53)]
        /* 0x0D38 */ public float CombatWaveSpawnTime;
        [NMS(Index = 143)]
        /* 0x0D3C */ public float CorruptedDroneRepairInteruptCooldownTime;
        [NMS(Index = 66)]
        /* 0x0D40 */ public float CriticalHitSizeDrone;
        [NMS(Index = 68)]
        /* 0x0D44 */ public float CriticalHitSizeMech;
        [NMS(Index = 67)]
        /* 0x0D48 */ public float CriticalHitSizeQuad;
        [NMS(Index = 69)]
        /* 0x0D4C */ public float CriticalHitSizeWalker;
        [NMS(Index = 101)]
        /* 0x0D50 */ public float DroneAggressiveInvestigateAttackTime;
        [NMS(Index = 52)]
        /* 0x0D54 */ public int DroneAggroDamage;
        [NMS(Index = 100)]
        /* 0x0D58 */ public float DroneAttackGetInRangeBoost;
        [NMS(Index = 29)]
        /* 0x0D5C */ public float DroneAttackMaxAngleDownFromPlayer;
        [NMS(Index = 28)]
        /* 0x0D60 */ public float DroneAttackPlayerHeightOffset;
        [NMS(Index = 92)]
        /* 0x0D64 */ public float DroneCombatSpawnAngle;
        [NMS(Index = 127)]
        /* 0x0D68 */ public float DroneCrimeCooldown;
        [NMS(Index = 128)]
        /* 0x0D6C */ public float DroneCrimeCooldownWaitTime;
        [NMS(Index = 129)]
        /* 0x0D70 */ public float DroneCrimeCooldownWaitTimeAtMax;
        [NMS(Index = 20)]
        /* 0x0D74 */ public float DroneCrimePostInvestigateWaitTime;
        [NMS(Index = 57)]
        /* 0x0D78 */ public float DroneCrimeWitnessInvestigateDistance;
        [NMS(Index = 105)]
        /* 0x0D7C */ public float DroneCriminalScanTime;
        [NMS(Index = 132)]
        /* 0x0D80 */ public float DroneDecisionTime;
        [NMS(Index = 99)]
        /* 0x0D84 */ public float DroneHeightAngle;
        [NMS(Index = 121)]
        /* 0x0D88 */ public float DroneHitImpulseCooldown;
        [NMS(Index = 117)]
        /* 0x0D8C */ public float DroneHitImpulseFlipForceDownBound;
        [NMS(Index = 120)]
        /* 0x0D90 */ public float DroneHitImpulseLaserMultiplier;
        [NMS(Index = 118)]
        /* 0x0D94 */ public float DroneHitImpulseMinVerticalComponentScale;
        [NMS(Index = 119)]
        /* 0x0D98 */ public float DroneHitImpulseMultiplier;
        [NMS(Index = 134)]
        /* 0x0D9C */ public float DroneInvestigateMaxPositionAngle;
        [NMS(Index = 15)]
        /* 0x0DA0 */ public float DroneInvestigateMinChaseRange;
        [NMS(Index = 136)]
        /* 0x0DA4 */ public float DroneInvestigateMinCrimeInterval;
        [NMS(Index = 133)]
        /* 0x0DA8 */ public float DroneInvestigateMinPositionAngle;
        [NMS(Index = 107)]
        /* 0x0DAC */ public float DroneInvestigateMinScanTime;
        [NMS(Index = 13)]
        /* 0x0DB0 */ public float DroneInvestigateMinWitnessRange;
        [NMS(Index = 14)]
        /* 0x0DB4 */ public float DroneInvestigateMinWitnessRangeCantSee;
        [NMS(Index = 16)]
        /* 0x0DB8 */ public float DroneInvestigateMinWitnessTime;
        [NMS(Index = 135)]
        /* 0x0DBC */ public float DroneInvestigateRepositionTime;
        [NMS(Index = 17)]
        /* 0x0DC0 */ public float DroneInvestigateSpeedBoost;
        [NMS(Index = 19)]
        /* 0x0DC4 */ public float DroneInvestigateSpeedBoostRange;
        [NMS(Index = 18)]
        /* 0x0DC8 */ public float DroneInvestigateSpeedBoostStartDistance;
        [NMS(Index = 138)]
        /* 0x0DCC */ public float DroneMaxScanAngle;
        [NMS(Index = 131)]
        /* 0x0DD0 */ public float DroneMaxScanLength;
        [NMS(Index = 86)]
        /* 0x0DD4 */ public float DroneMoveDistancePlayerMechMultiplier;
        [NMS(Index = 123)]
        /* 0x0DD8 */ public float DronePatrolAttackSightTime;
        [NMS(Index = 124)]
        /* 0x0DDC */ public float DronePatrolInvestigateSpeedBoost;
        [NMS(Index = 125)]
        /* 0x0DE0 */ public float DronePatrolSearchTime;
        [NMS(Index = 54)]
        /* 0x0DE4 */ public float DronePerceptionMinHearingSpeed;
        [NMS(Index = 280)]
        /* 0x0DE8 */ public float DronePerceptionRange;
        [NMS(Index = 281)]
        /* 0x0DEC */ public float DronePerceptionRangeHostile;
        [NMS(Index = 284)]
        /* 0x0DF0 */ public float DronePerceptionSightAngle;
        [NMS(Index = 282)]
        /* 0x0DF4 */ public float DronePerceptionSightRange;
        [NMS(Index = 283)]
        /* 0x0DF8 */ public float DronePerceptionSightRangeHostile;
        [NMS(Index = 102)]
        /* 0x0DFC */ public float DronePushLaserForce;
        [NMS(Index = 103)]
        /* 0x0E00 */ public float DronePushMaxSpeed;
        [NMS(Index = 104)]
        /* 0x0E04 */ public float DronePushMaxTurn;
        [NMS(Index = 130)]
        /* 0x0E08 */ public float DroneRadius;
        [NMS(Index = 122)]
        /* 0x0E0C */ public float DroneReAttackTime;
        [NMS(Index = 89)]
        /* 0x0E10 */ public float DroneScale;
        [NMS(Index = 140)]
        /* 0x0E14 */ public float DroneScanMinPerpSpeed;
        [NMS(Index = 137)]
        /* 0x0E18 */ public float DroneScanRadius;
        [NMS(Index = 139)]
        /* 0x0E1C */ public float DroneScanWaitTime;
        [NMS(Index = 56)]
        /* 0x0E20 */ public float DroneSearchLookDistance;
        [NMS(Index = 55)]
        /* 0x0E24 */ public float DroneSearchLookSpeed;
        [NMS(Index = 12)]
        /* 0x0E28 */ public float DroneSearchPickNearbyAngleMax;
        [NMS(Index = 11)]
        /* 0x0E2C */ public float DroneSearchPickNearbyAngleMin;
        [NMS(Index = 10)]
        /* 0x0E30 */ public float DroneSearchPickNearbyTime;
        [NMS(Index = 31)]
        /* 0x0E34 */ public float DroneSpawnFadeTime;
        [NMS(Index = 88)]
        /* 0x0E38 */ public float DroneSpawnHeight;
        [NMS(Index = 30)]
        /* 0x0E3C */ public float DroneSpawnTime;
        [NMS(Index = 87)]
        /* 0x0E40 */ public float DroneSquadSpawnRadius;
        [NMS(Index = 26)]
        /* 0x0E44 */ public float DroneUpdateDistForMax;
        [NMS(Index = 27)]
        /* 0x0E48 */ public float DroneUpdateDistForMin;
        [NMS(Index = 24)]
        /* 0x0E4C */ public float DroneUpdateFPSMax;
        [NMS(Index = 25)]
        /* 0x0E50 */ public float DroneUpdateFPSMin;
        [NMS(Index = 22)]
        /* 0x0E54 */ public float EncounterRangeToAllowPulledIntoFight;
        [NMS(Index = 21)]
        /* 0x0E58 */ public float EncounterRangeToBlockWantedSpawns;
        [NMS(Index = 141)]
        /* 0x0E5C */ public float EnergyExplodeTime;
        [NMS(Index = 157)]
        /* 0x0E60 */ public float ExoMechJumpCooldownTimeInCombat;
        [NMS(Index = 158)]
        /* 0x0E64 */ public float ExoMechJumpCooldownTimeOutOfCombat;
        [NMS(Index = 35)]
        /* 0x0E68 */ public float FakeQuadGuard;
        [NMS(Index = 302)]
        /* 0x0E6C */ public float FireRateLastHitBypassTime;
        [NMS(Index = 304)]
        /* 0x0E70 */ public float FireRateModifierMax;
        [NMS(Index = 303)]
        /* 0x0E74 */ public float FireRateModifierMin;
        [NMS(Index = 142)]
        /* 0x0E78 */ public float FollowRoutineArriveRadius;
        [NMS(Index = 44)]
        /* 0x0E7C */ public float FriendlyDroneBeepReplaceChatChance;
        [NMS(Index = 41)]
        /* 0x0E80 */ public float FriendlyDroneChatChanceBecomeWanted;
        [NMS(Index = 43)]
        /* 0x0E84 */ public float FriendlyDroneChatChanceIdle;
        [NMS(Index = 42)]
        /* 0x0E88 */ public float FriendlyDroneChatChanceLoseWanted;
        [NMS(Index = 39)]
        /* 0x0E8C */ public float FriendlyDroneChatChanceSummoned;
        [NMS(Index = 40)]
        /* 0x0E90 */ public float FriendlyDroneChatChanceUnsummoned;
        [NMS(Index = 37)]
        /* 0x0E94 */ public float FriendlyDroneChatCooldown;
        [NMS(Index = 38)]
        /* 0x0E98 */ public float FriendlyDroneDissolveTime;
        [NMS(Index = 5)]
        /* 0x0E9C */ public float GrenadeLaunchFlightTime;
        [NMS(Index = 112)]
        /* 0x0EA0 */ public float HeightTestSampleDistance;
        [NMS(Index = 113)]
        /* 0x0EA4 */ public float HeightTestSampleTime;
        [NMS(Index = 233)]
        /* 0x0EA8 */ public int HitsToCancelStealth;
        [NMS(Index = 232)]
        /* 0x0EAC */ public int HitsToCancelStealthSmall;
        [NMS(Index = 70)]
        /* 0x0EB0 */ public float LabelOffsetDrone;
        [NMS(Index = 73)]
        /* 0x0EB4 */ public float LabelOffsetMech;
        [NMS(Index = 71)]
        /* 0x0EB8 */ public float LabelOffsetQuad;
        [NMS(Index = 72)]
        /* 0x0EBC */ public float LabelOffsetSpiderQuad;
        [NMS(Index = 74)]
        /* 0x0EC0 */ public float LabelOffsetWalker;
        [NMS(Index = 288)]
        /* 0x0EC4 */ public float LaserFadeTime;
        [NMS(Index = 289)]
        /* 0x0EC8 */ public float LaserFadeTime2;
        [NMS(Index = 32)]
        /* 0x0ECC */ public float LineOfSightReturnCheckMinDistance;
        [NMS(Index = 33)]
        /* 0x0ED0 */ public float LineOfSightReturnCheckRadius;
        [NMS(Index = 34)]
        /* 0x0ED4 */ public float LineOfSightReturnRange;
        [NMS(Index = 126)]
        /* 0x0ED8 */ public int MaxNumInvestigatingDrones;
        [NMS(Index = 7)]
        /* 0x0EDC */ public int MaxNumPatrolDrones;
        [NMS(Index = 175)]
        /* 0x0EE0 */ public float MechAlertRange;
        [NMS(Index = 173)]
        /* 0x0EE4 */ public float MechAttackMoveAngleToleranceDeg;
        [NMS(Index = 174)]
        /* 0x0EE8 */ public float MechAttackMoveFacingAngleTolerance;
        [NMS(Index = 172)]
        /* 0x0EEC */ public float MechAttackMoveHoldPositionTime;
        [NMS(Index = 171)]
        /* 0x0EF0 */ public float MechAttackMoveMaxOffsetRotation;
        [NMS(Index = 170)]
        /* 0x0EF4 */ public float MechAttackMoveMinOffsetRotation;
        [NMS(Index = 176)]
        /* 0x0EF8 */ public float MechAttackRange;
        [NMS(Index = 168)]
        /* 0x0EFC */ public float MechAttackRate;
        [NMS(Index = 162)]
        /* 0x0F00 */ public float MechEndJumpMinDistanceInCombat;
        [NMS(Index = 164)]
        /* 0x0F04 */ public float MechEndJumpMinDistanceOutOfCombat;
        [NMS(Index = 156)]
        /* 0x0F08 */ public float MechFadeInDistance;
        [NMS(Index = 154)]
        /* 0x0F0C */ public float MechFadeInTime;
        [NMS(Index = 155)]
        /* 0x0F10 */ public float MechFadeOutTime;
        [NMS(Index = 179)]
        /* 0x0F14 */ public float MechHearingRange;
        [NMS(Index = 167)]
        /* 0x0F18 */ public float MechMinMaintainFireTargetTime;
        [NMS(Index = 166)]
        /* 0x0F1C */ public float MechMinMaintainTargetTime;
        [NMS(Index = 169)]
        /* 0x0F20 */ public float MechMinTurretAngle;
        [NMS(Index = 180)]
        /* 0x0F24 */ public float MechPatrolRadius;
        [NMS(Index = 178)]
        /* 0x0F28 */ public float MechSightAngle;
        [NMS(Index = 177)]
        /* 0x0F2C */ public float MechSightRange;
        [NMS(Index = 161)]
        /* 0x0F30 */ public float MechStartJumpMinDistanceInCombat;
        [NMS(Index = 163)]
        /* 0x0F34 */ public float MechStartJumpMinDistanceOutOfCombat;
        [NMS(Index = 108)]
        /* 0x0F38 */ public float MedicDroneMinHealTime;
        [NMS(Index = 3)]
        /* 0x0F3C */ public float MinInvestigateMessageTime;
        [NMS(Index = 4)]
        /* 0x0F40 */ public int MinRobotKillsForHint;
        [NMS(Index = 227)]
        /* 0x0F44 */ public float QuadAlertRange;
        [NMS(Index = 243)]
        /* 0x0F48 */ public float QuadAttackMinMoveTime;
        [NMS(Index = 228)]
        /* 0x0F4C */ public float QuadAttackMoveMinDist;
        [NMS(Index = 230)]
        /* 0x0F50 */ public float QuadAttackMoveMinRange;
        [NMS(Index = 229)]
        /* 0x0F54 */ public float QuadAttackMoveRange;
        [NMS(Index = 262)]
        /* 0x0F58 */ public float QuadAttackRate;
        [NMS(Index = 50)]
        /* 0x0F5C */ public float QuadAttackTurnAngleMax;
        [NMS(Index = 49)]
        /* 0x0F60 */ public float QuadAttackTurnAngleMin;
        [NMS(Index = 260)]
        /* 0x0F64 */ public float QuadCannotSeeTargetRepositionTime;
        [NMS(Index = 261)]
        /* 0x0F68 */ public int QuadDamageMoveThreshold;
        [NMS(Index = 259)]
        /* 0x0F6C */ public float QuadEvadeCooldown;
        [NMS(Index = 256)]
        /* 0x0F70 */ public float QuadEvadeFacingAngle;
        [NMS(Index = 271)]
        /* 0x0F74 */ public float QuadHearingRange;
        [NMS(Index = 266)]
        /* 0x0F78 */ public float QuadHeight;
        [NMS(Index = 247)]
        /* 0x0F7C */ public float QuadJumpBackCheckRange;
        [NMS(Index = 251)]
        /* 0x0F80 */ public float QuadJumpBackDoFlipDistance;
        [NMS(Index = 253)]
        /* 0x0F84 */ public float QuadJumpBackFacingAngle;
        [NMS(Index = 248)]
        /* 0x0F88 */ public float QuadJumpBackHeightRange;
        [NMS(Index = 249)]
        /* 0x0F8C */ public float QuadJumpBackJumpDistance;
        [NMS(Index = 250)]
        /* 0x0F90 */ public float QuadJumpBackJumpMinLength;
        [NMS(Index = 252)]
        /* 0x0F94 */ public float QuadJumpBackMinTime;
        [NMS(Index = 246)]
        /* 0x0F98 */ public float QuadJumpBackRange;
        [NMS(Index = 244)]
        /* 0x0F9C */ public float QuadJumpBackRecoveryTime;
        [NMS(Index = 255)]
        /* 0x0FA0 */ public float QuadJumpBackTestHeightOffset;
        [NMS(Index = 254)]
        /* 0x0FA4 */ public float QuadJumpBackTestRadius;
        [NMS(Index = 264)]
        /* 0x0FA8 */ public float QuadLaserSpringMax;
        [NMS(Index = 263)]
        /* 0x0FAC */ public float QuadLaserSpringMin;
        [NMS(Index = 47)]
        /* 0x0FB0 */ public float QuadLookAngleMax;
        [NMS(Index = 46)]
        /* 0x0FB4 */ public float QuadLookAngleMin;
        [NMS(Index = 245)]
        /* 0x0FB8 */ public float QuadMinStationaryTime;
        [NMS(Index = 267)]
        /* 0x0FBC */ public float QuadNavRadius;
        [NMS(Index = 268)]
        /* 0x0FC0 */ public float QuadObstacleSize;
        [NMS(Index = 269)]
        /* 0x0FC4 */ public float QuadPatrolRadius;
        [NMS(Index = 258)]
        /* 0x0FC8 */ public float QuadPounceDamageRadius;
        [NMS(Index = 257)]
        /* 0x0FCC */ public float QuadPounceOffset;
        [NMS(Index = 236)]
        /* 0x0FD0 */ public float QuadRepositionHealthThresholdPercent;
        [NMS(Index = 234)]
        /* 0x0FD4 */ public float QuadRepositionMaxTimeSinceHit;
        [NMS(Index = 240)]
        /* 0x0FD8 */ public float QuadRepositionMinMoveDist;
        [NMS(Index = 242)]
        /* 0x0FDC */ public float QuadRepositionMinTargetDist;
        [NMS(Index = 241)]
        /* 0x0FE0 */ public float QuadRepositionTargetDist;
        [NMS(Index = 239)]
        /* 0x0FE4 */ public float QuadRepositionTimeout;
        [NMS(Index = 273)]
        /* 0x0FE8 */ public float QuadSightAngle;
        [NMS(Index = 272)]
        /* 0x0FEC */ public float QuadSightRange;
        [NMS(Index = 231)]
        /* 0x0FF0 */ public float QuadStealthCooldown;
        [NMS(Index = 237)]
        /* 0x0FF4 */ public float QuadStealthRepositionHealthThresholdPercent;
        [NMS(Index = 238)]
        /* 0x0FF8 */ public float QuadStealthRepositionHealthThresholdPercentSmall;
        [NMS(Index = 235)]
        /* 0x0FFC */ public float QuadStealthRepositionMaxTimeSinceHit;
        [NMS(Index = 265)]
        /* 0x1000 */ public float QuadTurnBlendTime;
        [NMS(Index = 150)]
        /* 0x1004 */ public float RepairChargeTime;
        [NMS(Index = 144)]
        /* 0x1008 */ public float RepairCheckForTargetCooldownTime;
        [NMS(Index = 152)]
        /* 0x100C */ public float RepairEffectScaleDrone;
        [NMS(Index = 153)]
        /* 0x1010 */ public float RepairEffectScaleQuad;
        [NMS(Index = 146)]
        /* 0x1014 */ public float RepairOffset;
        [NMS(Index = 145)]
        /* 0x1018 */ public float RepairOffsetChangeTime;
        [NMS(Index = 148)]
        /* 0x101C */ public float RepairRate;
        [NMS(Index = 147)]
        /* 0x1020 */ public float RepairScanArriveDistance;
        [NMS(Index = 149)]
        /* 0x1024 */ public float RepairScanRadius;
        [NMS(Index = 85)]
        /* 0x1028 */ public float RobotHUDMarkerFalloff;
        [NMS(Index = 84)]
        /* 0x102C */ public float RobotHUDMarkerRange;
        [NMS(Index = 95)]
        /* 0x1030 */ public float RobotMapScale;
        [NMS(Index = 36)]
        /* 0x1034 */ public float RobotSightAngle;
        [NMS(Index = 115)]
        /* 0x1038 */ public float RobotSightTimer;
        [NMS(Index = 81)]
        /* 0x103C */ public float RobotSteeringAvoidCreaturesWeight;
        [NMS(Index = 82)]
        /* 0x1040 */ public float RobotSteeringAvoidDangerWeight;
        [NMS(Index = 80)]
        /* 0x1044 */ public float RobotSteeringAvoidTurnWeight;
        [NMS(Index = 79)]
        /* 0x1048 */ public float RobotSteeringFollowWeight;
        [NMS(Index = 306)]
        /* 0x104C */ public int ScoreForMaxFireRateModifier;
        [NMS(Index = 305)]
        /* 0x1050 */ public int ScoreForMinFireRateModifier;
        [NMS(Index = 159)]
        /* 0x1054 */ public float SentinelMechJumpCooldownTimeInCombat;
        [NMS(Index = 160)]
        /* 0x1058 */ public float SentinelMechJumpCooldownTimeOutOfCombat;
        [NMS(Index = 224)]
        /* 0x105C */ public float SpiderPounceAngle;
        [NMS(Index = 226)]
        /* 0x1060 */ public float SpiderPounceMinRange;
        [NMS(Index = 225)]
        /* 0x1064 */ public float SpiderPounceRange;
        [NMS(Index = 279)]
        /* 0x1068 */ public float SpiderQuadHeadTrackSmoothTime;
        [NMS(Index = 275)]
        /* 0x106C */ public float SpiderQuadHeight;
        [NMS(Index = 277)]
        /* 0x1070 */ public float SpiderQuadMiniHeight;
        [NMS(Index = 278)]
        /* 0x1074 */ public float SpiderQuadMiniNavRadius;
        [NMS(Index = 274)]
        /* 0x1078 */ public float SpiderQuadMiniObstacleSize;
        [NMS(Index = 276)]
        /* 0x107C */ public float SpiderQuadNavRadius;
        [NMS(Index = 91)]
        /* 0x1080 */ public float StoneEnemyTrackArrowOffsetMultiplier;
        [NMS(Index = 293)]
        /* 0x1084 */ public float SummonerDroneBeginTime;
        [NMS(Index = 294)]
        /* 0x1088 */ public float SummonerDroneBuildupTime;
        [NMS(Index = 292)]
        /* 0x108C */ public float SummonerDroneCooldown;
        [NMS(Index = 291)]
        /* 0x1090 */ public float SummonerDroneCooldownOffset;
        [NMS(Index = 290)]
        /* 0x1094 */ public int SummonerDroneResummonThreshold;
        [NMS(Index = 300)]
        /* 0x1098 */ public float SummonPreviewInterpSpeedMax;
        [NMS(Index = 299)]
        /* 0x109C */ public float SummonPreviewInterpSpeedMin;
        [NMS(Index = 297)]
        /* 0x10A0 */ public float SummonRadius;
        [NMS(Index = 298)]
        /* 0x10A4 */ public float SummonVerticalOffset;
        [NMS(Index = 90)]
        /* 0x10A8 */ public float TrackArrowOffsetMultiplier;
        [NMS(Index = 8)]
        /* 0x10AC */ public float UnderwaterPerceptionMargin;
        [NMS(Index = 190)]
        /* 0x10B0 */ public float WalkerAttackAngle;
        [NMS(Index = 186)]
        /* 0x10B4 */ public float WalkerAttackRange;
        [NMS(Index = 189)]
        /* 0x10B8 */ public float WalkerAttackRate;
        [NMS(Index = 188)]
        /* 0x10BC */ public float WalkerClosingRange;
        [NMS(Index = 59)]
        /* 0x10C0 */ public float WalkerEnergyLength;
        [NMS(Index = 65)]
        /* 0x10C4 */ public float WalkerEnergyMaxAlpha;
        [NMS(Index = 64)]
        /* 0x10C8 */ public float WalkerEnergyMinAlpha;
        [NMS(Index = 63)]
        /* 0x10CC */ public float WalkerEnergyRadiusStartMax;
        [NMS(Index = 62)]
        /* 0x10D0 */ public float WalkerEnergyRadiusStartMin;
        [NMS(Index = 61)]
        /* 0x10D4 */ public float WalkerEnergySpeedMax;
        [NMS(Index = 60)]
        /* 0x10D8 */ public float WalkerEnergySpeedMin;
        [NMS(Index = 192)]
        /* 0x10DC */ public float WalkerFastMoveFactor;
        [NMS(Index = 187)]
        /* 0x10E0 */ public float WalkerGuardAlertRange;
        [NMS(Index = 202)]
        /* 0x10E4 */ public float WalkerGunChargeTime;
        [NMS(Index = 203)]
        /* 0x10E8 */ public float WalkerGunRate;
        [NMS(Index = 201)]
        /* 0x10EC */ public float WalkerGunShootTime;
        [NMS(Index = 222)]
        /* 0x10F0 */ public float WalkerHeadMaxPitch;
        [NMS(Index = 221)]
        /* 0x10F4 */ public float WalkerHeadMaxYaw;
        [NMS(Index = 220)]
        /* 0x10F8 */ public float WalkerHeadMoveTimeActive;
        [NMS(Index = 219)]
        /* 0x10FC */ public float WalkerHeadMoveTimeIdle;
        [NMS(Index = 193)]
        /* 0x1100 */ public float WalkerHeight;
        [NMS(Index = 199)]
        /* 0x1104 */ public float WalkerLaserBodyOffset;
        [NMS(Index = 198)]
        /* 0x1108 */ public float WalkerLaserOvershootEnd;
        [NMS(Index = 197)]
        /* 0x110C */ public float WalkerLaserOvershootStart;
        [NMS(Index = 96)]
        /* 0x1110 */ public float WalkerLaserOvershootVehicleReducer;
        [NMS(Index = 212)]
        /* 0x1114 */ public float WalkerLegShotDefendTime;
        [NMS(Index = 214)]
        /* 0x1118 */ public float WalkerLegShotEnrageShotInterval;
        [NMS(Index = 215)]
        /* 0x111C */ public int WalkerLegShotEnrageShotsPerVolley;
        [NMS(Index = 218)]
        /* 0x1120 */ public float WalkerLegShotEnrageShotSpreadMax;
        [NMS(Index = 217)]
        /* 0x1124 */ public float WalkerLegShotEnrageShotSpreadMin;
        [NMS(Index = 216)]
        /* 0x1128 */ public float WalkerLegShotEnrageVolleyInterval;
        [NMS(Index = 191)]
        /* 0x112C */ public float WalkerMoveSpeed;
        [NMS(Index = 194)]
        /* 0x1130 */ public float WalkerNavRadius;
        [NMS(Index = 200)]
        /* 0x1134 */ public float WalkerObstacleSize;
        [NMS(Index = 185)]
        /* 0x1138 */ public float WalkerPauseTime;
        [NMS(Index = 196)]
        /* 0x113C */ public float WalkerPushRadius;
        [NMS(Index = 195)]
        /* 0x1140 */ public float WalkerPushTime;
        [NMS(Index = 207)]
        /* 0x1144 */ public float WalkerTitanFallEffectScale;
        [NMS(Index = 204)]
        /* 0x1148 */ public float WalkerTitanFallHeight;
        [NMS(Index = 205)]
        /* 0x114C */ public float WalkerTitanFallSpeed;
        [NMS(Index = 98)]
        /* 0x1150 */ public bool DisableDronePerception;
        [NMS(Index = 58)]
        /* 0x1151 */ public bool DroneChatter;
        [NMS(Index = 106)]
        /* 0x1152 */ public bool DroneClickToMove;
        [NMS(Index = 23)]
        /* 0x1153 */ public bool DroneEnableVariableUpdate;
        [NMS(Index = 116)]
        /* 0x1154 */ public bool DroneHitImpulseEnabled;
        [NMS(Index = 9)]
        /* 0x1155 */ public bool DronePatrolScanPlayer;
        [NMS(Index = 97)]
        /* 0x1156 */ public bool DronesUseEscalationTimer;
        [NMS(Index = 0)]
        /* 0x1157 */ public bool ForceShowDebugMoveTrail;
        [NMS(Index = 285)]
        /* 0x1158 */ public bool SpawnFriendlyDrone;
        [NMS(Index = 301)]
        /* 0x1159 */ public bool SummonerTestSummonEffects;
        [NMS(Index = 211)]
        /* 0x115A */ public bool WalkerLegShotDefendEnabled;
        [NMS(Index = 213)]
        /* 0x115B */ public bool WalkerLegShotEnrageEnabled;
    }
}
