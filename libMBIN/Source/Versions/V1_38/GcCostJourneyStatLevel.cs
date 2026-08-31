namespace libMBIN.V1_38.Structs
{
    public class GcCostJourneyStatLevel : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string StatName;
        public int RequiredLevel;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding14;
    }
}
