using System.Collections.Generic;

namespace libMBIN.V1_24.Structs
{
    public class GcInventoryLayoutGenerationDataEntry : NMSTemplate     // size: 0x20
    {
        public int MinSlots;
        public int MaxSlots;
        public int MinExtraTech;
        public int MaxExtraTech;
        public List<NMSString0x10> GenerationTech;
    }
}
