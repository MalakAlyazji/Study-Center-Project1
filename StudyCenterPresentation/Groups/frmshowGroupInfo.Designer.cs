namespace StudyCenterPresentation
{
    partial class frmshowGroupInfo
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
            this.ctrlGroupCard1 = new StudyCenterPresentation.ctrlGroupCard();
            this.SuspendLayout();
            // 
            // ctrlGroupCard1
            // 
            this.ctrlGroupCard1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrlGroupCard1.Location = new System.Drawing.Point(2, 12);
            this.ctrlGroupCard1.Name = "ctrlGroupCard1";
            this.ctrlGroupCard1.Size = new System.Drawing.Size(915, 416);
            this.ctrlGroupCard1.TabIndex = 0;
            // 
            // frmshowGroupInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(907, 430);
            this.Controls.Add(this.ctrlGroupCard1);
            this.Name = "frmshowGroupInfo";
            this.Text = "Show Group Info";
            this.Load += new System.EventHandler(this.frmshowGroupInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlGroupCard ctrlGroupCard1;
    }
}