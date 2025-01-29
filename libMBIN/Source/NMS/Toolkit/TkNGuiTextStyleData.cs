using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x73126CE46AE90B56, NameHash = 0x903BF7DD)]
    public class TkNGuiTextStyleData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public Colour Colour;
        [NMS(Index = 2, MxmlName = "Outline Colour")]
        /* 0x10 */ public Colour OutlineColour;
        [NMS(Index = 1, MxmlName = "Shadow Colour")]
        /* 0x20 */ public Colour ShadowColour;
        [NMS(Index = 5, MxmlName = "Drop Shadow Angle")]
        /* 0x30 */ public float DropShadowAngle;
        [NMS(Index = 6, MxmlName = "Drop Shadow Offset")]
        /* 0x34 */ public float DropShadowOffset;
        [NMS(Index = 3, MxmlName = "Font Height")]
        /* 0x38 */ public float FontHeight;
        [NMS(Index = 8, MxmlName = "Font Index")]
        /* 0x3C */ public int FontIndex;
        [NMS(Index = 4, MxmlName = "Font Spacing")]
        /* 0x40 */ public float FontSpacing;
        [NMS(Index = 7, MxmlName = "Outline Size")]
        /* 0x44 */ public float OutlineSize;
        [NMS(Index = 9)]
        /* 0x48 */ public TkNGuiAlignment Align;
        [NMS(Index = 14, MxmlName = "Allow Scroll")]
        /* 0x4A */ public bool AllowScroll;
        [NMS(Index = 17, MxmlName = "Auto Adjust Font Height")]
        /* 0x4B */ public bool AutoAdjustFontHeight;
        [NMS(Index = 16, MxmlName = "Auto Adjust Height")]
        /* 0x4C */ public bool AutoAdjustHeight;
        [NMS(Index = 18, MxmlName = "Block Audio")]
        /* 0x4D */ public bool BlockAudio;
        [NMS(Index = 19, MxmlName = "Bypass Style Colours")]
        /* 0x4E */ public bool BypassStyleColours;
        [NMS(Index = 20, MxmlName = "Bypass Style Font")]
        /* 0x4F */ public bool BypassStyleFont;
        [NMS(Index = 21, MxmlName = "Bypass Style Font Height")]
        /* 0x50 */ public bool BypassStyleFontHeight;
        [NMS(Index = 15, MxmlName = "Force Upper Case")]
        /* 0x51 */ public bool ForceUpperCase;
        [NMS(Index = 11, MxmlName = "Has Drop Shadow")]
        /* 0x52 */ public bool HasDropShadow;
        [NMS(Index = 12, MxmlName = "Has Outline")]
        /* 0x53 */ public bool HasOutline;
        [NMS(Index = 10, MxmlName = "Is Indented")]
        /* 0x54 */ public bool IsIndented;
        [NMS(Index = 13, MxmlName = "Is Paragraph")]
        /* 0x55 */ public bool IsParagraph;
    }
}
