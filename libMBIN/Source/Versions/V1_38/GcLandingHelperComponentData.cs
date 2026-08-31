namespace libMBIN.V1_38.Structs
{
    public class GcLandingHelperComponentData : NMSTemplate
    {
        public float ActiveDistanceMin;
        public float ActiveDistanceMax;
        public bool LandPoint;

        [NMS(Size = 3, Ignore = true)]
        public byte[] Padding9;
    }
}
