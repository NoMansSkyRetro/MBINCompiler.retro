using libMBIN.NMS;
using libMBIN.NMS.GameComponents;

namespace libMBIN.V1_00.Structs
{
    public class GcBuildingSpawnData : NMSTemplate // disc 0x320: no UnderwaterResource, LSystemID after Radius
    {
        /* 0x000 */ public float Density;
        [NMS(Size = 4, Ignore = true)]
        /* 0x004 */ public byte[] Padding4;
        /* 0x008 */ public GcResourceElement Resource;
        /* 0x2B0 */ public bool AutoCollision;
        [NMS(Size = 7, Ignore = true)]
        /* 0x2B1 */ public byte[] Padding2B1;
        /* 0x2B8 */ public GcSeed Seed;
        /* 0x2C8 */ public GcBuildingClassification BuildingClass;
        /* 0x2CC */ public GcBuildingClusterPlacement BuildingClusterPlacement;
        /* 0x2D0 */ public bool AddWaypoint;
        /* 0x2D1 */ public bool AddShelter;
        /* 0x2D2 */ public bool AddLandingPad;
        /* 0x2D3 */ public bool GivesShelter;
        /* 0x2D4 */ public bool PositioningAlignToNormal;
        /* 0x2D5 */ public bool PositioningLowerIntoGround;
        /* 0x2D8 */ public float PositioningScale;
        /* 0x2DC */ public float PositioningMaxXZRotation;
        /* 0x2E0 */ public float PositioningRadius;
        /* 0x2E4 */ public int LSystemID;
        /* 0x2E8 */ public int InstanceID;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x2EC */ public byte[] Padding2EC;
        /* 0x2F0 */ public Vector4f AABBMin;
        /* 0x300 */ public Vector4f AABBMax;
        /* 0x310 */ public bool BuildingSizeCalculated;
        [NMS(Size = 0xF, Ignore = true)]
        /* 0x311 */ public byte[] Padding311;
    }
}
