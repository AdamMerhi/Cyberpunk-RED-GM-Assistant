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
using MySql.Data.MySqlClient;



namespace Cyberpunk_RED_GM_Assistant
{
    public partial class Form2 : Form
    {
        public const string dbFilePath = "characterDb.mdf";
        private CharacterDatabase characterDatabase;
        private List<Character> characterList = new List<Character>();

        public Form2()
        {
            InitializeComponent();

            IntOnlyText(textBox1);
            IntOnlyText(textBox2);
            IntOnlyText(textBox3);
            IntOnlyText(textBox4);
            IntOnlyText(textBox5); 
            IntOnlyText(textBox6);
            IntOnlyText(textBox7);
            IntOnlyText(textBox8);  
            IntOnlyText(textBox9);
            IntOnlyText(textBox10);
            IntOnlyText(textBox16);
            IntOnlyText(textBox17);
            IntOnlyText(textBox18);
            IntOnlyText(textBox20);
            IntOnlyText(textBox21);
            IntOnlyText(textBox22);
            IntOnlyText(textBox23);
            IntOnlyText(textBox24);
            IntOnlyText(textBox25);
            IntOnlyText(textBox26);
            IntOnlyText(textBox27);
            IntOnlyText(textBox28);
            IntOnlyText(textBox29);

            //string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"dbFilePath\";Integrated Security=True";
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\characterDb.mdf;Integrated Security=True";
            characterDatabase  = new CharacterDatabase(connectionString);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Capture user input into a Character object
            Character character = new Character
            {
                name = textBox15.Text,
                intelligence = int.Parse(textBox29.Text),
                reflexes = int.Parse(textBox28.Text),
                dexterity = int.Parse(textBox27.Text),
                technique = int.Parse(textBox26.Text),
                cool = int.Parse(textBox25.Text),
                will = int.Parse(textBox24.Text),
                luck = int.Parse(textBox23.Text),
                move = int.Parse(textBox22.Text),
                body = int.Parse(textBox21.Text),
                empathy = int.Parse(textBox20.Text),
                concentration = int.Parse(textBox1.Text),
                perception = int.Parse(textBox2.Text),
                athletics = int.Parse(textBox4.Text),
                brawling = int.Parse(textBox3.Text),
                evasion = int.Parse(textBox8.Text),
                meleeWeapon = int.Parse(textBox7.Text),
                archery = int.Parse(textBox6.Text),
                autofire = int.Parse(textBox5.Text),
                handgun = int.Parse(textBox17.Text),
                heavyWeapons = int.Parse(textBox16.Text),
                shoulderArms = int.Parse(textBox28.Text),
                currentHp = int.Parse(textBox9.Text),
                maxHp = int.Parse(textBox10.Text),
                weapons = textBox11.Text,
                helmet = int.Parse(textBox13.Text),
                bodyArmor = int.Parse(textBox14.Text),
            };

            // Insert the character into the database using the CharacterDatabase class
            characterDatabase.InsertCharacter(character);
            characterList.Add(character);
            MessageBox.Show(character.ToString());
            //listBox1.Items.Add(character.ToString());
        }


        //TEXT BOXES INT ONLY
        public void IntOnlyText(TextBox textBox)
        {
            textBox.KeyPress += (sender, e) =>
            {
                if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }

                if ((e.KeyChar == '.') && (sender as TextBox).Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }
            };
        }

    }
}
