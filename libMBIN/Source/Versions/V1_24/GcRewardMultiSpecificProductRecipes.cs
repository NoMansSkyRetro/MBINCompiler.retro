using libMBIN.NMS;
using System.Collections.Generic;

namespace libMBIN.V1_24.Structs
{
    public class GcRewardMultiSpecificProductRecipes : NMSTemplate
    {
        public List<NMSString0x10> ProductIds;
        [NMS(Size = 0x10)]
        public string DisplayProductId;
        [NMS(Size = 0x20)]
        public string SetName;
    }
}
