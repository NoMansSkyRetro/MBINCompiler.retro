namespace libMBIN.V1_38.Structs
{
    public class GcJourneyCategoryType : NMSTemplate
    {
        public int CategoryType;
        public string[] CategoryTypeValues()
        {
            return new[] { "Journey", "Race", "Guild" };
        }
    }
}
