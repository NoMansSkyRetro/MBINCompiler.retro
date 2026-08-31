namespace libMBIN.V1_24.Structs
{
    public class TkControllerSpecification : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
        public TkButtonImageLookup ImageLookup;
    }
}
