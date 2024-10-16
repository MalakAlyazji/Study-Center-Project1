using System.Windows.Forms;
namespace StudyCenterPresentation
{
    public partial class frmShowStudentGroup : Form
    {
        int? _GroupID = null;
        public frmShowStudentGroup(int? GroupID)
        {
            InitializeComponent();
            _GroupID = GroupID;
            ctrlShowStudentGroupByGroupID1.LoadStudentInGroup(GroupID);
        }
        private void btnAddStudent_Click(object sender, System.EventArgs e)
        {
            frmAssignStudentToGroup frm = new frmAssignStudentToGroup(_GroupID, frmAssignStudentToGroup.entity.GroupID);
            frm.ShowDialog();
            ctrlShowStudentGroupByGroupID1.LoadStudentInGroup(_GroupID);
        }
    }
}
