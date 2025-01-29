namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA994DE52D81D6F27, NameHash = 0x53CA1E47)]
    public class GcSynchronisedBufferType : NMSTemplate
    {
        // size: 0x4
        public enum SyncBufferTypeEnum : byte {
            Refiner,
            Example1,
            Example2,
            Example3,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public SyncBufferTypeEnum SyncBufferType;
    }
}
