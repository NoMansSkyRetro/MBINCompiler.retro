namespace libMBIN.V1_24.Structs
{
    public class GcBiomeType : NMSTemplate
    {
        public int Biome;
        public string[] BiomeValues()
        {
            return new[] { "Lush", "Toxic", "Scorched", "Radioactive", "Frozen", "Barren", "Dead", "Test", "All" };
        }
    }
}
