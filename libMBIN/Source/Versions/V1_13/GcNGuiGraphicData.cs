using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
{
    public class GcNGuiGraphicData : NMSTemplate
    {
        public GcNGuiElementData ElementData;
        public TkNGuiGraphicStyle Style;

        [NMS(Size = 0x80)]
        public string Image;
    }
}
