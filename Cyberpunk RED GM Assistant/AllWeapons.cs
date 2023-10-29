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

            SetUpWeaponDisplay();
            ClearAttributeDisplay();

            /*foreach(Weapon weapon in weapons)
            {
                MessageBox.Show(weapon.ToString());
            }*/
        }                     

        private void MeleeWeaponsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetUpAttributeDisplay(GetWeaponsByName(MeleeWeaponsBox.Items[MeleeWeaponsBox.SelectedIndex].ToString()));
        }
                

        private void RangedWeaponsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetUpAttributeDisplay(GetWeaponsByName(RangedWeaponsBox.Items[RangedWeaponsBox.SelectedIndex].ToString()));
        }

        private void SetUpWeaponDisplay()
        {
            foreach (Weapon weapon in weapons)
            {
                if (weapon.isRangedWeapon())
                {
                    RangedWeaponsBox.Items.Add(weapon.name);
                }
                else
                {
                    MeleeWeaponsBox.Items.Add(weapon.name);
                }
            }
        }

        private void SetUpAttributeDisplay(Weapon weapon)
        {
            ClearAttributeDisplay();
            label9.Text = weapon.name;
            label10.Text = weapon.GetWeaponType();
            label11.Text = weapon.GetWeaponDamage();
            label12.Text = weapon.ROF.ToString();
            if (weapon.isRangedWeapon())
            {
                RangedWeapon thisGun = (RangedWeapon)weapon;
                label13.Text = thisGun.maxAmmoCount.ToString();
                label14.Text = thisGun.magazineSize.ToString();
            }
            else
            {
                //MeleeWeapon thisKnife = (MeleeWeapon)weapon;
                label13.Text = "N/A";
                label14.Text = "N/A";
            }
        }

        private void ClearAttributeDisplay()
        {
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
        }

        // Only useful inside this class.
        // Gets a weapon object stored in the List<Weapons> stored in this class. 
        private Weapon GetWeaponsByName(string name)
        {
            foreach (Weapon weapon in weapons)
            {
                if (weapon.name == name)
                {
                    return weapon;
                }
            }
            return null;
        }

        
    }
}
