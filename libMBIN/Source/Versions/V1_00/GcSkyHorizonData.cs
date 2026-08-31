using libMBIN.NMS;

namespace libMBIN.V1_00.Structs
{
    // disc-only sub-struct of GcWeatherProperties (8 floats, 0x20); from PS4 eboot FUN_006f22c0
    public class GcSkyHorizonData : NMSTemplate
    {
        public float AtmosphereThickness;
        public float HorizonMultiplier;
        public float DuskHorizonMultiplier;
        public float NightHorizonMultiplier;
        public float HorizonFadeSpeed;
        public float DayHorizonTightness;
        public float SunSize;
        public float SunStrength;
    }
}
