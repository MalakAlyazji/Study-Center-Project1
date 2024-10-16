using System;
using System.Data;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using StudyCenterbusiness;
namespace StudyCenterPresentation
{
    public partial class frmAssignStudentToGroup : Form
    {
        int? _SelectedStudentID = null;
        int? _StudentGroupID = null;
        int? _SelectedGroupID = null;
        clsStudentGroupBusiness _StudentGroup = null;
        public Action<int?, int?> StudentGroupIDAndPaymentIDBack;
        enum enMode { Add, Update }
        enMode _Mode = enMode.Add;
        public enum entity { StudentGroupID, StudentID, GroupID }
        DataTable _dtStudentGroup = new DataTable();
        public frmAssignStudentToGroup()
        {
            InitializeComponent();
            _Mode = enMode.Add;
        }
        public frmAssignStudentToGroup(int? Value, entity enType)
        {
            InitializeComponent();
            switch (enType)
            {
                case entity.StudentGroupID:
                    {
                        _StudentGroupID = Value;
                        _Mode = enMode.Update;
                        break;
                    }
                case entity.StudentID:
                    {
                        _Mode = enMode.Add;
                        _SelectedStudentID = Value;
                        break;
                    }
                case entity.GroupID:
                    {
                        _Mode = enMode.Add;
                        _SelectedGroupID = Value;
                        break;
                    }
                    _Mode = enMode.Update;
            }
        }
        void _RefreshGroupList()
        {
            if (_SelectedStudentID != null)
                _dtStudentGroup = clsStudentGroupBusiness.ListGroupStudentNotAssignedIn(_SelectedStudentID);
            dgvGroupsList.DataSource = _dtStudentGroup;
            if (dgvGroupsList.Rows.Count > 0)
            {
                dgvGroupsList.Columns[0].HeaderText = "Group ID";
                dgvGroupsList.Columns[0].Width = 110;

                dgvGroupsList.Columns[1].HeaderText = "Group Name";
                dgvGroupsList.Columns[1].Width = 150;

                dgvGroupsList.Columns[2].HeaderText = "Class Name";
                dgvGroupsList.Columns[2].Width = 200;

                dgvGroupsList.Columns[3].HeaderText = "Teacher Name";
                dgvGroupsList.Columns[3].Width = 250;

                dgvGroupsList.Columns[4].HeaderText = "Subject Name";
                dgvGroupsList.Columns[4].Width = 200;

                dgvGroupsList.Columns[5].HeaderText = "Grade Name";
                dgvGroupsList.Columns[5].Width = 170;

                dgvGroupsList.Columns[6].HeaderText = "Start Time";
                dgvGroupsList.Columns[6].Width = 120;

                dgvGroupsList.Columns[7].HeaderText = "End Time";
                dgvGroupsList.Columns[7].Width = 120;

                dgvGroupsList.Columns[8].HeaderText = "Meeting Days";
                dgvGroupsList.Columns[8].Width = 120;

                dgvGroupsList.Columns[9].HeaderText = "Students Count";
                dgvGroupsList.Columns[9].Width = 160;

                dgvGroupsList.Columns[10].HeaderText = "Fees";
                dgvGroupsList.Columns[10].Width = 100;

                dgvGroupsList.Columns[11].HeaderText = "Is Active";
                dgvGroupsList.Columns[11].Width = 80;
            }

        }
        void _GroupIDExists(int? GroupID)
        {
            if (!GroupID.HasValue)
            {
                _RefreshGroupList();
                gbSelectGroup.Visible = true;
                ctrlGroupCard1.Visible = false;
            }
            else
            {
                gbSelectGroup.Visible = false;
                ctrlGroupCard1.Visible = true;
                ctrlGroupCard1.Location = new System.Drawing.Point(25, 22);
                ctrlGroupCard1.Size = new System.Drawing.Size(862, 316);
                ctrlGroupCard1.LoadGroupInfoByGroupID(GroupID.Value);
            }
        }
        void _RefreshDefultValues()
        {
            _GroupIDExists(_SelectedGroupID);
            if (_Mode == enMode.Add)
            {
                lblTitle.Text = "Assign Student To Group";
                _StudentGroup = new clsStudentGroupBusiness();
                ctrlStudentIfoFILTER1.FilterEnabled = true;
                ctrlStudentIfoFILTER1.Focus();
            }
            else
            {
                lblTitle.Text = "Update Assigning Student To Group";
            }
            Text = lblTitle.Text;
        }
        private void ctrlStudentIfoFILTER1_OnStudentSelected(object sender, ctrlStudentIfoFILTER.SelectedStudentEventArgs e)
        {
            if (!e.StudentID.HasValue)
            {
                btsave.Enabled = false;
                _dtStudentGroup.Clear();
                return;
            }
            int? _GradeID = ctrlGroupCard1?.Group?.TeacherSubjectsInfo?.GradeSubjectInfo?.GradeID;
            if (_SelectedGroupID.HasValue && clsStudentGroupBusiness.GetGradeLevelIDByStudentID(e.StudentID) != _GradeID)
            {
                MessageBox.Show("The grade level of this student is different from the grade level " +
                                "of the group! Choose another one.", "Not Allowed",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);

                btsave.Enabled = false;
                ctrlStudentIfoFILTER1.Focus();
                return;
            }
            if (_SelectedGroupID.HasValue && clsStudentGroupBusiness.IsStudentGroupExistBy(e.StudentID, clsStudentGroupBusiness.enFindBy.Both, _SelectedGroupID))
            {
                MessageBox.Show("This student is Already enrolled in this group.",
                   "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlStudentIfoFILTER1.Reset();
                return;

            }
            _SelectedStudentID = e.StudentID.Value;
            btsave.Enabled = true;
            _RefreshGroupList();
        }
        void _FillSubjectNames()
        {
            cbSubjectNames.Items.Clear();
            cbSubjectNames.Items.Add("All");
            DataTable SubjectName = clsSubjectBusiness.GetSubjectNames();
            foreach (DataRow Row in SubjectName.Rows)
            {
                cbSubjectNames.Items.Add(Row["SubjectName"].ToString());
            }
        }
        void _FillGroupName()
        {

            cbSubjectNames.Items.Clear();
            cbSubjectNames.Items.Add("All");
            DataTable GroupName = clsGroupBusiness.GetGroupsNames();
            foreach (DataRow Row in GroupName.Rows)
            {
                cbGroupNames.Items.Add(Row["GroupName"].ToString());
            }
        }
        string _GetRealNames()
        {
            switch (cbFilter.SelectedItem)
            {
                case "Group ID":
                    return "GroupID";
                case "Group Name":
                    return "GroupName";
                case "Class Name":
                    return "ClassName";
                case "Teacher Name":
                    return "TeacherName";
                case "Subject Name":
                    return "SubjectName";
                case "Meeting Days":
                    return "MeetingDays";
                default:
                    return "None";
            }
        }
        private void txtSearch_TextChanged(object sender, System.EventArgs e)
        {
            if (_dtStudentGroup == null || dgvGroupsList.Rows.Count == 0)
            {
                _dtStudentGroup.DefaultView.RowFilter = "";
                return;
            }
            string ColumnName = _GetRealNames();
            if (string.IsNullOrEmpty(txtSearch.Text) || cbFilter.Text == "None")
            {
                _dtStudentGroup.DefaultView.RowFilter = "";
                return;
            }
            if (cbFilter.Text == "Group ID")
            {
                _dtStudentGroup.DefaultView.RowFilter = string.Format("[{0}] = {1}", ColumnName, txtSearch.Text.Trim());
            }
            else
            {
                _dtStudentGroup.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", ColumnName, txtSearch.Text.Trim());
            }
        }
        void _FilterComboBox(Guna2ComboBox cb, string Name)
        {
            if (_dtStudentGroup == null || _dtStudentGroup.Rows.Count == 0 || cb == null)
            {
                _dtStudentGroup.DefaultView.RowFilter = "";
                return;
            }
            if (cb.Text == "All")
            {
                _dtStudentGroup.DefaultView.RowFilter = "";
                return;
            }
            _dtStudentGroup.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", Name, cb.Text.Trim());
        }
        private void cbGroupNames_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            _FilterComboBox(cbGroupNames, "GroupName");
        }
        private void cbMeetingDays_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            _FilterComboBox(cbMeetingDays, "MeetingDays");
        }
        private void cbSubjectNames_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            _FilterComboBox(cbSubjectNames, "SubjectName");
        }
        void _FillToSave()
        {
            _StudentGroup.StudentID = _SelectedStudentID;
            if (_SelectedGroupID.HasValue)
                _StudentGroup.GroupID = _SelectedGroupID;
            else if (dgvGroupsList.Rows.Count > 0)
                _StudentGroup.GroupID = _SelectedGroupIDFromDGV();
            _StudentGroup.UserID = clsGlobal.LogInUser.UserID;
        }
        void _SaveStudentToGroup(string paymentMethod = null)
        {
            _FillToSave();
            if (paymentMethod == null)
            {
                paymentMethod = clsPaymentBusiness.FindPayment(_StudentGroup.PaymentID).PaymentMethods.ToString();
            }
            if (_StudentGroup.SaveStudentGroup(paymentMethod.ToString()))
            {
                _Mode = enMode.Update;
                Text = "Update Assigning Student To Group";
                lblTitle.Text = Text;
                StudentGroupIDAndPaymentIDBack?.Invoke(_StudentGroup.StudentGroupID, _StudentGroup.PaymentID);
                MessageBox.Show($"Student Saved Successfully with Student-Group ID :{_StudentGroup.StudentGroupID} and payment ID {_StudentGroup.PaymentID}", $"Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                clsShowMessage.OperationFelid("Saved");
            }
        }
        int? _SelectedGroupIDFromDGV()
        {
            return (int?)dgvGroupsList.CurrentRow.Cells["Group ID"].Value;
        }
        private void btsave_Click(object sender, System.EventArgs e)
        {
            if (dgvGroupsList.SelectedRows.Count <= 0)
            {
                MessageBox.Show("You have to select a Student!", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            decimal? fees = (decimal)dgvGroupsList.CurrentRow.Cells[10].Value;// clsGradeSubjectBusiness fees
            decimal? displayFees = ((decimal?)clsStudentGroupBusiness.GetGradeSubjectFeesByGroupID(_SelectedGroupID) ?? (fees));
            clsPaymentBusiness.enPaymentMethod paymentMethod = clsPaymentBusiness.enPaymentMethod.Cash;
            string message = $"The student with ID {_SelectedStudentID} has to pay {displayFees:C2}. Are you sure " +
                             $"you want to assign them to the group with ID {_SelectedGroupID ?? _SelectedGroupIDFromDGV()}?";

            if (_Mode == enMode.Add)
            {
                if (MessageBox.Show(message, "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    // Show payment method options
                    DialogResult paymentResult = MessageBox.Show("Select your payment method:\n\n" +
                        "Click OK for Cash or Cancel for Online.", "Payment Method",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    // Determine the payment method
                    paymentMethod =
                       paymentResult == DialogResult.OK ? clsPaymentBusiness.enPaymentMethod.Cash : clsPaymentBusiness.enPaymentMethod.Online;
                    MessageBox.Show($"You selected {paymentMethod} payment.");
                }
                else return;
                _SaveStudentToGroup(paymentMethod.ToString());
            }
            else
            {
                _SaveStudentToGroup();
            }
        }
        private void btclose_Click(object sender, System.EventArgs e)
        {
            Close();
        }
        private void cbFilter_SelectedIndexChanged(object sende, System.EventArgs e)
        {
            txtSearch.Visible = (cbFilter.Text != "None") && (cbFilter.Text != "Group Name") && (cbFilter.Text != "Subject Name") && (cbFilter.Text != "Meeting Days");
            cbGroupNames.Visible = (cbFilter.Text == "Group Name");
            cbSubjectNames.Visible = (cbFilter.Text == "Subject Name");
            cbMeetingDays.Visible = (cbFilter.Text == "Meeting Days");
            if (txtSearch.Visible)
            {
                txtSearch.Text = "";
                txtSearch.Focus();
            }
            if (cbGroupNames.Visible)
                cbGroupNames.SelectedIndex = 0;
            if (cbSubjectNames.Visible)
                cbSubjectNames.SelectedIndex = 0;
            if (cbMeetingDays.Visible)
                cbMeetingDays.SelectedIndex = 0;
        }
        void _LoadGroupInfoToUpdate()
        {
            if (_SelectedStudentID.HasValue)
            {
                ctrlStudentIfoFILTER1.LoadStudentInfoByStudentID(_SelectedStudentID);
                ctrlStudentIfoFILTER1.FilterEnabled = false;
                _StudentGroup = new clsStudentGroupBusiness();
                return;
            }
            _StudentGroup = clsStudentGroupBusiness.FindStudentGroupBy(_StudentGroupID, clsStudentGroupBusiness.enFindBy.StudentGroupID);
            if (_StudentGroup == null)
            {
                clsShowMessage.ShowMissingDataMessage("Student Group", _StudentGroupID);
                Close();
                return;
            }
            ctrlStudentIfoFILTER1.FilterEnabled = false;
            ctrlStudentIfoFILTER1.LoadStudentInfoByStudentID(_StudentGroup.StudentID);
            _GroupIDExists(_StudentGroup.GroupID);
        }
        private void frmAssignStudentToGroup_Load(object sender, System.EventArgs e)
        {
            _RefreshDefultValues();
            _FillGroupName();
            _FillSubjectNames();
            cbFilter.SelectedIndex = 0;
            if (_Mode == enMode.Update || _SelectedStudentID.HasValue)
            {
                _LoadGroupInfoToUpdate();
            }
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "Group ID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }
        private void dgvGroupsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Clear previous selections
                if (dgvGroupsList.SelectedRows.Count > 1)
                {
                    clsShowMessage.GeneralErrorMessage("Please select only one group at a time.");
                    return;
                }
                // If a valid single row is selected
                if (dgvGroupsList.SelectedRows.Count == 1)
                {
                    // Get the selected Group ID
                    _SelectedGroupID = (int?)dgvGroupsList.SelectedRows[0].Cells[0].Value;
                    // Confirm action
                    if (clsShowMessage.SelectConfirmation("Group", _SelectedGroupID) == DialogResult.OK)
                    {
                        clsShowMessage.OperationDoneSuccessfully("Selected");
                    }
                }
            }

        }
    }
}
