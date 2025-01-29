using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7A68031D4DE8C733, NameHash = 0xB38C6150)]
    public class GcNGuiGraphicData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x000 */ public TkNGuiGraphicStyle Style;
        [NMS(Index = 0, MxmlName = "Element Data")]
        /* 0x240 */ public GcNGuiElementData ElementData;
        [NMS(Index = 2)]
        /* 0x2A8 */ public VariableSizeString Image;
        [NMS(Index = 3)]
        /* 0x2B8 */ public float Angle;
    }
}
