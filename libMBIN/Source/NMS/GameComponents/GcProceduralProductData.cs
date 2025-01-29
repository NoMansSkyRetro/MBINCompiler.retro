using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAF6B812BAA9A5A1D, NameHash = 0xE5910A2D)]
    public class GcProceduralProductData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x000 */ public GcProductData Product;
        [NMS(Index = 4, Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x2E0 */ public GcProductProceduralOnlyData[] ProceduralData;
        [NMS(Index = 0)]
        /* 0x430 */ public GcNameGeneratorWord NameGeneratorBase;
        [NMS(Index = 1)]
        /* 0x458 */ public List<GcProceduralProductWord> NameGeneratorWordList;
        [NMS(Index = 5)]
        /* 0x468 */ public GcBiomeList PerBiomeDropWeights;
        [NMS(Index = 2)]
        /* 0x4F0 */ public int NameGeneratorLegacyRolls;
        [NMS(Index = 6)]
        /* 0x4F4 */ public NMSString0x20 DeployableProductID;
        [NMS(Index = 7)]
        /* 0x514 */ public bool RecordsStat;
    }
}
