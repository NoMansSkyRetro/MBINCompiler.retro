namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1C14C978586F4400, NameHash = 0xA200B6EB)]
    public class GcAISpaceshipRoles : NMSTemplate
    {
        // size: 0x8
        public enum AIShipRoleEnum : uint {
            Standard,
            PlayerSquadron,
            Freighter,
            CapitalFreighter,
            SmallFreighter,
            TinyFreighter,
            Frigate,
            Biggs,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public AIShipRoleEnum AIShipRole;
    }
}
