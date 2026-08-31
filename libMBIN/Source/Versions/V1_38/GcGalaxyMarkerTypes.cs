namespace libMBIN.V1_38.Structs
{
    public class GcGalaxyMarkerTypes : NMSTemplate
    {
        public int GalaxyMarkerType;
        public string[] GalaxyMarkerTypeValues()
        {
            return new[] { "StartingLocation", "Home", "Waypoint", "Contact",
                           "Blackhole", "AtlasStation", "Selection", "PlanetBase",
                           "Visited", "ScanEvent"};
        }
    }
}
