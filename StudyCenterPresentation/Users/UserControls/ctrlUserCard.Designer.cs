namespace StudyCenterPresentation
{
    partial class ctrlUserCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrlUserInfo1 = new StudyCenterPresentation.ctrlUserInfo();
            this.ctrlpersoninfo1 = new StudyCenterPresentation.ctrlpersoninfo();
            this.SuspendLayout();
            // 
            // ctrlUserInfo1
            // 
            this.ctrlUserInfo1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrlUserInfo1.Location = new System.Drawing.Point(2, 301);
            this.ctrlUserInfo1.Name = "ctrlUserInfo1";
            this.ctrlUserInfo1.Size = new System.Drawing.Size(822, 292);
            this.ctrlUserInfo1.TabIndex = 1;
            // 
            // ctrlpersoninfo1
            // 
            this.ctrlpersoninfo1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ctrlpersoninfo1.Location = new System.Drawing.Point(3, 3);
            this.ctrlpersoninfo1.Name = "ctrlpersoninfo1";
            this.ctrlpersoninfo1.Size = new System.Drawing.Size(818, 292);
            this.ctrlpersoninfo1.TabIndex = 0;
            // 
            // ctrlUserCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlUserInfo1);
            this.Controls.Add(this.ctrlpersoninfo1);
            this.Name = "ctrlUserCard";
            this.Size = new System.Drawing.Size(824, 596);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlpersoninfo ctrlpersoninfo1;
        private ctrlUserInfo ctrlUserInfo1;
    }
}
