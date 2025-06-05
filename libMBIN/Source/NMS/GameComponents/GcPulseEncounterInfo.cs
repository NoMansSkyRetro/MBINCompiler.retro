using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x94063EB6CB360281, NameHash = 0x191B9BEB)]
    public class GcPulseEncounterInfo : NMSTemplate
    {
        [NMS(Index = 8)]
        /* 0x000 */ public Colour CustomNotifyColour;
        [NMS(Index = 10)]
        /* 0x010 */ public GcPulseEncounterSpawnConditions SpawnConditions;
        [NMS(Index = 2)]
        /* 0x070 */ public NMSString0x20A ChatMessageName;
        [NMS(Index = 4)]
        /* 0x090 */ public NMSString0x20A CustomNotify;
        [NMS(Index = 6)]
        /* 0x0B0 */ public NMSString0x20A CustomNotifyOSD;
        [NMS(Index = 5)]
        /* 0x0D0 */ public NMSString0x20A CustomNotifyTitle;
        [NMS(Index = 1)]
        /* 0x0F0 */ public NMSString0x20A MarkerLabel;
        [NMS(Index = 3)]
        /* 0x110 */ public TkTextureResource MarkerIcon;
        [NMS(Index = 15)]
        /* 0x128 */ public NMSTemplate Encounter;
        [NMS(Index = 0)]
        /* 0x138 */ public NMSString0x10 Id;
        [NMS(Index = 13)]
        /* 0x148 */ public GcAudioWwiseEvents AudioEvent;
        [NMS(Index = 11)]
        /* 0x14C */ public float SpawnChance;
        [NMS(Index = 12)]
        /* 0x150 */ public float SpawnDistance;
        [NMS(Index = 7)]
        /* 0x154 */ public bool HasColourOverride;
        [NMS(Index = 14)]
        /* 0x155 */ public bool Silent;
        [NMS(Index = 9)]
        /* 0x156 */ public bool UseMarkerIconInOSD;
    }
}
