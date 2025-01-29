using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x734B4BF5B96FE11D, NameHash = 0xE4BF25FD)]
    public class GcMechMeshPartData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x3, EnumType = typeof(GcMechMeshType.MechMeshTypeEnum))]
        /* 0x0 */ public GcMechMeshPartTypeData[] MeshTypes;
    }
}
