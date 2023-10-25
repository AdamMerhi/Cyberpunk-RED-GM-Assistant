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
        public List<int> charsInQueue;

        public Form1()
        {
            charsInQueue = new List<int>(); // placeholder for list of character IDs
            charsInQueue.Add(1);
            charsInQueue.Add(2);
            charsInQueue.Add(3);

            InitializeComponent();

            // testing starts
            for(int i = 0; i < 20; i++)
            {
                AddToQueue();
                AddConditions();
            }

            for(int i = 0; i < 10; i++)
            {
                PrintCombatLog("Lorem ipsum dolor sit amet. Vel quaerat molestias id fugit ratione eum molestiae rerum et similique suscipit ut laboriosam officiis.");
            }

            for(int i = 0; i < 5; i++)
            {
                AddWeapon();
            }
            // testing ends
        }

        // needs character id in parameters to generate panel with correct text
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

            queueFlowPanel.Controls.Add(characterPanel);
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

            conditionsFlowPanel.Controls.Add(conditionPanel);
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

            weaponsFlowPanel.Controls.Add(weaponPanel);
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

            combatLogFlowPanel.Controls.Add(logPanel);
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
            ControlPaint.DrawBorder(e.Graphics, queueFlowPanel.ClientRectangle, 
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
    }
}
