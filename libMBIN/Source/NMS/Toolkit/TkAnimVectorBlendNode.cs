using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x6F283ECB79AD1601, NameHash = 0xE281E250)]
    public class TkAnimVectorBlendNode : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<TkAnimVectorBlendNodeData> BlendChildren;
        // size: 0x2
        public enum BlendOperationEnum : uint {
            Blend,
            Add,
        }
        [NMS(Index = 0)]
        /* 0x10 */ public BlendOperationEnum BlendOperation;
    }
}
