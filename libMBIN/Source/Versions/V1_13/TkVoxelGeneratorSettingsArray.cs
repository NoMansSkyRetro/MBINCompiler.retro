using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
{
    public class TkVoxelGeneratorSettingsArray : NMSTemplate
    {
        [NMS(Size = 0xA)]
        public TkVoxelGeneratorSettingsElement[] TerrainSettings;
    }
}
