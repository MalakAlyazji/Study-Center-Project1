using System;
using System.Data;
using System.Windows.Forms;
using StudyCenterbusiness;

namespace StudyCenterPresentation
{
    public partial class frmAssignTeacherToSubject : Form
    {
        enum enMode { Add, Update }
        enMode _Mode = enMode.Add;
        int? _SelectedTeacherID = null;
        int? _TeacherSubjectID = null;
        DataTable _dtListSubjectByTeacherID = null;
        clsTeacherSubjectsBusiness _TeacherSubject = null;
        int? _SelectedGradeSubjectID = null;
        string _SelectedSubjectName()
        {
            return (string)dgvList.CurrentRow.Cells["SubjectName"].Value;
        }
        string _SelectedGradeName()
        {
            return (string)dgvList.CurrentRow.Cells["GradeLevelName"].Value;
        }
        int? _SelectedSubjectID()
        {
            return clsSubjectBusiness.GetSubjecIDByName(_SelectedSubjectName());
        }
        public enum entity { TeacherID, TeacherSubjectID }
        public Action<int?> TeacherSubjectIDBack;
        public frmAssignTeacherToSubject()
        {
            InitializeComponent();
        }
        public frmAssignTeacherToSubject(int? value, entity entityType)
        {
            InitializeComponent();
            if (entityType == entity.TeacherSubjectID)
            {
                _TeacherSubjectID = value;
                _Mode = enMode.Add;
            }
            else
            {
                _SelectedTeacherID = value;
                _Mode = enMode.Update;
            }
        }
        void _RefreshListSubjects()
        {
            if (_SelectedTeacherID == null)
                _dtListSubjectByTeacherID.Clear();
            else
                _dtListSubjectByTeacherID = clsGradeSubjectBusiness.ListGradeSubjectNotAssignedToTeacherID(_SelectedTeacherID);
            dgvList.DataSource = _dtListSubjectByTeacherID;

            if (dgvList.Rows.Count > 0)
            {
                dgvList.Columns[0].HeaderText = "Subject Grade-Level ID";
                dgvList.Columns[0].Width = 120;

                dgvList.Columns[1].HeaderText = "Subject Name";
                dgvList.Columns[1].Width = 120;

                dgvList.Columns[2].HeaderText = "Grade Name";
                dgvList.Columns[2].Width = 120;

                dgvList.Columns[3].HeaderText = "Titles";
                dgvList.Columns[3].Width = 210;
            }
        }
        private void ctrlTeacherCardWithFilter1_OnTeacherSelected(object sender, ctrlTeacherCardWithFilter.TeacherSelectedEventArgs e)
        {
            if (e.TeacherID.HasValue)
            {
                _SelectedTeacherID = e.TeacherID;
                tbSubjectInfo.Enabled = true;
            }

        }
        void _RefreshDefultValues()
        {
            _RefreshListSubjects();
            if (_Mode == enMode.Add)
            {
                lblTitle.Text = "Add New Teacher Subject";
                _TeacherSubject = new clsTeacherSubjectsBusiness();
                tbSubjectInfo.Enabled = false;
                ctrlTeacherCardWithFilter1.Focus();
            }
            else
            {
                lblTitle.Text = "Update Teacher Subject";
                tbSubjectInfo.Enabled = true;
            }
            Text = lblTitle.Text;
        }
        private void btclose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.Text == "None")
                _RefreshListSubjects();

            cbSubjects.Visible = (cbFilter.Text == "Subject");

            cbGrades.Visible = (cbFilter.Text == "Grade Level");

            if (cbSubjects.Visible)
                cbSubjects.SelectedIndex = 0;

