namespace libMBIN.V1_24.Structs
{
    public class GcLegality : NMSTemplate
    {
        public int Legality;

        public string[] LegalityValues()
        {
            return new[] { "Legal", "Illegal", "None" };
        }
    }
}
