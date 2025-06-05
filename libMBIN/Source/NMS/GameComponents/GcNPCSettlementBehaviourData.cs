using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC404E856CE2E5036, NameHash = 0xB1AE9E88)]
    public class GcNPCSettlementBehaviourData : NMSTemplate
    {
        [NMS(Index = 1, Size = 0x5, EnumType = typeof(GcNPCSettlementBehaviourState.NPCSettlementBehaviourStateEnum))]
        /* 0x000 */ public GcNPCSettlementBehaviourEntry[] BehaviourOverrides;
        [NMS(Index = 0)]
        /* 0x168 */ public GcNPCSettlementBehaviourEntry BaseBehaviour;
    }
}
