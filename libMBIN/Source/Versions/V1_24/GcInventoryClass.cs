namespace libMBIN.V1_24.Structs
{
    public class GcInventoryClass : NMSTemplate
    {
        public int InventoryClass;
        public string[] InventoryValues()
        {
            return new[] { "C", "B", "A", "S" };
        }
    }
}
