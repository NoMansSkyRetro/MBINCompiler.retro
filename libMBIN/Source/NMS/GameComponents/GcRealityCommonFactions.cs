namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3FAF2693E9A6F89A, NameHash = 0x3BAFC07)]
    public class GcRealityCommonFactions : NMSTemplate
    {
        // size: 0x5
        public enum AIFactionEnum : uint {
            Player,
            Civilian,
            Pirate,
            Police,
            Creature,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public AIFactionEnum AIFaction;
    }
}
