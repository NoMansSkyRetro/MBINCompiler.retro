using libMBIN.NMS;
namespace libMBIN.V1_13.Structs
{
    [NMS(Alignment = 0x8)]
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
