using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x986DFA5645312F8E, NameHash = 0xB76358D6)]
    public class GcPlayerTitleData : NMSTemplate
    {
        [NMS(Index = 0, KeyField = "ID")]
        /* 0x0 */ public HashMap<GcPlayerTitle> Titles;
    }
}
