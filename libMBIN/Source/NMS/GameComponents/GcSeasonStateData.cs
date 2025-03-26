using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x25014E9BB78BA727, NameHash = 0xF5D18571)]
    public class GcSeasonStateData : NMSTemplate
    {
        [NMS(Index = 9)]
        /* 0x000 */ public GcInventoryContainer SeasonTransferInventory;
        [NMS(Index = 0)]
        /* 0x158 */ public List<float> MilestoneValues;
        [NMS(Index = 7)]
        /* 0x168 */ public List<GcUAProtectedLocations> ProtectedEvents;
        [NMS(Index = 5)]
        /* 0x178 */ public List<GcPlayerMissionParticipant> RendezvousParticipants;
        [NMS(Index = 4)]
        /* 0x188 */ public List<ulong> RendezvousUAs;
        [NMS(Index = 1)]
        /* 0x198 */ public List<short> RewardCollected;
        [NMS(Index = 10)]
        /* 0x1A8 */ public GcSeasonEndRewardsRedemptionState EndRewardsRedemptionState;
        [NMS(Index = 3)]
        /* 0x1AC */ public int PinnedMilestone;
        [NMS(Index = 2)]
        /* 0x1B0 */ public int PinnedStage;
        [NMS(Index = 8)]
        /* 0x1B4 */ public GcSeasonSaveStateOnDeath StateOnDeath;
        [NMS(Index = 6)]
        /* 0x1B8 */ public bool HasCollectedFinalReward;
    }
}
