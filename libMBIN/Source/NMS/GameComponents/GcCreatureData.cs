using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD1EF3BEA73F2903E, NameHash = 0xC0D06960)]
    public class GcCreatureData : NMSTemplate
    {
        [NMS(Index = 18)]
        /* 0x00 */ public List<NMSTemplate> Data;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 Id;
        [NMS(Index = 17)]
        /* 0x20 */ public NMSString0x10 KillingBlowMessageID;
        [NMS(Index = 16)]
        /* 0x30 */ public NMSString0x10 KillStatID;
        [NMS(Index = 6)]
        /* 0x40 */ public List<GcCreatureTagAndRarity> Tags;
        [NMS(Index = 2)]
        /* 0x50 */ public GcCreatureTypes ForceType;
        [NMS(Index = 12)]
        /* 0x54 */ public float FurChance;
        [NMS(Index = 11)]
        /* 0x58 */ public float FurLengthModifierAtMaxScale;
        [NMS(Index = 10)]
        /* 0x5C */ public float FurLengthModifierAtMinScale;
        [NMS(Index = 15)]
        /* 0x60 */ public GcCreatureRoleFrequencyModifier HerbivoreProbabilityModifier;
        [NMS(Index = 9)]
        /* 0x64 */ public float MaxScale;
        [NMS(Index = 8)]
        /* 0x68 */ public float MinScale;
        // size: 0x4
        public enum MoveAreaEnum : uint {
            Ground,
            Water,
            Air,
            Space,
        }
        [NMS(Index = 7)]
        /* 0x6C */ public MoveAreaEnum MoveArea;
        [NMS(Index = 14)]
        /* 0x70 */ public GcCreatureRoleFrequencyModifier PredatorProbabilityModifier;
        [NMS(Index = 13)]
        /* 0x74 */ public GcCreatureRarity Rarity;
        [NMS(Index = 3)]
        /* 0x78 */ public GcCreatureTypes RealType;
        [NMS(Index = 5)]
        /* 0x7C */ public bool CanBeFemale;
        [NMS(Index = 4)]
        /* 0x7D */ public bool EcoSystemCreature;
        [NMS(Index = 1)]
        /* 0x7E */ public bool OnlySpawnWhenIdIsForced;
    }
}
