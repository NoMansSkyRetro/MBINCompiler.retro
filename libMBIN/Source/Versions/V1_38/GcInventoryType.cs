namespace libMBIN.V1_38.Structs
{
    public class GcInventoryType : NMSTemplate
    {
        public int InventoryType; // Substance / Technology / Product

        public string[] InventoryTypeValues()
        {
            return new[] { "Substance", "Technology", "Product" };
        }
    }
}
