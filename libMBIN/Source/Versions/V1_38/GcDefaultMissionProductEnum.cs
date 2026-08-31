using System.Collections.Generic;

namespace libMBIN.V1_38.Structs
{
    public class GcDefaultMissionProductEnum : NMSTemplate
    {
        public int DefaultProductType;
        public string[] DefaultProductTypeValues()
        {
            return new[] { "None", "PrimaryProduct", "SecondaryProduct" };
        }
    }
}
