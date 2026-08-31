using libMBIN.NMS;
namespace libMBIN.V1_38.Structs
{
    [NMS(Alignment = 0x8)]
    public class GcCostStanding : NMSTemplate
    {
        public GcAlienRace AlienRace;
        public int RequiredStanding;
    }
}
