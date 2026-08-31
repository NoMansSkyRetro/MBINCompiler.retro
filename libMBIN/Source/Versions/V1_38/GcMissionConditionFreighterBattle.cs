namespace libMBIN.V1_38.Structs
{
    public class GcMissionConditionFreighterBattle : NMSTemplate
    {
        public int FreighterBattleStatus;
        public string[] FreighterBattleStatusValues()
        {
            return new[] { "None", "Active", "Joined", "Reward"};
        }
        public int FreighterBattleDistance;
        public TkEqualityEnum FreighterBattleTest;
    }
}
