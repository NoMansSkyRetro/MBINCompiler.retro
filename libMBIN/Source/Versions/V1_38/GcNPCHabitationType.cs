namespace libMBIN.V1_38.Structs
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
