using System.Collections.Generic;

namespace libMBIN.V1_24.Structs
{
    public class GcStatGroupTable : NMSTemplate
    {
        public List<GcStatGroupData> Table; // called GcStatGroupTable in exe, C# won't let us use same name as class for members though
    }
}
