namespace libMBIN.V1_13.Structs
{
    public class GcBuildingCostPartCount : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
        public int Count;
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding14;
    }
}
