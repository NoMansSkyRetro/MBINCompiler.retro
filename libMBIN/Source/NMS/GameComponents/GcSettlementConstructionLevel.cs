namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2156D904A517AB09, NameHash = 0xF1094533)]
    public class GcSettlementConstructionLevel : NMSTemplate
    {
        // size: 0x6
        public enum SettlementConstructionLevelEnum : uint {
            Start,
            GroundStorey,
            RegularStorey,
            Roof,
            Decoration,
            Other,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public SettlementConstructionLevelEnum SettlementConstructionLevel;
    }
}
