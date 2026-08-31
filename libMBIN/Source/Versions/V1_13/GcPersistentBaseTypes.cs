using System.Collections.Generic;

using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
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
