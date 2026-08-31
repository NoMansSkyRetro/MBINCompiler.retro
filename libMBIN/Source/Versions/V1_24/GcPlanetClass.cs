namespace libMBIN.V1_24.Structs
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
