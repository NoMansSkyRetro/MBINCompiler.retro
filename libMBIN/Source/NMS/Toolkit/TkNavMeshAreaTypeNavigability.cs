using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xCEC520D9588E352F, NameHash = 0x22FB49A4)]
    public class TkNavMeshAreaTypeNavigability : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public TkNavMeshAreaNavigability Navigability;
        [NMS(Index = 0)]
        /* 0xC */ public TkNavMeshAreaType AreaType;
    }
}
