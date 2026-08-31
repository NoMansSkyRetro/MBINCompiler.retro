namespace libMBIN.V1_24.Structs
{
    public class GcStatTrackType : NMSTemplate
    {
        public int StatTrackType;
        public string[] StatTrackTypeValues()
        {
            return new[] { "Set", "Add", "Max", "Min" };
        }
    }
}
