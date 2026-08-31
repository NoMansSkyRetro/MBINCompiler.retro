using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.V1_00.Structs
{
    // disc layout from PS4 eboot FUN_006f40b0: extra Sky/MaxSky horizon blocks, no Override
    // bools, 3 hazard groups x 6 triplets. Fog binds to the V1_00 GcFogProperties.
    public class GcWeatherProperties : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 Name;
        /* 0x010 */ public GcSkyHorizonData Sky;
        /* 0x030 */ public GcFogProperties Fog;
        /* 0x10c */ public GcFogProperties FlightFog;
        /* 0x1e8 */ public GcSkyHorizonData MaxSky;
        /* 0x208 */ public GcFogProperties StormFog;
        /* 0x2f0 */ public GcWeatherColourModifiers StormColourModifiers;
        /* 0x560 */ public GcFogProperties ExtremeFog;
        /* 0x640 */ public GcWeatherColourModifiers ExtremeColourModifiers;
        /* 0x8b0 */ public List<NMSString0x80> HeavyAir;
        /* 0x8c0 */ public float LowStormsChance;
        /* 0x8c4 */ public float HighStormsChance;
        /* 0x8c8 */ public float ExtremeWeatherChance;
        [NMS(Size = 6)] /* 0x8cc */ public GcWeatherHazardTriplet[] Temperature;
        [NMS(Size = 6)] /* 0x914 */ public GcWeatherHazardTriplet[] Toxicity;
        [NMS(Size = 6)] /* 0x95c */ public GcWeatherHazardTriplet[] Radiation;
    }
}
