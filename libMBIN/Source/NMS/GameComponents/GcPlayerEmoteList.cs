using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x76AA283E8A6F5CFA, NameHash = 0xDC769B4C)]
    public class GcPlayerEmoteList : NMSTemplate
    {
        [NMS(Index = 0, KeyField = "EmoteID")]
        /* 0x0 */ public HashMap<GcPlayerEmote> Emotes;
    }
}
