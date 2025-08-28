using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2837B73A469CCFF6, NameHash = 0x2338AA60)]
    public class GcBaseBuildingEntry : NMSTemplate
    {
        [NMS(Index = 51)]
        /* 0x000 */ public GcBaseLinkGridData LinkGridData;
        [NMS(Index = 31)]
        /* 0x058 */ public NMSString0x20A ColourPaletteGroupId;
        [NMS(Index = 32)]
        /* 0x078 */ public NMSString0x20A DefaultColourPaletteId;
        [NMS(Index = 34)]
        /* 0x098 */ public NMSString0x20A DefaultMaterialId;
        [NMS(Index = 60)]
        /* 0x0B8 */ public NMSString0x20A DescriptorID;
        [NMS(Index = 33)]
        /* 0x0D8 */ public NMSString0x20A MaterialGroupId;
        [NMS(Index = 56)]
        /* 0x0F8 */ public TkModelResource NPCInteractionScene;
        [NMS(Index = 4)]
        /* 0x118 */ public TkModelResource PlacementScene;
        [NMS(Index = 5)]
        /* 0x138 */ public NMSString0x20A SinglePartID;
        [NMS(Index = 39)]
        /* 0x158 */ public List<NMSString0x10> CompositePartObjectIDs;
        [NMS(Index = 40)]
        /* 0x168 */ public List<NMSString0x10> FamilyIDs;
        [NMS(Index = 63)]
        /* 0x178 */ public NMSString0x10 FossilDisplayID;
        [NMS(Index = 29)]
        /* 0x188 */ public List<GcBaseBuildingEntryGroup> Groups;
        [NMS(Index = 42)]
        /* 0x198 */ public NMSString0x10 IconOverrideProductID;
        [NMS(Index = 0)]
        /* 0x1A8 */ public NMSString0x10 ID;
        [NMS(Index = 58)]
        /* 0x1B8 */ public NMSString0x10 ModularCustomisationBaseID;
        [NMS(Index = 62)]
        /* 0x1C8 */ public NMSString0x10 OverrideProductID;
        [NMS(Index = 50)]
        /* 0x1D8 */ public NMSString0x10 Tag;
        // size: 0x2
        public enum BaseTerrainEditShapeEnum : uint {
            Cube,
            Cylinder,
        }
        [NMS(Index = 46)]
        /* 0x1E8 */ public BaseTerrainEditShapeEnum BaseTerrainEditShape;
        [NMS(Index = 9)]
        /* 0x1EC */ public GcBiomeType Biome;
        [NMS(Index = 41)]
        /* 0x1F0 */ public float BuildEffectAccelerator;
        [NMS(Index = 6)]
        /* 0x1F4 */ public GcBaseBuildingObjectDecorationTypes DecorationType;
        [NMS(Index = 22)]
        /* 0x1F8 */ public int FreighterBaseLimit;
        [NMS(Index = 52)]
        /* 0x1FC */ public int GhostsCountOverride;
        [NMS(Index = 47)]
        /* 0x200 */ public float MinimumDeleteDistance;
        [NMS(Index = 21)]
        /* 0x204 */ public int PlanetBaseLimit;
        [NMS(Index = 19)]
        /* 0x208 */ public int PlanetLimit;
        [NMS(Index = 20)]
        /* 0x20C */ public int RegionLimit;
        [NMS(Index = 55)]
        /* 0x210 */ public int RegionSpawnLOD;
        [NMS(Index = 54)]
        /* 0x214 */ public float SnappingDistanceOverride;
        [NMS(Index = 30)]
        /* 0x218 */ public int StorageContainerIndex;
        [NMS(Index = 3)]
        /* 0x21C */ public GcBaseBuildingPartStyle Style;
        [NMS(Index = 18)]
        /* 0x220 */ public bool BuildableAboveWater;
        [NMS(Index = 14)]
        /* 0x221 */ public bool BuildableInShipDecorative;
        [NMS(Index = 13)]
        /* 0x222 */ public bool BuildableInShipStructural;
        [NMS(Index = 12)]
        /* 0x223 */ public bool BuildableOnFreighter;
        [NMS(Index = 15)]
        /* 0x224 */ public bool BuildableOnPlanet;
        [NMS(Index = 10)]
        /* 0x225 */ public bool BuildableOnPlanetBase;
        [NMS(Index = 16)]
        /* 0x226 */ public bool BuildableOnPlanetWithProduct;
        [NMS(Index = 11)]
        /* 0x227 */ public bool BuildableOnSpaceBase;
        [NMS(Index = 17)]
        /* 0x228 */ public bool BuildableUnderwater;
        [NMS(Index = 35)]
        /* 0x229 */ public bool CanChangeColour;
        [NMS(Index = 36)]
        /* 0x22A */ public bool CanChangeMaterial;
        [NMS(Index = 37)]
        /* 0x22B */ public bool CanPickUp;
        [NMS(Index = 27)]
        /* 0x22C */ public bool CanRotate3D;
        [NMS(Index = 28)]
        /* 0x22D */ public bool CanScale;
        [NMS(Index = 25)]
        /* 0x22E */ public bool CanStack;
        [NMS(Index = 23)]
        /* 0x22F */ public bool CheckPlaceholderCollision;
        [NMS(Index = 24)]
        /* 0x230 */ public bool CheckPlayerCollision;
        [NMS(Index = 49)]
        /* 0x231 */ public bool CloseMenuAfterBuild;
        [NMS(Index = 45)]
        /* 0x232 */ public bool EditsTerrain;
        [NMS(Index = 59)]
        /* 0x233 */ public bool HasDescriptor;
        [NMS(Index = 8)]
        /* 0x234 */ public bool IsDecoration;
        [NMS(Index = 2)]
        /* 0x235 */ public bool IsFromModFolder;
        [NMS(Index = 57)]
        /* 0x236 */ public bool IsModularCustomisation;
        [NMS(Index = 7)]
        /* 0x237 */ public bool IsPlaceable;
        [NMS(Index = 48)]
        /* 0x238 */ public bool IsSealed;
        [NMS(Index = 1)]
        /* 0x239 */ public bool IsTemporary;
        [NMS(Index = 43)]
        /* 0x23A */ public bool RemovesAttachedDecoration;
        [NMS(Index = 44)]
        /* 0x23B */ public bool RemovesWhenUnsnapped;
        [NMS(Index = 53)]
        /* 0x23C */ public bool ShowGhosts;
        [NMS(Index = 38)]
        /* 0x23D */ public bool ShowInBuildMenu;
        [NMS(Index = 26)]
        /* 0x23E */ public bool SnapRotateBlocked;
        [NMS(Index = 61)]
        /* 0x23F */ public bool UseProductIDOverride;
    }
}
