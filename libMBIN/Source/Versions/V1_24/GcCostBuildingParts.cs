namespace libMBIN.V1_24.Structs
{
    public class GcCostBuildingParts : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Description;
        public GcBuildingCostPartCount RequiredParts;
    }
}
