namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC8716C73ADF063EF, NameHash = 0xFED86EB9)]
    public class GcPlayerAttributesEvent : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public bool CheckSpaceWalking;
        [NMS(Index = 1)]
        /* 0x1 */ public bool IsSpaceWalking;
    }
}
