namespace libMBIN.V1_38.Structs
{
    public class GcMissionTextDummy : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Text;
        public GcMissionPageHint PageHint;
    }
}
