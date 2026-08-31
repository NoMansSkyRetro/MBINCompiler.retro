using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
{
    public class GcBuildingDistribution : NMSTemplate // 0x2C00 bytes
    {
        [NMS(Size = 0x10)]
        public string Name;
        public int MinDistance;
        public int MaxDistance;
    }
}
