using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4849EA89B6C3199D, NameHash = 0x65B2753E)]
    public class GcPetData : NMSTemplate
    {
        [NMS(Index = 33, Size = 0x5)]
        /* 0x000 */ public GcPetBattlerMoveInitData[] PetBattlerMoveList;
        [NMS(Index = 7)]
        /* 0x078 */ public NMSString0x20A CustomSpeciesName;
        [NMS(Index = 12)]
        /* 0x098 */ public GcSeed BoneScaleSeed;
        [NMS(Index = 11)]
        /* 0x0A8 */ public GcSeed ColourBaseSeed;
        [NMS(Index = 1)]
        /* 0x0B8 */ public NMSString0x10 CreatureID;
        [NMS(Index = 4)]
        /* 0x0C8 */ public GcSeed CreatureSecondarySeed;
        [NMS(Index = 3)]
        /* 0x0D8 */ public GcSeed CreatureSeed;
        [NMS(Index = 2)]
        /* 0x0E8 */ public List<NMSString0x20A> Descriptors;
        [NMS(Index = 16)]
        /* 0x0F8 */ public ulong BirthTime;
        [NMS(Index = 6)]
        /* 0x100 */ public ulong GenusSeed;
        [NMS(Index = 17)]
        /* 0x108 */ public ulong LastEggTime;
        [NMS(Index = 19)]
        /* 0x110 */ public ulong LastTrustDecreaseTime;
        [NMS(Index = 18)]
        /* 0x118 */ public ulong LastTrustIncreaseTime;
        [NMS(Index = 5)]
        /* 0x120 */ public ulong SpeciesSeed;
        [NMS(Index = 9)]
        /* 0x128 */ public ulong UA;
        [NMS(Index = 24)]
        /* 0x130 */ public GcDiscoveryOwner SenderData;
        [NMS(Index = 28, Size = 0x3, EnumType = typeof(GcPetBattlerCoreStat.PetBattlerCoreStatEnum))]
        /* 0x234 */ public GcInventoryClass[] PetBattlerCoreStatClassOverrides;
        [NMS(Index = 29, Size = 0x3, EnumType = typeof(GcPetBattlerCoreStat.PetBattlerCoreStatEnum))]
        /* 0x240 */ public int[] PetBattlerTreatsEaten;
        [NMS(Index = 25, Size = 0x3, EnumType = typeof(GcCreaturePetTraits.PetTraitEnum))]
        /* 0x24C */ public float[] Traits;
        [NMS(Index = 26, Size = 0x2, EnumType = typeof(GcCreaturePetMood.PetMoodEnum))]
        /* 0x258 */ public float[] Moods;
        [NMS(Index = 14)]
        /* 0x260 */ public GcBiomeType Biome;
        [NMS(Index = 15)]
        /* 0x264 */ public GcCreatureTypes CreatureType;
        [NMS(Index = 31)]
        /* 0x268 */ public float PetBattleProgressToTreat;
        [NMS(Index = 30)]
        /* 0x26C */ public int PetBattlerTreatsAvailable;
        [NMS(Index = 32)]
        /* 0x270 */ public int PetBattlerVictories;
        [NMS(Index = 0)]
        /* 0x274 */ public float Scale;
        [NMS(Index = 23)]
        /* 0x278 */ public float Trust;
        [NMS(Index = 22)]
        /* 0x27C */ public NMSString0x20 CustomName;
        [NMS(Index = 10)]
        /* 0x29C */ public bool AllowUnmodifiedReroll;
        [NMS(Index = 20)]
        /* 0x29D */ public bool EggModified;
        [NMS(Index = 21)]
        /* 0x29E */ public bool HasBeenSummoned;
        [NMS(Index = 13)]
        /* 0x29F */ public bool HasFur;
        [NMS(Index = 27)]
        /* 0x2A0 */ public bool PetBattlerUseCoreStatClassOverrides;
        [NMS(Index = 8)]
        /* 0x2A1 */ public bool Predator;
    }
}
