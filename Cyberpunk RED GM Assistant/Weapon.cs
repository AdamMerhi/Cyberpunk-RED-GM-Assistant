using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk_RED_GM_Assistant
{
    internal abstract class Weapon
    {
        //public string weaponID { get; set; }
        public int weaponID {  get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int damage { get; set; }

        // this one is my bad, didn't make clear in reqs doc but can you change damage to two variables please?
        // i need one called damageDiceAmount which is the number of dice you roll when you land a hit,
        // and i need another called damageDiceType, which is the type of dice you roll;
        // e.g. 2d10 means damageDiceAmount = 2, damageDiceType = 10

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
    }
}
