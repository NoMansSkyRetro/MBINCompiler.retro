namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x63009C27857C7069, NameHash = 0xC402725B)]
    public class GcMoveableObjectComponentData : NMSTemplate
    {
        [NMS(Index = 10)]
        /* 0x00 */ public Vector3f GravGunGrabRotationTarget;
        [NMS(Index = 5)]
        /* 0x10 */ public NMSString0x10 DefaultCollisionEffect;
        [NMS(Index = 6)]
        /* 0x20 */ public NMSString0x10 TerrainCollisionEffect;
        [NMS(Index = 7)]
        /* 0x30 */ public float Cooldown;
        [NMS(Index = 8)]
        /* 0x34 */ public float GlobalCooldown;
        [NMS(Index = 4)]
        /* 0x38 */ public float MaxImpactScale;
        [NMS(Index = 1)]
        /* 0x3C */ public float MaxImpactStrength;
        [NMS(Index = 3)]
        /* 0x40 */ public float MinImpactScale;
        [NMS(Index = 0)]
        /* 0x44 */ public float MinImpactStrength;
        [NMS(Index = 2)]
        /* 0x48 */ public float MinRelativeVelocity;
        [NMS(Index = 13)]
        /* 0x4C */ public float OnTruckCooldownModifier;
        [NMS(Index = 12)]
        /* 0x50 */ public float OnTruckImpactStrengthModifier;
        [NMS(Index = 11)]
        /* 0x54 */ public float OnTruckMinRelativeVelocityModifier;
        [NMS(Index = 9)]
        /* 0x58 */ public bool UseGravGunGrabRotationTarget;
    }
}
