using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x31A0D98362246A50, NameHash = 0x903BF7DD)]
    public class TkNGuiTextStyleData : NMSTemplate
    {
        [NMS(Index = 5, MxmlName = "Drop Shadow Angle")]
        /* 0x00 */ public float DropShadowAngle;
        [NMS(Index = 6, MxmlName = "Drop Shadow Offset")]
        /* 0x04 */ public float DropShadowOffset;
        [NMS(Index = 3, MxmlName = "Font Height")]
        /* 0x08 */ public float FontHeight;
        [NMS(Index = 8, MxmlName = "Font Index")]
        /* 0x0C */ public int FontIndex;
        [NMS(Index = 4, MxmlName = "Font Spacing")]
        /* 0x10 */ public float FontSpacing;
        [NMS(Index = 7, MxmlName = "Outline Size")]
        /* 0x14 */ public float OutlineSize;
        [NMS(Index = 0)]
        /* 0x18 */ public Colour32 Colour;
        [NMS(Index = 2, MxmlName = "Outline Colour")]
        /* 0x1C */ public Colour32 OutlineColour;
        [NMS(Index = 1, MxmlName = "Shadow Colour")]
        /* 0x20 */ public Colour32 ShadowColour;
        [NMS(Index = 9)]
        /* 0x24 */ public TkNGuiAlignment Align;
        [NMS(Index = 14, MxmlName = "Allow Scroll")]
        /* 0x26 */ public bool AllowScroll;
        [NMS(Index = 18, MxmlName = "Auto Adjust Font Height")]
        /* 0x27 */ public bool AutoAdjustFontHeight;
        [NMS(Index = 17, MxmlName = "Auto Adjust Height")]
        /* 0x28 */ public bool AutoAdjustHeight;
        [NMS(Index = 19, MxmlName = "Block Audio")]
        /* 0x29 */ public bool BlockAudio;
        [NMS(Index = 20, MxmlName = "Bypass Style Colours")]
        /* 0x2A */ public bool BypassStyleColours;
        [NMS(Index = 21, MxmlName = "Bypass Style Font")]
        /* 0x2B */ public bool BypassStyleFont;
        [NMS(Index = 22, MxmlName = "Bypass Style Font Height")]
        /* 0x2C */ public bool BypassStyleFontHeight;
        [NMS(Index = 16, MxmlName = "Force Upper Case")]
        /* 0x2D */ public bool ForceUpperCase;
        [NMS(Index = 11, MxmlName = "Has Drop Shadow")]
        /* 0x2E */ public bool HasDropShadow;
        [NMS(Index = 12, MxmlName = "Has Outline")]
        /* 0x2F */ public bool HasOutline;
        [NMS(Index = 10, MxmlName = "Is Indented")]
        /* 0x30 */ public bool IsIndented;
        [NMS(Index = 13, MxmlName = "Is Paragraph")]
        /* 0x31 */ public bool IsParagraph;
        [NMS(Index = 15, MxmlName = "Scroll On Hover")]
        /* 0x32 */ public bool ScrollOnHover;
    }
}
