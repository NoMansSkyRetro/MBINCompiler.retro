using System.Collections.Generic;

namespace libMBIN.V1_38.Structs
{
    public class GcMaintenanceElementGroups : NMSTemplate
    {
        public int MaintenanceGroup;
        public string[] MaintenanceGroupValues()
        {
            return new[] { "Custom", "Farming", "Fuelling", "Repairing", "Cleaning"};
        }
    }
}
