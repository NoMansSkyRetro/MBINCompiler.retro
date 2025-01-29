using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE1D1925AF4E395A5, NameHash = 0x107C2CC0)]
    public class GcInventoryTable : NMSTemplate
    {
        [NMS(Index = 7, Size = 0xA, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x0000 */ public GcInventoryGenerationBaseStatData[] ShipBaseStatsData;
        [NMS(Index = 8, Size = 0xA, EnumType = typeof(GcWeaponClasses.WeaponStatClassEnum))]
        /* 0x0280 */ public GcInventoryGenerationBaseStatData[] WeaponBaseStatsData;
        [NMS(Index = 6)]
        /* 0x0500 */ public GcInventoryGenerationBaseStatData VehicleBaseStatsData;
        [NMS(Index = 9)]
        /* 0x0540 */ public List<GcInventoryBaseStat> BaseStats;
        [NMS(Index = 0)]
        /* 0x0550 */ public List<GcInventoryTableEntry> Table;
        [NMS(Index = 1)]
        /* 0x0560 */ public GcInventoryLayoutGenerationData GenerationData;
        [NMS(Index = 10, Size = 0xA, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x137C */ public GcShipInventoryMaxUpgradeCapacity[] ShipInventoryMaxUpgradeSize;
        [NMS(Index = 2)]
        /* 0x155C */ public GcInventoryCostData ShipCostData;
        [NMS(Index = 3, Size = 0xA, EnumType = typeof(GcWeaponClasses.WeaponStatClassEnum))]
        /* 0x16EC */ public GcInventoryCostDataEntry[] WeaponCostData;
        [NMS(Index = 5, Size = 0x4, EnumType = typeof(GcWealthClass.WealthClassEnum))]
        /* 0x187C */ public GcInventoryClassProbabilities[] ClassProbabilityData;
        [NMS(Index = 4)]
        /* 0x18BC */ public GcInventoryCostDataEntry VehicleCostData;
        [NMS(Index = 11)]
        /* 0x18E4 */ public GcWeaponInventoryMaxUpgradeCapacity WeaponInventoryMaxUpgradeSize;
    }
}
