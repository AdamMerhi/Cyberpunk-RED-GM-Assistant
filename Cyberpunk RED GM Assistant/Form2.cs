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

        private ViewAllCharacters higherView;

        public Form2()
        {
            InitializeComponent();

            //this.higherView = higherView;

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
            characterDatabase = new CharacterDatabase(connectionString);

        }

        public Form2(ViewAllCharacters higherView)
        {
            InitializeComponent();

            this.higherView = higherView;

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
                Name = textBox15.Text,
                Intelligence = int.Parse(textBox29.Text),
                Reflexes = int.Parse(textBox28.Text),
                Dexterity = int.Parse(textBox27.Text),
                Technique = int.Parse(textBox26.Text),
                Cool = int.Parse(textBox25.Text),
                Will = int.Parse(textBox24.Text),
                Luck = int.Parse(textBox23.Text),
                Move = int.Parse(textBox22.Text),
                Body = int.Parse(textBox21.Text),
                Empathy = int.Parse(textBox20.Text),
                Concentration = int.Parse(textBox1.Text),
                Perception = int.Parse(textBox2.Text),
                Athletics = int.Parse(textBox4.Text),
                Brawling = int.Parse(textBox3.Text),
                Evasion = int.Parse(textBox8.Text),
                MeleeWeapon = int.Parse(textBox7.Text),
                Archery = int.Parse(textBox6.Text),
                Autofire = int.Parse(textBox5.Text),
                Handgun = int.Parse(textBox17.Text),
                HeavyWeapons = int.Parse(textBox16.Text),
                ShoulderArms = int.Parse(textBox28.Text),
                CurrentHp = int.Parse(textBox9.Text),
                MaxHp = int.Parse(textBox10.Text),
                Weapons = textBox11.Text,
                //Weapon2 = textBox12.Text,
                Helmet = int.Parse(textBox13.Text),
                BodyArmor = int.Parse(textBox14.Text),
            };

            // Insert the character into the database using the CharacterDatabase class
            characterDatabase.InsertCharacter(character);
            characterList.Add(character);

            higherView.DisplayAllCharacters();

            MessageBox.Show($"Character {textBox15.Text} created successfully!\nPress OK to return to all characters view.");
            this.Hide();
            //higherView.
            //MessageBox.Show(character.ToString());
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
