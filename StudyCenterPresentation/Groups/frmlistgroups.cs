using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using StudyCenterbusiness;
namespace StudyCenterPresentation.Groups
{
    public partial class frmlistgroups : Form
    {
        DataTable _dtGroup;
        int _RowsPerPage = 0;
        int? _CountGroups = null;
        int _SelectedGroupID => (int)dgvlist.CurrentRow.Cells[0].Value;
        public frmlistgroups()
        {
            InitializeComponent();
            _RowsPerPage = short.TryParse(ConfigurationManager.AppSettings["RowsPerPage"], out short value) ? _RowsPerPage = value : _RowsPerPage = 8;
        }
        void _FillcbLevels()
        {
            cblevels.Items.Clear();
            cblevels.Items.Add("All");
            DataTable dt = clsGradeLevelBusiness.GetLevelsName();
            foreach (DataRow dr in dt.Rows)
            {
                cblevels.Items.Add(dr["GradeLevelName"]).ToString();
            }
        }
        void _FillCountGroups()
        {
            _CountGroups = clsGroupBusiness.CountGroups();
            short NumberOfPages = (short)Math.Ceiling((decimal)_CountGroups / _RowsPerPage);
            NUMPageNumber.Maximum = NumberOfPages;
            if (NumberOfPages > 0)
            {
                NUMPageNumber.Value = 1;
            }
        }
        void _Refresh()
        {
            cbfilter.SelectedIndex = 0;
            _dtGroup = clsGroupBusiness.ListGroupsByPages((short)NUMPageNumber.Value, _RowsPerPage);
            dgvlist.DataSource = _dtGroup;
            lbrecord.Text = _dtGroup.Rows.Count.ToString();
            if (_dtGroup.Rows.Count > 0)
            {
                dgvlist.Columns[0].HeaderText = "Group ID";
                dgvlist.Columns[0].Width = 50;
                dgvlist.Columns[1].HeaderText = "Group Name";
                dgvlist.Columns[1].Width = 100;
                dgvlist.Columns[2].HeaderText = "Class Name";
                dgvlist.Columns[2].Width = 100;
                dgvlist.Columns[3].HeaderText = "Teacher Name";
                dgvlist.Columns[3].Width = 100;
                dgvlist.Columns[4].HeaderText = "Subject Name";
                dgvlist.Columns[4].Width = 100;
                dgvlist.Columns[5].HeaderText = "Grade Level";
                dgvlist.Columns[5].Width = 100;
                dgvlist.Columns[6].HeaderText = "Start Time";
                dgvlist.Columns[6].Width = 100;
                dgvlist.Columns[7].HeaderText = "End Time";
                dgvlist.Columns[7].Width = 100;
            }
        }
        private void frmlistgroups_Load(object sender, EventArgs e)
        {
            _Refresh();
            _FillcbLevels();
            _FillCountGroups();
        }
        string _GetRealNames()
        {
            switch (cbfilter.SelectedItem)
            {
                case "Group ID":
                    return "GroupID";
                case "Group Name":
                    return "GroupName";
                case "Teacher Name":
                    return "FullName";
                case "Subject Name":
                    return "SubjectName";
                case "Grade Level":
                    return "GradeLevelName";
                default:
                    return null;
            }
        }
        private void txtfilterr_TextChanged(object sender, EventArgs e)
        {
            if (_dtGroup == null || dgvlist.Rows.Count == 0)
                return;
            string ColumnName = _GetRealNames();
            if (cbfilter.SelectedIndex == 0 || string.IsNullOrEmpty(txtfilterr.Text))
            {
                _dtGroup.DefaultView.RowFilter = null;
                lbrecord.Text = dgvlist.Rows.Count.ToString();
                return;
            }
            if (cbfilter.SelectedItem == "Group ID")
            {
                _dtGroup.DefaultView.RowFilter = string.Format("[{0}]={1}", ColumnName, txtfilterr.Text);
            }
            else
            {
                _dtGroup.DefaultView.RowFilter = string.Format("[{0}]like'{1}%'", ColumnName, txtfilterr.Text);
            }
        }
        private void cbfilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtfilterr.Visible = (cbfilter.SelectedIndex != 0 && cbfilter.SelectedIndex != 5);
            cblevels.Visible = cbfilter.SelectedIndex == 5;
            if (cblevels.Visible)
            {
                cblevels.SelectedIndex = 0;
            }
            if (txtfilterr.Visible)
            {
                txtfilterr.Text = "";
                txtfilterr.Focus();
            }
        }
        private void txtfilterr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbfilter.SelectedIndex == 0 || cbfilter.SelectedIndex == 5)
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }
        private void NUMPageNumber_ValueChanged(object sender, EventArgs e)
        {
            _Refresh();
            cbfilter.SelectedIndex = 0;
        }
        private void cblevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_dtGroup == null || _dtGroup.Rows.Count == 0)
            {
                return;
            }
            if (cblevels.SelectedIndex == 0)
            {
                _dtGroup.DefaultView.RowFilter = null;
                lbrecord.Text = dgvlist.Rows.Count.ToString();
                return;
            }
            _dtGroup.DefaultView.RowFilter = string.Format("[{0}]like'{1}%'", "GradeLevelName", cblevels.Text);
            lbrecord.Text = dgvlist.Rows.Count.ToString();
        }
        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            frmAddGroup frmAddGroup = new frmAddGroup();
            frmAddGroup.ShowDialog();
            _Refresh();
        }
        private void showGroupDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmshowGroupInfo frmshowGroupInfo = new frmshowGroupInfo(_SelectedGroupID);
            frmshowGroupInfo.ShowDialog();
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddGroup frmAddGroup = new frmAddGroup(_SelectedGroupID);
            frmAddGroup.ShowDialog();
            _Refresh();
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsShowMessage.DeleteConfiirmation(_SelectedGroupID.ToString()) == DialogResult.No)
            {
                return;
            }
            if (clsGroupBusiness.DeleteGroup(_SelectedGroupID))
            {
                clsShowMessage.DeletedSuccessfuly("Student");
            }
            _Refresh();
        }
        private void showStudentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowStudentGroup frmShowStudentGroup = new frmShowStudentGroup(_SelectedGroupID);
            frmShowStudentGroup.ShowDialog();
            _Refresh();
        }
        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAssignStudentToGroup frm = new frmAssignStudentToGroup(_SelectedGroupID, frmAssignStudentToGroup.entity.GroupID);
            frm.ShowDialog();
            _Refresh();
        }
    }
}
