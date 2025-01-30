using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x49350F77FBF25252, NameHash = 0x1D0BA017)]
    public class GcNGuiPresetText : NMSTemplate
    {
        [NMS(Index = 3, MxmlName = "Graphic Style")]
        /* 0x000 */ public TkNGuiGraphicStyle GraphicStyle;
        [NMS(Index = 2)]
        /* 0x240 */ public TkNGuiTextStyle Style;
        [NMS(Index = 1)]
        /* 0x360 */ public GcNGuiLayoutData Layout;
        [NMS(Index = 4)]
        /* 0x3A8 */ public VariableSizeString Image;
        [NMS(Index = 0)]
        /* 0x3B8 */ public NMSString0x10 PresetID;
    }
}
