namespace StudyCenterPresentation
{
    partial class MainForm
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
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label22 = new System.Windows.Forms.Label();
            this.lbemail = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblcountUsers = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lblCountGradeLevels = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lblCountMeetings = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.lblcountGroups = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.lblCountPayments = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.lblCountSubjects = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.lblCountTeachers = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.lblCountStudents = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.lblCountClasses = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.btnAddUsers = new System.Windows.Forms.Button();
            this.btnAddGradeLevel = new System.Windows.Forms.Button();
            this.btnAddMeeting = new System.Windows.Forms.Button();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.btnAddPayments = new System.Windows.Forms.Button();
            this.btnAddSubjects = new System.Windows.Forms.Button();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label44 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.lbtimer = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnstudents = new System.Windows.Forms.ToolStripMenuItem();
            this.btnteachers = new System.Windows.Forms.ToolStripMenuItem();
            this.btnsubjects = new System.Windows.Forms.ToolStripMenuItem();
            this.btnclasses = new System.Windows.Forms.ToolStripMenuItem();
            this.btngroups = new System.Windows.Forms.ToolStripMenuItem();
            this.btnpayments = new System.Windows.Forms.ToolStripMenuItem();
            this.btnsettings = new System.Windows.Forms.ToolStripMenuItem();
            this.btnlogout = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::StudyCenterPresentation.Properties.Resources.close__3_1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(1391, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 50);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label22.Location = new System.Drawing.Point(15, 421);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(72, 25);
            this.label22.TabIndex = 6;
            this.label22.Text = "Email:";
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbemail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbemail.Location = new System.Drawing.Point(15, 472);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(34, 25);
            this.lbemail.TabIndex = 8;
            this.lbemail.Text = "\" \"";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2Panel1.BorderColor = System.Drawing.Color.DarkCyan;
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.BorderThickness = 3;
            this.guna2Panel1.Controls.Add(this.lblcountUsers);
            this.guna2Panel1.Controls.Add(this.label25);
            this.guna2Panel1.Controls.Add(this.lblCountGradeLevels);
            this.guna2Panel1.Controls.Add(this.label27);
            this.guna2Panel1.Controls.Add(this.lblCountMeetings);
            this.guna2Panel1.Controls.Add(this.label29);
            this.guna2Panel1.Controls.Add(this.lblcountGroups);
            this.guna2Panel1.Controls.Add(this.label31);
            this.guna2Panel1.Controls.Add(this.lblCountPayments);
            this.guna2Panel1.Controls.Add(this.label33);
            this.guna2Panel1.Controls.Add(this.lblCountSubjects);
            this.guna2Panel1.Controls.Add(this.label35);
            this.guna2Panel1.Controls.Add(this.lblCountTeachers);
            this.guna2Panel1.Controls.Add(this.label37);
            this.guna2Panel1.Controls.Add(this.lblCountStudents);
            this.guna2Panel1.Controls.Add(this.label39);
            this.guna2Panel1.Controls.Add(this.lblCountClasses);
            this.guna2Panel1.Controls.Add(this.label41);
            this.guna2Panel1.Controls.Add(this.btnAddUsers);
            this.guna2Panel1.Controls.Add(this.btnAddGradeLevel);
            this.guna2Panel1.Controls.Add(this.btnAddMeeting);
            this.guna2Panel1.Controls.Add(this.btnAddGroup);
            this.guna2Panel1.Controls.Add(this.btnAddPayments);
            this.guna2Panel1.Controls.Add(this.btnAddSubjects);
            this.guna2Panel1.Controls.Add(this.btnAddTeacher);
            this.guna2Panel1.Controls.Add(this.btnAddStudent);
            this.guna2Panel1.Controls.Add(this.btnAddClass);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.DarkCyan;
            this.guna2Panel1.ForeColor = System.Drawing.Color.DarkCyan;
            this.guna2Panel1.Location = new System.Drawing.Point(1134, 194);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(306, 555);
            this.guna2Panel1.TabIndex = 9;
            // 
            // lblcountUsers
            // 
            this.lblcountUsers.AutoSize = true;
            this.lblcountUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcountUsers.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblcountUsers.Location = new System.Drawing.Point(165, 503);
            this.lblcountUsers.Name = "lblcountUsers";
            this.lblcountUsers.Size = new System.Drawing.Size(19, 20);
            this.lblcountUsers.TabIndex = 53;
            this.lblcountUsers.Text = "0";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label25.Location = new System.Drawing.Point(16, 503);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(62, 22);
            this.label25.TabIndex = 52;
            this.label25.Text = "Users";
            // 
            // lblCountGradeLevels
            // 
            this.lblCountGradeLevels.AutoSize = true;
            this.lblCountGradeLevels.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountGradeLevels.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblCountGradeLevels.Location = new System.Drawing.Point(165, 439);
            this.lblCountGradeLevels.Name = "lblCountGradeLevels";
            this.lblCountGradeLevels.Size = new System.Drawing.Size(19, 20);
            this.lblCountGradeLevels.TabIndex = 51;
            this.lblCountGradeLevels.Text = "0";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label27.Location = new System.Drawing.Point(16, 439);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(129, 22);
            this.label27.TabIndex = 50;
            this.label27.Text = "Grade Levels";
            // 
            // lblCountMeetings
            // 
            this.lblCountMeetings.AutoSize = true;
            this.lblCountMeetings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountMeetings.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblCountMeetings.Location = new System.Drawing.Point(165, 381);
            this.lblCountMeetings.Name = "lblCountMeetings";
            this.lblCountMeetings.Size = new System.Drawing.Size(19, 20);
            this.lblCountMeetings.TabIndex = 49;
            this.lblCountMeetings.Text = "0";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label29.Location = new System.Drawing.Point(16, 379);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(140, 22);
            this.label29.TabIndex = 48;
            this.label29.Text = "Meetings Time";
            // 
            // lblcountGroups
            // 
            this.lblcountGroups.AutoSize = true;
            this.lblcountGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcountGroups.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblcountGroups.Location = new System.Drawing.Point(165, 325);
            this.lblcountGroups.Name = "lblcountGroups";
            this.lblcountGroups.Size = new System.Drawing.Size(19, 20);
            this.lblcountGroups.TabIndex = 47;
            this.lblcountGroups.Text = "0";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label31.Location = new System.Drawing.Point(16, 325);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(75, 22);
            this.label31.TabIndex = 46;
            this.label31.Text = "Groups";
            // 
            // lblCountPayments
            // 
            this.lblCountPayments.AutoSize = true;
            this.lblCountPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountPayments.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblCountPayments.Location = new System.Drawing.Point(165, 261);
            this.lblCountPayments.Name = "lblCountPayments";
            this.lblCountPayments.Size = new System.Drawing.Size(19, 20);
            this.lblCountPayments.TabIndex = 45;
            this.lblCountPayments.Text = "0";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label33.Location = new System.Drawing.Point(16, 261);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(97, 22);
            this.label33.TabIndex = 44;
            this.label33.Text = "Payments";
            // 
            // lblCountSubjects
            // 
            this.lblCountSubjects.AutoSize = true;
            this.lblCountSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountSubjects.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblCountSubjects.Location = new System.Drawing.Point(165, 201);
            this.lblCountSubjects.Name = "lblCountSubjects";
            this.lblCountSubjects.Size = new System.Drawing.Size(19, 20);
            this.lblCountSubjects.TabIndex = 43;
            this.lblCountSubjects.Text = "0";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label35.Location = new System.Drawing.Point(16, 201);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(87, 22);
            this.label35.TabIndex = 42;
            this.label35.Text = "Subjects";
            // 
            // lblCountTeachers
            // 
            this.lblCountTeachers.AutoSize = true;
            this.lblCountTeachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountTeachers.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblCountTeachers.Location = new System.Drawing.Point(165, 143);
            this.lblCountTeachers.Name = "lblCountTeachers";
            this.lblCountTeachers.Size = new System.Drawing.Size(19, 20);
            this.lblCountTeachers.TabIndex = 41;
            this.lblCountTeachers.Text = "0";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label37.Location = new System.Drawing.Point(16, 143);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(94, 22);
            this.label37.TabIndex = 40;
            this.label37.Text = "Teachers";
            // 
            // lblCountStudents
            // 
            this.lblCountStudents.AutoSize = true;
            this.lblCountStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountStudents.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblCountStudents.Location = new System.Drawing.Point(165, 85);
            this.lblCountStudents.Name = "lblCountStudents";
            this.lblCountStudents.Size = new System.Drawing.Size(19, 20);
            this.lblCountStudents.TabIndex = 39;
            this.lblCountStudents.Text = "0";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label39.Location = new System.Drawing.Point(16, 21);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(81, 22);
            this.label39.TabIndex = 38;
            this.label39.Text = "Classes";
            // 
            // lblCountClasses
            // 
            this.lblCountClasses.AutoSize = true;
            this.lblCountClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountClasses.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblCountClasses.Location = new System.Drawing.Point(165, 23);
            this.lblCountClasses.Name = "lblCountClasses";
            this.lblCountClasses.Size = new System.Drawing.Size(19, 20);
            this.lblCountClasses.TabIndex = 37;
            this.lblCountClasses.Text = "0";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label41.Location = new System.Drawing.Point(16, 85);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(89, 22);
            this.label41.TabIndex = 36;
            this.label41.Text = "Students";
            // 
            // btnAddUsers
            // 
            this.btnAddUsers.BackColor = System.Drawing.Color.White;
            this.btnAddUsers.BackgroundImage = global::StudyCenterPresentation.Properties.Resources.user;
            this.btnAddUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUsers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddUsers.Location = new System.Drawing.Point(229, 494);
            this.btnAddUsers.Name = "btnAddUsers";
            this.btnAddUsers.Size = new System.Drawing.Size(61, 41);
            this.btnAddUsers.TabIndex = 35;
            this.btnAddUsers.UseVisualStyleBackColor = false;
            this.btnAddUsers.Click += new System.EventHandler(this.btnAddUsers_Click);
            // 
            // btnAddGradeLevel
            // 
            this.btnAddGradeLevel.BackColor = System.Drawing.Color.White;
            this.btnAddGradeLevel.BackgroundImage = global::StudyCenterPresentation.Properties.Resources.grade_level;
            this.btnAddGradeLevel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddGradeLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGradeLevel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddGradeLevel.Location = new System.Drawing.Point(229, 440);
            this.btnAddGradeLevel.Name = "btnAddGradeLevel";
            this.btnAddGradeLevel.Size = new System.Drawing.Size(61, 41);
            this.btnAddGradeLevel.TabIndex = 34;
            this.btnAddGradeLevel.UseVisualStyleBackColor = false;
            this.btnAddGradeLevel.Click += new System.EventHandler(this.btnAddGradeLevel_Click);
            // 
            // btnAddMeeting
            // 
            this.btnAddMeeting.BackColor = System.Drawing.Color.White;
            this.btnAddMeeting.BackgroundImage = global::StudyCenterPresentation.Properties.Resources.meeting;
            this.btnAddMeeting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddMeeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMeeting.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddMeeting.Location = new System.Drawing.Point(229, 376);
            this.btnAddMeeting.Name = "btnAddMeeting";
            this.btnAddMeeting.Size = new System.Drawing.Size(61, 41);
            this.btnAddMeeting.TabIndex = 33;
            this.btnAddMeeting.UseVisualStyleBackColor = false;
            this.btnAddMeeting.Click += new System.EventHandler(this.btnAddMeeting_Click);
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.BackColor = System.Drawing.Color.White;
            this.btnAddGroup.BackgroundImage = global::StudyCenterPresentation.Properties.Resources.groups_blue_64;
            this.btnAddGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGroup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddGroup.Location = new System.Drawing.Point(229, 316);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(61, 41);
            this.btnAddGroup.TabIndex = 32;
            this.btnAddGroup.UseVisualStyleBackColor = false;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // btnAddPayments
            // 
            this.btnAddPayments.BackColor = System.Drawing.Color.White;
            this.btnAddPayments.BackgroundImage = global::StudyCenterPresentation.Properties.Resources.payments_blue_64;
            this.btnAddPayments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPayments.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddPayments.Location = new System.Drawing.Point(229, 252);
            this.btnAddPayments.Name = "btnAddPayments";
            this.btnAddPayments.Size = new System.Drawing.Size(61, 41);
            this.btnAddPayments.TabIndex = 31;
            this.btnAddPayments.UseVisualStyleBackColor = false;
            // 
            // btnAddSubjects
            // 
            this.btnAddSubjects.BackColor = System.Drawing.Color.White;
            this.btnAddSubjects.BackgroundImage = global::StudyCenterPresentation.Properties.Resources.add_subject;
            this.btnAddSubjects.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSubjects.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddSubjects.Location = new System.Drawing.Point(229, 192);
            this.btnAddSubjects.Name = "btnAddSubjects";
            this.btnAddSubjects.Size = new System.Drawing.Size(61, 41);
            this.btnAddSubjects.TabIndex = 30;
            this.btnAddSubjects.UseVisualStyleBackColor = false;
            this.btnAddSubjects.Click += new System.EventHandler(this.btnAddSubjects_Click);
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.BackColor = System.Drawing.Color.White;
            this.btnAddTeacher.BackgroundImage = global::StudyCenterPresentation.Properties.Resources.add_teacher;
            this.btnAddTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTeacher.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddTeacher.Location = new System.Drawing.Point(229, 134);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(61, 41);
            this.btnAddTeacher.TabIndex = 29;
            this.btnAddTeacher.UseVisualStyleBackColor = false;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.White;
            this.btnAddStudent.BackgroundImage = global::StudyCenterPresentation.Properties.Resources.add_student;
            this.btnAddStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddStudent.Location = new System.Drawing.Point(229, 76);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(61, 41);
            this.btnAddStudent.TabIndex = 28;
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnAddClass
            // 
            this.btnAddClass.BackColor = System.Drawing.Color.White;
            this.btnAddClass.BackgroundImage = global::StudyCenterPresentation.Properties.Resources.classes_blue_64;
            this.btnAddClass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddClass.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAddClass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddClass.Location = new System.Drawing.Point(229, 14);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(61, 41);
            this.btnAddClass.TabIndex = 27;
            this.btnAddClass.UseVisualStyleBackColor = false;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox3.BackgroundImage = global::StudyCenterPresentation.Properties.Resources.main_form;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(105, 167);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(715, 538);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label44.Font = new System.Drawing.Font("Bernard MT Condensed", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label44.Location = new System.Drawing.Point(256, 36);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(299, 55);
            this.label44.TabIndex = 6;
            this.label44.Text = "Welcome Back";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label43.Location = new System.Drawing.Point(161, 91);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(497, 60);
            this.label43.TabIndex = 7;
            this.label43.Text = "Experience seamless student enrollment,\r\n efficient teacher management.\r\n and dyn" +
    "amic class schedulin all in one powerful platform.";
            // 
            // lbtimer
            // 
            this.lbtimer.AutoSize = true;
            this.lbtimer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbtimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtimer.Location = new System.Drawing.Point(116, 824);
            this.lbtimer.Name = "lbtimer";
            this.lbtimer.Size = new System.Drawing.Size(89, 29);
            this.lbtimer.TabIndex = 8;
            this.lbtimer.Text = "Timer:";
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.DarkCyan;
            this.guna2CustomGradientPanel1.BorderColor = System.Drawing.Color.DarkCyan;
            this.guna2CustomGradientPanel1.BorderRadius = 20;
            this.guna2CustomGradientPanel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2CustomGradientPanel1.BorderThickness = 5;
            this.guna2CustomGradientPanel1.Controls.Add(this.lblTimer);
            this.guna2CustomGradientPanel1.Controls.Add(this.lbtimer);
            this.guna2CustomGradientPanel1.Controls.Add(this.label43);
            this.guna2CustomGradientPanel1.Controls.Add(this.label44);
            this.guna2CustomGradientPanel1.Controls.Add(this.pictureBox3);
            this.guna2CustomGradientPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.guna2CustomGradientPanel1.CustomBorderColor = System.Drawing.Color.DarkCyan;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(149, 12);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(978, 950);
            this.guna2CustomGradientPanel1.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(15, 15);
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnstudents,
            this.btnteachers,
            this.btnsubjects,
            this.btnclasses,
            this.btngroups,
            this.btnpayments,
            this.btnsettings,
            this.btnlogout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(156, 977);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnstudents
            // 
            this.btnstudents.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnstudents.Name = "btnstudents";
            this.btnstudents.Size = new System.Drawing.Size(133, 29);
            this.btnstudents.Text = "Students";
            this.btnstudents.Click += new System.EventHandler(this.btnstudents_Click);
            // 
            // btnteachers
            // 
            this.btnteachers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnteachers.Name = "btnteachers";
            this.btnteachers.Size = new System.Drawing.Size(133, 29);
            this.btnteachers.Text = "Teachers";
            this.btnteachers.Click += new System.EventHandler(this.btnteachers_Click);
            // 
            // btnsubjects
            // 
            this.btnsubjects.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnsubjects.Name = "btnsubjects";
            this.btnsubjects.Size = new System.Drawing.Size(133, 29);
            this.btnsubjects.Text = "Subjects";
            this.btnsubjects.Click += new System.EventHandler(this.btnsubjects_Click);
            // 
            // btnclasses
            // 
            this.btnclasses.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnclasses.Name = "btnclasses";
            this.btnclasses.Size = new System.Drawing.Size(133, 29);
            this.btnclasses.Text = "Classes";
            this.btnclasses.Click += new System.EventHandler(this.btnclasses_Click);
            // 
            // btngroups
            // 
            this.btngroups.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btngroups.Name = "btngroups";
            this.btngroups.Size = new System.Drawing.Size(133, 29);
            this.btngroups.Text = "Groups";
            this.btngroups.Click += new System.EventHandler(this.btngroups_Click);
            // 
            // btnpayments
            // 
            this.btnpayments.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnpayments.Name = "btnpayments";
            this.btnpayments.Size = new System.Drawing.Size(133, 29);
            this.btnpayments.Text = "Payments";
            this.btnpayments.Click += new System.EventHandler(this.btnpayments_Click);
            // 
            // btnsettings
            // 
            this.btnsettings.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnsettings.Name = "btnsettings";
            this.btnsettings.Size = new System.Drawing.Size(133, 29);
            this.btnsettings.Text = "settings";
            this.btnsettings.Click += new System.EventHandler(this.btnsettings_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(133, 32);
            this.btnlogout.Text = "Logout";
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.MintCream;
            this.lblUserName.Location = new System.Drawing.Point(1175, 61);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(77, 32);
            this.lblUserName.TabIndex = 11;
            this.lblUserName.Text = "User";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.White;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(234, 825);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(31, 32);
            this.lblTimer.TabIndex = 9;
            this.lblTimer.Text = "?";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1452, 977);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.lbemail);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lbemail;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblcountUsers;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lblCountGradeLevels;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lblCountMeetings;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label lblcountGroups;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label lblCountPayments;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label lblCountSubjects;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label lblCountTeachers;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label lblCountStudents;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label lblCountClasses;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Button btnAddUsers;
        private System.Windows.Forms.Button btnAddGradeLevel;
        private System.Windows.Forms.Button btnAddMeeting;
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.Button btnAddPayments;
        private System.Windows.Forms.Button btnAddSubjects;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label lbtimer;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnstudents;
        private System.Windows.Forms.ToolStripMenuItem btnteachers;
        private System.Windows.Forms.ToolStripMenuItem btnsubjects;
        private System.Windows.Forms.ToolStripMenuItem btnclasses;
        private System.Windows.Forms.ToolStripMenuItem btngroups;
        private System.Windows.Forms.ToolStripMenuItem btnpayments;
        private System.Windows.Forms.ToolStripMenuItem btnsettings;
        private System.Windows.Forms.ToolStripMenuItem btnlogout;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblTimer;
    }
}