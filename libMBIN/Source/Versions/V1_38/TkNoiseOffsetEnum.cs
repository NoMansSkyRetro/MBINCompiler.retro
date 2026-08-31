namespace libMBIN.V1_38.Structs
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
