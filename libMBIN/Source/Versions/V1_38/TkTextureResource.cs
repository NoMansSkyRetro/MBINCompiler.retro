namespace libMBIN.V1_38.Structs
{
    public class TkTextureResource : NMSTemplate        // size: 0x84
    {
        [NMS(Size = 0x80)]
        public string Filename;
        [NMS(Ignore = true)]
        public int EmptyNode1;		// should change this to a byte type so everything is the same...
    }
}
