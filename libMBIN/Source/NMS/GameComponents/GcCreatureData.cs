using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF049C544A8298D4D, NameHash = 0xC0D06960)]
    public class GcCreatureData : NMSTemplate
    {
        [NMS(Index = 19)]
        /* 0x00 */ public List<NMSTemplate> Data;
        [NMS(Index = 18)]
        /* 0x10 */ public NMSString0x10 EggType;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 Id;
        [NMS(Index = 17)]
        /* 0x30 */ public NMSString0x10 KillingBlowMessageID;
        [NMS(Index = 16)]
        /* 0x40 */ public NMSString0x10 KillStatID;
        [NMS(Index = 6)]
        /* 0x50 */ public List<GcCreatureTagAndRarity> Tags;
        [NMS(Index = 2)]
        /* 0x60 */ public GcCreatureTypes ForceType;
        [NMS(Index = 12)]
        /* 0x64 */ public float FurChance;
        [NMS(Index = 11)]
        /* 0x68 */ public float FurLengthModifierAtMaxScale;
        [NMS(Index = 10)]
        /* 0x6C */ public float FurLengthModifierAtMinScale;
        [NMS(Index = 15)]
        /* 0x70 */ public GcCreatureRoleFrequencyModifier HerbivoreProbabilityModifier;
        [NMS(Index = 9)]
        /* 0x74 */ public float MaxScale;
        [NMS(Index = 8)]
        /* 0x78 */ public float MinScale;
        // size: 0x4
        public enum MoveAreaEnum : uint {
            Ground,
            Water,
            Air,
            Space,
        }
        [NMS(Index = 7)]
        /* 0x7C */ public MoveAreaEnum MoveArea;
        [NMS(Index = 14)]
        /* 0x80 */ public GcCreatureRoleFrequencyModifier PredatorProbabilityModifier;
        [NMS(Index = 13)]
        /* 0x84 */ public GcCreatureRarity Rarity;
        [NMS(Index = 3)]
        /* 0x88 */ public GcCreatureTypes RealType;
        [NMS(Index = 5)]
        /* 0x8C */ public bool CanBeFemale;
        [NMS(Index = 4)]
        /* 0x8D */ public bool EcoSystemCreature;
        [NMS(Index = 1)]
        /* 0x8E */ public bool OnlySpawnWhenIdIsForced;
    }
}
