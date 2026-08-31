using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
{
    public class GcBuildingDefinitionTable : NMSTemplate
    {
        [NMS(Size = 6)]
        public GcBuildingDensity[] BuildingProbabilities;
        [NMS(Size = 7)]
        public GcBuildingFilenameList[] BuildingFiles;
        [NMS(Size = 0x17, EnumValue = new string[0x17] {
                "None", "TerrainResource", "Shelter", "Abandoned", "Terminal", "Shop", "Outpost", "Waypoint",
                "Beacon", "RadioTower", "Observatory", "Depot", "Factory", "Harvester", "Plaque", "Monolith",
                "Portal", "Ruin", "Debris", "DamagedMachine", "DistressSignal", "LandingPad", "Base"
            })]
        public GcBuildingDefinitionData[] BuildingPlacement;
    }
}
