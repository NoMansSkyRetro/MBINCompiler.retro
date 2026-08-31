using System.Collections.Generic;

namespace libMBIN.V1_24.Structs
{
    public class TkLSystemGlobalRestriction : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Name;
        [NMS(Size = 0x80)]
        public string Model;

        public List<TkLSystemRestrictionData> Restrictions;
    }
}
