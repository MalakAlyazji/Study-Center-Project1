using System;
using System.Data;
using System.Windows.Forms;
using StudyCenterbusiness;

namespace StudyCenterPresentation
{
    public partial class frmAddGroup : Form
    {
        DataTable _dtMeetingDays;
        public Action<int?> GroupIDBack;
        private enum _enMode { AddNew, Update };
        private _enMode _Mode = _enMode.AddNew;
        int? _GroupID;
        clsGroupBusiness _Group;
        int? _SelectedClassID = null;
        int? _SelectedTeacherID = null;
        int? _SelectedTeacherSubjectID = null;
        int? _SelectedGradeSubjectID = null;
        int? _SelectedGradeID = null;
        int? _SelectedMeetingID = null;
        public frmAddGroup()
        {
            InitializeComponent();
            _Mode = _enMode.AddNew;
        }
        public frmAddGroup(int? GroupID)
        {
            InitializeComponent();
            _GroupID = GroupID;
            _Mode = _enMode.Update;
        }
        private void CheckIfAllTabsCompleted()
        {
            if (_SelectedClassID.HasValue && _SelectedTeacherID.HasValue && _SelectedTeacherSubjectID.HasValue
                && _SelectedMeetingID.HasValue)
            {
                btsave.Enabled = true;
            }
            else
            {
                btsave.Enabled = false;
            }
        }
        private void btclose_Click(object sender, EventArgs e)
        {
            Close();
        }
        void _ResetClear()
        {
            ctrlClassCardWithFilter2.Reset();
            ctrlTeacherCardWithFilter1.Reset();
        }
        void _ResetDefultValues()
        {
            if (_Mode == _enMode.AddNew)
            {
                ctrlClassCardWithFilter2.FilterEnabled = true;
                ctrlTeacherCardWithFilter1.FilterEnabled = true;
                cbMeetingDays.SelectedIndex = 0;
                lblTitle.Text = "Add New Group";
                _Group = new clsGroupBusiness();
                ctrlClassCardWithFilter2.FilterFocus();
                ctrlGroupCard1.lblUserName.Text = "Malak";
                ctrlGroupCard1.lblCountStudent.Text = "0";
                if (!_SelectedClassID.HasValue)
                {
                    _ResetClear();
                }
            }
            else
            {
                ctrlClassCardWithFilter2.FilterEnabled = false;
                ctrlTeacherCardWithFilter1.FilterEnabled = false;
                lblTitle.Text = "Update Group";
            }
            Text = lblTitle.Text;
        }
        void _ShowGroupCard()
        {
            ctrlGroupCard1.LoadGroupInfoByGroupID(_Group.GroupID);
        }
        void _SaveGroup()
        {
            _FillGroupInfoToSave();
            if (_Group.SaveGroup())
            {
                _Mode = _enMode.Update;
                Text = "Update Group";
                lblTitle.Text = "Update Group";
                GroupIDBack?.Invoke(_Group.GroupID);
                _ShowGroupCard();
                clsShowMessage.OperationDoneSuccessfully("Group");

            }
            else
            {
                clsShowMessage.GeneralErrorMessage("Error Addd New Group");
            }
        }
        private void ctrlClassCardWithFilter2_OnClassSelected(object sender, ctrlClassCardWithFilter.SelectedClassEventArgs e)
        {
            _SelectedClassID = e.ClassID;
            if (!e.ClassID.HasValue)
            {
                dgvlist.DataSource = null;
                ctrlClassCardWithFilter2.Reset();
                return;
            }
            if (_SelectedTeacherID.HasValue)
            {
                _RefreshMeetingList();

            }
            CheckIfAllTabsCompleted();
        }
        void _FillMeetingInfoToUpdate()
        {
            _dtMeetingDays = clsMeetingBusiness.ListMeetingBySeletedMeetingID(_Group.MeetingID);
            dgvlist.DataSource = _dtMeetingDays;
        }
        void _FillGroupInfoToSave()
        {
            _Group.ClassID = _SelectedClassID;
            _Group.GradeSubjectID = _SelectedGradeSubjectID;
            _Group.GradeLevelID = _SelectedGradeID;
            _Group.MeetingID = _SelectedMeetingID;
            _Group.TeacherSubjectID = _SelectedTeacherSubjectID;
            _Group.UserID = clsGlobal.LogInUser.UserID;
        }
        void _FillGroupInfoToUpdate()
        {
            ctrlClassCardWithFilter2.LoadClassInfoByClassID(_Group.ClassID);
            ctrlTeacherCardWithFilter1.LoadTeacherByTeacherID(_Group.TeacherSubjectsInfo.TeacherID);
            ctrlTeacherSubjectsByTeacherID1.LoadTeacherSubjectBySelectedTeacherSubjectID(_Group.TeacherSubjectID);
            _FillMeetingInfoToUpdate();
            ctrlGroupCard1.LoadGroupInfoByGroupID(_Group.GroupID);
            btsave.Enabled = true;
        }
        void _RefreshMeetingList()
        {
            _dtMeetingDays = clsMeetingBusiness.ListMeetingsByCLassAndTeacher(_SelectedClassID, _SelectedTeacherID);
            dgvlist.DataSource = _dtMeetingDays;
            if (dgvlist.Rows.Count > 0)
            {
                dgvlist.Columns[0].HeaderText = "Meeting ID";
                dgvlist.Columns[0].Width = 50;
                dgvlist.Columns[1].HeaderText = "Start Time";
                dgvlist.Columns[1].Width = 70;
                dgvlist.Columns[2].HeaderText = "End Time";
                dgvlist.Columns[2].Width = 70;
                dgvlist.Columns[3].HeaderText = "Meeting Days";
                dgvlist.Columns[3].Width = 100;

            }
        }
        private void cbMeetingDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_dtMeetingDays == null || _dtMeetingDays.Rows.Count == 0)
            {
                return;
            }
            if (cbMeetingDays.Text == "All")
            {
                _dtMeetingDays.DefaultView.RowFilter = "";
                return;
            }
            _dtMeetingDays.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", "MeetingDays", cbMeetingDays.Text);
        }
        private void btnaddMeeting_Click(object sender, EventArgs e)
        {
            frmAddNewMeeting frmAddNewMeeting = new frmAddNewMeeting();
            frmAddNewMeeting.ShowDialog();
            _RefreshMeetingList();
        }
        private void dgvlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvlist.Rows[e.RowIndex];
                _SelectedMeetingID = (int?)row.Cells[0].Value;
                if (_SelectedMeetingID.HasValue)
                {
                    clsShowMessage.SelectConfirmation("Meeting", _SelectedMeetingID);
                }
                lblsSelectMeeting.Visible = false;
                CheckIfAllTabsCompleted();
            }
        }
        void _LoadGroupToUpdate()
        {
            _Group = clsGroupBusiness.FindGroup(_GroupID);
            if (_Group == null)
            {
                clsShowMessage.OperationFelid("Group Could'nt be found");
                Close();
                return;
            }
            _FillGroupInfoToUpdate();
        }
        private void frmAddGroup_Load(object sender, EventArgs e)
        {
            cbfilter.SelectedIndex = 0;
            lblsSelectMeeting.Visible = true;
            _ResetDefultValues();
            if (_Mode == _enMode.Update)
            {
                _LoadGroupToUpdate();
            }
        }
        private void btsave_Click(object sender, EventArgs e)
        {
            if (dgvlist.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please select a meeting time.", "Select Meeting Time",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (dgvlist.Rows.Count == 0)
            {
                MessageBox.Show("This teacher does not have any available meeting times.",
                    "No Meeting Times", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (ctrlTeacherSubjectsByTeacherID1.dgvlist.Rows.Count == 0)
            {
                MessageBox.Show("This teacher is not assigned to teach any subjects.",
                   "No Subjects Assigned", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
                if (ctrlTeacherSubjectsByTeacherID1.dgvlist.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("No Choosen Subject, Please Select One.",
                       "No Subjects Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
            }
            _SaveGroup();
        }
        private void ctrlListTeacherSubjestByTeacherID1_RowClicked(object sender, int SelectedTeacherSubjectID, int SelectedGradeSubjectID, int SelectedGradeID)
        {

            lblsSelectSubject.Visible = false;
            _SelectedTeacherSubjectID = SelectedTeacherSubjectID;
            _SelectedGradeSubjectID = SelectedGradeSubjectID;
            _SelectedGradeID = SelectedGradeID;
            clsShowMessage.SelectConfirmation("Teacher-Subject", _SelectedTeacherSubjectID);
            CheckIfAllTabsCompleted();
        }
        private void ctrlTeacherCardWithFilter1_OnTeacherSelected(object sender, ctrlTeacherCardWithFilter.TeacherSelectedEventArgs e)
        {
            _SelectedTeacherID = e.TeacherID;
            if (!e.TeacherID.HasValue)
            {
                dgvlist.DataSource = null;
                ctrlTeacherCardWithFilter1.Reset();
            }
            if (_SelectedClassID.HasValue)
            {
                _RefreshMeetingList();
            }
            ctrlTeacherSubjectsByTeacherID1.LoadTeacherSubjectByTeacherID(_SelectedTeacherID);
            CheckIfAllTabsCompleted();
        }
        private void dgvlist_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvlist.SelectedRows.Count > 1)
            {
                // If more than one row is selected, clear the selection
                dgvlist.ClearSelection();
                MessageBox.Show("Please select only one meeting time.", "Select One Meeting Time Only",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
        }
    }
}
