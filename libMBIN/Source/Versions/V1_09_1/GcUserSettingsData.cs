using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.V1_09_1.Structs
{
    public class GcUserSettingsData : NMSTemplate
    {
        /* 0x00 */ public bool InvertLookControls;
        /* 0x01 */ public bool InvertFlightControls;
        /* 0x02 */ public bool Vibration;

        /* 0x04 */ public int ScreenBrightness;
        /* 0x08 */ public int MusicVolume;
        /* 0x0C */ public int SfxVolume;
        /* 0x10 */ public int LookSensitivity;
        /* 0x14 */ public int FlightSensitivity;
        /* 0x18 */ public int Unknown18; // added in 1.09.x (0 in the shipped file)
    }
}
