using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
{
    [NMS(Alignment = 0x8)]
    public class GcRewardMissionMessage : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string MessageID;
    }
}
