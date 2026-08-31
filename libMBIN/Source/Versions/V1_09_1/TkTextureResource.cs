namespace libMBIN.V1_09_1.Structs
{
    public class TkTextureResource : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Filename;
        [NMS(Ignore = true)]
        public int EmptyNode1;
    }
}
