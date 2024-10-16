namespace StudyCenterPresentation
{
    partial class ctrlstudentcard
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
            this.ctrlStudentInfoOUTINPUT1 = new StudyCenterPresentation.ctrlStudentInfoOUTINPUT();
            this.ctrlpersoninfo1 = new StudyCenterPresentation.ctrlpersoninfo();
            this.SuspendLayout();
            // 
            // ctrlStudentInfoOUTINPUT1
            // 
            this.ctrlStudentInfoOUTINPUT1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrlStudentInfoOUTINPUT1.Location = new System.Drawing.Point(5, 305);
            this.ctrlStudentInfoOUTINPUT1.Name = "ctrlStudentInfoOUTINPUT1";
            this.ctrlStudentInfoOUTINPUT1.Size = new System.Drawing.Size(780, 209);
            this.ctrlStudentInfoOUTINPUT1.TabIndex = 1;
            // 
            // ctrlpersoninfo1
            // 
            this.ctrlpersoninfo1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ctrlpersoninfo1.Location = new System.Drawing.Point(3, 3);
            this.ctrlpersoninfo1.Name = "ctrlpersoninfo1";
            this.ctrlpersoninfo1.Size = new System.Drawing.Size(778, 296);
            this.ctrlpersoninfo1.TabIndex = 0;
            // 
            // ctrlstudentcard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.ctrlStudentInfoOUTINPUT1);
            this.Controls.Add(this.ctrlpersoninfo1);
            this.Name = "ctrlstudentcard";
            this.Size = new System.Drawing.Size(794, 513);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlpersoninfo ctrlpersoninfo1;
        private ctrlStudentInfoOUTINPUT ctrlStudentInfoOUTINPUT1;
    }
}
