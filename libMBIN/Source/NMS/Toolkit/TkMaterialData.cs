using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x5EBA81CB025BC4A, NameHash = 0x4737D48A)]
    public class TkMaterialData : NMSTemplate
    {
        [NMS(Index = 10)]
        /* 0x00 */ public List<TkMaterialFlags> Flags;
        [NMS(Index = 11)]
        /* 0x10 */ public List<TkMaterialFxFlags> FxFlags;
        [NMS(Index = 8)]
        /* 0x20 */ public VariableSizeString Link;
        [NMS(Index = 1)]
        /* 0x30 */ public VariableSizeString Metamaterial;
        [NMS(Index = 0)]
        /* 0x40 */ public VariableSizeString Name;
        [NMS(Index = 14)]
        /* 0x50 */ public List<TkMaterialSampler> Samplers;
        [NMS(Index = 9)]
        /* 0x60 */ public VariableSizeString Shader;
        [NMS(Index = 12)]
        /* 0x70 */ public List<TkMaterialUniform_Float> Uniforms_Float;
        [NMS(Index = 13)]
        /* 0x80 */ public List<TkMaterialUniform_UInt> Uniforms_UInt;
        [NMS(Index = 15)]
        /* 0x90 */ public long ShaderMillDataHash;
        [NMS(Index = 3)]
        /* 0x98 */ public int TransparencyLayerID;
        [NMS(Index = 2)]
        /* 0x9C */ public NMSString0x20 Class;
        [NMS(Index = 4)]
        /* 0xBC */ public bool CastShadow;
        [NMS(Index = 6)]
        /* 0xBD */ public bool CreateFur;
        [NMS(Index = 5)]
        /* 0xBE */ public bool DisableZTest;
        [NMS(Index = 7)]
        /* 0xBF */ public bool EnableLodFade;
    }
}
