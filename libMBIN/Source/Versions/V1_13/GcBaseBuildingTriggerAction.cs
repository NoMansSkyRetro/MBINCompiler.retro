using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
{
    public class GcBaseBuildingTriggerAction : NMSTemplate
    {
        // THIS IS A DUMMY STRUCT UNTIL I FIGURE OUT WHAT THE ACTUAL ONE IS
        [NMS(Size = 0x10)]
        public string ID;
        public int TimeDelay;       // Just a guess?
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding0x14;
    }
}
