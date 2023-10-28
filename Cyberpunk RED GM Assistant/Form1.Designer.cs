namespace Cyberpunk_RED_GM_Assistant
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.queueLabel = new System.Windows.Forms.Label();
            this.currentTurnPnl = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.weaponsFPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.conditionsFPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.label18 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.focusPnl = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.actionPnl = new System.Windows.Forms.Panel();
            this.attackPnl = new System.Windows.Forms.Panel();
            this.attackRollBtn = new System.Windows.Forms.Button();
            this.attackRollTBox = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.distanceTBox = new System.Windows.Forms.TextBox();
            this.aimCBox = new System.Windows.Forms.ComboBox();
            this.targetCBox = new System.Windows.Forms.ComboBox();
            this.weaponCBox = new System.Windows.Forms.ComboBox();
            this.executeAttackBtn = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.endTurnBtn = new System.Windows.Forms.Button();
            this.reloadBtn = new System.Windows.Forms.Button();
            this.attackBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.queueFPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.combatLogFPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.focusCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startTurnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeFromQueueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllCharactersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentTurnPnl.SuspendLayout();
            this.actionPnl.SuspendLayout();
            this.attackPnl.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // queueLabel
            // 
            this.queueLabel.AutoSize = true;
            this.queueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queueLabel.Location = new System.Drawing.Point(12, 9);
            this.queueLabel.Name = "queueLabel";
            this.queueLabel.Size = new System.Drawing.Size(258, 31);
            this.queueLabel.TabIndex = 1;
            this.queueLabel.Text = "INITIATIVE QUEUE";
            this.queueLabel.Click += new System.EventHandler(this.queueLabel_Click);
            // 
            // currentTurnPnl
            // 
            this.currentTurnPnl.AutoScroll = true;
            this.currentTurnPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentTurnPnl.Controls.Add(this.label13);
            this.currentTurnPnl.Controls.Add(this.label14);
            this.currentTurnPnl.Controls.Add(this.label15);
            this.currentTurnPnl.Controls.Add(this.label16);
            this.currentTurnPnl.Controls.Add(this.label8);
            this.currentTurnPnl.Controls.Add(this.label9);
            this.currentTurnPnl.Controls.Add(this.label11);
            this.currentTurnPnl.Controls.Add(this.label12);
            this.currentTurnPnl.Controls.Add(this.label1);
            this.currentTurnPnl.Controls.Add(this.weaponsFPnl);
            this.currentTurnPnl.Controls.Add(this.conditionsFPnl);
            this.currentTurnPnl.Controls.Add(this.label18);
            this.currentTurnPnl.Controls.Add(this.label10);
            this.currentTurnPnl.Controls.Add(this.label7);
            this.currentTurnPnl.Controls.Add(this.label6);
            this.currentTurnPnl.Location = new System.Drawing.Point(303, 43);
            this.currentTurnPnl.Name = "currentTurnPnl";
            this.currentTurnPnl.Size = new System.Drawing.Size(630, 380);
            this.currentTurnPnl.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(122, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 20);
            this.label13.TabIndex = 26;
            this.label13.Text = "7";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(58, 99);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 20);
            this.label14.TabIndex = 25;
            this.label14.Text = "7";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(103, 99);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 20);
            this.label15.TabIndex = 24;
            this.label15.Text = "/";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(13, 99);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 25);
            this.label16.TabIndex = 23;
            this.label16.Text = "SP";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(122, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "7";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(58, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "7";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(103, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "/";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 25);
            this.label12.TabIndex = 19;
            this.label12.Text = "SP";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label12.Click += new System.EventHandler(this.label12_Click_1);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "60";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // weaponsFPnl
            // 
            this.weaponsFPnl.AutoScroll = true;
            this.weaponsFPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weaponsFPnl.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.weaponsFPnl.Location = new System.Drawing.Point(212, 49);
            this.weaponsFPnl.Name = "weaponsFPnl";
            this.weaponsFPnl.Size = new System.Drawing.Size(399, 313);
            this.weaponsFPnl.TabIndex = 17;
            this.weaponsFPnl.WrapContents = false;
            // 
            // conditionsFPnl
            // 
            this.conditionsFPnl.AutoScroll = true;
            this.conditionsFPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.conditionsFPnl.Location = new System.Drawing.Point(17, 130);
            this.conditionsFPnl.Name = "conditionsFPnl";
            this.conditionsFPnl.Size = new System.Drawing.Size(179, 233);
            this.conditionsFPnl.TabIndex = 16;
            this.conditionsFPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.conditionsFlowPanel_Paint);
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(58, 49);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 20);
            this.label18.TabIndex = 15;
            this.label18.Text = "60";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(103, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "/";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "HP";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Joe Mama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(297, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(381, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select an Action for Joe Mama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(297, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "CURRENT TURN";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // focusPnl
            // 
            this.focusPnl.AutoScroll = true;
            this.focusPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.focusPnl.Location = new System.Drawing.Point(942, 43);
            this.focusPnl.Name = "focusPnl";
            this.focusPnl.Size = new System.Drawing.Size(630, 380);
            this.focusPnl.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(936, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(326, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "FOCUSED CHARACTER";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // actionPnl
            // 
            this.actionPnl.AutoScroll = true;
            this.actionPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.actionPnl.Controls.Add(this.attackPnl);
            this.actionPnl.Controls.Add(this.endTurnBtn);
            this.actionPnl.Controls.Add(this.reloadBtn);
            this.actionPnl.Controls.Add(this.attackBtn);
            this.actionPnl.Location = new System.Drawing.Point(303, 469);
            this.actionPnl.Name = "actionPnl";
            this.actionPnl.Size = new System.Drawing.Size(630, 380);
            this.actionPnl.TabIndex = 2;
            // 
            // attackPnl
            // 
            this.attackPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.attackPnl.Controls.Add(this.attackRollBtn);
            this.attackPnl.Controls.Add(this.attackRollTBox);
            this.attackPnl.Controls.Add(this.label23);
            this.attackPnl.Controls.Add(this.distanceTBox);
            this.attackPnl.Controls.Add(this.aimCBox);
            this.attackPnl.Controls.Add(this.targetCBox);
            this.attackPnl.Controls.Add(this.weaponCBox);
            this.attackPnl.Controls.Add(this.executeAttackBtn);
            this.attackPnl.Controls.Add(this.label22);
            this.attackPnl.Controls.Add(this.label21);
            this.attackPnl.Controls.Add(this.label20);
            this.attackPnl.Controls.Add(this.label19);
            this.attackPnl.Controls.Add(this.label17);
            this.attackPnl.Location = new System.Drawing.Point(209, 12);
            this.attackPnl.Name = "attackPnl";
            this.attackPnl.Size = new System.Drawing.Size(402, 349);
            this.attackPnl.TabIndex = 3;
            // 
            // attackRollBtn
            // 
            this.attackRollBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attackRollBtn.Location = new System.Drawing.Point(175, 147);
            this.attackRollBtn.Name = "attackRollBtn";
            this.attackRollBtn.Size = new System.Drawing.Size(106, 28);
            this.attackRollBtn.TabIndex = 38;
            this.attackRollBtn.Text = "Roll 1d10";
            this.attackRollBtn.UseVisualStyleBackColor = true;
            this.attackRollBtn.Click += new System.EventHandler(this.attackRollBtn_Click);
            // 
            // attackRollTBox
            // 
            this.attackRollTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attackRollTBox.Location = new System.Drawing.Point(96, 148);
            this.attackRollTBox.Name = "attackRollTBox";
            this.attackRollTBox.Size = new System.Drawing.Size(73, 27);
            this.attackRollTBox.TabIndex = 37;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(175, 111);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(71, 25);
            this.label23.TabIndex = 36;
            this.label23.Text = "metres";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // distanceTBox
            // 
            this.distanceTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distanceTBox.Location = new System.Drawing.Point(96, 112);
            this.distanceTBox.Name = "distanceTBox";
            this.distanceTBox.Size = new System.Drawing.Size(73, 27);
            this.distanceTBox.TabIndex = 35;
            // 
            // aimCBox
            // 
            this.aimCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aimCBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aimCBox.FormattingEnabled = true;
            this.aimCBox.Items.AddRange(new object[] {
            "Hipfire",
            "Head",
            "Held Item",
            "Leg"});
            this.aimCBox.Location = new System.Drawing.Point(96, 75);
            this.aimCBox.Name = "aimCBox";
            this.aimCBox.Size = new System.Drawing.Size(150, 28);
            this.aimCBox.TabIndex = 34;
            // 
            // targetCBox
            // 
            this.targetCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.targetCBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.targetCBox.FormattingEnabled = true;
            this.targetCBox.Location = new System.Drawing.Point(96, 39);
            this.targetCBox.Name = "targetCBox";
            this.targetCBox.Size = new System.Drawing.Size(150, 28);
            this.targetCBox.TabIndex = 33;
            // 
            // weaponCBox
            // 
            this.weaponCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.weaponCBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weaponCBox.FormattingEnabled = true;
            this.weaponCBox.Location = new System.Drawing.Point(96, 3);
            this.weaponCBox.Name = "weaponCBox";
            this.weaponCBox.Size = new System.Drawing.Size(150, 28);
            this.weaponCBox.TabIndex = 32;
            this.weaponCBox.SelectedIndexChanged += new System.EventHandler(this.weaponCBox_SelectedIndexChanged);
            // 
            // executeAttackBtn
            // 
            this.executeAttackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.executeAttackBtn.Location = new System.Drawing.Point(93, 199);
            this.executeAttackBtn.Name = "executeAttackBtn";
            this.executeAttackBtn.Size = new System.Drawing.Size(150, 30);
            this.executeAttackBtn.TabIndex = 4;
            this.executeAttackBtn.Text = "Execute";
            this.executeAttackBtn.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(3, 147);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(44, 25);
            this.label22.TabIndex = 31;
            this.label22.Text = "Roll";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(3, 111);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(88, 25);
            this.label21.TabIndex = 30;
            this.label21.Text = "Distance";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(3, 75);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(46, 25);
            this.label20.TabIndex = 29;
            this.label20.Text = "Aim";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(3, 39);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(69, 25);
            this.label19.TabIndex = 28;
            this.label19.Text = "Target";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(3, 3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(87, 25);
            this.label17.TabIndex = 27;
            this.label17.Text = "Weapon";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // endTurnBtn
            // 
            this.endTurnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTurnBtn.Location = new System.Drawing.Point(11, 84);
            this.endTurnBtn.Name = "endTurnBtn";
            this.endTurnBtn.Size = new System.Drawing.Size(150, 30);
            this.endTurnBtn.TabIndex = 2;
            this.endTurnBtn.Text = "End Turn";
            this.endTurnBtn.UseVisualStyleBackColor = true;
            // 
            // reloadBtn
            // 
            this.reloadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reloadBtn.Location = new System.Drawing.Point(11, 48);
            this.reloadBtn.Name = "reloadBtn";
            this.reloadBtn.Size = new System.Drawing.Size(150, 30);
            this.reloadBtn.TabIndex = 1;
            this.reloadBtn.Text = "Reload";
            this.reloadBtn.UseVisualStyleBackColor = true;
            // 
            // attackBtn
            // 
            this.attackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attackBtn.Location = new System.Drawing.Point(11, 12);
            this.attackBtn.Name = "attackBtn";
            this.attackBtn.Size = new System.Drawing.Size(150, 30);
            this.attackBtn.TabIndex = 0;
            this.attackBtn.Text = "Attack";
            this.attackBtn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(936, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 31);
            this.label5.TabIndex = 6;
            this.label5.Text = "COMBAT LOG";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // queueFPnl
            // 
            this.queueFPnl.AutoScroll = true;
            this.queueFPnl.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.queueFPnl.Location = new System.Drawing.Point(12, 43);
            this.queueFPnl.Name = "queueFPnl";
            this.queueFPnl.Size = new System.Drawing.Size(279, 806);
            this.queueFPnl.TabIndex = 7;
            this.queueFPnl.WrapContents = false;
            this.queueFPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.queueFlowPanel_Paint);
            // 
            // combatLogFPnl
            // 
            this.combatLogFPnl.AutoScroll = true;
            this.combatLogFPnl.BackColor = System.Drawing.Color.DimGray;
            this.combatLogFPnl.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.combatLogFPnl.Location = new System.Drawing.Point(942, 469);
            this.combatLogFPnl.Name = "combatLogFPnl";
            this.combatLogFPnl.Size = new System.Drawing.Size(630, 380);
            this.combatLogFPnl.TabIndex = 8;
            this.combatLogFPnl.WrapContents = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.focusCharacterToolStripMenuItem,
            this.startTurnToolStripMenuItem,
            this.removeFromQueueToolStripMenuItem,
            this.viewDetailsToolStripMenuItem,
            this.viewAllCharactersToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(229, 156);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // focusCharacterToolStripMenuItem
            // 
            this.focusCharacterToolStripMenuItem.Name = "focusCharacterToolStripMenuItem";
            this.focusCharacterToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.focusCharacterToolStripMenuItem.Text = "Focus Character";
            // 
            // startTurnToolStripMenuItem
            // 
            this.startTurnToolStripMenuItem.Name = "startTurnToolStripMenuItem";
            this.startTurnToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.startTurnToolStripMenuItem.Text = "Start Turn";
            // 
            // removeFromQueueToolStripMenuItem
            // 
            this.removeFromQueueToolStripMenuItem.Name = "removeFromQueueToolStripMenuItem";
            this.removeFromQueueToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.removeFromQueueToolStripMenuItem.Text = "Remove From Queue";
            // 
            // viewDetailsToolStripMenuItem
            // 
            this.viewDetailsToolStripMenuItem.Name = "viewDetailsToolStripMenuItem";
            this.viewDetailsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.viewDetailsToolStripMenuItem.Text = "View Details";
            // 
            // viewAllCharactersToolStripMenuItem
            // 
            this.viewAllCharactersToolStripMenuItem.Name = "viewAllCharactersToolStripMenuItem";
            this.viewAllCharactersToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.viewAllCharactersToolStripMenuItem.Text = "View All Characters";
            this.viewAllCharactersToolStripMenuItem.Click += new System.EventHandler(this.viewAllCharactersToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.combatLogFPnl);
            this.Controls.Add(this.queueFPnl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.actionPnl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.focusPnl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.currentTurnPnl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.queueLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.currentTurnPnl.ResumeLayout(false);
            this.currentTurnPnl.PerformLayout();
            this.actionPnl.ResumeLayout(false);
            this.attackPnl.ResumeLayout(false);
            this.attackPnl.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label queueLabel;
        private System.Windows.Forms.Panel currentTurnPnl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel focusPnl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel actionPnl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.FlowLayoutPanel queueFPnl;
        private System.Windows.Forms.FlowLayoutPanel conditionsFPnl;
        private System.Windows.Forms.FlowLayoutPanel weaponsFPnl;
        private System.Windows.Forms.FlowLayoutPanel combatLogFPnl;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button attackBtn;
        private System.Windows.Forms.Button endTurnBtn;
        private System.Windows.Forms.Button reloadBtn;
        private System.Windows.Forms.Panel attackPnl;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button executeAttackBtn;
        private System.Windows.Forms.ComboBox weaponCBox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox distanceTBox;
        private System.Windows.Forms.ComboBox aimCBox;
        private System.Windows.Forms.ComboBox targetCBox;
        private System.Windows.Forms.TextBox attackRollTBox;
        private System.Windows.Forms.Button attackRollBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem focusCharacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startTurnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeFromQueueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllCharactersToolStripMenuItem;
    }
}

