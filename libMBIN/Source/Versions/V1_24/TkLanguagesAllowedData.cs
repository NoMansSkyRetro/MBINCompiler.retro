using System.Collections.Generic;

namespace libMBIN.V1_24.Structs
{
    public class TkLanguagesAllowedData : NMSTemplate
    {
        public List<TkLanguages> Allowed;
        public TkLanguages Language;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding14;
    }
}
