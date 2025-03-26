namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xFCB3BBC714E969E8, NameHash = 0xADA2A1CC)]
    public class TkNavMeshPolyFlags : NMSTemplate
    {
        // size: 0x1
        public enum NavMeshPolyFlagsEnum : ushort {
            None,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public NavMeshPolyFlagsEnum NavMeshPolyFlags;
    }
}
