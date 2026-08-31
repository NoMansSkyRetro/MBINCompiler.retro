namespace libMBIN.V1_24.Structs
{
    public class GcBuildingDistribution : NMSTemplate // 0x2C00 bytes
    {
        [NMS(Size = 0x10)]
        public string Name;
        public int MinDistance;
        public int MaxDistance;
    }
}
