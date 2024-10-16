using System.Data;
using System.Windows.Forms;
using StudyCenterbusiness;

namespace StudyCenterPresentation
{
    public partial class ctrlTeahersInClass : UserControl
    {
        int? _ClassID;
        DataTable _dtTeacher;
        public int? ClassID => _ClassID;
        int? _SelectedGroupID()
        {
            return (int?)dgvlist.CurrentRow.Cells["Group ID"].Value;
        }
        int? _SelectedTeacherID()
        {
            return (int?)dgvlist.CurrentRow.Cells["Teacher ID"].Value;
        }
        public ctrlTeahersInClass()
        {
            InitializeComponent();
        }
        void _FillTeachersInClass()
        {
            gbTeacherSubjectBy.Text = "Teachers Who Teach In Class:";
            dgvlist.DataSource = _dtTeacher;
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
            _ClassID = ClassID.Value;
            _dtTeacher = clsTeacherSubjectsBusiness.ListTeacherSubjectsBy(clsTeacherSubjectsBusiness.enFindBy.ClassID, _ClassID);
            if (_dtTeacher == null)
            {
                clsShowMessage.OperationFelid("Found");
                return;
            }
            _FillTeachersInClass();
        }
        private void showTeacherDetailsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmShowTeacherInfo frmShowTeacherInfo = new frmShowTeacherInfo(_SelectedTeacherID());
            frmShowTeacherInfo.ShowDialog();
        }
        private void showClassDetailsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmShowClassCard frmShowClassCard = new frmShowClassCard(_ClassID);
            frmShowClassCard.ShowDialog();
        }
        private void showGroupsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmshowGroupInfo frmshowGroupInfo = new frmshowGroupInfo(_SelectedGroupID());
            frmshowGroupInfo.ShowDialog();
        }
    }
}
