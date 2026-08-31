using libMBIN.NMS;
using System.Collections.Generic;

namespace libMBIN.V1_24.Structs
{
    public class GcTechnologyAttachmentComponentData : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> Techs;

        /* 0x10 */ public int Inventory;
        public string[] InventoryValues()
        {
            return new[] { "Vehicle"};
        }
        /* 0x14 */ public bool Inverted;
    }
}
