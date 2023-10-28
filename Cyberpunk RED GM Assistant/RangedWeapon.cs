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
        // const
        public int maxAmmoCount { get; set; }
        // const
        public int magazineSize { get; set; }
        public int magazineAmmoCount { get; set; }        
        public int reserveAmmoCount { get; set; }

        // Initiase a ranged weapon object by passing in data. 
        //public RangedWeapon(int weaponID, string name, int range, int ROF, int maxAmmoCount, int magazineAmmoCount, int type, int handsRequired, int cost, int damage)
        public RangedWeapon(int weaponID, string name, int ROF, int type, int damageAmount, int diceType, int maxAmmoCount, int magazineAmmoCount)
        {
            this.weaponID = weaponID;
            this.name = name;
            //this.range = range;
            this.ROF = ROF;            
            this.type = (RangedWeaponType)type;
            /*this.handsRequired = handsRequired;
            this.cost = cost;*/
            this.damageDiceAmount = damageAmount;
            this.damageDiceType = diceType;

            this.maxAmmoCount = maxAmmoCount;
            this.reserveAmmoCount = maxAmmoCount;
            this.magazineSize = magazineAmmoCount;
            this.magazineAmmoCount = magazineAmmoCount;
            
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
            magazineAmmoCount--;
        }

        // Handles the logic for reloading the weapon
        public void ReloadWeapon()
        {
            if (reserveAmmoCount > magazineSize)
            {
                magazineAmmoCount = magazineSize;
                reserveAmmoCount = reserveAmmoCount - magazineAmmoCount;
                //reserveAmmoCount = maxAmmoCount;
            }
            else
            {
                magazineAmmoCount += reserveAmmoCount;
                reserveAmmoCount = 0;
            }
        }

        // Have the reserveAmmoCount return to the maxAmmoCount level
        public void ResupplyAmmo()
        {
            reserveAmmoCount = maxAmmoCount;
        }

    }// end of: RangedWeapon() class

}
