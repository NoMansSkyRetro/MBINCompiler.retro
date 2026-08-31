using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
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
