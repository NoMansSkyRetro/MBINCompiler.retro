using System.Collections.Generic;

namespace libMBIN.V1_38.Structs
{
    public class GcInventoryBaseStat : NMSTemplate      // size: 0x30
    {
        [NMS(Size = 0x10)]
        public string BaseStatID;
        [NMS(Size = 0x10)]
        public string LocID;
        public List<GcInventoryBaseStatBonus> StatBonus;
    }
}
