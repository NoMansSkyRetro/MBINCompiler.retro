using libMBIN.NMS;
using System.Collections.Generic;
namespace libMBIN.V1_09_1.Structs
{
    // 1.09.1 layout (0x50, from DEFAULTREALITY bytes): the scalar block precedes the lists
    public class GcTradeData : NMSTemplate
    {
        public int MinItemsForSale;
        public int MaxItemsForSale;
        public float PercentageOfItemsAreProducts;
        public int MinAmountOfProductAvailable;
        public int MaxAmountOfProductAvailable;
        public int MinAmountOfSubstanceAvailable;
        public int MaxAmountOfSubstanceAvailable;
        public bool HasStarItems;
        public int MinNumberOfStarItems;
        public int MaxNumberOfStarItems;
        public float StarItemMarkUp;
        public int Unknown2C;
        public List<NMSString0x10> AlwaysPresentProducts;
        public List<NMSString0x10> AlwaysPresentSubstances;
    }
}
