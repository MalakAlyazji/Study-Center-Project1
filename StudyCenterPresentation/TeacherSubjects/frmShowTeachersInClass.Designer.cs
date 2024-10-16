namespace StudyCenterPresentation
{
    partial class frmShowTeachersInClass
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
            this.ctrlTeacherSubjectsByTeacherID1 = new StudyCenterPresentation.ctrlTeacherSubjectsByTeacherID();
            this.SuspendLayout();
            // 
            // ctrlTeacherSubjectsByTeacherID1
            // 
            this.ctrlTeacherSubjectsByTeacherID1.Location = new System.Drawing.Point(1, 2);
            this.ctrlTeacherSubjectsByTeacherID1.Name = "ctrlTeacherSubjectsByTeacherID1";
            this.ctrlTeacherSubjectsByTeacherID1.Size = new System.Drawing.Size(818, 357);
            this.ctrlTeacherSubjectsByTeacherID1.TabIndex = 0;
            // 
            // frmShowTeachersInClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(816, 360);
            this.Controls.Add(this.ctrlTeacherSubjectsByTeacherID1);
            this.Name = "frmShowTeachersInClass";
            this.Text = "Teachers In Class";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlTeacherSubjectsByTeacherID ctrlTeacherSubjectsByTeacherID1;
    }
}