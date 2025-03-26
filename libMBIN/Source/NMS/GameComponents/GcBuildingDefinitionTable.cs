using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x98A1848AE5D4035F, NameHash = 0xFD3342FE)]
    public class GcBuildingDefinitionTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x0000 */ public GcBuildingFilenameList[] BuildingFiles;
        [NMS(Index = 1, Size = 0x39, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0xC060 */ public GcBuildingDefinitionData[] BuildingPlacement;
        [NMS(Index = 2)]
        /* 0xDCE0 */ public List<GcBuildingClusterLayout> ClusterLayouts;
    }
}
