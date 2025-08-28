using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x6535170541DCA728, NameHash = 0xDF397906)]
    public class TkNavModifierComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public TkNavMeshInclusionParams NavMeshInclusion;
    }
}
