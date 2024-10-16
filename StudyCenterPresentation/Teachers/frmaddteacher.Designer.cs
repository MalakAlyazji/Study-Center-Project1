namespace StudyCenterPresentation
{
    partial class frmaddteacher
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
            this.lbltitle = new System.Windows.Forms.Label();
            this.btclose = new Guna.UI2.WinForms.Guna2Button();
            this.btsave = new Guna.UI2.WinForms.Guna2Button();
            this.groupTeacher = new Guna.UI2.WinForms.Guna2Panel();
            this.txtSalary = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtHireDate = new System.Windows.Forms.DateTimePicker();
            this.txtQualifications = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblcreatedby = new System.Windows.Forms.Label();
            this.lblTeacherID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlpersoninfoFITER1 = new StudyCenterPresentation.ctrlpersoninfoFITER();
            this.groupTeacher.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbltitle.Location = new System.Drawing.Point(233, -15);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(278, 59);
            this.lbltitle.TabIndex = 2;
            this.lbltitle.Text = "Find Teacher";
            // 
            // btclose
            // 
            this.btclose.AutoRoundedCorners = true;
            this.btclose.BorderRadius = 18;
            this.btclose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btclose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btclose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btclose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btclose.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btclose.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btclose.ForeColor = System.Drawing.Color.White;
            this.btclose.Location = new System.Drawing.Point(665, 818);
            this.btclose.Name = "btclose";
            this.btclose.Size = new System.Drawing.Size(109, 39);
            this.btclose.TabIndex = 134;
            this.btclose.Text = "Close";
            this.btclose.Click += new System.EventHandler(this.btclose_Click);
            // 
            // btsave
            // 
            this.btsave.AutoRoundedCorners = true;
            this.btsave.BorderRadius = 18;
            this.btsave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btsave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btsave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btsave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btsave.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btsave.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsave.ForeColor = System.Drawing.Color.White;
            this.btsave.Location = new System.Drawing.Point(548, 818);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(112, 39);
            this.btsave.TabIndex = 133;
            this.btsave.Text = "Save";
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // groupTeacher
            // 
            this.groupTeacher.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupTeacher.Controls.Add(this.txtSalary);
            this.groupTeacher.Controls.Add(this.label5);
            this.groupTeacher.Controls.Add(this.dtHireDate);
            this.groupTeacher.Controls.Add(this.txtQualifications);
            this.groupTeacher.Controls.Add(this.label6);
            this.groupTeacher.Controls.Add(this.panel2);
            this.groupTeacher.Controls.Add(this.lblcreatedby);
            this.groupTeacher.Controls.Add(this.lblTeacherID);
            this.groupTeacher.Controls.Add(this.label4);
            this.groupTeacher.Controls.Add(this.label1);
            this.groupTeacher.Controls.Add(this.label2);
            this.groupTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupTeacher.Location = new System.Drawing.Point(25, 470);
            this.groupTeacher.Name = "groupTeacher";
            this.groupTeacher.Size = new System.Drawing.Size(763, 342);
            this.groupTeacher.TabIndex = 136;
            // 
            // txtSalary
            // 
            this.txtSalary.AutoRoundedCorners = true;
            this.txtSalary.BorderColor = System.Drawing.Color.Black;
            this.txtSalary.BorderRadius = 18;
            this.txtSalary.BorderThickness = 2;
            this.txtSalary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSalary.DefaultText = "";
            this.txtSalary.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSalary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSalary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSalary.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSalary.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSalary.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSalary.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSalary.Location = new System.Drawing.Point(157, 155);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.PasswordChar = '\0';
            this.txtSalary.PlaceholderText = "";
            this.txtSalary.SelectedText = "";
            this.txtSalary.Size = new System.Drawing.Size(177, 38);
            this.txtSalary.TabIndex = 204;
            this.txtSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalary_KeyPress);
            this.txtSalary.Validating += new System.ComponentModel.CancelEventHandler(this.txtSalary_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(374, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 29);
            this.label5.TabIndex = 203;
            this.label5.Text = "Hire Date:";
            // 
            // dtHireDate
            // 
            this.dtHireDate.Location = new System.Drawing.Point(517, 110);
            this.dtHireDate.Name = "dtHireDate";
            this.dtHireDate.Size = new System.Drawing.Size(232, 21);
            this.dtHireDate.TabIndex = 202;
            // 
            // txtQualifications
            // 
            this.txtQualifications.AutoRoundedCorners = true;
            this.txtQualifications.BorderColor = System.Drawing.Color.Black;
            this.txtQualifications.BorderRadius = 58;
            this.txtQualifications.BorderThickness = 2;
            this.txtQualifications.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQualifications.DefaultText = "";
            this.txtQualifications.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQualifications.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQualifications.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQualifications.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQualifications.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQualifications.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQualifications.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQualifications.Location = new System.Drawing.Point(181, 210);
            this.txtQualifications.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQualifications.Name = "txtQualifications";
            this.txtQualifications.PasswordChar = '\0';
            this.txtQualifications.PlaceholderText = "";
            this.txtQualifications.SelectedText = "";
            this.txtQualifications.Size = new System.Drawing.Size(555, 118);
            this.txtQualifications.TabIndex = 201;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(4, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 29);
            this.label6.TabIndex = 200;
            this.label6.Text = "Qualifications:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(4, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(847, 51);
            this.panel2.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(17, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Teacher Info:";
            // 
            // lblcreatedby
            // 
            this.lblcreatedby.AutoSize = true;
            this.lblcreatedby.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcreatedby.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblcreatedby.Location = new System.Drawing.Point(187, 109);
            this.lblcreatedby.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblcreatedby.Name = "lblcreatedby";
            this.lblcreatedby.Size = new System.Drawing.Size(68, 25);
            this.lblcreatedby.TabIndex = 199;
            this.lblcreatedby.Text = "[????]";
            // 
            // lblTeacherID
            // 
            this.lblTeacherID.AutoSize = true;
            this.lblTeacherID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherID.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTeacherID.Location = new System.Drawing.Point(187, 54);
            this.lblTeacherID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTeacherID.Name = "lblTeacherID";
            this.lblTeacherID.Size = new System.Drawing.Size(68, 25);
            this.lblTeacherID.TabIndex = 198;
            this.lblTeacherID.Text = "[????]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(53, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 29);
            this.label4.TabIndex = 33;
            this.label4.Text = "Salary:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(3, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 29);
            this.label1.TabIndex = 32;
            this.label1.Text = "Created By:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(4, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 29);
            this.label2.TabIndex = 27;
            this.label2.Text = "Teacher ID:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlpersoninfoFITER1
            // 
            this.ctrlpersoninfoFITER1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrlpersoninfoFITER1.FilterEnable = false;
            this.ctrlpersoninfoFITER1.Location = new System.Drawing.Point(25, 47);
            this.ctrlpersoninfoFITER1.Name = "ctrlpersoninfoFITER1";
            this.ctrlpersoninfoFITER1.Size = new System.Drawing.Size(763, 429);
            this.ctrlpersoninfoFITER1.TabIndex = 135;
            this.ctrlpersoninfoFITER1.OnPersonSelected += new System.EventHandler<StudyCenterPresentation.ctrlpersoninfoFITER.PersonSelectedEventArgs>(this.ctrlpersoninfoFITER1_OnPersonSelected);
            // 
            // frmaddteacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(822, 864);
            this.Controls.Add(this.groupTeacher);
            this.Controls.Add(this.ctrlpersoninfoFITER1);
            this.Controls.Add(this.btclose);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.lbltitle);
            this.Name = "frmaddteacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Teacher";
            this.Load += new System.EventHandler(this.frmaddteacher_Load);
            this.groupTeacher.ResumeLayout(false);
            this.groupTeacher.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private Guna.UI2.WinForms.Guna2Button btclose;
        private Guna.UI2.WinForms.Guna2Button btsave;
        private ctrlpersoninfoFITER ctrlpersoninfoFITER1;
        private Guna.UI2.WinForms.Guna2Panel groupTeacher;
        public Guna.UI2.WinForms.Guna2TextBox txtSalary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtHireDate;
        public Guna.UI2.WinForms.Guna2TextBox txtQualifications;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblcreatedby;
        public System.Windows.Forms.Label lblTeacherID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}