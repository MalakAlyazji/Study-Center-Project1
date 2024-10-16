namespace StudyCenterPresentation.Students
{
    partial class frmliststudents
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
            this.dgvlist = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showStudentsDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbrecord = new System.Windows.Forms.Label();
            this.NUMPageNumber = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnaddperson = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbfilter = new System.Windows.Forms.Label();
            this.cbfilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbgender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtfilterr = new Guna.UI2.WinForms.Guna2TextBox();
            this.cblevels = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlist)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUMPageNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnaddperson)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvlist
            // 
            this.dgvlist.AllowUserToAddRows = false;
            this.dgvlist.AllowUserToDeleteRows = false;
            this.dgvlist.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlist.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvlist.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvlist.Location = new System.Drawing.Point(4, 267);
            this.dgvlist.Name = "dgvlist";
            this.dgvlist.ReadOnly = true;
            this.dgvlist.RowHeadersWidth = 51;
            this.dgvlist.RowTemplate.Height = 24;
            this.dgvlist.Size = new System.Drawing.Size(947, 429);
            this.dgvlist.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showStudentsDetailsToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.assignToToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(229, 100);
            // 
            // showStudentsDetailsToolStripMenuItem
            // 
            this.showStudentsDetailsToolStripMenuItem.Name = "showStudentsDetailsToolStripMenuItem";
            this.showStudentsDetailsToolStripMenuItem.Size = new System.Drawing.Size(228, 24);
            this.showStudentsDetailsToolStripMenuItem.Text = "Show Student\'s Details";
            this.showStudentsDetailsToolStripMenuItem.Click += new System.EventHandler(this.showStudentsDetailsToolStripMenuItem_Click);
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
            this.assignToToolStripMenuItem.Text = "Assign to Group";
            this.assignToToolStripMenuItem.Click += new System.EventHandler(this.assignToToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(12, 709);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "# Records :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(254, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 51);
            this.label2.TabIndex = 3;
            this.label2.Text = "Manage Students";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(614, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "page :";
            // 
            // lbrecord
            // 
            this.lbrecord.AutoSize = true;
            this.lbrecord.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrecord.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbrecord.Location = new System.Drawing.Point(134, 714);
            this.lbrecord.Name = "lbrecord";
            this.lbrecord.Size = new System.Drawing.Size(20, 24);
            this.lbrecord.TabIndex = 10;
            this.lbrecord.Text = "0";
            // 
            // NUMPageNumber
            // 
            this.NUMPageNumber.AutoRoundedCorners = true;
            this.NUMPageNumber.BackColor = System.Drawing.Color.Transparent;
            this.NUMPageNumber.BorderRadius = 14;
            this.NUMPageNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NUMPageNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NUMPageNumber.Location = new System.Drawing.Point(707, 217);
            this.NUMPageNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NUMPageNumber.Name = "NUMPageNumber";
            this.NUMPageNumber.Size = new System.Drawing.Size(61, 30);
            this.NUMPageNumber.TabIndex = 12;
            this.NUMPageNumber.UpDownButtonFillColor = System.Drawing.Color.DarkSlateGray;
            this.NUMPageNumber.ValueChanged += new System.EventHandler(this.NUMPageNumber_ValueChanged);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = global::StudyCenterPresentation.Properties.Resources.grade_level;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(238, 2);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(394, 128);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 14;
            this.guna2PictureBox2.TabStop = false;
            // 
            // btnaddperson
            // 
            this.btnaddperson.BackColor = System.Drawing.Color.Transparent;
            this.btnaddperson.Image = global::StudyCenterPresentation.Properties.Resources.add_student;
            this.btnaddperson.ImageRotate = 0F;
            this.btnaddperson.Location = new System.Drawing.Point(808, 202);
            this.btnaddperson.Name = "btnaddperson";
            this.btnaddperson.Size = new System.Drawing.Size(80, 45);
            this.btnaddperson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnaddperson.TabIndex = 13;
            this.btnaddperson.TabStop = false;
            this.btnaddperson.Click += new System.EventHandler(this.btnaddperson_Click);
            // 
            // lbfilter
            // 
            this.lbfilter.AutoSize = true;
            this.lbfilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfilter.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbfilter.Location = new System.Drawing.Point(21, 217);
            this.lbfilter.Name = "lbfilter";
            this.lbfilter.Size = new System.Drawing.Size(72, 28);
            this.lbfilter.TabIndex = 5;
            this.lbfilter.Text = "Filter :";
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
            "Student ID",
            "Name",
            "Grade",
            "Gender",
            "Age"});
            this.cbfilter.Location = new System.Drawing.Point(99, 207);
            this.cbfilter.Name = "cbfilter";
            this.cbfilter.Size = new System.Drawing.Size(213, 36);
            this.cbfilter.TabIndex = 11;
            this.cbfilter.SelectedIndexChanged += new System.EventHandler(this.cbfilter_SelectedIndexChanged);
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
            this.cbgender.Location = new System.Drawing.Point(318, 202);
            this.cbgender.Name = "cbgender";
            this.cbgender.Size = new System.Drawing.Size(202, 36);
            this.cbgender.TabIndex = 15;
            this.cbgender.Visible = false;
            this.cbgender.SelectedIndexChanged += new System.EventHandler(this.cbgender_SelectedIndexChanged);
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
            this.txtfilterr.Location = new System.Drawing.Point(318, 202);
            this.txtfilterr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtfilterr.Name = "txtfilterr";
            this.txtfilterr.PasswordChar = '\0';
            this.txtfilterr.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.txtfilterr.PlaceholderText = "";
            this.txtfilterr.SelectedText = "";
            this.txtfilterr.Size = new System.Drawing.Size(202, 38);
            this.txtfilterr.TabIndex = 19;
            this.txtfilterr.Visible = false;
            this.txtfilterr.TextChanged += new System.EventHandler(this.txtfilterr_TextChanged);
            this.txtfilterr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfilterr_KeyPress);
            // 
            // cblevels
            // 
            this.cblevels.AutoRoundedCorners = true;
            this.cblevels.BackColor = System.Drawing.Color.Transparent;
            this.cblevels.BorderColor = System.Drawing.Color.Black;
            this.cblevels.BorderRadius = 17;
            this.cblevels.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.cblevels.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cblevels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cblevels.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cblevels.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cblevels.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cblevels.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cblevels.ItemHeight = 30;
            this.cblevels.Items.AddRange(new object[] {
            "All"});
            this.cblevels.Location = new System.Drawing.Point(318, 202);
            this.cblevels.Name = "cblevels";
            this.cblevels.Size = new System.Drawing.Size(202, 36);
            this.cblevels.TabIndex = 20;
            this.cblevels.Visible = false;
            this.cblevels.SelectedIndexChanged += new System.EventHandler(this.cblevels_SelectedIndexChanged);
            // 
            // frmliststudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(963, 746);
            this.Controls.Add(this.cblevels);
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
            this.Name = "frmliststudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Students";
            this.Load += new System.EventHandler(this.frmliststudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlist)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUMPageNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnaddperson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvlist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbrecord;
        private Guna.UI2.WinForms.Guna2NumericUpDown NUMPageNumber;
        private Guna.UI2.WinForms.Guna2PictureBox btnaddperson;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showStudentsDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignToToolStripMenuItem;
        private System.Windows.Forms.Label lbfilter;
        private Guna.UI2.WinForms.Guna2ComboBox cbfilter;
        private Guna.UI2.WinForms.Guna2ComboBox cbgender;
        private Guna.UI2.WinForms.Guna2TextBox txtfilterr;
        private Guna.UI2.WinForms.Guna2ComboBox cblevels;
    }
}