using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x309B0C1094EFDDC3, NameHash = 0xE9E49954)]
    public class TkNGuiEditorStyleData : NMSTemplate
    {
        [NMS(Index = 4, Size = 0x5F, EnumType = typeof(TkNGuiEditorGraphicType.NGuiEditorGraphicEnum))]
        /* 0x0000 */ public TkNGuiGraphicStyle[] GraphicStyles;
        [NMS(Index = 5, Size = 0xF, EnumType = typeof(TKNGuiEditorTextType.NGuiEditorTextEnum))]
        /* 0xD5C0 */ public TkNGuiTextStyle[] TextStyles;
        [NMS(Index = 1, Size = 0x8, MxmlName = "Skin Colours")]
        /* 0xE6A0 */ public TkNGuiEditorStyleColour[] SkinColours;
        [NMS(Index = 3)]
        /* 0xEB20 */ public VariableSizeString Font;
        [NMS(Index = 7)]
        /* 0xEB30 */ public List<TkNGuiLayoutShortcut> LayoutShortcuts;
        [NMS(Index = 6)]
        /* 0xEB40 */ public List<float> SnapSettings;
        [NMS(Index = 0, Size = 0x41, EnumType = typeof(TKNGuiEditorComponentSize.NGuiEditorComponentSizeEnum))]
        /* 0xEB50 */ public float[] Sizes;
        [NMS(Index = 2, MxmlName = "Skin Font Height")]
        /* 0xEC54 */ public float SkinFontHeight;
    }
}