            if (cbGrades.Visible)
                cbGrades.SelectedIndex = 0;
        }
        private void cbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_dtListSubjectByTeacherID == null || _dtListSubjectByTeacherID.Rows.Count == 0)
            {
                return;
            }
            if (cbSubjects.SelectedIndex == 0)
            {
                _dtListSubjectByTeacherID.DefaultView.RowFilter = "";
                return;
            }
            _dtListSubjectByTeacherID.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", "SubjectName", cbSubjects.SelectedItem);
        }
        private void cbGrades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_dtListSubjectByTeacherID == null || _dtListSubjectByTeacherID.Rows.Count == 0)
            {
                return;
            }
            if (cbGrades.SelectedIndex == 0)
            {
                _dtListSubjectByTeacherID.DefaultView.RowFilter = "";
                return;
            }
            _dtListSubjectByTeacherID.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", "GradeLevelName", cbGrades.SelectedItem);
        }
        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                if (e.RowIndex != null)
                {
                    _SelectedGradeSubjectID = (int?)dgvList.Rows[e.RowIndex].Cells[0].Value;
                    int? _SelectedSubjectID = clsGradeSubjectBusiness.FindGradeSubjectIDBy(_SelectedGradeSubjectID, clsGradeSubjectBusiness.enFindBy.GradeSubjectID).SubjectID;
                    if (clsShowMessage.SelectConfirmation("Subject", _SelectedSubjectID) == DialogResult.OK)
                    {
                        clsShowMessage.OperationDoneSuccessfully("Selected");
                    }
                }
            }
        }
        void _LoadToUpdate()
        {
            if (_SelectedTeacherID.HasValue)
            {
                ctrlTeacherCardWithFilter1.LoadTeacherByTeacherID(_SelectedTeacherID);
                _TeacherSubject = new clsTeacherSubjectsBusiness();
                return;
            }
            _TeacherSubject = clsTeacherSubjectsBusiness.FindTeacherSubjectsBy(_TeacherSubjectID, clsTeacherSubjectsBusiness.enFindBy.TeacherSubjectID);
            ctrlTeacherCardWithFilter1.FilterEnabled = false;
            if (_TeacherSubject == null)
            {
                clsShowMessage.ShowMissingDataMessage("Subject Teacher", _TeacherSubjectID);
                Close();
                return;
            }
            _RefreshListSubjects();
        }
        void _FillGradeNames()
        {
            cbGrades.Items.Clear();
            cbGrades.Items.Add("All");
            DataTable dt = clsGradeLevelBusiness.GetLevelsName();
            foreach (DataRow grade in dt.Rows)
            {
                cbGrades.Items.Add(grade["GradeLevelName"].ToString());
            }
            if (cbGrades.Items.Count > 0)
                cbGrades.SelectedIndex = 0;
        }
        void _FillSubjectNames()
        {
            cbSubjects.Items.Clear();
            cbSubjects.Items.Add("All");
            DataTable dt = clsSubjectBusiness.GetSubjectNames();
            foreach (DataRow subject in dt.Rows)
            {
                cbSubjects.Items.Add(subject["SubjectName"].ToString());
            }
            if (cbSubjects.Items.Count > 0)
                cbSubjects.SelectedIndex = 0;
        }
        private void frmAssignTeacherToSubject_Load(object sender, EventArgs e)
        {
            _RefreshDefultValues();
            _FillSubjectNames();
            _FillGradeNames();
            cbFilter.SelectedIndex = 0;
            if (_Mode == enMode.Update)
            {
                _LoadToUpdate();
            }
        }
        void _FillToSave()
        {
            _TeacherSubject.TeacherID = _SelectedTeacherID;
            _TeacherSubject.GradeLevelSubjectID = _SelectedGradeSubjectID;
        }
        void _SaveTeacherSubjectInfo()
        {
            _FillToSave();
            if (_TeacherSubject.SaveTeacherSubject())
            {
                Text = "Update Teacher-Subject Info";
                lblTitle.Text = Text;
                _Mode = enMode.Update;
                TeacherSubjectIDBack?.Invoke(_TeacherSubject?.TeacherSubjectID);
                clsShowMessage.OperationDoneSuccessfully("Saved");
            }
            else
            {
                clsShowMessage.OperationFelid("Saved");
            }
        }
        private void btsave_Click(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows.Count <= 0)
            {
                MessageBox.Show("You have to select a subject!", "Missing Data",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (MessageBox.Show($"Are you sure you want to assign the teacher with ID {_SelectedTeacherID}" +
               $" to the {_SelectedSubjectName().Trim()} subject for the {_SelectedGradeName().Trim()}?", "Confirm",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2) == DialogResult.No)
                return;
            if (clsTeacherSubjectsBusiness.IsTeacherSubjectExistBy(_SelectedTeacherID, clsTeacherSubjectsBusiness.enFindBy.Both, _SelectedSubjectID()))
            {
                MessageBox.Show("This teacher is currently teaching the specified subject.",
                        "Teacher Subject Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _SaveTeacherSubjectInfo();
        }
    }
}
