using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x8F024C7F5B7460BD, NameHash = 0x93482A51)]
    public class TkNGuiGraphicStyleData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public Colour Colour;
        [NMS(Index = 3, MxmlName = "Gradient Colour")]
        /* 0x10 */ public Colour GradientColour;
        [NMS(Index = 1, MxmlName = "Icon Colour")]
        /* 0x20 */ public Colour IconColour;
        [NMS(Index = 2, MxmlName = "Stroke Colour")]
        /* 0x30 */ public Colour StrokeColour;
        [NMS(Index = 4, MxmlName = "Stroke Gradient Colour")]
        /* 0x40 */ public Colour StrokeGradientColour;
        [NMS(Index = 26)]
        /* 0x50 */ public TkNGuiGraphicAnimatedImageData Animated;
        [NMS(Index = 11, MxmlName = "Corner Radius")]
        /* 0x70 */ public float CornerRadius;
        [NMS(Index = 15)]
        /* 0x74 */ public float Desaturation;
        [NMS(Index = 14)]
        /* 0x78 */ public TkNGuiEditorIcons EditorIcon;
        [NMS(Index = 10, MxmlName = "Gradient End Offset")]
        /* 0x7C */ public float GradientEndOffset;
        [NMS(Index = 9, MxmlName = "Gradient Start Offset")]
        /* 0x80 */ public float GradientStartOffset;
        [NMS(Index = 13)]
        /* 0x84 */ public int Image;
        [NMS(Index = 7)]
        /* 0x88 */ public float MarginX;
        [NMS(Index = 8)]
        /* 0x8C */ public float MarginY;
        [NMS(Index = 5)]
        /* 0x90 */ public float PaddingX;
        [NMS(Index = 6)]
        /* 0x94 */ public float PaddingY;
        [NMS(Index = 17, MxmlName = "Stroke Gradient Feather")]
        /* 0x98 */ public float StrokeGradientFeather;
        [NMS(Index = 16, MxmlName = "Stroke Gradient Offset")]
        /* 0x9C */ public float StrokeGradientOffset;
        [NMS(Index = 12, MxmlName = "Stroke Size")]
        /* 0xA0 */ public float StrokeSize;
        // size: 0x6
        public enum GradientEnum : byte {
            None,
            Vertical,
            Horizontal,
            HorizontalBounce,
            Radial,
            Box,
        }
        [NMS(Index = 19)]
        /* 0xA4 */ public GradientEnum Gradient;
        [NMS(Index = 24, MxmlName = "Gradient Offset Percent")]
        /* 0xA5 */ public bool GradientOffsetPercent;
        [NMS(Index = 21, MxmlName = "Has Drop Shadow")]
        /* 0xA6 */ public bool HasDropShadow;
        [NMS(Index = 23, MxmlName = "Has Inner Gradient")]
        /* 0xA7 */ public bool HasInnerGradient;
        [NMS(Index = 22, MxmlName = "Has Outer Gradient")]
        /* 0xA8 */ public bool HasOuterGradient;
        // size: 0x8
        public enum ShapeEnum : byte {
            Rectangle,
            Ellipse,
            Line,
            LineInverted,
            Bezier,
            BezierInverted,
            BezierWide,
            BezierWideInverted,
        }
        [NMS(Index = 18)]
        /* 0xA9 */ public ShapeEnum Shape;
        [NMS(Index = 20, MxmlName = "Solid Colour")]
        /* 0xAA */ public bool SolidColour;
        [NMS(Index = 25, MxmlName = "Stroke Gradient")]
        /* 0xAB */ public bool StrokeGradient;
    }
}
