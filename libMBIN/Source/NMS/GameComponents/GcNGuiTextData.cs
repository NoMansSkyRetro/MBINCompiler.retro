using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDE64309606070537, NameHash = 0xD5C1D227)]
    public class GcNGuiTextData : NMSTemplate
    {
        [NMS(Index = 0, MxmlName = "Element Data")]
        /* 0x000 */ public GcNGuiElementData ElementData;
        [NMS(Index = 7)]
        /* 0x068 */ public List<GcAccessibleOverride_Text> AccessibleOverrides;
        [NMS(Index = 4)]
        /* 0x078 */ public VariableSizeString Image;
        [NMS(Index = 3)]
        /* 0x088 */ public VariableSizeString Text;
        [NMS(Index = 6)]
        /* 0x098 */ public List<GcVROverride_Text> VROverrides;
        [NMS(Index = 2, MxmlName = "Graphic Style")]
        /* 0x0A8 */ public TkNGuiGraphicStyle GraphicStyle;
        [NMS(Index = 1)]
        /* 0x228 */ public TkNGuiTextStyle Style;
        [NMS(Index = 5)]
        /* 0x2C4 */ public float ForcedOffset;
        [NMS(Index = 10)]
        /* 0x2C8 */ public bool BlockSpecialStyles;
        [NMS(Index = 9)]
        /* 0x2C9 */ public bool ForcedAllowScroll;
        [NMS(Index = 8)]
        /* 0x2CA */ public bool Special;
    }
}
