using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x85CAA9C3C143DB17, NameHash = 0x29E8EF9E)]
    public class GcCameraAmbientBuildingData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Animation;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x10 DroneAnimation;
        [NMS(Index = 2)]
        /* 0x20 */ public float Offset;
        [NMS(Index = 5, Size = 0x39, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x24 */ public bool[] AvailableBuildings;
        [NMS(Index = 6, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x5D */ public bool[] AvailableRaces;
        [NMS(Index = 4)]
        /* 0x66 */ public bool AvoidTerrain;
        [NMS(Index = 3)]
        /* 0x67 */ public bool UseLookAt;
    }
}
