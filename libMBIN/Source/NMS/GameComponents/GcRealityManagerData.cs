using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9378272B704B2DC8, NameHash = 0xEDA97B90)]
    public class GcRealityManagerData : NMSTemplate
    {
        [NMS(Index = 67, Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x0000 */ public Colour[] SubstanceCategoryColours;
        [NMS(Index = 65, Size = 0x7, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x0090 */ public Colour[] HazardColours;
        [NMS(Index = 66, Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x0100 */ public Colour[] RarityColours;
        [NMS(Index = 64)]
        /* 0x0130 */ public GcRealityIconTable Icons;
        [NMS(Index = 76)]
        /* 0x1CD8 */ public GcTradeSettings TradeSettings;
        [NMS(Index = 69, Size = 0xD0, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x3550 */ public TkTextureResource[] StatCategoryIcons;
        [NMS(Index = 70, Size = 0xD0, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x48D0 */ public TkTextureResource[] StatTechPackageIcons;
        [NMS(Index = 59, Size = 0x21, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x5C50 */ public GcNumberedTextList[] MissionNameAdjectives;
        [NMS(Index = 58, Size = 0x21, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x5F68 */ public GcNumberedTextList[] MissionNameFormats;
        [NMS(Index = 60, Size = 0x21, EnumType = typeof(GcMissionType.MissionTypeEnum))]
        /* 0x6280 */ public GcNumberedTextList[] MissionNameNouns;
        [NMS(Index = 5)]
        /* 0x6598 */ public GcSubstanceSecondaryBiome SubstanceSecondaryBiome;
        [NMS(Index = 52, Size = 0x7, EnumType = typeof(GcShipWeapons.ShipWeaponEnum))]
        /* 0x67B8 */ public GcShipWeaponData[] ShipWeapons;
        [NMS(Index = 53, Size = 0x15, EnumType = typeof(GcPlayerWeapons.WeaponModeEnum))]
        /* 0x6978 */ public GcPlayerWeaponData[] PlayerWeapons;
        [NMS(Index = 56, Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x6AC8 */ public NMSString0x20A[] FactionNames;
        [NMS(Index = 75, Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x6C08 */ public GcRepShopData[] RepShops;
        [NMS(Index = 74, Size = 0x11, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x6D48 */ public GcTechList[] PlanetTechShops;
        [NMS(Index = 57, Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x6E58 */ public GcNumberedTextList[] FactionClients;
        [NMS(Index = 68, Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x6F48 */ public TkTextureResource[] SubstanceChargeIcons;
        [NMS(Index = 61, Size = 0xB)]
        /* 0x7020 */ public TkIdArray[] MissionBoardRewardOptions;
        [NMS(Index = 55, Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x70D0 */ public NMSString0x10[] FactionStandingIDs;
        [NMS(Index = 54, Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x7170 */ public TkIdArray[] DefaultVehicleLoadout;
        [NMS(Index = 92, Size = 0x5, EnumType = typeof(GcCatalogueGroups.CatalogueGroupEnum))]
        /* 0x71E0 */ public GcFilename[] Catalogues;
        // size: 0x5
        public enum StatsEnum {
            Suit,
            Weapon,
            Ship,
            Freighter,
            Vehicle,
        }
        [NMS(Index = 72, Size = 0x5, EnumType = typeof(StatsEnum))]
        /* 0x7230 */ public GcStats[] Stats;
        [NMS(Index = 8, Size = 0x3, EnumType = typeof(GcProductTableType.ProductTableTypeEnum))]
        /* 0x7280 */ public GcFilename[] ProductTables;
        [NMS(Index = 83)]
        /* 0x72B0 */ public GcInventoryLayout ShipCargoOnlyStartingLayout;
        [NMS(Index = 81)]
        /* 0x72C8 */ public GcInventoryLayout ShipStartingLayout;
        [NMS(Index = 82)]
        /* 0x72E0 */ public GcInventoryLayout ShipTechOnlyStartingLayout;
        [NMS(Index = 80)]
        /* 0x72F8 */ public GcInventoryLayout SuitCargoStartingSlotLayout;
        [NMS(Index = 78)]
        /* 0x7310 */ public GcInventoryLayout SuitStartingSlotLayout;
        [NMS(Index = 79)]
        /* 0x7328 */ public GcInventoryLayout SuitTechOnlyStartingSlotLayout;
        [NMS(Index = 26)]
        /* 0x7340 */ public List<GcFilename> AlienPuzzleTables;
        [NMS(Index = 25)]
        /* 0x7350 */ public GcFilename AlienWordsTable;
        [NMS(Index = 20)]
        /* 0x7360 */ public GcFilename BaitDataTable;
        [NMS(Index = 62)]
        /* 0x7370 */ public List<GcRewardMissionOverride> BuilderMissionRewardOverrides;
        [NMS(Index = 49)]
        /* 0x7380 */ public GcFilename CombatEffectsTable;
        [NMS(Index = 13)]
        /* 0x7390 */ public GcFilename ConsumableItemTable;
        [NMS(Index = 42)]
        /* 0x73A0 */ public GcFilename CostTable;
        [NMS(Index = 30)]
        /* 0x73B0 */ public List<GcDamageMultiplierLookup> DamageMultiplierTable;
        [NMS(Index = 36)]
        /* 0x73C0 */ public GcFilename DamageTable;
        [NMS(Index = 16)]
        /* 0x73D0 */ public GcFilename DialogClearanceTable;
        [NMS(Index = 33)]
        /* 0x73E0 */ public GcFilename DiscoveryRewardTable;
        [NMS(Index = 90)]
        /* 0x73F0 */ public List<GcFiendCrimeSpawnTable> FiendCrimeSpawnTable;
        [NMS(Index = 19)]
        /* 0x7400 */ public GcFilename FishDataTable;
        [NMS(Index = 91)]
        /* 0x7410 */ public List<GcIDPair> FreighterBaseItemPairs;
        [NMS(Index = 51)]
        /* 0x7420 */ public List<GcFreighterCargoOption> FreighterCargoOptions;
        [NMS(Index = 21)]
        /* 0x7430 */ public GcFilename GameTableDiceDataTable;
        [NMS(Index = 31)]
        /* 0x7440 */ public GcFilename HistoricalSeasonDataTable;
        [NMS(Index = 35)]
        /* 0x7450 */ public GcFilename InventoryTable;
        [NMS(Index = 11)]
        /* 0x7460 */ public GcFilename LegacyItemConversionTable;
        [NMS(Index = 12)]
        /* 0x7470 */ public List<TkRawID> LegacyRepairTable;
        [NMS(Index = 45)]
        /* 0x7480 */ public GcFilename MaintenanceGroupsTable;
        [NMS(Index = 18)]
        /* 0x7490 */ public GcFilename MaintenanceOverrideTable;
        [NMS(Index = 88)]
        /* 0x74A0 */ public List<NMSString0x10> NeverOfferedForSale;
        [NMS(Index = 87)]
        /* 0x74B0 */ public List<NMSString0x10> NeverSellableItems;
        [NMS(Index = 23)]
        /* 0x74C0 */ public GcFilename PetBattlerMoveSetsTable;
        [NMS(Index = 22)]
        /* 0x74D0 */ public GcFilename PetBattlerMovesTable;
        [NMS(Index = 24)]
        /* 0x74E0 */ public GcFilename PetShopItemTable;
        [NMS(Index = 77)]
        /* 0x74F0 */ public List<NMSString0x10> PirateStationExtraProds;
        [NMS(Index = 48)]
        /* 0x7500 */ public GcFilename PlayerWeaponPropertiesTable;
        [NMS(Index = 9)]
        /* 0x7510 */ public GcFilename ProceduralProductTable;
        [NMS(Index = 10)]
        /* 0x7520 */ public GcFilename ProceduralTechnologyTable;
        [NMS(Index = 17)]
        /* 0x7530 */ public GcFilename ProductDescriptionOverrideTable;
        [NMS(Index = 37)]
        /* 0x7540 */ public GcFilename PurchaseableBuildingBlueprintsTable;
        [NMS(Index = 38)]
        /* 0x7550 */ public GcFilename PurchaseableSpecialsTable;
        [NMS(Index = 14)]
        /* 0x7560 */ public GcFilename RecipeTable;
        [NMS(Index = 32)]
        /* 0x7570 */ public GcFilename RewardTable;
        [NMS(Index = 47)]
        /* 0x7580 */ public GcFilename SettlementPerksTable;
        [NMS(Index = 73)]
        /* 0x7590 */ public GcTechList StationTechShops;
        [NMS(Index = 34)]
        /* 0x75A0 */ public GcFilename StatRewardsTable;
        [NMS(Index = 15)]
        /* 0x75B0 */ public GcFilename StoriesTable;
        [NMS(Index = 4)]
        /* 0x75C0 */ public List<GcSubstanceSecondaryLookup> SubstanceSecondaryLookups;
        [NMS(Index = 7)]
        /* 0x75D0 */ public GcFilename SubstanceTable;
        [NMS(Index = 86)]
        /* 0x75E0 */ public List<int> SuitCargoUpgradePrices;
        [NMS(Index = 85)]
        /* 0x75F0 */ public List<int> SuitTechOnlyUpgradePrices;
        [NMS(Index = 84)]
        /* 0x7600 */ public List<int> SuitUpgradePrices;
        [NMS(Index = 50)]
        /* 0x7610 */ public GcFilename TechBoxTable;
        [NMS(Index = 6)]
        /* 0x7620 */ public GcFilename TechnologyTable;
        [NMS(Index = 44)]
        /* 0x7630 */ public GcFilename TradingClassDataTable;
        [NMS(Index = 43)]
        /* 0x7640 */ public GcFilename TradingCostTable;
        [NMS(Index = 46)]
        /* 0x7650 */ public GcFilename UnlockableItemTrees;
        [NMS(Index = 41)]
        /* 0x7660 */ public GcFilename UnlockablePlatformRewardsTable;
        [NMS(Index = 39)]
        /* 0x7670 */ public GcFilename UnlockableSeasonRewardsTable;
        [NMS(Index = 40)]
        /* 0x7680 */ public GcFilename UnlockableTwitchRewardsTable;
        [NMS(Index = 71, Size = 0xD0, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x7690 */ public GcMinMaxFloat[] FoodStatValues;
        [NMS(Index = 28, Size = 0x9C, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x7D10 */ public GcAlienPuzzleTableIndex[] InteractionPuzzlesIndexTypes;
        [NMS(Index = 2, Size = 0x11, EnumType = typeof(GcDiscoveryType.DiscoveryTypeEnum))]
        /* 0x7F80 */ public GcDiscoveryWorth[] DiscoveryWorth;
        [NMS(Index = 89, Size = 0x5)]
        /* 0x815C */ public float[] NormalisedPriceLimits;
        [NMS(Index = 3, Size = 0x4, EnumType = typeof(GcCreatureSizeClasses.CreatureSizeClassEnum))]
        /* 0x8170 */ public float[] CreatureDiscoverySizeMultiplier;
        [NMS(Index = 63, Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x8180 */ public float[] WeightedTextWeights;
        [NMS(Index = 0)]
        /* 0x818C */ public ushort HomeRealityIteration;
        [NMS(Index = 1)]
        /* 0x818E */ public ushort RealityIteration;
        [NMS(Index = 27, Size = 0x9C, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x8190 */ public bool[] LoopInteractionPuzzles;
        [NMS(Index = 29, Size = 0x7, EnumType = typeof(GcWeightingCurve.WeightingCurveEnum))]
        /* 0x822C */ public TkCurveType[] WeightingCurves;
    }
}
