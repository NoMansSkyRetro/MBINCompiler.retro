using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1978387435F26873, NameHash = 0x15C14AC1)]
    public class GcBuildingDefinitionData : NMSTemplate
    {
        [NMS(Index = 8)]
        /* 0x00 */ public NMSString0x20A TextureNameHint;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x10 ClusterLayout;
        [NMS(Index = 3, Size = 0x8, EnumType = typeof(GcBuildingDensityLevels.BuildingDensityEnum))]
        /* 0x30 */ public float[] Density;
        [NMS(Index = 0)]
        /* 0x50 */ public TkNoiseFlattenOptions FlattenType;
        [NMS(Index = 2)]
        /* 0x58 */ public float ClusterSpacing;
        [NMS(Index = 12)]
        /* 0x5C */ public float MaxHeight;
        [NMS(Index = 11)]
        /* 0x60 */ public float MinHeight;
        [NMS(Index = 7)]
        /* 0x64 */ public int NumModelsToGenerate;
        [NMS(Index = 5)]
        /* 0x68 */ public int NumOverridesToGenerate;
        [NMS(Index = 6)]
        /* 0x6C */ public int NumOverridesToGenerateWaterworlds;
        [NMS(Index = 9, MxmlName = "OverrideRadius ")]
        /* 0x70 */ public float OverrideRadius;
        [NMS(Index = 13)]
        /* 0x74 */ public GcPlanetaryBuildingRestrictions PlanetRestrictions;
        [NMS(Index = 4)]
        /* 0x76 */ public bool EnabledWhenPlanetHasNoNPCs;
        [NMS(Index = 10)]
        /* 0x77 */ public bool GivesShelter;
        [NMS(Index = 14)]
        /* 0x78 */ public bool IgnoreParticlesInAABB;
    }
}
