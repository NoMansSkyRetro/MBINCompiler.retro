using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE85248509D9428AA, NameHash = 0x13A770D3)]
    public class GcHotActionsSaveData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0xA)]
        /* 0x0 */ public GcQuickMenuActionSaveData[] KeyActions;
    }
}
