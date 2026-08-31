using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
{
    public class GcNPCHabitationType : NMSTemplate
    {
        public int NPCHabitationType;
        public string[] NPCHabitationTypeValues()
        {
            return new[] {"WeaponsExpert", "Farmer", "Builder", "Vehicles", "Scientist" };
        }
    }
}
