using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9D644642A4079F4, NameHash = 0xF6B8782)]
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
        [NMS(Index = 17, Size = 0x1E)]
        /* 0x01B0 */ public GcPetData[] Pets;
        [NMS(Index = 18, Size = 0x1E)]
        /* 0x5160 */ public GcPetCustomisationData[] PetAccessoryCustomisation;
        [NMS(Index = 41, Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x75F0 */ public GcCameraFollowSettings[] VehicleCameraOverride;
        [NMS(Index = 59)]
        /* 0x7D28 */ public NMSString0x10 BackgroundSpaceEncounter;
        [NMS(Index = 35)]
        /* 0x7D38 */ public List<GcDebugCamera> DebugCameraPaths;
        [NMS(Index = 37)]
        /* 0x7D48 */ public List<GcCreatureDebugSpawnData> DebugCreatureSpawns;
        [NMS(Index = 36)]
        /* 0x7D58 */ public List<GcDebugObjectDecoration> DebugDecorations;
        [NMS(Index = 39)]
        /* 0x7D68 */ public List<GcAIShipDebugSpawnData> DebugEnemyShipSpawns;
        [NMS(Index = 54)]
        /* 0x7D78 */ public NMSString0x10 DebugExperienceCamShake;
        [NMS(Index = 53)]
        /* 0x7D88 */ public GcSeed DebugFlybySeed;
        [NMS(Index = 38)]
        /* 0x7D98 */ public List<GcMechDebugSpawnData> DebugMechSpawns;
        [NMS(Index = 11)]
        /* 0x7DA8 */ public List<GcNPCDebugSpawnData> DebugNPCSpawns;
        [NMS(Index = 34)]
        /* 0x7DB8 */ public List<GcDebugShipTravelLine> DebugShipPaths;
        [NMS(Index = 40)]
        /* 0x7DC8 */ public List<GcAIShipDebugSpawnData> DebugShipSpawns;
        [NMS(Index = 10)]
        /* 0x7DD8 */ public List<NMSString0x10> DefaultNPCIdles;
        [NMS(Index = 69)]
        /* 0x7DE8 */ public NMSString0x10 GhostShipReward;
        [NMS(Index = 68)]
        /* 0x7DF8 */ public NMSString0x10 LivingFrigateReward;
        [NMS(Index = 67)]
        /* 0x7E08 */ public NMSString0x10 NormandyReward;
        [NMS(Index = 22)]
        /* 0x7E18 */ public List<Vector3f> PetRideWayPoints;
        [NMS(Index = 58)]
        /* 0x7E28 */ public NMSString0x10 PulseEncounter;
        [NMS(Index = 4)]
        /* 0x7E38 */ public List<GcExperienceDebugTriggerInput> TriggerActions;
        [NMS(Index = 30)]
        /* 0x7E48 */ public Vector2f CloudStratosphereWindOffset;
        [NMS(Index = 29)]
        /* 0x7E50 */ public Vector2f CloudWindOffset;
        [NMS(Index = 73)]
        /* 0x7E58 */ public float CameraSpinDistanceOffset;
        [NMS(Index = 71)]
        /* 0x7E5C */ public float CameraSpinRevolutions;
        [NMS(Index = 70)]
        /* 0x7E60 */ public float CameraSpinTime;
        [NMS(Index = 72)]
        /* 0x7E64 */ public float CameraSpinVerticalOffset;
        [NMS(Index = 28)]
        /* 0x7E68 */ public float CloudAnimScale;
        [NMS(Index = 27)]
        /* 0x7E6C */ public float CloudCover;
        [NMS(Index = 32)]
        /* 0x7E70 */ public float CustomShipDockedTime;
        [NMS(Index = 43)]
        /* 0x7E74 */ public GcSentinelTypes DebugDroneType;
        [NMS(Index = 52)]
        /* 0x7E78 */ public float DebugFlybyRange;
        [NMS(Index = 66)]
        /* 0x7E7C */ public float DebugFrigateFlybyHeightOffset;
        [NMS(Index = 65)]
        /* 0x7E80 */ public float DebugFrigateFlybyRotation;
        [NMS(Index = 46)]
        /* 0x7E84 */ public int DebugNumDrones;
        [NMS(Index = 6)]
        /* 0x7E88 */ public float FlyCamSmoothFactor;
        [NMS(Index = 7)]
        /* 0x7E8C */ public float FlyCamSpeedModifier;
        [NMS(Index = 9)]
        /* 0x7E90 */ public float NPCIdleMaxDelay;
        [NMS(Index = 8)]
        /* 0x7E94 */ public float NPCIdleMinDelay;
        [NMS(Index = 16)]
        /* 0x7E98 */ public GcPetBehaviours PetForceBehaviour;
        [NMS(Index = 21)]
        /* 0x7E9C */ public int PetRideIndex;
        [NMS(Index = 20)]
        /* 0x7EA0 */ public float PlayerWalkSpeed;
        [NMS(Index = 33)]
        /* 0x7EA4 */ public float ShipSpawningMultiplier;
        [NMS(Index = 0)]
        /* 0x7EA8 */ public bool Active;
        [NMS(Index = 25)]
        /* 0x7EA9 */ public bool AllowOverrideWaterSettings;
        [NMS(Index = 3)]
        /* 0x7EAA */ public bool AutoCreateDecorations;
        [NMS(Index = 2)]
        /* 0x7EAB */ public bool AutoSave;
        [NMS(Index = 31)]
        /* 0x7EAC */ public bool BusyShips;
        [NMS(Index = 74)]
        /* 0x7EAD */ public TkCurveType CameraSpinEasing;
        [NMS(Index = 26)]
        /* 0x7EAE */ public bool ControlClouds;
        [NMS(Index = 1)]
        /* 0x7EAF */ public bool DebugDraw;
        [NMS(Index = 42)]
        /* 0x7EB0 */ public bool DebugDroneScanPlayer;
        [NMS(Index = 5)]
        /* 0x7EB1 */ public bool FlyCamSmooth;
        [NMS(Index = 19)]
        /* 0x7EB2 */ public bool ForcePlayerWalk;
        [NMS(Index = 23)]
        /* 0x7EB3 */ public bool ForceSunPosition;
        [NMS(Index = 12)]
        /* 0x7EB4 */ public bool LoadPetsFromDebugScene;
        [NMS(Index = 60)]
        /* 0x7EB5 */ public bool PulseEncountersAlwaysPersist;
        [NMS(Index = 14)]
        /* 0x7EB6 */ public bool ResetMoodsOnSummon;
        [NMS(Index = 15)]
        /* 0x7EB7 */ public bool ShowAccessoryMoods;
        [NMS(Index = 13)]
        /* 0x7EB8 */ public bool UpdatePetMoods;
    }
}
