namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x232C3926E779F421, NameHash = 0x6708AA89)]
    public class GcPlayerWeapons : NMSTemplate
    {
        // size: 0x14
        public enum WeaponModeEnum : uint {
            Bolt,
            Shotgun,
            Burst,
            Rail,
            Cannon,
            Laser,
            Grenade,
            MineGrenade,
            Scope,
            FrontShield,
            Melee,
            TerrainEdit,
            SunLaser,
            Spawner,
            SpawnerAlt,
            SoulLaser,
            Flamethrower,
            StunGrenade,
            Stealth,
            FishLaser,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public WeaponModeEnum WeaponMode;
    }
}
