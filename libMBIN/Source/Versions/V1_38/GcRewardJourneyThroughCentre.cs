namespace libMBIN.V1_38.Structs
{
    public class GcRewardJourneyThroughCentre : NMSTemplate
    {
        public int CentreJourneyDestination;
        public string[] CentreJourneyDestinationValues()
        {
            return new[] { "Next", "Abandoned", "Vicious", "Lush", "Balanced"};
        }
    }
}
