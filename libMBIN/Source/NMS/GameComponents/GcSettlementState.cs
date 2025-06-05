using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x37F89E4B0C10B009, NameHash = 0x552AF47D)]
    public class GcSettlementState : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public Vector3f Position;
        [NMS(Index = 5, Size = 0x30)]
        /* 0x010 */ public ulong[] LastBuildingUpgradesTimestamps;
        [NMS(Index = 20, Size = 0x2)]
        /* 0x190 */ public GcSettlementProductionSlotData[] ProductionState;
        [NMS(Index = 28)]
        /* 0x1F0 */ public NMSString0x10 LastJudgementPerkID;
        [NMS(Index = 9)]
        /* 0x200 */ public NMSString0x10 PendingCustomJudgementID;
        [NMS(Index = 11)]
        /* 0x210 */ public List<NMSString0x10> Perks;
        [NMS(Index = 18)]
        /* 0x220 */ public ulong DbTimestamp;
        [NMS(Index = 15)]
        /* 0x228 */ public ulong LastAlertChangeTime;
        [NMS(Index = 16)]
        /* 0x230 */ public ulong LastBugAttackChangeTime;
        [NMS(Index = 14)]
        /* 0x238 */ public ulong LastDebtChangeTime;
        [NMS(Index = 12)]
        /* 0x240 */ public ulong LastJudgementTime;
        [NMS(Index = 30)]
        /* 0x248 */ public ulong LastPopulationChangeTime;
        [NMS(Index = 13)]
        /* 0x250 */ public ulong LastUpkeepDebtCheckTime;
        [NMS(Index = 27)]
        /* 0x258 */ public ulong MiniMissionSeed;
        [NMS(Index = 26)]
        /* 0x260 */ public ulong MiniMissionStartTime;
        [NMS(Index = 24)]
        /* 0x268 */ public ulong NextBuildingUpgradeSeedValue;
        [NMS(Index = 3)]
        /* 0x270 */ public ulong SeedValue;
        [NMS(Index = 1)]
        /* 0x278 */ public ulong UniverseAddress;
        [NMS(Index = 7)]
        /* 0x280 */ public GcDiscoveryOwner Owner;
        [NMS(Index = 4, Size = 0x30)]
        /* 0x384 */ public int[] BuildingStates;
        [NMS(Index = 10, Size = 0x8, EnumType = typeof(GcSettlementStatType.SettlementStatTypeEnum))]
        /* 0x444 */ public int[] Stats;
        [NMS(Index = 19)]
        /* 0x464 */ public int DbVersion;
        [NMS(Index = 23)]
        /* 0x468 */ public GcBuildingClassification NextBuildingUpgradeClass;
        [NMS(Index = 22)]
        /* 0x46C */ public int NextBuildingUpgradeIndex;
        [NMS(Index = 8)]
        /* 0x470 */ public GcSettlementJudgementType PendingJudgementType;
        [NMS(Index = 25)]
        /* 0x474 */ public GcAlienRace Race;
        [NMS(Index = 29)]
        /* 0x478 */ public ushort Population;
        [NMS(Index = 17)]
        /* 0x47A */ public NMSString0x40 DbResourceId;
        [NMS(Index = 6)]
        /* 0x4BA */ public NMSString0x40 Name;
        [NMS(Index = 0)]
        /* 0x4FA */ public NMSString0x40 UniqueId;
        [NMS(Index = 21)]
        /* 0x53A */ public bool IsReported;
    }
}
