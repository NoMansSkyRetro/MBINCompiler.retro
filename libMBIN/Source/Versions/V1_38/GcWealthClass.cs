namespace libMBIN.V1_38.Structs
{
    public class GcWealthClass : NMSTemplate
    {
        public int WealthClass;
        public string[] WealthClassValues()
        {
            return new[]
            {
                "Poor", "Average", "Wealthy"
            };
        }
    }
}
