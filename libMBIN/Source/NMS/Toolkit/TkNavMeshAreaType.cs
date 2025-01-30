namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xD82360AE2BF88393, NameHash = 0xDCBDDB64)]
    public class TkNavMeshAreaType : NMSTemplate
    {
        // size: 0x6
        public enum NavMeshAreaTypeEnum : uint {
            Null,
            Terrain,
            TerrainInstance,
            Water,
            Normal,
            Auto,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public NavMeshAreaTypeEnum NavMeshAreaType;
    }
}
