using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x14A9D3CA83B277C4, NameHash = 0xA40EDAE)]
    public class GcNGuiPresetGraphic : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public TkNGuiGraphicStyle Style;
        [NMS(Index = 1)]
        /* 0x240 */ public GcNGuiLayoutData Layout;
        [NMS(Index = 3)]
        /* 0x288 */ public VariableSizeString Image;
        [NMS(Index = 0)]
        /* 0x298 */ public NMSString0x10 PresetID;
    }
}
