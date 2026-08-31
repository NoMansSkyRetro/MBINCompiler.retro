using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
{
    public class GcScannableComponentData : NMSTemplate
    {
        public float ScanRange;
        [NMS(Size = 0x20)]
        public string ScanName;
        public float ScanTime;

        public GcScannerIconTypes IconType;
        public bool PermanentIcon;
        public float PermanentIconRadius;
    }
}
