using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAFB7377F81A1AF55, NameHash = 0xB38C6150)]
    public class GcNGuiGraphicData : NMSTemplate
    {
        [NMS(Index = 0, MxmlName = "Element Data")]
        /* 0x000 */ public GcNGuiElementData ElementData;
        [NMS(Index = 2)]
        /* 0x068 */ public VariableSizeString Image;
        [NMS(Index = 1)]
        /* 0x078 */ public TkNGuiGraphicStyle Style;
        [NMS(Index = 3)]
        /* 0x198 */ public float Angle;
    }
}
