using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6A91BB72F2BD2D1, NameHash = 0x191B9BEB)]
    public class GcPulseEncounterInfo : NMSTemplate
    {
        [NMS(Index = 8)]
        /* 0x000 */ public Colour CustomNotifyColour;
        [NMS(Index = 10)]
        /* 0x010 */ public GcPulseEncounterSpawnConditions SpawnConditions;
        [NMS(Index = 2)]
        /* 0x080 */ public NMSString0x20A ChatMessageName;
        [NMS(Index = 4)]
        /* 0x0A0 */ public NMSString0x20A CustomNotify;
        [NMS(Index = 6)]
        /* 0x0C0 */ public NMSString0x20A CustomNotifyOSD;
        [NMS(Index = 5)]
        /* 0x0E0 */ public NMSString0x20A CustomNotifyTitle;
        [NMS(Index = 1)]
        /* 0x100 */ public NMSString0x20A MarkerLabel;
        [NMS(Index = 3)]
        /* 0x120 */ public TkTextureResource MarkerIcon;
        [NMS(Index = 15)]
        /* 0x138 */ public NMSTemplate Encounter;
        [NMS(Index = 0)]
        /* 0x148 */ public NMSString0x10 Id;
        [NMS(Index = 13)]
        /* 0x158 */ public GcAudioWwiseEvents AudioEvent;
        [NMS(Index = 11)]
        /* 0x15C */ public float SpawnChance;
        [NMS(Index = 12)]
        /* 0x160 */ public float SpawnDistance;
        [NMS(Index = 7)]
        /* 0x164 */ public bool HasColourOverride;
        [NMS(Index = 14)]
        /* 0x165 */ public bool Silent;
        [NMS(Index = 9)]
        /* 0x166 */ public bool UseMarkerIconInOSD;
    }
}
