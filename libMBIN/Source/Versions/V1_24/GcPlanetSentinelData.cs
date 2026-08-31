namespace libMBIN.V1_24.Structs
{
    public class GcPlanetSentinelData : NMSTemplate
    {
        public int SentinelLevel;
        public string[] SentinelLevelValues()
        {
            return new[] { "Default", "Aggressive" };
        }

        public int MaxActiveDrones;
    }
}
