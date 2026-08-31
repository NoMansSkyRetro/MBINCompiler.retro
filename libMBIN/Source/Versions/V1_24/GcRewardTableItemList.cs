using System.Collections.Generic;

namespace libMBIN.V1_24.Structs
{
    public class GcRewardTableItemList : NMSTemplate
    {
        public bool EntitlementLinked;
        [NMS(Size = 0x20)]
        public string EntitlementId;
        public int RewardChoice;
        public string[] RewardChoiceValues()
        {
            return new[] { "GiveAll", "Select", "TryEach" };
        }

        public List<GcRewardTableItem> List;
    }
}
