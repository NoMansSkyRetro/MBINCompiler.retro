using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x52CF1F638A22782B, NameHash = 0xFD3342FE)]
    public class GcBuildingDefinitionTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x0000 */ public GcBuildingFilenameList[] BuildingFiles;
        [NMS(Index = 1, Size = 0x37, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0xB9A0 */ public GcBuildingDefinitionData[] BuildingPlacement;
        [NMS(Index = 2)]
        /* 0xD368 */ public List<GcBuildingClusterLayout> ClusterLayouts;
    }
}
