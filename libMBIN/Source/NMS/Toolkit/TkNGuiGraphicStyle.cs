using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x1B5D669E28609266, NameHash = 0x80EBCD8A)]
    public class TkNGuiGraphicStyle : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public TkNGuiGraphicStyleData Active;
        [NMS(Index = 0)]
        /* 0x070 */ public TkNGuiGraphicStyleData Default;
        [NMS(Index = 1)]
        /* 0x0E0 */ public TkNGuiGraphicStyleData Highlight;
        [NMS(Index = 15)]
        /* 0x150 */ public Vector2f CustomMaxStart;
        [NMS(Index = 14)]
        /* 0x158 */ public Vector2f CustomMinStart;
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
        /* 0x160 */ public AnimateEnum Animate;
        [NMS(Index = 11)]
        /* 0x164 */ public float AnimSplit;
        [NMS(Index = 10)]
        /* 0x168 */ public float AnimTime;
        [NMS(Index = 8)]
        /* 0x16C */ public float GlobalFade;
        [NMS(Index = 7)]
        /* 0x170 */ public float HighlightScale;
        [NMS(Index = 6)]
        /* 0x174 */ public float HighlightTime;
        [NMS(Index = 12)]
        /* 0x178 */ public TkCurveType AnimCurve1;
        [NMS(Index = 13)]
        /* 0x179 */ public TkCurveType AnimCurve2;
        [NMS(Index = 5)]
        /* 0x17A */ public bool DistributeChildrenHeight;
        [NMS(Index = 4)]
        /* 0x17B */ public bool DistributeChildrenWidth;
        [NMS(Index = 3)]
        /* 0x17C */ public bool InheritStyleFromParentLayer;
    }
}
