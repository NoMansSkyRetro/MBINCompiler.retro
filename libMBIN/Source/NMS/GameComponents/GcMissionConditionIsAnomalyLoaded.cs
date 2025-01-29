using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x98656B7E3B42EB03, NameHash = 0xD6FAC380)]
    public class GcMissionConditionIsAnomalyLoaded : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcGalaxyStarAnomaly Anomaly;
    }
}
