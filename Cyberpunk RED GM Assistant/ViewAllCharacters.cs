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

        //private bool isPrinted = false;
        private List<Character> characterList;

        private Character currentlySelectedCharacter;

        public Form1 combatView; // Line 730 and 840 ish in Form1.cs

        public ViewAllCharacters(Form1 combatView)
        {
            InitializeComponent();

            //IntOnlyText(textBox1);

            characterDatabase = new CharacterDatabase(characterConnectionString);
            weaponDatabase = new WeaponDatabase(weaponConnectionString);

            //RetrieveCharacterDataToLocal();
            DisplayAllCharacters();

            this.combatView = combatView;
            //ClearAttributeDisplay();
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
            if (currentlySelectedCharacter == null)
            {
                MessageBox.Show("Please select a character first. ", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            combatView.characters.Add(currentlySelectedCharacter);
            combatView.charsInQueue.Add(currentlySelectedCharacter);
            combatView.characters.Add(currentlySelectedCharacter);
            combatView.UpdateInitiativeQueue();

        }

        // View/Edit Character Button
        private void button2_Click(object sender, EventArgs e)
        {
            if (currentlySelectedCharacter == null)
            {
                MessageBox.Show("Please select a character first. ", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //int characterID = int.Parse(textBox1.Text);
            //Form3 CheckCharacterView = new Form3(characterID);
            Form3 CheckCharacterView = new Form3(currentlySelectedCharacter.ID);
            CheckCharacterView.Show();
        }


        // Delete Character
        private void button3_Click(object sender, EventArgs e)
        {
            if (currentlySelectedCharacter == null)
            {
                MessageBox.Show("Please select a character first. ", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult result = MessageBox.Show("ARE YOU SURE YOU WANT TO DELETE THIS CHARACTER?\nTHIS ACTION CAN NOT BE UNDONE.", 
                "Confirm Message Box",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);

            if (result == DialogResult.OK)
            {
                characterDatabase.RemoveCharacterByID(currentlySelectedCharacter.ID);
                currentlySelectedCharacter = null;
                DisplayAllCharacters();
                ClearAttributeDisplay();
            }
                        
        }

        // Create Character Button
        private void button4_Click(object sender, EventArgs e)
        {
            //Form2 CreateCharacterView = new Form2();
            Form2 CreateCharacterView = new Form2(this);
            CreateCharacterView.Show();
        }

        // See All Weapons
        // Used to be Close Window

        private void button5_Click(object sender, EventArgs e)
        {
            // Simply closes this window
            //this.Hide();
            List<Weapon> weapons = weaponDatabase.GetAllWeapons();
            AllWeapons allWeapons = new AllWeapons(weapons);
            allWeapons.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        // All character views
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void RetrieveCharacterDataToLocal()
        {
            characterList = characterDatabase.GetAllCharacters();
        }

        // Only useful inside this class.
        // Gets a character object stored in the List<Characters> stored in this class. 
        private Character GetCharacterByName(string name)
        {
            foreach (Character character in characterList)
            {
                if (character.Name == name)
                {
                    return character;
                }
            }
            return null;
        }

        // Setting up all character display in the flow layout. 
        // Can be reused when character database gets updated. 
        public void DisplayAllCharacters()
        {
            flowLayoutPanel1.Controls.Clear();
            //List<Character> allCharacters = characterDatabase.GetAllCharacters();
            /*if (!isPrinted)
            {*/
            //foreach (Character character in allCharacters)
            RetrieveCharacterDataToLocal();
            foreach (Character character in characterList) 
            {
                //Character c = characterDatabase.GetCharacterByID(12);

                /*FlowLayoutPanel characterPanel = new FlowLayoutPanel();
                characterPanel.Size = new Size(255, 60);
                characterPanel.FlowDirection = FlowDirection.TopDown;
                //characterPanel.ContextMenuStrip = contextMenuStrip1;*/

                Label nameLabel = new Label();
                nameLabel.AutoSize = true;
                nameLabel.Font = new Font(nameLabel.Font.Name, 15f);
                //nameLabel.Text = $"1. {character.Name}"; // find character from charsInQueue
                nameLabel.Text = $"{character.Name}"; // find character from charsInQueue

                nameLabel.Click += new EventHandler(NameLabelClickHandler);

                //characterPanel.Controls.Add(nameLabel);

                /*Label statsLabel = new Label();
                statsLabel.AutoSize = true;
                statsLabel.Font = new Font(statsLabel.Font.Name, 13f);
                string statsText = $"HP {character.CurrentHp} | SP {character.Helmet} | SP {character.BodyArmor}"; // get character stats and chuck them in here
                statsLabel.Text = statsText;
                characterPanel.Controls.Add(statsLabel);*/

                //flowLayoutPanel1.Controls.Add(characterPanel);
                flowLayoutPanel1.Controls.Add(nameLabel);
            }
            //isPrinted = true;
            //}
        }

        private void NameLabelClickHandler(object sender, EventArgs e)
        {
            Label nameLabel = (Label)sender;
            //Character character;
            if (nameLabel != null)
            {
                Character character = GetCharacterByName(nameLabel.Text);
                currentlySelectedCharacter = character;
                //MessageBox.Show(character.Weapons);
                SetUpAttributeDisplay(character);
            }

            /*Label nameLabel = new Label();
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font(nameLabel.Font.Name, 15f);
            //nameLabel.Text = $"1. {character.Name}"; // find character from charsInQueue
            nameLabel.Text = $"{character.Name}"; // find character from charsInQueue*/
        }

        private void SetUpAttributeDisplay(Character character)
        {
            ClearAttributeDisplay();
            /*SkillsFlowLayout;
            ConditionsFlowLayout;*/

            // BELOW ARE CONDITIONS

            Label Intelligence = new Label();
            Intelligence.AutoSize = true;
            Intelligence.Font = new Font(Intelligence.Font.Name, 16f);
            Intelligence.Text = $"Intelligence: {character.Intelligence}";

            Label Reflexes = new Label();
            Reflexes.AutoSize = true;
            Reflexes.Font = new Font(Reflexes.Font.Name, 16f);
            Reflexes.Text = $"Reflexes: {character.Reflexes}";

            Label Dexterity = new Label();
            Dexterity.AutoSize = true;
            Dexterity.Font = new Font(Dexterity.Font.Name, 16f);
            Dexterity.Text = $"Dexterity: {character.Dexterity}";

            Label Technique = new Label();
            Technique.AutoSize = true;
            Technique.Font = new Font(Technique.Font.Name, 16f);
            Technique.Text = $"Technique: {character.Technique}";

            Label Cool = new Label();
            Cool.AutoSize = true;
            Cool.Font = new Font(Cool.Font.Name, 16f);
            Cool.Text = $"Cool: {character.Cool}";

            Label Will = new Label();
            Will.AutoSize = true;
            Will.Font = new Font(Will.Font.Name, 16f);
            Will.Text = $"Will: {character.Will}";

            Label Luck = new Label();
            Luck.AutoSize = true;
            Luck.Font = new Font(Luck.Font.Name, 16f);
            Luck.Text = $"Luck: {character.Luck}";

            Label Move = new Label();
            Move.AutoSize = true;
            Move.Font = new Font(Move.Font.Name, 16f);
            Move.Text = $"Move: {character.Move}";

            Label Body = new Label();
            Body.AutoSize = true;
            Body.Font = new Font(Body.Font.Name, 16f);
            Body.Text = $"Body: {character.Body}";

            Label Empathy = new Label();
            Empathy.AutoSize = true;
            Empathy.Font = new Font(Empathy.Font.Name, 16f);
            Empathy.Text = $"Empathy: {character.Empathy}";

            // BELOW ARE SKILLS

            Label Concentration = new Label();
            Concentration.AutoSize = true;
            Concentration.Font = new Font(Concentration.Font.Name, 16f);
            Concentration.Text = $"Concentration: {character.Concentration}"; 

            Label Perception = new Label();
            Perception.AutoSize = true;
            Perception.Font = new Font(Perception.Font.Name, 16f);
            Perception.Text = $"Perception: {character.Perception}"; 

            Label Athletics = new Label();
            Athletics.AutoSize = true;
            Athletics.Font = new Font(Athletics.Font.Name, 16f);
            Athletics.Text = $"Athletics: {character.Perception}"; 

            Label Brawling = new Label();
            Brawling.AutoSize = true;
            Brawling.Font = new Font(Brawling.Font.Name, 16f);
            Brawling.Text = $"Brawling: {character.Brawling}";

            Label Evasion = new Label();
            Evasion.AutoSize = true;
            Evasion.Font = new Font(Evasion.Font.Name, 16f);
            Evasion.Text = $"Evasion: {character.Evasion}";

            Label MeleeWeapon = new Label();
            MeleeWeapon.AutoSize = true;
            MeleeWeapon.Font = new Font(MeleeWeapon.Font.Name, 16f);
            MeleeWeapon.Text = $"MeleeWeapon: {character.MeleeWeapon}";

            Label Archery = new Label();
            Archery.AutoSize = true;
            Archery.Font = new Font(Archery.Font.Name, 16f);
            Archery.Text = $"Archery: {character.Archery}";

            Label Autofire = new Label();
            Autofire.AutoSize = true;
            Autofire.Font = new Font(Autofire.Font.Name, 16f);
            Autofire.Text = $"Autofire: {character.Autofire}";

            Label Handgun = new Label();
            Handgun.AutoSize = true;
            Handgun.Font = new Font(Handgun.Font.Name, 16f);
            Handgun.Text = $"Handgun: {character.Handgun}";

            Label HeavyWeapons = new Label();
            HeavyWeapons.AutoSize = true;
            HeavyWeapons.Font = new Font(HeavyWeapons.Font.Name, 16f);
            HeavyWeapons.Text = $"HeavyWeapons: {character.HeavyWeapons}";

            Label ShoulderArms = new Label();
            ShoulderArms.AutoSize = true;
            ShoulderArms.Font = new Font(ShoulderArms.Font.Name, 16f);
            ShoulderArms.Text = $"ShoulderArms: {character.ShoulderArms}";

            CharacterName.Text = character.Name;
            HPLabel.Text = $"{character.CurrentHp}/{character.MaxHp}";

            if (character.weaponList.Count() > 0)
            {
                //WeaponLabel1.Text = character.weaponList[0].name;
                foreach (Weapon weapon in character.weaponList)
                {
                    Label thisWeapon = new Label();
                    thisWeapon.AutoSize = true;
                    thisWeapon.Font = new Font(thisWeapon.Font.Name, 16f);
                    thisWeapon.Text = weapon.name;
                    WeaponFlowLayout.Controls.Add(thisWeapon);
                }
            }            

            HelmetLabel.Text = $"Helmet: {character.Helmet}";
            ArmorLabel.Text = $"Body Armor: {character.BodyArmor}";

            SkillsFlowLayout.Controls.Add(Concentration);
            SkillsFlowLayout.Controls.Add(Perception);
            SkillsFlowLayout.Controls.Add(Athletics);
            SkillsFlowLayout.Controls.Add(Brawling);
            SkillsFlowLayout.Controls.Add(Evasion);
            SkillsFlowLayout.Controls.Add(MeleeWeapon);
            SkillsFlowLayout.Controls.Add(Archery);
            SkillsFlowLayout.Controls.Add(Autofire);
            SkillsFlowLayout.Controls.Add(Handgun);
            SkillsFlowLayout.Controls.Add(HeavyWeapons);
            SkillsFlowLayout.Controls.Add(ShoulderArms);

            ConditionsFlowLayout.Controls.Add(Intelligence);
            ConditionsFlowLayout.Controls.Add(Reflexes);
            ConditionsFlowLayout.Controls.Add(Dexterity);
            ConditionsFlowLayout.Controls.Add(Technique);
            ConditionsFlowLayout.Controls.Add(Cool);
            ConditionsFlowLayout.Controls.Add(Will);
            ConditionsFlowLayout.Controls.Add(Luck);
            ConditionsFlowLayout.Controls.Add(Move);
            ConditionsFlowLayout.Controls.Add(Body);
            ConditionsFlowLayout.Controls.Add(Empathy);

        }// end of: private void SetUpAttributeDisplay(Character character)

        private void ClearAttributeDisplay()
        {
            SkillsFlowLayout.Controls.Clear();
            ConditionsFlowLayout.Controls.Clear();
            WeaponFlowLayout.Controls.Clear();

            CharacterName.Text = "";
            HPLabel.Text = "CurrentHP/MaxHP";
            //WeaponLabel1.Text = "";
            HelmetLabel.Text = "Helmet:";
            ArmorLabel.Text = "Body Armor:";
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

            // weaponID, name, ROF, type, damage, maxAmmoCount, magazineAmmoCount 
            // weaponID, name, ROF, type, damageAmount, diceType, maxAmmoCount, magazineAmmoCount
            /*weaponDatabase.InsertWeapon(new RangedWeapon(101, "GLOCK-18", 2, 0, 2, 6, 36, 12));
            weaponDatabase.InsertWeapon(new RangedWeapon(102, "FN P90", 1, 1, 2, 6, 90, 30));
            weaponDatabase.InsertWeapon(new RangedWeapon(103, "SPAS-12", 1, 2, 5, 6, 12, 4));
            weaponDatabase.InsertWeapon(new RangedWeapon(104, "HK416", 1, 3, 5, 6, 75, 25));
            weaponDatabase.InsertWeapon(new RangedWeapon(105, "M82A1", 1, 4, 5, 6, 12, 4));
            weaponDatabase.InsertWeapon(new RangedWeapon(106, "Crossbow", 1, 5, 4, 6, 10, 1));
            weaponDatabase.InsertWeapon(new RangedWeapon(107, "M320 GL", 1, 6, 6, 6, 6, 2));
            weaponDatabase.InsertWeapon(new RangedWeapon(108, "RPG", 1, 7, 8, 6, 3, 1));

            // weaponID, name, range, ROF, type, handsRequired, cost, damage, canConceal
            // weaponID, name, ROF, type, damage
            // weaponID, name, ROF, type, damageAmount, diceType
            weaponDatabase.InsertWeapon(new MeleeWeapon(201, "Dagger", 2, 0, 1, 6));
            weaponDatabase.InsertWeapon(new MeleeWeapon(202, "Axe", 2, 1, 2, 6));
            weaponDatabase.InsertWeapon(new MeleeWeapon(203, "Katana", 1, 2, 3, 6));
            weaponDatabase.InsertWeapon(new MeleeWeapon(204, "Sledgehammer", 1, 3, 4, 6));*/

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
        }

        // See All Weapons
        private void button7_Click(object sender, EventArgs e)
        {
            List<Weapon> weapons = weaponDatabase.GetAllWeapons();
            AllWeapons allWeapons = new AllWeapons(weapons);
            allWeapons.Show();
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

        private void SkillsFlowLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ConditionsFlowLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CharacterName_Click(object sender, EventArgs e)
        {

        }

        





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
