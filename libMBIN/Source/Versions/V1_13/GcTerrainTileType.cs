namespace libMBIN.V1_13.Structs
{
    public class GcTerrainTileType : NMSTemplate
    {
        public int TileType;

        public string[] TileTypeValues()
        {
            return new[]
            {
                "Air", "Base", "Rock", "Mountain", "Underwater", "Cave", "Dirt", "Liquid", "Substance"
            };
        }
    }
}
