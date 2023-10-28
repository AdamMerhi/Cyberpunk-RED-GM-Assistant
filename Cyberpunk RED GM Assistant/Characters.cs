using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk_RED_GM_Assistant
{
    internal class Character
    {
        public int ID { get; set; } // set randomly on character creation
        public string Name { get; set; }
        //** Status **
        public int Intelligence { get; set; }
        public int Reflexes { get; set; }
        public int Dexterity { get; set; }
        public int Technique { get; set; }
        public int Cool { get; set; }
        public int Will { get; set; }
        public int Luck { get; set; }
        public int Move { get; set; }
        public int Body { get; set; }
        public int Empathy { get; set; } // last stat
                //** Skills **
        public int Concentration { get; set; }
        public int Perception { get; set; }
        public int Athletics { get; set; }
        public int Brawling { get; set; }
        public int Evasion { get; set; }
        public int MeleeWeapon { get; set; }
        public int Archery { get; set; }
        public int Autofire { get; set; }
        public int Handgun { get; set; }
        public int HeavyWeapons { get; set; }
        public int ShoulderArms { get; set; }
        public int CurrentHp { get; set; }
        public int MaxHp { get; set; }
        public string Weapon1 { get; set; }
        public string Weapon2 { get; set; }
        public string Armor1 { get; set; }
        public string Armor2 { get; set; }
        public Character()
        {

        }
        public override string ToString()
        {
            return $"{Name}: Intelligence={Intelligence}, Reflexes={Reflexes}, Dexterity={Dexterity}, " +
                   $"Technique={Technique}, Cool={Cool}, Will={Will}, Luck={Luck}, Move={Move}, " +
                   $"Body={Body}, Empathy={Empathy}, Concentration={Concentration}, Perception={Perception}, " +
                   $"Athletics={Athletics}, Brawling={Brawling}, Evasion={Evasion}, " +
                   $"MeleeWeapon={MeleeWeapon}, Archery={Archery}, Autofire={Autofire}, " +
                   $"Handgun={Handgun}, HeavyWeapons={HeavyWeapons}, ShoulderArms={ShoulderArms}, CurrentHp={CurrentHp}, MaxHp={MaxHp}, Weapon1={Weapon1}, Weapon2={Weapon2}, Armor1={Armor1}, Armor2={Armor2} ";
        }


    }
}
