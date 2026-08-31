namespace libMBIN.V1_38.Structs
{
    public class TkLSystemRestrictionData : NMSTemplate
    {
        public int Amount;
        public int Restriction;
        public string[] RestrictionValues()
        {
            return new[] { "NoMoreThan", "AtLeast", "AtLeastIfICan" };
        }
    }
}
