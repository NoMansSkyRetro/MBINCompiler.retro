using System.Collections.Generic;

namespace libMBIN.V1_38.Structs
{
    public class GcDefaultMissionSubstanceEnum : NMSTemplate
    {
        public int DefaultSubstanceType;
        public string[] DefaultSubstanceTypeValues()
        {
            return new[] { "None", "PrimarySubstance", "SecondarySubstance" };
        }
    }
}
