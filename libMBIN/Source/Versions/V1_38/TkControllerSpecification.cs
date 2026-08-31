namespace libMBIN.V1_38.Structs
{
    public class TkControllerSpecification : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
        public TkButtonImageLookup ImageLookup;
    }
}
