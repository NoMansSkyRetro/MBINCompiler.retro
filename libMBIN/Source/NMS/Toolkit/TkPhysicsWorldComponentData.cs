namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xFAA5A0922BA74CC2, NameHash = 0xB7832FA2)]
    public class TkPhysicsWorldComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public int MaximumNumberOfBodies;
        [NMS(Index = 1)]
        /* 0x4 */ public float SafeRadius;
    }
}
