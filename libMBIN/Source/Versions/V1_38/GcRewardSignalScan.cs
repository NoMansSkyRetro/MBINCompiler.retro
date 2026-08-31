namespace libMBIN.V1_38.Structs
{
    public class GcRewardSignalScan : NMSTemplate
    {
        public int SignalScanType;
        public string[] SignalScanTypeValues()
        {
            return new[] { "None", "DropPod", "Shelter", "Search", "Relic", "Industrial", "Alien", "CrashedFreighter" };
        }
    }
}
