using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8B03A8CC1D619F7D, NameHash = 0xE97F7AA9)]
    public class GcStatIconTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0xCB, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x0 */ public VariableSizeString[] StatIcons;
    }
}
