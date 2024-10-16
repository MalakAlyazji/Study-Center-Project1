namespace StudyCenterPresentation
{
    partial class frmShowTeacherInfo
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
            this.ctrlTeacherCardWithFilter1 = new StudyCenterPresentation.ctrlTeacherCardWithFilter();
            this.SuspendLayout();
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
            this.btclose.Location = new System.Drawing.Point(684, 698);
            this.btclose.Name = "btclose";
            this.btclose.Size = new System.Drawing.Size(102, 36);
            this.btclose.TabIndex = 134;
            this.btclose.Text = "Close";
            this.btclose.Click += new System.EventHandler(this.btclose_Click);
            // 
            // ctrlTeacherCardWithFilter1
            // 
            this.ctrlTeacherCardWithFilter1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrlTeacherCardWithFilter1.FilterEnabled = true;
            this.ctrlTeacherCardWithFilter1.Location = new System.Drawing.Point(6, 12);
            this.ctrlTeacherCardWithFilter1.Name = "ctrlTeacherCardWithFilter1";
            this.ctrlTeacherCardWithFilter1.Size = new System.Drawing.Size(792, 680);
            this.ctrlTeacherCardWithFilter1.TabIndex = 135;
            // 
            // frmShowTeacherInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(810, 739);
            this.Controls.Add(this.ctrlTeacherCardWithFilter1);
            this.Controls.Add(this.btclose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmShowTeacherInfo";
            this.Text = "frmShowTeacherInfo";
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btclose;
        private ctrlTeacherCardWithFilter ctrlTeacherCardWithFilter1;
    }
}