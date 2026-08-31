using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace libMBIN.V1_00.Structs
{
    public class GcPlanetWeatherData : NMSTemplate // disc: extra day colour block, short tail
    {
        public GcWeatherOptions WeatherOptions;

        [NMS(Size = 0x10)]
        public Colour[] DayColours;

        public GcPlanetWeatherColourData NightColours;
        public GcPlanetHeavyAirData HeavyAir;
        public float NightDensity;
        public int WeatherIntensity;
        public int StormFrequency;
        public int AtmosphereType;
    }
}
