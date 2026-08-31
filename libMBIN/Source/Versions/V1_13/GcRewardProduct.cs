using libMBIN.NMS;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.V1_13.Structs
{
    public class GcRewardProduct : NMSTemplate // 0x1C
    {
        public GcRealitySubstanceCategory Category;
        public GcRarity Rarity;
        public int ItemLevel;
        [NMS(Size = 4, EnumValue = new[] { "Component", "Device", "Consumable", "Curiosity" })]
        public bool[] AllowedProductTypes;
        public int AmountMin;
        public int AmountMax;
        public int Unknown18;
    }
}
