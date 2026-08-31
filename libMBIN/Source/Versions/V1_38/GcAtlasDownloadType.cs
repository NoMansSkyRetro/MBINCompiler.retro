namespace libMBIN.V1_38.Structs
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
