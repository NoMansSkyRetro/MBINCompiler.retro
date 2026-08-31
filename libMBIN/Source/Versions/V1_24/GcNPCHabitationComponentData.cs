namespace libMBIN.V1_24.Structs
{
    public class GcNPCHabitationComponentData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string NPCSpawnLocator;

        public GcNPCHabitationType NPCHabitationType;
    }
}
