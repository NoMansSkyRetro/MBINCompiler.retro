namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xFEC85E4778944B78, NameHash = 0xDEEECE89)]
    public class TkReferenceComponentData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public VariableSizeString LSystem;
        [NMS(Index = 0)]
        /* 0x10 */ public VariableSizeString Reference;
    }
}
