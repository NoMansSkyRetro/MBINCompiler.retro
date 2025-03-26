using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE80A6FC80910384A, NameHash = 0xEDA97B90)]
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
        /* 0x16F0 */ public GcRealityIconTable Icons;
        [NMS(Index = 65, Size = 0xCB, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x2B90 */ public TkTextureResource[] StatCategoryIcons;
        [NMS(Index = 66, Size = 0xCB, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x3E98 */ public TkTextureResource[] StatTechPackageIcons;
        [NMS(Index = 55, Size = 0x17, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x51A0 */ public GcNumberedTextList[] MissionNameAdjectives;
        [NMS(Index = 54, Size = 0x17, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x53C8 */ public GcNumberedTextList[] MissionNameFormats;
        [NMS(Index = 56, Size = 0x17, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x55F0 */ public GcNumberedTextList[] MissionNameNouns;
        [NMS(Index = 5)]
        /* 0x5818 */ public GcSubstanceSecondaryBiome SubstanceSecondaryBiome;
        [NMS(Index = 48, Size = 0x7, EnumType = typeof(GcShipWeapons.ShipWeaponEnum))]
        /* 0x5A38 */ public GcShipWeaponData[] ShipWeapons;
        [NMS(Index = 52, Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x5BF8 */ public NMSString0x20A[] FactionNames;
        [NMS(Index = 49, Size = 0x14, EnumType = typeof(GcPlayerWeapons.WeaponModeEnum))]
        /* 0x5D38 */ public GcPlayerWeaponData[] PlayerWeapons;
        [NMS(Index = 71, Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x5E78 */ public GcRepShopData[] RepShops;
        [NMS(Index = 70, Size = 0x11, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x5FB8 */ public GcTechList[] PlanetTechShops;
        [NMS(Index = 53, Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x60C8 */ public GcNumberedTextList[] FactionClients;
        [NMS(Index = 64, Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x61B8 */ public TkTextureResource[] SubstanceChargeIcons;
        [NMS(Index = 57, Size = 0xB)]
        /* 0x6290 */ public TkIdArray[] MissionBoardRewardOptions;
        [NMS(Index = 51, Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x6340 */ public NMSString0x10[] FactionStandingIDs;
        [NMS(Index = 50, Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x63E0 */ public TkIdArray[] DefaultVehicleLoadout;
        [NMS(Index = 88, Size = 0x5, EnumType = typeof(GcCatalogueGroups.CatalogueGroupEnum))]
        /* 0x6450 */ public VariableSizeString[] Catalogues;
        // size: 0x5
        public enum StatsEnum {
            Suit,
            Weapon,
            Ship,
            Freighter,
            Vehicle,
        }
        [NMS(Index = 68, Size = 0x5, EnumType = typeof(StatsEnum))]
        /* 0x64A0 */ public GcStats[] Stats;
        [NMS(Index = 8, Size = 0x3, EnumType = typeof(GcProductTableType.ProductTableTypeEnum))]
        /* 0x64F0 */ public VariableSizeString[] ProductTables;
        [NMS(Index = 79)]
        /* 0x6520 */ public GcInventoryLayout ShipCargoOnlyStartingLayout;
        [NMS(Index = 77)]
        /* 0x6538 */ public GcInventoryLayout ShipStartingLayout;
        [NMS(Index = 78)]
        /* 0x6550 */ public GcInventoryLayout ShipTechOnlyStartingLayout;
        [NMS(Index = 76)]
        /* 0x6568 */ public GcInventoryLayout SuitCargoStartingSlotLayout;
        [NMS(Index = 74)]
        /* 0x6580 */ public GcInventoryLayout SuitStartingSlotLayout;
        [NMS(Index = 75)]
        /* 0x6598 */ public GcInventoryLayout SuitTechOnlyStartingSlotLayout;
        [NMS(Index = 22)]
        /* 0x65B0 */ public List<VariableSizeString> AlienPuzzleTables;
        [NMS(Index = 21)]
        /* 0x65C0 */ public VariableSizeString AlienWordsTable;
        [NMS(Index = 20)]
        /* 0x65D0 */ public VariableSizeString BaitDataTable;
        [NMS(Index = 58)]
        /* 0x65E0 */ public List<GcRewardMissionOverride> BuilderMissionRewardOverrides;
        [NMS(Index = 45)]
        /* 0x65F0 */ public VariableSizeString CombatEffectsTable;
        [NMS(Index = 13)]
        /* 0x6600 */ public VariableSizeString ConsumableItemTable;
        [NMS(Index = 38)]
        /* 0x6610 */ public VariableSizeString CostTable;
        [NMS(Index = 26)]
        /* 0x6620 */ public List<GcDamageMultiplierLookup> DamageMultiplierTable;
        [NMS(Index = 32)]
        /* 0x6630 */ public VariableSizeString DamageTable;
        [NMS(Index = 16)]
        /* 0x6640 */ public VariableSizeString DialogClearanceTable;
        [NMS(Index = 29)]
        /* 0x6650 */ public VariableSizeString DiscoveryRewardTable;
        [NMS(Index = 86)]
        /* 0x6660 */ public List<GcFiendCrimeSpawnTable> FiendCrimeSpawnTable;
        [NMS(Index = 19)]
        /* 0x6670 */ public VariableSizeString FishDataTable;
        [NMS(Index = 87)]
        /* 0x6680 */ public List<GcIDPair> FreighterBaseItemPairs;
        [NMS(Index = 47)]
        /* 0x6690 */ public List<GcFreighterCargoOption> FreighterCargoOptions;
        [NMS(Index = 27)]
        /* 0x66A0 */ public VariableSizeString HistoricalSeasonDataTable;
        [NMS(Index = 31)]
        /* 0x66B0 */ public VariableSizeString InventoryTable;
        [NMS(Index = 11)]
        /* 0x66C0 */ public VariableSizeString LegacyItemConversionTable;
        [NMS(Index = 12)]
        /* 0x66D0 */ public List<TkRawID> LegacyRepairTable;
        [NMS(Index = 41)]
        /* 0x66E0 */ public VariableSizeString MaintenanceGroupsTable;
        [NMS(Index = 18)]
        /* 0x66F0 */ public VariableSizeString MaintenanceOverrideTable;
        [NMS(Index = 84)]
        /* 0x6700 */ public List<NMSString0x10> NeverOfferedForSale;
        [NMS(Index = 83)]
        /* 0x6710 */ public List<NMSString0x10> NeverSellableItems;
        [NMS(Index = 73)]
        /* 0x6720 */ public List<NMSString0x10> PirateStationExtraProds;
        [NMS(Index = 44)]
        /* 0x6730 */ public VariableSizeString PlayerWeaponPropertiesTable;
        [NMS(Index = 9)]
        /* 0x6740 */ public VariableSizeString ProceduralProductTable;
        [NMS(Index = 10)]
        /* 0x6750 */ public VariableSizeString ProceduralTechnologyTable;
        [NMS(Index = 17)]
        /* 0x6760 */ public VariableSizeString ProductDescriptionOverrideTable;
        [NMS(Index = 33)]
        /* 0x6770 */ public VariableSizeString PurchaseableBuildingBlueprintsTable;
        [NMS(Index = 34)]
        /* 0x6780 */ public VariableSizeString PurchaseableSpecialsTable;
        [NMS(Index = 14)]
        /* 0x6790 */ public VariableSizeString RecipeTable;
        [NMS(Index = 28)]
        /* 0x67A0 */ public VariableSizeString RewardTable;
        [NMS(Index = 43)]
        /* 0x67B0 */ public VariableSizeString SettlementPerksTable;
        [NMS(Index = 69)]
        /* 0x67C0 */ public GcTechList StationTechShops;
        [NMS(Index = 30)]
        /* 0x67D0 */ public VariableSizeString StatRewardsTable;
        [NMS(Index = 15)]
        /* 0x67E0 */ public VariableSizeString StoriesTable;
        [NMS(Index = 4)]
        /* 0x67F0 */ public List<GcSubstanceSecondaryLookup> SubstanceSecondaryLookups;
        [NMS(Index = 7)]
        /* 0x6800 */ public VariableSizeString SubstanceTable;
        [NMS(Index = 82)]
        /* 0x6810 */ public List<int> SuitCargoUpgradePrices;
        [NMS(Index = 81)]
        /* 0x6820 */ public List<int> SuitTechOnlyUpgradePrices;
        [NMS(Index = 80)]
        /* 0x6830 */ public List<int> SuitUpgradePrices;
        [NMS(Index = 46)]
        /* 0x6840 */ public VariableSizeString TechBoxTable;
        [NMS(Index = 6)]
        /* 0x6850 */ public VariableSizeString TechnologyTable;
        [NMS(Index = 40)]
        /* 0x6860 */ public VariableSizeString TradingClassDataTable;
        [NMS(Index = 39)]
        /* 0x6870 */ public VariableSizeString TradingCostTable;
        [NMS(Index = 42)]
        /* 0x6880 */ public VariableSizeString UnlockableItemTrees;
        [NMS(Index = 37)]
        /* 0x6890 */ public VariableSizeString UnlockablePlatformRewardsTable;
        [NMS(Index = 35)]
        /* 0x68A0 */ public VariableSizeString UnlockableSeasonRewardsTable;
        [NMS(Index = 36)]
        /* 0x68B0 */ public VariableSizeString UnlockableTwitchRewardsTable;
        [NMS(Index = 67, Size = 0xCB, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x68C0 */ public GcMinMaxFloat[] FoodStatValues;
        [NMS(Index = 24, Size = 0x91, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x6F18 */ public GcAlienPuzzleTableIndex[] InteractionPuzzlesIndexTypes;
        [NMS(Index = 2, Size = 0x11, EnumType = typeof(GcDiscoveryType.DiscoveryTypeEnum))]
        /* 0x715C */ public GcDiscoveryWorth[] DiscoveryWorth;
        [NMS(Index = 85, Size = 0x5)]
        /* 0x7338 */ public float[] NormalisedPriceLimits;
        [NMS(Index = 3, Size = 0x4, EnumType = typeof(GcCreatureSizeClasses.CreatureSizeClassEnum))]
        /* 0x734C */ public float[] CreatureDiscoverySizeMultiplier;
        [NMS(Index = 59, Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x735C */ public float[] WeightedTextWeights;
        [NMS(Index = 0)]
        /* 0x7368 */ public ushort HomeRealityIteration;
        [NMS(Index = 1)]
        /* 0x736A */ public ushort RealityIteration;
        [NMS(Index = 23, Size = 0x91, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x736C */ public bool[] LoopInteractionPuzzles;
        [NMS(Index = 25, Size = 0x7, EnumType = typeof(GcWeightingCurve.WeightingCurveEnum))]
        /* 0x73FD */ public TkCurveType[] WeightingCurves;
    }
}
