using libMBIN.NMS;

namespace libMBIN.V1_00.Structs
{
    // disc hazard value is a triplet (0xC) not a Min/Max pair; from PS4 eboot FUN_006f2f90
    public class GcWeatherHazardTriplet : NMSTemplate
    {
        public float Min;
        public float Average;
        public float Max;
    }
}
