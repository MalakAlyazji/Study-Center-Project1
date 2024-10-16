namespace StudyCenterPresentation
{
    partial class ctrlAddMeeting
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
            this.gbAddClass = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tpStartTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cbMeetingDays = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMeetingID = new System.Windows.Forms.Label();
            this.gbAddClass.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAddClass
            // 
            this.gbAddClass.Controls.Add(this.lblEndTime);
            this.gbAddClass.Controls.Add(this.label4);
            this.gbAddClass.Controls.Add(this.label3);
            this.gbAddClass.Controls.Add(this.tpStartTime);
            this.gbAddClass.Controls.Add(this.cbMeetingDays);
            this.gbAddClass.Controls.Add(this.label1);
            this.gbAddClass.Controls.Add(this.label2);
            this.gbAddClass.Controls.Add(this.lblMeetingID);
            this.gbAddClass.CustomBorderColor = System.Drawing.Color.DarkSlateGray;
            this.gbAddClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddClass.ForeColor = System.Drawing.Color.White;
            this.gbAddClass.Location = new System.Drawing.Point(3, 3);
            this.gbAddClass.Name = "gbAddClass";
            this.gbAddClass.Size = new System.Drawing.Size(525, 299);
            this.gbAddClass.TabIndex = 2;
            this.gbAddClass.Text = "Meeting Info:";
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndTime.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblEndTime.Location = new System.Drawing.Point(222, 257);
            this.lblEndTime.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(75, 29);
            this.lblEndTime.TabIndex = 217;
            this.lblEndTime.Text = "[????]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(16, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 29);
            this.label4.TabIndex = 216;
            this.label4.Text = "End Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(16, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 29);
            this.label3.TabIndex = 215;
            this.label3.Text = "Start Time:";
            // 
            // tpStartTime
            // 
            this.tpStartTime.BorderRadius = 15;
            this.tpStartTime.BorderThickness = 3;
            this.tpStartTime.Checked = true;
            this.tpStartTime.CustomFormat = "\"hh:mm\"";
            this.tpStartTime.FillColor = System.Drawing.Color.DarkSlateGray;
            this.tpStartTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tpStartTime.Location = new System.Drawing.Point(205, 188);
            this.tpStartTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.tpStartTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.tpStartTime.Name = "tpStartTime";
            this.tpStartTime.ShowUpDown = true;
            this.tpStartTime.Size = new System.Drawing.Size(250, 39);
            this.tpStartTime.TabIndex = 214;
            this.tpStartTime.Value = new System.DateTime(2024, 9, 22, 8, 0, 0, 0);
            this.tpStartTime.ValueChanged += new System.EventHandler(this.tpStartTime_ValueChanged);
            // 
            // cbMeetingDays
            // 
            this.cbMeetingDays.BackColor = System.Drawing.Color.Transparent;
            this.cbMeetingDays.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.cbMeetingDays.BorderRadius = 20;
            this.cbMeetingDays.BorderThickness = 2;
            this.cbMeetingDays.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMeetingDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMeetingDays.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMeetingDays.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMeetingDays.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbMeetingDays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbMeetingDays.ItemHeight = 30;
            this.cbMeetingDays.Items.AddRange(new object[] {
            "Daily",
            "STT",
            "MW"});
            this.cbMeetingDays.Location = new System.Drawing.Point(205, 114);
            this.cbMeetingDays.Name = "cbMeetingDays";
            this.cbMeetingDays.Size = new System.Drawing.Size(250, 36);
            this.cbMeetingDays.TabIndex = 213;
            this.cbMeetingDays.SelectedIndexChanged += new System.EventHandler(this.cbMeetingDays_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(16, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 29);
            this.label1.TabIndex = 208;
            this.label1.Text = "Meeting Days:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(16, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 29);
            this.label2.TabIndex = 206;
            this.label2.Text = "Meeting ID:";
            // 
            // lblMeetingID
            // 
            this.lblMeetingID.AutoSize = true;
            this.lblMeetingID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMeetingID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeetingID.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblMeetingID.Location = new System.Drawing.Point(222, 61);
            this.lblMeetingID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMeetingID.Name = "lblMeetingID";
            this.lblMeetingID.Size = new System.Drawing.Size(75, 29);
            this.lblMeetingID.TabIndex = 207;
            this.lblMeetingID.Text = "[????]";
            // 
            // ctrlAddMeeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbAddClass);
            this.Name = "ctrlAddMeeting";
            this.Size = new System.Drawing.Size(532, 306);
            this.gbAddClass.ResumeLayout(false);
            this.gbAddClass.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbAddClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblMeetingID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public Guna.UI2.WinForms.Guna2DateTimePicker tpStartTime;
        public Guna.UI2.WinForms.Guna2ComboBox cbMeetingDays;
        public System.Windows.Forms.Label lblEndTime;
    }
}
