using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x78B9E38681F59389, NameHash = 0xB36368E9)]
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
        [NMS(Index = 33)]
        /* 0x2F8 */ public VariableSizeString DetailNormal;
        [NMS(Index = 0)]
        /* 0x308 */ public VariableSizeString ExternalMaterial;
        [NMS(Index = 29)]
        /* 0x318 */ public VariableSizeString ForceDiffuse;
        [NMS(Index = 32)]
        /* 0x328 */ public VariableSizeString ForceFeature;
        [NMS(Index = 31)]
        /* 0x338 */ public VariableSizeString ForceMask;
        [NMS(Index = 30)]
        /* 0x348 */ public VariableSizeString ForceNormal;
        [NMS(Index = 63)]
        /* 0x358 */ public float BillboardSphereFactor;
        [NMS(Index = 49, MxmlName = "Branch H Swing")]
        /* 0x35C */ public float BranchHSwing;
        [NMS(Index = 50, MxmlName = "Branch Trunk Anim")]
        /* 0x360 */ public float BranchTrunkAnim;
        [NMS(Index = 48, MxmlName = "Branch V Swing")]
        /* 0x364 */ public float BranchVSwing;
        [NMS(Index = 36, MxmlName = "Detail Height Blend")]
        /* 0x368 */ public float DetailHeightBlend;
        [NMS(Index = 37, MxmlName = "Detail Height Boost")]
        /* 0x36C */ public float DetailHeightBoost;
        [NMS(Index = 91)]
        /* 0x370 */ public float FurNoiseScale;
        [NMS(Index = 92)]
        /* 0x374 */ public float FurNoiseThickness;
        [NMS(Index = 93)]
        /* 0x378 */ public float FurNoiseTurbulence;
        [NMS(Index = 94)]
        /* 0x37C */ public float FurTurbulenceScale;
        [NMS(Index = 21)]
        /* 0x380 */ public float Glow;
        [NMS(Index = 51, MxmlName = "Height Scale")]
        /* 0x384 */ public float HeightScale;
        [NMS(Index = 26, MxmlName = "IBL Weight")]
        /* 0x388 */ public float IBLWeight;
        [NMS(Index = 53, MxmlName = "Leaf Noise")]
        /* 0x38C */ public float LeafNoise;
        [NMS(Index = 54, MxmlName = "Leaf Swing")]
        /* 0x390 */ public float LeafSwing;
        [NMS(Index = 38, MxmlName = "Normal Tiling")]
        /* 0x394 */ public float NormalTiling;
        [NMS(Index = 115, MxmlName = "Num Steps")]
        /* 0x398 */ public int NumSteps;
        [NMS(Index = 114, MxmlName = "Parallax Depth")]
        /* 0x39C */ public float ParallaxDepth;
        [NMS(Index = 111, MxmlName = "Particle Refraction Brightness Multiplier")]
        /* 0x3A0 */ public float ParticleRefractionBrightnessMultiplier;
        [NMS(Index = 109, MxmlName = "Particle Refraction Strength X")]
        /* 0x3A4 */ public float ParticleRefractionStrengthX;
        [NMS(Index = 110, MxmlName = "Particle Refraction Strength Y")]
        /* 0x3A8 */ public float ParticleRefractionStrengthY;
        [NMS(Index = 112, MxmlName = "Particle Refraction Tint")]
        /* 0x3AC */ public float ParticleRefractionTint;
        [NMS(Index = 81)]
        /* 0x3B0 */ public float ReactivityBias;
        [NMS(Index = 19)]
        /* 0x3B4 */ public float Reflectance;
        [NMS(Index = 106)]
        /* 0x3B8 */ public float Refraction;
        [NMS(Index = 107, MxmlName = "Refraction Index")]
        /* 0x3BC */ public float RefractionIndex;
        [NMS(Index = 13)]
        /* 0x3C0 */ public float Roughness;
        // size: 0x8
        public enum ShaderEnum : uint {
            UberShader,
            Sky,
            Screen,
            UberHack,
            UIScreen,
            Decal,
            Particle,
            ReflectionProbe,
        }
        [NMS(Index = 1)]
        /* 0x3C4 */ public ShaderEnum Shader;
        [NMS(Index = 117, MxmlName = "Shadow Factor")]
        /* 0x3C8 */ public float ShadowFactor;
        [NMS(Index = 90)]
        /* 0x3CC */ public float ShellsHeight;
        [NMS(Index = 57)]
        /* 0x3D0 */ public float SoftFadeStrength;
        [NMS(Index = 17)]
        /* 0x3D4 */ public float Subsurface;
        [NMS(Index = 56)]
        /* 0x3D8 */ public float TerrainNormalFactor;
        [NMS(Index = 69)]
        /* 0x3DC */ public float TessellationHeight;
        [NMS(Index = 83)]
        /* 0x3E0 */ public float TopBlend;
        [NMS(Index = 84)]
        /* 0x3E4 */ public float TopBlendOffset;
        [NMS(Index = 85)]
        /* 0x3E8 */ public float TopBlendSharpness;
        [NMS(Index = 4)]
        /* 0x3EC */ public int TransparencyLayerID;
        [NMS(Index = 52, MxmlName = "Trunk Bend")]
        /* 0x3F0 */ public float TrunkBend;
        [NMS(Index = 101, MxmlName = "UV Frame Time")]
        /* 0x3F4 */ public float UVFrameTime;
        [NMS(Index = 104, MxmlName = "UV Num Tiles X")]
        /* 0x3F8 */ public float UVNumTilesX;
        [NMS(Index = 105, MxmlName = "UV Num Tiles Y")]
        /* 0x3FC */ public float UVNumTilesY;
        [NMS(Index = 99, MxmlName = "UV Scroll Normal X")]
        /* 0x400 */ public float UVScrollNormalX;
        [NMS(Index = 100, MxmlName = "UV Scroll Normal Y")]
        /* 0x404 */ public float UVScrollNormalY;
        [NMS(Index = 97, MxmlName = "UV Scroll X")]
        /* 0x408 */ public float UVScrollX;
        [NMS(Index = 98, MxmlName = "UV Scroll Y")]
        /* 0x40C */ public float UVScrollY;
        [NMS(Index = 120, MxmlName = "Wave One Speed")]
        /* 0x410 */ public float WaveOneSpeed;
        [NMS(Index = 124, MxmlName = "Wave Two Speed")]
        /* 0x414 */ public float WaveTwoSpeed;
        [NMS(Index = 28)]
        /* 0x418 */ public NMSString0x20 MaterialClass;
        [NMS(Index = 5)]
        /* 0x438 */ public bool Additive;
        [NMS(Index = 46, MxmlName = "Alpha Cutout")]
        /* 0x439 */ public bool AlphaCutout;
        [NMS(Index = 74)]
        /* 0x43A */ public bool AlwaysOnTopUI;
        [NMS(Index = 68)]
        /* 0x43B */ public bool AnisotropicFilter;
        [NMS(Index = 23, MxmlName = "AO Map")]
        /* 0x43C */ public bool AOMap;
        [NMS(Index = 72)]
        /* 0x43D */ public bool BeforeUI;
        [NMS(Index = 24, MxmlName = "Bent Normals")]
        /* 0x43E */ public bool BentNormals;
        [NMS(Index = 60)]
        /* 0x43F */ public bool Billboard;
        [NMS(Index = 40, MxmlName = "Bright Edge")]
        /* 0x440 */ public bool BrightEdge;
        [NMS(Index = 41)]
        /* 0x441 */ public bool CameraRelative;
        [NMS(Index = 11, MxmlName = "Cast Shadow")]
        /* 0x442 */ public bool CastShadow;
        [NMS(Index = 42)]
        /* 0x443 */ public bool Colourisable;
        [NMS(Index = 43)]
        /* 0x444 */ public bool ColourMask;
        [NMS(Index = 89)]
        /* 0x445 */ public bool CreateFur;
        [NMS(Index = 87)]
        /* 0x446 */ public bool DecalNormalOnly;
        [NMS(Index = 88)]
        /* 0x447 */ public bool DecalTerrainOnly;
        [NMS(Index = 73)]
        /* 0x448 */ public bool DepthMaskUI;
        [NMS(Index = 67)]
        /* 0x449 */ public bool DisablePostProcess;
        [NMS(Index = 7)]
        /* 0x44A */ public bool DisableZTest;
        [NMS(Index = 119, MxmlName = "Displacement Position Offset")]
        /* 0x44B */ public bool DisplacementPositionOffset;
        [NMS(Index = 118, MxmlName = "Displacement Wave")]
        /* 0x44C */ public bool DisplacementWave;
        [NMS(Index = 70)]
        /* 0x44D */ public bool Dissolve;
        [NMS(Index = 80)]
        /* 0x44E */ public bool DoubleBufferGeometry;
        [NMS(Index = 58)]
        /* 0x44F */ public bool DoubleSided;
        [NMS(Index = 59)]
        /* 0x450 */ public bool DoubleSidedKeepNormals;
        [NMS(Index = 78)]
        /* 0x451 */ public bool DrawToBloom;
        [NMS(Index = 79)]
        /* 0x452 */ public bool DrawToLensFlare;
        [NMS(Index = 75)]
        /* 0x453 */ public bool EnableLodFade;
        [NMS(Index = 45, MxmlName = "Feature Map")]
        /* 0x454 */ public bool FeatureMap;
        [NMS(Index = 8)]
        /* 0x455 */ public bool FullPrecisionPosition;
        [NMS(Index = 22, MxmlName = "Glow Mask")]
        /* 0x456 */ public bool GlowMask;
        [NMS(Index = 95, MxmlName = "High Quality Particle")]
        /* 0x457 */ public bool HighQualityParticle;
        [NMS(Index = 25, MxmlName = "Image Based Lighting")]
        /* 0x458 */ public bool ImageBasedLighting;
        [NMS(Index = 64)]
        /* 0x459 */ public bool Imposter;
        [NMS(Index = 71)]
        /* 0x45A */ public bool InvertAlpha;
        [NMS(Index = 27, MxmlName = "Light Layers")]
        /* 0x45B */ public TkLightLayer LightLayers;
        [NMS(Index = 55)]
        /* 0x45C */ public bool MatchGroundColour;
        [NMS(Index = 62)]
        /* 0x45D */ public bool MergedMeshBillboard;
        [NMS(Index = 15)]
        /* 0x45E */ public bool Metallic;
        [NMS(Index = 16, MxmlName = "Metallic Mask")]
        /* 0x45F */ public bool MetallicMask;
        [NMS(Index = 44)]
        /* 0x460 */ public bool Multitexture;
        [NMS(Index = 113, MxmlName = "Parallax Mapped")]
        /* 0x461 */ public bool ParallaxMapped;
        [NMS(Index = 10, MxmlName = "Receive Shadow")]
        /* 0x462 */ public bool ReceiveShadow;
        [NMS(Index = 20, MxmlName = "Reflectance Mask")]
        /* 0x463 */ public bool ReflectanceMask;
        [NMS(Index = 77)]
        /* 0x464 */ public bool ReflectionProbe;
        [NMS(Index = 108, MxmlName = "Refraction Mask")]
        /* 0x465 */ public bool RefractionMask;
        [NMS(Index = 61)]
        /* 0x466 */ public bool RotateAroundAt;
        [NMS(Index = 14, MxmlName = "Roughness Mask")]
        /* 0x467 */ public bool RoughnessMask;
        [NMS(Index = 65)]
        /* 0x468 */ public bool ScanEffect;
        [NMS(Index = 76)]
        /* 0x469 */ public bool ScreenSpaceReflections;
        [NMS(Index = 116, MxmlName = "Self Shadow")]
        /* 0x46A */ public bool SelfShadow;
        [NMS(Index = 12, MxmlName = "Shadow Only")]
        /* 0x46B */ public bool ShadowOnly;
        [NMS(Index = 82)]
        /* 0x46C */ public bool SimulatedCloth;
        [NMS(Index = 18, MxmlName = "Subsurface Mask")]
        /* 0x46D */ public bool SubsurfaceMask;
        [NMS(Index = 86)]
        /* 0x46E */ public bool TopBlendFlip;
        [NMS(Index = 3)]
        /* 0x46F */ public bool Transparent;
        [NMS(Index = 39, MxmlName = "UI Surface")]
        /* 0x470 */ public bool UISurface;
        [NMS(Index = 9)]
        /* 0x471 */ public bool Unlit;
        [NMS(Index = 2)]
        /* 0x472 */ public bool UseShaderMill;
        [NMS(Index = 102, MxmlName = "UV Animation")]
        /* 0x473 */ public bool UVAnimation;
        [NMS(Index = 96, MxmlName = "UV Scrolling")]
        /* 0x474 */ public bool UVScrolling;
        [NMS(Index = 103, MxmlName = "UV Tile Alts")]
        /* 0x475 */ public bool UVTileAlts;
        [NMS(Index = 34, MxmlName = "Vertex Alpha  AO")]
        /* 0x476 */ public bool VertexAlphaAO;
        [NMS(Index = 6, MxmlName = "Vertex Colour")]
        /* 0x477 */ public bool VertexColour;
        [NMS(Index = 35, MxmlName = "Vertex Detail Blend")]
        /* 0x478 */ public bool VertexDetailBlend;
        [NMS(Index = 47)]
        /* 0x479 */ public bool Wind;
        [NMS(Index = 66)]
        /* 0x47A */ public bool WriteLogZ;
    }
}
