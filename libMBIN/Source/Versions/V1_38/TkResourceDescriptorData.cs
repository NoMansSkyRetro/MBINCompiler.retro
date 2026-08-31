using System.Collections.Generic;

namespace libMBIN.V1_38.Structs
{
    public class TkResourceDescriptorData : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Id;
        [NMS(Size = 0x80)]
        public string Name;
        public List<NMSString0x80> ReferencePaths;
        public float Chance;
        public List<NMSTemplate> Children;
    }
}
