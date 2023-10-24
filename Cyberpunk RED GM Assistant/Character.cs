using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk_RED_GM_Tool
{
    internal class Character
    {
        public string name { get; set; }
        public int id { get; set; }

        public List<Weapon> weapons;

        public Character(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
    }
}
