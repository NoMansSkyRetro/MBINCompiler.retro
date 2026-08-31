using libMBIN.NMS;

namespace libMBIN.V1_00.Structs
{
    public class GcPlanetWeatherColourData : NMSTemplate // disc: no SkyUpper/SkySolar/SkyGradientSpeed
    {
        public Colour SkyColour;
        public Colour HorizonColour;
        public Colour SunColour;
        public Colour FogColour;
        public Colour HeightFogColour;
        public Colour LightColour;
        public Colour CloudColour1;
        public Colour CloudColour2;
    }
}
