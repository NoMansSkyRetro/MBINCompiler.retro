namespace libMBIN.V1_38.Structs
{
    [NMS(Alignment = 0x10)]
    public class GcNGuiGraphicData : NMSTemplate
    {
        public GcNGuiElementData ElementData;
        public TkNGuiGraphicStyle Style;

        [NMS(Size = 0x80)]
        public string Image;
    }
}
