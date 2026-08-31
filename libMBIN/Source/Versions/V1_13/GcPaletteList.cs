using libMBIN.NMS.GameComponents;
namespace libMBIN.V1_13.Structs
{
    public class GcPaletteList : NMSTemplate
    {
        // 41 palettes since Foundation (rc1: 27, 1.09.1: 38)
        [NMS(Size = 41)]
        public GcPaletteData[] Palettes;
    }
}
