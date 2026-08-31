using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
{
    public class GcScannerBuildingIconTypes : NMSTemplate
    {
        public int ScanBuildingIconTypes;
        public string[] ScanBuildingIconTypesValues()
        {
            return new[] { "None", "Generic", "Shelter", "Relic", "Factory", "Unknown", "Distress", "Beacon", "Waypoint", "SpaceStation", "TechResource", "FuelResource", "MineralResource", "SpaceAnomaly", "SapceAtlas" };
        }
    }
}
