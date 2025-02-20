using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE264E9CF58569C75, NameHash = 0xA5E5246F)]
    public class GcExternalObjectList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcEnvironmentSpawnData Objects;
    }
}
