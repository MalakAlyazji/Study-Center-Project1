namespace StudyCenterPresentation
{
    partial class frmAddGradeSubject
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
            this.gbAddClass = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lnkAddNewSubject = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblGradeSubjectTitles = new System.Windows.Forms.Label();
            this.txtFees = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSubjectName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbGradeLevelName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGradeSubjectID = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.btclose = new Guna.UI2.WinForms.Guna2Button();
            this.btsave = new Guna.UI2.WinForms.Guna2Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbAddClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAddClass
            // 
            this.gbAddClass.Controls.Add(this.lnkAddNewSubject);
            this.gbAddClass.Controls.Add(this.label5);
            this.gbAddClass.Controls.Add(this.lblGradeSubjectTitles);
            this.gbAddClass.Controls.Add(this.txtFees);
            this.gbAddClass.Controls.Add(this.label4);
            this.gbAddClass.Controls.Add(this.cbSubjectName);
            this.gbAddClass.Controls.Add(this.label3);
            this.gbAddClass.Controls.Add(this.cbGradeLevelName);
            this.gbAddClass.Controls.Add(this.label1);
            this.gbAddClass.Controls.Add(this.label2);
            this.gbAddClass.Controls.Add(this.lblGradeSubjectID);
            this.gbAddClass.CustomBorderColor = System.Drawing.Color.DarkSlateGray;
            this.gbAddClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddClass.ForeColor = System.Drawing.Color.White;
            this.gbAddClass.Location = new System.Drawing.Point(12, 64);
            this.gbAddClass.Name = "gbAddClass";
            this.gbAddClass.Size = new System.Drawing.Size(625, 347);
            this.gbAddClass.TabIndex = 2;
            this.gbAddClass.Text = "Grade Subject Info:";
            // 
            // lnkAddNewSubject
            // 
            this.lnkAddNewSubject.AutoSize = true;
            this.lnkAddNewSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkAddNewSubject.LinkColor = System.Drawing.Color.DarkSlateGray;
            this.lnkAddNewSubject.Location = new System.Drawing.Point(439, 57);
            this.lnkAddNewSubject.Name = "lnkAddNewSubject";
            this.lnkAddNewSubject.Size = new System.Drawing.Size(163, 22);
            this.lnkAddNewSubject.TabIndex = 216;
            this.lnkAddNewSubject.TabStop = true;
            this.lnkAddNewSubject.Text = "Add New Subject";
            this.lnkAddNewSubject.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAddNewSubject_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(26, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 29);
            this.label5.TabIndex = 214;
            this.label5.Text = "Titles:";
            // 
            // lblGradeSubjectTitles
            // 
            this.lblGradeSubjectTitles.AutoSize = true;
            this.lblGradeSubjectTitles.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGradeSubjectTitles.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradeSubjectTitles.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblGradeSubjectTitles.Location = new System.Drawing.Point(256, 299);
            this.lblGradeSubjectTitles.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblGradeSubjectTitles.Name = "lblGradeSubjectTitles";
            this.lblGradeSubjectTitles.Size = new System.Drawing.Size(75, 29);
            this.lblGradeSubjectTitles.TabIndex = 215;
            this.lblGradeSubjectTitles.Text = "[????]";
            // 
            // txtFees
            // 
            this.txtFees.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtFees.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.txtFees.BorderRadius = 20;
            this.txtFees.BorderThickness = 2;
            this.txtFees.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFees.DefaultText = "";
            this.txtFees.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFees.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFees.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFees.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFees.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtFees.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFees.Location = new System.Drawing.Point(261, 237);
            this.txtFees.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFees.Name = "txtFees";
            this.txtFees.PasswordChar = '\0';
            this.txtFees.PlaceholderText = "";
            this.txtFees.SelectedText = "";
            this.txtFees.Size = new System.Drawing.Size(190, 38);
            this.txtFees.TabIndex = 213;
            this.txtFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFees_KeyPress);
            this.txtFees.Validating += new System.ComponentModel.CancelEventHandler(this.txtFees_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(26, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 29);
            this.label4.TabIndex = 212;
            this.label4.Text = "Fees[$]:";
            // 
            // cbSubjectName
            // 
            this.cbSubjectName.BackColor = System.Drawing.Color.Transparent;
            this.cbSubjectName.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.cbSubjectName.BorderRadius = 15;
            this.cbSubjectName.BorderThickness = 2;
            this.cbSubjectName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSubjectName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubjectName.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSubjectName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSubjectName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbSubjectName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSubjectName.ItemHeight = 30;
            this.cbSubjectName.Location = new System.Drawing.Point(261, 180);
            this.cbSubjectName.Name = "cbSubjectName";
            this.cbSubjectName.Size = new System.Drawing.Size(190, 36);
            this.cbSubjectName.TabIndex = 211;
            this.cbSubjectName.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            this.cbSubjectName.Validating += new System.ComponentModel.CancelEventHandler(this.cbGradeLevelsAndSubjectNames_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(17, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 29);
            this.label3.TabIndex = 210;
            this.label3.Text = "Subject Name:";
            // 
            // cbGradeLevelName
            // 
            this.cbGradeLevelName.BackColor = System.Drawing.Color.Transparent;
            this.cbGradeLevelName.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.cbGradeLevelName.BorderRadius = 15;
            this.cbGradeLevelName.BorderThickness = 2;
            this.cbGradeLevelName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGradeLevelName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGradeLevelName.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbGradeLevelName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbGradeLevelName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbGradeLevelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbGradeLevelName.ItemHeight = 30;
            this.cbGradeLevelName.Location = new System.Drawing.Point(261, 117);
            this.cbGradeLevelName.Name = "cbGradeLevelName";
            this.cbGradeLevelName.Size = new System.Drawing.Size(190, 36);
            this.cbGradeLevelName.TabIndex = 209;
            this.cbGradeLevelName.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            this.cbGradeLevelName.Validating += new System.ComponentModel.CancelEventHandler(this.cbGradeLevelsAndSubjectNames_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(17, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 29);
            this.label1.TabIndex = 208;
            this.label1.Text = "Grade Level Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(17, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 29);
            this.label2.TabIndex = 206;
            this.label2.Text = "Grade Subject ID:";
            // 
            // lblGradeSubjectID
            // 
            this.lblGradeSubjectID.AutoSize = true;
            this.lblGradeSubjectID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGradeSubjectID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradeSubjectID.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblGradeSubjectID.Location = new System.Drawing.Point(256, 57);
            this.lblGradeSubjectID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblGradeSubjectID.Name = "lblGradeSubjectID";
            this.lblGradeSubjectID.Size = new System.Drawing.Size(75, 29);
            this.lblGradeSubjectID.TabIndex = 207;
            this.lblGradeSubjectID.Text = "[????]";
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbltitle.Location = new System.Drawing.Point(34, 7);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(580, 54);
            this.lbltitle.TabIndex = 4;
            this.lbltitle.Text = "Add New Subject Grade Level";
            // 
            // btclose
            // 
            this.btclose.AutoRoundedCorners = true;
            this.btclose.BorderRadius = 17;
            this.btclose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btclose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btclose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btclose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btclose.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btclose.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btclose.ForeColor = System.Drawing.Color.White;
            this.btclose.Location = new System.Drawing.Point(532, 419);
            this.btclose.Name = "btclose";
            this.btclose.Size = new System.Drawing.Size(105, 36);
            this.btclose.TabIndex = 138;
            this.btclose.Text = "Close";
            this.btclose.Click += new System.EventHandler(this.btclose_Click);
            // 
            // btsave
            // 
            this.btsave.AutoRoundedCorners = true;
            this.btsave.BorderRadius = 17;
            this.btsave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btsave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btsave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btsave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btsave.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btsave.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsave.ForeColor = System.Drawing.Color.White;
            this.btsave.Location = new System.Drawing.Point(414, 419);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(112, 36);
            this.btsave.TabIndex = 137;
            this.btsave.Text = "Save";
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddGradeSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(661, 467);
            this.Controls.Add(this.btclose);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.gbAddClass);
            this.Name = "frmAddGradeSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddGradeSubject";
            this.Load += new System.EventHandler(this.frmAddGradeSubject_Load);
            this.gbAddClass.ResumeLayout(false);
            this.gbAddClass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbAddClass;
        private Guna.UI2.WinForms.Guna2ComboBox cbSubjectName;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cbGradeLevelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblGradeSubjectID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbltitle;
        private Guna.UI2.WinForms.Guna2Button btclose;
        private Guna.UI2.WinForms.Guna2Button btsave;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lblGradeSubjectTitles;
        public Guna.UI2.WinForms.Guna2TextBox txtFees;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.LinkLabel lnkAddNewSubject;
    }
}