namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xED7EA3C66338607D, NameHash = 0x570640A8)]
    public class GcTechnologyCategory : NMSTemplate
    {
        // size: 0x11
        public enum TechnologyCategoryEnum : uint {
            Ship,
            Weapon,
            Suit,
            Personal,
            All,
            None,
            Freighter,
            Maintenance,
            Exocraft,
            Colossus,
            Submarine,
            Mech,
            AllVehicles,
            AlienShip,
            AllShips,
            RobotShip,
            AllShipsExceptAlien,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public TechnologyCategoryEnum TechnologyCategory;
    }
}
