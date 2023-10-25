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

            for(int i = 0; i < 20; i++)
            {
                AddToQueue();
                AddConditions();
            }
        }

        // needs character id in parameters to generate panel with correct text
        private void AddToQueue()
        {
            FlowLayoutPanel characterPanel = new FlowLayoutPanel();
            characterPanel.Size = new Size(255, 60);

            Label nameLabel = new Label();
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font(nameLabel.Font.Name, 15f);
            string nameText = $"1. Joe Mama"; // find character from charsInQueue
            nameLabel.Text = nameText;
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
            string text = $"Condition"; // find condition here
            conditionLabel.Text = text;
            conditionPanel.Controls.Add(conditionLabel);

            conditionsFlowPanel.Controls.Add(conditionPanel);
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
    }
}
