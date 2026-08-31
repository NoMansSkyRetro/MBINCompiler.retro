using libMBIN.NMS;
namespace libMBIN.V1_24.Structs
{
    public class GcColourPaletteData : NMSTemplate
    {
        [NMS(Size = 5)]
        public Colour[] Colours;
    }
}
