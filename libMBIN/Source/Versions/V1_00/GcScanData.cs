namespace libMBIN.V1_00.Structs
{
    public class GcScanData : NMSTemplate // disc: 0x10, no ChargeTime
    {
        public int ScanType;
        public string[] ScanTypeValues()
        {
            return new[] { "Tool", "Beacon", "RadioTower", "Observatory", "DistressSignal", "Waypoint", "Ship", "DebugPlanet", "DebugSpace" };
        }

        public float PulseRange;
        public float PulseTime;
        public bool PlayAudioMarkers;
    }
}
