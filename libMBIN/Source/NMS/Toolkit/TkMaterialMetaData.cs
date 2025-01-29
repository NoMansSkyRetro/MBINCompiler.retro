using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x5532C2440E35BF93, NameHash = 0xB36368E9)]
    public class TkMaterialMetaData : NMSTemplate
    {
        [NMS(Index = 121, MxmlName = "Wave One Amplitude")]
        /* 0x000 */ public Vector3f WaveOneAmplitude;
        [NMS(Index = 123, MxmlName = "Wave One Fall Off")]
        /* 0x010 */ public Vector3f WaveOneFallOff;
        [NMS(Index = 122, MxmlName = "Wave One Frequency")]
        /* 0x020 */ public Vector3f WaveOneFrequency;
        [NMS(Index = 125, MxmlName = "Wave Two Amplitude")]
        /* 0x030 */ public Vector3f WaveTwoAmplitude;
        [NMS(Index = 127, MxmlName = "Wave Two Fall Off")]
        /* 0x040 */ public Vector3f WaveTwoFallOff;
        [NMS(Index = 126, MxmlName = "Wave Two Frequency")]
        /* 0x050 */ public Vector3f WaveTwoFrequency;
        [NMS(Index = 128)]
        /* 0x060 */ public TkMaterialShaderMillData ShaderMillData;
        [NMS(Index = 31)]
        /* 0x378 */ public VariableSizeString DetailNormal;
        [NMS(Index = 0)]
        /* 0x388 */ public VariableSizeString ExternalMaterial;
        [NMS(Index = 27)]
        /* 0x398 */ public VariableSizeString ForceDiffuse;
        [NMS(Index = 30)]
        /* 0x3A8 */ public VariableSizeString ForceFeature;
        [NMS(Index = 29)]
        /* 0x3B8 */ public VariableSizeString ForceMask;
        [NMS(Index = 28)]
        /* 0x3C8 */ public VariableSizeString ForceNormal;
        [NMS(Index = 67)]
        /* 0x3D8 */ public float BillboardSphereFactor;
        [NMS(Index = 48, MxmlName = "Branch H Swing")]
        /* 0x3DC */ public float BranchHSwing;
        [NMS(Index = 49, MxmlName = "Branch Trunk Anim")]
        /* 0x3E0 */ public float BranchTrunkAnim;
        [NMS(Index = 47, MxmlName = "Branch V Swing")]
        /* 0x3E4 */ public float BranchVSwing;
        // size: 0x3
        public enum DecalNormalEnum : uint {
            None,
            Decal,
            Vertex,
        }
        [NMS(Index = 63)]
        /* 0x3E8 */ public DecalNormalEnum DecalNormal;
        [NMS(Index = 34, MxmlName = "Detail Height Blend")]
        /* 0x3EC */ public float DetailHeightBlend;
        [NMS(Index = 35, MxmlName = "Detail Height Boost")]
        /* 0x3F0 */ public float DetailHeightBoost;
        [NMS(Index = 91)]
        /* 0x3F4 */ public float FurNoiseScale;
        [NMS(Index = 92)]
        /* 0x3F8 */ public float FurNoiseThickness;
        [NMS(Index = 93)]
        /* 0x3FC */ public float FurNoiseTurbulence;
        [NMS(Index = 94)]
        /* 0x400 */ public float FurTurbulenceScale;
        [NMS(Index = 20)]
        /* 0x404 */ public float Glow;
        [NMS(Index = 50, MxmlName = "Height Scale")]
        /* 0x408 */ public float HeightScale;
        [NMS(Index = 25, MxmlName = "IBL Weight")]
        /* 0x40C */ public float IBLWeight;
        [NMS(Index = 52, MxmlName = "Leaf Noise")]
        /* 0x410 */ public float LeafNoise;
        [NMS(Index = 53, MxmlName = "Leaf Swing")]
        /* 0x414 */ public float LeafSwing;
        [NMS(Index = 36, MxmlName = "Normal Tiling")]
        /* 0x418 */ public float NormalTiling;
        [NMS(Index = 115, MxmlName = "Num Steps")]
        /* 0x41C */ public int NumSteps;
        [NMS(Index = 114, MxmlName = "Parallax Depth")]
        /* 0x420 */ public float ParallaxDepth;
        [NMS(Index = 111, MxmlName = "Particle Refraction Brightness Multiplier")]
        /* 0x424 */ public float ParticleRefractionBrightnessMultiplier;
        [NMS(Index = 109, MxmlName = "Particle Refraction Strength X")]
        /* 0x428 */ public float ParticleRefractionStrengthX;
        [NMS(Index = 110, MxmlName = "Particle Refraction Strength Y")]
        /* 0x42C */ public float ParticleRefractionStrengthY;
        [NMS(Index = 112, MxmlName = "Particle Refraction Tint")]
        /* 0x430 */ public float ParticleRefractionTint;
        [NMS(Index = 87)]
        /* 0x434 */ public float ReactivityBias;
        [NMS(Index = 18)]
        /* 0x438 */ public float Reflectance;
        [NMS(Index = 106)]
        /* 0x43C */ public float Refraction;
        [NMS(Index = 107, MxmlName = "Refraction Index")]
        /* 0x440 */ public float RefractionIndex;
        [NMS(Index = 12)]
        /* 0x444 */ public float Roughness;
        // size: 0x7
        public enum ShaderEnum : uint {
            UberShader,
            Sky,
            Screen,
            UberHack,
            UIScreen,
            ShaderMillParticle,
            ShaderMillUber,
        }
        [NMS(Index = 1)]
        /* 0x448 */ public ShaderEnum Shader;
        [NMS(Index = 117, MxmlName = "Shadow Factor")]
        /* 0x44C */ public float ShadowFactor;
        [NMS(Index = 90)]
        /* 0x450 */ public float ShellsHeight;
        [NMS(Index = 56)]
        /* 0x454 */ public float SoftFadeStrength;
        [NMS(Index = 16)]
        /* 0x458 */ public float Subsurface;
        [NMS(Index = 55)]
        /* 0x45C */ public float TerrainNormalFactor;
        [NMS(Index = 75)]
        /* 0x460 */ public float TessellationHeight;
        [NMS(Index = 3)]
        /* 0x464 */ public int TransparencyLayerID;
        [NMS(Index = 51, MxmlName = "Trunk Bend")]
        /* 0x468 */ public float TrunkBend;
        [NMS(Index = 101, MxmlName = "UV Frame Time")]
        /* 0x46C */ public float UVFrameTime;
        [NMS(Index = 104, MxmlName = "UV Num Tiles X")]
        /* 0x470 */ public float UVNumTilesX;
        [NMS(Index = 105, MxmlName = "UV Num Tiles Y")]
        /* 0x474 */ public float UVNumTilesY;
        [NMS(Index = 99, MxmlName = "UV Scroll Normal X")]
        /* 0x478 */ public float UVScrollNormalX;
        [NMS(Index = 100, MxmlName = "UV Scroll Normal Y")]
        /* 0x47C */ public float UVScrollNormalY;
        [NMS(Index = 97, MxmlName = "UV Scroll X")]
        /* 0x480 */ public float UVScrollX;
        [NMS(Index = 98, MxmlName = "UV Scroll Y")]
        /* 0x484 */ public float UVScrollY;
        [NMS(Index = 120, MxmlName = "Wave One Speed")]
        /* 0x488 */ public float WaveOneSpeed;
        [NMS(Index = 124, MxmlName = "Wave Two Speed")]
        /* 0x48C */ public float WaveTwoSpeed;
        [NMS(Index = 26)]
        /* 0x490 */ public NMSString0x20 MaterialClass;
        [NMS(Index = 57)]
        /* 0x4B0 */ public bool AcuteAngleFadeOut;
        [NMS(Index = 4)]
        /* 0x4B1 */ public bool Additive;
        [NMS(Index = 44, MxmlName = "Alpha Cutout")]
        /* 0x4B2 */ public bool AlphaCutout;
        [NMS(Index = 80)]
        /* 0x4B3 */ public bool AlwaysOnTopUI;
        [NMS(Index = 74)]
        /* 0x4B4 */ public bool AnisotropicFilter;
        [NMS(Index = 22, MxmlName = "AO Map")]
        /* 0x4B5 */ public bool AOMap;
        [NMS(Index = 78)]
        /* 0x4B6 */ public bool BeforeUI;
        [NMS(Index = 23, MxmlName = "Bent Normals")]
        /* 0x4B7 */ public bool BentNormals;
        [NMS(Index = 64)]
        /* 0x4B8 */ public bool Billboard;
        [NMS(Index = 38, MxmlName = "Bright Edge")]
        /* 0x4B9 */ public bool BrightEdge;
        [NMS(Index = 39)]
        /* 0x4BA */ public bool CameraRelative;
        [NMS(Index = 10, MxmlName = "Cast Shadow")]
        /* 0x4BB */ public bool CastShadow;
        [NMS(Index = 58)]
        /* 0x4BC */ public bool ClampAmbientLight;
        [NMS(Index = 40)]
        /* 0x4BD */ public bool Colourisable;
        [NMS(Index = 41)]
        /* 0x4BE */ public bool ColourMask;
        [NMS(Index = 89)]
        /* 0x4BF */ public bool CreateFur;
        [NMS(Index = 61)]
        /* 0x4C0 */ public bool DecalDiffuse;
        [NMS(Index = 62)]
        /* 0x4C1 */ public bool DecalTerrainOnly;
        [NMS(Index = 79)]
        /* 0x4C2 */ public bool DepthMaskUI;
        [NMS(Index = 45, MxmlName = "Detailed Alpha Cutout")]
        /* 0x4C3 */ public bool DetailedAlphaCutout;
        [NMS(Index = 71)]
        /* 0x4C4 */ public bool DisableAmbient;
        [NMS(Index = 72)]
        /* 0x4C5 */ public bool DisablePostProcess;
        [NMS(Index = 6)]
        /* 0x4C6 */ public bool DisableZTest;
        [NMS(Index = 119, MxmlName = "Displacement Position Offset")]
        /* 0x4C7 */ public bool DisplacementPositionOffset;
        [NMS(Index = 118, MxmlName = "Displacement Wave")]
        /* 0x4C8 */ public bool DisplacementWave;
        [NMS(Index = 76)]
        /* 0x4C9 */ public bool Dissolve;
        [NMS(Index = 86)]
        /* 0x4CA */ public bool DoubleBufferGeometry;
        [NMS(Index = 59)]
        /* 0x4CB */ public bool DoubleSided;
        [NMS(Index = 60)]
        /* 0x4CC */ public bool DoubleSidedKeepNormals;
        [NMS(Index = 84)]
        /* 0x4CD */ public bool DrawToBloom;
        [NMS(Index = 85)]
        /* 0x4CE */ public bool DrawToLensFlare;
        [NMS(Index = 81)]
        /* 0x4CF */ public bool EnableLodFade;
        [NMS(Index = 43, MxmlName = "Feature Map")]
        /* 0x4D0 */ public bool FeatureMap;
        [NMS(Index = 7)]
        /* 0x4D1 */ public bool FullPrecisionPosition;
        [NMS(Index = 21, MxmlName = "Glow Mask")]
        /* 0x4D2 */ public bool GlowMask;
        [NMS(Index = 95, MxmlName = "High Quality Particle")]
        /* 0x4D3 */ public bool HighQualityParticle;
        [NMS(Index = 24, MxmlName = "Image Based Lighting")]
        /* 0x4D4 */ public bool ImageBasedLighting;
        [NMS(Index = 68)]
        /* 0x4D5 */ public bool Imposter;
        [NMS(Index = 77)]
        /* 0x4D6 */ public bool InvertAlpha;
        [NMS(Index = 54)]
        /* 0x4D7 */ public bool MatchGroundColour;
        [NMS(Index = 66)]
        /* 0x4D8 */ public bool MergedMeshBillboard;
        [NMS(Index = 14)]
        /* 0x4D9 */ public bool Metallic;
        [NMS(Index = 15, MxmlName = "Metallic Mask")]
        /* 0x4DA */ public bool MetallicMask;
        [NMS(Index = 42)]
        /* 0x4DB */ public bool Multitexture;
        [NMS(Index = 113, MxmlName = "Parallax Mapped")]
        /* 0x4DC */ public bool ParallaxMapped;
        [NMS(Index = 9, MxmlName = "Receive Shadow")]
        /* 0x4DD */ public bool ReceiveShadow;
        [NMS(Index = 19, MxmlName = "Reflectance Mask")]
        /* 0x4DE */ public bool ReflectanceMask;
        [NMS(Index = 83)]
        /* 0x4DF */ public bool ReflectionProbe;
        [NMS(Index = 108, MxmlName = "Refraction Mask")]
        /* 0x4E0 */ public bool RefractionMask;
        [NMS(Index = 65)]
        /* 0x4E1 */ public bool RotateAroundAt;
        [NMS(Index = 13, MxmlName = "Roughness Mask")]
        /* 0x4E2 */ public bool RoughnessMask;
        [NMS(Index = 69)]
        /* 0x4E3 */ public bool ScanEffect;
        [NMS(Index = 82)]
        /* 0x4E4 */ public bool ScreenSpaceReflections;
        [NMS(Index = 116, MxmlName = "Self Shadow")]
        /* 0x4E5 */ public bool SelfShadow;
        [NMS(Index = 11, MxmlName = "Shadow Only")]
        /* 0x4E6 */ public bool ShadowOnly;
        [NMS(Index = 88)]
        /* 0x4E7 */ public bool SimulatedCloth;
        [NMS(Index = 17, MxmlName = "Subsurface Mask")]
        /* 0x4E8 */ public bool SubsurfaceMask;
        [NMS(Index = 2)]
        /* 0x4E9 */ public bool Transparent;
        [NMS(Index = 37, MxmlName = "UI Surface")]
        /* 0x4EA */ public bool UISurface;
        [NMS(Index = 8)]
        /* 0x4EB */ public bool Unlit;
        [NMS(Index = 102, MxmlName = "UV Animation")]
        /* 0x4EC */ public bool UVAnimation;
        [NMS(Index = 96, MxmlName = "UV Scrolling")]
        /* 0x4ED */ public bool UVScrolling;
        [NMS(Index = 103, MxmlName = "UV Tile Alts")]
        /* 0x4EE */ public bool UVTileAlts;
        [NMS(Index = 32, MxmlName = "Vertex Alpha  AO")]
        /* 0x4EF */ public bool VertexAlphaAO;
        [NMS(Index = 5, MxmlName = "Vertex Colour")]
        /* 0x4F0 */ public bool VertexColour;
        [NMS(Index = 33, MxmlName = "Vertex Detail Blend")]
        /* 0x4F1 */ public bool VertexDetailBlend;
        [NMS(Index = 73)]
        /* 0x4F2 */ public bool WarpedDiffuseLighting;
        [NMS(Index = 46)]
        /* 0x4F3 */ public bool Wind;
        [NMS(Index = 70)]
        /* 0x4F4 */ public bool WriteLogZ;
    }
}
