namespace libMBIN.V1_38.Structs
{
    public class GcSolarSystemLocatorTypes : NMSTemplate
    {
        public int LocatorType;
        public string[] LocatorTypeValues()
        {
            return new[] { "Generic1", "Generic2", "Generic3", "Generic4" };
        }
    }
}
