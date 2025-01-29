using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7AABB6FC8820C905, NameHash = 0x94578880)]
    public class GcProceduralTextureColourIndices : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x8, EnumType = typeof(GcPaletteColourAlt.ColourAltNewEnum))]
        /* 0x0 */ public int[] Alts;
    }
}
