using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8C9B91B14CA49252, NameHash = 0x1EF39842)]
    public class GcNGuiPreset : NMSTemplate
    {
        [NMS(Index = 3, Size = 0xA)]
        /* 0x0000 */ public GcNGuiPresetText[] Text;
        [NMS(Index = 2, Size = 0xA)]
        /* 0x1590 */ public GcNGuiPresetGraphic[] Graphic;
        [NMS(Index = 1, Size = 0xA)]
        /* 0x24E0 */ public GcNGuiPresetGraphic[] Layer;
        [NMS(Index = 4, MxmlName = "Spacing Layout")]
        /* 0x3430 */ public GcNGuiLayoutData SpacingLayout;
        [NMS(Index = 0)]
        /* 0x3478 */ public VariableSizeString Font;
    }
}
