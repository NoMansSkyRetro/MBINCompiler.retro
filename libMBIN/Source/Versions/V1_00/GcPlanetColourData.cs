using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace libMBIN.V1_00.Structs
{
    public class GcPlanetColourData : NMSTemplate // disc: 27 palettes
    {
        [NMS(Size = 0x1B)]
        public GcColourPaletteData[] Palettes;
    }
}
