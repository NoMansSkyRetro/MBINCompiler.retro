namespace libMBIN.V1_24.Structs
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
