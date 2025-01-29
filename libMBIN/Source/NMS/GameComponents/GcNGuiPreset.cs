using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB04E6E9B4E13858B, NameHash = 0x1EF39842)]
    public class GcNGuiPreset : NMSTemplate
    {
        [NMS(Index = 3, Size = 0xA)]
        /* 0x0000 */ public GcNGuiPresetText[] Text;
        [NMS(Index = 2, Size = 0xA)]
        /* 0x2620 */ public GcNGuiPresetGraphic[] Graphic;
        [NMS(Index = 1, Size = 0xA)]
        /* 0x4100 */ public GcNGuiPresetGraphic[] Layer;
        [NMS(Index = 4, MxmlName = "Spacing Layout")]
        /* 0x5BE0 */ public GcNGuiLayoutData SpacingLayout;
        [NMS(Index = 0)]
        /* 0x5C28 */ public VariableSizeString Font;
    }
}
