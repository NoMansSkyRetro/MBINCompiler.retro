using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xC27A0D32247B7CFC, NameHash = 0x4026294F)]
    public class TkModelDescriptorList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkResourceDescriptorList> List;
    }
}
