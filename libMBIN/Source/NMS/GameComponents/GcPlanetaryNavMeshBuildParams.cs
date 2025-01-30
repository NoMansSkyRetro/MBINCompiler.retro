using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x204E037B553A183F, NameHash = 0x2C6E32AD)]
    public class GcPlanetaryNavMeshBuildParams : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public TkNavMeshBuildParams BaseParams;
        [NMS(Index = 1)]
        /* 0x30 */ public int CellsPerVoxelHeight;
        [NMS(Index = 0)]
        /* 0x34 */ public int CellsPerVoxelWidth;
    }
}
