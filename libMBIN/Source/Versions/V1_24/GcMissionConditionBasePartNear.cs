using libMBIN.NMS;
namespace libMBIN.V1_24.Structs
{
    [NMS(Alignment = 0x8)]
    public class GcMissionConditionBasePartNear : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string PartID;
        /* 0x10 */ public float Distance;
        [NMS(Size = 4, Ignore = true)]
        /* 0x14 */ public byte[] Padding14;
    }
}
