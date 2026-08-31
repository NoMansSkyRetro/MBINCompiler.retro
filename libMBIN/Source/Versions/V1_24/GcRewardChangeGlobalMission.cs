namespace libMBIN.V1_24.Structs
{
    public class GcRewardChangeGlobalMission : NMSTemplate
    {
        public int GlobalMission;

        public string[] GlobalMissionValues()
        {
            return new[] { "Atlas", "BlackHole", "Anomaly", "Explore" };
        }
    }
}
