namespace libMBIN.V1_38.Structs
{
    public class GcInventoryBaseStatEntry : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string BaseStatID;
        public float Value;
    }
}
