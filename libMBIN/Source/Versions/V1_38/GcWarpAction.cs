namespace libMBIN.V1_38.Structs
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
