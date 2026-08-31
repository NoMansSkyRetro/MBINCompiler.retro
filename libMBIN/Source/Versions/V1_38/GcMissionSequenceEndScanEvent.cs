namespace libMBIN.V1_38.Structs
{
    [NMS(Alignment = 0x8, Size = 0xA0)]
    public class GcMissionSequenceEndScanEvent : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x000 */ public string Event;
        [NMS(Size = 0x80)]
        /* 0x20 */ public string DebugText;
    }
}
