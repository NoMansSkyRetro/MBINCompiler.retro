namespace libMBIN.V1_38.Structs
{
    public class GcMissionGalacticFeature : NMSTemplate
    {
        public int GalacticFeature;
        public string[] GalacticFeatureValues()
        {
            return new[] { "Anomaly", "Atlas", "BlackHole"};
        }
    }
}
