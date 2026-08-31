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

        // 1.09.1 icon region, derived from DEFAULTREALITY bytes: 35 icons, one dword,
        // 14 colours, 75 icons (some with empty paths), five dwords, one icon, one dword
        [NMS(Size = 35)]
        public TkTextureResource[] IconsA;
        public int Unknown179C;
        [NMS(Size = 14)]
        public Colour[] Colours17A0;
        [NMS(Size = 75)]
        public TkTextureResource[] IconsB;
        public int Unknown3F2C;
        public int Unknown3F30;
        public int Unknown3F34;
        public int Unknown3F38;
        public int Unknown3F3C;
        [NMS(Size = 1)]
        public TkTextureResource[] IconsC;
        public int Unknown3FC4;

        // 1.09.1: eleven flat stat groups (the Suit/Weapon/Ship split came later)
        [NMS(Size = 11)]
        public GcStatsGroup[] StatGroups;

        // 1.09.1 tail, derived from DEFAULTREALITY bytes: an extra stats list, the two
        // never-lists, one trade block, twelve loose dwords, the 37 suit upgrade prices,
        // and a four-string list before the price limits
        public List<GcStatsEntry> UnknownStatsList;
        public List<NMSString0x10> NeverSellableItems;
        public List<NMSString0x10> NeverOfferedForSale;
        public GcTradeData TradeSpaceStation;
        public int UnknownT0; public int UnknownT1; public int UnknownT2; public float UnknownT3;
        public int UnknownT4; public int UnknownT5; public int UnknownT6; public int UnknownT7;
        public int UnknownT8; public int UnknownT9; public float UnknownT10; public int UnknownT11;
        public List<int> SuitUpgradePrices;
        public List<NMSString0x10> Unknown47C0;
        [NMS(Size = 6, EnumValue = new string[6] { "Commodity", "Technology", "Fuel", "Tradeable", "Special", "BuildingPart" })]
        public float[] NormalizedPriceLimits;

        [NMS(Size = 0x8, Ignore = true)] // 8, not 0xC: the struct ends 16-aligned at 0x4D40
        public byte[] Padding47E4;
    }
}
