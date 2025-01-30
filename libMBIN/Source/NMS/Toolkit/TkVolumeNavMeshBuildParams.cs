using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x9A1B3CAE8EB2268B, NameHash = 0x253FE95)]
    public class TkVolumeNavMeshBuildParams : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public Vector3f BoundsMax;
        [NMS(Index = 0)]
        /* 0x10 */ public Vector3f BoundsMin;
        [NMS(Index = 6)]
        /* 0x20 */ public TkNavMeshBuildParams BaseParams;
        [NMS(Index = 4)]
        /* 0x50 */ public float CellsPerUnitHeight;
        [NMS(Index = 3)]
        /* 0x54 */ public float CellsPerUnitWidth;
        [NMS(Index = 5)]
        /* 0x58 */ public int NumBorderCells;
        [NMS(Index = 2)]
        /* 0x5C */ public float TileSize;
    }
}
