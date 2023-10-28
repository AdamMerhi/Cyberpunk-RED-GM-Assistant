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
    public partial class ViewAllCharacters : Form
    {

        public const string weaponDBFilePath = "WeaponDB.mdf";
        public const string characterDBFilePath = "characterDb.mdf";
        private CharacterDatabase characterDatabase;
        private WeaponDatabase weaponDatabase;

        public ViewAllCharacters()
        {
            InitializeComponent();

            /*string characterConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"characterDBFilePath\";Integrated Security=True";
            string weaponConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={weaponDBFilePath};Integrated Security=True";
            */
            string characterConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"characterDBFilePath\";Integrated Security=True";
            //string weaponConnectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"{weaponDBFilePath}\";Integrated Security=True";
            string weaponConnectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={weaponDBFilePath};Integrated Security=True";

            //$"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={dbFilePath};Integrated Security=True"


            characterDatabase = new CharacterDatabase(characterConnectionString);
            weaponDatabase = new WeaponDatabase(weaponConnectionString);

            //weaponDatabase.InsertWeapon(new RangedWeapon(101, "FN P90", 10, 900, 50, 1, 1, 10, 10));
            //LoadCharacterData(characterID);
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
            weaponDatabase.InsertWeapon(new RangedWeapon(101, "FN P90", 10, 900, 50, 1, 1, 10, 10));
        }

        // View Character Button
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 CheckCharacterView = new Form3(11);
            CheckCharacterView.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        // Create Character Button
        private void button4_Click(object sender, EventArgs e)
        {
            Form2 CreateCharacterView = new Form2();
            CreateCharacterView.Show();
        }

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
        }

        private void ViewAllCharacters_Load(object sender, EventArgs e)
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
