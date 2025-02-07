using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBEDD649FE0151D39, NameHash = 0x60BCEB20)]
    public class GcSimpleInteractionComponentData : NMSTemplate
    {
        [NMS(Index = 18)]
        /* 0x000 */ public GcInteractionActivationCost ActivationCost;
        [NMS(Index = 32, Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x068 */ public NMSString0x10[] RarityLocators;
        [NMS(Index = 24)]
        /* 0x098 */ public NMSString0x20A ForceSubtitle;
        [NMS(Index = 23)]
        /* 0x0B8 */ public NMSString0x20A Name;
        [NMS(Index = 29)]
        /* 0x0D8 */ public NMSString0x20A ScanData;
        [NMS(Index = 28)]
        /* 0x0F8 */ public NMSString0x20A ScanType;
        [NMS(Index = 26)]
        /* 0x118 */ public NMSString0x20A TerminalHeading;
        [NMS(Index = 27)]
        /* 0x138 */ public NMSString0x20A TerminalMessage;
        [NMS(Index = 25)]
        /* 0x158 */ public NMSString0x20A VRInteractMessage;
        [NMS(Index = 33)]
        /* 0x178 */ public List<GcInteractionBaseBuildingState> BaseBuildingTriggerActions;
        [NMS(Index = 3)]
        /* 0x188 */ public NMSString0x10 Id;
        [NMS(Index = 35)]
        /* 0x198 */ public List<GcPersistencyMissionOverride> PersistencyBufferOverride;
        [NMS(Index = 34)]
        /* 0x1A8 */ public List<GcRewardMissionOverride> RewardOverrideTable;
        [NMS(Index = 6)]
        /* 0x1B8 */ public NMSString0x10 TriggerAction;
        [NMS(Index = 7)]
        /* 0x1C8 */ public NMSString0x10 TriggerActionOnPrepare;
        [NMS(Index = 8)]
        /* 0x1D8 */ public NMSString0x10 TriggerActionToggle;
        [NMS(Index = 10)]
        /* 0x1E8 */ public float Delay;
        [NMS(Index = 16)]
        /* 0x1EC */ public int IncreaseCorruptSentinelWanted;
        [NMS(Index = 15)]
        /* 0x1F0 */ public int InteractCrimeLevel;
        [NMS(Index = 1)]
        /* 0x1F4 */ public float InteractDistance;
        [NMS(Index = 14)]
        /* 0x1F8 */ public float InteractFiendCrimeChance;
        [NMS(Index = 13)]
        /* 0x1FC */ public GcFiendCrime InteractFiendCrimeType;
        [NMS(Index = 4)]
        /* 0x200 */ public GcRarity Rarity;
        [NMS(Index = 30)]
        /* 0x204 */ public GcDiscoveryType ScanIcon;
        // size: 0x24
        public enum SimpleInteractionTypeEnum : uint {
            Interact,
            Treasure,
            Beacon,
            Scan,
            Save,
            CallShip,
            CallVehicle,
            Word,
            Tech,
            GenericReward,
            Feed,
            Ladder,
            ClaimBase,
            TeleportStartPoint,
            TeleportEndPoint,
            Portal,
            Chest,
            ResourceHarvester,
            BaseCapsule,
            Hologram,
            NPCTerminalMessage,
            VehicleBoot,
            BiomeHarvester,
            FreighterGalacticMap,
            FreighterChest,
            Collectable,
            Chair,
            BaseTreasureChest,
            SpawnObject,
            NoiseBox,
            AbandFreighterTeleporter,
            PetEgg,
            SubstancePickup,
            FreighterTeleport,
            MiniPortalTrigger,
            SuperDoopaScanner,
        }
        [NMS(Index = 0)]
        /* 0x208 */ public SimpleInteractionTypeEnum SimpleInteractionType;
        [NMS(Index = 5)]
        /* 0x20C */ public GcSizeIndicator Size;
        [NMS(Index = 19)]
        /* 0x210 */ public GcStatsEnum StatToTrack;
        [NMS(Index = 31)]
        /* 0x214 */ public bool ActivateLocatorsFromRarity;
        [NMS(Index = 9)]
        /* 0x215 */ public bool BroadcastTriggerAction;
        [NMS(Index = 38)]
        /* 0x216 */ public bool CanCollectInMech;
        [NMS(Index = 11)]
        /* 0x217 */ public bool HideContents;
        [NMS(Index = 12)]
        /* 0x218 */ public bool InteractIsCrime;
        [NMS(Index = 21)]
        /* 0x219 */ public bool MustBeVisibleToInteract;
        [NMS(Index = 22)]
        /* 0x21A */ public bool NeedsStorm;
        [NMS(Index = 17)]
        /* 0x21B */ public bool NotifyEncounter;
        [NMS(Index = 37)]
        /* 0x21C */ public bool ReseedOnRewardSuccess;
        [NMS(Index = 20)]
        /* 0x21D */ public bool StartsBuried;
        [NMS(Index = 2)]
        /* 0x21E */ public bool Use2dInteractDistance;
        [NMS(Index = 36)]
        /* 0x21F */ public bool UsePersonalPersistentBuffer;
    }
}
