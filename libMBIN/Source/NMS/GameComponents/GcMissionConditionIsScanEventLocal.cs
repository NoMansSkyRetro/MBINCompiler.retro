namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x63C49795463D34A5, NameHash = 0x4F937484)]
    public class GcMissionConditionIsScanEventLocal : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A Event;
        [NMS(Index = 1)]
        /* 0x20 */ public bool RequiresFullFireteam;
    }
}
