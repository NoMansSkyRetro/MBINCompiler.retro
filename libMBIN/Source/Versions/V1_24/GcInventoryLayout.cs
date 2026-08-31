using libMBIN.NMS;
namespace libMBIN.V1_24.Structs
{
    public class GcInventoryLayout : NMSTemplate
    {
        public int Slots;
        [NMS(Ignore = true)]
        public int EmptyNode1;
        public GcSeed Seed;
        public int Level;
        [NMS(Ignore = true)]
        public int EmptyNode2;
    }
}
