namespace StudyCenterPresentation
{
    partial class ctrlShowTeacherCard
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
            this.ctrlpersoninfo1 = new StudyCenterPresentation.ctrlpersoninfo();
            this.ctrlteacherinfo1 = new StudyCenterPresentation.ctrlteacherinfo();
            this.SuspendLayout();
            // 
            // ctrlpersoninfo1
            // 
            this.ctrlpersoninfo1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ctrlpersoninfo1.Location = new System.Drawing.Point(3, 3);
            this.ctrlpersoninfo1.Name = "ctrlpersoninfo1";
            this.ctrlpersoninfo1.Size = new System.Drawing.Size(818, 292);
            this.ctrlpersoninfo1.TabIndex = 0;
            // 
            // ctrlteacherinfo1
            // 
            this.ctrlteacherinfo1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrlteacherinfo1.Location = new System.Drawing.Point(3, 301);
            this.ctrlteacherinfo1.Name = "ctrlteacherinfo1";
            this.ctrlteacherinfo1.Size = new System.Drawing.Size(820, 245);
            this.ctrlteacherinfo1.TabIndex = 1;
            // 
            // ctrlShowTeacherCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlteacherinfo1);
            this.Controls.Add(this.ctrlpersoninfo1);
            this.Name = "ctrlShowTeacherCard";
            this.Size = new System.Drawing.Size(823, 553);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlpersoninfo ctrlpersoninfo1;
        private ctrlteacherinfo ctrlteacherinfo1;
    }
}
