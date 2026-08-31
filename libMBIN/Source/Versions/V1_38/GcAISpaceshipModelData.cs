namespace libMBIN.V1_38.Structs
{
    public class GcAISpaceshipModelData : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string File;
        public GcSpaceshipClasses Class;
        public GcAISpaceshipRoles AIRole;
    }
}
