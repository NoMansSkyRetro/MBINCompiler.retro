using libMBIN.NMS;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.V1_00.Structs
{
    public class GcRewardTechRecipe : NMSTemplate // 0x18
    {
        public GcTechnologyCategory Category;
        public int Unknown4;
        [NMS(Size = 0x10)]
        public string RewardGroup;
    }
}
