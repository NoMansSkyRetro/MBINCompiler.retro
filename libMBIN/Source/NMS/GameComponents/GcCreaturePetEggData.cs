using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xABE07B847F5831C2, NameHash = 0x78DE80B5)]
    public class GcCreaturePetEggData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public GcResourceElement EggResource;
        [NMS(Index = 3)]
        /* 0x48 */ public GcResourceElement HatchResource;
        [NMS(Index = 1)]
        /* 0x90 */ public TkTextureResource IconResource;
        [NMS(Index = 0)]
        /* 0xA8 */ public NMSString0x10 Id;
        [NMS(Index = 5)]
        /* 0xB8 */ public float HatchOffset;
        [NMS(Index = 4)]
        /* 0xBC */ public float HatchScale;
    }
}
