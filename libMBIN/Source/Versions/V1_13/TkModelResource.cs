namespace libMBIN.V1_13.Structs
{
    public class TkModelResource : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Filename;
        [NMS(Ignore = true)]
        public int EmptyNode1;
    }
}
