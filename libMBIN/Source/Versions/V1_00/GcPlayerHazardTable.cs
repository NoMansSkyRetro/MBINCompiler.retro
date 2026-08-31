using libMBIN.NMS;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.V1_00.Structs
{
    public class GcPlayerHazardTable : NMSTemplate
    {
        [NMS(Size = 6)]
        public GcPlayerHazardData[] Table;
    }
}
