using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
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
