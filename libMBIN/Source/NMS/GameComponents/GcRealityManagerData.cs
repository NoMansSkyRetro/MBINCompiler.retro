using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD5B8FDAC6A9DBB9, NameHash = 0xEDA97B90)]
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
        [NMS(Index = 65, Size = 0xD0, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x2DD8 */ public TkTextureResource[] StatCategoryIcons;
        [NMS(Index = 66, Size = 0xD0, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x4158 */ public TkTextureResource[] StatTechPackageIcons;
        [NMS(Index = 55, Size = 0x21, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x54D8 */ public GcNumberedTextList[] MissionNameAdjectives;
        [NMS(Index = 54, Size = 0x21, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x57F0 */ public GcNumberedTextList[] MissionNameFormats;
        [NMS(Index = 56, Size = 0x21, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x5B08 */ public GcNumberedTextList[] MissionNameNouns;
        [NMS(Index = 5)]
        /* 0x5E20 */ public GcSubstanceSecondaryBiome SubstanceSecondaryBiome;
        [NMS(Index = 48, Size = 0x7, EnumType = typeof(GcShipWeapons.ShipWeaponEnum))]
        /* 0x6040 */ public GcShipWeaponData[] ShipWeapons;
        [NMS(Index = 49, Size = 0x15, EnumType = typeof(GcPlayerWeapons.WeaponModeEnum))]
        /* 0x6200 */ public GcPlayerWeaponData[] PlayerWeapons;
        [NMS(Index = 52, Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x6350 */ public NMSString0x20A[] FactionNames;
        [NMS(Index = 71, Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x6490 */ public GcRepShopData[] RepShops;
        [NMS(Index = 70, Size = 0x11, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x65D0 */ public GcTechList[] PlanetTechShops;
        [NMS(Index = 53, Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x66E0 */ public GcNumberedTextList[] FactionClients;
        [NMS(Index = 64, Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x67D0 */ public TkTextureResource[] SubstanceChargeIcons;
        [NMS(Index = 57, Size = 0xB)]
        /* 0x68A8 */ public TkIdArray[] MissionBoardRewardOptions;
        [NMS(Index = 51, Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x6958 */ public NMSString0x10[] FactionStandingIDs;
        [NMS(Index = 50, Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x69F8 */ public TkIdArray[] DefaultVehicleLoadout;
        [NMS(Index = 88, Size = 0x5, EnumType = typeof(GcCatalogueGroups.CatalogueGroupEnum))]
        /* 0x6A68 */ public GcFilename[] Catalogues;
        // size: 0x5
        public enum StatsEnum {
            Suit,
            Weapon,
            Ship,
            Freighter,
            Vehicle,
        }
        [NMS(Index = 68, Size = 0x5, EnumType = typeof(StatsEnum))]
        /* 0x6AB8 */ public GcStats[] Stats;
        [NMS(Index = 8, Size = 0x3, EnumType = typeof(GcProductTableType.ProductTableTypeEnum))]
        /* 0x6B08 */ public GcFilename[] ProductTables;
        [NMS(Index = 79)]
        /* 0x6B38 */ public GcInventoryLayout ShipCargoOnlyStartingLayout;
        [NMS(Index = 77)]
        /* 0x6B50 */ public GcInventoryLayout ShipStartingLayout;
        [NMS(Index = 78)]
        /* 0x6B68 */ public GcInventoryLayout ShipTechOnlyStartingLayout;
        [NMS(Index = 76)]
        /* 0x6B80 */ public GcInventoryLayout SuitCargoStartingSlotLayout;
        [NMS(Index = 74)]
        /* 0x6B98 */ public GcInventoryLayout SuitStartingSlotLayout;
        [NMS(Index = 75)]
        /* 0x6BB0 */ public GcInventoryLayout SuitTechOnlyStartingSlotLayout;
        [NMS(Index = 22)]
        /* 0x6BC8 */ public List<GcFilename> AlienPuzzleTables;
        [NMS(Index = 21)]
        /* 0x6BD8 */ public GcFilename AlienWordsTable;
        [NMS(Index = 20)]
        /* 0x6BE8 */ public GcFilename BaitDataTable;
        [NMS(Index = 58)]
        /* 0x6BF8 */ public List<GcRewardMissionOverride> BuilderMissionRewardOverrides;
        [NMS(Index = 45)]
        /* 0x6C08 */ public GcFilename CombatEffectsTable;
        [NMS(Index = 13)]
        /* 0x6C18 */ public GcFilename ConsumableItemTable;
        [NMS(Index = 38)]
        /* 0x6C28 */ public GcFilename CostTable;
        [NMS(Index = 26)]
        /* 0x6C38 */ public List<GcDamageMultiplierLookup> DamageMultiplierTable;
        [NMS(Index = 32)]
        /* 0x6C48 */ public GcFilename DamageTable;
        [NMS(Index = 16)]
        /* 0x6C58 */ public GcFilename DialogClearanceTable;
        [NMS(Index = 29)]
        /* 0x6C68 */ public GcFilename DiscoveryRewardTable;
        [NMS(Index = 86)]
        /* 0x6C78 */ public List<GcFiendCrimeSpawnTable> FiendCrimeSpawnTable;
        [NMS(Index = 19)]
        /* 0x6C88 */ public GcFilename FishDataTable;
        [NMS(Index = 87)]
        /* 0x6C98 */ public List<GcIDPair> FreighterBaseItemPairs;
        [NMS(Index = 47)]
        /* 0x6CA8 */ public List<GcFreighterCargoOption> FreighterCargoOptions;
        [NMS(Index = 27)]
        /* 0x6CB8 */ public GcFilename HistoricalSeasonDataTable;
        [NMS(Index = 31)]
        /* 0x6CC8 */ public GcFilename InventoryTable;
        [NMS(Index = 11)]
        /* 0x6CD8 */ public GcFilename LegacyItemConversionTable;
        [NMS(Index = 12)]
        /* 0x6CE8 */ public List<TkRawID> LegacyRepairTable;
        [NMS(Index = 41)]
        /* 0x6CF8 */ public GcFilename MaintenanceGroupsTable;
        [NMS(Index = 18)]
        /* 0x6D08 */ public GcFilename MaintenanceOverrideTable;
        [NMS(Index = 84)]
        /* 0x6D18 */ public List<NMSString0x10> NeverOfferedForSale;
        [NMS(Index = 83)]
        /* 0x6D28 */ public List<NMSString0x10> NeverSellableItems;
        [NMS(Index = 73)]
        /* 0x6D38 */ public List<NMSString0x10> PirateStationExtraProds;
        [NMS(Index = 44)]
        /* 0x6D48 */ public GcFilename PlayerWeaponPropertiesTable;
        [NMS(Index = 9)]
        /* 0x6D58 */ public GcFilename ProceduralProductTable;
        [NMS(Index = 10)]
        /* 0x6D68 */ public GcFilename ProceduralTechnologyTable;
        [NMS(Index = 17)]
        /* 0x6D78 */ public GcFilename ProductDescriptionOverrideTable;
        [NMS(Index = 33)]
        /* 0x6D88 */ public GcFilename PurchaseableBuildingBlueprintsTable;
        [NMS(Index = 34)]
        /* 0x6D98 */ public GcFilename PurchaseableSpecialsTable;
        [NMS(Index = 14)]
        /* 0x6DA8 */ public GcFilename RecipeTable;
        [NMS(Index = 28)]
        /* 0x6DB8 */ public GcFilename RewardTable;
        [NMS(Index = 43)]
        /* 0x6DC8 */ public GcFilename SettlementPerksTable;
        [NMS(Index = 69)]
        /* 0x6DD8 */ public GcTechList StationTechShops;
        [NMS(Index = 30)]
        /* 0x6DE8 */ public GcFilename StatRewardsTable;
        [NMS(Index = 15)]
        /* 0x6DF8 */ public GcFilename StoriesTable;
        [NMS(Index = 4)]
        /* 0x6E08 */ public List<GcSubstanceSecondaryLookup> SubstanceSecondaryLookups;
        [NMS(Index = 7)]
        /* 0x6E18 */ public GcFilename SubstanceTable;
        [NMS(Index = 82)]
        /* 0x6E28 */ public List<int> SuitCargoUpgradePrices;
        [NMS(Index = 81)]
        /* 0x6E38 */ public List<int> SuitTechOnlyUpgradePrices;
        [NMS(Index = 80)]
        /* 0x6E48 */ public List<int> SuitUpgradePrices;
        [NMS(Index = 46)]
        /* 0x6E58 */ public GcFilename TechBoxTable;
        [NMS(Index = 6)]
        /* 0x6E68 */ public GcFilename TechnologyTable;
        [NMS(Index = 40)]
        /* 0x6E78 */ public GcFilename TradingClassDataTable;
        [NMS(Index = 39)]
        /* 0x6E88 */ public GcFilename TradingCostTable;
        [NMS(Index = 42)]
        /* 0x6E98 */ public GcFilename UnlockableItemTrees;
        [NMS(Index = 37)]
        /* 0x6EA8 */ public GcFilename UnlockablePlatformRewardsTable;
        [NMS(Index = 35)]
        /* 0x6EB8 */ public GcFilename UnlockableSeasonRewardsTable;
        [NMS(Index = 36)]
        /* 0x6EC8 */ public GcFilename UnlockableTwitchRewardsTable;
        [NMS(Index = 67, Size = 0xD0, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x6ED8 */ public GcMinMaxFloat[] FoodStatValues;
        [NMS(Index = 24, Size = 0x9B, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x7558 */ public GcAlienPuzzleTableIndex[] InteractionPuzzlesIndexTypes;
        [NMS(Index = 2, Size = 0x11, EnumType = typeof(GcDiscoveryType.DiscoveryTypeEnum))]
        /* 0x77C4 */ public GcDiscoveryWorth[] DiscoveryWorth;
        [NMS(Index = 85, Size = 0x5)]
        /* 0x79A0 */ public float[] NormalisedPriceLimits;
        [NMS(Index = 3, Size = 0x4, EnumType = typeof(GcCreatureSizeClasses.CreatureSizeClassEnum))]
        /* 0x79B4 */ public float[] CreatureDiscoverySizeMultiplier;
        [NMS(Index = 59, Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x79C4 */ public float[] WeightedTextWeights;
        [NMS(Index = 0)]
        /* 0x79D0 */ public ushort HomeRealityIteration;
        [NMS(Index = 1)]
        /* 0x79D2 */ public ushort RealityIteration;
        [NMS(Index = 23, Size = 0x9B, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x79D4 */ public bool[] LoopInteractionPuzzles;
        [NMS(Index = 25, Size = 0x7, EnumType = typeof(GcWeightingCurve.WeightingCurveEnum))]
        /* 0x7A6F */ public TkCurveType[] WeightingCurves;
    }
}
