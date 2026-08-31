using System.Collections.Generic;

namespace libMBIN.V1_38.Structs
{
    public class GcTerrainEdit : NMSTemplate      // size: 0x8
    {
        public int Data;        // not actually an int.... not sure what... in the test file it has it as 'TestByte'...
        public int Position;
    }
}
