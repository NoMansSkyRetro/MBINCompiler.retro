using libMBIN.NMS;
namespace libMBIN.V1_38.Structs
{
    [NMS(Alignment = 0x8)]
    public class GcCostJourneyMilestone : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string RequiredMilestone;
    }
}
