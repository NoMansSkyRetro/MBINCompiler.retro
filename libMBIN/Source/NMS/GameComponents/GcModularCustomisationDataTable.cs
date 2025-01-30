using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3ACC0B38DDFE8CCB, NameHash = 0x54887B8D)]
    public class GcModularCustomisationDataTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x6, EnumType = typeof(GcModularCustomisationResourceType.ModularCustomisationResourceTypeEnum))]
        /* 0x000 */ public GcModularCustomisationConfig[] ModularCustomisationConfigs;
        [NMS(Index = 2, Size = 0x6, EnumType = typeof(GcModularCustomisationResourceType.ModularCustomisationResourceTypeEnum))]
        /* 0xEA0 */ public GcModularCustomisationProductLookupList[] ProductLookupLists;
        [NMS(Index = 1)]
        /* 0xF00 */ public List<GcModularCustomisationSlottableItemList> SharedSlottableItemLists;
    }
}
