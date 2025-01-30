namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x27296A37F094C515, NameHash = 0xB154C16E)]
    public class GcInventoryClass : NMSTemplate
    {
        // size: 0x4
        public enum InventoryClassEnum : uint {
            C,
            B,
            A,
            S,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public InventoryClassEnum InventoryClass;
    }
}
