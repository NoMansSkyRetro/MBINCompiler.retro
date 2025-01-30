using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFA662DC7B2A63D88, NameHash = 0xA6C1713F)]
    public class GcPlayerHazardTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x7, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x0 */ public GcPlayerHazardData[] Table;
    }
}
