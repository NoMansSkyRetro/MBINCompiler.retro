using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
{
    public class GcMissionSequenceShowMessage : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string DebugText;
        /* 0x080 */ public float Time;
        [NMS(Size = 0x80)]
        /* 0x084 */ public string Message;
    }
}
