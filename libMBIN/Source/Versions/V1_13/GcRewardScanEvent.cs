using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
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
