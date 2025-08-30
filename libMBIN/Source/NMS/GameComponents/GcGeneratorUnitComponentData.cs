using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8605BABAD0F03E7A, NameHash = 0x45C7860)]
    public class GcGeneratorUnitComponentData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x000 */ public GcMaintenanceComponentData MaintenanceData;
        [NMS(Index = 2, Size = 0x11, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x410 */ public NMSString0x10[] BiomeGasRewards;
        // size: 0x4
        public enum GeneratorUnitTypeEnum : uint {
            MiningUnit,
            GasHarvester,
            SystemHoover,
            SeaHarvester,
        }
        [NMS(Index = 0)]
        /* 0x520 */ public GeneratorUnitTypeEnum GeneratorUnitType;
        [NMS(Index = 1)]
        /* 0x524 */ public int ResourceMaintenanceSlotOverride;
    }
}
