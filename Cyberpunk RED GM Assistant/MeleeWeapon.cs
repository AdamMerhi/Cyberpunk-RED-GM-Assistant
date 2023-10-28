using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum MeleeWeaponType
{
    Light,
    Medium,
    Heavy,
    VeryHeavy
}

namespace Cyberpunk_RED_GM_Assistant
{
    internal class MeleeWeapon : Weapon
    {
        public MeleeWeaponType type { get; set; }
        /*public bool canConceal { get; set; }
        public bool isConcealed { get; set; }*/

        // Initiase a melee weapon object by passing in data. 
        //public MeleeWeapon(int weaponID, string name, int range, int ROF, int type, int handsRequired, int cost, bool canConceal, int damage)
        public MeleeWeapon(int weaponID, string name, int ROF, int type, int damage)
        {
            this.name = name;
            this.weaponID = weaponID;
            //this.range = range;
            this.ROF = ROF;
            this.type = (MeleeWeaponType)type;
            //this.handsRequired = handsRequired;
            //this.cost = cost;
            //this.canConceal = canConceal;
            this.damage = damage;
        }

        // Initiase a melee weapon object by passing in an ID, and retrieve the information from database using this ID. WIP
        public MeleeWeapon(int weaponID)
        {
            this.weaponID = weaponID;
        }

        public MeleeWeapon()
        {

        }

        // Change the isConcelaed status on this melee weapon
        // idk if this function would be useful for your character implementation, if not I can remove this function
        /*public void ToggleConceal()
        {
            if (!canConceal)
            {
                Console.WriteLine("Why you try to hide something this large");
                return;
            }
            isConcealed = !isConcealed;
        }*/

        // Use this function to check if a weapon is ranged or melee
        // True = Ranged, False = Melee
        override public bool isRangedWeapon()
        {
            return false;
        }

    }// end of: MeleeWeapon() class
}
