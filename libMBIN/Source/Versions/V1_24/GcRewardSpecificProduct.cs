using libMBIN.NMS;
namespace libMBIN.V1_24.Structs
{
    [NMS(Alignment = 0x8)]
    public class GcRewardSpecificProduct : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
        public int AmountMin;
        public int AmountMax;
    }
}
