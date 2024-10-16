namespace StudyCenterPresentation
{
    partial class frmAssignStudentToGroup
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tbStudentInfo = new System.Windows.Forms.TabPage();
            this.ctrlStudentIfoFILTER1 = new StudyCenterPresentation.ctrlStudentIfoFILTER();
            this.tbGroupInfo = new System.Windows.Forms.TabPage();
            this.ctrlGroupCard1 = new StudyCenterPresentation.ctrlGroupCard();
            this.gbSelectGroup = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbGroupNames = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbMeetingDays = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbSubjectNames = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvGroupsList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btclose = new Guna.UI2.WinForms.Guna2Button();
            this.btsave = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TabControl1.SuspendLayout();
            this.tbStudentInfo.SuspendLayout();
            this.tbGroupInfo.SuspendLayout();
            this.gbSelectGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupsList)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.guna2TabControl1.Controls.Add(this.tbStudentInfo);
            this.guna2TabControl1.Controls.Add(this.tbGroupInfo);
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(12, 57);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(941, 704);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.TabIndex = 209;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.DarkSlateGray;
            this.guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tbStudentInfo
            // 
            this.tbStudentInfo.Controls.Add(this.ctrlStudentIfoFILTER1);
            this.tbStudentInfo.Location = new System.Drawing.Point(4, 44);
            this.tbStudentInfo.Name = "tbStudentInfo";
            this.tbStudentInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbStudentInfo.Size = new System.Drawing.Size(933, 656);
            this.tbStudentInfo.TabIndex = 0;
            this.tbStudentInfo.Text = "Student info";
            this.tbStudentInfo.UseVisualStyleBackColor = true;
            // 
            // ctrlStudentIfoFILTER1
            // 
            this.ctrlStudentIfoFILTER1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrlStudentIfoFILTER1.FilterEnabled = false;
            this.ctrlStudentIfoFILTER1.Location = new System.Drawing.Point(36, 6);
            this.ctrlStudentIfoFILTER1.Name = "ctrlStudentIfoFILTER1";
            this.ctrlStudentIfoFILTER1.Size = new System.Drawing.Size(781, 640);
            this.ctrlStudentIfoFILTER1.TabIndex = 0;
            this.ctrlStudentIfoFILTER1.OnStudentSelected += new System.EventHandler<StudyCenterPresentation.ctrlStudentIfoFILTER.SelectedStudentEventArgs>(this.ctrlStudentIfoFILTER1_OnStudentSelected);
            // 
            // tbGroupInfo
            // 
            this.tbGroupInfo.Controls.Add(this.ctrlGroupCard1);
            this.tbGroupInfo.Controls.Add(this.gbSelectGroup);
            this.tbGroupInfo.Location = new System.Drawing.Point(4, 44);
            this.tbGroupInfo.Name = "tbGroupInfo";
            this.tbGroupInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbGroupInfo.Size = new System.Drawing.Size(933, 656);
            this.tbGroupInfo.TabIndex = 1;
            this.tbGroupInfo.Text = "Group Info";
            this.tbGroupInfo.UseVisualStyleBackColor = true;
            // 
            // ctrlGroupCard1
            // 
            this.ctrlGroupCard1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrlGroupCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlGroupCard1.Location = new System.Drawing.Point(7, 8);
            this.ctrlGroupCard1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlGroupCard1.Name = "ctrlGroupCard1";
            this.ctrlGroupCard1.Size = new System.Drawing.Size(896, 410);
            this.ctrlGroupCard1.TabIndex = 237;
            this.ctrlGroupCard1.Visible = false;
            // 
            // gbSelectGroup
            // 
            this.gbSelectGroup.BackColor = System.Drawing.Color.White;
            this.gbSelectGroup.Controls.Add(this.txtSearch);
            this.gbSelectGroup.Controls.Add(this.cbGroupNames);
            this.gbSelectGroup.Controls.Add(this.cbMeetingDays);
            this.gbSelectGroup.Controls.Add(this.cbSubjectNames);
            this.gbSelectGroup.Controls.Add(this.cbFilter);
            this.gbSelectGroup.Controls.Add(this.label1);
            this.gbSelectGroup.Controls.Add(this.dgvGroupsList);
            this.gbSelectGroup.CustomBorderColor = System.Drawing.Color.DarkSlateGray;
            this.gbSelectGroup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSelectGroup.ForeColor = System.Drawing.Color.White;
            this.gbSelectGroup.Location = new System.Drawing.Point(20, 54);
            this.gbSelectGroup.Name = "gbSelectGroup";
            this.gbSelectGroup.Size = new System.Drawing.Size(860, 596);
            this.gbSelectGroup.TabIndex = 6;
            this.gbSelectGroup.Text = "Group Information";
            // 
            // txtSearch
            // 
            this.txtSearch.AutoRoundedCorners = true;
            this.txtSearch.BorderColor = System.Drawing.Color.Gray;
            this.txtSearch.BorderRadius = 17;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.txtSearch.Location = new System.Drawing.Point(362, 61);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(268, 36);
            this.txtSearch.TabIndex = 230;
            this.txtSearch.Visible = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // cbGroupNames
            // 
            this.cbGroupNames.BackColor = System.Drawing.Color.Transparent;
            this.cbGroupNames.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.cbGroupNames.BorderRadius = 17;
            this.cbGroupNames.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGroupNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGroupNames.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.cbGroupNames.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.cbGroupNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGroupNames.ForeColor = System.Drawing.Color.Black;
            this.cbGroupNames.ItemHeight = 30;
            this.cbGroupNames.Location = new System.Drawing.Point(362, 61);
            this.cbGroupNames.Name = "cbGroupNames";
            this.cbGroupNames.Size = new System.Drawing.Size(211, 36);
            this.cbGroupNames.TabIndex = 236;
            this.cbGroupNames.Visible = false;
            this.cbGroupNames.SelectedIndexChanged += new System.EventHandler(this.cbGroupNames_SelectedIndexChanged);
            // 
            // cbMeetingDays
            // 
            this.cbMeetingDays.BackColor = System.Drawing.Color.Transparent;
            this.cbMeetingDays.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.cbMeetingDays.BorderRadius = 17;
            this.cbMeetingDays.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMeetingDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMeetingDays.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.cbMeetingDays.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.cbMeetingDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMeetingDays.ForeColor = System.Drawing.Color.Black;
            this.cbMeetingDays.ItemHeight = 30;
            this.cbMeetingDays.Items.AddRange(new object[] {
            "All",
            "Daily",
            "STT",
            "MW"});
            this.cbMeetingDays.Location = new System.Drawing.Point(362, 61);
            this.cbMeetingDays.Name = "cbMeetingDays";
            this.cbMeetingDays.Size = new System.Drawing.Size(211, 36);
            this.cbMeetingDays.StartIndex = 0;
            this.cbMeetingDays.TabIndex = 235;
            this.cbMeetingDays.Visible = false;
            this.cbMeetingDays.SelectedIndexChanged += new System.EventHandler(this.cbMeetingDays_SelectedIndexChanged);
            // 
            // cbSubjectNames
            // 
            this.cbSubjectNames.BackColor = System.Drawing.Color.Transparent;
            this.cbSubjectNames.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.cbSubjectNames.BorderRadius = 17;
            this.cbSubjectNames.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSubjectNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubjectNames.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.cbSubjectNames.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.cbSubjectNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSubjectNames.ForeColor = System.Drawing.Color.Black;
            this.cbSubjectNames.ItemHeight = 30;
            this.cbSubjectNames.Location = new System.Drawing.Point(362, 61);
            this.cbSubjectNames.Name = "cbSubjectNames";
            this.cbSubjectNames.Size = new System.Drawing.Size(211, 36);
            this.cbSubjectNames.TabIndex = 234;
            this.cbSubjectNames.Visible = false;
            this.cbSubjectNames.SelectedIndexChanged += new System.EventHandler(this.cbSubjectNames_SelectedIndexChanged);
            // 
            // cbFilter
            // 
            this.cbFilter.BackColor = System.Drawing.Color.Transparent;
            this.cbFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.cbFilter.BorderRadius = 17;
            this.cbFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.cbFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.cbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.cbFilter.ForeColor = System.Drawing.Color.Black;
            this.cbFilter.ItemHeight = 30;
            this.cbFilter.Items.AddRange(new object[] {
            "None",
            "Group ID",
            "Group Name",
            "Class Name",
            "Teacher Name",
            "Subject Name",
            "Meeting Days"});
            this.cbFilter.Location = new System.Drawing.Point(125, 64);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(218, 36);
            this.cbFilter.StartIndex = 0;
            this.cbFilter.TabIndex = 233;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 229;
            this.label1.Text = "Filter By:";
            // 
            // dgvGroupsList
            // 
            this.dgvGroupsList.AllowUserToAddRows = false;
            this.dgvGroupsList.AllowUserToDeleteRows = false;
            this.dgvGroupsList.AllowUserToOrderColumns = true;
            this.dgvGroupsList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            this.dgvGroupsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGroupsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgvGroupsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            this.dgvGroupsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGroupsList.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGroupsList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGroupsList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvGroupsList.GridColor = System.Drawing.Color.White;
            this.dgvGroupsList.Location = new System.Drawing.Point(20, 113);
            this.dgvGroupsList.Name = "dgvGroupsList";
            this.dgvGroupsList.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGroupsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvGroupsList.RowHeadersVisible = false;
            this.dgvGroupsList.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            this.dgvGroupsList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvGroupsList.RowTemplate.Height = 33;
            this.dgvGroupsList.ShowCellToolTips = false;
            this.dgvGroupsList.Size = new System.Drawing.Size(822, 411);
            this.dgvGroupsList.TabIndex = 213;
            this.dgvGroupsList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.dgvGroupsList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dgvGroupsList.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvGroupsList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvGroupsList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvGroupsList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvGroupsList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvGroupsList.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dgvGroupsList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dgvGroupsList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvGroupsList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvGroupsList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvGroupsList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvGroupsList.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvGroupsList.ThemeStyle.ReadOnly = true;
            this.dgvGroupsList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dgvGroupsList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvGroupsList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvGroupsList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvGroupsList.ThemeStyle.RowsStyle.Height = 33;
            this.dgvGroupsList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.dgvGroupsList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvGroupsList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGroupsList_CellClick);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(43)))), ((int)(((byte)(71)))));
            this.lblTitle.Location = new System.Drawing.Point(111, -9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(527, 59);
            this.lblTitle.TabIndex = 210;
            this.lblTitle.Text = "Assign Student To Group";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btclose
            // 
            this.btclose.AutoRoundedCorners = true;
            this.btclose.BorderRadius = 18;
            this.btclose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btclose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btclose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btclose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btclose.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btclose.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btclose.ForeColor = System.Drawing.Color.White;
            this.btclose.Location = new System.Drawing.Point(841, 767);
            this.btclose.Name = "btclose";
            this.btclose.Size = new System.Drawing.Size(112, 39);
            this.btclose.TabIndex = 212;
            this.btclose.Text = "Close";
            this.btclose.Click += new System.EventHandler(this.btclose_Click);
            // 
            // btsave
            // 
            this.btsave.AutoRoundedCorners = true;
            this.btsave.BorderRadius = 18;
            this.btsave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btsave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btsave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btsave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btsave.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btsave.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsave.ForeColor = System.Drawing.Color.White;
            this.btsave.Location = new System.Drawing.Point(724, 767);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(115, 39);
            this.btsave.TabIndex = 211;
            this.btsave.Text = "Save";
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // frmAssignStudentToGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(965, 807);
            this.Controls.Add(this.btclose);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.guna2TabControl1);
            this.Name = "frmAssignStudentToGroup";
            this.Text = "frmAssignStudentToGroup";
            this.Load += new System.EventHandler(this.frmAssignStudentToGroup_Load);
            this.guna2TabControl1.ResumeLayout(false);
            this.tbStudentInfo.ResumeLayout(false);
            this.tbGroupInfo.ResumeLayout(false);
            this.gbSelectGroup.ResumeLayout(false);
            this.gbSelectGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage tbStudentInfo;
        private System.Windows.Forms.TabPage tbGroupInfo;
        private System.Windows.Forms.Label lblTitle;
        private ctrlStudentIfoFILTER ctrlStudentIfoFILTER1;
        private Guna.UI2.WinForms.Guna2GroupBox gbSelectGroup;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cbGroupNames;
        private Guna.UI2.WinForms.Guna2ComboBox cbMeetingDays;
        private Guna.UI2.WinForms.Guna2ComboBox cbSubjectNames;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilter;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvGroupsList;
        private Guna.UI2.WinForms.Guna2Button btclose;
        private Guna.UI2.WinForms.Guna2Button btsave;
        private ctrlGroupCard ctrlGroupCard1;
    }
}