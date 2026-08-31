namespace libMBIN.V1_24.Structs
{
    public class GcCreatureComponentData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
        public GcPrimaryAxis PrimaryAxis;
        public float Scaler;
    }
}
