using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x711A0264DD1002D6, NameHash = 0xA5C6254C)]
    public class GcModelViewCollection : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x30, EnumType = typeof(GcModelViews.ModelViewsEnum))]
        /* 0x0 */ public TkModelRendererData[] ModelViewData;
    }
}
