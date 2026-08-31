namespace libMBIN.V1_38.Structs
{
    public class GcRewardShipAssistance : NMSTemplate
    {
        public int AssistanceType;
        public string[] AssistanceTypeValues()
        {
            return new[] { "Police", "Wingmen"};
        }

        public float Time;
    }
}
