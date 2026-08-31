namespace libMBIN.V1_24.Structs
{
    public class GcAISpaceshipRoles : NMSTemplate
    {
        public int AIShipRole;
        public string[] AIShipRoleValues()
        {
            return new[] { "Standard", "Freighter", "CapitalFreighter", "SmallFreighter", "TinyFreighter" };
        }
    }
}
