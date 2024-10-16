using System;
using System.Data;
using System.Windows.Forms;
using StudyCenterbusiness;

namespace StudyCenterPresentation
{
    public partial class ctrlTeacherSubjectsByTeacherID : UserControl
    {
        DataTable _dtTeacherSubjects;
        int? _TeacherID = null;
        public delegate void RowClickedEventHandler(object sender, int SelectedTeacherSubjectID, int SelectedGradeSubjectID, int SelectedGradeID);
        public event RowClickedEventHandler RowClicked;
        public int? TeacherID => _TeacherID;
        public int? SelectedTeacherSubjectID = null;
        public int? SelectedGradeSubjectID = null;
        public int? SelectedGradeID = null;
        int? _SelectedClassID = null;
        int? _SelectedSubjectID = null;
        public void LoadTeacherSubjectBySelectedSubjectID(int? SelectedSubjectID)
        {
            if (!SelectedSubjectID.HasValue)
            {
                clsShowMessage.IdNotFound("Subject", SelectedSubjectID);
                return;
            }
            _SelectedSubjectID = SelectedSubjectID.Value;
            _dtTeacherSubjects = clsTeacherSubjectsBusiness.ListTeacherSubjectsBy(clsTeacherSubjectsBusiness.enFindBy.SubjectID, _SelectedSubjectID);
            if (_dtTeacherSubjects == null)
            {
                clsShowMessage.GeneralErrorMessage("Could'nt Load Teacher by this Subject ID !");
                return;
            }
            _FillTeacherSubjectBySubjectID();
        }
        void _FillTeacherSubjectBySubjectID()
        {
            dgvlist.DataSource = _dtTeacherSubjects;
            lbrecord.Text = dgvlist.Rows.Count.ToString();
            if (dgvlist.Rows.Count > 0)
            {
                dgvlist.Columns[0].HeaderText = "Teacher ID";
                dgvlist.Columns[0].Width = 50;
                dgvlist.Columns[1].HeaderText = "Teacher Name";
                dgvlist.Columns[1].Width = 130;
                dgvlist.Columns[1].HeaderText = "Class ID";
                dgvlist.Columns[1].Width = 50;
                dgvlist.Columns[1].HeaderText = "Group ID";
                dgvlist.Columns[1].Width = 50;
                dgvlist.Columns[3].HeaderText = "Group Name";
                dgvlist.Columns[3].Width = 120;
                dgvlist.Columns[5].HeaderText = "Subject Name";
                dgvlist.Columns[5].Width = 120;
                dgvlist.Columns[6].HeaderText = "Grade Level";
                dgvlist.Columns[6].Width = 120;
            }
        }
        void _FillTeachersInClass()
        {
            gbTeacherSubjectBy.Text = "Subject Taught in class:";
            dgvlist.DataSource = _dtTeacherSubjects;
            lbrecord.Text = dgvlist.Rows.Count.ToString();
            if (dgvlist.Rows.Count > 0)
            {
                dgvlist.Columns[0].HeaderText = "Teacher ID";
                dgvlist.Columns[0].Width = 100;
                dgvlist.Columns[1].HeaderText = "Teacher Name";
                dgvlist.Columns[1].Width = 100;
                dgvlist.Columns[2].HeaderText = "Class ID";
                dgvlist.Columns[2].Width = 100;
                dgvlist.Columns[3].HeaderText = "Group ID";
                dgvlist.Columns[3].Width = 100;
                dgvlist.Columns[4].HeaderText = "Group Name";
                dgvlist.Columns[4].Width = 150;
                dgvlist.Columns[5].HeaderText = "Subject Name";
                dgvlist.Columns[5].Width = 150;
                dgvlist.Columns[6].HeaderText = "Grade Level Name";
                dgvlist.Columns[6].Width = 150;
            }
        }
        public void LoadTeacherInClass(int? ClassID)
        {
            if (!ClassID.HasValue)
            {
                clsShowMessage.IdNotFound("Class", ClassID);
                return;
            }
            _SelectedClassID = ClassID.Value;
            _dtTeacherSubjects = clsTeacherSubjectsBusiness.ListTeacherSubjectsBy(clsTeacherSubjectsBusiness.enFindBy.ClassID, ClassID);
            if (_dtTeacherSubjects == null)
            {
                clsShowMessage.OperationFelid("Found");
                return;
            }
            _FillTeachersInClass();
        }
        void _FillTeacherSubjectByTeacherID()
        {
            dgvlist.DataSource = _dtTeacherSubjects;
            lbrecord.Text = dgvlist.Rows.Count.ToString();
            if (dgvlist.Rows.Count > 0)
            {
                dgvlist.Columns[0].HeaderText = "Teacher-Subject ID";
                dgvlist.Columns[0].Width = 50;
                dgvlist.Columns[1].HeaderText = "Teacher ID";
                dgvlist.Columns[1].Width = 50;
                dgvlist.Columns[2].HeaderText = "Grade Subject ID";
                dgvlist.Columns[2].Width = 50;
                dgvlist.Columns[3].HeaderText = "Grade Level ID";
                dgvlist.Columns[3].Width = 50;
                dgvlist.Columns[4].HeaderText = "Subject Name";
                dgvlist.Columns[4].Width = 100;
                dgvlist.Columns[5].HeaderText = "Title";
                dgvlist.Columns[5].Width = 100;
            }
        }
        void _FillTeacherSubjectByTeacherSubjectID()
        {
            dgvlist.DataSource = _dtTeacherSubjects;
            lbrecord.Text = dgvlist.Rows.Count.ToString();
            if (dgvlist.Rows.Count > 0)
            {
                dgvlist.Columns[0].HeaderText = "Teacher-Subject ID";
                dgvlist.Columns[0].Width = 50;
                dgvlist.Columns[1].HeaderText = "Teacher Name";
                dgvlist.Columns[1].Width = 70;
                dgvlist.Columns[2].HeaderText = "Teacher ID";
                dgvlist.Columns[2].Width = 50;
                dgvlist.Columns[3].HeaderText = "Grade Subject ID";
                dgvlist.Columns[3].Width = 50;
                dgvlist.Columns[4].HeaderText = "Group Name";
                dgvlist.Columns[4].Width = 70;
                dgvlist.Columns[5].HeaderText = "Subject Name";
                dgvlist.Columns[5].Width = 100;
                dgvlist.Columns[6].HeaderText = "Grade Level";
                dgvlist.Columns[6].Width = 100;
            }
        }
        public void LoadTeacherSubjectByTeacherID(int? TeacherID)
        {
            if (!TeacherID.HasValue)
            {
                clsShowMessage.IdNotFound("Teacher", TeacherID);
                return;
            }
            _TeacherID = TeacherID.Value;
            _dtTeacherSubjects = clsTeacherSubjectsBusiness.ListTeacherSubjectsBy(clsTeacherSubjectsBusiness.enFindBy.TeacherID, _TeacherID);
            if (_dtTeacherSubjects == null)
            {
                clsShowMessage.GeneralErrorMessage("Could'nt Load Teacher-Subject !");
                return;
            }
            _FillTeacherSubjectByTeacherID();
        }
        public void LoadTeacherSubjectBySelectedTeacherSubjectID(int? SelectedTeacherSubjectID)
        {
            if (!SelectedTeacherSubjectID.HasValue)
            {
                clsShowMessage.IdNotFound("Teacher-Subject", SelectedTeacherSubjectID);
                return;
            }
            SelectedTeacherSubjectID = SelectedTeacherSubjectID.Value;
            _dtTeacherSubjects = clsTeacherSubjectsBusiness.ListTeacherSubjectsBy(clsTeacherSubjectsBusiness.enFindBy.TeacherSubjectID, SelectedTeacherSubjectID);
            if (_dtTeacherSubjects == null)
            {
                clsShowMessage.GeneralErrorMessage("Could'nt Load Teacher-Subject !");
                return;
            }
            _FillTeacherSubjectByTeacherSubjectID();
        }
        private void dgvlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvlist.Rows[e.RowIndex];
                SelectedTeacherSubjectID = (int?)row.Cells[0].Value;
                SelectedGradeSubjectID = (int?)row.Cells[2].Value;
                SelectedGradeID = (int?)row.Cells[3].Value;
                if (RowClicked != null && SelectedTeacherSubjectID.HasValue && SelectedTeacherSubjectID.HasValue && SelectedGradeSubjectID.HasValue)
                {
                    RowClicked.Invoke(this, (int)SelectedTeacherSubjectID, (int)SelectedGradeSubjectID, (int)SelectedGradeID);
                }
            }
        }
        public ctrlTeacherSubjectsByTeacherID()
        {
            InitializeComponent();
        }
        private void dgvlist_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvlist.SelectedRows.Count > 1)
            {
                // If more than one row is selected, clear the selection
                dgvlist.ClearSelection();
                MessageBox.Show("You have to select only one subject !",
                  "only one subject", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void showSubjectDetilsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowTeacherInfo frmShowTeacherInfo = new frmShowTeacherInfo((int?)dgvlist.CurrentRow.Cells["TeacherID"].Value);
            frmShowTeacherInfo.ShowDialog();
        }

        //public void LoadTeacherSubjectAll()
        //{
        //    _dtTeacherSubjects = clsTeacherSubjectsBusiness.ListTeacherSubjectsBy(clsTeacherSubjectsBusiness.enFindBy.listAll);
        //    if (_dtTeacherSubjects == null)
        //    {
        //        clsShowMessage.GeneralErrorMessage("Could'nt Load Teacher-Subject !");
        //        return;
        //    }
        //    _FillTeacherSubjectByTeacherID();
        //}

    }
}
