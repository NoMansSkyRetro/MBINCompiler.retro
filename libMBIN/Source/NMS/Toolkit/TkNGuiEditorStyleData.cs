using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x8B98ACD48ED3F63D, NameHash = 0xE9E49954)]
    public class TkNGuiEditorStyleData : NMSTemplate
    {
        [NMS(Index = 1, Size = 0x8, MxmlName = "Skin Colours")]
        /* 0x0000 */ public TkNGuiEditorStyleColour[] SkinColours;
        [NMS(Index = 3)]
        /* 0x0480 */ public VariableSizeString Font;
        [NMS(Index = 7)]
        /* 0x0490 */ public List<TkNGuiLayoutShortcut> LayoutShortcuts;
        [NMS(Index = 6)]
        /* 0x04A0 */ public List<float> SnapSettings;
        [NMS(Index = 4, Size = 0x5F, EnumType = typeof(TkNGuiEditorGraphicType.NGuiEditorGraphicEnum))]
        /* 0x04B0 */ public TkNGuiGraphicStyle[] GraphicStyles;
        [NMS(Index = 5, Size = 0xF, EnumType = typeof(TKNGuiEditorTextType.NGuiEditorTextEnum))]
        /* 0x9330 */ public TkNGuiTextStyle[] TextStyles;
        [NMS(Index = 0, Size = 0x41, EnumType = typeof(TKNGuiEditorComponentSize.NGuiEditorComponentSizeEnum))]
        /* 0x9C54 */ public float[] Sizes;
        [NMS(Index = 2, MxmlName = "Skin Font Height")]
        /* 0x9D58 */ public float SkinFontHeight;
    }
}
