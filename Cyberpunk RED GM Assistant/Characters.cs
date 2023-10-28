using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk_RED_GM_Assistant
{
    internal class Character
    {
        public int characterID { get; set; } // set randomly on character creation
        public string name { get; set; }
        //** Status **
        public int intelligence { get; set; }
        public int reflexes { get; set; }
        public int dexterity { get; set; }
        public int technique { get; set; }
        public int cool { get; set; }
        public int will { get; set; }
        public int luck { get; set; }
        public int move { get; set; }
        public int body { get; set; }
        public int empathy { get; set; } // last stat
        //** Skills **
        public int concentration { get; set; }
        public int perception { get; set; }
        public int athletics { get; set; }
        public int brawling { get; set; }
        public int evasion { get; set; }
        public int meleeWeapon { get; set; }
        public int archery { get; set; }
        public int autofire { get; set; }
        public int handgun { get; set; }
        public int heavyWeapons { get; set; }
        public int shoulderArms { get; set; }
        public int currentHp { get; set; }
        public int maxHp { get; set; }
        public string weapons { get; set; }
        public int helmetArmor { get; set; }
        public int bodyArmor { get; set; }
        public Character()
        {

        }
        public override string ToString()
        {
            return $"{name}: Intelligence={intelligence}, Reflexes={reflexes}, Dexterity={dexterity}, " +
                   $"Technique={technique}, Cool={cool}, Will={will}, Luck={luck}, Move={move}, " +
                   $"Body={body}, Empathy={empathy}, Concentration={concentration}, Perception={perception}, " +
                   $"Athletics={athletics}, Brawling={brawling}, Evasion={evasion}, " +
                   $"MeleeWeapon={meleeWeapon}, Archery={archery}, Autofire={autofire}, " +
                   $"Handgun={handgun}, HeavyWeapons={heavyWeapons}, ShoulderArms={shoulderArms}, CurrentHp={currentHp}, MaxHp={maxHp}, Weapons={weapons}, HelmetArmor={helmetArmor}, BodyArmor={bodyArmor} ";
        }
    }
}
