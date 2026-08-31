using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
{
    public class GcNPCHabitationComponentData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string NPCSpawnLocator;

        public GcNPCHabitationType NPCHabitationType;
    }
}
