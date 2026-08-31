namespace libMBIN.V1_38.Structs
{
    public class GcBuildingDensityLevels : NMSTemplate
    {
        public int BuildingDensity;
        public string[] BuildingDensityValues()
        {
            return new[] { "Dead", "Low", "Mid", "Full", "RelicOnly", "IndustrialOnly" };
        }
    }
}
