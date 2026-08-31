namespace libMBIN.V1_38.Structs
{
    public class GcSizeIndicator : NMSTemplate
    {
        public int SizeIndicator;
        public string[] SizeIndicatorValues()
        {
            return new[] { "Small", "Medium", "Large" };
        }
    }
}
