using System.Collections.Generic;

using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_09_1.Structs
{
    public class GcRealityManagerData : NMSTemplate
    {
        public float RealityIteration;

        // TODO: Probably keep these values in a static class.
        [NMS(Size = 7, EnumValue = new string[7] { "Unknown", "SolarSystem", "Planet", "Animal", "Flora", "Mineral", "Sector" })]
        public GcDiscoveryWorth[] DiscoveryWorth;

        [NMS(Size = 0x80)]
        public string TechnologyTable;
        [NMS(Size = 0x80)]
        public string SubstanceTable;
        [NMS(Size = 0x80)]
        public string ProductTable;
        [NMS(Size = 0x80)]
        public string AlienWordsTable;
        [NMS(Size = 0x80)]
        public string AlienPuzzlesTable;
        [NMS(Size = 0x80)]
        public string RewardTable;
        [NMS(Size = 0x80)]
        public string RewardDestructTable;
        [NMS(Size = 0x80)]
        public string InventoryTable;
        [NMS(Size = 0x80)]
        public string DamageTable;
        [NMS(Size = 0x80)]
        public string CostTable;

        public GcRealityIconTable Icons;

        [NMS(Size = 6, EnumValue = new string[6] { "None", "NoOxygen", "ExtremeHeat", "ExtremeCold", "ToxicGas", "Radiation" })]
        public Colour[] HazardColours;

        [NMS(Size = 3, EnumValue = new string[3] { "Common", "Uncommon", "Rare" })]
        public Colour[] RarityColours;

        [NMS(Size = 6, EnumValue = new string[6] { "Commodity", "Technology", "Fuel", "Tradeable", "Special", "BuildingPart" })]
        /* 0x19A0 */ public Colour[] SubstanceCategoryColours;

        [NMS(Size = 6, EnumValue = new string[6] { "Commodity", "Technology", "Fuel", "Tradeable", "Special", "BuildingPart" })]
        public TkTextureResource[] SubstanceChargeIcons;

        // 1.09.1: 68 stat icons (the era list of 77 names came later)
        [NMS(Size = 68)]
        public TkTextureResource[] StatCategoryIcons;

        // 1.09.1: eleven flat stat groups (the Suit/Weapon/Ship split came later)
        [NMS(Size = 11)]
        public GcStatsGroup[] StatGroups;


        public List<int> SuitUpgradePrices;

        public List<NMSString0x10> NeverSellableItems;

        public List<NMSString0x10> NeverOfferedForSale;

        // 1.09.1: trade settings come after the price lists
        public GcTradeSettings TradeSettings;

        [NMS(Size = 6, EnumValue = new string[6] { "Commodity", "Technology", "Fuel", "Tradeable", "Special", "BuildingPart" })]
        public float[] NormalizedPriceLimits;

        [NMS(Size = 0x8, Ignore = true)] // 8, not 0xC: the struct ends 16-aligned at 0x4D40
        public byte[] Padding47E4;
    }
}
