namespace StudyCenterPresentation
{
    partial class frmAddGroup
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tbClass = new System.Windows.Forms.TabPage();
            this.ctrlClassCardWithFilter2 = new StudyCenterPresentation.ctrlClassCardWithFilter();
            this.tbTeacher = new System.Windows.Forms.TabPage();
            this.ctrlTeacherCardWithFilter1 = new StudyCenterPresentation.ctrlTeacherCardWithFilter();
            this.tbStubject = new System.Windows.Forms.TabPage();
            this.ctrlTeacherSubjectsByTeacherID1 = new StudyCenterPresentation.ctrlTeacherSubjectsByTeacherID();
            this.lblsSelectSubject = new System.Windows.Forms.Label();
            this.tbMeeting = new System.Windows.Forms.TabPage();
            this.lblsSelectMeeting = new System.Windows.Forms.Label();
            this.btnaddMeeting = new Guna.UI2.WinForms.Guna2PictureBox();
            this.cbMeetingDays = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbfilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbfilter = new System.Windows.Forms.Label();
            this.dgvlist = new System.Windows.Forms.DataGridView();
            this.tbGroup = new System.Windows.Forms.TabPage();
            this.ctrlGroupCard1 = new StudyCenterPresentation.ctrlGroupCard();
            this.btclose = new Guna.UI2.WinForms.Guna2Button();
            this.btsave = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.guna2TabControl1.SuspendLayout();
            this.tbClass.SuspendLayout();
            this.tbTeacher.SuspendLayout();
            this.tbStubject.SuspendLayout();
            this.tbMeeting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnaddMeeting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlist)).BeginInit();
            this.tbGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Controls.Add(this.tbClass);
            this.guna2TabControl1.Controls.Add(this.tbTeacher);
            this.guna2TabControl1.Controls.Add(this.tbStubject);
            this.guna2TabControl1.Controls.Add(this.tbMeeting);
            this.guna2TabControl1.Controls.Add(this.tbGroup);
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(135, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(40, 43);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(921, 734);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(135, 40);
            this.guna2TabControl1.TabButtonTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2TabControl1.TabIndex = 0;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tbClass
            // 
            this.tbClass.Controls.Add(this.ctrlClassCardWithFilter2);
            this.tbClass.Location = new System.Drawing.Point(4, 44);
            this.tbClass.Name = "tbClass";
            this.tbClass.Padding = new System.Windows.Forms.Padding(3);
            this.tbClass.Size = new System.Drawing.Size(913, 686);
            this.tbClass.TabIndex = 0;
            this.tbClass.Text = "Class Info";
            this.tbClass.UseVisualStyleBackColor = true;
            // 
            // ctrlClassCardWithFilter2
            // 
            this.ctrlClassCardWithFilter2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrlClassCardWithFilter2.FilterEnabled = false;
            this.ctrlClassCardWithFilter2.Location = new System.Drawing.Point(22, 16);
            this.ctrlClassCardWithFilter2.Name = "ctrlClassCardWithFilter2";
            this.ctrlClassCardWithFilter2.Size = new System.Drawing.Size(789, 378);
            this.ctrlClassCardWithFilter2.TabIndex = 0;
            this.ctrlClassCardWithFilter2.OnClassSelected += new System.EventHandler<StudyCenterPresentation.ctrlClassCardWithFilter.SelectedClassEventArgs>(this.ctrlClassCardWithFilter2_OnClassSelected);
            // 
            // tbTeacher
            // 
            this.tbTeacher.Controls.Add(this.ctrlTeacherCardWithFilter1);
            this.tbTeacher.Location = new System.Drawing.Point(4, 44);
            this.tbTeacher.Name = "tbTeacher";
            this.tbTeacher.Padding = new System.Windows.Forms.Padding(3);
            this.tbTeacher.Size = new System.Drawing.Size(913, 686);
            this.tbTeacher.TabIndex = 1;
            this.tbTeacher.Text = "Teacher Info";
            this.tbTeacher.UseVisualStyleBackColor = true;
            // 
            // ctrlTeacherCardWithFilter1
            // 
            this.ctrlTeacherCardWithFilter1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrlTeacherCardWithFilter1.FilterEnabled = true;
            this.ctrlTeacherCardWithFilter1.Location = new System.Drawing.Point(17, 6);
            this.ctrlTeacherCardWithFilter1.Name = "ctrlTeacherCardWithFilter1";
            this.ctrlTeacherCardWithFilter1.Size = new System.Drawing.Size(809, 674);
            this.ctrlTeacherCardWithFilter1.TabIndex = 0;
            this.ctrlTeacherCardWithFilter1.OnTeacherSelected += new System.EventHandler<StudyCenterPresentation.ctrlTeacherCardWithFilter.TeacherSelectedEventArgs>(this.ctrlTeacherCardWithFilter1_OnTeacherSelected);
            // 
            // tbStubject
            // 
            this.tbStubject.Controls.Add(this.ctrlTeacherSubjectsByTeacherID1);
            this.tbStubject.Controls.Add(this.lblsSelectSubject);
            this.tbStubject.Location = new System.Drawing.Point(4, 44);
            this.tbStubject.Name = "tbStubject";
            this.tbStubject.Size = new System.Drawing.Size(913, 686);
            this.tbStubject.TabIndex = 2;
            this.tbStubject.Text = "Subject Info";
            this.tbStubject.UseVisualStyleBackColor = true;
            // 
            // ctrlTeacherSubjectsByTeacherID1
            // 
            this.ctrlTeacherSubjectsByTeacherID1.Location = new System.Drawing.Point(32, 76);
            this.ctrlTeacherSubjectsByTeacherID1.Name = "ctrlTeacherSubjectsByTeacherID1";
            this.ctrlTeacherSubjectsByTeacherID1.Size = new System.Drawing.Size(835, 390);
            this.ctrlTeacherSubjectsByTeacherID1.TabIndex = 2;
            this.ctrlTeacherSubjectsByTeacherID1.RowClicked += new StudyCenterPresentation.ctrlTeacherSubjectsByTeacherID.RowClickedEventHandler(this.ctrlListTeacherSubjestByTeacherID1_RowClicked);
            // 
            // lblsSelectSubject
            // 
            this.lblsSelectSubject.AutoSize = true;
            this.lblsSelectSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsSelectSubject.Location = new System.Drawing.Point(40, 13);
            this.lblsSelectSubject.Name = "lblsSelectSubject";
            this.lblsSelectSubject.Size = new System.Drawing.Size(446, 36);
            this.lblsSelectSubject.TabIndex = 1;
            this.lblsSelectSubject.Text = "Double click to select subject :";
            // 
            // tbMeeting
            // 
            this.tbMeeting.Controls.Add(this.lblsSelectMeeting);
            this.tbMeeting.Controls.Add(this.btnaddMeeting);
            this.tbMeeting.Controls.Add(this.cbMeetingDays);
            this.tbMeeting.Controls.Add(this.cbfilter);
            this.tbMeeting.Controls.Add(this.lbfilter);
            this.tbMeeting.Controls.Add(this.dgvlist);
            this.tbMeeting.Location = new System.Drawing.Point(4, 44);
            this.tbMeeting.Name = "tbMeeting";
            this.tbMeeting.Size = new System.Drawing.Size(913, 686);
            this.tbMeeting.TabIndex = 3;
            this.tbMeeting.Text = "Meeting Time Info";
            this.tbMeeting.UseVisualStyleBackColor = true;
            // 
            // lblsSelectMeeting
            // 
            this.lblsSelectMeeting.AutoSize = true;
            this.lblsSelectMeeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsSelectMeeting.Location = new System.Drawing.Point(29, 19);
            this.lblsSelectMeeting.Name = "lblsSelectMeeting";
            this.lblsSelectMeeting.Size = new System.Drawing.Size(481, 36);
            this.lblsSelectMeeting.TabIndex = 25;
            this.lblsSelectMeeting.Text = "Double click to select a meeting :";
            // 
            // btnaddMeeting
            // 
            this.btnaddMeeting.BackColor = System.Drawing.Color.Transparent;
            this.btnaddMeeting.Image = global::StudyCenterPresentation.Properties.Resources.meeting__1_;
            this.btnaddMeeting.ImageRotate = 0F;
            this.btnaddMeeting.Location = new System.Drawing.Point(673, 68);
            this.btnaddMeeting.Name = "btnaddMeeting";
            this.btnaddMeeting.Size = new System.Drawing.Size(96, 46);
            this.btnaddMeeting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnaddMeeting.TabIndex = 24;
            this.btnaddMeeting.TabStop = false;
            this.btnaddMeeting.Click += new System.EventHandler(this.btnaddMeeting_Click);
            // 
            // cbMeetingDays
            // 
            this.cbMeetingDays.AutoRoundedCorners = true;
            this.cbMeetingDays.BackColor = System.Drawing.Color.Transparent;
            this.cbMeetingDays.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.cbMeetingDays.BorderRadius = 17;
            this.cbMeetingDays.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.cbMeetingDays.BorderThickness = 2;
            this.cbMeetingDays.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMeetingDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMeetingDays.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMeetingDays.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMeetingDays.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbMeetingDays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbMeetingDays.ItemHeight = 30;
            this.cbMeetingDays.Items.AddRange(new object[] {
            "All",
            "Daily",
            "STT",
            "MW"});
            this.cbMeetingDays.Location = new System.Drawing.Point(309, 76);
            this.cbMeetingDays.Name = "cbMeetingDays";
            this.cbMeetingDays.Size = new System.Drawing.Size(181, 36);
            this.cbMeetingDays.TabIndex = 23;
            this.cbMeetingDays.SelectedIndexChanged += new System.EventHandler(this.cbMeetingDays_SelectedIndexChanged);
            // 
            // cbfilter
            // 
            this.cbfilter.AutoRoundedCorners = true;
            this.cbfilter.BackColor = System.Drawing.Color.Transparent;
            this.cbfilter.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.cbfilter.BorderRadius = 17;
            this.cbfilter.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.cbfilter.BorderThickness = 2;
            this.cbfilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbfilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbfilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbfilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbfilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbfilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbfilter.ItemHeight = 30;
            this.cbfilter.Items.AddRange(new object[] {
            "Meeting Days"});
            this.cbfilter.Location = new System.Drawing.Point(108, 76);
            this.cbfilter.Name = "cbfilter";
            this.cbfilter.Size = new System.Drawing.Size(195, 36);
            this.cbfilter.TabIndex = 22;
            // 
            // lbfilter
            // 
            this.lbfilter.AutoSize = true;
            this.lbfilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfilter.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbfilter.Location = new System.Drawing.Point(30, 86);
            this.lbfilter.Name = "lbfilter";
            this.lbfilter.Size = new System.Drawing.Size(73, 25);
            this.lbfilter.TabIndex = 21;
            this.lbfilter.Text = "Filter :";
            // 
            // dgvlist
            // 
            this.dgvlist.AllowUserToAddRows = false;
            this.dgvlist.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            this.dgvlist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvlist.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvlist.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvlist.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvlist.Location = new System.Drawing.Point(26, 128);
            this.dgvlist.Name = "dgvlist";
            this.dgvlist.ReadOnly = true;
            this.dgvlist.RowHeadersWidth = 51;
            this.dgvlist.RowTemplate.Height = 24;
            this.dgvlist.Size = new System.Drawing.Size(743, 429);
            this.dgvlist.TabIndex = 1;
            this.dgvlist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlist_CellClick);
            this.dgvlist.SelectionChanged += new System.EventHandler(this.dgvlist_SelectionChanged);
            // 
            // tbGroup
            // 
            this.tbGroup.Controls.Add(this.ctrlGroupCard1);
            this.tbGroup.Location = new System.Drawing.Point(4, 44);
            this.tbGroup.Name = "tbGroup";
            this.tbGroup.Size = new System.Drawing.Size(913, 686);
            this.tbGroup.TabIndex = 4;
            this.tbGroup.Text = "Group Info";
            this.tbGroup.UseVisualStyleBackColor = true;
            // 
            // ctrlGroupCard1
            // 
            this.ctrlGroupCard1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrlGroupCard1.Location = new System.Drawing.Point(3, 3);
            this.ctrlGroupCard1.Name = "ctrlGroupCard1";
            this.ctrlGroupCard1.Size = new System.Drawing.Size(901, 414);
            this.ctrlGroupCard1.TabIndex = 0;
            // 
            // btclose
            // 
            this.btclose.AutoRoundedCorners = true;
            this.btclose.BorderRadius = 21;
            this.btclose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btclose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btclose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btclose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btclose.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btclose.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.btclose.ForeColor = System.Drawing.Color.White;
            this.btclose.Location = new System.Drawing.Point(838, 779);
            this.btclose.Name = "btclose";
            this.btclose.Size = new System.Drawing.Size(119, 45);
            this.btclose.TabIndex = 136;
            this.btclose.Text = "Close";
            this.btclose.Click += new System.EventHandler(this.btclose_Click);
            // 
            // btsave
            // 
            this.btsave.AutoRoundedCorners = true;
            this.btsave.BorderRadius = 21;
            this.btsave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btsave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btsave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btsave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btsave.Enabled = false;
            this.btsave.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btsave.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsave.ForeColor = System.Drawing.Color.White;
            this.btsave.Location = new System.Drawing.Point(706, 779);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(126, 45);
            this.btsave.TabIndex = 135;
            this.btsave.Text = "Save";
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(266, -2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(297, 42);
            this.lblTitle.TabIndex = 137;
            this.lblTitle.Text = "Add New Group";
            // 
            // frmAddGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(989, 836);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btclose);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.guna2TabControl1);
            this.Name = "frmAddGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddGroup";
            this.Load += new System.EventHandler(this.frmAddGroup_Load);
            this.guna2TabControl1.ResumeLayout(false);
            this.tbClass.ResumeLayout(false);
            this.tbTeacher.ResumeLayout(false);
            this.tbStubject.ResumeLayout(false);
            this.tbStubject.PerformLayout();
            this.tbMeeting.ResumeLayout(false);
            this.tbMeeting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnaddMeeting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlist)).EndInit();
            this.tbGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage tbClass;
        private System.Windows.Forms.TabPage tbTeacher;
        private System.Windows.Forms.TabPage tbStubject;
        private Guna.UI2.WinForms.Guna2Button btclose;
        private Guna.UI2.WinForms.Guna2Button btsave;
        private System.Windows.Forms.TabPage tbMeeting;
        private System.Windows.Forms.TabPage tbGroup;
        private ctrlClassCardWithFilter ctrlClassCardWithFilter2;
        private System.Windows.Forms.DataGridView dgvlist;
        private Guna.UI2.WinForms.Guna2ComboBox cbMeetingDays;
        private Guna.UI2.WinForms.Guna2ComboBox cbfilter;
        private System.Windows.Forms.Label lbfilter;
        private Guna.UI2.WinForms.Guna2PictureBox btnaddMeeting;
        private ctrlGroupCard ctrlGroupCard1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblsSelectSubject;
        private System.Windows.Forms.Label lblsSelectMeeting;
        private ctrlTeacherSubjectsByTeacherID ctrlTeacherSubjectsByTeacherID1;
        private ctrlTeacherCardWithFilter ctrlTeacherCardWithFilter1;
    }
}