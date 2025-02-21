using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x65DD5ECD4CE3B7B0, NameHash = 0x6D1FFAE5)]
    public class TkNGuiTextStyle : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public TkNGuiTextStyleData Active;
        [NMS(Index = 0)]
        /* 0x34 */ public TkNGuiTextStyleData Default;
        [NMS(Index = 1)]
        /* 0x68 */ public TkNGuiTextStyleData Highlight;
    }
}
