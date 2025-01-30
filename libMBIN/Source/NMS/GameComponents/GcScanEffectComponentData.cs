using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xADC4CDC42C8C96AD, NameHash = 0x309F7D36, Alignment = 0x10)]
    public class GcScanEffectComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<GcScanEffectData> ScanEffects;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x40 NodeName;
    }
}
