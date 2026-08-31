namespace libMBIN.V1_24.Structs
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
