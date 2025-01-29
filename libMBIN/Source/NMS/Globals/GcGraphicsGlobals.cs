using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x43B8DE88B879B209, NameHash = 0xEADD2E75)]
    public class GcGraphicsGlobals : NMSTemplate
    {
        [NMS(Index = 52)]
        /* 0x000 */ public TkImGuiSettings ImGui;
        [NMS(Index = 256, Size = 0x4, EnumType = typeof(TkGraphicsDetailTypes.GraphicDetailEnum))]
        /* 0x190 */ public Vector4f[] ShellsSettings;
        [NMS(Index = 251, Size = 0x4, EnumType = typeof(TkGraphicsDetailTypes.GraphicDetailEnum))]
        /* 0x1D0 */ public Vector4f[] TessSettings;
        [NMS(Index = 6)]
        /* 0x210 */ public GcLightShaftProperties LightShaftProperties;
        [NMS(Index = 7)]
        /* 0x240 */ public GcLightShaftProperties StormLightShaftProperties;
        [NMS(Index = 178)]
        /* 0x270 */ public Vector4f LensParams;
        [NMS(Index = 177)]
        /* 0x280 */ public Vector4f MipLevelDebug;
        [NMS(Index = 49)]
        /* 0x290 */ public Colour ScanColour;
        [NMS(Index = 84)]
        /* 0x2A0 */ public Vector4f ShadowBias;
        [NMS(Index = 79)]
        /* 0x2B0 */ public Vector4f ShadowSplit;
        [NMS(Index = 83)]
        /* 0x2C0 */ public Vector4f ShadowSplitCameraView;
        [NMS(Index = 80)]
        /* 0x2D0 */ public Vector4f ShadowSplitShip;
        [NMS(Index = 81)]
        /* 0x2E0 */ public Vector4f ShadowSplitSpace;
        [NMS(Index = 82)]
        /* 0x2F0 */ public Vector4f ShadowSplitStation;
        [NMS(Index = 250)]
        /* 0x300 */ public Vector4f TaaSettings;
        [NMS(Index = 254)]
        /* 0x310 */ public Vector4f TerrainMipDistanceHigh;
        [NMS(Index = 252)]
        /* 0x320 */ public Vector4f TerrainMipDistanceLow;
        [NMS(Index = 253)]
        /* 0x330 */ public Vector4f TerrainMipDistanceMed;
        [NMS(Index = 255)]
        /* 0x340 */ public Vector4f TerrainMipDistanceUlt;
        [NMS(Index = 53)]
        /* 0x350 */ public Colour UIColour;
        [NMS(Index = 54)]
        /* 0x360 */ public Colour UIShipColour;
        [NMS(Index = 180)]
        /* 0x370 */ public Colour VerticalColourBottom;
        [NMS(Index = 179)]
        /* 0x380 */ public Colour VerticalColourTop;
        [NMS(Index = 181)]
        /* 0x390 */ public Vector4f VerticalGradient;
        [NMS(Index = 284)]
        /* 0x3A0 */ public List<int> CascadeRenderSequence;
        [NMS(Index = 303, Size = 0x4, EnumType = typeof(TkGraphicsDetailTypes.GraphicDetailEnum))]
        /* 0x3B0 */ public TkGraphicsDetailPreset[] GraphicsDetailPresetsPC;
        [NMS(Index = 317)]
        /* 0x540 */ public TkGraphicsDetailPreset GraphicsDetailPresetiOS;
        [NMS(Index = 316)]
        /* 0x5A4 */ public TkGraphicsDetailPreset GraphicsDetailPresetMacOS;
        [NMS(Index = 311)]
        /* 0x608 */ public TkGraphicsDetailPreset GraphicsDetailPresetNX64Handheld;
        [NMS(Index = 310)]
        /* 0x66C */ public TkGraphicsDetailPreset GraphicsDetailPresetOberon;
        [NMS(Index = 304)]
        /* 0x6D0 */ public TkGraphicsDetailPreset GraphicsDetailPresetPS4;
        [NMS(Index = 306)]
        /* 0x734 */ public TkGraphicsDetailPreset GraphicsDetailPresetPS4Pro;
        [NMS(Index = 307)]
        /* 0x798 */ public TkGraphicsDetailPreset GraphicsDetailPresetPS4ProVR;
        [NMS(Index = 305)]
        /* 0x7FC */ public TkGraphicsDetailPreset GraphicsDetailPresetPS4VR;
        [NMS(Index = 312)]
        /* 0x860 */ public TkGraphicsDetailPreset GraphicsDetailPresetPS5;
        [NMS(Index = 314)]
        /* 0x8C4 */ public TkGraphicsDetailPreset GraphicsDetailPresetPS5VR;
        [NMS(Index = 313)]
        /* 0x928 */ public TkGraphicsDetailPreset GraphicsDetailPresetTrinity;
        [NMS(Index = 315)]
        /* 0x98C */ public TkGraphicsDetailPreset GraphicsDetailPresetTrinityVR;
        [NMS(Index = 308)]
        /* 0x9F0 */ public TkGraphicsDetailPreset GraphicsDetailPresetXB1;
        [NMS(Index = 309)]
        /* 0xA54 */ public TkGraphicsDetailPreset GraphicsDetailPresetXB1X;
        [NMS(Index = 319, Size = 0x4, EnumType = typeof(TkGraphicsDetailTypes.GraphicDetailEnum))]
        /* 0xAB8 */ public float[] VariableUpdatePeriodModifers;
        [NMS(Index = 203)]
        /* 0xAC8 */ public Vector2f WindDir1;
        [NMS(Index = 204)]
        /* 0xAD0 */ public Vector2f WindDir2;
        [NMS(Index = 230)]
        /* 0xAD8 */ public float AlphaCutoutMax;
        [NMS(Index = 229)]
        /* 0xADC */ public float AlphaCutoutMin;
        [NMS(Index = 205)]
        /* 0xAE0 */ public float AtmosphereSize;
        [NMS(Index = 12)]
        /* 0xAE4 */ public float Brightness;
        [NMS(Index = 13)]
        /* 0xAE8 */ public float Contrast;
        [NMS(Index = 70)]
        /* 0xAEC */ public float DirectionLightFOV;
        [NMS(Index = 69)]
        /* 0xAF0 */ public float DirectionLightRadius;
        [NMS(Index = 71)]
        /* 0xAF4 */ public float DirectionLightShadowBias;
        [NMS(Index = 113)]
        /* 0xAF8 */ public float DOFAmountManual;
        [NMS(Index = 117)]
        /* 0xAFC */ public float DOFAmountManualFull;
        [NMS(Index = 115)]
        /* 0xB00 */ public float DOFAmountManualFullIndoor;
        [NMS(Index = 116)]
        /* 0xB04 */ public float DOFAmountManualLight;
        [NMS(Index = 114)]
        /* 0xB08 */ public float DOFAmountManualLightIndoor;
        [NMS(Index = 131)]
        /* 0xB0C */ public float DOFAutoFarAmount;
        [NMS(Index = 133)]
        /* 0xB10 */ public float DOFAutoFarFarPlane;
        [NMS(Index = 132)]
        /* 0xB14 */ public float DOFAutoFarFarPlaneFade;
        [NMS(Index = 134)]
        /* 0xB18 */ public float DOFAutoFarNearPlane;
        [NMS(Index = 120)]
        /* 0xB1C */ public float DOFFarFadeDistance;
        [NMS(Index = 122)]
        /* 0xB20 */ public float DOFFarFadeDistanceCave;
        [NMS(Index = 138)]
        /* 0xB24 */ public float DOFFarFadeDistanceInteraction;
        [NMS(Index = 130)]
        /* 0xB28 */ public float DOFFarFadeDistanceManual;
        [NMS(Index = 129)]
        /* 0xB2C */ public float DOFFarFadeDistanceManualIndoor;
        [NMS(Index = 124)]
        /* 0xB30 */ public float DOFFarFadeDistanceSpace;
        [NMS(Index = 127)]
        /* 0xB34 */ public float DOFFarFadeDistanceWater;
        [NMS(Index = 112)]
        /* 0xB38 */ public float DOFFarPlane;
        [NMS(Index = 121)]
        /* 0xB3C */ public float DOFFarPlaneCave;
        [NMS(Index = 137)]
        /* 0xB40 */ public float DOFFarPlaneInteraction;
        [NMS(Index = 128)]
        /* 0xB44 */ public float DOFFarPlaneManual;
        [NMS(Index = 123)]
        /* 0xB48 */ public float DOFFarPlaneSpace;
        [NMS(Index = 126)]
        /* 0xB4C */ public float DOFFarPlaneWater;
        [NMS(Index = 125)]
        /* 0xB50 */ public float DOFFarStrengthWater;
        [NMS(Index = 136)]
        /* 0xB54 */ public float DOFNearAdjustInteraction;
        [NMS(Index = 118)]
        /* 0xB58 */ public float DOFNearFadeDistance;
        [NMS(Index = 119)]
        /* 0xB5C */ public float DOFNearFadeDistanceManual;
        [NMS(Index = 135)]
        /* 0xB60 */ public float DOFNearMinInteraction;
        [NMS(Index = 111)]
        /* 0xB64 */ public float DOFNearPlane;
        [NMS(Index = 63)]
        /* 0xB68 */ public float FarClipDistance;
        [NMS(Index = 213)]
        /* 0xB6C */ public float FoliageSaturationMax;
        [NMS(Index = 212)]
        /* 0xB70 */ public float FoliageSaturationMin;
        [NMS(Index = 215)]
        /* 0xB74 */ public float FoliageValueMax;
        [NMS(Index = 214)]
        /* 0xB78 */ public float FoliageValueMin;
        [NMS(Index = 241)]
        /* 0xB7C */ public float FrustumJitterAmount;
        [NMS(Index = 242)]
        /* 0xB80 */ public float FrustumJitterAmountDLSS;
        [NMS(Index = 217)]
        /* 0xB84 */ public float GrassSaturationMax;
        [NMS(Index = 216)]
        /* 0xB88 */ public float GrassSaturationMin;
        [NMS(Index = 219)]
        /* 0xB8C */ public float GrassValueMax;
        [NMS(Index = 218)]
        /* 0xB90 */ public float GrassValueMin;
        [NMS(Index = 3, MxmlName = "HBAO Bias")]
        /* 0xB94 */ public float HBAOBias;
        [NMS(Index = 5, MxmlName = "HBAO Intensity")]
        /* 0xB98 */ public float HBAOIntensity;
        [NMS(Index = 4, MxmlName = "HBAO Radius")]
        /* 0xB9C */ public float HBAORadius;
        [NMS(Index = 92)]
        /* 0xBA0 */ public float HDRExposure;
        [NMS(Index = 104)]
        /* 0xBA4 */ public float HDRExposureCave;
        [NMS(Index = 93)]
        /* 0xBA8 */ public float HDRGamma;
        [NMS(Index = 94)]
        /* 0xBAC */ public float HDRLutExposure;
        [NMS(Index = 95)]
        /* 0xBB0 */ public float HDRLutGamma;
        [NMS(Index = 96)]
        /* 0xBB4 */ public float HDRLutToe;
        [NMS(Index = 98)]
        /* 0xBB8 */ public float HDROffset;
        [NMS(Index = 106)]
        /* 0xBBC */ public float HDROffsetCave;
        [NMS(Index = 97)]
        /* 0xBC0 */ public float HDRThreshold;
        [NMS(Index = 105)]
        /* 0xBC4 */ public float HDRThresholdCave;
        [NMS(Index = 61)]
        /* 0xBC8 */ public float HUDDistance;
        [NMS(Index = 60)]
        /* 0xBCC */ public float HUDMotionPos;
        [NMS(Index = 57)]
        /* 0xBD0 */ public float HUDMotionPosSpring;
        [NMS(Index = 58)]
        /* 0xBD4 */ public float HUDMotionX;
        [NMS(Index = 55)]
        /* 0xBD8 */ public float HUDMotionXSpring;
        [NMS(Index = 59)]
        /* 0xBDC */ public float HUDMotionY;
        [NMS(Index = 56)]
        /* 0xBE0 */ public float HUDMotionYSpring;
        [NMS(Index = 209)]
        /* 0xBE4 */ public float HueVariance;
        [NMS(Index = 329)]
        /* 0xBE8 */ public float IblContrastBiasAmount;
        [NMS(Index = 330)]
        /* 0xBEC */ public float IblDiffuseShadowAmount;
        [NMS(Index = 332)]
        /* 0xBF0 */ public float IblSpecularShadowAmount;
        [NMS(Index = 331)]
        /* 0xBF4 */ public float IblTransmissiveShadowAmount;
        [NMS(Index = 102)]
        /* 0xBF8 */ public float LensDirt;
        [NMS(Index = 110)]
        /* 0xBFC */ public float LensDirtCave;
        [NMS(Index = 100)]
        /* 0xC00 */ public float LensOffset;
        [NMS(Index = 108)]
        /* 0xC04 */ public float LensOffsetCave;
        [NMS(Index = 101)]
        /* 0xC08 */ public float LensScale;
        [NMS(Index = 109)]
        /* 0xC0C */ public float LensScaleCave;
        [NMS(Index = 99)]
        /* 0xC10 */ public float LensThreshold;
        [NMS(Index = 107)]
        /* 0xC14 */ public float LensThresholdCave;
        [NMS(Index = 165)]
        /* 0xC18 */ public float LowHealthDesaturationIntensityMax;
        [NMS(Index = 164)]
        /* 0xC1C */ public float LowHealthDesaturationIntensityMin;
        [NMS(Index = 166)]
        /* 0xC20 */ public float LowHealthDesaturationIntensityTimeSinceHit;
        [NMS(Index = 168)]
        /* 0xC24 */ public float LowHealthFadeInTime;
        [NMS(Index = 169)]
        /* 0xC28 */ public float LowHealthFadeOutTime;
        [NMS(Index = 167)]
        /* 0xC2C */ public float LowHealthOverlayIntensity;
        [NMS(Index = 171)]
        /* 0xC30 */ public float LowHealthPulseRateFullShield;
        [NMS(Index = 170)]
        /* 0xC34 */ public float LowHealthPulseRateLowShield;
        [NMS(Index = 173)]
        /* 0xC38 */ public float LowHealthStrengthFullShield;
        [NMS(Index = 172)]
        /* 0xC3C */ public float LowHealthStrengthLowShield;
        [NMS(Index = 163)]
        /* 0xC40 */ public float LowHealthVignetteEnd;
        [NMS(Index = 162)]
        /* 0xC44 */ public float LowHealthVignetteStart;
        [NMS(Index = 0)]
        /* 0xC48 */ public float LUTDistanceFlightMultiplier;
        [NMS(Index = 234)]
        /* 0xC4C */ public float MaxParticleRenderRange;
        [NMS(Index = 235)]
        /* 0xC50 */ public float MaxParticleRenderRangeSpace;
        [NMS(Index = 227)]
        /* 0xC54 */ public float MaxSpaceFogStrength;
        [NMS(Index = 282)]
        /* 0xC58 */ public float MinPixelSizeOfObjectsInShadowsCockpitOnPlanet;
        [NMS(Index = 281)]
        /* 0xC5C */ public float MinPixelSizeOfObjectsInShadowsPlanet;
        [NMS(Index = 280)]
        /* 0xC60 */ public float MinPixelSizeOfObjectsInShadowsSpace;
        [NMS(Index = 43)]
        /* 0xC64 */ public float ModelRendererLightIntensity;
        [NMS(Index = 237)]
        /* 0xC68 */ public float MotionBlurShutterAngle;
        [NMS(Index = 236)]
        /* 0xC6C */ public float MotionBlurShutterSpeed;
        [NMS(Index = 293)]
        /* 0xC70 */ public float MotionBlurThresholdDefault;
        [NMS(Index = 291)]
        /* 0xC74 */ public float MotionBlurThresholdInVehicle;
        [NMS(Index = 290)]
        /* 0xC78 */ public float MotionBlurThresholdOnFoot;
        [NMS(Index = 292)]
        /* 0xC7C */ public float MotionBlurThresholdSpace;
        [NMS(Index = 62)]
        /* 0xC80 */ public float NearClipDistance;
        [NMS(Index = 21)]
        /* 0xC84 */ public float New_BounceLightIntensity;
        [NMS(Index = 20)]
        /* 0xC88 */ public float New_BounceLightPower;
        [NMS(Index = 19)]
        /* 0xC8C */ public float New_BounceLightWarp;
        [NMS(Index = 26)]
        /* 0xC90 */ public float New_SideRimColourMixer;
        [NMS(Index = 25)]
        /* 0xC94 */ public float New_SideRimWarp;
        [NMS(Index = 24)]
        /* 0xC98 */ public float New_SkyLightIntensity;
        [NMS(Index = 23)]
        /* 0xC9C */ public float New_SkyLightPower;
        [NMS(Index = 22)]
        /* 0xCA0 */ public float New_SkyLightWarp;
        [NMS(Index = 28)]
        /* 0xCA4 */ public float New_TopRimColourMixer;
        [NMS(Index = 30)]
        /* 0xCA8 */ public float New_TopRimIntensity;
        [NMS(Index = 29)]
        /* 0xCAC */ public float New_TopRimPower;
        [NMS(Index = 27)]
        /* 0xCB0 */ public float New_TopRimWarp;
        [NMS(Index = 296)]
        /* 0xCB4 */ public float NoFocusMaxFPS;
        [NMS(Index = 33)]
        /* 0xCB8 */ public float Old_BounceLightIntensity;
        [NMS(Index = 32)]
        /* 0xCBC */ public float Old_BounceLightPower;
        [NMS(Index = 31)]
        /* 0xCC0 */ public float Old_BounceLightWarp;
        [NMS(Index = 38)]
        /* 0xCC4 */ public float Old_SideRimColourMixer;
        [NMS(Index = 37)]
        /* 0xCC8 */ public float Old_SideRimWarp;
        [NMS(Index = 36)]
        /* 0xCCC */ public float Old_SkyLightIntensity;
        [NMS(Index = 35)]
        /* 0xCD0 */ public float Old_SkyLightPower;
        [NMS(Index = 34)]
        /* 0xCD4 */ public float Old_SkyLightWarp;
        [NMS(Index = 40)]
        /* 0xCD8 */ public float Old_TopRimColourMixer;
        [NMS(Index = 42)]
        /* 0xCDC */ public float Old_TopRimIntensity;
        [NMS(Index = 41)]
        /* 0xCE0 */ public float Old_TopRimPower;
        [NMS(Index = 39)]
        /* 0xCE4 */ public float Old_TopRimWarp;
        [NMS(Index = 44)]
        /* 0xCE8 */ public float PetModelRendererLightIntensity;
        [NMS(Index = 326)]
        /* 0xCEC */ public float PhotoModeBloomGainMax;
        [NMS(Index = 324)]
        /* 0xCF0 */ public float PhotoModeBloomGainMedium;
        [NMS(Index = 320)]
        /* 0xCF4 */ public float PhotoModeBloomGainMin;
        [NMS(Index = 327)]
        /* 0xCF8 */ public float PhotoModeBloomThresholdMax;
        [NMS(Index = 325)]
        /* 0xCFC */ public float PhotoModeBloomThresholdMedium;
        [NMS(Index = 321)]
        /* 0xD00 */ public float PhotoModeBloomThresholdMin;
        [NMS(Index = 322)]
        /* 0xD04 */ public float PhotoModeDefaultBloomValue;
        [NMS(Index = 323)]
        /* 0xD08 */ public float PhotoModeMediumValue;
        [NMS(Index = 87)]
        /* 0xD0C */ public float QuantizeTime;
        [NMS(Index = 90)]
        /* 0xD10 */ public float QuantizeTimeCameraView;
        [NMS(Index = 88)]
        /* 0xD14 */ public float QuantizeTimeShip;
        [NMS(Index = 89)]
        /* 0xD18 */ public float QuantizeTimeSpace;
        [NMS(Index = 18)]
        /* 0xD1C */ public float Redo_BounceIntensity;
        [NMS(Index = 16)]
        /* 0xD20 */ public float Redo_LightIntensity;
        [NMS(Index = 17)]
        /* 0xD24 */ public float Redo_SkyIntensity;
        [NMS(Index = 228)]
        /* 0xD28 */ public float ReflectionStrength;
        [NMS(Index = 208)]
        /* 0xD2C */ public float RingAvoidanceSphereInterpTime;
        [NMS(Index = 207)]
        /* 0xD30 */ public float RingRadius;
        [NMS(Index = 206)]
        /* 0xD34 */ public float RingSize;
        [NMS(Index = 14)]
        /* 0xD38 */ public float Saturation;
        [NMS(Index = 210)]
        /* 0xD3C */ public float SaturationVariance;
        [NMS(Index = 48)]
        /* 0xD40 */ public float ScanAlpha;
        [NMS(Index = 186)]
        /* 0xD44 */ public float ScanBandWidth;
        [NMS(Index = 47)]
        /* 0xD48 */ public float ScanClamp;
        [NMS(Index = 188)]
        /* 0xD4C */ public float ScanDistance;
        [NMS(Index = 184)]
        /* 0xD50 */ public float ScanEffectSpeed;
        [NMS(Index = 182)]
        /* 0xD54 */ public float ScanFadeInTime;
        [NMS(Index = 183)]
        /* 0xD58 */ public float ScanFadeOutTime;
        [NMS(Index = 46)]
        /* 0xD5C */ public float ScanFresnel;
        [NMS(Index = 187)]
        /* 0xD60 */ public float ScanHeightScale;
        [NMS(Index = 189)]
        /* 0xD64 */ public float ScanHorizontalScale;
        [NMS(Index = 185)]
        /* 0xD68 */ public float ScanObjectFade;
        [NMS(Index = 86)]
        /* 0xD6C */ public float ShadowBillboardOffset;
        [NMS(Index = 72)]
        /* 0xD70 */ public float ShadowLength;
        [NMS(Index = 78)]
        /* 0xD74 */ public float ShadowLengthCameraView;
        [NMS(Index = 76)]
        /* 0xD78 */ public float ShadowLengthFreighter;
        [NMS(Index = 77)]
        /* 0xD7C */ public float ShadowLengthFreighterAbandoned;
        [NMS(Index = 73)]
        /* 0xD80 */ public float ShadowLengthShip;
        [NMS(Index = 74)]
        /* 0xD84 */ public float ShadowLengthSpace;
        [NMS(Index = 75)]
        /* 0xD88 */ public float ShadowLengthStation;
        [NMS(Index = 68)]
        /* 0xD8C */ public int ShadowMapSize;
        [NMS(Index = 300)]
        /* 0xD90 */ public float SharpenFilterAmount;
        [NMS(Index = 302)]
        /* 0xD94 */ public float SharpenFilterDepthFactorEnd;
        [NMS(Index = 301)]
        /* 0xD98 */ public float SharpenFilterDepthFactorStart;
        [NMS(Index = 174)]
        /* 0xD9C */ public float ShieldDownScanlineTime;
        [NMS(Index = 192)]
        /* 0xDA0 */ public float Single1ScanBandWidth;
        [NMS(Index = 193)]
        /* 0xDA4 */ public float Single1ScanEffectSpeed;
        [NMS(Index = 191)]
        /* 0xDA8 */ public float Single1ScanHeightScale;
        [NMS(Index = 195)]
        /* 0xDAC */ public float Single1ScanHorizontalScale;
        [NMS(Index = 194)]
        /* 0xDB0 */ public float Single1ScanObjectFade;
        [NMS(Index = 190)]
        /* 0xDB4 */ public float Single1ScanTime;
        [NMS(Index = 198)]
        /* 0xDB8 */ public float Single2ScanBandWidth;
        [NMS(Index = 199)]
        /* 0xDBC */ public float Single2ScanEffectSpeed;
        [NMS(Index = 197)]
        /* 0xDC0 */ public float Single2ScanHeightScale;
        [NMS(Index = 201)]
        /* 0xDC4 */ public float Single2ScanHorizontalScale;
        [NMS(Index = 200)]
        /* 0xDC8 */ public float Single2ScanObjectFade;
        [NMS(Index = 196)]
        /* 0xDCC */ public float Single2ScanTime;
        [NMS(Index = 221)]
        /* 0xDD0 */ public float SkySaturationMax;
        [NMS(Index = 220)]
        /* 0xDD4 */ public float SkySaturationMin;
        [NMS(Index = 223)]
        /* 0xDD8 */ public float SkyValueMax;
        [NMS(Index = 222)]
        /* 0xDDC */ public float SkyValueMin;
        [NMS(Index = 295)]
        /* 0xDE0 */ public float SpaceIBLBlendDistance;
        [NMS(Index = 294)]
        /* 0xDE4 */ public float SpaceIBLBlendStart;
        [NMS(Index = 225)]
        /* 0xDE8 */ public float SpaceMieFactor;
        [NMS(Index = 224)]
        /* 0xDEC */ public float SpaceScale;
        [NMS(Index = 226)]
        /* 0xDF0 */ public float SpaceSunFactor;
        [NMS(Index = 2, MxmlName = "Sun Light Blend Time")]
        /* 0xDF4 */ public float SunLightBlendTime;
        [NMS(Index = 1, MxmlName = "Sun Light Intensity")]
        /* 0xDF8 */ public float SunLightIntensity;
        [NMS(Index = 9)]
        /* 0xDFC */ public float SunRayDecay;
        [NMS(Index = 8)]
        /* 0xE00 */ public float SunRayDensity;
        [NMS(Index = 10)]
        /* 0xE04 */ public float SunRayExposure;
        [NMS(Index = 11)]
        /* 0xE08 */ public float SunRayWeight;
        [NMS(Index = 285)]
        /* 0xE0C */ public int SupersamplingLevel;
        [NMS(Index = 240)]
        /* 0xE10 */ public float TaaAccumDelay;
        [NMS(Index = 239)]
        /* 0xE14 */ public float TaaHighFreqConstant;
        [NMS(Index = 238)]
        /* 0xE18 */ public float TaaLowFreqConstant;
        [NMS(Index = 289)]
        /* 0xE1C */ public int TargetTextureMemUsageMB;
        [NMS(Index = 202)]
        /* 0xE20 */ public float TeleportFlashTime;
        [NMS(Index = 259)]
        /* 0xE24 */ public int TerrainAnisoHi;
        [NMS(Index = 257)]
        /* 0xE28 */ public int TerrainAnisoLow;
        [NMS(Index = 258)]
        /* 0xE2C */ public int TerrainAnisoMed;
        [NMS(Index = 260)]
        /* 0xE30 */ public int TerrainAnisoUlt;
        [NMS(Index = 267)]
        /* 0xE34 */ public int TerrainBlocksPerFrameHi;
        [NMS(Index = 265)]
        /* 0xE38 */ public int TerrainBlocksPerFrameLow;
        [NMS(Index = 266)]
        /* 0xE3C */ public int TerrainBlocksPerFrameMed;
        [NMS(Index = 273)]
        /* 0xE40 */ public int TerrainBlocksPerFrameOberon;
        [NMS(Index = 269)]
        /* 0xE44 */ public int TerrainBlocksPerFramePs430;
        [NMS(Index = 270)]
        /* 0xE48 */ public int TerrainBlocksPerFramePs460;
        [NMS(Index = 268)]
        /* 0xE4C */ public int TerrainBlocksPerFrameUlt;
        [NMS(Index = 271)]
        /* 0xE50 */ public int TerrainBlocksPerFrameXb130;
        [NMS(Index = 272)]
        /* 0xE54 */ public int TerrainBlocksPerFrameXb160;
        [NMS(Index = 261)]
        /* 0xE58 */ public int TerrainDroppedMipsLow;
        [NMS(Index = 262)]
        /* 0xE5C */ public int TerrainDroppedMipsMed;
        [NMS(Index = 263)]
        /* 0xE60 */ public float TerrainMipBiasLow;
        [NMS(Index = 264)]
        /* 0xE64 */ public float TerrainMipBiasMed;
        [NMS(Index = 91)]
        /* 0xE68 */ public float ToneMapExposure;
        [NMS(Index = 103)]
        /* 0xE6C */ public float ToneMapExposureCave;
        [NMS(Index = 211)]
        /* 0xE70 */ public float ValueVariance;
        [NMS(Index = 143)]
        /* 0xE74 */ public float VignetteEnd;
        [NMS(Index = 147)]
        /* 0xE78 */ public float VignetteEndMoveVR;
        [NMS(Index = 151)]
        /* 0xE7C */ public float VignetteEndMoveVRShip;
        [NMS(Index = 160)]
        /* 0xE80 */ public float VignetteEndRidingVR;
        [NMS(Index = 157)]
        /* 0xE84 */ public float VignetteEndTurnRidingVR;
        [NMS(Index = 145)]
        /* 0xE88 */ public float VignetteEndTurnVR;
        [NMS(Index = 154)]
        /* 0xE8C */ public float VignetteEndTurnVRShip;
        [NMS(Index = 142)]
        /* 0xE90 */ public float VignetteStart;
        [NMS(Index = 146)]
        /* 0xE94 */ public float VignetteStartMoveVR;
        [NMS(Index = 150)]
        /* 0xE98 */ public float VignetteStartMoveVRShip;
        [NMS(Index = 159)]
        /* 0xE9C */ public float VignetteStartRidingVR;
        [NMS(Index = 156)]
        /* 0xEA0 */ public float VignetteStartTurnRidingVR;
        [NMS(Index = 144)]
        /* 0xEA4 */ public float VignetteStartTurnVR;
        [NMS(Index = 153)]
        /* 0xEA8 */ public float VignetteStartTurnVRShip;
        [NMS(Index = 149)]
        /* 0xEAC */ public float VignetteVRMoveInterpTime;
        [NMS(Index = 152)]
        /* 0xEB0 */ public float VignetteVRMoveInterpTimeShip;
        [NMS(Index = 161)]
        /* 0xEB4 */ public float VignetteVRRidingInterpTime;
        [NMS(Index = 148)]
        /* 0xEB8 */ public float VignetteVRTurnInterpTime;
        [NMS(Index = 155)]
        /* 0xEBC */ public float VignetteVRTurnInterpTimeShip;
        [NMS(Index = 158)]
        /* 0xEC0 */ public float VignetteVRTurnRidingInterpTime;
        [NMS(Index = 64)]
        /* 0xEC4 */ public float WarpK;
        [NMS(Index = 65)]
        /* 0xEC8 */ public float WarpKCube;
        [NMS(Index = 67)]
        /* 0xECC */ public float WarpKDispersion;
        [NMS(Index = 66)]
        /* 0xED0 */ public float WarpScale;
        [NMS(Index = 231)]
        /* 0xED4 */ public float WaterHueShift;
        [NMS(Index = 232)]
        /* 0xED8 */ public float WaterSaturation;
        [NMS(Index = 233)]
        /* 0xEDC */ public float WaterValue;
        [NMS(Index = 45)]
        /* 0xEE0 */ public float WonderModelRendererLightIntensity;
        [NMS(Index = 283)]
        /* 0xEE4 */ public bool AllowPartialCascadeRender;
        [NMS(Index = 244)]
        /* 0xEE5 */ public bool ApplyTaaTest;
        [NMS(Index = 51)]
        /* 0xEE6 */ public bool CenterRenderSpaceOffset;
        [NMS(Index = 50)]
        /* 0xEE7 */ public bool DebugLinesDepthTest;
        [NMS(Index = 139)]
        /* 0xEE8 */ public bool DOFEnableBokeh;
        [NMS(Index = 140)]
        /* 0xEE9 */ public bool DOFEnableNewBokehShader;
        [NMS(Index = 141)]
        /* 0xEEA */ public bool DOFEnablePhysCamera;
        [NMS(Index = 297)]
        /* 0xEEB */ public bool EnableCrossPipeSharing;
        [NMS(Index = 298)]
        /* 0xEEC */ public bool EnableSSR;
        [NMS(Index = 274)]
        /* 0xEED */ public bool EnableTerrainCachePs4Base;
        [NMS(Index = 275)]
        /* 0xEEE */ public bool EnableTerrainCachePs4Pro;
        [NMS(Index = 276)]
        /* 0xEEF */ public bool EnableTerrainCacheXb1Base;
        [NMS(Index = 277)]
        /* 0xEF0 */ public bool EnableTerrainCacheXb1X;
        [NMS(Index = 286)]
        /* 0xEF1 */ public bool EnableTextureStreaming;
        [NMS(Index = 318)]
        /* 0xEF2 */ public bool EnableVariableUpdate;
        [NMS(Index = 278)]
        /* 0xEF3 */ public bool ForceCachedTerrain;
        [NMS(Index = 288)]
        /* 0xEF4 */ public bool ForceEvictAllTextures;
        [NMS(Index = 287)]
        /* 0xEF5 */ public bool ForceStreamAllTextures;
        [NMS(Index = 279)]
        /* 0xEF6 */ public bool ForceUncachedTerrain;
        [NMS(Index = 175)]
        /* 0xEF7 */ public bool FullscreenScanEffect;
        [NMS(Index = 328)]
        /* 0xEF8 */ public bool IBLReflections;
        [NMS(Index = 15)]
        /* 0xEF9 */ public bool Redo_On;
        [NMS(Index = 85)]
        /* 0xEFA */ public bool ShadowQuantized;
        [NMS(Index = 299)]
        /* 0xEFB */ public bool ShowReflectionProbes;
        [NMS(Index = 245)]
        /* 0xEFC */ public bool ShowTaaBuf;
        [NMS(Index = 249)]
        /* 0xEFD */ public bool ShowTaaCVarianceBuf;
        [NMS(Index = 248)]
        /* 0xEFE */ public bool ShowTaaNVarianceBuf;
        [NMS(Index = 247)]
        /* 0xEFF */ public bool ShowTaaVarianceBuf;
        [NMS(Index = 246)]
        /* 0xF00 */ public bool TonemapInLuminance;
        [NMS(Index = 176)]
        /* 0xF01 */ public bool UseImposters;
        [NMS(Index = 243)]
        /* 0xF02 */ public bool UseTaaResolve;
    }
}
