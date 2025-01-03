using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB4BDA220D505A7D0, NameHash = 0xEDC78ED)]
    public class GcRecipeTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcRefinerRecipe> Table;
    }
}
