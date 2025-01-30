namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3FE0AC63ECE39E94, NameHash = 0xCC5A3F4F)]
    public class GcSettlementStatType : NMSTemplate
    {
        // size: 0x7
        public enum SettlementStatTypeEnum : uint {
            Population,
            Happiness,
            Production,
            Upkeep,
            Sentinels,
            Debt,
            Alert,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public SettlementStatTypeEnum SettlementStatType;
    }
}
