namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAF7120F3BC22E0B3, NameHash = 0xCA9B582D)]
    public class GcBiomeType : NMSTemplate
    {
        // size: 0x11
        public enum BiomeEnum : uint {
            Lush,
            Toxic,
            Scorched,
            Radioactive,
            Frozen,
            Barren,
            Dead,
            Weird,
            Red,
            Green,
            Blue,
            Test,
            Swamp,
            Lava,
            Waterworld,
            GasGiant,
            All,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public BiomeEnum Biome;
    }
}
