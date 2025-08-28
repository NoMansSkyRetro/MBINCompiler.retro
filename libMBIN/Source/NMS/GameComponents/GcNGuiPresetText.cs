using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBF578E8D71FF7A52, NameHash = 0x1D0BA017)]
    public class GcNGuiPresetText : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x000 */ public GcNGuiLayoutData Layout;
        [NMS(Index = 4)]
        /* 0x048 */ public VariableSizeString Image;
        [NMS(Index = 0)]
        /* 0x058 */ public NMSString0x10 PresetID;
        [NMS(Index = 3, MxmlName = "Graphic Style")]
        /* 0x068 */ public TkNGuiGraphicStyle GraphicStyle;
        [NMS(Index = 2)]
        /* 0x188 */ public TkNGuiTextStyle Style;
    }
}
