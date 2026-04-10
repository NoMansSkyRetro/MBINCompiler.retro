using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x583722183070C542, NameHash = 0xF6B8782)]
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
        /* 0x5AC0 */ public GcPetCustomisationData[] PetAccessoryCustomisation;
        [NMS(Index = 41, Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x7F50 */ public GcCameraFollowSettings[] VehicleCameraOverride;
        [NMS(Index = 59)]
        /* 0x8688 */ public NMSString0x10 BackgroundSpaceEncounter;
        [NMS(Index = 35)]
        /* 0x8698 */ public List<GcDebugCamera> DebugCameraPaths;
        [NMS(Index = 37)]
        /* 0x86A8 */ public List<GcCreatureDebugSpawnData> DebugCreatureSpawns;
        [NMS(Index = 36)]
        /* 0x86B8 */ public List<GcDebugObjectDecoration> DebugDecorations;
        [NMS(Index = 39)]
        /* 0x86C8 */ public List<GcAIShipDebugSpawnData> DebugEnemyShipSpawns;
        [NMS(Index = 54)]
        /* 0x86D8 */ public NMSString0x10 DebugExperienceCamShake;
        [NMS(Index = 53)]
        /* 0x86E8 */ public GcSeed DebugFlybySeed;
        [NMS(Index = 38)]
        /* 0x86F8 */ public List<GcMechDebugSpawnData> DebugMechSpawns;
        [NMS(Index = 11)]
        /* 0x8708 */ public List<GcNPCDebugSpawnData> DebugNPCSpawns;
        [NMS(Index = 34)]
        /* 0x8718 */ public List<GcDebugShipTravelLine> DebugShipPaths;
        [NMS(Index = 40)]
        /* 0x8728 */ public List<GcAIShipDebugSpawnData> DebugShipSpawns;
        [NMS(Index = 10)]
        /* 0x8738 */ public List<NMSString0x10> DefaultNPCIdles;
        [NMS(Index = 69)]
        /* 0x8748 */ public NMSString0x10 GhostShipReward;
        [NMS(Index = 68)]
        /* 0x8758 */ public NMSString0x10 LivingFrigateReward;
        [NMS(Index = 67)]
        /* 0x8768 */ public NMSString0x10 NormandyReward;
        [NMS(Index = 22)]
        /* 0x8778 */ public List<Vector3f> PetRideWayPoints;
        [NMS(Index = 58)]
        /* 0x8788 */ public NMSString0x10 PulseEncounter;
        [NMS(Index = 4)]
        /* 0x8798 */ public List<GcExperienceDebugTriggerInput> TriggerActions;
        [NMS(Index = 30)]
        /* 0x87A8 */ public Vector2f CloudStratosphereWindOffset;
        [NMS(Index = 29)]
        /* 0x87B0 */ public Vector2f CloudWindOffset;
        [NMS(Index = 73)]
        /* 0x87B8 */ public float CameraSpinDistanceOffset;
        [NMS(Index = 71)]
        /* 0x87BC */ public float CameraSpinRevolutions;
        [NMS(Index = 70)]
        /* 0x87C0 */ public float CameraSpinTime;
        [NMS(Index = 72)]
        /* 0x87C4 */ public float CameraSpinVerticalOffset;
        [NMS(Index = 28)]
        /* 0x87C8 */ public float CloudAnimScale;
        [NMS(Index = 27)]
        /* 0x87CC */ public float CloudCover;
        [NMS(Index = 32)]
        /* 0x87D0 */ public float CustomShipDockedTime;
        [NMS(Index = 43)]
        /* 0x87D4 */ public GcSentinelTypes DebugDroneType;
        [NMS(Index = 52)]
        /* 0x87D8 */ public float DebugFlybyRange;
        [NMS(Index = 66)]
        /* 0x87DC */ public float DebugFrigateFlybyHeightOffset;
        [NMS(Index = 65)]
        /* 0x87E0 */ public float DebugFrigateFlybyRotation;
        [NMS(Index = 46)]
        /* 0x87E4 */ public int DebugNumDrones;
        [NMS(Index = 6)]
        /* 0x87E8 */ public float FlyCamSmoothFactor;
        [NMS(Index = 7)]
        /* 0x87EC */ public float FlyCamSpeedModifier;
        [NMS(Index = 9)]
        /* 0x87F0 */ public float NPCIdleMaxDelay;
        [NMS(Index = 8)]
        /* 0x87F4 */ public float NPCIdleMinDelay;
        [NMS(Index = 16)]
        /* 0x87F8 */ public GcPetBehaviours PetForceBehaviour;
        [NMS(Index = 21)]
        /* 0x87FC */ public int PetRideIndex;
        [NMS(Index = 20)]
        /* 0x8800 */ public float PlayerWalkSpeed;
        [NMS(Index = 33)]
        /* 0x8804 */ public float ShipSpawningMultiplier;
        [NMS(Index = 0)]
        /* 0x8808 */ public bool Active;
        [NMS(Index = 25)]
        /* 0x8809 */ public bool AllowOverrideWaterSettings;
        [NMS(Index = 3)]
        /* 0x880A */ public bool AutoCreateDecorations;
        [NMS(Index = 2)]
        /* 0x880B */ public bool AutoSave;
        [NMS(Index = 31)]
        /* 0x880C */ public bool BusyShips;
        [NMS(Index = 74)]
        /* 0x880D */ public TkCurveType CameraSpinEasing;
        [NMS(Index = 26)]
        /* 0x880E */ public bool ControlClouds;
        [NMS(Index = 1)]
        /* 0x880F */ public bool DebugDraw;
        [NMS(Index = 42)]
        /* 0x8810 */ public bool DebugDroneScanPlayer;
        [NMS(Index = 5)]
        /* 0x8811 */ public bool FlyCamSmooth;
        [NMS(Index = 19)]
        /* 0x8812 */ public bool ForcePlayerWalk;
        [NMS(Index = 23)]
        /* 0x8813 */ public bool ForceSunPosition;
        [NMS(Index = 12)]
        /* 0x8814 */ public bool LoadPetsFromDebugScene;
        [NMS(Index = 60)]
        /* 0x8815 */ public bool PulseEncountersAlwaysPersist;
        [NMS(Index = 14)]
        /* 0x8816 */ public bool ResetMoodsOnSummon;
        [NMS(Index = 15)]
        /* 0x8817 */ public bool ShowAccessoryMoods;
        [NMS(Index = 13)]
        /* 0x8818 */ public bool UpdatePetMoods;
    }
}
