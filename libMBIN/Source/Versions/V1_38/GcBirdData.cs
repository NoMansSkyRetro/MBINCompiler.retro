namespace libMBIN.V1_38.Structs
{
    public class GcBirdData : NMSTemplate		// size: 0x90
    {
        public float FlapSpeedMax;
        public float FlapSpeedMin;
        public float FlapSpeed;
        public float FlapAccel;

        [NMS(Size = 0x80)]
        public string CircleAttractor;
    }
}
