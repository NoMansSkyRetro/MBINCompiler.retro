namespace libMBIN.V1_38.Structs
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
