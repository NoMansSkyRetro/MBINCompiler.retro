using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB63E70B7F9E8FABD, NameHash = 0x4E8AAD10)]
    public class GcScreenFilterTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x54, EnumType = typeof(GcScreenFilters.ScreenFilterEnum))]
        /* 0x0 */ public GcScreenFilterData[] Filters;
    }
}
