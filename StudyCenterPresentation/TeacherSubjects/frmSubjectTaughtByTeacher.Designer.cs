namespace StudyCenterPresentation
{
    partial class srmSubjectTaughtByTeacher
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
            this.ctrlTeacherCard1 = new StudyCenterPresentation.ctrlTeacherCard();
            this.ctrlTeacherSubjectsByTeacherID1 = new StudyCenterPresentation.ctrlTeacherSubjectsByTeacherID();
            this.SuspendLayout();
            // 
            // ctrlTeacherCard1
            // 
            this.ctrlTeacherCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlTeacherCard1.Location = new System.Drawing.Point(12, 1);
            this.ctrlTeacherCard1.Name = "ctrlTeacherCard1";
            this.ctrlTeacherCard1.Size = new System.Drawing.Size(704, 503);
            this.ctrlTeacherCard1.TabIndex = 3;
            // 
            // ctrlTeacherSubjectsByTeacherID1
            // 
            this.ctrlTeacherSubjectsByTeacherID1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlTeacherSubjectsByTeacherID1.Location = new System.Drawing.Point(14, 500);
            this.ctrlTeacherSubjectsByTeacherID1.Name = "ctrlTeacherSubjectsByTeacherID1";
            this.ctrlTeacherSubjectsByTeacherID1.Size = new System.Drawing.Size(707, 306);
            this.ctrlTeacherSubjectsByTeacherID1.TabIndex = 2;
            // 
            // srmSubjectTaughtByTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(733, 890);
            this.Controls.Add(this.ctrlTeacherCard1);
            this.Controls.Add(this.ctrlTeacherSubjectsByTeacherID1);
            this.Name = "srmSubjectTaughtByTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "srmSubjectTaughtByTeacher";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlTeacherCard ctrlTeacherCard1;
        private ctrlTeacherSubjectsByTeacherID ctrlTeacherSubjectsByTeacherID1;
    }
}