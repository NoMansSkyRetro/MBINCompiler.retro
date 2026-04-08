using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x311833704A34D157, NameHash = 0xEFBFCE4B)]
    public class GcGameTableNPCEventReactionData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x2, EnumType = typeof(GcGameTableNPCEventTriggerOwner.GameTableNPCEventTriggerOwnerEnum))]
        /* 0x0 */ public GcGameTableNPCEventReactionList[] Reactions;
    }
}
