namespace libMBIN.V1_38.Structs
{
    public class GcGalaxyStarAnomaly : NMSTemplate
    {
        public int GalaxyStarAnomaly;
        public string[] GalaxyStarAnomalyValues()
        {
            return new[] { "None", "AtlasStation", "AtlasStationFinal", "BlackHole", "MiniStation" };
        }
    }
}
