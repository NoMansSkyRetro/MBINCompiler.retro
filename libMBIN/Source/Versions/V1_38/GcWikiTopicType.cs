namespace libMBIN.V1_38.Structs
{
    public class GcWikiTopicType : NMSTemplate
    {
        public int WikiTopicType;
        public string[] WikiTopicTypeValues()
        {
            return new[] { "List", "Grid"};
        }
    }
}
