using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xDFACB37BE3DA73B3, NameHash = 0xA35B0A28)]
    public class TkNavMeshInclusionParams : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public float InclusionMinSize;
        [NMS(Index = 2)]
        /* 0x4 */ public TkNavMeshAreaType AreaType;
        [NMS(Index = 0)]
        /* 0x5 */ public TkNavMeshInclusionType InclusionType;
    }
}
