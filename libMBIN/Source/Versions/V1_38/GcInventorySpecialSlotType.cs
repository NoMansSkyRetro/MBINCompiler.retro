namespace libMBIN.V1_38.Structs
{
    public class GcInventorySpecialSlotType : NMSTemplate
    {
        public int InventorySpecialSlotType;
        public string[] InventorySpecialSlotTypeValues()
        {
            return new[] { "Broken", "TechOnly", "Cargo"};
        }
    }
}
