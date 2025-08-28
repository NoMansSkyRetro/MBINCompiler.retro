using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x28AF81326E107D8E, NameHash = 0xDC4113AA)]
    public class GcNavigationGlobals : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x000 */ public TkVolumeNavMeshBuildParams FreighterBaseNavMeshBuildParams;
        [NMS(Index = 5)]
        /* 0x070 */ public TkVolumeNavMeshBuildParams NexusNavMeshBuildParams;
        [NMS(Index = 4)]
        /* 0x0E0 */ public TkVolumeNavMeshBuildParams SpaceStationNavMeshBuildParams;
        [NMS(Index = 2)]
        /* 0x150 */ public GcPlanetaryNavMeshBuildParams PlanetaryNavMeshBuildParams;
        [NMS(Index = 0)]
        /* 0x18C */ public int MaxAsyncTileBuildsInFlight;
        [NMS(Index = 1)]
        /* 0x190 */ public int PlanetaryNavMeshLod;
    }
}
