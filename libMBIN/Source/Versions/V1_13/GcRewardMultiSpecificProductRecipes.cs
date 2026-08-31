using System.Collections.Generic;

using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
{
    public class GcRewardMultiSpecificProductRecipes : NMSTemplate
    {
        public List<NMSString0x10> ProductIds;
        [NMS(Size = 0x10)]
        public string DisplayProductId;
        [NMS(Size = 0x10)]
        public string SetName;
    }
}
