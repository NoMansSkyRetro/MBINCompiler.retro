namespace libMBIN.V1_38.Structs
{
    public class GcCreatureMoveAnimData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Anim;
        [NMS(Size = 0x10)]
        public string AnimLeft;
        [NMS(Size = 0x10)]
        public string AnimRight;

        public float AnimSpeed;
        public float MinSpeedScale;
        public float MaxSpeedScale;
        public float MaxPredatorSpeedScale;
    }
}
