namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF257AE5007EACDCD, NameHash = 0xED81F7C6)]
    public class GcNPCTriggerTypes : NMSTemplate
    {
        // size: 0x10
        public enum NPCTriggerEnum : uint {
            None,
            Idle,
            Greet,
            Mood,
            StartDead,
            Talk_Start,
            Talk_Stop,
            Interact_Start,
            Interact_Stop,
            Interact_BeginHold,
            Interact_CancelHold,
            LookAt_Player_Start,
            LookAt_Player_Stop,
            SetProp,
            Interact_StartFromRemote,
            StartBusy,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public NPCTriggerEnum NPCTrigger;
    }
}
