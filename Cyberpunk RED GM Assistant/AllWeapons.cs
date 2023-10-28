using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cyberpunk_RED_GM_Assistant
{
    public partial class AllWeapons : Form
    {
        public List<Weapon> weapons = new List<Weapon>();
        /*public AllWeapons()
        {
            InitializeComponent();
        }*/

        public AllWeapons(List<Weapon> weapons)
        {
            InitializeComponent();
            this.weapons = weapons;

            foreach(Weapon weapon in weapons)
            {
                MessageBox.Show(weapon.ToString());
            }
        }
    }
}
