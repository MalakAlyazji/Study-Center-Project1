namespace StudyCenterPresentation
{
    partial class ctrlFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlFilter));
            this.cbfilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtfilter = new Guna.UI2.WinForms.Guna2TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbfilter = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnsearch = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gbfilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnsearch)).BeginInit();
            this.SuspendLayout();
            // 
            // cbfilter
            // 
            this.cbfilter.AutoRoundedCorners = true;
            this.cbfilter.BackColor = System.Drawing.Color.Transparent;
            this.cbfilter.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.cbfilter.BorderRadius = 17;
            this.cbfilter.BorderThickness = 2;
            this.cbfilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbfilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbfilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbfilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbfilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbfilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbfilter.ItemHeight = 30;
            this.cbfilter.Items.AddRange(new object[] {
            "Person ID"});
            this.cbfilter.Location = new System.Drawing.Point(121, 71);
            this.cbfilter.Name = "cbfilter";
            this.cbfilter.Size = new System.Drawing.Size(179, 36);
            this.cbfilter.TabIndex = 32;
            this.cbfilter.SelectedIndexChanged += new System.EventHandler(this.cbfilter_SelectedIndexChanged);
            // 
            // txtfilter
            // 
            this.txtfilter.AutoRoundedCorners = true;
            this.txtfilter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtfilter.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.txtfilter.BorderRadius = 20;
            this.txtfilter.BorderThickness = 2;
            this.txtfilter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtfilter.DefaultText = "";
            this.txtfilter.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtfilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtfilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtfilter.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtfilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtfilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtfilter.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtfilter.Location = new System.Drawing.Point(322, 71);
            this.txtfilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtfilter.Name = "txtfilter";
            this.txtfilter.PasswordChar = '\0';
            this.txtfilter.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.txtfilter.PlaceholderText = "";
            this.txtfilter.SelectedText = "";
            this.txtfilter.Size = new System.Drawing.Size(197, 42);
            this.txtfilter.TabIndex = 29;
            this.txtfilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfilter_KeyPress);
            this.txtfilter.Validating += new System.ComponentModel.CancelEventHandler(this.txtfilter_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // gbfilter
            // 
            this.gbfilter.BorderThickness = 2;
            this.gbfilter.Controls.Add(this.btnAdd);
            this.gbfilter.Controls.Add(this.btnsearch);
            this.gbfilter.Controls.Add(this.guna2TextBox1);
            this.gbfilter.Controls.Add(this.cbfilter);
            this.gbfilter.Controls.Add(this.txtfilter);
            this.gbfilter.CustomBorderColor = System.Drawing.Color.DarkSlateGray;
            this.gbfilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbfilter.ForeColor = System.Drawing.Color.White;
            this.gbfilter.Location = new System.Drawing.Point(0, 0);
            this.gbfilter.Name = "gbfilter";
            this.gbfilter.Size = new System.Drawing.Size(781, 133);
            this.gbfilter.TabIndex = 33;
            this.gbfilter.Text = "Filter:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.BackgroundImage = global::StudyCenterPresentation.Properties.Resources.add;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.FillColor = System.Drawing.Color.Transparent;
            this.btnAdd.ImageRotate = 0F;
            this.btnAdd.Location = new System.Drawing.Point(671, 64);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 43);
            this.btnAdd.TabIndex = 35;
            this.btnAdd.TabStop = false;
            this.btnAdd.Click += new System.EventHandler(this.btnaddperson_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsearch.BackgroundImage")));
            this.btnsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsearch.FillColor = System.Drawing.Color.Transparent;
            this.btnsearch.ImageRotate = 0F;
            this.btnsearch.Location = new System.Drawing.Point(568, 64);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(64, 43);
            this.btnsearch.TabIndex = 34;
            this.btnsearch.TabStop = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.AutoSize = true;
            this.guna2TextBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2TextBox1.BorderColor = System.Drawing.Color.White;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "Filter:";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(16, 64);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.White;
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(86, 43);
            this.guna2TextBox1.TabIndex = 33;
            // 
            // ctrlFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbfilter);
            this.Name = "ctrlFilter";
            this.Size = new System.Drawing.Size(781, 133);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gbfilter.ResumeLayout(false);
            this.gbfilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnsearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2GroupBox gbfilter;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        public Guna.UI2.WinForms.Guna2ComboBox cbfilter;
        public Guna.UI2.WinForms.Guna2TextBox txtfilter;
        private Guna.UI2.WinForms.Guna2PictureBox btnAdd;
        private Guna.UI2.WinForms.Guna2PictureBox btnsearch;
    }
}
