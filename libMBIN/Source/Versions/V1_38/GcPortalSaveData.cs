using libMBIN.NMS;
namespace libMBIN.V1_38.Structs
{
    [NMS(Size = 0x18)]
    public class GcPortalSaveData : NMSTemplate
    {
        public GcSeed PortalSeed;
        public ulong LastPortalUA;      // Universal Address
    }
}
