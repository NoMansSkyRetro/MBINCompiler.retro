using libMBIN.NMS; using libMBIN.NMS.GameComponents; using libMBIN.NMS.Globals; using libMBIN.NMS.Toolkit; namespace libMBIN.V1_13.Structs
{
    public class TkUserServiceAuthProvider : NMSTemplate
    {
        public int AuthProvider;
        public string[] AuthProviderValues()
        {
            return new[] { "Null", "PSN", "Steam", "Galaxy" };
        }
    }
}
