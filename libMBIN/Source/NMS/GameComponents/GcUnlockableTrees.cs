using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6B5A6810C3D292C0, NameHash = 0x600392A1)]
    public class GcUnlockableTrees : NMSTemplate
    {
        [NMS(Index = 0, Size = 0xE, EnumType = typeof(GcUnlockableItemTreeGroups.UnlockableItemTreeEnum))]
        /* 0x000 */ public GcUnlockableItemTrees[] Trees;
        [NMS(Index = 1)]
        /* 0x2A0 */ public List<GcUnlockableTreeCostType> CostTypes;
    }
}
