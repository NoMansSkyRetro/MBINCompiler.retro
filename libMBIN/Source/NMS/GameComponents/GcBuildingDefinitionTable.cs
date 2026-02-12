using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEDE7DEEA1757C55E, NameHash = 0xFD3342FE)]
    public class GcBuildingDefinitionTable : NMSTemplate
    {
        [NMS(Index = 1, Size = 0x3E, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x0000 */ public GcBuildingDefinitionData[] BuildingPlacement;
        [NMS(Index = 0, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x26C0 */ public GcBuildingFilenameList[] BuildingFiles;
        [NMS(Index = 2)]
        /* 0xF800 */ public List<GcBuildingClusterLayout> ClusterLayouts;
    }
}
