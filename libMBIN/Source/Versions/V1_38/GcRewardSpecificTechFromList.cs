using System.Collections.Generic;

namespace libMBIN.V1_38.Structs
{
    public class GcRewardSpecificTechFromList : NMSTemplate
    {
        public List<NMSString0x10> TechList;

        public int TechListRewardOrder;
        public string[] TechListRewardOrderValues()
        {
            return new[] { "OneRandom", "InOrder", "TryAllRandom" };
        }

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding14;
    }
}
