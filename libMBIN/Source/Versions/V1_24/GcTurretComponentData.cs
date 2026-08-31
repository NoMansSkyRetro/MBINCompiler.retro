namespace libMBIN.V1_24.Structs
{
    public class GcTurretComponentData : NMSTemplate
    {
        public int GunType;
        public string[] GunTypeValues()
        {
            return new[] { "Laser", "Projectile", "Missile" };
        }
    }
}
