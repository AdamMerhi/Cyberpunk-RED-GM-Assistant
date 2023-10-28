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
    public partial class Form3 : Form
    {
        public const string dbFilePath = "characterDb.mdf";
        private CharacterDatabase characterDatabase;
        public Form3(int characterID)
        {
            InitializeComponent();
            Form2 form2 = new Form2();

            form2.IntOnlyText(textBox1);
            form2.IntOnlyText(textBox2);
            form2.IntOnlyText(textBox3);
            form2.IntOnlyText(textBox4);
            form2.IntOnlyText(textBox5);
            form2.IntOnlyText(textBox6);
            form2.IntOnlyText(textBox7);
            form2.IntOnlyText(textBox8);
            form2.IntOnlyText(textBox9);
            form2.IntOnlyText(textBox10);
            form2.IntOnlyText(textBox16);
            form2.IntOnlyText(textBox17);
            form2.IntOnlyText(textBox18);
            form2.IntOnlyText(textBox20);
            form2.IntOnlyText(textBox21);
            form2.IntOnlyText(textBox22);
            form2.IntOnlyText(textBox23);
            form2.IntOnlyText(textBox24);
            form2.IntOnlyText(textBox25);
            form2.IntOnlyText(textBox26);
            form2.IntOnlyText(textBox27);
            form2.IntOnlyText(textBox28);
            form2.IntOnlyText(textBox29);

            //string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"dbFilePath\";Integrated Security=True";
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\characterDb.mdf;Integrated Security=True";

            characterDatabase = new CharacterDatabase(connectionString);
            LoadCharacterData(characterID);
        }
        private void LoadCharacterData(int characterID)
        {

            if (characterID <= 0)
            {
                MessageBox.Show("Please enter a valid Character ID.");
                return;
            }
            // Retrieve character data from the database for the specified character ID
            Character character = characterDatabase.GetCharacterByID(characterID);

            if (character != null)
            {
                // Populate the text boxes with the retrieved data
                textBox15.Text = character.name;
                textBox29.Text = character.intelligence.ToString();
                textBox28.Text = character.reflexes.ToString();
                textBox27.Text = character.dexterity.ToString();
                textBox26.Text = character.technique.ToString();
                textBox25.Text = character.cool.ToString();
                textBox24.Text = character.will.ToString();
                textBox23.Text = character.luck.ToString();
                textBox22.Text = character.move.ToString();
                textBox21.Text = character.body.ToString();
                textBox20.Text = character.empathy.ToString();
                textBox1.Text = character.concentration.ToString();
                textBox2.Text = character.perception.ToString();
                textBox4.Text = character.athletics.ToString();
                textBox3.Text = character.brawling.ToString();
                textBox8.Text = character.evasion.ToString();
                textBox7.Text = character.meleeWeapon.ToString();
                textBox6.Text = character.archery.ToString();
                textBox5.Text = character.autofire.ToString();
                textBox17.Text = character.handgun.ToString();
                textBox16.Text = character.heavyWeapons.ToString();
                textBox28.Text = character.shoulderArms.ToString();
                textBox9.Text = character.currentHp.ToString();
                textBox10.Text = character.maxHp.ToString();
                textBox11.Text = character.weapons;
                textBox13.Text = character.helmet.ToString();
                textBox14.Text = character.bodyArmor.ToString();

                // textBox12 was weapon2
            }
            else
            {
                MessageBox.Show("Character not found for the specified ID.");
            }

        }
        private void SaveCharacterData(int characterID)
        {
            if (characterID <= 0)
            {
                MessageBox.Show("Please enter a valid Character ID.");
                return;
            }

            if (int.TryParse(textBox29.Text, out int intelligence) &&
                int.TryParse(textBox28.Text, out int reflexes) &&
                int.TryParse(textBox27.Text, out int dexterity) &&
                int.TryParse(textBox26.Text, out int technique) &&
                int.TryParse(textBox25.Text, out int cool) &&
                int.TryParse(textBox24.Text, out int will) &&
                int.TryParse(textBox23.Text, out int luck) &&
                int.TryParse(textBox22.Text, out int move) &&
                int.TryParse(textBox21.Text, out int body) &&
                int.TryParse(textBox20.Text, out int empathy) &&
                int.TryParse(textBox1.Text, out int concentration) &&
                int.TryParse(textBox2.Text, out int perception) &&
                int.TryParse(textBox4.Text, out int athletics) &&
                int.TryParse(textBox3.Text, out int brawling) &&
                int.TryParse(textBox8.Text, out int evasion) &&
                int.TryParse(textBox7.Text, out int meleeWeapon) &&
                int.TryParse(textBox6.Text, out int archery) &&
                int.TryParse(textBox5.Text, out int autofire) &&
                int.TryParse(textBox17.Text, out int handgun) &&
                int.TryParse(textBox16.Text, out int heavyWeapons) &&
                int.TryParse(textBox28.Text, out int shoulderArms) &&
                int.TryParse(textBox9.Text, out int currentHp) &&
                int.TryParse(textBox10.Text, out int maxHp) &&
                int.TryParse(textBox13.Text, out int helmet) &&
                int.TryParse(textBox14.Text, out int bodyArmor))
            {
                // Create a Character object with the updated data
                Character character = new Character
                {
                    characterID = characterID, // Set the ID to the existing character's ID
                    name = textBox15.Text,
                    intelligence = intelligence,
                    reflexes = reflexes,
                    dexterity = dexterity,
                    technique = technique,
                    cool = cool,
                    will = will,
                    luck = luck,
                    move = move,
                    body = body,
                    empathy = empathy,
                    concentration = concentration,
                    perception = perception,
                    athletics = athletics,
                    brawling = brawling,
                    evasion = evasion,
                    meleeWeapon = meleeWeapon,
                    archery = archery,
                    autofire = autofire,
                    handgun = handgun,
                    heavyWeapons = heavyWeapons,
                    shoulderArms = shoulderArms,
                    currentHp = currentHp,
                    maxHp = maxHp,
                    weapons = textBox11.Text,
                    helmet = helmet,
                    bodyArmor = bodyArmor
                };

                // Update the character in the database using the CharacterDatabase class
                characterDatabase.UpdateCharacter(character);

                MessageBox.Show("Character data saved successfully.");
            }
            else
            {
                MessageBox.Show("Please enter valid numeric values for character attributes.");
            }
        }

        /*private void textBox19_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox19.Text, out int characterID))
            {
                // The text in textBox19 is a valid integer, so we can use it as the Character ID
                LoadCharacterData(characterID);
            }
            else
            {
                // Handle the case where the entered text is not a valid integer
                MessageBox.Show("Please enter a valid Character ID.");
            }
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            SaveCharacterData(9);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        /* private void button2_Click(object sender, EventArgs e)
         {
             if (int.TryParse(textBox19.Text, out int characterID))
             {
                 // The text in textBox19 is a valid integer, so we can use it as the Character ID
                 LoadCharacterData(characterID);
             }
             else
             {
                 // Handle the case where the entered text is not a valid integer
                 MessageBox.Show("Please enter a valid Character ID.");
             }
         }*/
    }
}
