using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x50C9D96E226A901F, NameHash = 0x29E8EF9E)]
    public class GcCameraAmbientBuildingData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Animation;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x10 DroneAnimation;
        [NMS(Index = 2)]
        /* 0x20 */ public float Offset;
        [NMS(Index = 5, Size = 0x3E, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x24 */ public bool[] AvailableBuildings;
        [NMS(Index = 6, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x62 */ public bool[] AvailableRaces;
        [NMS(Index = 4)]
        /* 0x6B */ public bool AvoidTerrain;
        [NMS(Index = 3)]
        /* 0x6C */ public bool UseLookAt;
    }
}
