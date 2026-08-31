namespace libMBIN.V1_38.Structs
{
    public class GcBuildingClusterPlacement : NMSTemplate
    {
        public int BuildingClusterPlacement;
        public string[] BuildingClusterPlacementValues()
        {
            return new[] { "Cluster", "Large", "Small", "None" };
        }
    }
}
