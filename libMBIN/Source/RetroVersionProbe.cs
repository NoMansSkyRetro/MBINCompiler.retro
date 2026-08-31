namespace libMBIN.NMS {

    /// <summary>
    /// Self-test for the retro version-filtered field walk. Field presence is gated per build,
    /// so <c>dumplayout --nms-version=&lt;id&gt;</c> reports a different size and field count for
    /// each build:
    ///   rc1 / 1.09.1 / 1.13  -> Base only            (size 0x4)
    ///   1.24 (Path Finder)   -> + PathFinderField     (size 0x8)
    ///   1.38 (Atlas Rises)   -> + AtlasField          (size 0xC)
    /// This exercises the real mechanism (OffsetOf / SizeOf are version-filtered), not a mock.
    /// </summary>
    [NMS]
    public class GcRetroVersionProbe : NMSTemplate {
        public int Base;
        [NMSVersion( First = "1.24" )] public int   PathFinderField;
        [NMSVersion( First = "1.38" )] public float AtlasField;
    }
}
