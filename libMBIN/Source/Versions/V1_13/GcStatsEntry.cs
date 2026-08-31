using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
{
    public class GcStatsEntry : NMSTemplate
    {
        public GcStatsTypes StatsType;
        public Colour Colour;
        public float RangeMin;
        public float RangeMax;
        public bool LessIsBetter;

        [NMS(Ignore = true)]
        public int EmptyNode1;
    }
}
