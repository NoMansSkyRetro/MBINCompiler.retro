using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x56B2EAA2FBBACAB6, NameHash = 0x8BB80F0F)]
    public class GcGravityGunGlobals : NMSTemplate
    {
        [NMS(Index = 35)]
        /* 0x00 */ public NMSString0x10 ImpactDamageType;
        [NMS(Index = 34)]
        /* 0x10 */ public GcImpactCombatEffectData GrabCombatEffectToTarget;
        [NMS(Index = 10)]
        /* 0x20 */ public float AngularEjectionPowerFractionOfPower;
        [NMS(Index = 12)]
        /* 0x24 */ public float EjectMaxPowerup;
        [NMS(Index = 11)]
        /* 0x28 */ public float EjectPowerupMaxTimeSeconds;
        [NMS(Index = 27)]
        /* 0x2C */ public float GrabDragRotationStrength;
        [NMS(Index = 25)]
        /* 0x30 */ public float GrabFixedRotationDampingRatio;
        [NMS(Index = 24)]
        /* 0x34 */ public float GrabFixedRotationSpringConst;
        [NMS(Index = 26)]
        /* 0x38 */ public float GrabFreeRotationDampingFactor;
        [NMS(Index = 21)]
        /* 0x3C */ public float GrabMaxAngularSpeed;
        [NMS(Index = 20)]
        /* 0x40 */ public float GrabMaxLinearSpeed;
        [NMS(Index = 30)]
        /* 0x44 */ public float GrabPositionBobMagnitude;
        [NMS(Index = 29)]
        /* 0x48 */ public float GrabPositionBobSpeed;
        [NMS(Index = 23)]
        /* 0x4C */ public float GrabPositionDampingRatio;
        [NMS(Index = 22)]
        /* 0x50 */ public float GrabPositionSpringConst;
        [NMS(Index = 14)]
        /* 0x54 */ public float GrabPosOffset;
        [NMS(Index = 15)]
        /* 0x58 */ public float GrabRequestTimeoutSeconds;
        [NMS(Index = 33)]
        /* 0x5C */ public float GrabRotationBobTorqueStrength;
        [NMS(Index = 32)]
        /* 0x60 */ public float GrabRotationBobTorqueVariationSpeed;
        [NMS(Index = 39)]
        /* 0x64 */ public float ImpactDamageMaxDamage;
        [NMS(Index = 38)]
        /* 0x68 */ public float ImpactDamageMaxImpulse;
        [NMS(Index = 37)]
        /* 0x6C */ public float ImpactDamageMinImpulse;
        [NMS(Index = 40)]
        /* 0x70 */ public float ImpactDamageModifierOnTruck;
        [NMS(Index = 36)]
        /* 0x74 */ public float ImpactDamageSpeedThreshold;
        [NMS(Index = 16)]
        /* 0x78 */ public float InitialGrabSpeed;
        [NMS(Index = 18)]
        /* 0x7C */ public float InitialGrabTimeMinSeconds;
        [NMS(Index = 2)]
        /* 0x80 */ public float PushForceUpComponent;
        [NMS(Index = 3)]
        /* 0x84 */ public float PushPower;
        [NMS(Index = 6)]
        /* 0x88 */ public float PushPowerInScrapyard;
        [NMS(Index = 4)]
        /* 0x8C */ public float PushPowerInScrapyardDistance;
        [NMS(Index = 8)]
        /* 0x90 */ public float PushPowerSentinel;
        [NMS(Index = 7)]
        /* 0x94 */ public float PushPowerSentinelEject;
        [NMS(Index = 5)]
        /* 0x98 */ public float PushPowerToxicInScrapyard;
        [NMS(Index = 9)]
        /* 0x9C */ public float ThresholdForAngularEjectionVelocity;
        [NMS(Index = 1)]
        /* 0xA0 */ public int WeaponChargeGrab;
        [NMS(Index = 0)]
        /* 0xA4 */ public int WeaponChargePush;
        [NMS(Index = 13)]
        /* 0xA8 */ public TkCurveType EjectPowerCurve;
        [NMS(Index = 28)]
        /* 0xA9 */ public bool GrabPositionBobEnabled;
        [NMS(Index = 31)]
        /* 0xAA */ public bool GrabRotationBobEnabled;
        [NMS(Index = 19)]
        /* 0xAB */ public bool GrabUseDynamicPhysics;
        [NMS(Index = 17)]
        /* 0xAC */ public TkCurveType InitialGrabCurve;
    }
}
