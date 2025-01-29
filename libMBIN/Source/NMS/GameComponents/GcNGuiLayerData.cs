using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x39E3571F52A35BD6, NameHash = 0xA151C99F)]
    public class GcNGuiLayerData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x000 */ public TkNGuiGraphicStyle Style;
        [NMS(Index = 0, MxmlName = "Element Data")]
        /* 0x240 */ public GcNGuiElementData ElementData;
        [NMS(Index = 3)]
        /* 0x2A8 */ public List<NMSTemplate> Children;
        [NMS(Index = 4)]
        /* 0x2B8 */ public VariableSizeString DataFilename;
        [NMS(Index = 2)]
        /* 0x2C8 */ public VariableSizeString Image;
        // size: 0x5
        public enum AltModeEnum : uint {
            None,
            Normal,
            Alt,
            NeverOnTouch,
            OnlyOnTouch,
        }
        [NMS(Index = 5)]
        /* 0x2D8 */ public AltModeEnum AltMode;
    }
}
