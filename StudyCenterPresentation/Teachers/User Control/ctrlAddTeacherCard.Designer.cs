namespace StudyCenterPresentation
{
    partial class ctrlAddTeacherCard
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
            this.ctrlEditTeacher1 = new StudyCenterPresentation.ctrlShowTeacherCard();
            this.SuspendLayout();
            // 
            // ctrlpersoninfo1
            // 
            this.ctrlpersoninfo1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ctrlpersoninfo1.Location = new System.Drawing.Point(0, 0);
            this.ctrlpersoninfo1.Name = "ctrlpersoninfo1";
            this.ctrlpersoninfo1.Size = new System.Drawing.Size(822, 296);
            this.ctrlpersoninfo1.TabIndex = 0;
            // 
            // ctrlEditTeacher1
            // 
            this.ctrlEditTeacher1.Location = new System.Drawing.Point(0, 302);
            this.ctrlEditTeacher1.Name = "ctrlEditTeacher1";
            this.ctrlEditTeacher1.Size = new System.Drawing.Size(821, 326);
            this.ctrlEditTeacher1.TabIndex = 1;
            // 
            // ctrlTeacherCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.ctrlEditTeacher1);
            this.Controls.Add(this.ctrlpersoninfo1);
            this.Name = "ctrlTeacherCard";
            this.Size = new System.Drawing.Size(825, 631);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlpersoninfo ctrlpersoninfo1;
        public ctrlShowTeacherCard ctrlEditTeacher1;
    }
}
