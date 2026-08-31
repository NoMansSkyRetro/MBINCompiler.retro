namespace libMBIN.V1_38.Structs
{
    public class GcRewardTeleport : NMSTemplate
    {
        public int TeleportRewardType;
        public string[] TeleportRewardTypeValues()
        {
            return new[] { "None", "ToBase", "Station0", "Station1", "Station2", "Station3", "Atlas" };
        }
    }
}
