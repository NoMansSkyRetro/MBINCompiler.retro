namespace libMBIN.V1_38.Structs
{
    public class GcInventoryClassProbabilities : NMSTemplate
    {
        [NMS(Size = 4, EnumValue = new[] { "C", "B", "A", "S" })]
        public float[] ClassProbabilities;
    }
}
