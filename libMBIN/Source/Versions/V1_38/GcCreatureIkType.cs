namespace libMBIN.V1_38.Structs
{
    public class GcCreatureIkType : NMSTemplate
    {
        public int CreatureIkType;
        public string[] CreatureIkTypeValues()
        {
            return new[] { "Foot", "Hinge_X", "Hinge_Y", "Hinge_Z", "Locked", "Head", "Toe", "SpaceshipFoot", "SpaceshipToe" };
        }
    }
}
