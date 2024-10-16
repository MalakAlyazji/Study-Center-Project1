namespace StudyCenterPresentation
{
    partial class frmAddGradeLevel
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
            this.ctrlAddGrade1 = new StudyCenterPresentation.ctrlAddGrade();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbltitle.Location = new System.Drawing.Point(60, 9);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(460, 59);
            this.lbltitle.TabIndex = 3;
            this.lbltitle.Text = "Add New Grade Level";
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
            this.btclose.Location = new System.Drawing.Point(441, 317);
            this.btclose.Name = "btclose";
            this.btclose.Size = new System.Drawing.Size(105, 36);
            this.btclose.TabIndex = 136;
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
            this.btsave.Location = new System.Drawing.Point(323, 317);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(112, 36);
            this.btsave.TabIndex = 135;
            this.btsave.Text = "Save";
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // ctrlAddGrade1
            // 
            this.ctrlAddGrade1.Location = new System.Drawing.Point(12, 81);
            this.ctrlAddGrade1.Name = "ctrlAddGrade1";
            this.ctrlAddGrade1.Size = new System.Drawing.Size(534, 212);
            this.ctrlAddGrade1.TabIndex = 4;
            // 
            // frmAddGradeLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(569, 365);
            this.Controls.Add(this.btclose);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.ctrlAddGrade1);
            this.Controls.Add(this.lbltitle);
            this.Name = "frmAddGradeLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Grade Levels";
            this.Load += new System.EventHandler(this.frmAddGradeLevel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private Guna.UI2.WinForms.Guna2Button btclose;
        private Guna.UI2.WinForms.Guna2Button btsave;
        private ctrlAddGrade ctrlAddGrade1;
    }
}