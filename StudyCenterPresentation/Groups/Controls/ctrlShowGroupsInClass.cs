using System.Data;
using System.Windows.Forms;
using StudyCenterbusiness;

namespace StudyCenterPresentation
{
    public partial class ctrlShowGroupsInClass : UserControl
    {
        DataTable _dtGroups;
        int? _ClassID = null;
        public ctrlShowGroupsInClass()
        {
            InitializeComponent();
        }
        void _FillGroupsInClass()
        {
            gbGroupsInClass.Text = "Groups In Class:";
            dgvlist.DataSource = _dtGroups;
            lbrecord.Text = dgvlist.Rows.Count.ToString();
            if (dgvlist.Rows.Count > 0)
            {
                dgvlist.Columns[0].HeaderText = "Class ID";
                dgvlist.Columns[0].Width = 50;
                dgvlist.Columns[1].HeaderText = "Class Name";
                dgvlist.Columns[1].Width = 150;
                dgvlist.Columns[2].HeaderText = "Group ID";
                dgvlist.Columns[2].Width = 50;
                dgvlist.Columns[3].HeaderText = "Group NAme";
                dgvlist.Columns[3].Width = 100;
                dgvlist.Columns[4].HeaderText = "Teaher Name";
                dgvlist.Columns[4].Width = 150;
                dgvlist.Columns[5].HeaderText = "Subject Name";
                dgvlist.Columns[5].Width = 150;
                dgvlist.Columns[6].HeaderText = "Grade Level";
                dgvlist.Columns[6].Width = 50;
                dgvlist.Columns[7].HeaderText = "Student Count";
                dgvlist.Columns[7].Width = 50;
                dgvlist.Columns[8].HeaderText = "Start Time";
                dgvlist.Columns[8].Width = 150;
                dgvlist.Columns[9].HeaderText = "End Time";
                dgvlist.Columns[9].Width = 150;
                dgvlist.Columns[10].HeaderText = "Is Active";
                dgvlist.Columns[10].Width = 50;
            }
        }
        int? _SelecteGroupID()
        {
            return (int?)dgvlist.CurrentRow.Cells["Group ID"].Value;
        }
        public void LoadGroupsInClass(int? ClassID)
        {
            if (!ClassID.HasValue)
            {
                clsShowMessage.IdNotFound("Class", ClassID);
                return;
            }
            _ClassID = ClassID.Value;
            _dtGroups = clsGroupBusiness.ListGroupsByClassID(_ClassID);
            if (_dtGroups == null)
            {
                clsShowMessage.OperationFelid("Found");
                return;
            }
            _FillGroupsInClass();
        }
        private void showGroupDetailsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmshowGroupInfo frmshowGroupInfo = new frmshowGroupInfo(_SelecteGroupID());
            frmshowGroupInfo.ShowDialog();
            LoadGroupsInClass(_ClassID);
        }
        private void editToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmAddGroup frmAddGroup = new frmAddGroup(_SelecteGroupID());
            frmAddGroup.ShowDialog();
            LoadGroupsInClass(_ClassID);
        }
        private void showStudentToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmShowStudentGroup frm = new frmShowStudentGroup(_SelecteGroupID());
            frm.ShowDialog();
            LoadGroupsInClass(_ClassID);
        }
        private void addStudentToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmAssignStudentToGroup frmAssignStudent = new frmAssignStudentToGroup(_SelecteGroupID(), frmAssignStudentToGroup.entity.GroupID);
            frmAssignStudent.ShowDialog();
            LoadGroupsInClass(_ClassID);
        }
    }
}
