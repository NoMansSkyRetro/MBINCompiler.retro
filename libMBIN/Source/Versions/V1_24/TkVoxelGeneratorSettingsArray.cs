namespace libMBIN.V1_24.Structs
{
    public class TkVoxelGeneratorSettingsArray : NMSTemplate
    {
        [NMS(Size = 0xA)]
        public TkVoxelGeneratorSettingsElement[] TerrainSettings;
    }
}
