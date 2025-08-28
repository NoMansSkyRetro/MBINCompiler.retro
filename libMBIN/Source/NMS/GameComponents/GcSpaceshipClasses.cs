namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5F6BF09A580035FA, NameHash = 0x5179E0DF)]
    public class GcSpaceshipClasses : NMSTemplate
    {
        // size: 0xB
        public enum ShipClassEnum : uint {
            Freighter,
            Dropship,
            Fighter,
            Scientific,
            Shuttle,
            PlayerFreighter,
            Royal,
            Alien,
            Sail,
            Robot,
            Corvette,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ShipClassEnum ShipClass;
    }
}
