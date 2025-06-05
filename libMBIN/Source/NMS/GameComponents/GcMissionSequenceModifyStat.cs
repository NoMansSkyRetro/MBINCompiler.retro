using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE5795F4755D20B9E, NameHash = 0x59D1F229)]
    public class GcMissionSequenceModifyStat : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Stat;
        [NMS(Index = 3)]
        /* 0x10 */ public NMSString0x10 StatGroup;
        [NMS(Index = 1)]
        /* 0x20 */ public int Amount;
        [NMS(Index = 2)]
        /* 0x24 */ public GcStatModifyType ModifyType;
    }
}
