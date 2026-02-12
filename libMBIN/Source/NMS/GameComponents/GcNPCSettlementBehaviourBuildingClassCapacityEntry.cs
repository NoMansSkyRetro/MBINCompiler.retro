using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE2F3CD69E0F701F7, NameHash = 0xB1E003D1)]
    public class GcNPCSettlementBehaviourBuildingClassCapacityEntry : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcBuildingClassification BuildingClass;
        [NMS(Index = 1)]
        /* 0x4 */ public int Capacity;
    }
}
