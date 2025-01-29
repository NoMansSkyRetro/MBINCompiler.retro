namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD523E832428A94F0, NameHash = 0x89CBAB6)]
    public class GcModularCustomisationResourceType : NMSTemplate
    {
        // size: 0x6
        public enum ModularCustomisationResourceTypeEnum : uint {
            MultiToolStaff,
            Fighter,
            Dropship,
            Scientific,
            Shuttle,
            Sail,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ModularCustomisationResourceTypeEnum ModularCustomisationResourceType;
    }
}
