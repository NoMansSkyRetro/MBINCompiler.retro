using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB5E74C453CD8521B, NameHash = 0xA09640A7)]
    public class GcGameTablePetData : NMSTemplate
    {
        [NMS(Index = 14, Size = 0x5)]
        /* 0x000 */ public GcPetBattlerMoveInitData[] MoveInitDataList;
        [NMS(Index = 4)]
        /* 0x078 */ public GcSeed BoneScaleSeed;
        [NMS(Index = 3)]
        /* 0x088 */ public GcSeed ColourBaseSeed;
        [NMS(Index = 7)]
        /* 0x098 */ public List<NMSString0x20A> Descriptors;
        [NMS(Index = 9)]
        /* 0x0A8 */ public GcSeed DescriptorSecondarySeed;
        [NMS(Index = 8)]
        /* 0x0B8 */ public GcSeed DescriptorSeed;
        [NMS(Index = 0)]
        /* 0x0C8 */ public NMSString0x10 ID;
        [NMS(Index = 11)]
        /* 0x0D8 */ public GcSeed PetBattlerSeed;
        [NMS(Index = 1)]
        /* 0x0E8 */ public GcSeed Seed;
        [NMS(Index = 17, Size = 0x3, EnumType = typeof(GcPetBattlerCoreStat.PetBattlerCoreStatEnum))]
        /* 0x0F8 */ public GcInventoryClass[] CoreStatClassOverrides;
        [NMS(Index = 12, Size = 0x3, EnumType = typeof(GcPetBattlerCoreStat.PetBattlerCoreStatEnum))]
        /* 0x104 */ public int[] StatTreatsEaten;
        [NMS(Index = 15, Size = 0x3, EnumType = typeof(GcCreaturePetTraits.PetTraitEnum))]
        /* 0x110 */ public float[] Traits;
        [NMS(Index = 5)]
        /* 0x11C */ public float Babify;
        [NMS(Index = 6)]
        /* 0x120 */ public float Scale;
        [NMS(Index = 13)]
        /* 0x124 */ public int ThumbnailIndex;
        [NMS(Index = 10)]
        /* 0x128 */ public NMSString0x20 Name;
        [NMS(Index = 2)]
        /* 0x148 */ public GcPetBattlerAffinity Affinity;
        [NMS(Index = 16)]
        /* 0x149 */ public bool UseCoreStatClassOverrides;
    }
}
