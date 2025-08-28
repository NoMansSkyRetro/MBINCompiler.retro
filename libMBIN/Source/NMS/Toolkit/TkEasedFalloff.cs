using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xD47381DBC24FECB2, NameHash = 0xEA76999E)]
    public class TkEasedFalloff : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public float LeftMargin;
        [NMS(Index = 1)]
        /* 0x4 */ public float RightMargin;
        [NMS(Index = 2)]
        /* 0x8 */ public TkCurveType LeftCurve;
        [NMS(Index = 3)]
        /* 0x9 */ public TkCurveType RightCurve;
    }
}
