using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4849BFA5C02461C4, NameHash = 0xCA916707)]
    public class GcCustomisationDescriptorGroupSet : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public List<GcCustomisationDescriptorGroup> DescriptorGroups;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 Id;
        [NMS(Index = 2)]
        /* 0x20 */ public NMSString0x10 RequiresGroup;
        [NMS(Index = 1)]
        /* 0x30 */ public bool GroupsAreMutuallyExclusive;
    }
}
