using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
{
    public class GcCostInstalledTech : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
		
        public int InvetoryToCheck;
        public string[] InventoryToCheckValues()
        {
            return new[] { "All", "Suit", "Ship", "Weapon", "Freighter", "Buggy" };
        }
    }
}
