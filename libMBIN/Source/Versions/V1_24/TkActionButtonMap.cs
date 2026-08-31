using System.Collections.Generic;

namespace libMBIN.V1_24.Structs
{
    public class TkActionButtonMap : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string ActionId;
        public bool ScaleToFitFont;
        public TkInputEnum PadButtonId;
        public List<TkPlatformButtonPair> Platforms;
    }
}
