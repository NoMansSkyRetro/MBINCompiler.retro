using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD128ED136335E3C3, NameHash = 0x2338AA60)]
    public class GcBaseBuildingEntry : NMSTemplate
    {
        [NMS(Index = 47)]
        /* 0x000 */ public GcBaseLinkGridData LinkGridData;
        [NMS(Index = 29)]
        /* 0x058 */ public NMSString0x20A ColourPaletteGroupId;
        [NMS(Index = 30)]
        /* 0x078 */ public NMSString0x20A DefaultColourPaletteId;
        [NMS(Index = 32)]
        /* 0x098 */ public NMSString0x20A DefaultMaterialId;
        [NMS(Index = 31)]
        /* 0x0B8 */ public NMSString0x20A MaterialGroupId;
        [NMS(Index = 52)]
        /* 0x0D8 */ public TkModelResource NPCInteractionScene;
        [NMS(Index = 4)]
        /* 0x0F8 */ public TkModelResource PlacementScene;
        [NMS(Index = 5)]
        /* 0x118 */ public NMSString0x20A SinglePartID;
        [NMS(Index = 37)]
        /* 0x138 */ public List<NMSString0x10> CompositePartObjectIDs;
        [NMS(Index = 38)]
        /* 0x148 */ public List<NMSString0x10> FamilyIDs;
        [NMS(Index = 27)]
        /* 0x158 */ public List<GcBaseBuildingEntryGroup> Groups;
        [NMS(Index = 0)]
        /* 0x168 */ public NMSString0x10 ID;
        // size: 0x2
        public enum BaseTerrainEditShapeEnum : uint {
            Cube,
            Cylinder,
        }
        [NMS(Index = 43)]
        /* 0x178 */ public BaseTerrainEditShapeEnum BaseTerrainEditShape;
        [NMS(Index = 9)]
        /* 0x17C */ public GcBiomeType Biome;
        [NMS(Index = 39)]
        /* 0x180 */ public float BuildEffectAccelerator;
        [NMS(Index = 6)]
        /* 0x184 */ public GcBaseBuildingObjectDecorationTypes DecorationType;
        [NMS(Index = 21)]
        /* 0x188 */ public int FreighterBaseLimit;
        [NMS(Index = 48)]
        /* 0x18C */ public int GhostsCountOverride;
        [NMS(Index = 44)]
        /* 0x190 */ public float MinimumDeleteDistance;
        [NMS(Index = 20)]
        /* 0x194 */ public int PlanetBaseLimit;
        [NMS(Index = 18)]
        /* 0x198 */ public int PlanetLimit;
        [NMS(Index = 19)]
        /* 0x19C */ public int RegionLimit;
        [NMS(Index = 51)]
        /* 0x1A0 */ public int RegionSpawnLOD;
        [NMS(Index = 50)]
        /* 0x1A4 */ public float SnappingDistanceOverride;
        [NMS(Index = 28)]
        /* 0x1A8 */ public int StorageContainerIndex;
        [NMS(Index = 3)]
        /* 0x1AC */ public GcBaseBuildingPartStyle Style;
        [NMS(Index = 17)]
        /* 0x1B0 */ public bool BuildableAboveWater;
        [NMS(Index = 13)]
        /* 0x1B1 */ public bool BuildableInShip;
        [NMS(Index = 12)]
        /* 0x1B2 */ public bool BuildableOnFreighter;
        [NMS(Index = 14)]
        /* 0x1B3 */ public bool BuildableOnPlanet;
        [NMS(Index = 10)]
        /* 0x1B4 */ public bool BuildableOnPlanetBase;
        [NMS(Index = 15)]
        /* 0x1B5 */ public bool BuildableOnPlanetWithProduct;
        [NMS(Index = 11)]
        /* 0x1B6 */ public bool BuildableOnSpaceBase;
        [NMS(Index = 16)]
        /* 0x1B7 */ public bool BuildableUnderwater;
        [NMS(Index = 33)]
        /* 0x1B8 */ public bool CanChangeColour;
        [NMS(Index = 34)]
        /* 0x1B9 */ public bool CanChangeMaterial;
        [NMS(Index = 35)]
        /* 0x1BA */ public bool CanPickUp;
        [NMS(Index = 25)]
        /* 0x1BB */ public bool CanRotate3D;
        [NMS(Index = 26)]
        /* 0x1BC */ public bool CanScale;
        [NMS(Index = 24)]
        /* 0x1BD */ public bool CanStack;
        [NMS(Index = 22)]
        /* 0x1BE */ public bool CheckPlaceholderCollision;
        [NMS(Index = 23)]
        /* 0x1BF */ public bool CheckPlayerCollision;
        [NMS(Index = 46)]
        /* 0x1C0 */ public bool CloseMenuAfterBuild;
        [NMS(Index = 42)]
        /* 0x1C1 */ public bool EditsTerrain;
        [NMS(Index = 8)]
        /* 0x1C2 */ public bool IsDecoration;
        [NMS(Index = 2)]
        /* 0x1C3 */ public bool IsFromModFolder;
        [NMS(Index = 7)]
        /* 0x1C4 */ public bool IsPlaceable;
        [NMS(Index = 45)]
        /* 0x1C5 */ public bool IsSealed;
        [NMS(Index = 1)]
        /* 0x1C6 */ public bool IsTemporary;
        [NMS(Index = 40)]
        /* 0x1C7 */ public bool RemovesAttachedDecoration;
        [NMS(Index = 41)]
        /* 0x1C8 */ public bool RemovesWhenUnsnapped;
        [NMS(Index = 49)]
        /* 0x1C9 */ public bool ShowGhosts;
        [NMS(Index = 36)]
        /* 0x1CA */ public bool ShowInBuildMenu;
    }
}
