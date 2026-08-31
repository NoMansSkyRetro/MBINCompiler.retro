using libMBIN;
using libMBIN.NMS;
namespace libMBIN.V1_00.Structs
{
    public class GcPlanetHazardData : NMSTemplate
    {
        [NMS(Size = 6)]
        public float[] Temperature;

        [NMS(Size = 6)]
        public float[] Toxicity;

        [NMS(Size = 6)]
        public float[] Radiation;
    }
}
