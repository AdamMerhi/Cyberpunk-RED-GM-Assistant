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
    internal class RangedWeapon : Weapon
    {

        public RangedWeaponType type { get; set; }
        public int maxAmmoCount { get; set; }
        public int magazineSize {  get; set; }
        public int magazineAmmoCount { get; set; }        
        public int reserveAmmoCount {  get; set; }

        // Initiase a ranged weapon object by passing in data. 
        //public RangedWeapon(int weaponID, string name, int range, int ROF, int maxAmmoCount, int magazineAmmoCount, int type, int handsRequired, int cost, int damage)
        public RangedWeapon(int weaponID, string name, int ROF, int type, int damage, int maxAmmoCount, int magazineAmmoCount)
        {
            this.weaponID = weaponID;
            this.name = name;
            //this.range = range;
            this.ROF = ROF;            
            this.type = (RangedWeaponType)type;
            /*this.handsRequired = handsRequired;
            this.cost = cost;*/
            this.damage = damage;

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

        // Use this function to check if a weapon is ranged or melee
        // True = Ranged, False = Melee
        override public bool isRangedWeapon()
        {
            return true;
        }

    }// end of: RangedWeapon() class

}
