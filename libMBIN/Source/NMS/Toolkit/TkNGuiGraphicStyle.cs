using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x563C0DB5119E2E1D, NameHash = 0x80EBCD8A)]
    public class TkNGuiGraphicStyle : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public TkNGuiGraphicStyleData Active;
        [NMS(Index = 0)]
        /* 0x050 */ public TkNGuiGraphicStyleData Default;
        [NMS(Index = 1)]
        /* 0x0A0 */ public TkNGuiGraphicStyleData Highlight;
        [NMS(Index = 17)]
        /* 0x0F0 */ public Vector2f CustomMaxStart;
        [NMS(Index = 16)]
        /* 0x0F8 */ public Vector2f CustomMinStart;
        // size: 0x6
        public enum AnimateEnum : uint {
            None,
            WipeRightToLeft,
            SimpleWipe,
            SimpleWipeDown,
            CustomWipe,
            CustomWipeAlpha,
        }
        [NMS(Index = 11)]
        /* 0x100 */ public AnimateEnum Animate;
        [NMS(Index = 13)]
        /* 0x104 */ public float AnimSplit;
        [NMS(Index = 12)]
        /* 0x108 */ public float AnimTime;
        [NMS(Index = 10)]
        /* 0x10C */ public float GlobalFade;
        [NMS(Index = 9)]
        /* 0x110 */ public float HighlightScale;
        [NMS(Index = 8)]
        /* 0x114 */ public float HighlightTime;
        [NMS(Index = 14)]
        /* 0x118 */ public TkCurveType AnimCurve1;
        [NMS(Index = 15)]
        /* 0x119 */ public TkCurveType AnimCurve2;
        [NMS(Index = 4)]
        /* 0x11A */ public bool AutoAdjustToChildrenHeight;
        [NMS(Index = 5)]
        /* 0x11B */ public bool AutoAdjustToChildrenWidth;
        [NMS(Index = 7)]
        /* 0x11C */ public bool DistributeChildrenHeight;
        [NMS(Index = 6)]
        /* 0x11D */ public bool DistributeChildrenWidth;
        [NMS(Index = 3)]
        /* 0x11E */ public bool InheritStyleFromParentLayer;
    }
}
