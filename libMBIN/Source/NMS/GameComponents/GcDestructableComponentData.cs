using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x736C051B1E5187B3, NameHash = 0xFC70ABE3)]
    public class GcDestructableComponentData : NMSTemplate
    {
        [NMS(Index = 31, Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x000 */ public NMSString0x10[] RarityLocators;
        [NMS(Index = 36)]
        /* 0x030 */ public TkModelResource DestroyedModel;
        [NMS(Index = 28)]
        /* 0x050 */ public NMSString0x20A OverrideRewardLoc;
        [NMS(Index = 47)]
        /* 0x070 */ public NMSString0x10 AreaDamage;
        [NMS(Index = 38)]
        /* 0x080 */ public NMSString0x10 DestroyedModelSpawnNode;
        [NMS(Index = 42)]
        /* 0x090 */ public NMSString0x10 DestroyEffect;
        [NMS(Index = 44)]
        /* 0x0A0 */ public NMSString0x10 DestroyEffectPoint;
        [NMS(Index = 0)]
        /* 0x0B0 */ public NMSString0x10 Explosion;
        [NMS(Index = 21)]
        /* 0x0C0 */ public NMSString0x10 GivesReward;
        [NMS(Index = 19)]
        /* 0x0D0 */ public List<GcSubstanceAmount> GivesSubstances;
        [NMS(Index = 53)]
        /* 0x0E0 */ public List<GcLootProbability> LootItems;
        [NMS(Index = 15)]
        /* 0x0F0 */ public NMSString0x10 LootReward;
        [NMS(Index = 24)]
        /* 0x100 */ public NMSString0x10 PirateSystemAltReward;
        [NMS(Index = 29)]
        /* 0x110 */ public List<GcRewardMissionOverride> RewardOverrideTable;
        [NMS(Index = 7)]
        /* 0x120 */ public NMSString0x10 TriggerAction;
        [NMS(Index = 3)]
        /* 0x130 */ public NMSString0x10 UnderwaterExplosion;
        [NMS(Index = 6)]
        /* 0x140 */ public NMSString0x10 VehicleDestroyEffect;
        [NMS(Index = 32, Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x150 */ public int[] StandingChangeOnDeath;
        [NMS(Index = 45)]
        /* 0x178 */ public float DestroyEffectTime;
        [NMS(Index = 40)]
        /* 0x17C */ public float DestroyForce;
        [NMS(Index = 41)]
        /* 0x180 */ public float DestroyForceRadius;
        [NMS(Index = 1)]
        /* 0x184 */ public float ExplosionScale;
        [NMS(Index = 9)]
        /* 0x188 */ public int IncreaseCorruptSentinelWanted;
        [NMS(Index = 12)]
        /* 0x18C */ public GcFiendCrime IncreaseFiendCrime;
        [NMS(Index = 11)]
        /* 0x190 */ public float IncreaseFiendWantedChance;
        [NMS(Index = 8)]
        /* 0x194 */ public int IncreaseWanted;
        [NMS(Index = 17)]
        /* 0x198 */ public int LootRewardAmountMax;
        [NMS(Index = 16)]
        /* 0x19C */ public int LootRewardAmountMin;
        [NMS(Index = 23)]
        /* 0x1A0 */ public int OverrideChipAmount;
        [NMS(Index = 50)]
        /* 0x1A4 */ public float ShowInteractRange;
        [NMS(Index = 20)]
        /* 0x1A8 */ public GcStatsEnum StatToTrack;
        [NMS(Index = 4)]
        /* 0x1AC */ public float UnderwaterExplosionScale;
        [NMS(Index = 30)]
        /* 0x1B0 */ public bool ActivateLocatorsFromRarity;
        [NMS(Index = 22)]
        /* 0x1B1 */ public bool BlockDestructionIfRewardFails;
        [NMS(Index = 18)]
        /* 0x1B2 */ public bool CanDestroyFromStoredInteraction;
        [NMS(Index = 14)]
        /* 0x1B3 */ public bool DamagesParentWhenDestroyed;
        [NMS(Index = 39)]
        /* 0x1B4 */ public bool DestroyedModelCollidesWithEverything;
        [NMS(Index = 37)]
        /* 0x1B5 */ public bool DestroyedModelUsesScale;
        [NMS(Index = 46)]
        /* 0x1B6 */ public bool DestroyEffectMatrices;
        [NMS(Index = 43)]
        /* 0x1B7 */ public bool DestroyEffectOnSurface;
        [NMS(Index = 2)]
        /* 0x1B8 */ public bool ExplosionScaleToBounds;
        [NMS(Index = 52)]
        /* 0x1B9 */ public bool GrenadeSingleHit;
        [NMS(Index = 49)]
        /* 0x1BA */ public bool HideInteractWhenAllArmourDestroyed;
        [NMS(Index = 51)]
        /* 0x1BB */ public bool HideInteractWhenShielded;
        [NMS(Index = 35)]
        /* 0x1BC */ public bool HideModel;
        [NMS(Index = 27)]
        /* 0x1BD */ public bool HideReward;
        [NMS(Index = 10)]
        /* 0x1BE */ public bool IncreaseFiendWanted;
        [NMS(Index = 26)]
        /* 0x1BF */ public bool NoConsequencesDuringPirateBattle;
        [NMS(Index = 13)]
        /* 0x1C0 */ public bool NotifyEncounter;
        [NMS(Index = 5)]
        /* 0x1C1 */ public bool OnlyExplodeSelf;
        [NMS(Index = 34)]
        /* 0x1C2 */ public bool RemoveModel;
        [NMS(Index = 25)]
        /* 0x1C3 */ public bool RewardIfDestroyedByOther;
        [NMS(Index = 48)]
        /* 0x1C4 */ public bool ShowInteract;
        [NMS(Index = 33)]
        /* 0x1C5 */ public bool UseSystemColorsForTexture;
    }
}
