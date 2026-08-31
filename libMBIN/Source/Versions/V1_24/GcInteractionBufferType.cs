namespace libMBIN.V1_24.Structs
{
    public class GcInteractionBufferType : NMSTemplate
    {
        public int InterationBufferType;
        public string[] InterationBufferTypeValues()
        {
            return new[] { "DistressSignal", "Crate", "Destructable", "Terrain", "Cost", "Building", "Creature"};
        }
    }
}
