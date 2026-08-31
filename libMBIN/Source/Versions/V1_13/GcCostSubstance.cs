using libMBIN.NMS;
namespace libMBIN.V1_13.Structs
{
    [NMS(Alignment = 0x8)]
    public class GcCostSubstance : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
        public int Amount;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding14;
    }
}
