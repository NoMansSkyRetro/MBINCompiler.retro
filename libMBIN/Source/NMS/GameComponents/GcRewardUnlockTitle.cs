namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1B215F131B9E1304, NameHash = 0xE758333B)]
    public class GcRewardUnlockTitle : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 TitleID;
        [NMS(Index = 1)]
        /* 0x10 */ public bool NoMusic;
        [NMS(Index = 2)]
        /* 0x11 */ public bool ShowEvenIfAlreadyUnlocked;
    }
}
