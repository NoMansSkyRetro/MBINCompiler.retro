using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
{
    public class GcGalaxyMarkerTypes : NMSTemplate
    {
        public int GalaxyMarkerType;
        public string[] GalaxyMarkerTypeValues()
        {
            return new[] { "Home", "Waypoint", "Contact", "Blackhole", "AtlasStation", "Selection"};
        }
    }
}
