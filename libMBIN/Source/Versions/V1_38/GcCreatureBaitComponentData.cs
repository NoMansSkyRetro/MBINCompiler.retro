using libMBIN.NMS;
using System.Collections.Generic;

namespace libMBIN.V1_38.Structs
{
    public class GcCreatureBaitComponentData : NMSTemplate
    {
        public List<NMSString0x10> AttractList;
        public float BaitStrength;
        public float BaitRadius;

        public bool Debug;
        public bool InducesRage;

        [NMS(Size = 6, Ignore = true)]
        public byte[] Padding1A;
    }
}
