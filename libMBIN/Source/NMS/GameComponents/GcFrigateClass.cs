namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x674F5182459F7D3E, NameHash = 0x47646960)]
    public class GcFrigateClass : NMSTemplate
    {
        // size: 0xA
        public enum FrigateClassEnum : uint {
            Combat,
            Exploration,
            Mining,
            Diplomacy,
            Support,
            Normandy,
            DeepSpace,
            DeepSpaceCommon,
            Pirate,
            GhostShip,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public FrigateClassEnum FrigateClass;
    }
}
