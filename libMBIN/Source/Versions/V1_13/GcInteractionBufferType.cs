using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
{
    public class GcInteractionBufferType : NMSTemplate // 0x7D10 bytes
    {
        public int InterationBufferType;
        public string[] InterationBufferTypeValues()
        {
            return new[] { "DistressSignal", "Crate", "Destructable", "Terrain", "Cost", "Building", "Creature"};
        }
    }
}
