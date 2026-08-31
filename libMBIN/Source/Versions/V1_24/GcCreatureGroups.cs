namespace libMBIN.V1_24.Structs
{
    public class GcCreatureGroups : NMSTemplate
    {
        public int CreatureGroup;
        public string[] CreatureGroupValues()
        {
            return new[] { "Solo", "Couple", "Group", "Herd" };
        }
    }
}
