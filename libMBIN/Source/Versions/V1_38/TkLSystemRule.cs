using System.Collections.Generic;

namespace libMBIN.V1_38.Structs
{
    public class TkLSystemRule : NMSTemplate // 0xB8 bytes
    {
        [NMS(Size = 0x20)]
        public string Name;
        [NMS(Size = 0x80)]
        public string Model;

        public List<TkLSystemInnerRule> Rules;

        public int RuleType;
        public string[] RuleTypeValues()
        {
            return new[] { "Default", "BaseRule" };
        }

        [NMS(Size = 4, Ignore = true)]
        public byte[] PaddingB4;
    }
}
