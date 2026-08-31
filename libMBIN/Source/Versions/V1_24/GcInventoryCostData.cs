using System.Collections.Generic;

namespace libMBIN.V1_24.Structs
{
    public class GcInventoryCostData : NMSTemplate     // size: 0xF0
    {
        [NMS(Size = 0x6, EnumValue = new[] { "Freighter", "Dropship", "Fighter", "Scientific", "Shuttle", "PlayerFreighter" })]
        public GcInventoryCostDataEntry[] InventoryCostData;

    }
}
