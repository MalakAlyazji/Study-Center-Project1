namespace StudyCenterPresentation
{
    partial class frmShowStudentGroup
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
            this.ctrlShowStudentGroupByGroupID1 = new StudyCenterPresentation.ctrlShowStudentGroupByGroupID();
            this.btnAddStudent = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // ctrlShowStudentGroupByGroupID1
            // 
            this.ctrlShowStudentGroupByGroupID1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrlShowStudentGroupByGroupID1.Location = new System.Drawing.Point(7, 1);
            this.ctrlShowStudentGroupByGroupID1.Name = "ctrlShowStudentGroupByGroupID1";
            this.ctrlShowStudentGroupByGroupID1.Size = new System.Drawing.Size(820, 437);
            this.ctrlShowStudentGroupByGroupID1.TabIndex = 0;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackgroundImage = global::StudyCenterPresentation.Properties.Resources.add_student;
            this.btnAddStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddStudent.Checked = true;
            this.btnAddStudent.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnAddStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddStudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddStudent.FillColor = System.Drawing.Color.White;
            this.btnAddStudent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddStudent.ForeColor = System.Drawing.Color.White;
            this.btnAddStudent.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnAddStudent.ImageOffset = new System.Drawing.Point(1, 0);
            this.btnAddStudent.ImageSize = new System.Drawing.Size(45, 45);
            this.btnAddStudent.Location = new System.Drawing.Point(749, 1);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(78, 64);
            this.btnAddStudent.TabIndex = 229;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // frmShowStudentGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(839, 440);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.ctrlShowStudentGroupByGroupID1);
            this.Name = "frmShowStudentGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show Student Group";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlShowStudentGroupByGroupID ctrlShowStudentGroupByGroupID1;
        private Guna.UI2.WinForms.Guna2Button btnAddStudent;
    }
}