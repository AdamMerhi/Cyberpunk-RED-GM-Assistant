using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum RangedWeaponType
{
    Pistol,
    SMG,
    ShotgunSlug,
    AR,
    Sniper,
    Bows,
    GL,
    RPG
}

namespace Cyberpunk_RED_GM_Assistant
{
    public class RangedWeapon : Weapon
    {

        public RangedWeaponType type { get; set; }
        public int currentAmmoCount { get; set; }
        public int maxAmmoCount { get; set; }

        // Initiase a ranged weapon object by passing in data. 
        public RangedWeapon(int weaponID, string name, int range, int ROF, int ammoCount, int type, int handsRequired, int cost, int damage)
        {
            this.weaponID = weaponID;
            this.name = name;
            this.range = range;
            this.ROF = ROF;
            currentAmmoCount = ammoCount;
            maxAmmoCount = ammoCount;
            this.type = (RangedWeaponType)type;
            this.handsRequired = handsRequired;
            this.cost = cost;
            this.damage = damage;
        }

        // Initiase a ranged weapon object by passing in an ID, and retrieve the information from database using this ID. WIP
        public RangedWeapon(int weaponID)
        {
            this.weaponID = weaponID;
        }

        public RangedWeapon()
        {

        }

        // Simply decreases ammoCount when taking shot
        public void ShotsFired()
        {
            currentAmmoCount--;
        }

    }// end of: RangedWeapon() class

}
