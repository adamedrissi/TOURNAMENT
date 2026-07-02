namespace Tournament
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
            System.Windows.Forms.TabControl tab1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupPlayers = new System.Windows.Forms.GroupBox();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.btn_Submit1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.groupTeam = new System.Windows.Forms.GroupBox();
            this.lbl_TeamStatus = new System.Windows.Forms.Label();
            this.rdo_Team4 = new System.Windows.Forms.RadioButton();
            this.rdo_Team3 = new System.Windows.Forms.RadioButton();
            this.rdo_Team2 = new System.Windows.Forms.RadioButton();
            this.rdo_Team1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Submit2 = new System.Windows.Forms.Button();
            this.txt_TeamName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lst_Events = new System.Windows.Forms.ListBox();
            this.btn_AddEntry = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.rdo_Team = new System.Windows.Forms.RadioButton();
            this.rdo_Individual = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_EventStatus = new System.Windows.Forms.Label();
            this.lblEventStatus = new System.Windows.Forms.Label();
            this.txt_AddEvent = new System.Windows.Forms.TextBox();
            this.btn_EventsAdd = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_DeleteEvents = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_DeletePlayers = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_DeleteTeams = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lst_Players = new System.Windows.Forms.ListBox();
            this.lst_Teams = new System.Windows.Forms.ListBox();
            this.dgv_playerscore = new System.Windows.Forms.DataGridView();
            this.numPlayerScore = new System.Windows.Forms.NumericUpDown();
            this.btn_AddScore = new System.Windows.Forms.Button();
            this.dgv_teamscore = new System.Windows.Forms.DataGridView();
            this.btn_AddTeamScore = new System.Windows.Forms.Button();
            this.numTeamScore = new System.Windows.Forms.NumericUpDown();
            tab1 = new System.Windows.Forms.TabControl();
            tab1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupPlayers.SuspendLayout();
            this.groupTeam.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_playerscore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPlayerScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_teamscore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTeamScore)).BeginInit();
            this.SuspendLayout();
            // 
            // tab1
            // 
            tab1.Controls.Add(this.tabPage3);
            tab1.Controls.Add(this.tabPage4);
            tab1.Controls.Add(this.tabPage5);
            tab1.Controls.Add(this.tabPage6);
            tab1.Dock = System.Windows.Forms.DockStyle.Left;
            tab1.Location = new System.Drawing.Point(0, 0);
            tab1.Name = "tab1";
            tab1.SelectedIndex = 0;
            tab1.Size = new System.Drawing.Size(371, 454);
            tab1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupPlayers);
            this.tabPage3.Controls.Add(this.groupTeam);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(363, 428);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Entry";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupPlayers
            // 
            this.groupPlayers.Controls.Add(this.lbl_Status);
            this.groupPlayers.Controls.Add(this.btn_Submit1);
            this.groupPlayers.Controls.Add(this.label2);
            this.groupPlayers.Controls.Add(this.label1);
            this.groupPlayers.Controls.Add(this.txt_Name);
            this.groupPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPlayers.Location = new System.Drawing.Point(0, 15);
            this.groupPlayers.Name = "groupPlayers";
            this.groupPlayers.Size = new System.Drawing.Size(357, 151);
            this.groupPlayers.TabIndex = 9;
            this.groupPlayers.TabStop = false;
            this.groupPlayers.Text = "Individuals";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Status.Location = new System.Drawing.Point(143, 115);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(0, 20);
            this.lbl_Status.TabIndex = 4;
            // 
            // btn_Submit1
            // 
            this.btn_Submit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit1.Location = new System.Drawing.Point(13, 111);
            this.btn_Submit1.Name = "btn_Submit1";
            this.btn_Submit1.Size = new System.Drawing.Size(82, 32);
            this.btn_Submit1.TabIndex = 3;
            this.btn_Submit1.Text = "Submit";
            this.btn_Submit1.UseVisualStyleBackColor = true;
            this.btn_Submit1.Click += new System.EventHandler(this.btn_Submit1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Full Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 26);
            this.label1.TabIndex = 1;
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(13, 75);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(205, 26);
            this.txt_Name.TabIndex = 0;
            // 
            // groupTeam
            // 
            this.groupTeam.Controls.Add(this.lbl_TeamStatus);
            this.groupTeam.Controls.Add(this.rdo_Team4);
            this.groupTeam.Controls.Add(this.rdo_Team3);
            this.groupTeam.Controls.Add(this.rdo_Team2);
            this.groupTeam.Controls.Add(this.rdo_Team1);
            this.groupTeam.Controls.Add(this.label5);
            this.groupTeam.Controls.Add(this.btn_Submit2);
            this.groupTeam.Controls.Add(this.txt_TeamName);
            this.groupTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupTeam.Location = new System.Drawing.Point(6, 172);
            this.groupTeam.Name = "groupTeam";
            this.groupTeam.Size = new System.Drawing.Size(351, 245);
            this.groupTeam.TabIndex = 8;
            this.groupTeam.TabStop = false;
            this.groupTeam.Text = "Teams";
            // 
            // lbl_TeamStatus
            // 
            this.lbl_TeamStatus.AutoSize = true;
            this.lbl_TeamStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TeamStatus.Location = new System.Drawing.Point(191, 210);
            this.lbl_TeamStatus.Name = "lbl_TeamStatus";
            this.lbl_TeamStatus.Size = new System.Drawing.Size(133, 20);
            this.lbl_TeamStatus.TabIndex = 15;
            this.lbl_TeamStatus.Text = "Enter Information";
            // 
            // rdo_Team4
            // 
            this.rdo_Team4.AutoSize = true;
            this.rdo_Team4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_Team4.Location = new System.Drawing.Point(195, 159);
            this.rdo_Team4.Name = "rdo_Team4";
            this.rdo_Team4.Size = new System.Drawing.Size(74, 21);
            this.rdo_Team4.TabIndex = 14;
            this.rdo_Team4.TabStop = true;
            this.rdo_Team4.Text = "Team 4";
            this.rdo_Team4.UseVisualStyleBackColor = true;
            // 
            // rdo_Team3
            // 
            this.rdo_Team3.AutoSize = true;
            this.rdo_Team3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_Team3.Location = new System.Drawing.Point(195, 129);
            this.rdo_Team3.Name = "rdo_Team3";
            this.rdo_Team3.Size = new System.Drawing.Size(74, 21);
            this.rdo_Team3.TabIndex = 13;
            this.rdo_Team3.TabStop = true;
            this.rdo_Team3.Text = "Team 3";
            this.rdo_Team3.UseVisualStyleBackColor = true;
            // 
            // rdo_Team2
            // 
            this.rdo_Team2.AutoSize = true;
            this.rdo_Team2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_Team2.Location = new System.Drawing.Point(195, 99);
            this.rdo_Team2.Name = "rdo_Team2";
            this.rdo_Team2.Size = new System.Drawing.Size(74, 21);
            this.rdo_Team2.TabIndex = 12;
            this.rdo_Team2.TabStop = true;
            this.rdo_Team2.Text = "Team 2";
            this.rdo_Team2.UseVisualStyleBackColor = true;
            // 
            // rdo_Team1
            // 
            this.rdo_Team1.AutoSize = true;
            this.rdo_Team1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_Team1.Location = new System.Drawing.Point(195, 69);
            this.rdo_Team1.Name = "rdo_Team1";
            this.rdo_Team1.Size = new System.Drawing.Size(74, 21);
            this.rdo_Team1.TabIndex = 11;
            this.rdo_Team1.TabStop = true;
            this.rdo_Team1.Text = "Team 1";
            this.rdo_Team1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Full Team Name";
            // 
            // btn_Submit2
            // 
            this.btn_Submit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit2.Location = new System.Drawing.Point(7, 198);
            this.btn_Submit2.Name = "btn_Submit2";
            this.btn_Submit2.Size = new System.Drawing.Size(82, 32);
            this.btn_Submit2.TabIndex = 7;
            this.btn_Submit2.Text = "Submit";
            this.btn_Submit2.UseVisualStyleBackColor = true;
            this.btn_Submit2.Click += new System.EventHandler(this.btn_Submit2_Click);
            // 
            // txt_TeamName
            // 
            this.txt_TeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TeamName.Location = new System.Drawing.Point(5, 111);
            this.txt_TeamName.Name = "txt_TeamName";
            this.txt_TeamName.Size = new System.Drawing.Size(183, 26);
            this.txt_TeamName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(363, 428);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Events";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lst_Events);
            this.groupBox1.Controls.Add(this.btn_AddEntry);
            this.groupBox1.Location = new System.Drawing.Point(10, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 351);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Upcoming Events";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Select an event and an individual or team from the right";
            // 
            // lst_Events
            // 
            this.lst_Events.FormattingEnabled = true;
            this.lst_Events.Location = new System.Drawing.Point(23, 37);
            this.lst_Events.Name = "lst_Events";
            this.lst_Events.Size = new System.Drawing.Size(202, 212);
            this.lst_Events.TabIndex = 7;
            // 
            // btn_AddEntry
            // 
            this.btn_AddEntry.Location = new System.Drawing.Point(23, 291);
            this.btn_AddEntry.Name = "btn_AddEntry";
            this.btn_AddEntry.Size = new System.Drawing.Size(78, 30);
            this.btn_AddEntry.TabIndex = 4;
            this.btn_AddEntry.Text = "Add";
            this.btn_AddEntry.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "Events";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.rdo_Team);
            this.tabPage5.Controls.Add(this.rdo_Individual);
            this.tabPage5.Controls.Add(this.label15);
            this.tabPage5.Controls.Add(this.lbl_EventStatus);
            this.tabPage5.Controls.Add(this.lblEventStatus);
            this.tabPage5.Controls.Add(this.txt_AddEvent);
            this.tabPage5.Controls.Add(this.btn_EventsAdd);
            this.tabPage5.Controls.Add(this.label14);
            this.tabPage5.Controls.Add(this.btn_DeleteEvents);
            this.tabPage5.Controls.Add(this.label13);
            this.tabPage5.Controls.Add(this.btn_DeletePlayers);
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.btn_DeleteTeams);
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(363, 428);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Admin";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // rdo_Team
            // 
            this.rdo_Team.AutoSize = true;
            this.rdo_Team.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.rdo_Team.Location = new System.Drawing.Point(231, 189);
            this.rdo_Team.Name = "rdo_Team";
            this.rdo_Team.Size = new System.Drawing.Size(52, 17);
            this.rdo_Team.TabIndex = 17;
            this.rdo_Team.TabStop = true;
            this.rdo_Team.Text = "Team";
            this.rdo_Team.UseVisualStyleBackColor = true;
            // 
            // rdo_Individual
            // 
            this.rdo_Individual.AutoSize = true;
            this.rdo_Individual.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.rdo_Individual.Location = new System.Drawing.Point(155, 189);
            this.rdo_Individual.Name = "rdo_Individual";
            this.rdo_Individual.Size = new System.Drawing.Size(70, 17);
            this.rdo_Individual.TabIndex = 16;
            this.rdo_Individual.TabStop = true;
            this.rdo_Individual.Text = "Individual";
            this.rdo_Individual.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 266);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(259, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Define the event as either an individual or team event";
            // 
            // lbl_EventStatus
            // 
            this.lbl_EventStatus.AutoSize = true;
            this.lbl_EventStatus.Location = new System.Drawing.Point(165, 242);
            this.lbl_EventStatus.Name = "lbl_EventStatus";
            this.lbl_EventStatus.Size = new System.Drawing.Size(0, 13);
            this.lbl_EventStatus.TabIndex = 14;
            // 
            // lblEventStatus
            // 
            this.lblEventStatus.AutoSize = true;
            this.lblEventStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventStatus.ForeColor = System.Drawing.Color.Red;
            this.lblEventStatus.Location = new System.Drawing.Point(278, 238);
            this.lblEventStatus.Name = "lblEventStatus";
            this.lblEventStatus.Size = new System.Drawing.Size(0, 17);
            this.lblEventStatus.TabIndex = 13;
            this.lblEventStatus.Visible = false;
            // 
            // txt_AddEvent
            // 
            this.txt_AddEvent.Location = new System.Drawing.Point(11, 209);
            this.txt_AddEvent.Name = "txt_AddEvent";
            this.txt_AddEvent.Size = new System.Drawing.Size(272, 20);
            this.txt_AddEvent.TabIndex = 12;
            // 
            // btn_EventsAdd
            // 
            this.btn_EventsAdd.Location = new System.Drawing.Point(8, 237);
            this.btn_EventsAdd.Name = "btn_EventsAdd";
            this.btn_EventsAdd.Size = new System.Drawing.Size(105, 26);
            this.btn_EventsAdd.TabIndex = 11;
            this.btn_EventsAdd.Text = "Add";
            this.btn_EventsAdd.UseVisualStyleBackColor = true;
            this.btn_EventsAdd.Click += new System.EventHandler(this.btn_EventsAdd_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 189);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Add Events";
            // 
            // btn_DeleteEvents
            // 
            this.btn_DeleteEvents.Location = new System.Drawing.Point(13, 314);
            this.btn_DeleteEvents.Name = "btn_DeleteEvents";
            this.btn_DeleteEvents.Size = new System.Drawing.Size(105, 26);
            this.btn_DeleteEvents.TabIndex = 8;
            this.btn_DeleteEvents.Text = "Delete";
            this.btn_DeleteEvents.UseVisualStyleBackColor = true;
            this.btn_DeleteEvents.Click += new System.EventHandler(this.btn_DeleteEvents_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 294);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(187, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Events- Select from the events screen";
            // 
            // btn_DeletePlayers
            // 
            this.btn_DeletePlayers.Location = new System.Drawing.Point(8, 134);
            this.btn_DeletePlayers.Name = "btn_DeletePlayers";
            this.btn_DeletePlayers.Size = new System.Drawing.Size(105, 26);
            this.btn_DeletePlayers.TabIndex = 5;
            this.btn_DeletePlayers.Text = "Delete";
            this.btn_DeletePlayers.UseVisualStyleBackColor = true;
            this.btn_DeletePlayers.Click += new System.EventHandler(this.btn_DeletePlayers_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(180, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Individuals- Select from the overview";
            // 
            // btn_DeleteTeams
            // 
            this.btn_DeleteTeams.Location = new System.Drawing.Point(8, 56);
            this.btn_DeleteTeams.Name = "btn_DeleteTeams";
            this.btn_DeleteTeams.Size = new System.Drawing.Size(105, 26);
            this.btn_DeleteTeams.TabIndex = 2;
            this.btn_DeleteTeams.Text = "Delete";
            this.btn_DeleteTeams.UseVisualStyleBackColor = true;
            this.btn_DeleteTeams.Click += new System.EventHandler(this.btn_DeleteTeams_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(162, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Teams- Select from the overview";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.pictureBox1);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(363, 428);
            this.tabPage6.TabIndex = 3;
            this.tabPage6.Text = "Scoring System";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 322);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(664, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 31);
            this.label7.TabIndex = 1;
            this.label7.Text = "Overview";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(425, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Individuals";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(583, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Teams";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(783, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(177, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Scoreboard (Individuals and Teams)";
            // 
            // lst_Players
            // 
            this.lst_Players.FormattingEnabled = true;
            this.lst_Players.Location = new System.Drawing.Point(370, 83);
            this.lst_Players.Name = "lst_Players";
            this.lst_Players.Size = new System.Drawing.Size(172, 173);
            this.lst_Players.TabIndex = 8;
            // 
            // lst_Teams
            // 
            this.lst_Teams.FormattingEnabled = true;
            this.lst_Teams.Location = new System.Drawing.Point(548, 83);
            this.lst_Teams.Name = "lst_Teams";
            this.lst_Teams.Size = new System.Drawing.Size(172, 173);
            this.lst_Teams.TabIndex = 9;
            // 
            // dgv_playerscore
            // 
            this.dgv_playerscore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_playerscore.Location = new System.Drawing.Point(742, 83);
            this.dgv_playerscore.Name = "dgv_playerscore";
            this.dgv_playerscore.RowTemplate.Height = 24;
            this.dgv_playerscore.Size = new System.Drawing.Size(310, 180);
            this.dgv_playerscore.TabIndex = 10;
            // 
            // numPlayerScore
            // 
            this.numPlayerScore.Location = new System.Drawing.Point(390, 267);
            this.numPlayerScore.Name = "numPlayerScore";
            this.numPlayerScore.Size = new System.Drawing.Size(67, 20);
            this.numPlayerScore.TabIndex = 11;
            // 
            // btn_AddScore
            // 
            this.btn_AddScore.Location = new System.Drawing.Point(463, 269);
            this.btn_AddScore.Name = "btn_AddScore";
            this.btn_AddScore.Size = new System.Drawing.Size(79, 28);
            this.btn_AddScore.TabIndex = 12;
            this.btn_AddScore.Text = "Enter";
            this.btn_AddScore.UseVisualStyleBackColor = true;
            this.btn_AddScore.Click += new System.EventHandler(this.btn_AddScore_Click);
            // 
            // dgv_teamscore
            // 
            this.dgv_teamscore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_teamscore.Location = new System.Drawing.Point(742, 262);
            this.dgv_teamscore.Name = "dgv_teamscore";
            this.dgv_teamscore.RowTemplate.Height = 24;
            this.dgv_teamscore.Size = new System.Drawing.Size(310, 180);
            this.dgv_teamscore.TabIndex = 13;
            // 
            // btn_AddTeamScore
            // 
            this.btn_AddTeamScore.Location = new System.Drawing.Point(641, 267);
            this.btn_AddTeamScore.Name = "btn_AddTeamScore";
            this.btn_AddTeamScore.Size = new System.Drawing.Size(79, 28);
            this.btn_AddTeamScore.TabIndex = 15;
            this.btn_AddTeamScore.Text = "Enter";
            this.btn_AddTeamScore.UseVisualStyleBackColor = true;
            this.btn_AddTeamScore.Click += new System.EventHandler(this.btn_AddTeamScore_Click);
            // 
            // numTeamScore
            // 
            this.numTeamScore.Location = new System.Drawing.Point(568, 267);
            this.numTeamScore.Name = "numTeamScore";
            this.numTeamScore.Size = new System.Drawing.Size(67, 20);
            this.numTeamScore.TabIndex = 14;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1064, 454);
            this.Controls.Add(this.btn_AddTeamScore);
            this.Controls.Add(this.numTeamScore);
            this.Controls.Add(this.dgv_teamscore);
            this.Controls.Add(this.btn_AddScore);
            this.Controls.Add(this.numPlayerScore);
            this.Controls.Add(this.dgv_playerscore);
            this.Controls.Add(this.lst_Teams);
            this.Controls.Add(this.lst_Players);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(tab1);
            this.Name = "Form1";
            this.Text = "Tournaments";
            this.Load += new System.EventHandler(this.Form1_Load);
            tab1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupPlayers.ResumeLayout(false);
            this.groupPlayers.PerformLayout();
            this.groupTeam.ResumeLayout(false);
            this.groupTeam.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_playerscore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPlayerScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_teamscore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTeamScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupPlayers;
        private System.Windows.Forms.Button btn_Submit1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupTeam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Submit2;
        private System.Windows.Forms.TextBox txt_TeamName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_AddEntry;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btn_DeleteEvents;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_DeletePlayers;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_DeleteTeams;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_EventsAdd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_AddEvent;
        private System.Windows.Forms.Label lblEventStatus;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.ListBox lst_Players;
        private System.Windows.Forms.ListBox lst_Teams;
        private System.Windows.Forms.RadioButton rdo_Team4;
        private System.Windows.Forms.RadioButton rdo_Team3;
        private System.Windows.Forms.RadioButton rdo_Team2;
        private System.Windows.Forms.RadioButton rdo_Team1;
        private System.Windows.Forms.Label lbl_TeamStatus;
        private System.Windows.Forms.Label lbl_EventStatus;
        private System.Windows.Forms.ListBox lst_Events;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_playerscore;
        private System.Windows.Forms.NumericUpDown numPlayerScore;
        private System.Windows.Forms.Button btn_AddScore;
        private System.Windows.Forms.DataGridView dgv_teamscore;
        private System.Windows.Forms.Button btn_AddTeamScore;
        private System.Windows.Forms.NumericUpDown numTeamScore;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rdo_Team;
        private System.Windows.Forms.RadioButton rdo_Individual;
        private System.Windows.Forms.Label label15;
    }
}

