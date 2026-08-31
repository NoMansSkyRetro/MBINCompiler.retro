using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
{
    public class GcGalaxyWaypointTypes : NMSTemplate
    {
        public int GalaxyWaypointType;
        public string[] GalaxyWaypointTypeValues()
        {
            return new[] { "User", "Gameplay_AtlasStation", "Gameplay_DistressBeacon", "Gameplay_Mission"};
        }
    }
}
