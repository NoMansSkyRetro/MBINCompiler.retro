namespace libMBIN.V1_13.Structs
{
    public class GcRewardSignalScan : NMSTemplate // 0x8
    {
        public int SignalScanType;
        public string[] SignalScanTypeValues()
        {
            return new[] { "None", "DropPod", "Shelter", "Search", "Relic", "Industrial" };
        }
        public int Unknown4;
    }
}
