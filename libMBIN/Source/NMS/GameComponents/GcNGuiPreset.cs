using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE08B614504B154E2, NameHash = 0x1EF39842)]
    public class GcNGuiPreset : NMSTemplate
    {
        [NMS(Index = 3, Size = 0xA)]
        /* 0x0000 */ public GcNGuiPresetText[] Text;
        [NMS(Index = 2, Size = 0xA)]
        /* 0x1950 */ public GcNGuiPresetGraphic[] Graphic;
        [NMS(Index = 1, Size = 0xA)]
        /* 0x2C60 */ public GcNGuiPresetGraphic[] Layer;
        [NMS(Index = 4, MxmlName = "Spacing Layout")]
        /* 0x3F70 */ public GcNGuiLayoutData SpacingLayout;
        [NMS(Index = 0)]
        /* 0x3FB8 */ public VariableSizeString Font;
    }
}
