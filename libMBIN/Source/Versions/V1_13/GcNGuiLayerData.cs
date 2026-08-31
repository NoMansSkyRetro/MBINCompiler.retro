using System.Collections.Generic;

using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
{
    public class GcNGuiLayerData : NMSTemplate
    {
        public GcNGuiElementData Data;
        public TkNGuiGraphicStyle Style;
        [NMS(Size = 0x80)]
        public string Image;
        public List<NMSTemplate> Children;
        [NMS(Size = 0x80)]
        public string DataFilename;
    }
}
