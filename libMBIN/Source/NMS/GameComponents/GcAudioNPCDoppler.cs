using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4455F1C4CA56E06C, NameHash = 0x308DBEDE)]
    public class GcAudioNPCDoppler : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x7, EnumType = typeof(GcAISpaceshipTypes.ShipTypeEnum))]
        /* 0x0 */ public GcAudio3PointDopplerData[] Config;
    }
}
