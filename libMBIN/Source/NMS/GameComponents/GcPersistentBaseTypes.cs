namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5A7A0045D5A93F0, NameHash = 0xF6DBD6AA)]
    public class GcPersistentBaseTypes : NMSTemplate
    {
        // size: 0xB
        public enum PersistentBaseTypesEnum : uint {
            HomePlanetBase,
            FreighterBase,
            ExternalPlanetBase,
            CivilianFreighterBase,
            FriendsPlanetBase,
            FriendsFreighterBase,
            SpaceBase,
            GeneratedPlanetBase,
            GeneratedPlanetBaseEdits,
            PlayerShipBase,
            FriendsShipBase,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public PersistentBaseTypesEnum PersistentBaseTypes;
    }
}
