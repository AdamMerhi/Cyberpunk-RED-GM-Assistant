using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Cyberpunk_RED_GM_Assistant
{
    public partial class Form1 : Form
    {
        public const string dbFilePath = "characterDb.mdf";
        private CharacterDatabase characterDatabase;
        public List<Character> characters;
        public List<int> charsInQueue; // List of character IDs of characters in Initiative Queue
        public Character activeCharacter;
        public Character focusedCharacter;

        // list of different action panels, e.g. attack panel, reload panel
        // need this so that all panels can be looped over and all but one can be hidden
        // for each panel in panels if (panel != activePanel) hide panel
        public List<Panel> actionPanels;

        public Form1()
        {
            InitializeComponent();

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\characterDb.mdf;Integrated Security=True";
            characterDatabase = new CharacterDatabase(connectionString);

            // Load all characters and store into a list
            characters = characterDatabase.GetAllCharacters();

            activeCharacter = characterDatabase.GetCharacterByID(12);

            charsInQueue = new List<int>(); // placeholder for list of character IDs
            charsInQueue.Add(1);
            charsInQueue.Add(2);
            charsInQueue.Add(3);

            actionPanels = new List<Panel>
            {
                attackPnl,
                attackRollPnl
            };

            // testing starts
            foreach(Character c in characters)
            {
                AddToQueue(c.ID);
            }

            AddConditions();

            for(int i = 0; i < 1; i++)
            {
                PrintCombatLog("Lorem ipsum dolor sit amet. Vel quaerat molestias id fugit ratione eum molestiae rerum et similique suscipit ut laboriosam officiis.");
            }

            for(int i = 0; i < 5; i++)
            {
                AddWeapon();
            }

            InitialiseAttackPanel(); // only called on Attack action
            // testing ends
        }

        private void LoadCharacters()
        {

        }

        private void ShowPanel(Panel p)
        {
            foreach(Panel panel in actionPanels) 
            {
                if(panel != p)
                {
                    panel.Hide();
                }
                else
                {
                    panel.Show();
                }
            }
        }

        // needs character id in parameters to generate panel with correct text
        private void AddToQueue(int characterID)
        {
            Character c = characterDatabase.GetCharacterByID(characterID);

            FlowLayoutPanel characterPanel = new FlowLayoutPanel();
            characterPanel.Size = new Size(255, 60);
            characterPanel.FlowDirection = FlowDirection.TopDown;
            characterPanel.ContextMenuStrip = contextMenuStrip1;

            Label nameLabel = new Label();
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font(nameLabel.Font.Name, 15f);
            nameLabel.Text = $"1. {c.Name}"; // find character from charsInQueue
            characterPanel.Controls.Add(nameLabel);

            Label statsLabel = new Label();
            statsLabel.AutoSize = true;
            statsLabel.Font = new Font(statsLabel.Font.Name, 13f);
            string statsText = $"HP {c.CurrentHp} | SP {c.Helmet} | SP {c.BodyArmor}"; // get character stats and chuck them in here
            statsLabel.Text = statsText;
            characterPanel.Controls.Add(statsLabel);

            queueFPnl.Controls.Add(characterPanel);
        }

        // needs character id in parameters to generate label with correct conditions
        private void AddConditions()
        {
            // for each condition create a new panel with text and add to the conditions flow panel
            Panel conditionPanel = new Panel();
            conditionPanel.Size = new Size(110, 25);

            Label conditionLabel = new Label();
            conditionLabel.AutoSize = true;
            conditionLabel.Font = new Font(conditionLabel.Font.Name, 13f);
            conditionLabel.Text = $"Condition"; // find condition here
            conditionPanel.Controls.Add(conditionLabel);

            conditionsFPnl.Controls.Add(conditionPanel);
        }

        // needs character id in parameters to get weapon IDs
        // then searches for weapon IDs and formats attributes into panels
        private void AddWeapon()
        {
            // for each weapon create a new flow layout panel and add to the weapons flow panel
            FlowLayoutPanel weaponPanel = new FlowLayoutPanel();
            weaponPanel.Size = new Size(372, 75);
            weaponPanel.FlowDirection = FlowDirection.LeftToRight;

            // Weapon name
            Label nameLabel = new Label();
            nameLabel.Size = new Size(180, 20);
            nameLabel.Font = new Font(nameLabel.Font.Name, 13f);
            nameLabel.Text = $"SPAS-12"; // find name here
            weaponPanel.Controls.Add(nameLabel);

            // Weapon type
            Label typeLabel = new Label();
            typeLabel.Size = new Size(180, 20);
            typeLabel.Font = new Font(typeLabel.Font.Name, 13f);
            typeLabel.Text = $"Shotgun"; // find type here
            weaponPanel.Controls.Add(typeLabel);

            // Weapon damage
            Label dmgLabel = new Label();
            dmgLabel.Size = new Size(180, 20);
            dmgLabel.Font = new Font(dmgLabel.Font.Name, 13f);
            dmgLabel.Text = $"DMG 5d6"; // find damage here
            weaponPanel.Controls.Add(dmgLabel);

            // Weapon rate of fire
            Label rofLabel = new Label();
            rofLabel.Size = new Size(180, 20);
            rofLabel.Font = new Font(rofLabel.Font.Name, 13f);
            rofLabel.Text = $"ROF 1"; // find rate of fire here
            weaponPanel.Controls.Add(rofLabel);

            // Current ammo / Reserve Ammo
            Label ammoLabel = new Label();
            ammoLabel.Size = new Size(180, 20);
            ammoLabel.Font = new Font(ammoLabel.Font.Name, 13f);
            ammoLabel.Text = $"3 / 16"; // find current ammo and reserve ammo here
            weaponPanel.Controls.Add(ammoLabel);

            // Ammo type (WIP, currently has no functional use)
            Label ammoTypeLabel = new Label();
            ammoTypeLabel.Size = new Size(180, 20);
            ammoTypeLabel.Font = new Font(ammoTypeLabel.Font.Name, 13f);
            ammoTypeLabel.Text = $"Shotgun"; // find type here
            weaponPanel.Controls.Add(ammoTypeLabel);

            weaponsFPnl.Controls.Add(weaponPanel);
        }

        // Prints a string to the combat log
        private void PrintCombatLog(string str)
        {
            Panel logPanel = new Panel();
            logPanel.AutoSize = true;

            Label logLabel = new Label();
            logLabel.MaximumSize = new Size(600, 0);
            logLabel.AutoSize = true;
            logLabel.Font = new Font(logLabel.Font.Name, 13f);
            logLabel.ForeColor = Color.White;
            logLabel.Text = str;
            logPanel.Controls.Add(logLabel);

            combatLogFPnl.Controls.Add(logPanel);
        }

        // needs character id as input to get all weapons that the character has
        private void InitialiseAttackPanel()
        {
            // Hide all action panels and show attack action panel

            // Weapon select
            // for each weapon in character's weapons
            weaponCBox.Items.Add("SPAS-12");
            weaponCBox.Items.Add("FN P90");

            // Target select
            // for each character in initiative queue
            // make sure current character is excluded
            targetCBox.Items.Add("Mike Hock");
            targetCBox.Items.Add("Deez Nuts");
            targetCBox.Items.Add("Ho-Lee Phuc");
            targetCBox.Items.Add("Oliver Closoff");
            targetCBox.Items.Add("Hugh Jass");
        }

        private void ProcessAttackAction()
        {
            int roll = Convert.ToInt32(attackRollTBox.Text);
            int dv = RangedDV("Shotgun", Convert.ToInt32(distanceTBox.Text));
            
            // Aimed shots rulebook page 171
            // If not hipfiring then subtract 8 from roll
            if(aimCBox.SelectedItem != aimCBox.Items[0])
            {
                roll -= 8;
            }

            // Subtract ammo from weapon

            // Check if attack hits
            if(roll > dv)
            {
                // attack hits
                // show roll damage panel
                PrintCombatLog("Attack hit!");
                ShowPanel(attackRollPnl);
            }
            else
            {
                // attack misses
                // show attack result panel
                PrintCombatLog("Attack missed!");
            }
        }

        private void ProcessDamageRoll()
        {
            List<TextBox> tBoxes = new List<TextBox>()
            {
                rollDmgTBox1, rollDmgTBox2, rollDmgTBox3, rollDmgTBox4, rollDmgTBox5, 
                rollDmgTBox6, rollDmgTBox7, rollDmgTBox8, rollDmgTBox9
            };
            int roll = 0;

            foreach(TextBox tBox in tBoxes)
            {
                if (int.TryParse(tBox.Text, out int i))
                {
                    roll += i;
                }
            }

            // subtract damage here

            PrintCombatLog($"{roll} damage dealt!");
        }

        // Returns a list of random integers
        private List<int> RollDice(int diceAmount, int diceType)
        {
            Random rnd = new Random();
            List<int> rolls = new List<int>();

            for(int i = 0; i < diceAmount; i++)
            {
                rolls.Add(rnd.Next(1, diceType + 1));
            }

            return rolls;
        }

        // Returns an integer for a ranged attack difficulty value given a weapon type and distance
        private int RangedDV(string type, int distance)
        {
            int dv = 99;
            switch(type)
            {
                case "Pistol":
                    switch(distance)
                    {
                        case int i when (i >= 0 && i <= 6):
                            dv = 13; 
                            break;
                        case int i when (i >= 7 && i <= 12):
                            dv = 15;
                            break;
                        case int i when (i >= 13 && i <= 25):
                            dv = 20;
                            break;
                        case int i when (i >= 26 && i <= 50):
                            dv = 25;
                            break;
                        case int i when (i >= 51 && i <= 100):
                            dv = 30;
                            break;
                        case int i when (i >= 101 && i <= 200):
                            dv = 30;
                            break;
                        case int i when (i >= 201 && i <= 400):
                            dv = 99;
                            break;
                        case int i when (i >= 401 && i <= 800):
                            dv = 99;
                            break;
                        default:
                            dv = 99;
                            break;
                    }
                    break;
                case "SMG":
                    switch (distance)
                    {
                        case int i when (i >= 0 && i <= 6):
                            dv = 15;
                            break;
                        case int i when (i >= 7 && i <= 12):
                            dv = 13;
                            break;
                        case int i when (i >= 13 && i <= 25):
                            dv = 15;
                            break;
                        case int i when (i >= 26 && i <= 50):
                            dv = 20;
                            break;
                        case int i when (i >= 51 && i <= 100):
                            dv = 25;
                            break;
                        case int i when (i >= 101 && i <= 200):
                            dv = 25;
                            break;
                        case int i when (i >= 201 && i <= 400):
                            dv = 30;
                            break;
                        case int i when (i >= 401 && i <= 800):
                            dv = 99;
                            break;
                        default:
                            dv = 99;
                            break;
                    }
                    break;
                case "Shotgun":
                    switch (distance)
                    {
                        case int i when (i >= 0 && i <= 6):
                            dv = 13;
                            break;
                        case int i when (i >= 7 && i <= 12):
                            dv = 15;
                            break;
                        case int i when (i >= 13 && i <= 25):
                            dv = 20;
                            break;
                        case int i when (i >= 26 && i <= 50):
                            dv = 25;
                            break;
                        case int i when (i >= 51 && i <= 100):
                            dv = 30;
                            break;
                        case int i when (i >= 101 && i <= 200):
                            dv = 35;
                            break;
                        case int i when (i >= 201 && i <= 400):
                            dv = 99;
                            break;
                        case int i when (i >= 401 && i <= 800):
                            dv = 99;
                            break;
                        default:
                            dv = 99;
                            break;
                    }
                    break;
                case "Assault Rifle":
                    switch (distance)
                    {
                        case int i when (i >= 0 && i <= 6):
                            dv = 17;
                            break;
                        case int i when (i >= 7 && i <= 12):
                            dv = 16;
                            break;
                        case int i when (i >= 13 && i <= 25):
                            dv = 15;
                            break;
                        case int i when (i >= 26 && i <= 50):
                            dv = 13;
                            break;
                        case int i when (i >= 51 && i <= 100):
                            dv = 15;
                            break;
                        case int i when (i >= 101 && i <= 200):
                            dv = 20;
                            break;
                        case int i when (i >= 201 && i <= 400):
                            dv = 25;
                            break;
                        case int i when (i >= 401 && i <= 800):
                            dv = 30;
                            break;
                        default:
                            dv = 99;
                            break;
                    }
                    break;
                case "Sniper Rifle":
                    switch (distance)
                    {
                        case int i when (i >= 0 && i <= 6):
                            dv = 30;
                            break;
                        case int i when (i >= 7 && i <= 12):
                            dv = 25;
                            break;
                        case int i when (i >= 13 && i <= 25):
                            dv = 25;
                            break;
                        case int i when (i >= 26 && i <= 50):
                            dv = 20;
                            break;
                        case int i when (i >= 51 && i <= 100):
                            dv = 15;
                            break;
                        case int i when (i >= 101 && i <= 200):
                            dv = 16;
                            break;
                        case int i when (i >= 201 && i <= 400):
                            dv = 17;
                            break;
                        case int i when (i >= 401 && i <= 800):
                            dv = 20;
                            break;
                        default:
                            dv = 99;
                            break;
                    }
                    break;
                case "Bow/Crossbow":
                    switch (distance)
                    {
                        case int i when (i >= 0 && i <= 6):
                            dv = 15;
                            break;
                        case int i when (i >= 7 && i <= 12):
                            dv = 13;
                            break;
                        case int i when (i >= 13 && i <= 25):
                            dv = 15;
                            break;
                        case int i when (i >= 26 && i <= 50):
                            dv = 17;
                            break;
                        case int i when (i >= 51 && i <= 100):
                            dv = 20;
                            break;
                        case int i when (i >= 101 && i <= 200):
                            dv = 22;
                            break;
                        case int i when (i >= 201 && i <= 400):
                            dv = 99;
                            break;
                        case int i when (i >= 401 && i <= 800):
                            dv = 99;
                            break;
                        default:
                            dv = 99;
                            break;
                    }
                    break;
                case "Grenade Launcher":
                    switch (distance)
                    {
                        case int i when (i >= 0 && i <= 6):
                            dv = 16;
                            break;
                        case int i when (i >= 7 && i <= 12):
                            dv = 15;
                            break;
                        case int i when (i >= 13 && i <= 25):
                            dv = 15;
                            break;
                        case int i when (i >= 26 && i <= 50):
                            dv = 17;
                            break;
                        case int i when (i >= 51 && i <= 100):
                            dv = 20;
                            break;
                        case int i when (i >= 101 && i <= 200):
                            dv = 22;
                            break;
                        case int i when (i >= 201 && i <= 400):
                            dv = 25;
                            break;
                        case int i when (i >= 401 && i <= 800):
                            dv = 99;
                            break;
                        default:
                            dv = 99;
                            break;
                    }
                    break;
                case "Rocket Launcher":
                    switch (distance)
                    {
                        case int i when (i >= 0 && i <= 6):
                            dv = 17;
                            break;
                        case int i when (i >= 7 && i <= 12):
                            dv = 16;
                            break;
                        case int i when (i >= 13 && i <= 25):
                            dv = 15;
                            break;
                        case int i when (i >= 26 && i <= 50):
                            dv = 15;
                            break;
                        case int i when (i >= 51 && i <= 100):
                            dv = 20;
                            break;
                        case int i when (i >= 101 && i <= 200):
                            dv = 20;
                            break;
                        case int i when (i >= 201 && i <= 400):
                            dv = 25;
                            break;
                        case int i when (i >= 401 && i <= 800):
                            dv = 30;
                            break;
                        default:
                            dv = 99;
                            break;
                    }
                    break;
            }
            return dv;
        }

        private void queueLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void queueFlowPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, queueFPnl.ClientRectangle, 
                Color.Red, 2, ButtonBorderStyle.Solid,
                Color.Red, 2, ButtonBorderStyle.Solid,
                Color.Red, 2, ButtonBorderStyle.Solid,
                Color.Red, 2, ButtonBorderStyle.Solid);
        }

        private void conditionsFlowPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click_1(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void weaponCBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void attackRollBtn_Click(object sender, EventArgs e)
        {
            attackRollTBox.Text = Convert.ToString(RollDice(1, 10)[0]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void viewAllCharactersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAllCharacters viewAllForm = new ViewAllCharacters();
            viewAllForm.Show();
        }

        private void attackRollPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void executeAttackBtn_Click(object sender, EventArgs e)
        {
            ProcessAttackAction();
        }

        private void executeDmgRollBtn_Click(object sender, EventArgs e)
        {
            ProcessDamageRoll();
        }

        private void rollDmgTBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rollDmgTBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void rollDmgTBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void rollDmgTBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void rollDmgTBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void rollDmgTBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void rollDmgTBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void rollDmgTBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void rollDmgTBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void rollDmgTBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void rollDmgBtn_Click(object sender, EventArgs e)
        {

        }

        private void viewAllCharactersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewAllCharacters viewAllForm = new ViewAllCharacters();
            viewAllForm.Show();
        }

        private void attackBtn_Click(object sender, EventArgs e)
        {
            ShowPanel(attackPnl);
            InitialiseAttackPanel();
        }
    }
}
