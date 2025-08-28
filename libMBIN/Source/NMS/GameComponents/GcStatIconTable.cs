using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE8F356952D84FC7B, NameHash = 0xE97F7AA9)]
    public class GcStatIconTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0xCE, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x0 */ public VariableSizeString[] StatIcons;
    }
}
