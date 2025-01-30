using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x114547F4CB481C3B, NameHash = 0x52090B8B)]
    public class TkHitCurveData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public TkInOutCurve Curve;
        [NMS(Index = 0)]
        /* 0x8 */ public float Time;
    }
}
