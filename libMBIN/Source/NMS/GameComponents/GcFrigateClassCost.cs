using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x46A4369BDF9C7EDD, NameHash = 0x36328696)]
    public class GcFrigateClassCost : NMSTemplate
    {
        [NMS(Index = 0, Size = 0xA, EnumType = typeof(GcFrigateClass.FrigateClassEnum))]
        /* 0x0 */ public int[] Cost;
    }
}
