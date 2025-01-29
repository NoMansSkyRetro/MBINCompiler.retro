using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x49D3C86802DA74F9, NameHash = 0xE324DEAE)]
    public class GcNPCSettlementBehaviourEntry : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public List<GcNPCSettlementBehaviourAreaPropertyWeightEntry> AreaPropertyWeights;
        [NMS(Index = 2)]
        /* 0x10 */ public List<GcNPCSettlementBehaviourBuildingClassCapacityEntry> BuildingClassCapacities;
        [NMS(Index = 4)]
        /* 0x20 */ public List<GcNPCSettlementBehaviourBuildingClassWeightEntry> BuildingClassWeights;
        [NMS(Index = 5)]
        /* 0x30 */ public List<GcNPCSettlementBehaviourObjectTypeWeightEntry> ObjectTypeWeights;
        [NMS(Index = 0)]
        /* 0x40 */ public float RunWhenOutdoorsProbability;
        [NMS(Index = 1)]
        /* 0x44 */ public bool OnlyUseIndoorPOIs;
    }
}
