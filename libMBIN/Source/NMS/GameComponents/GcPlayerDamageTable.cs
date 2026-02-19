using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4390E5789E2C7EDC, NameHash = 0xE2349289)]
    public class GcPlayerDamageTable : NMSTemplate
    {
        [NMS(Index = 0, KeyField = "Id")]
        /* 0x0 */ public HashMap<GcPlayerDamageData> DamageTable;
    }
}
