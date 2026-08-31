namespace libMBIN.V1_24.Structs
{
    public class GcPrimaryAxis : NMSTemplate
    {
        public int PrimaryAxis;
        public string[] PrimaryAxisValues()
        {
            return new[] { "Z", "ZNeg" };
        }
    }
}
