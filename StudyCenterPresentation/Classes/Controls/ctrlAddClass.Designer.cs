namespace StudyCenterPresentation
{
    partial class ctrlAddClass
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
            this.txtClassName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCapacity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblClassID = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbAddClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAddClass
            // 
            this.gbAddClass.Controls.Add(this.txtClassName);
            this.gbAddClass.Controls.Add(this.txtCapacity);
            this.gbAddClass.Controls.Add(this.label3);
            this.gbAddClass.Controls.Add(this.label1);
            this.gbAddClass.Controls.Add(this.label2);
            this.gbAddClass.Controls.Add(this.lblClassID);
            this.gbAddClass.CustomBorderColor = System.Drawing.Color.DarkSlateGray;
            this.gbAddClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddClass.ForeColor = System.Drawing.Color.White;
            this.gbAddClass.Location = new System.Drawing.Point(3, 3);
            this.gbAddClass.Name = "gbAddClass";
            this.gbAddClass.Size = new System.Drawing.Size(525, 262);
            this.gbAddClass.TabIndex = 0;
            this.gbAddClass.Text = "Class Info:";
            // 
            // txtClassName
            // 
            this.txtClassName.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.txtClassName.BorderRadius = 20;
            this.txtClassName.BorderThickness = 3;
            this.txtClassName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClassName.DefaultText = "";
            this.txtClassName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtClassName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtClassName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClassName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClassName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtClassName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClassName.Location = new System.Drawing.Point(182, 140);
            this.txtClassName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.PasswordChar = '\0';
            this.txtClassName.PlaceholderText = "";
            this.txtClassName.SelectedText = "";
            this.txtClassName.Size = new System.Drawing.Size(209, 38);
            this.txtClassName.TabIndex = 212;
            this.txtClassName.Validating += new System.ComponentModel.CancelEventHandler(this.txtClassName_Validating);
            // 
            // txtCapacity
            // 
            this.txtCapacity.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.txtCapacity.BorderRadius = 20;
            this.txtCapacity.BorderThickness = 3;
            this.txtCapacity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCapacity.DefaultText = "";
            this.txtCapacity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCapacity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCapacity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCapacity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCapacity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtCapacity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCapacity.Location = new System.Drawing.Point(182, 206);
            this.txtCapacity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.PasswordChar = '\0';
            this.txtCapacity.PlaceholderText = "";
            this.txtCapacity.SelectedText = "";
            this.txtCapacity.Size = new System.Drawing.Size(209, 38);
            this.txtCapacity.TabIndex = 211;
            this.txtCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCapacity_KeyPress);
            this.txtCapacity.Validating += new System.ComponentModel.CancelEventHandler(this.txtCapacity_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(16, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 29);
            this.label3.TabIndex = 209;
            this.label3.Text = "Capacity:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(16, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 29);
            this.label1.TabIndex = 208;
            this.label1.Text = "Class Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(16, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 29);
            this.label2.TabIndex = 206;
            this.label2.Text = "Class ID:";
            // 
            // lblClassID
            // 
            this.lblClassID.AutoSize = true;
            this.lblClassID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassID.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblClassID.Location = new System.Drawing.Point(177, 73);
            this.lblClassID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblClassID.Name = "lblClassID";
            this.lblClassID.Size = new System.Drawing.Size(75, 29);
            this.lblClassID.TabIndex = 207;
            this.lblClassID.Text = "[????]";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlAddClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.gbAddClass);
            this.Name = "ctrlAddClass";
            this.Size = new System.Drawing.Size(531, 273);
            this.gbAddClass.ResumeLayout(false);
            this.gbAddClass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbAddClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblClassID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public Guna.UI2.WinForms.Guna2TextBox txtCapacity;
        public Guna.UI2.WinForms.Guna2TextBox txtClassName;
    }
}
