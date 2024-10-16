namespace StudyCenterPresentation
{
    partial class ctrlAddGrade
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
            this.components = new System.ComponentModel.Container();
            this.gbAddClass = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtGradeName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGradeID = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbAddClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAddClass
            // 
            this.gbAddClass.Controls.Add(this.txtGradeName);
            this.gbAddClass.Controls.Add(this.label1);
            this.gbAddClass.Controls.Add(this.label2);
            this.gbAddClass.Controls.Add(this.lblGradeID);
            this.gbAddClass.CustomBorderColor = System.Drawing.Color.DarkSlateGray;
            this.gbAddClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddClass.ForeColor = System.Drawing.Color.White;
            this.gbAddClass.Location = new System.Drawing.Point(3, 3);
            this.gbAddClass.Name = "gbAddClass";
            this.gbAddClass.Size = new System.Drawing.Size(525, 204);
            this.gbAddClass.TabIndex = 1;
            this.gbAddClass.Text = "Grade Level Info:";
            // 
            // txtGradeName
            // 
            this.txtGradeName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtGradeName.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.txtGradeName.BorderRadius = 20;
            this.txtGradeName.BorderThickness = 3;
            this.txtGradeName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGradeName.DefaultText = "";
            this.txtGradeName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGradeName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGradeName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGradeName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGradeName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGradeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtGradeName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGradeName.Location = new System.Drawing.Point(282, 140);
            this.txtGradeName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGradeName.Name = "txtGradeName";
            this.txtGradeName.PasswordChar = '\0';
            this.txtGradeName.PlaceholderText = "";
            this.txtGradeName.SelectedText = "";
            this.txtGradeName.Size = new System.Drawing.Size(209, 38);
            this.txtGradeName.TabIndex = 212;
            this.txtGradeName.Validating += new System.ComponentModel.CancelEventHandler(this.txtClassName_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(16, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 29);
            this.label1.TabIndex = 208;
            this.label1.Text = "Grade Level Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(16, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 29);
            this.label2.TabIndex = 206;
            this.label2.Text = "Grade Level ID:";
            // 
            // lblGradeID
            // 
            this.lblGradeID.AutoSize = true;
            this.lblGradeID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGradeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradeID.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblGradeID.Location = new System.Drawing.Point(238, 73);
            this.lblGradeID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblGradeID.Name = "lblGradeID";
            this.lblGradeID.Size = new System.Drawing.Size(75, 29);
            this.lblGradeID.TabIndex = 207;
            this.lblGradeID.Text = "[????]";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlAddGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbAddClass);
            this.Name = "ctrlAddGrade";
            this.Size = new System.Drawing.Size(534, 212);
            this.gbAddClass.ResumeLayout(false);
            this.gbAddClass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbAddClass;
        public Guna.UI2.WinForms.Guna2TextBox txtGradeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblGradeID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
