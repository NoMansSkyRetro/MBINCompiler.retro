using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2177DD1396E6268, NameHash = 0xB1E003D1)]
    public class GcNPCSettlementBehaviourBuildingClassCapacityEntry : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public int Capacity;
        [NMS(Index = 0)]
        /* 0x4 */ public GcBuildingClassification BuildingClass;
    }
}
