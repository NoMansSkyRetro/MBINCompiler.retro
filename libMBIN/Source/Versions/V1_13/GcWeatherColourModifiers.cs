using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
{
    public class GcWeatherColourModifiers : NMSTemplate
    {
        public GcColourModifier SkyColour;
        public GcColourModifier HorizonColour;
        public GcColourModifier SunColour;
        public GcColourModifier FogColour;
        public GcColourModifier HeightFogColour;
        public GcColourModifier LightColour;
        public GcColourModifier CloudColour1;
        public GcColourModifier CloudColour2;

        [NMS(Size = 5)]
        public GcColourModifier[] HeavyAirColour;
    }
}
