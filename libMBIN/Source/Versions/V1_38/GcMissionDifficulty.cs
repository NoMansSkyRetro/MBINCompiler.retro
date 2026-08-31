using System.Collections.Generic;

namespace libMBIN.V1_38.Structs
{
    public class GcMissionDifficulty : NMSTemplate
    {
        public int MissionDifficulty;
        public string[] MissionDifficultyValues()
        {
            return new[] { "Easy", "Normal", "Hard"};
        }
    }
}
