namespace StudyCenterPresentation
{
    partial class frmShowGradeSubject
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
            this.ctrlGradeSubjectCard1 = new StudyCenterPresentation.ctrlGradeSubjectCard();
            this.SuspendLayout();
            // 
            // ctrlGradeSubjectCard1
            // 
            this.ctrlGradeSubjectCard1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrlGradeSubjectCard1.Location = new System.Drawing.Point(12, 12);
            this.ctrlGradeSubjectCard1.Name = "ctrlGradeSubjectCard1";
            this.ctrlGradeSubjectCard1.Size = new System.Drawing.Size(753, 300);
            this.ctrlGradeSubjectCard1.TabIndex = 0;
            // 
            // frmShowGradeSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(775, 316);
            this.Controls.Add(this.ctrlGradeSubjectCard1);
            this.Name = "frmShowGradeSubject";
            this.Text = "Show Grade Subject";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlGradeSubjectCard ctrlGradeSubjectCard1;
    }
}