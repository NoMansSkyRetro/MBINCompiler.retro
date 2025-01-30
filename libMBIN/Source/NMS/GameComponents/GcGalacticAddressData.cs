namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB8523BF1E05433E9, NameHash = 0x12504775)]
    public class GcGalacticAddressData : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public int PlanetIndex;
        [NMS(Index = 3)]
        /* 0x04 */ public int SolarSystemIndex;
        [NMS(Index = 0)]
        /* 0x08 */ public int VoxelX;
        [NMS(Index = 1)]
        /* 0x0C */ public int VoxelY;
        [NMS(Index = 2)]
        /* 0x10 */ public int VoxelZ;
    }
}
