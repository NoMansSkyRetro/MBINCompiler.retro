using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace libMBIN.V1_00.Structs
{
    public class GcBuildingDefinitionTable : NMSTemplate // 0x89C0
    {
        [NMS(Size = 4)]
        public GcBuildingDensity[] BuildingProbabilities;
        [NMS(Size = 6)]
        public GcBuildingFilenameList[] BuildingFiles;
        [NMS(Size = 0x16)]
        public GcBuildingDefinitionData[] BuildingPlacement;
    }
}
