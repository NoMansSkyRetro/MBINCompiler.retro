using System.Collections.Generic;

namespace libMBIN.V1_38.Structs
{
    public class GcMissionConditionTest : NMSTemplate
    {
        public int ConditionTest;
        public string[] ConditionTestValues()
        {
            return new[] { "AnyFalse", "AllFalse", "AnyTrue", "AllTrue"};
        }
    }
}
