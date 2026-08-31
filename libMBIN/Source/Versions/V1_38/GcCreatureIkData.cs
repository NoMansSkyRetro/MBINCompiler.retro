namespace libMBIN.V1_38.Structs
{
    public class GcCreatureIkData : NMSTemplate
    {
        public GcCreatureIkType CreatureIkType;
        [NMS(Size = 0x100)]
        public string JointName;
    }
}
