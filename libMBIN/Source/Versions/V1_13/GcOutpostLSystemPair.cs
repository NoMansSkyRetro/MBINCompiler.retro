using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
{
    public class GcOutpostLSystemPair : NMSTemplate // 0x320 bytes
    {
        [NMS(Size = 0x20)]
        public string Locator;
        [NMS(Size = 7)]
        public NMSString0x80[] LSystems;
    }
}
