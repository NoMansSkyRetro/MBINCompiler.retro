using libMBIN.NMS;

namespace libMBIN.V1_00.Structs
{
    public class GcPlanetInfo : NMSTemplate // disc: six strings
    {
        public NMSString0x80 PlanetDescription;
        public NMSString0x80 PlanetType;
        public NMSString0x80 Weather;
        public NMSString0x80 Resources;
        public NMSString0x80 Flora;
        public NMSString0x80 Fauna;
        public bool IsWeatherExtreme;
        public bool AreSentinelsExtreme;
    }
}
