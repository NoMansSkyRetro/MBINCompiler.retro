namespace libMBIN.V1_24.Structs
{
    public class GcGalaxyStarTypes : NMSTemplate
    {
        public int GalaxyStarType;
        public string[] GalaxyStarTypeValues()
        {
            return new[] { "Yellow", "Green", "Blue", "Red" };
        }
    }
}
