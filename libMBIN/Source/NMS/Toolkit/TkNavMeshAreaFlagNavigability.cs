using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xA4482DB5131A058C, NameHash = 0x80C899CB)]
    public class TkNavMeshAreaFlagNavigability : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public TkNavMeshAreaNavigability Navigability;
        [NMS(Index = 0)]
        /* 0xC */ public TkNavMeshAreaFlags AreaFlag;
    }
}
