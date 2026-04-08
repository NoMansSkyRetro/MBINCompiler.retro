namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5D6D514B2C3DECA7, NameHash = 0x4B7625CE)]
    public class GcGameTableNPCEventTriggerOwner : NMSTemplate
    {
        // size: 0x2
        public enum GameTableNPCEventTriggerOwnerEnum : uint {
            Self,
            Opponent,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public GameTableNPCEventTriggerOwnerEnum GameTableNPCEventTriggerOwner;
    }
}
