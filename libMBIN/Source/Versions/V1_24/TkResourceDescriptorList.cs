using System.Collections.Generic;

namespace libMBIN.V1_24.Structs
{
    public class TkResourceDescriptorList : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string TypeId;
        public List<TkResourceDescriptorData> Descriptors;
    }
}
