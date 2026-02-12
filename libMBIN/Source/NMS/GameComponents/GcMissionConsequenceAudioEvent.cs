using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB37A6F86C101D3F1, NameHash = 0xC261496D)]
    public class GcMissionConsequenceAudioEvent : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcAudioWwiseEvents AudioEvent;
        [NMS(Index = 1)]
        /* 0x4 */ public bool UseFrontendAudioObject;
    }
}
