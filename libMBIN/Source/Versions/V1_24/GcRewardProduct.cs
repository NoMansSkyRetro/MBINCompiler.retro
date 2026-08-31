namespace libMBIN.V1_24.Structs
{
    public class GcRewardProduct : NMSTemplate
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
