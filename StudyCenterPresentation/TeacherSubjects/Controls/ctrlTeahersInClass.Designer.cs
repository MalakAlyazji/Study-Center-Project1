namespace StudyCenterPresentation
{
    partial class ctrlTeahersInClass
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbTeacherSubjectBy = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lbrecord = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvlist = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showTeacherDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showClassDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showGroupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbTeacherSubjectBy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlist)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTeacherSubjectBy
            // 
            this.gbTeacherSubjectBy.Controls.Add(this.lbrecord);
            this.gbTeacherSubjectBy.Controls.Add(this.label1);
            this.gbTeacherSubjectBy.Controls.Add(this.dgvlist);
            this.gbTeacherSubjectBy.CustomBorderColor = System.Drawing.Color.DarkSlateGray;
            this.gbTeacherSubjectBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTeacherSubjectBy.ForeColor = System.Drawing.Color.White;
            this.gbTeacherSubjectBy.Location = new System.Drawing.Point(2, 2);
            this.gbTeacherSubjectBy.Name = "gbTeacherSubjectBy";
            this.gbTeacherSubjectBy.Size = new System.Drawing.Size(897, 367);
            this.gbTeacherSubjectBy.TabIndex = 6;
            this.gbTeacherSubjectBy.Text = "Teachers who teacher in class:";
            // 
            // lbrecord
            // 
            this.lbrecord.AutoSize = true;
            this.lbrecord.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbrecord.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrecord.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbrecord.Location = new System.Drawing.Point(156, 324);
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvlist.DefaultCellStyle = dataGridViewCellStyle10;
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
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.contextMenuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showTeacherDetailsToolStripMenuItem,
            this.showClassDetailsToolStripMenuItem,
            this.showGroupsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(222, 98);
            // 
            // showTeacherDetailsToolStripMenuItem
            // 
            this.showTeacherDetailsToolStripMenuItem.Name = "showTeacherDetailsToolStripMenuItem";
            this.showTeacherDetailsToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.showTeacherDetailsToolStripMenuItem.Text = "Show Teacher Details";
            this.showTeacherDetailsToolStripMenuItem.Click += new System.EventHandler(this.showTeacherDetailsToolStripMenuItem_Click);
            // 
            // showClassDetailsToolStripMenuItem
            // 
            this.showClassDetailsToolStripMenuItem.Name = "showClassDetailsToolStripMenuItem";
            this.showClassDetailsToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.showClassDetailsToolStripMenuItem.Text = "Show Class Details";
            this.showClassDetailsToolStripMenuItem.Click += new System.EventHandler(this.showClassDetailsToolStripMenuItem_Click);
            // 
            // showGroupsToolStripMenuItem
            // 
            this.showGroupsToolStripMenuItem.Name = "showGroupsToolStripMenuItem";
            this.showGroupsToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.showGroupsToolStripMenuItem.Text = "Show Groups";
            this.showGroupsToolStripMenuItem.Click += new System.EventHandler(this.showGroupsToolStripMenuItem_Click);
            // 
            // ctrlTeahersInClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbTeacherSubjectBy);
            this.Name = "ctrlTeahersInClass";
            this.Size = new System.Drawing.Size(899, 371);
            this.gbTeacherSubjectBy.ResumeLayout(false);
            this.gbTeacherSubjectBy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlist)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbTeacherSubjectBy;
        private System.Windows.Forms.Label lbrecord;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvlist;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showTeacherDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showClassDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showGroupsToolStripMenuItem;
    }
}
