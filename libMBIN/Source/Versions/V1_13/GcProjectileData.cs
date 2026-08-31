using libMBIN.NMS;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.V1_13.Structs
{
    public class GcProjectileData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string Id;
        /* 0x010 */ public GcResourceElement Model;
        /* 0x2B8 */ public GcAudioWwiseEvents AkEvent;
        /* 0x2BC */ public float Radius;
        /* 0x2C0 */ public float Speed;
        /* 0x2C4 */ public float Gravity;
        /* 0x2C8 */ public float Life;
        /* 0x2CC */ public float Offset;
        /* 0x2D0 */ public float RagdollPush;
        /* 0x2D4 */ public int Damage;
        /* 0x2D8 */ public int MiningDamage;
        /* 0x2DC */ public int Bounces;
        /* 0x2E0 */ public bool HitOnBounce;

        /* 0x2E8 */ public GcProjectileDamageId PlayerDamage; // 0xC string + a bool the base def's NMSString0x10 swallowed
        /* 0x300 */ public Colour Colour;
        [NMS(Size = 4, Ignore = true)]
        /* 0x310 */ public byte[] Padding310;
        public enum ClassEnum : uint { Player, PlayerShip, Ship, Robot }
        /* 0x314 */ public ClassEnum Class;
        /* 0x318 */ public NMSString0x10 DefaultImpact;
        /* 0x328 */ public List<GcProjectileImpactData> Impacts;
    }

    // 1.09.1-era: PlayerDamage is a 12-char id followed by a flag byte, packed where the
    // base def declared a full NMSString0x10 (same 16 bytes, same 8-alignment)
    [NMS(Size = 0x10, Alignment = 0x8)]
    public class GcProjectileDamageId : NMSTemplate
    {
        [NMS(Size = 0xC)]
        public string Id;
        public bool Unknown2F4;
        [NMS(Size = 3, Ignore = true)]
        public byte[] Padding;
    }
}
