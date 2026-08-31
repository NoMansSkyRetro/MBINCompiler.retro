using libMBIN.NMS;

namespace libMBIN.V1_00.Structs
{
    public class GcWeatherTable : NMSTemplate // disc: 8 weather files, no default hazard blocks
    {
        [NMS(Size = 8)]
        public NMSString0x80[] Table;
    }
}
