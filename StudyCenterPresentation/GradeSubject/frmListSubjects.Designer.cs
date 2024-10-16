namespace StudyCenterPresentation
{
    partial class frmListSubjects
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbrecord = new System.Windows.Forms.Label();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnaddperson = new Guna.UI2.WinForms.Guna2PictureBox();
            this.NUMPageNumber = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvlist = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showSubjectDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whoTeachsThisSubjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbfilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbfilter = new System.Windows.Forms.Label();
            this.txtfilterr = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnaddperson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUMPageNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlist)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbrecord
            // 
            this.lbrecord.AutoSize = true;
            this.lbrecord.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbrecord.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrecord.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbrecord.Location = new System.Drawing.Point(147, 667);
            this.lbrecord.Name = "lbrecord";
            this.lbrecord.Size = new System.Drawing.Size(20, 24);
            this.lbrecord.TabIndex = 50;
            this.lbrecord.Text = "0";
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = global::StudyCenterPresentation.Properties.Resources.subjects;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(218, 3);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(394, 128);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 49;
            this.guna2PictureBox2.TabStop = false;
            // 
            // btnaddperson
            // 
            this.btnaddperson.BackColor = System.Drawing.Color.Transparent;
            this.btnaddperson.Image = global::StudyCenterPresentation.Properties.Resources.book_stack;
            this.btnaddperson.ImageRotate = 0F;
            this.btnaddperson.Location = new System.Drawing.Point(839, 186);
            this.btnaddperson.Name = "btnaddperson";
            this.btnaddperson.Size = new System.Drawing.Size(61, 37);
            this.btnaddperson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnaddperson.TabIndex = 48;
            this.btnaddperson.TabStop = false;
            this.btnaddperson.Click += new System.EventHandler(this.btnaddSubject_Click);
            // 
            // NUMPageNumber
            // 
            this.NUMPageNumber.AutoRoundedCorners = true;
            this.NUMPageNumber.BackColor = System.Drawing.Color.Transparent;
            this.NUMPageNumber.BorderRadius = 14;
            this.NUMPageNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NUMPageNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NUMPageNumber.Location = new System.Drawing.Point(748, 193);
            this.NUMPageNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NUMPageNumber.Name = "NUMPageNumber";
            this.NUMPageNumber.Size = new System.Drawing.Size(77, 30);
            this.NUMPageNumber.TabIndex = 47;
            this.NUMPageNumber.UpDownButtonFillColor = System.Drawing.Color.DarkSlateGray;
            this.NUMPageNumber.ValueChanged += new System.EventHandler(this.NUMPageNumber_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(673, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 28);
            this.label3.TabIndex = 46;
            this.label3.Text = "page :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(237, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 51);
            this.label2.TabIndex = 45;
            this.label2.Text = "Manage Subjects";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(25, 662);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 28);
            this.label1.TabIndex = 44;
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
            this.dgvlist.Location = new System.Drawing.Point(17, 244);
            this.dgvlist.Name = "dgvlist";
            this.dgvlist.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvlist.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvlist.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvlist.RowTemplate.Height = 24;
            this.dgvlist.Size = new System.Drawing.Size(902, 415);
            this.dgvlist.TabIndex = 43;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showSubjectDetailsToolStripMenuItem,
            this.editToolStripMenuItem,
            this.whoTeachsThisSubjectToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(245, 76);
            // 
            // showSubjectDetailsToolStripMenuItem
            // 
            this.showSubjectDetailsToolStripMenuItem.Name = "showSubjectDetailsToolStripMenuItem";
            this.showSubjectDetailsToolStripMenuItem.Size = new System.Drawing.Size(244, 24);
            this.showSubjectDetailsToolStripMenuItem.Text = "Show Subject Details";
            this.showSubjectDetailsToolStripMenuItem.Click += new System.EventHandler(this.showSubjectDetailsToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(244, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // whoTeachsThisSubjectToolStripMenuItem
            // 
            this.whoTeachsThisSubjectToolStripMenuItem.Name = "whoTeachsThisSubjectToolStripMenuItem";
            this.whoTeachsThisSubjectToolStripMenuItem.Size = new System.Drawing.Size(244, 24);
            this.whoTeachsThisSubjectToolStripMenuItem.Text = "Who Teachs this Subject?";
            this.whoTeachsThisSubjectToolStripMenuItem.Click += new System.EventHandler(this.whoTeachsThisSubjectToolStripMenuItem_Click);
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
            "Subject Grade Level ID",
            "Subject Name",
            "Grade Level Name"});
            this.cbfilter.Location = new System.Drawing.Point(90, 195);
            this.cbfilter.Name = "cbfilter";
            this.cbfilter.Size = new System.Drawing.Size(249, 36);
            this.cbfilter.TabIndex = 52;
            this.cbfilter.SelectedIndexChanged += new System.EventHandler(this.cbfilter_SelectedIndexChanged);
            // 
            // lbfilter
            // 
            this.lbfilter.AutoSize = true;
            this.lbfilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfilter.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbfilter.Location = new System.Drawing.Point(12, 194);
            this.lbfilter.Name = "lbfilter";
            this.lbfilter.Size = new System.Drawing.Size(72, 28);
            this.lbfilter.TabIndex = 51;
            this.lbfilter.Text = "Filter :";
            // 
            // txtfilterr
            // 
            this.txtfilterr.AutoRoundedCorners = true;
            this.txtfilterr.BorderColor = System.Drawing.Color.Black;
            this.txtfilterr.BorderRadius = 17;
            this.txtfilterr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtfilterr.DefaultText = "";
            this.txtfilterr.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtfilterr.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtfilterr.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtfilterr.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtfilterr.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtfilterr.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtfilterr.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtfilterr.Location = new System.Drawing.Point(345, 194);
            this.txtfilterr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtfilterr.Name = "txtfilterr";
            this.txtfilterr.PasswordChar = '\0';
            this.txtfilterr.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.txtfilterr.PlaceholderText = "";
            this.txtfilterr.SelectedText = "";
            this.txtfilterr.Size = new System.Drawing.Size(177, 37);
            this.txtfilterr.TabIndex = 53;
            this.txtfilterr.Visible = false;
            this.txtfilterr.TextChanged += new System.EventHandler(this.txtfilterr_TextChanged);
            this.txtfilterr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfilterr_KeyPress);
            // 
            // frmListSubjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(939, 689);
            this.Controls.Add(this.txtfilterr);
            this.Controls.Add(this.cbfilter);
            this.Controls.Add(this.lbfilter);
            this.Controls.Add(this.lbrecord);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.btnaddperson);
            this.Controls.Add(this.NUMPageNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvlist);
            this.Name = "frmListSubjects";
            this.Text = "frmListSubjects";
            this.Load += new System.EventHandler(this.frmListSubjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnaddperson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUMPageNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlist)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbrecord;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2PictureBox btnaddperson;
        private Guna.UI2.WinForms.Guna2NumericUpDown NUMPageNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvlist;
        private Guna.UI2.WinForms.Guna2ComboBox cbfilter;
        private System.Windows.Forms.Label lbfilter;
        private Guna.UI2.WinForms.Guna2TextBox txtfilterr;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showSubjectDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whoTeachsThisSubjectToolStripMenuItem;
    }
}