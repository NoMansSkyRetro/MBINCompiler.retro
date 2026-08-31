using libMBIN.NMS;
namespace libMBIN.V1_24.Structs
{
    public class GcHUDImageData : NMSTemplate
    {
        public GcHUDComponent Data;

        [NMS(Size = 0x80)]
        public string Image;

        public Colour Colour;
    }
}
