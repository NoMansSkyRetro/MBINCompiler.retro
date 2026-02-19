using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD859771393F29E66, NameHash = 0x2218E35E)]
    public class GcMissionSequenceCommunicatorOnTakeOff : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public GcPlayerCommunicatorMessage Comms;
        [NMS(Index = 2)]
        /* 0x50 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x60 */ public VariableSizeString Message;
    }
}
