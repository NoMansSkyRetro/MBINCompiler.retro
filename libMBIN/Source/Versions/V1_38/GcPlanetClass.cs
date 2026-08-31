namespace libMBIN.V1_38.Structs
{
    public class GcPlanetClass : NMSTemplate
    {
        public int PlanetClass;
        public string[] PlanetClassValues()
        {
            return new[] { "Default", "Initial", "InInitialSystem" };
        }
    }
}
