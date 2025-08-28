using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x741D820487C5C477, NameHash = 0xEDA97B90)]
    public class GcRealityManagerData : NMSTemplate
    {
        [NMS(Index = 63, Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x0000 */ public Colour[] SubstanceCategoryColours;
        [NMS(Index = 61, Size = 0x7, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x0090 */ public Colour[] HazardColours;
        [NMS(Index = 62, Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x0100 */ public Colour[] RarityColours;
        [NMS(Index = 72)]
        /* 0x0130 */ public GcTradeSettings TradeSettings;
        [NMS(Index = 60)]
        /* 0x18C0 */ public GcRealityIconTable Icons;
        [NMS(Index = 65, Size = 0xCE, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x2DC0 */ public TkTextureResource[] StatCategoryIcons;
        [NMS(Index = 66, Size = 0xCE, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x4110 */ public TkTextureResource[] StatTechPackageIcons;
        [NMS(Index = 55, Size = 0x21, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x5460 */ public GcNumberedTextList[] MissionNameAdjectives;
        [NMS(Index = 54, Size = 0x21, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x5778 */ public GcNumberedTextList[] MissionNameFormats;
        [NMS(Index = 56, Size = 0x21, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x5A90 */ public GcNumberedTextList[] MissionNameNouns;
        [NMS(Index = 5)]
        /* 0x5DA8 */ public GcSubstanceSecondaryBiome SubstanceSecondaryBiome;
        [NMS(Index = 48, Size = 0x7, EnumType = typeof(GcShipWeapons.ShipWeaponEnum))]
        /* 0x5FC8 */ public GcShipWeaponData[] ShipWeapons;
        [NMS(Index = 52, Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x6188 */ public NMSString0x20A[] FactionNames;
        [NMS(Index = 49, Size = 0x14, EnumType = typeof(GcPlayerWeapons.WeaponModeEnum))]
        /* 0x62C8 */ public GcPlayerWeaponData[] PlayerWeapons;
        [NMS(Index = 71, Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x6408 */ public GcRepShopData[] RepShops;
        [NMS(Index = 70, Size = 0x11, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x6548 */ public GcTechList[] PlanetTechShops;
        [NMS(Index = 53, Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x6658 */ public GcNumberedTextList[] FactionClients;
        [NMS(Index = 64, Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x6748 */ public TkTextureResource[] SubstanceChargeIcons;
        [NMS(Index = 57, Size = 0xB)]
        /* 0x6820 */ public TkIdArray[] MissionBoardRewardOptions;
        [NMS(Index = 51, Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x68D0 */ public NMSString0x10[] FactionStandingIDs;
        [NMS(Index = 50, Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x6970 */ public TkIdArray[] DefaultVehicleLoadout;
        [NMS(Index = 88, Size = 0x5, EnumType = typeof(GcCatalogueGroups.CatalogueGroupEnum))]
        /* 0x69E0 */ public VariableSizeString[] Catalogues;
        // size: 0x5
        public enum StatsEnum {
            Suit,
            Weapon,
            Ship,
            Freighter,
            Vehicle,
        }
        [NMS(Index = 68, Size = 0x5, EnumType = typeof(StatsEnum))]
        /* 0x6A30 */ public GcStats[] Stats;
        [NMS(Index = 8, Size = 0x3, EnumType = typeof(GcProductTableType.ProductTableTypeEnum))]
        /* 0x6A80 */ public VariableSizeString[] ProductTables;
        [NMS(Index = 79)]
        /* 0x6AB0 */ public GcInventoryLayout ShipCargoOnlyStartingLayout;
        [NMS(Index = 77)]
        /* 0x6AC8 */ public GcInventoryLayout ShipStartingLayout;
        [NMS(Index = 78)]
        /* 0x6AE0 */ public GcInventoryLayout ShipTechOnlyStartingLayout;
        [NMS(Index = 76)]
        /* 0x6AF8 */ public GcInventoryLayout SuitCargoStartingSlotLayout;
        [NMS(Index = 74)]
        /* 0x6B10 */ public GcInventoryLayout SuitStartingSlotLayout;
        [NMS(Index = 75)]
        /* 0x6B28 */ public GcInventoryLayout SuitTechOnlyStartingSlotLayout;
        [NMS(Index = 22)]
        /* 0x6B40 */ public List<VariableSizeString> AlienPuzzleTables;
        [NMS(Index = 21)]
        /* 0x6B50 */ public VariableSizeString AlienWordsTable;
        [NMS(Index = 20)]
        /* 0x6B60 */ public VariableSizeString BaitDataTable;
        [NMS(Index = 58)]
        /* 0x6B70 */ public List<GcRewardMissionOverride> BuilderMissionRewardOverrides;
        [NMS(Index = 45)]
        /* 0x6B80 */ public VariableSizeString CombatEffectsTable;
        [NMS(Index = 13)]
        /* 0x6B90 */ public VariableSizeString ConsumableItemTable;
        [NMS(Index = 38)]
        /* 0x6BA0 */ public VariableSizeString CostTable;
        [NMS(Index = 26)]
        /* 0x6BB0 */ public List<GcDamageMultiplierLookup> DamageMultiplierTable;
        [NMS(Index = 32)]
        /* 0x6BC0 */ public VariableSizeString DamageTable;
        [NMS(Index = 16)]
        /* 0x6BD0 */ public VariableSizeString DialogClearanceTable;
        [NMS(Index = 29)]
        /* 0x6BE0 */ public VariableSizeString DiscoveryRewardTable;
        [NMS(Index = 86)]
        /* 0x6BF0 */ public List<GcFiendCrimeSpawnTable> FiendCrimeSpawnTable;
        [NMS(Index = 19)]
        /* 0x6C00 */ public VariableSizeString FishDataTable;
        [NMS(Index = 87)]
        /* 0x6C10 */ public List<GcIDPair> FreighterBaseItemPairs;
        [NMS(Index = 47)]
        /* 0x6C20 */ public List<GcFreighterCargoOption> FreighterCargoOptions;
        [NMS(Index = 27)]
        /* 0x6C30 */ public VariableSizeString HistoricalSeasonDataTable;
        [NMS(Index = 31)]
        /* 0x6C40 */ public VariableSizeString InventoryTable;
        [NMS(Index = 11)]
        /* 0x6C50 */ public VariableSizeString LegacyItemConversionTable;
        [NMS(Index = 12)]
        /* 0x6C60 */ public List<TkRawID> LegacyRepairTable;
        [NMS(Index = 41)]
        /* 0x6C70 */ public VariableSizeString MaintenanceGroupsTable;
        [NMS(Index = 18)]
        /* 0x6C80 */ public VariableSizeString MaintenanceOverrideTable;
        [NMS(Index = 84)]
        /* 0x6C90 */ public List<NMSString0x10> NeverOfferedForSale;
        [NMS(Index = 83)]
        /* 0x6CA0 */ public List<NMSString0x10> NeverSellableItems;
        [NMS(Index = 73)]
        /* 0x6CB0 */ public List<NMSString0x10> PirateStationExtraProds;
        [NMS(Index = 44)]
        /* 0x6CC0 */ public VariableSizeString PlayerWeaponPropertiesTable;
        [NMS(Index = 9)]
        /* 0x6CD0 */ public VariableSizeString ProceduralProductTable;
        [NMS(Index = 10)]
        /* 0x6CE0 */ public VariableSizeString ProceduralTechnologyTable;
        [NMS(Index = 17)]
        /* 0x6CF0 */ public VariableSizeString ProductDescriptionOverrideTable;
        [NMS(Index = 33)]
        /* 0x6D00 */ public VariableSizeString PurchaseableBuildingBlueprintsTable;
        [NMS(Index = 34)]
        /* 0x6D10 */ public VariableSizeString PurchaseableSpecialsTable;
        [NMS(Index = 14)]
        /* 0x6D20 */ public VariableSizeString RecipeTable;
        [NMS(Index = 28)]
        /* 0x6D30 */ public VariableSizeString RewardTable;
        [NMS(Index = 43)]
        /* 0x6D40 */ public VariableSizeString SettlementPerksTable;
        [NMS(Index = 69)]
        /* 0x6D50 */ public GcTechList StationTechShops;
        [NMS(Index = 30)]
        /* 0x6D60 */ public VariableSizeString StatRewardsTable;
        [NMS(Index = 15)]
        /* 0x6D70 */ public VariableSizeString StoriesTable;
        [NMS(Index = 4)]
        /* 0x6D80 */ public List<GcSubstanceSecondaryLookup> SubstanceSecondaryLookups;
        [NMS(Index = 7)]
        /* 0x6D90 */ public VariableSizeString SubstanceTable;
        [NMS(Index = 82)]
        /* 0x6DA0 */ public List<int> SuitCargoUpgradePrices;
        [NMS(Index = 81)]
        /* 0x6DB0 */ public List<int> SuitTechOnlyUpgradePrices;
        [NMS(Index = 80)]
        /* 0x6DC0 */ public List<int> SuitUpgradePrices;
        [NMS(Index = 46)]
        /* 0x6DD0 */ public VariableSizeString TechBoxTable;
        [NMS(Index = 6)]
        /* 0x6DE0 */ public VariableSizeString TechnologyTable;
        [NMS(Index = 40)]
        /* 0x6DF0 */ public VariableSizeString TradingClassDataTable;
        [NMS(Index = 39)]
        /* 0x6E00 */ public VariableSizeString TradingCostTable;
        [NMS(Index = 42)]
        /* 0x6E10 */ public VariableSizeString UnlockableItemTrees;
        [NMS(Index = 37)]
        /* 0x6E20 */ public VariableSizeString UnlockablePlatformRewardsTable;
        [NMS(Index = 35)]
        /* 0x6E30 */ public VariableSizeString UnlockableSeasonRewardsTable;
        [NMS(Index = 36)]
        /* 0x6E40 */ public VariableSizeString UnlockableTwitchRewardsTable;
        [NMS(Index = 67, Size = 0xCE, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x6E50 */ public GcMinMaxFloat[] FoodStatValues;
        [NMS(Index = 24, Size = 0x98, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x74C0 */ public GcAlienPuzzleTableIndex[] InteractionPuzzlesIndexTypes;
        [NMS(Index = 2, Size = 0x11, EnumType = typeof(GcDiscoveryType.DiscoveryTypeEnum))]
        /* 0x7720 */ public GcDiscoveryWorth[] DiscoveryWorth;
        [NMS(Index = 85, Size = 0x5)]
        /* 0x78FC */ public float[] NormalisedPriceLimits;
        [NMS(Index = 3, Size = 0x4, EnumType = typeof(GcCreatureSizeClasses.CreatureSizeClassEnum))]
        /* 0x7910 */ public float[] CreatureDiscoverySizeMultiplier;
        [NMS(Index = 59, Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x7920 */ public float[] WeightedTextWeights;
        [NMS(Index = 0)]
        /* 0x792C */ public ushort HomeRealityIteration;
        [NMS(Index = 1)]
        /* 0x792E */ public ushort RealityIteration;
        [NMS(Index = 23, Size = 0x98, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x7930 */ public bool[] LoopInteractionPuzzles;
        [NMS(Index = 25, Size = 0x7, EnumType = typeof(GcWeightingCurve.WeightingCurveEnum))]
        /* 0x79C8 */ public TkCurveType[] WeightingCurves;
    }
}
