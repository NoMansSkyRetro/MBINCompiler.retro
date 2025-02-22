using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x540D454C21830CA8, NameHash = 0xE2349289)]
    public class GcPlayerDamageTable : NMSTemplate
    {
        [NMS(Index = 0, KeyField = "Id")]
        /* 0x0 */ public HashMap<GcPlayerDamageData> DamageTable;
    }
}
