using System.Collections.Generic;
using libMBIN.NMS;
namespace libMBIN.V1_13.Structs
{
    [NMS(Alignment = 0x8)]
    public class GcCostBuildingParts : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Description;
        public List<GcBuildingCostPartCount> RequiredParts;
    }
}
