using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace libMBIN.V1_00.Structs
{
    public class GcPaletteList : NMSTemplate // disc: 27 palettes (release has 38)
    {
        [NMS(Size = 0x1B)]
        public GcPaletteData[] Palettes;
    }
}
