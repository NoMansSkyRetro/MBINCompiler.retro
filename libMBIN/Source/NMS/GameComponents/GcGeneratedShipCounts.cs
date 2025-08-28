using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x646C77D0C9F53D5C, NameHash = 0x4069B863)]
    public class GcGeneratedShipCounts : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x8, EnumType = typeof(GcAISpaceshipRoles.AIShipRoleEnum))]
        /* 0x0 */ public int[] Counts;
    }
}
