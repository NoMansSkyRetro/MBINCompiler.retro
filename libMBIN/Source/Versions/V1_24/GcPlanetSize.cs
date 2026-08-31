namespace libMBIN.V1_24.Structs
{
    public class GcPlanetSize : NMSTemplate
    {
        public int PlanetSize;
        public string[] PlanetSizeValues()
        {
            return new[] { "Large", "Medium", "Small", "Moon" };
        }
    }
}
