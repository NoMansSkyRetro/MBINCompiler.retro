using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB73332A2242F834D, NameHash = 0xD5C1D227)]
    public class GcNGuiTextData : NMSTemplate
    {
        [NMS(Index = 2, MxmlName = "Graphic Style")]
        /* 0x000 */ public TkNGuiGraphicStyle GraphicStyle;
        [NMS(Index = 1)]
        /* 0x240 */ public TkNGuiTextStyle Style;
        [NMS(Index = 0, MxmlName = "Element Data")]
        /* 0x360 */ public GcNGuiElementData ElementData;
        [NMS(Index = 7)]
        /* 0x3C8 */ public List<GcAccessibleOverride_Text> AccessibleOverrides;
        [NMS(Index = 4)]
        /* 0x3D8 */ public VariableSizeString Image;
        [NMS(Index = 3)]
        /* 0x3E8 */ public VariableSizeString Text;
        [NMS(Index = 6)]
        /* 0x3F8 */ public List<GcVROverride_Text> VROverrides;
        [NMS(Index = 5)]
        /* 0x408 */ public float ForcedOffset;
        [NMS(Index = 10)]
        /* 0x40C */ public bool BlockSpecialStyles;
        [NMS(Index = 9)]
        /* 0x40D */ public bool ForcedAllowScroll;
        [NMS(Index = 8)]
        /* 0x40E */ public bool Special;
    }
}
