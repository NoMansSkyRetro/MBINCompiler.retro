using libMBIN.NMS;
namespace libMBIN.V1_38.Structs
{
    public class TkPlatformButtonPair : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string PlatformId;
        [NMS(Size = 0x10)]
        public string ButtonId;
        public Vector2f Size;
    }

}
