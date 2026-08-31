using System.Collections.Generic;

namespace libMBIN.V1_24.Structs
{
    public class GcNGuiSpecialTextStyleData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Name;

        public List<NMSTemplate> StyleProperties;
        public GcNGuiStyleAnimationData Animation;
    }
}
