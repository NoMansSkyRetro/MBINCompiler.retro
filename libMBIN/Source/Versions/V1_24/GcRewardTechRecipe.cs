namespace libMBIN.V1_24.Structs
{
    public class GcRewardTechRecipe : NMSTemplate
    {
        public GcTechnologyCategory Category;
        [NMS(Size = 0x10)]
        public string RewardGroup;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding14;
    }
}
