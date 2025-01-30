using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x7B2B5D630B5FF0F9, NameHash = 0x703BD36A)]
    public class TkLanguageFontTableEntry : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public VariableSizeString ConsoleFont;
        [NMS(Index = 4)]
        /* 0x10 */ public VariableSizeString ConsoleFont2;
        [NMS(Index = 1)]
        /* 0x20 */ public VariableSizeString GameFont;
        [NMS(Index = 2)]
        /* 0x30 */ public VariableSizeString GameFont2;
        [NMS(Index = 0)]
        /* 0x40 */ public TkLanguages Language;
    }
}
