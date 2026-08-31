using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
{
    public class GcGalaxyStarAnomaly : NMSTemplate
    {
        public int GalaxyStarAnomaly;
        public string[] GalaxyStarAnomalyValues()
        {
            return new[] { "None", "AtlasStation", "BlackHole", "MiniStation" };
        }
    }
}
