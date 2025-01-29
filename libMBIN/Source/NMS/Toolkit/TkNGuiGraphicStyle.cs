using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x79AA9AF064027FF8, NameHash = 0x80EBCD8A)]
    public class TkNGuiGraphicStyle : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public TkNGuiGraphicStyleData Active;
        [NMS(Index = 0)]
        /* 0x0B0 */ public TkNGuiGraphicStyleData Default;
        [NMS(Index = 1)]
        /* 0x160 */ public TkNGuiGraphicStyleData Highlight;
        [NMS(Index = 15)]
        /* 0x210 */ public Vector2f CustomMaxStart;
        [NMS(Index = 14)]
        /* 0x218 */ public Vector2f CustomMinStart;
        // size: 0x6
        public enum AnimateEnum : uint {
            None,
            WipeRightToLeft,
            SimpleWipe,
            SimpleWipeDown,
            CustomWipe,
            CustomWipeAlpha,
        }
        [NMS(Index = 9)]
        /* 0x220 */ public AnimateEnum Animate;
        [NMS(Index = 11)]
        /* 0x224 */ public float AnimSplit;
        [NMS(Index = 10)]
        /* 0x228 */ public float AnimTime;
        [NMS(Index = 8)]
        /* 0x22C */ public float GlobalFade;
        [NMS(Index = 7)]
        /* 0x230 */ public float HighlightScale;
        [NMS(Index = 6)]
        /* 0x234 */ public float HighlightTime;
        [NMS(Index = 12)]
        /* 0x238 */ public TkCurveType AnimCurve1;
        [NMS(Index = 13)]
        /* 0x239 */ public TkCurveType AnimCurve2;
        [NMS(Index = 5)]
        /* 0x23A */ public bool DistributeChildrenHeight;
        [NMS(Index = 4)]
        /* 0x23B */ public bool DistributeChildrenWidth;
        [NMS(Index = 3)]
        /* 0x23C */ public bool InheritStyleFromParentLayer;
    }
}
