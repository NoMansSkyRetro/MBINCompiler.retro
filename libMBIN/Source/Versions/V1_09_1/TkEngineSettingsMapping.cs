namespace libMBIN.V1_09_1.Structs
{
    // Same GUID in every build but the settings count grew per era: the bool array is one
    // entry per engine setting (payloads 52/56/56/60 for 1.09.1/1.13/1.24/1.38).
    public class TkEngineSettingsMapping : NMSTemplate
    {
        public float ShadowMultiplierLow;
        public float ShadowMultiplierNormal;
        public float ShadowMultiplierHigh;
        public float ShadowMultiplierUltra;
        public float ReflectionMultiplierLow;
        public float ReflectionMultiplierNormal;
        public float ReflectionMultiplierHigh;
        // one per engine setting; see the V1_38 def for the 1.38-era setting names
        [NMS(Size = 24)]
        public bool[] NeedsGameRestart;
    }
}
