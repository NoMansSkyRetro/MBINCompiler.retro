using libMBIN.NMS;
namespace libMBIN.V1_24.Structs
{
    public class GcTextStyleOutline : NMSTemplate
    {
        public Colour OutlineColour;
        public Vector2f OutlineOffset;

        [NMS(Size = 8, Ignore = true)]
        public byte[] Padding18;
    }
}
