using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFFE5C820E7C6C3CA, NameHash = 0xE2349289)]
    public class GcPlayerDamageTable : NMSTemplate
    {
        [NMS(Index = 0, KeyField = "Id")]
        /* 0x0 */ public HashMap<GcPlayerDamageData> DamageTable;
    }
}
