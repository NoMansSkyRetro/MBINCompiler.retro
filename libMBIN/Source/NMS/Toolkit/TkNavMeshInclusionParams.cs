using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xF06C5BB778DC8DF7, NameHash = 0xA35B0A28)]
    public class TkNavMeshInclusionParams : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public float InclusionMinSize;
        [NMS(Index = 0)]
        /* 0x4 */ public TkNavMeshInclusionType InclusionType;
        [NMS(Index = 2)]
        /* 0x8 */ public TkNavMeshAreaType AreaType;
    }
}
