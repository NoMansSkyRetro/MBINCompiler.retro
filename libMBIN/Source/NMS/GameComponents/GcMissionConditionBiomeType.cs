using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x40A7B8E1E896C6A0, NameHash = 0xFD18D350)]
    public class GcMissionConditionBiomeType : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcBiomeType Type;
        [NMS(Index = 1)]
        /* 0x4 */ public bool AnyInfested;
    }
}
