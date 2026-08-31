namespace libMBIN.V1_24.Structs
{
    public class GcWarpAction : NMSTemplate
    {
        public int WarpType;
        public string[] WarpTypeValues()
        {
            return new[] { "BlackHole" }; // one value? :D:D
        }
    }
}
