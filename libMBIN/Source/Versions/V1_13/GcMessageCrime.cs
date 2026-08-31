using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
{
    public class GcMessageCrime : NMSTemplate
    {
        public int Crime;
        public string[] CrimeValues()
        {
            return new[]
            {
                "AttackCreature", "AttackSentinel", "KillCreature", "KillSentinel", "MineResources", "HitResources",
                "AttackSpaceStation", "AttackShip", "AttackPolice", "KillShip", "KillPolice", "TimedShootable"
            };
        }
        public Vector4f Position;
        public int Value;
    }
}
