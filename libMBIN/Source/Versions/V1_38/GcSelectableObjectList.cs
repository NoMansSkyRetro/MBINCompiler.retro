using System.Collections.Generic;

namespace libMBIN.V1_38.Structs
{
    public class GcSelectableObjectList : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Name;
        public GcAlienRace Race;
        public List<GcSelectableObjectData> Options;
    }
}
