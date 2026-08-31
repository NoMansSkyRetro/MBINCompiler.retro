using libMBIN.NMS;

namespace libMBIN.V1_00.Structs
{
    // disc terrain block is 26 floats (0x68); the split of the 18 array slots is a
    // guess over zero-valued slots, the totals are byte-proven
    public class GcTerrainControls : NMSTemplate
    {
        [NMS(Size = 7, EnumValue = new[] { "Base", "Hill", "Mountain", "Rock", "UnderWater", "Texture", "Elevation" })]
        public float[] NoiseLayers;
        [NMS(Size = 9, EnumValue = new[] { "Small", "Large", "Resources_Heridium", "Resources_Iridium", "Resources_Copper", "Resources_Nickel", "Resources_Aluminium", "Resources_Gold", "Resources_Emeril" })]
        public float[] GridLayers;
        [NMS(Size = 2)]
        public float[] Features;

        public float UndergroundCaves;
        public float WaterActiveFrequency;
        public float HighWaterActiveFrequency;
        public float RockTileFrequency;
        public float SubstanceTileFrequency;

        [NMS(Size = 3)]
        public float[] UnknownTail;
    }
}
