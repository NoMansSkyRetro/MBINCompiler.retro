using libMBIN.NMS;
namespace libMBIN.V1_38.Structs
{
    public class GcAtlasMessage : NMSTemplate
    {
        public GcUniverseAddressData UniverseAddress;
        [NMS(Size = 0x80)]
        public string CustomName;
        public Vector4f Positon;
        public int ColourIndex;
    }
}
