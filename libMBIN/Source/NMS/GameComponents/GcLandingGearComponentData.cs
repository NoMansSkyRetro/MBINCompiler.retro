using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF31EC1F4C7DE739C, NameHash = 0xC1383C3B)]
    public class GcLandingGearComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public float DeployTime;
        [NMS(Index = 5)]
        /* 0x04 */ public GcAudioWwiseEvents EndAudioEvent;
        [NMS(Index = 2)]
        /* 0x08 */ public float RetractTime;
        [NMS(Index = 4)]
        /* 0x0C */ public GcAudioWwiseEvents StartAudioEvent;
        [NMS(Index = 1)]
        /* 0x10 */ public TkCurveType DeployCurve;
        [NMS(Index = 3)]
        /* 0x11 */ public TkCurveType RetractCurve;
    }
}
