using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA3F6DB1430E039F9, NameHash = 0x2F76F833)]
    public class GcAISpaceshipMappingData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x8, EnumType = typeof(GcAISpaceshipRoles.AIShipRoleEnum))]
        /* 0x0 */ public GcAISpaceshipInstanceData[] ClassMap;
    }
}
