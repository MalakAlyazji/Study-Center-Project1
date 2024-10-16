namespace StudyCenterPresentation
{
    partial class ctrlShowGroupsInClass
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbGroupsInClass = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lbrecord = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvlist = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showGroupDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbGroupsInClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlist)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGroupsInClass
            // 
            this.gbGroupsInClass.Controls.Add(this.lbrecord);
            this.gbGroupsInClass.Controls.Add(this.label1);
            this.gbGroupsInClass.Controls.Add(this.dgvlist);
            this.gbGroupsInClass.CustomBorderColor = System.Drawing.Color.DarkSlateGray;
            this.gbGroupsInClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGroupsInClass.ForeColor = System.Drawing.Color.White;
            this.gbGroupsInClass.Location = new System.Drawing.Point(3, 3);
            this.gbGroupsInClass.Name = "gbGroupsInClass";
            this.gbGroupsInClass.Size = new System.Drawing.Size(897, 367);
            this.gbGroupsInClass.TabIndex = 7;
            this.gbGroupsInClass.Text = "Groups in class:";
            // 
            // lbrecord
            // 
            this.lbrecord.AutoSize = true;
            this.lbrecord.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbrecord.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrecord.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbrecord.Location = new System.Drawing.Point(156, 329);
            this.lbrecord.Name = "lbrecord";
            this.lbrecord.Size = new System.Drawing.Size(20, 24);
            this.lbrecord.TabIndex = 36;
            this.lbrecord.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(19, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 28);
            this.label1.TabIndex = 35;
            this.label1.Text = "# Records :";
            // 
            // dgvlist
            // 
            this.dgvlist.AllowUserToAddRows = false;
            this.dgvlist.AllowUserToDeleteRows = false;
            this.dgvlist.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvlist.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvlist.GridColor = System.Drawing.Color.Black;
            this.dgvlist.Location = new System.Drawing.Point(12, 52);
            this.dgvlist.Name = "dgvlist";
            this.dgvlist.ReadOnly = true;
            this.dgvlist.RowHeadersWidth = 51;
            this.dgvlist.RowTemplate.Height = 24;
            this.dgvlist.Size = new System.Drawing.Size(870, 269);
            this.dgvlist.TabIndex = 34;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showGroupDetailsToolStripMenuItem,
            this.editToolStripMenuItem,
            this.showStudentToolStripMenuItem,
            this.addStudentToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(210, 100);
            // 
            // showGroupDetailsToolStripMenuItem
            // 
            this.showGroupDetailsToolStripMenuItem.Name = "showGroupDetailsToolStripMenuItem";
            this.showGroupDetailsToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.showGroupDetailsToolStripMenuItem.Text = "Show Group Details";
            this.showGroupDetailsToolStripMenuItem.Click += new System.EventHandler(this.showGroupDetailsToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // showStudentToolStripMenuItem
            // 
            this.showStudentToolStripMenuItem.Name = "showStudentToolStripMenuItem";
            this.showStudentToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.showStudentToolStripMenuItem.Text = "Show Students";
            this.showStudentToolStripMenuItem.Click += new System.EventHandler(this.showStudentToolStripMenuItem_Click);
            // 
            // addStudentToolStripMenuItem
            // 
            this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.addStudentToolStripMenuItem.Text = "Add Student";
            this.addStudentToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // ctrlShowGroupsInClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.gbGroupsInClass);
            this.Name = "ctrlShowGroupsInClass";
            this.Size = new System.Drawing.Size(902, 368);
            this.gbGroupsInClass.ResumeLayout(false);
            this.gbGroupsInClass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlist)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbGroupsInClass;
        private System.Windows.Forms.Label lbrecord;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvlist;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showGroupDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
    }
}
