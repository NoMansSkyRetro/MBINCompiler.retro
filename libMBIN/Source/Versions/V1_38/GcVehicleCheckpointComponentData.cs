namespace libMBIN.V1_38.Structs
{
    public class GcVehicleCheckpointComponentData : NMSTemplate
    {
        public int CheckpointType;
        public string[] CheckpointTypeValues()
        {
            return new[] { "Checkpoint", "Start", "Finish"};
        }
    }
}
