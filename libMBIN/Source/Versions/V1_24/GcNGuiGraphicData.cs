namespace libMBIN.V1_24.Structs
{
    public class GcNGuiGraphicData : NMSTemplate
    {
        public GcNGuiElementData ElementData;
        public TkNGuiGraphicStyle Style;

        [NMS(Size = 0x80)]
        public string Image;
    }
}
