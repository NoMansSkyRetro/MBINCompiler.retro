using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCC5294707151FDBE, NameHash = 0xA547E834)]
    public class GcRealityIconTable : NMSTemplate
    {
        [NMS(Index = 15, Size = 0x73, EnumType = typeof(GcRealityGameIcons.GameIconsEnum))]
        /* 0x0000 */ public TkTextureResource[] GameIcons;
        [NMS(Index = 5, Size = 0x11, EnumType = typeof(GcDiscoveryType.DiscoveryTypeEnum))]
        /* 0x0AC8 */ public TkTextureResource[] BinocularDiscoveryIcons;
        [NMS(Index = 3, Size = 0xB, EnumType = typeof(GcProductCategory.ProductCategoryEnum))]
        /* 0x0C60 */ public TkTextureResource[] ProductCategoryIcons;
        [NMS(Index = 4, Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x0D68 */ public TkTextureResource[] MissionFactionIcons;
        [NMS(Index = 8, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x0E58 */ public TkTextureResource[] DiscoveryPageRaceIcons;
        [NMS(Index = 2, Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x0F30 */ public TkTextureResource[] SubstanceCategoryIcons;
        [NMS(Index = 17, Size = 0x7, EnumType = typeof(GcDifficultyPresetType.DifficultyPresetTypeEnum))]
        /* 0x1008 */ public TkTextureResource[] DifficultyPresetIcons;
        [NMS(Index = 6, Size = 0x7, EnumType = typeof(GcTradingClass.TradingClassEnum))]
        /* 0x10B0 */ public TkTextureResource[] DiscoveryPageTradingIcons;
        [NMS(Index = 0, Size = 0x7, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x1158 */ public TkTextureResource[] HazardIcons;
        [NMS(Index = 1, Size = 0x7, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x1200 */ public TkTextureResource[] HazardIconsHUD;
        [NMS(Index = 19, Size = 0x6, EnumType = typeof(GcOptionsUIHeaderIcons.OptionsUIHeaderIconTypeEnum))]
        /* 0x12A8 */ public TkTextureResource[] OptionsUIHeaderIcons;
        [NMS(Index = 20, Size = 0x5, EnumType = typeof(GcInventoryFilterOptions.InventoryFilterEnum))]
        /* 0x1338 */ public TkTextureResource[] InventoryFilterIcons;
        [NMS(Index = 18, Size = 0x4, EnumType = typeof(GcDifficultyOptionGroups.DifficultyOptionGroupEnum))]
        /* 0x13B0 */ public TkTextureResource[] DifficultyUIOptionIcons;
        [NMS(Index = 7, Size = 0x4, EnumType = typeof(GcPlayerConflictData.ConflictLevelEnum))]
        /* 0x1410 */ public TkTextureResource[] DiscoveryPageConflictIcons;
        [NMS(Index = 16, KeyField = "ID")]
        /* 0x1470 */ public HashMap<GcRealityIcon> MissionDetailIcons;
        [NMS(Index = 10)]
        /* 0x14A0 */ public TkTextureResource DiscoveryPageConflictUnknown;
        [NMS(Index = 11)]
        /* 0x14B8 */ public TkTextureResource DiscoveryPageRaceUnknown;
        [NMS(Index = 9)]
        /* 0x14D0 */ public TkTextureResource DiscoveryPageTradingUnknown;
        [NMS(Index = 13)]
        /* 0x14E8 */ public List<GcPlanetResourceIconLookup> PlanetResourceIconLookups;
        [NMS(Index = 14)]
        /* 0x14F8 */ public List<TkTextureResource> RepairTechIcons;
        [NMS(Index = 12)]
        /* 0x1508 */ public List<GcPlanetResourceIconLookup> TerrainIconLookups;
    }
}
