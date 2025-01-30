using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3A40FE60E19C38E3, NameHash = 0xAFEEEF4C)]
    public class GcCustomisationPreset : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public GcCharacterCustomisationData Data;
        [NMS(Index = 0)]
        /* 0x58 */ public NMSString0x10 Name;
    }
}
