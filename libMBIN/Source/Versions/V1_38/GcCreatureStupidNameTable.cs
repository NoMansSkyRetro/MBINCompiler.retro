using System.Collections.Generic;

namespace libMBIN.V1_38.Structs
{
    public class GcCreatureStupidNameTable : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string StupidUserName;

        public List<GcCreatureStupidName> Table;
    }
}
