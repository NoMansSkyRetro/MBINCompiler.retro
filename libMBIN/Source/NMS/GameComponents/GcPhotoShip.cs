namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC810C015C2A3D2F6, NameHash = 0x94E48FB7)]
    public class GcPhotoShip : NMSTemplate
    {
        // size: 0xB
        public enum PhotoShipTypeEnum : uint {
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
        /* 0x0 */ public PhotoShipTypeEnum PhotoShipType;
    }
}
