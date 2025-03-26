namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xB953CCADE063F130, NameHash = 0xD52EBF67)]
    public class TkNavMeshAreaFlags : NMSTemplate
    {
        // size: 0x1
        public enum NavMeshAreaFlagsEnum : byte {
            None,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public NavMeshAreaFlagsEnum NavMeshAreaFlags;
    }
}
