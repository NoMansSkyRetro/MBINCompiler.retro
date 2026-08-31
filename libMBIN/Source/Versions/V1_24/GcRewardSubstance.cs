using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace libMBIN.V1_24.Structs
{
    public class GcRewardSubstance : NMSTemplate // 0x20
    {
        public GcRealitySubstanceCategory ItemCategory;
        public GcRarity ItemRarity;
        public int ItemLevel;
        public int AmountMin;
        public int AmountMax;
        public float HardModeMultiplier;
        public bool DisableMultiplier;
    }
}
