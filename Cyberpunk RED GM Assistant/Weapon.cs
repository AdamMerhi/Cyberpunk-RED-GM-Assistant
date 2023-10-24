using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk_RED_GM_Tool
{
    internal abstract class Weapon
    {
        public string weaponID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int damage { get; set; }
        public int ROF { get; set; }
        public int handsRequired { get; set; }
        public int range { get; set; }
        public int cost { get; set; }
    }
}
