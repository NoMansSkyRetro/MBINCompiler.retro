using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC35150FABFE9EF5C, NameHash = 0x6831C7D8)]
    public class GcMissionSequenceWaitForRefuel : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public VariableSizeString Message;
        [NMS(Index = 2)]
        /* 0x20 */ public int Amount;
        [NMS(Index = 1)]
        /* 0x24 */ public GcStatsTypes TargetStat;
    }
}
