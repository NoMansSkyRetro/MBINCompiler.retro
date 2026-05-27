namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA934596C84E6DA06, NameHash = 0x3CC4F74)]
    public class GcMissionConditionFlagshipBattleState : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public int AlliesBelowHealthPercentage;
        // size: 0x2
        public enum BattleStateEnum : uint {
            AlliesDead,
            AlliesBelowHealthPercentage,
        }
        [NMS(Index = 0)]
        /* 0x4 */ public BattleStateEnum BattleState;
    }
}
