using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2E9F42C3A43BB7B7, NameHash = 0xDC769B4C)]
    public class GcPlayerEmoteList : NMSTemplate
    {
        [NMS(Index = 0, KeyField = "EmoteID")]
        /* 0x0 */ public HashMap<GcPlayerEmote> Emotes;
    }
}
