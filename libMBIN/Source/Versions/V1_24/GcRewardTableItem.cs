namespace libMBIN.V1_24.Structs
{
    public class GcRewardTableItem : NMSTemplate
    {
        public float PercentageChance;
        public NMSTemplate Reward; // Generic
        [NMS(Size = 0x40)]
        public string LabelID;
    }
}
