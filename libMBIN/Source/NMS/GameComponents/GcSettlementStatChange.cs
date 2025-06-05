using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x139C69CAB29905CF, NameHash = 0xDB7A6AA2)]
    public class GcSettlementStatChange : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcSettlementStatType Stat;
        [NMS(Index = 1)]
        /* 0x4 */ public GcSettlementStatStrength Strength;
    }
}
