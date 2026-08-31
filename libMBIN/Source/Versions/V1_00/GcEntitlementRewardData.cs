using libMBIN.NMS;

namespace libMBIN.V1_00.Structs
{
    public class GcEntitlementRewardData : NMSTemplate // disc: 0x30, no Name/Error strings
    {
        public NMSString0x20 EntitlementId;
        public NMSString0x10 RewardId;
    }
}
