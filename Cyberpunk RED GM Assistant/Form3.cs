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

            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\School\\uni\\Year Two\\SEM TWO\\Development .NET\\Assignment 2\\Cyberpunk-RED-GM-Assistant\\Cyberpunk RED GM Assistant\\characterDb.mdf\";Integrated Security=True";
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
                textBox15.Text = character.Name;
                textBox29.Text = character.Intelligence.ToString();
                textBox28.Text = character.Reflexes.ToString();
                textBox27.Text = character.Dexterity.ToString();
                textBox26.Text = character.Technique.ToString();
                textBox25.Text = character.Cool.ToString();
                textBox24.Text = character.Will.ToString();
                textBox23.Text = character.Luck.ToString();
                textBox22.Text = character.Move.ToString();
                textBox21.Text = character.Body.ToString();
                textBox20.Text = character.Empathy.ToString();
                textBox1.Text = character.Concentration.ToString();
                textBox2.Text = character.Perception.ToString();
                textBox4.Text = character.Athletics.ToString();
                textBox3.Text = character.Brawling.ToString();
                textBox8.Text = character.Evasion.ToString();
                textBox7.Text = character.MeleeWeapon.ToString();
                textBox6.Text = character.Archery.ToString();
                textBox5.Text = character.Autofire.ToString();
                textBox17.Text = character.Handgun.ToString();
                textBox16.Text = character.HeavyWeapons.ToString();
                textBox28.Text = character.ShoulderArms.ToString();
                textBox9.Text = character.CurrentHp.ToString();
                textBox10.Text = character.MaxHp.ToString();
                textBox11.Text = character.Weapon1;
                textBox12.Text = character.Weapon2;
                textBox13.Text = character.Armor1;
                textBox14.Text = character.Armor2;
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
                int.TryParse(textBox10.Text, out int maxHp))
            {
                // Create a Character object with the updated data
                Character character = new Character
                {
                    ID = characterID, // Set the ID to the existing character's ID
                    Name = textBox15.Text,
                    Intelligence = intelligence,
                    Reflexes = reflexes,
                    Dexterity = dexterity,
                    Technique = technique,
                    Cool = cool,
                    Will = will,
                    Luck = luck,
                    Move = move,
                    Body = body,
                    Empathy = empathy,
                    Concentration = concentration,
                    Perception = perception,
                    Athletics = athletics,
                    Brawling = brawling,
                    Evasion = evasion,
                    MeleeWeapon = meleeWeapon,
                    Archery = archery,
                    Autofire = autofire,
                    Handgun = handgun,
                    HeavyWeapons = heavyWeapons,
                    ShoulderArms = shoulderArms,
                    CurrentHp = currentHp,
                    MaxHp = maxHp,
                    Weapon1 = textBox11.Text,
                    Weapon2 = textBox12.Text,
                    Armor1 = textBox13.Text,
                    Armor2 = textBox14.Text
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
