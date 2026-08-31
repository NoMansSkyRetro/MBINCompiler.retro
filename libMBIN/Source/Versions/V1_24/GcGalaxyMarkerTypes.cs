namespace libMBIN.V1_24.Structs
{
    public class GcGalaxyMarkerTypes : NMSTemplate
    {
        public int GalaxyMarkerType;
        public string[] GalaxyMarkerTypeValues()
        {
            return new[] { "Home", "Waypoint", "Contact", "Blackhole", "AtlasStation", "Selection", "PlanetBase"};
        }
    }
}
