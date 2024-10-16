namespace StudyCenterPresentation
{
    partial class frmaddstudent
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
            this.lbltitle = new System.Windows.Forms.Label();
            this.btclose = new Guna.UI2.WinForms.Guna2Button();
            this.btsave = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlpersoninfoFITER1 = new StudyCenterPresentation.ctrlpersoninfoFITER();
            this.ctrlstudentinfo1 = new StudyCenterPresentation.ctrlstudentinfo();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbltitle.Location = new System.Drawing.Point(117, -2);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(383, 59);
            this.lbltitle.TabIndex = 1;
            this.lbltitle.Text = "Add New Student";
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
            this.btclose.Location = new System.Drawing.Point(682, 730);
            this.btclose.Name = "btclose";
            this.btclose.Size = new System.Drawing.Size(105, 36);
            this.btclose.TabIndex = 132;
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
            this.btsave.Location = new System.Drawing.Point(564, 730);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(112, 36);
            this.btsave.TabIndex = 131;
            this.btsave.Text = "Save";
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // ctrlpersoninfoFITER1
            // 
            this.ctrlpersoninfoFITER1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrlpersoninfoFITER1.FilterEnable = true;
            this.ctrlpersoninfoFITER1.Location = new System.Drawing.Point(20, 60);
            this.ctrlpersoninfoFITER1.Name = "ctrlpersoninfoFITER1";
            this.ctrlpersoninfoFITER1.Size = new System.Drawing.Size(749, 414);
            this.ctrlpersoninfoFITER1.TabIndex = 133;
            this.ctrlpersoninfoFITER1.OnPersonSelected += new System.EventHandler<StudyCenterPresentation.ctrlpersoninfoFITER.PersonSelectedEventArgs>(this.ctrlpersoninfoFITER1_OnPersonSelected);
            // 
            // ctrlstudentinfo1
            // 
            this.ctrlstudentinfo1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ctrlstudentinfo1.Enabled = false;
            this.ctrlstudentinfo1.Location = new System.Drawing.Point(20, 480);
            this.ctrlstudentinfo1.Name = "ctrlstudentinfo1";
            this.ctrlstudentinfo1.Size = new System.Drawing.Size(749, 247);
            this.ctrlstudentinfo1.TabIndex = 3;
            // 
            // frmaddstudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(799, 772);
            this.Controls.Add(this.ctrlpersoninfoFITER1);
            this.Controls.Add(this.btclose);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.ctrlstudentinfo1);
            this.Controls.Add(this.lbltitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmaddstudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Student";
            this.Load += new System.EventHandler(this.frmaddstudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbltitle;
        private ctrlstudentinfo ctrlstudentinfo1;
        private Guna.UI2.WinForms.Guna2Button btclose;
        private Guna.UI2.WinForms.Guna2Button btsave;
        private ctrlpersoninfoFITER ctrlpersoninfoFITER1;
    }
}