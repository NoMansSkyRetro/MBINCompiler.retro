using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libMBIN.V1_38.Structs
{
    public class TkMonitorName :NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string name;
    }
}
