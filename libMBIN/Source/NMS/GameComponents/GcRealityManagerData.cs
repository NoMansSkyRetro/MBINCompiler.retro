using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x59F83E9C6D6A5B12, NameHash = 0xEDA97B90)]
    public class GcRealityManagerData : NMSTemplate
    {
        [NMS(Index = 63, Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x0000 */ public Colour[] SubstanceCategoryColours;
        [NMS(Index = 61, Size = 0x7, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x0090 */ public Colour[] HazardColours;
        [NMS(Index = 62, Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x0100 */ public Colour[] RarityColours;
        [NMS(Index = 60)]
        /* 0x0130 */ public GcRealityIconTable Icons;
        [NMS(Index = 65, Size = 0xCB, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x15A0 */ public TkTextureResource[] StatCategoryIcons;
        [NMS(Index = 66, Size = 0xCB, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x28A8 */ public TkTextureResource[] StatTechPackageIcons;
        [NMS(Index = 72)]
        /* 0x3BB0 */ public GcTradeSettings TradeSettings;
        [NMS(Index = 55, Size = 0x17, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x4E60 */ public GcNumberedTextList[] MissionNameAdjectives;
        [NMS(Index = 54, Size = 0x17, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x5088 */ public GcNumberedTextList[] MissionNameFormats;
        [NMS(Index = 56, Size = 0x17, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x52B0 */ public GcNumberedTextList[] MissionNameNouns;
        [NMS(Index = 5)]
        /* 0x54D8 */ public GcSubstanceSecondaryBiome SubstanceSecondaryBiome;
        [NMS(Index = 48, Size = 0x7, EnumType = typeof(GcShipWeapons.ShipWeaponEnum))]
        /* 0x56F8 */ public GcShipWeaponData[] ShipWeapons;
        [NMS(Index = 52, Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x58B8 */ public NMSString0x20A[] FactionNames;
        [NMS(Index = 49, Size = 0x14, EnumType = typeof(GcPlayerWeapons.WeaponModeEnum))]
        /* 0x59F8 */ public GcPlayerWeaponData[] PlayerWeapons;
        [NMS(Index = 71, Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x5B38 */ public GcRepShopData[] RepShops;
        [NMS(Index = 70, Size = 0x11, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x5C78 */ public GcTechList[] PlanetTechShops;
        [NMS(Index = 53, Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x5D88 */ public GcNumberedTextList[] FactionClients;
        [NMS(Index = 64, Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x5E78 */ public TkTextureResource[] SubstanceChargeIcons;
        [NMS(Index = 57, Size = 0xB)]
        /* 0x5F50 */ public TkIdArray[] MissionBoardRewardOptions;
        [NMS(Index = 51, Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x6000 */ public NMSString0x10[] FactionStandingIDs;
        [NMS(Index = 50, Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x60A0 */ public TkIdArray[] DefaultVehicleLoadout;
        [NMS(Index = 88, Size = 0x5, EnumType = typeof(GcCatalogueGroups.CatalogueGroupEnum))]
        /* 0x6110 */ public VariableSizeString[] Catalogues;
        // size: 0x5
        public enum StatsEnum {
            Suit,
            Weapon,
            Ship,
            Freighter,
            Vehicle,
        }
        [NMS(Index = 68, Size = 0x5, EnumType = typeof(StatsEnum))]
        /* 0x6160 */ public GcStats[] Stats;
        [NMS(Index = 8, Size = 0x3, EnumType = typeof(GcProductTableType.ProductTableTypeEnum))]
        /* 0x61B0 */ public VariableSizeString[] ProductTables;
        [NMS(Index = 79)]
        /* 0x61E0 */ public GcInventoryLayout ShipCargoOnlyStartingLayout;
        [NMS(Index = 77)]
        /* 0x61F8 */ public GcInventoryLayout ShipStartingLayout;
        [NMS(Index = 78)]
        /* 0x6210 */ public GcInventoryLayout ShipTechOnlyStartingLayout;
        [NMS(Index = 76)]
        /* 0x6228 */ public GcInventoryLayout SuitCargoStartingSlotLayout;
        [NMS(Index = 74)]
        /* 0x6240 */ public GcInventoryLayout SuitStartingSlotLayout;
        [NMS(Index = 75)]
        /* 0x6258 */ public GcInventoryLayout SuitTechOnlyStartingSlotLayout;
        [NMS(Index = 22)]
        /* 0x6270 */ public List<VariableSizeString> AlienPuzzleTables;
        [NMS(Index = 21)]
        /* 0x6280 */ public VariableSizeString AlienWordsTable;
        [NMS(Index = 20)]
        /* 0x6290 */ public VariableSizeString BaitDataTable;
        [NMS(Index = 58)]
        /* 0x62A0 */ public List<GcRewardMissionOverride> BuilderMissionRewardOverrides;
        [NMS(Index = 45)]
        /* 0x62B0 */ public VariableSizeString CombatEffectsTable;
        [NMS(Index = 13)]
        /* 0x62C0 */ public VariableSizeString ConsumableItemTable;
        [NMS(Index = 38)]
        /* 0x62D0 */ public VariableSizeString CostTable;
        [NMS(Index = 26)]
        /* 0x62E0 */ public List<GcDamageMultiplierLookup> DamageMultiplierTable;
        [NMS(Index = 32)]
        /* 0x62F0 */ public VariableSizeString DamageTable;
        [NMS(Index = 16)]
        /* 0x6300 */ public VariableSizeString DialogClearanceTable;
        [NMS(Index = 29)]
        /* 0x6310 */ public VariableSizeString DiscoveryRewardTable;
        [NMS(Index = 86)]
        /* 0x6320 */ public List<GcFiendCrimeSpawnTable> FiendCrimeSpawnTable;
        [NMS(Index = 19)]
        /* 0x6330 */ public VariableSizeString FishDataTable;
        [NMS(Index = 87)]
        /* 0x6340 */ public List<GcIDPair> FreighterBaseItemPairs;
        [NMS(Index = 47)]
        /* 0x6350 */ public List<GcFreighterCargoOption> FreighterCargoOptions;
        [NMS(Index = 27)]
        /* 0x6360 */ public VariableSizeString HistoricalSeasonDataTable;
        [NMS(Index = 31)]
        /* 0x6370 */ public VariableSizeString InventoryTable;
        [NMS(Index = 11)]
        /* 0x6380 */ public VariableSizeString LegacyItemConversionTable;
        [NMS(Index = 12)]
        /* 0x6390 */ public List<TkRawID> LegacyRepairTable;
        [NMS(Index = 41)]
        /* 0x63A0 */ public VariableSizeString MaintenanceGroupsTable;
        [NMS(Index = 18)]
        /* 0x63B0 */ public VariableSizeString MaintenanceOverrideTable;
        [NMS(Index = 84)]
        /* 0x63C0 */ public List<NMSString0x10> NeverOfferedForSale;
        [NMS(Index = 83)]
        /* 0x63D0 */ public List<NMSString0x10> NeverSellableItems;
        [NMS(Index = 73)]
        /* 0x63E0 */ public List<NMSString0x10> PirateStationExtraProds;
        [NMS(Index = 44)]
        /* 0x63F0 */ public VariableSizeString PlayerWeaponPropertiesTable;
        [NMS(Index = 9)]
        /* 0x6400 */ public VariableSizeString ProceduralProductTable;
        [NMS(Index = 10)]
        /* 0x6410 */ public VariableSizeString ProceduralTechnologyTable;
        [NMS(Index = 17)]
        /* 0x6420 */ public VariableSizeString ProductDescriptionOverrideTable;
        [NMS(Index = 33)]
        /* 0x6430 */ public VariableSizeString PurchaseableBuildingBlueprintsTable;
        [NMS(Index = 34)]
        /* 0x6440 */ public VariableSizeString PurchaseableSpecialsTable;
        [NMS(Index = 14)]
        /* 0x6450 */ public VariableSizeString RecipeTable;
        [NMS(Index = 28)]
        /* 0x6460 */ public VariableSizeString RewardTable;
        [NMS(Index = 43)]
        /* 0x6470 */ public VariableSizeString SettlementPerksTable;
        [NMS(Index = 69)]
        /* 0x6480 */ public GcTechList StationTechShops;
        [NMS(Index = 30)]
        /* 0x6490 */ public VariableSizeString StatRewardsTable;
        [NMS(Index = 15)]
        /* 0x64A0 */ public VariableSizeString StoriesTable;
        [NMS(Index = 4)]
        /* 0x64B0 */ public List<GcSubstanceSecondaryLookup> SubstanceSecondaryLookups;
        [NMS(Index = 7)]
        /* 0x64C0 */ public VariableSizeString SubstanceTable;
        [NMS(Index = 82)]
        /* 0x64D0 */ public List<int> SuitCargoUpgradePrices;
        [NMS(Index = 81)]
        /* 0x64E0 */ public List<int> SuitTechOnlyUpgradePrices;
        [NMS(Index = 80)]
        /* 0x64F0 */ public List<int> SuitUpgradePrices;
        [NMS(Index = 46)]
        /* 0x6500 */ public VariableSizeString TechBoxTable;
        [NMS(Index = 6)]
        /* 0x6510 */ public VariableSizeString TechnologyTable;
        [NMS(Index = 40)]
        /* 0x6520 */ public VariableSizeString TradingClassDataTable;
        [NMS(Index = 39)]
        /* 0x6530 */ public VariableSizeString TradingCostTable;
        [NMS(Index = 42)]
        /* 0x6540 */ public VariableSizeString UnlockableItemTrees;
        [NMS(Index = 37)]
        /* 0x6550 */ public VariableSizeString UnlockablePlatformRewardsTable;
        [NMS(Index = 35)]
        /* 0x6560 */ public VariableSizeString UnlockableSeasonRewardsTable;
        [NMS(Index = 36)]
        /* 0x6570 */ public VariableSizeString UnlockableTwitchRewardsTable;
        [NMS(Index = 67, Size = 0xCB, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x6580 */ public GcMinMaxFloat[] FoodStatValues;
        [NMS(Index = 24, Size = 0x90, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x6BD8 */ public GcAlienPuzzleTableIndex[] InteractionPuzzlesIndexTypes;
        [NMS(Index = 2, Size = 0x11, EnumType = typeof(GcDiscoveryType.DiscoveryTypeEnum))]
        /* 0x6E18 */ public GcDiscoveryWorth[] DiscoveryWorth;
        [NMS(Index = 85, Size = 0x5)]
        /* 0x6FF4 */ public float[] NormalisedPriceLimits;
        [NMS(Index = 3, Size = 0x4, EnumType = typeof(GcCreatureSizeClasses.CreatureSizeClassEnum))]
        /* 0x7008 */ public float[] CreatureDiscoverySizeMultiplier;
        [NMS(Index = 59, Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x7018 */ public float[] WeightedTextWeights;
        [NMS(Index = 0)]
        /* 0x7024 */ public ushort HomeRealityIteration;
        [NMS(Index = 1)]
        /* 0x7026 */ public ushort RealityIteration;
        [NMS(Index = 23, Size = 0x90, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x7028 */ public bool[] LoopInteractionPuzzles;
        [NMS(Index = 25, Size = 0x7, EnumType = typeof(GcWeightingCurve.WeightingCurveEnum))]
        /* 0x70B8 */ public TkCurveType[] WeightingCurves;
    }
}
