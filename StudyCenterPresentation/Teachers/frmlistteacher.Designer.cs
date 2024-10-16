namespace StudyCenterPresentation
{
    partial class frmlistteacher
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
            this.components = new System.ComponentModel.Container();
            this.txtfilterr = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbgender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnaddperson = new Guna.UI2.WinForms.Guna2PictureBox();
            this.NUMPageNumber = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.cbfilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbrecord = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbfilter = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvlist = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showTeachersDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teachedSubjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teachedClassesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnaddperson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUMPageNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlist)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtfilterr
            // 
            this.txtfilterr.AutoRoundedCorners = true;
            this.txtfilterr.BorderColor = System.Drawing.Color.Black;
            this.txtfilterr.BorderRadius = 18;
            this.txtfilterr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtfilterr.DefaultText = "";
            this.txtfilterr.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtfilterr.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtfilterr.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtfilterr.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtfilterr.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtfilterr.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtfilterr.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtfilterr.Location = new System.Drawing.Point(310, 204);
            this.txtfilterr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtfilterr.Name = "txtfilterr";
            this.txtfilterr.PasswordChar = '\0';
            this.txtfilterr.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.txtfilterr.PlaceholderText = "";
            this.txtfilterr.SelectedText = "";
            this.txtfilterr.Size = new System.Drawing.Size(202, 38);
            this.txtfilterr.TabIndex = 32;
            this.txtfilterr.Visible = false;
            this.txtfilterr.TextChanged += new System.EventHandler(this.txtfilterr_TextChanged);
            // 
            // cbgender
            // 
            this.cbgender.AutoRoundedCorners = true;
            this.cbgender.BackColor = System.Drawing.Color.Transparent;
            this.cbgender.BorderColor = System.Drawing.Color.Black;
            this.cbgender.BorderRadius = 17;
            this.cbgender.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.cbgender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbgender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbgender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbgender.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbgender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbgender.ItemHeight = 30;
            this.cbgender.Items.AddRange(new object[] {
            "All",
            "Male",
            "Female"});
            this.cbgender.Location = new System.Drawing.Point(310, 206);
            this.cbgender.Name = "cbgender";
            this.cbgender.Size = new System.Drawing.Size(202, 36);
            this.cbgender.TabIndex = 31;
            this.cbgender.Visible = false;
            this.cbgender.SelectedIndexChanged += new System.EventHandler(this.cbgender_SelectedIndexChanged);
            this.cbgender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbgender_KeyPress);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = global::StudyCenterPresentation.Properties.Resources.teacher;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(230, 1);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(394, 128);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 30;
            this.guna2PictureBox2.TabStop = false;
            // 
            // btnaddperson
            // 
            this.btnaddperson.BackColor = System.Drawing.Color.Transparent;
            this.btnaddperson.Image = global::StudyCenterPresentation.Properties.Resources.add_student;
            this.btnaddperson.ImageRotate = 0F;
            this.btnaddperson.Location = new System.Drawing.Point(859, 206);
            this.btnaddperson.Name = "btnaddperson";
            this.btnaddperson.Size = new System.Drawing.Size(80, 45);
            this.btnaddperson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnaddperson.TabIndex = 29;
            this.btnaddperson.TabStop = false;
            this.btnaddperson.Click += new System.EventHandler(this.btnaddperson_Click);
            // 
            // NUMPageNumber
            // 
            this.NUMPageNumber.AutoRoundedCorners = true;
            this.NUMPageNumber.BackColor = System.Drawing.Color.Transparent;
            this.NUMPageNumber.BorderRadius = 14;
            this.NUMPageNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NUMPageNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NUMPageNumber.Location = new System.Drawing.Point(754, 221);
            this.NUMPageNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NUMPageNumber.Name = "NUMPageNumber";
            this.NUMPageNumber.Size = new System.Drawing.Size(77, 30);
            this.NUMPageNumber.TabIndex = 28;
            this.NUMPageNumber.UpDownButtonFillColor = System.Drawing.Color.DarkSlateGray;
            this.NUMPageNumber.ValueChanged += new System.EventHandler(this.NUMPageNumber_ValueChanged);
            // 
            // cbfilter
            // 
            this.cbfilter.AutoRoundedCorners = true;
            this.cbfilter.BackColor = System.Drawing.Color.Transparent;
            this.cbfilter.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.cbfilter.BorderRadius = 17;
            this.cbfilter.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.cbfilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbfilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbfilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbfilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbfilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbfilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbfilter.ItemHeight = 30;
            this.cbfilter.Items.AddRange(new object[] {
            "None",
            "Teacher ID",
            "Teacher Name",
            "Gender",
            "Age"});
            this.cbfilter.Location = new System.Drawing.Point(91, 206);
            this.cbfilter.Name = "cbfilter";
            this.cbfilter.Size = new System.Drawing.Size(213, 36);
            this.cbfilter.TabIndex = 27;
            this.cbfilter.SelectedIndexChanged += new System.EventHandler(this.cbfilter_SelectedIndexChanged);
            // 
            // lbrecord
            // 
            this.lbrecord.AutoSize = true;
            this.lbrecord.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrecord.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbrecord.Location = new System.Drawing.Point(135, 695);
            this.lbrecord.Name = "lbrecord";
            this.lbrecord.Size = new System.Drawing.Size(20, 24);
            this.lbrecord.TabIndex = 26;
            this.lbrecord.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(679, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 28);
            this.label3.TabIndex = 25;
            this.label3.Text = "page :";
            // 
            // lbfilter
            // 
            this.lbfilter.AutoSize = true;
            this.lbfilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfilter.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbfilter.Location = new System.Drawing.Point(13, 216);
            this.lbfilter.Name = "lbfilter";
            this.lbfilter.Size = new System.Drawing.Size(72, 28);
            this.lbfilter.TabIndex = 24;
            this.lbfilter.Text = "Filter :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(246, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 51);
            this.label2.TabIndex = 23;
            this.label2.Text = "Manage Teachers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(13, 690);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 28);
            this.label1.TabIndex = 22;
            this.label1.Text = "# Records :";
            // 
            // dgvlist
            // 
            this.dgvlist.AllowUserToAddRows = false;
            this.dgvlist.AllowUserToDeleteRows = false;
            this.dgvlist.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlist.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvlist.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvlist.Location = new System.Drawing.Point(4, 258);
            this.dgvlist.Name = "dgvlist";
            this.dgvlist.ReadOnly = true;
            this.dgvlist.RowHeadersWidth = 51;
            this.dgvlist.RowTemplate.Height = 24;
            this.dgvlist.Size = new System.Drawing.Size(947, 429);
            this.dgvlist.TabIndex = 21;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showTeachersDetailsToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.assignToToolStripMenuItem,
            this.teachedSubjectsToolStripMenuItem,
            this.teachedClassesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(229, 148);
            // 
            // showTeachersDetailsToolStripMenuItem
            // 
            this.showTeachersDetailsToolStripMenuItem.Name = "showTeachersDetailsToolStripMenuItem";
            this.showTeachersDetailsToolStripMenuItem.Size = new System.Drawing.Size(228, 24);
            this.showTeachersDetailsToolStripMenuItem.Text = "Show Teacher\'s Details";
            this.showTeachersDetailsToolStripMenuItem.Click += new System.EventHandler(this.showTeachersDetailsToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(228, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(228, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // assignToToolStripMenuItem
            // 
            this.assignToToolStripMenuItem.Name = "assignToToolStripMenuItem";
            this.assignToToolStripMenuItem.Size = new System.Drawing.Size(228, 24);
            this.assignToToolStripMenuItem.Text = "Assign to Subjects";
            this.assignToToolStripMenuItem.Click += new System.EventHandler(this.assignToToolStripMenuItem_Click);
            // 
            // teachedSubjectsToolStripMenuItem
            // 
            this.teachedSubjectsToolStripMenuItem.Name = "teachedSubjectsToolStripMenuItem";
            this.teachedSubjectsToolStripMenuItem.Size = new System.Drawing.Size(228, 24);
            this.teachedSubjectsToolStripMenuItem.Text = "Teached Subjects";
            this.teachedSubjectsToolStripMenuItem.Click += new System.EventHandler(this.teachedSubjectsToolStripMenuItem_Click);
            // 
            // teachedClassesToolStripMenuItem
            // 
            this.teachedClassesToolStripMenuItem.Name = "teachedClassesToolStripMenuItem";
            this.teachedClassesToolStripMenuItem.Size = new System.Drawing.Size(228, 24);
            this.teachedClassesToolStripMenuItem.Text = "Teached Classes";
            this.teachedClassesToolStripMenuItem.Click += new System.EventHandler(this.teachedClassesToolStripMenuItem_Click);
            // 
            // frmlistteacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(961, 721);
            this.Controls.Add(this.txtfilterr);
            this.Controls.Add(this.cbgender);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.btnaddperson);
            this.Controls.Add(this.NUMPageNumber);
            this.Controls.Add(this.cbfilter);
            this.Controls.Add(this.lbrecord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbfilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvlist);
            this.Name = "frmlistteacher";
            this.Text = "List Teachers";
            this.Load += new System.EventHandler(this.frmlistteacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnaddperson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUMPageNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlist)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtfilterr;
        private Guna.UI2.WinForms.Guna2ComboBox cbgender;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2PictureBox btnaddperson;
        private Guna.UI2.WinForms.Guna2NumericUpDown NUMPageNumber;
        private Guna.UI2.WinForms.Guna2ComboBox cbfilter;
        private System.Windows.Forms.Label lbrecord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbfilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvlist;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showTeachersDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teachedSubjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teachedClassesToolStripMenuItem;
    }
}