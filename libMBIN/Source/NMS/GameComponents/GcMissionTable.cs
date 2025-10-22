using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC8573B85474C98DE, NameHash = 0x4E2556EB)]
    public class GcMissionTable : NMSTemplate
    {
        [NMS(Index = 0, KeyField = "MissionID")]
        /* 0x0 */ public HashMap<GcGenericMissionSequence> Missions;
    }
}
