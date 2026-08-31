namespace libMBIN.V1_24.Structs
{
    public class GcRewardOpenPage : NMSTemplate
    {
        public int PageToOpen;
        public string[] PageToOpenValues()
        {
            return new[] { "FreighterShipTransfer"};
        }
    }
}
