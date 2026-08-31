using libMBIN.NMS;
namespace libMBIN.V1_24.Structs
{
    [NMS(Alignment = 0x8)]
    public class GcGoToStateAction : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string State;

        public bool Broadcast;
        public int BroadcastLevel;
        public string[] BroadcastLevelValues()
        {
            return new[] { "Scene", "LocalModel" };
        }
    }
}
