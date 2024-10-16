namespace StudyCenterPresentation
{
    partial class frmAddClass
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
            this.ctrlAddClass1 = new StudyCenterPresentation.ctrlAddClass();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbltitle.Location = new System.Drawing.Point(89, 9);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(324, 59);
            this.lbltitle.TabIndex = 2;
            this.lbltitle.Text = "Add New Class";
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
            this.btclose.Location = new System.Drawing.Point(437, 350);
            this.btclose.Name = "btclose";
            this.btclose.Size = new System.Drawing.Size(105, 36);
            this.btclose.TabIndex = 134;
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
            this.btsave.Location = new System.Drawing.Point(319, 350);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(112, 36);
            this.btsave.TabIndex = 133;
            this.btsave.Text = "Save";
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // ctrlAddClass1
            // 
            this.ctrlAddClass1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrlAddClass1.Location = new System.Drawing.Point(12, 71);
            this.ctrlAddClass1.Name = "ctrlAddClass1";
            this.ctrlAddClass1.Size = new System.Drawing.Size(531, 273);
            this.ctrlAddClass1.TabIndex = 3;
            // 
            // frmAddClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(554, 405);
            this.Controls.Add(this.btclose);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.ctrlAddClass1);
            this.Controls.Add(this.lbltitle);
            this.Name = "frmAddClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Class";
            this.Load += new System.EventHandler(this.frmAddClass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private ctrlAddClass ctrlAddClass1;
        private Guna.UI2.WinForms.Guna2Button btclose;
        private Guna.UI2.WinForms.Guna2Button btsave;
    }
}