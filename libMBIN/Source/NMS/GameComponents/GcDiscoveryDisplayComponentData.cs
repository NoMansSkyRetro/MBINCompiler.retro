using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBC6BAA311917DBE5, NameHash = 0xA379DDEE)]
    public class GcDiscoveryDisplayComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public GcScanEffectData DiscoveryScanEffect;
        [NMS(Index = 1)]
        /* 0x50 */ public float DiscoveryScale;
        [NMS(Index = 2)]
        /* 0x54 */ public float DiscoveryScalePlanets;
    }
}
