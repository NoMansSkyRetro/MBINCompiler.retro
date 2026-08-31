namespace libMBIN.V1_24.Structs
{
    public class TkNoiseOffsetEnum : NMSTemplate
    {
        public int OffsetType;
        public string[] OffsetTypeValues()
        {
            return new[] { "Zero", "Base", "All", "SeaLevel" };
        }
    }
}
