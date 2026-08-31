using libMBIN.NMS;
namespace libMBIN.V1_24.Structs
{
    public class GcSolarSystemTraderSpawnData : NMSTemplate
    {
        public int MaxToSpawn;
        public float InitialTakeoffDelay;
        public Vector2f SequenceTakeoffDelay;
        public int ChanceToDelayLaunch;
    }
}
