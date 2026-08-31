namespace libMBIN.V1_38.Structs
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
