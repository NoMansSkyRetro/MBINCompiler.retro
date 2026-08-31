namespace libMBIN.V1_24.Structs
{
    public class GcStats : NMSTemplate
    {
        [NMS(Size = 4)]
        public GcStatsGroup[] Stats;
    }
}
