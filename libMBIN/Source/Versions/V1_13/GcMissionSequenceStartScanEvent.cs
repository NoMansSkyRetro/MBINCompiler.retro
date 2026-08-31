using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
{
    [NMS(Alignment = 0x8)]
    public class GcMissionSequenceStartScanEvent : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string DebugText;
        /* 0x080 */ public float Time;
        /* 0x084 */ public int Unknown84;
        [NMS(Size = 0x10)]
        /* 0x088 */ public string Event;
        /* 0x098 */ public bool FromShipScan;
        public int Table;
        /* 0x09C */ public string[] TableValues()
        {
            return new[] { "Space", "Planet", "Mission", "Tutorial" };
        }
    }
}
