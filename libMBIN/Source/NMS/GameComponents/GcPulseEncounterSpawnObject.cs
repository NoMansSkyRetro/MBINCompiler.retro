using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x59D7C910F08BC5DC, NameHash = 0x2A80495A)]
    public class GcPulseEncounterSpawnObject : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public TkModelResource Object;
        [NMS(Index = 13)]
        /* 0x20 */ public NMSString0x10 DespawnEffect;
        [NMS(Index = 12)]
        /* 0x30 */ public NMSString0x10 SpawnEffect;
        [NMS(Index = 6)]
        /* 0x40 */ public NMSString0x10 TriggerActionOnSpawn;
        [NMS(Index = 2)]
        /* 0x50 */ public float Pitch;
        [NMS(Index = 4)]
        /* 0x54 */ public float Roll;
        [NMS(Index = 1)]
        /* 0x58 */ public float SpawnScale;
        [NMS(Index = 11)]
        /* 0x5C */ public float SpawnTime;
        [NMS(Index = 5)]
        /* 0x60 */ public float UpOffset;
        [NMS(Index = 10)]
        /* 0x64 */ public float WarpInDistance;
        [NMS(Index = 3)]
        /* 0x68 */ public float Yaw;
        [NMS(Index = 7)]
        /* 0x6C */ public bool BlockAIShipAutopilot;
        [NMS(Index = 8)]
        /* 0x6D */ public bool LeaveIfAttacked;
        [NMS(Index = 9)]
        /* 0x6E */ public bool WarpIn;
    }
}
