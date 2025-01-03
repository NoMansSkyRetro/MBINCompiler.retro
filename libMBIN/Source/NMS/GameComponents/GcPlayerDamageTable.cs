using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8B238D7C4CFE46AF, NameHash = 0xE2349289)]
    public class GcPlayerDamageTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public HashMap<GcPlayerDamageData> DamageTable;
    }
}
