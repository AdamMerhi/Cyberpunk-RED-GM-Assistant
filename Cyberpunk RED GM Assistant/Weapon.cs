using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk_RED_GM_Assistant
{
    public abstract class Weapon
    {
        //public string weaponID { get; set; }
        public int weaponID {  get; set; }
        public string name { get; set; }
        public string description { get; set; }

        // The number of dice you roll when you land a hit
        public int damageDiceAmount {  get; set; }
        // The type of dice you roll
        public int damageDiceType { get; set; }
        public int ROF { get; set; }
        /*public int handsRequired { get; set; }
        public int range { get; set; }
        public int cost { get; set; }*/

        // Use this function to check if a weapon is ranged or melee.
        // Implementation is located inside the RangedWeapon and MeleeWeapon subclass. 
        // True = Ranged, False = Melee
        public abstract bool isRangedWeapon();

        public abstract string ToString();

        public abstract string GetWeaponType();

        public abstract string GetWeaponDamage();
    }
}
