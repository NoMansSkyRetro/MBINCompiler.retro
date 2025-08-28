using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD8F0D3D501581A4D, NameHash = 0xF6B8782)]
    public class GcDebugScene : NMSTemplate
    {
        [NMS(Index = 75, Size = 0x6)]
        /* 0x0000 */ public GcDebugPlanetPos[] PlanetPositions;
        [NMS(Index = 44)]
        /* 0x00C0 */ public Vector3f DebugDroneSpawn;
        [NMS(Index = 45)]
        /* 0x00D0 */ public Vector3f DebugDroneTarget;
        [NMS(Index = 51)]
        /* 0x00E0 */ public Vector3f DebugFlybyDir;
        [NMS(Index = 50)]
        /* 0x00F0 */ public Vector3f DebugFlybyTarget;
        [NMS(Index = 62)]
        /* 0x0100 */ public Vector3f DebugFrigateFlybySpawnPos;
        [NMS(Index = 49)]
        /* 0x0110 */ public Vector3f DebugQueenSpawn;
        [NMS(Index = 56)]
        /* 0x0120 */ public Vector3f DebugShipSpawnFacing;
        [NMS(Index = 55)]
        /* 0x0130 */ public Vector3f DebugShipSpawnPos;
        [NMS(Index = 57)]
        /* 0x0140 */ public Vector3f DebugShipSpawnUp;
        [NMS(Index = 63)]
        /* 0x0150 */ public Vector3f DebugSpaceBattleSpawnPosOffset;
        [NMS(Index = 64)]
        /* 0x0160 */ public Vector3f DebugSpaceBattleSpawnRotOffset;
        [NMS(Index = 47)]
        /* 0x0170 */ public Vector3f DebugWalkerSpawn;
        [NMS(Index = 48)]
        /* 0x0180 */ public Vector3f DebugWalkerTarget;
        [NMS(Index = 24)]
        /* 0x0190 */ public Vector3f ForcedSunPosition;
        [NMS(Index = 61)]
        /* 0x01A0 */ public Vector3f SandwormSpawnPos;
        [NMS(Index = 17, Size = 0x12)]
        /* 0x01B0 */ public GcPetData[] Pets;
        [NMS(Index = 18, Size = 0x12)]
        /* 0x2640 */ public GcPetCustomisationData[] PetAccessoryCustomisation;
        [NMS(Index = 41, Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x3C30 */ public GcCameraFollowSettings[] VehicleCameraOverride;
        [NMS(Index = 59)]
        /* 0x4330 */ public NMSString0x10 BackgroundSpaceEncounter;
        [NMS(Index = 35)]
        /* 0x4340 */ public List<GcDebugCamera> DebugCameraPaths;
        [NMS(Index = 37)]
        /* 0x4350 */ public List<GcCreatureDebugSpawnData> DebugCreatureSpawns;
        [NMS(Index = 36)]
        /* 0x4360 */ public List<GcDebugObjectDecoration> DebugDecorations;
        [NMS(Index = 39)]
        /* 0x4370 */ public List<GcAIShipDebugSpawnData> DebugEnemyShipSpawns;
        [NMS(Index = 54)]
        /* 0x4380 */ public NMSString0x10 DebugExperienceCamShake;
        [NMS(Index = 53)]
        /* 0x4390 */ public GcSeed DebugFlybySeed;
        [NMS(Index = 38)]
        /* 0x43A0 */ public List<GcMechDebugSpawnData> DebugMechSpawns;
        [NMS(Index = 11)]
        /* 0x43B0 */ public List<GcNPCDebugSpawnData> DebugNPCSpawns;
        [NMS(Index = 34)]
        /* 0x43C0 */ public List<GcDebugShipTravelLine> DebugShipPaths;
        [NMS(Index = 40)]
        /* 0x43D0 */ public List<GcAIShipDebugSpawnData> DebugShipSpawns;
        [NMS(Index = 10)]
        /* 0x43E0 */ public List<NMSString0x10> DefaultNPCIdles;
        [NMS(Index = 69)]
        /* 0x43F0 */ public NMSString0x10 GhostShipReward;
        [NMS(Index = 68)]
        /* 0x4400 */ public NMSString0x10 LivingFrigateReward;
        [NMS(Index = 67)]
        /* 0x4410 */ public NMSString0x10 NormandyReward;
        [NMS(Index = 22)]
        /* 0x4420 */ public List<Vector3f> PetRideWayPoints;
        [NMS(Index = 58)]
        /* 0x4430 */ public NMSString0x10 PulseEncounter;
        [NMS(Index = 4)]
        /* 0x4440 */ public List<GcExperienceDebugTriggerInput> TriggerActions;
        [NMS(Index = 30)]
        /* 0x4450 */ public Vector2f CloudStratosphereWindOffset;
        [NMS(Index = 29)]
        /* 0x4458 */ public Vector2f CloudWindOffset;
        [NMS(Index = 73)]
        /* 0x4460 */ public float CameraSpinDistanceOffset;
        [NMS(Index = 71)]
        /* 0x4464 */ public float CameraSpinRevolutions;
        [NMS(Index = 70)]
        /* 0x4468 */ public float CameraSpinTime;
        [NMS(Index = 72)]
        /* 0x446C */ public float CameraSpinVerticalOffset;
        [NMS(Index = 28)]
        /* 0x4470 */ public float CloudAnimScale;
        [NMS(Index = 27)]
        /* 0x4474 */ public float CloudCover;
        [NMS(Index = 32)]
        /* 0x4478 */ public float CustomShipDockedTime;
        [NMS(Index = 43)]
        /* 0x447C */ public GcSentinelTypes DebugDroneType;
        [NMS(Index = 52)]
        /* 0x4480 */ public float DebugFlybyRange;
        [NMS(Index = 66)]
        /* 0x4484 */ public float DebugFrigateFlybyHeightOffset;
        [NMS(Index = 65)]
        /* 0x4488 */ public float DebugFrigateFlybyRotation;
        [NMS(Index = 46)]
        /* 0x448C */ public int DebugNumDrones;
        [NMS(Index = 6)]
        /* 0x4490 */ public float FlyCamSmoothFactor;
        [NMS(Index = 7)]
        /* 0x4494 */ public float FlyCamSpeedModifier;
        [NMS(Index = 9)]
        /* 0x4498 */ public float NPCIdleMaxDelay;
        [NMS(Index = 8)]
        /* 0x449C */ public float NPCIdleMinDelay;
        [NMS(Index = 16)]
        /* 0x44A0 */ public GcPetBehaviours PetForceBehaviour;
        [NMS(Index = 21)]
        /* 0x44A4 */ public int PetRideIndex;
        [NMS(Index = 20)]
        /* 0x44A8 */ public float PlayerWalkSpeed;
        [NMS(Index = 33)]
        /* 0x44AC */ public float ShipSpawningMultiplier;
        [NMS(Index = 0)]
        /* 0x44B0 */ public bool Active;
        [NMS(Index = 25)]
        /* 0x44B1 */ public bool AllowOverrideWaterSettings;
        [NMS(Index = 3)]
        /* 0x44B2 */ public bool AutoCreateDecorations;
        [NMS(Index = 2)]
        /* 0x44B3 */ public bool AutoSave;
        [NMS(Index = 31)]
        /* 0x44B4 */ public bool BusyShips;
        [NMS(Index = 74)]
        /* 0x44B5 */ public TkCurveType CameraSpinEasing;
        [NMS(Index = 26)]
        /* 0x44B6 */ public bool ControlClouds;
        [NMS(Index = 1)]
        /* 0x44B7 */ public bool DebugDraw;
        [NMS(Index = 42)]
        /* 0x44B8 */ public bool DebugDroneScanPlayer;
        [NMS(Index = 5)]
        /* 0x44B9 */ public bool FlyCamSmooth;
        [NMS(Index = 19)]
        /* 0x44BA */ public bool ForcePlayerWalk;
        [NMS(Index = 23)]
        /* 0x44BB */ public bool ForceSunPosition;
        [NMS(Index = 12)]
        /* 0x44BC */ public bool LoadPetsFromDebugScene;
        [NMS(Index = 60)]
        /* 0x44BD */ public bool PulseEncountersAlwaysPersist;
        [NMS(Index = 14)]
        /* 0x44BE */ public bool ResetMoodsOnSummon;
        [NMS(Index = 15)]
        /* 0x44BF */ public bool ShowAccessoryMoods;
        [NMS(Index = 13)]
        /* 0x44C0 */ public bool UpdatePetMoods;
    }
}
