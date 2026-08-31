namespace libMBIN.V1_24.Structs
{
    public class GcStatDisplayType : NMSTemplate
    {
        public int StatDisplayType;
        public string[] StatDisplayTypeValues()
        {
            return new[] { "None", "Sols", "Distance" };
        }
    }
}
