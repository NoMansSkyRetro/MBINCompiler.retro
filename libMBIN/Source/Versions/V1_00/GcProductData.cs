using libMBIN.NMS;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.V1_00.Structs
{
    public class GcProductData : NMSTemplate
    {
        public NMSString0x10 Id;
        public NMSString0x80 Name;
        public NMSString0x80 NameLower;
        public VariableSizeString Subtitle;
        public VariableSizeString Description;
        public NMSString0x20 Hint;
        public TkModelResource Debis;
        public int BaseValue;
        public int Level;
        public TkTextureResource Icon;
        public Colour Colour;
        public GcRealitySubstanceCategory SubstanceCategory;
        public GcProductCategory Category;
        public GcRarity Rarity;
        public GcLegality Legality;
        public bool Consumable;
        public int ChargeValue;
        public List<GcTechnologyRequirement> Requirements;
        public GcItemPriceModifiers Cost;
        public bool SpecificChargeOnly;
    }
}
