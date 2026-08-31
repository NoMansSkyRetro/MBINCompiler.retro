namespace libMBIN.V1_38.Structs
{
    public class GcPlanetHazardData : NMSTemplate
    {
        [NMS(Size = 5)]
        public float[] Temperature;

        [NMS(Size = 5)]
        public float[] Toxicity;

        [NMS(Size = 5)]
        public float[] Radiation;

        [NMS(Size = 5)]
        public float[] OutputTemperature;

        [NMS(Size = 5)]
        public float[] OutputToxicity;

        [NMS(Size = 5)]
        public float[] OutputRadiation;
    }
}
