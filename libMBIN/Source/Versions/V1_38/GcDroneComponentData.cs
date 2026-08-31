namespace libMBIN.V1_38.Structs
{
    public class GcDroneComponentData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
        public GcPrimaryAxis PrimaryAxis;
        public float Scaler;
        public GcCreatureHealthData Health;
    }
}
