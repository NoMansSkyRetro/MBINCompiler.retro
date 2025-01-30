namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x671544E5B7E3E32E, NameHash = 0x65DD91BC)]
    public class GcSettlementJudgementType : NMSTemplate
    {
        // size: 0x7
        public enum SettlementJudgementTypeEnum : uint {
            None,
            StrangerVisit,
            Policy,
            NewBuilding,
            BuildingChoice,
            Conflict,
            Request,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public SettlementJudgementTypeEnum SettlementJudgementType;
    }
}
