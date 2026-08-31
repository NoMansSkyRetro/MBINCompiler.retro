using System.Collections.Generic;

namespace libMBIN.V1_24.Structs
{
    public class GcPersistentBaseTypes : NMSTemplate
    {
        public int PersistentBaseTypes;
        public string[] PersistentBaseTypesValues()
        {
            return new[] { "HomePlanetBase", "FreighterBase" };
        }
    }
}
