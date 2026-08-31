namespace libMBIN.V1_24.Structs
{
    public class TkAnimPoseData : NMSTemplate // 0x18 bytes
    {
        [NMS(Size = 0x10)]
        public string Anim;
        public int FrameStart;
        public int FrameEnd;
    }
}
