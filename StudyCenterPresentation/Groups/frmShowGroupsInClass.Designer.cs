namespace StudyCenterPresentation
{
    partial class frmShowGroupsInClass
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
            this.ctrlShowGroupsInClass1 = new StudyCenterPresentation.ctrlShowGroupsInClass();
            this.SuspendLayout();
            // 
            // ctrlShowGroupsInClass1
            // 
            this.ctrlShowGroupsInClass1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrlShowGroupsInClass1.Location = new System.Drawing.Point(3, 2);
            this.ctrlShowGroupsInClass1.Name = "ctrlShowGroupsInClass1";
            this.ctrlShowGroupsInClass1.Size = new System.Drawing.Size(902, 368);
            this.ctrlShowGroupsInClass1.TabIndex = 0;
            // 
            // frmShowGroupsInClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 374);
            this.Controls.Add(this.ctrlShowGroupsInClass1);
            this.Name = "frmShowGroupsInClass";
            this.Text = "Groups In Class";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlShowGroupsInClass ctrlShowGroupsInClass1;
    }
}