using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
{
    public class GcAtlasDownloadType : NMSTemplate
    {
        public int DownloadType;
        public string[] DownloadTypeValues()
        {
            return new[]
            {
                "Unknown", "Discovery", "Base", "Message"
            };
        }
    }
}
