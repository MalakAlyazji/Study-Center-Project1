using System;
using System.Data;
using System.Windows.Forms;
using StudyCenterBuisness;

namespace StudyCenterPresentation.Users
{
    public partial class frmlistusers : Form
    {
        int? _SelectedUserID => (int?)dgvlist.CurrentRow.Cells["UserID"].Value;
        DataTable _dtUsers = new DataTable();
        clsuserbusiness _User;
        public frmlistusers()
        {
            InitializeComponent();
        }
        void _Refresh()
        {
            _dtUsers = clsuserbusiness.ListUsers();
            dgvlist.DataSource = _dtUsers;
            lbrecord.Text = dgvlist.Rows.Count.ToString();
            if (dgvlist.Rows.Count > 0)
            {
                dgvlist.Columns[0].HeaderText = "User ID";
                dgvlist.Columns[0].Width = 500;
                dgvlist.Columns[1].HeaderText = "Full Name";
                dgvlist.Columns[1].Width = 300;
                dgvlist.Columns[2].HeaderText = "Gender";
                dgvlist.Columns[2].Width = 300;
                dgvlist.Columns[3].HeaderText = "User Name";
                dgvlist.Columns[3].Width = 300;
                dgvlist.Columns[4].HeaderText = "Is Active";
                dgvlist.Columns[4].Width = 300;
            }
        }
        private void showUserDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowUserInfo frmShowUserInfo = new frmShowUserInfo(_SelectedUserID);
            frmShowUserInfo.ShowDialog();
            _Refresh();
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((clsGlobal.LogInUser.Permissions & (int)clsuserbusiness.enPermissions.UpdateUser) != (int)clsuserbusiness.enPermissions.UpdateUser)
            {
                MessageBox.Show("You do not have permission to edit this user.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmAddEditUser frm = new frmAddEditUser(_SelectedUserID);
            frm.ShowDialog();
            _Refresh();
        }
        private void frmlistusers_Load(object sender, EventArgs e)
        {
            _Refresh();
        }
    }
}
