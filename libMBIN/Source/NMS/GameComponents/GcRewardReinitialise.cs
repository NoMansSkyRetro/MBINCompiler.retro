namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCC0D57B75007CE79, NameHash = 0x8F4041AD)]
    public class GcRewardReinitialise : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A OverrideMessage;
        [NMS(Index = 1)]
        /* 0x20 */ public bool DoIntroNextWarp;
    }
}
