using System.Collections.Generic;

namespace libMBIN.V1_38.Structs
{
    public class TkEqualityEnum : NMSTemplate
    {
        public int EqualityEnum;
        public string[] EqualityEnumValues()
        {
            return new[] { "Equal", "Greater", "Less", "GreaterEqual", "LessEqual"};
        }
    }
}
