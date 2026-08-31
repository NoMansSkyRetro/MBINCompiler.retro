using libMBIN.NMS;
namespace libMBIN.V1_13.Structs
{
    [NMS(Alignment = 0x8)]
    public class GcCostJourneyStatLevel : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string StatName;
        public int RequiredLevel;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding14;
    }
}
