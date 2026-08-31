namespace libMBIN.V1_38.Structs
{
    public class TkVoxelGeneratorSettingsArray : NMSTemplate
    {
        [NMS(Size = 0xA)]
        public TkVoxelGeneratorSettingsElement[] TerrainSettings;
    }
}
