using libMBIN.NMS;
using libMBIN.NMS.GameComponents;
namespace libMBIN.V1_13.Structs
{
    [NMS(Alignment = 0x8)]
    public class GcCostStanding : NMSTemplate
    {
        public GcAlienRace AlienRace;
        public int RequiredStanding;
    }
}
