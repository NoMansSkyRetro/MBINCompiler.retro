namespace libMBIN.V1_24.Structs
{
    public class GcRewardScanEvent : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Event;
        public int ScanEventTable;
        public string[] ScanEventTableValues()
        {
            return new[] { "Space", "Planet", "Missions", "Tutorial" };
        }
    }
}
