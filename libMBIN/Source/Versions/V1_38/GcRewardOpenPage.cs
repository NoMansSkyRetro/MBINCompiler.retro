namespace libMBIN.V1_38.Structs
{
    public class GcRewardOpenPage : NMSTemplate
    {
        public int PageToOpen;
        public string[] PageToOpenValues()
        {
            return new[] { "FreighterShipTransfer", "DisplayPortalUa"};
        }
    }
}
