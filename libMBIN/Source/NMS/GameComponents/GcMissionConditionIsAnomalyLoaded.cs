using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD99E1CA6C1334FEC, NameHash = 0xD6FAC380)]
    public class GcMissionConditionIsAnomalyLoaded : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcGalaxyStarAnomaly Anomaly;
    }
}
