using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x141EDF1C0A9F4FD3, NameHash = 0x20C96CD2)]
    public class GcLightingRigComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<GcHeroLightData> LightData;
        [NMS(Index = 2)]
        /* 0x10 */ public float PitchAngleMax;
        [NMS(Index = 1)]
        /* 0x14 */ public float PitchAngleMin;
    }
}
