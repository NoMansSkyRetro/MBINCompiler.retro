namespace libMBIN.V1_24.Structs
{
    public class GcCostTableEntry : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
        public NMSTemplate Cost;
    }
}
