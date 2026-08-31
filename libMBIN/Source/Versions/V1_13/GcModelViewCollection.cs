using libMBIN.NMS;
using libMBIN.NMS.Toolkit;

namespace libMBIN.V1_13.Structs
{
    public class GcModelViewCollection : NMSTemplate // 0x770
    {
        [NMS(Size = 0x11, EnumValue = new string[0x11] {"Exosuit", "Weapon", "Ship", "Animal", "AnimalThumbnails",
                                                        "Unknown2", "Unknown3","Unknown4","Unknown5","Unknown6","Unknown7",
                                                        "Unknown8","Unknown9", "Freighter", "Unknown10","Unknown11","Unknown12",})] // 17 * 0x70 = 0x770
        public TkModelRendererData[] ModelViews;
    }
}
