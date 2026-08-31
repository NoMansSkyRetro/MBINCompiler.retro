namespace libMBIN.V1_38.Structs
{
    public class GcMissionConditionLocation : NMSTemplate
    {
        public int MissionPlayerLocation;
        public string[] MissionPlayerLocationValues()
        {
            return new[] { "OnPlanet", "OnPlanetInVehicle", "InShipLanded" , "InShipInPlanetOrbit" , "InShipInSpace",
             "InSpaceStation", "InFreighter"};
        }
    }
}
