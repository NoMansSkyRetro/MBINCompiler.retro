namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x7B719B402A509591, NameHash = 0xD52EBF67)]
    public class TkNavMeshAreaFlags : NMSTemplate
    {
        // size: 0x2
        public enum NavMeshAreaFlagsEnum : byte {
            None,
            Steep,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public NavMeshAreaFlagsEnum NavMeshAreaFlags;
    }
}
