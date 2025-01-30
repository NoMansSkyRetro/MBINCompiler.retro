namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x117FD42A4BB0B09D, NameHash = 0xD3AB937B)]
    public class TkPhysRelVectorData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public Vector3f Local;
        [NMS(Index = 1)]
        /* 0x10 */ public Vector3f Offset;
    }
}
