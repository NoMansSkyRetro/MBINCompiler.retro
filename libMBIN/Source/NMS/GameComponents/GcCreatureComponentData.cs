using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCB808C58F7BF6795, NameHash = 0xD942199B)]
    public class GcCreatureComponentData : NMSTemplate
    {
        [NMS(Index = 12)]
        /* 0x00 */ public Vector3f DiscoveryUIOffset;
        [NMS(Index = 16)]
        /* 0x10 */ public Vector3f PetLargeUIOverrideOffset;
        [NMS(Index = 4)]
        /* 0x20 */ public NMSString0x10 DeathEffect;
        [NMS(Index = 5)]
        /* 0x30 */ public NMSString0x10 DeathEffectTrail;
        [NMS(Index = 0)]
        /* 0x40 */ public NMSString0x10 Id;
        [NMS(Index = 8)]
        /* 0x50 */ public List<GcReplacementEffectData> ReplacementImpacts;
        [NMS(Index = 13)]
        /* 0x60 */ public List<GcCreatureDiscoveryThumbnailOverride> ThumbnailOverrides;
        [NMS(Index = 9)]
        /* 0x70 */ public float AccessoryPitchOffset;
        [NMS(Index = 1)]
        /* 0x74 */ public GcPrimaryAxis Axis;
        [NMS(Index = 6)]
        /* 0x78 */ public float DeathEffectScale;
        [NMS(Index = 7)]
        /* 0x7C */ public float DeathFadeTime;
        [NMS(Index = 10)]
        /* 0x80 */ public float DiscoveryFurScaler;
        [NMS(Index = 11)]
        /* 0x84 */ public float DiscoveryUIScaler;
        [NMS(Index = 25)]
        /* 0x88 */ public float NavRadiusModifier;
        [NMS(Index = 3)]
        /* 0x8C */ public float PetIndoorScaler;
        [NMS(Index = 15)]
        /* 0x90 */ public float PetLargeUIOverrideScaler;
        [NMS(Index = 2)]
        /* 0x94 */ public float Scaler;
        [NMS(Index = 23)]
        /* 0x98 */ public float UnderwaterRagdollAnimStrength;
        [NMS(Index = 24)]
        /* 0x9C */ public float UnderwaterRagdollAnimTime;
        [NMS(Index = 19)]
        /* 0xA0 */ public float UnderwaterRagdollDamping;
        [NMS(Index = 20)]
        /* 0xA4 */ public float UnderwaterRagdollDampingTime;
        [NMS(Index = 18)]
        /* 0xA8 */ public float UnderwaterRagdollGravityScale;
        [NMS(Index = 21)]
        /* 0xAC */ public float UnderwaterRagdollSpinStrength;
        [NMS(Index = 22)]
        /* 0xB0 */ public float UnderwaterRagdollSpinTime;
        [NMS(Index = 14)]
        /* 0xB4 */ public bool UsePetLargeUIOverride;
        [NMS(Index = 17)]
        /* 0xB5 */ public bool UseStandardWaterPusher;
    }
}
