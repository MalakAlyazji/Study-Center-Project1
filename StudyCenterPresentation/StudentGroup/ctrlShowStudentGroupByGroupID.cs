using System.Data;
using System.Windows.Forms;
using StudyCenterbusiness;

namespace StudyCenterPresentation
{
    public partial class ctrlShowStudentGroupByGroupID : UserControl
    {
        public ctrlShowStudentGroupByGroupID()
        {
            InitializeComponent();
        }
        DataTable _dtstudentGroups;
        int? _SelectedGroupID = null;
        void _FillStudentsInGroup()
        {
            gbGroupStudents.Text = "Students Enrolled in Group:";
            dgvlist.DataSource = _dtstudentGroups;
            lbrecord.Text = dgvlist.Rows.Count.ToString();
            if (dgvlist.Rows.Count > 0)
            {
                dgvlist.Columns[0].HeaderText = "Student-Group ID";
                dgvlist.Columns[0].Width = 100;
                dgvlist.Columns[1].HeaderText = "Student ID";
                dgvlist.Columns[1].Width = 100;
                dgvlist.Columns[2].HeaderText = "Student Name";
                dgvlist.Columns[2].Width = 150;
                dgvlist.Columns[3].HeaderText = "Gender";
                dgvlist.Columns[3].Width = 100;
                dgvlist.Columns[4].HeaderText = "Date Of Birth";
                dgvlist.Columns[4].Width = 150;
                dgvlist.Columns[5].HeaderText = "Age";
                dgvlist.Columns[5].Width = 150;
                dgvlist.Columns[6].HeaderText = "Grade Level";
                dgvlist.Columns[6].Width = 100;
                dgvlist.Columns[6].HeaderText = "Group ID";
                dgvlist.Columns[6].Width = 100;
                dgvlist.Columns[6].HeaderText = "Group Name";
                dgvlist.Columns[6].Width = 100;
            }
        }
        public void LoadStudentInGroup(int? GroupID)
        {
            if (!GroupID.HasValue)
            {
                clsShowMessage.IdNotFound("Group", GroupID);
                return;
            }
            _SelectedGroupID = GroupID.Value;
            _dtstudentGroups = clsStudentGroupBusiness.ListStudentGroupByGroupID(_SelectedGroupID);
            if (_dtstudentGroups == null)
            {
                clsShowMessage.OperationFelid("Found");
                return;
            }
            _FillStudentsInGroup();
        }
        private void showStudentDetailsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmShowStudentInfo frmShowStudentInfo = new frmShowStudentInfo((int?)dgvlist.CurrentRow.Cells["StudentID"].Value);
            frmShowStudentInfo.ShowDialog();
        }
        private void editToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmAssignStudentToGroup frmAssignStudentToGroup = new frmAssignStudentToGroup((int?)dgvlist.CurrentRow.Cells["StudentGroupID"].Value, frmAssignStudentToGroup.entity.StudentGroupID);
            frmAssignStudentToGroup.ShowDialog();
        }
    }
}
