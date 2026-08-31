using libMBIN.NMS;
using System.Collections.Generic;

namespace libMBIN.V1_24.Structs
{
    public class GcCreatureStupidName : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;

        public int Count;
        public List<NMSString0x80> Names;
    }
}
