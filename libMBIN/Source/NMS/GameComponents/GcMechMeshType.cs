namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9ECDA7808D8C0D93, NameHash = 0x3E4089B3)]
    public class GcMechMeshType : NMSTemplate
    {
        // size: 0x3
        public enum MechMeshTypeEnum : uint {
            Exocraft,
            Sentinel,
            BugHunter,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public MechMeshTypeEnum MechMeshType;
    }
}
