namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3158883FAD7B0DB8, NameHash = 0x3E434CE8)]
    public class GcWeightedColourId : NMSTemplate
    {
        [NMS(Index = 2, MxmlName = "Decoration Palette")]
        /* 0x00 */ public NMSString0x20A DecorationPalette;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x20A Palette;
        [NMS(Index = 0, MxmlName = "Relative Probability")]
        /* 0x40 */ public float RelativeProbability;
    }
}
