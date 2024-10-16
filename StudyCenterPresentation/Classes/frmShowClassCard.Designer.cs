namespace StudyCenterPresentation
{
    partial class frmShowClassCard
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
            this.btclose = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlClassCardWithFilter1 = new StudyCenterPresentation.ctrlClassCardWithFilter();
            this.SuspendLayout();
            // 
            // btclose
            // 
            this.btclose.AutoRoundedCorners = true;
            this.btclose.BorderRadius = 17;
            this.btclose.DefaultAutoSize = true;
            this.btclose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btclose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btclose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btclose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btclose.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btclose.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.btclose.ForeColor = System.Drawing.Color.White;
            this.btclose.Location = new System.Drawing.Point(723, 396);
            this.btclose.Name = "btclose";
            this.btclose.Size = new System.Drawing.Size(78, 36);
            this.btclose.TabIndex = 134;
            this.btclose.Text = "Close";
            this.btclose.Click += new System.EventHandler(this.btclose_Click);
            // 
            // ctrlClassCardWithFilter1
            // 
            this.ctrlClassCardWithFilter1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrlClassCardWithFilter1.FilterEnabled = false;
            this.ctrlClassCardWithFilter1.Location = new System.Drawing.Point(12, 12);
            this.ctrlClassCardWithFilter1.Name = "ctrlClassCardWithFilter1";
            this.ctrlClassCardWithFilter1.Size = new System.Drawing.Size(789, 378);
            this.ctrlClassCardWithFilter1.TabIndex = 0;
            // 
            // frmShowClassCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(815, 441);
            this.Controls.Add(this.btclose);
            this.Controls.Add(this.ctrlClassCardWithFilter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmShowClassCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmShowClassCard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlClassCardWithFilter ctrlClassCardWithFilter1;
        private Guna.UI2.WinForms.Guna2Button btclose;
    }
}