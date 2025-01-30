namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9F013B9DA4926097, NameHash = 0x6D272431)]
    public class GcAlienRace : NMSTemplate
    {
        // size: 0x9
        public enum AlienRaceEnum : uint {
            Traders,
            Warriors,
            Explorers,
            Robots,
            Atlas,
            Diplomats,
            Exotics,
            None,
            Builders,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public AlienRaceEnum AlienRace;
    }
}
