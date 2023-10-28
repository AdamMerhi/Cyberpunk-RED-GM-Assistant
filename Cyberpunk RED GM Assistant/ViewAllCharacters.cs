using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cyberpunk_RED_GM_Assistant
{
    public partial class ViewAllCharacters : Form
    {

        /*public const string weaponDBFilePath = "WeaponDB.mdf";
        public const string characterDBFilePath = "characterDb.mdf";*/
        public const string characterConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\characterDb.mdf;Integrated Security=True";
        public const string weaponConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\WeaponDB.mdf;Integrated Security=True";

        private CharacterDatabase characterDatabase;
        private WeaponDatabase weaponDatabase;

        private bool isPrinted = false;

        public ViewAllCharacters()
        {
            InitializeComponent();

            IntOnlyText(textBox1);

            characterDatabase = new CharacterDatabase(characterConnectionString);
            weaponDatabase = new WeaponDatabase(weaponConnectionString);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        // Add to Queue
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        // View Character Button
        private void button2_Click(object sender, EventArgs e)
        {
            int characterID = int.Parse(textBox1.Text);
            Form3 CheckCharacterView = new Form3(characterID);
            CheckCharacterView.Show();
        }

        // Delete Character Button
        private void button3_Click(object sender, EventArgs e)
        {
            // This is a untested function, IDK if it works or not
            //characterDatabase.RemoveCharacterByID(000);
        }

        // Create Character Button
        private void button4_Click(object sender, EventArgs e)
        {
            Form2 CreateCharacterView = new Form2();
            CreateCharacterView.Show();
        }

        // Close Window Button
        private void button5_Click(object sender, EventArgs e)
        {
            // Simply closes this window
            this.Hide();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        // All character views
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            if (!isPrinted)
            {
                FlowLayoutPanel characterPanel = new FlowLayoutPanel();
                characterPanel.Size = new Size(255, 60);
                characterPanel.FlowDirection = FlowDirection.TopDown;

                Label nameLabel = new Label();
                nameLabel.AutoSize = true;
                nameLabel.Font = new Font(nameLabel.Font.Name, 15f);
                nameLabel.Text = $"1. Joe Mama"; // find character from charsInQueue
                characterPanel.Controls.Add(nameLabel);

                Label statsLabel = new Label();
                statsLabel.AutoSize = true;
                statsLabel.Font = new Font(statsLabel.Font.Name, 13f);
                string statsText = $"HP 60 | SP 7 | SP 7"; // get character stats and chuck them in here
                statsLabel.Text = statsText;
                characterPanel.Controls.Add(statsLabel);

                flowLayoutPanel1.Controls.Add(characterPanel);

                isPrinted = true;   
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        // Initiase Weapons
        private void button6_Click(object sender, EventArgs e)
        {
            // Below code is for one-time adding these weapon data into the weaponDatabase. 
            // I will put this as comment, and try not to run them again as they just put replicate data into database. 

            // IDK in-game definition for melee weapon types,
            // so I am just setting up the data in my freestyle,
            // I just comment them out here so it won't execure.
            // feel free to change if u want.

            // weaponID, name, range, ROF, ammoCount, type, handsRequired, cost, damage
            weaponDatabase.InsertWeapon(new RangedWeapon(101, "GLOCK-18", 5, 900, 50, 0, 1, 10, 8));
            weaponDatabase.InsertWeapon(new RangedWeapon(102, "FN P90", 10, 900, 50, 1, 1, 10, 10));
            weaponDatabase.InsertWeapon(new RangedWeapon(103, "M870", 3, 900, 50, 2, 2, 10, 50));
            weaponDatabase.InsertWeapon(new RangedWeapon(104, "HK416", 20, 900, 50, 3, 2, 10, 20));
            weaponDatabase.InsertWeapon(new RangedWeapon(105, "M82A1", 30, 900, 50, 4, 2, 10, 50));
            weaponDatabase.InsertWeapon(new RangedWeapon(106, "Crossbow", 20, 900, 50, 5, 2, 10, 30));
            weaponDatabase.InsertWeapon(new RangedWeapon(107, "M320 GL", 15, 900, 50, 6, 2, 10, 40));
            weaponDatabase.InsertWeapon(new RangedWeapon(108, "RPG", 15, 100, 50, 7, 2, 10, 60));

            // weaponID, name, range, ROF, type, handsRequired, cost, damage, canConceal
            weaponDatabase.InsertWeapon(new MeleeWeapon(201, "Dagger", 1, 100, 0, 1, 10, true, 10));
            weaponDatabase.InsertWeapon(new MeleeWeapon(202, "Axe", 1, 100, 1, 1, 10, true, 10));
            weaponDatabase.InsertWeapon(new MeleeWeapon(203, "Katana", 1, 100, 2, 2, 10, false, 10));
            weaponDatabase.InsertWeapon(new MeleeWeapon(204, "Sledgehammer", 1, 100, 3, 2, 10, false, 10));
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //TEXT BOXES INT ONLY
        public void IntOnlyText(System.Windows.Forms.TextBox textBox)
        {
            textBox.KeyPress += (sender, e) =>
            {
                if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }

                if ((e.KeyChar == '.') && (sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }
            };
        }

        /*public enum RangedWeaponType
        {
            Pistol,
            SMG,
            ShotgunSlug,
            AR,
            Sniper,
            Bows,
            GL,
            RPG
        }*/

        /*public enum MeleeWeaponType
        {
            Light,
            Medium,
            Heavy,
            VeryHeavy
        }*/

        /*// needs character id in parameters to generate panel with correct text
        private void AddToQueue()
        {
            FlowLayoutPanel characterPanel = new FlowLayoutPanel();
            characterPanel.Size = new Size(255, 60);
            characterPanel.FlowDirection = FlowDirection.TopDown;

            Label nameLabel = new Label();
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font(nameLabel.Font.Name, 15f);
            nameLabel.Text = $"1. Joe Mama"; // find character from charsInQueue
            characterPanel.Controls.Add(nameLabel);

            Label statsLabel = new Label();
            statsLabel.AutoSize = true;
            statsLabel.Font = new Font(statsLabel.Font.Name, 13f);
            string statsText = $"HP 60 | SP 7 | SP 7"; // get character stats and chuck them in here
            statsLabel.Text = statsText;
            characterPanel.Controls.Add(statsLabel);

            queueFPnl.Controls.Add(characterPanel);
        }*/

    }
}
