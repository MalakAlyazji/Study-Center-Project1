using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using StudyCenterBuisness;
using StudyCenterbusiness;
namespace StudyCenterPresentation.Students
{
    public partial class frmliststudents : Form
    {
        DataTable _dtStudents;
        private readonly int _RowsPerPage = 0;
        int _countstudent = 0;
        private int? _SelectedStudentID => (int?)dgvlist.CurrentRow.Cells["StudentID"].Value;
        public frmliststudents()
        {
            InitializeComponent();
            if (short.TryParse(ConfigurationManager.AppSettings["RowsPerPage"], out short value))
            {
                _RowsPerPage = value;
            }
            else
            {
                _RowsPerPage = 8;
            }
        }
        private void _Refresh()
        {
            cbfilter.SelectedIndex = 0;
            _dtStudents = clsstudentbusiness.ListByPages((short)NUMPageNumber.Value, _RowsPerPage);
            dgvlist.DataSource = _dtStudents;
            lbrecord.Text = dgvlist.Rows.Count.ToString();
            if (dgvlist.Rows.Count > 0)
            {
                dgvlist.Columns[0].HeaderText = "Student ID";
                dgvlist.Columns[0].Width = 60;
                dgvlist.Columns[1].HeaderText = "Student Name";
                dgvlist.Columns[1].Width = 140;
                dgvlist.Columns[2].HeaderText = "Emergency Contact Number";
                dgvlist.Columns[2].Width = 120;
                dgvlist.Columns[3].HeaderText = "Grade Level";
                dgvlist.Columns[3].Width = 80;
                dgvlist.Columns[4].HeaderText = "Date Of Birth";
                dgvlist.Columns[4].Width = 110;
                dgvlist.Columns[5].HeaderText = "Age";
                dgvlist.Columns[5].Width = 60;
                dgvlist.Columns[6].HeaderText = "Gender";
                dgvlist.Columns[6].Width = 80;
            }
        }
        private void _fillcountstudent()
        {
            _countstudent = clsstudentbusiness.StudentCount();
            short NumberOfPages = (short)Math.Ceiling((decimal)_countstudent / _RowsPerPage);
            NUMPageNumber.Maximum = NumberOfPages;
            if (NumberOfPages > 0)
            {
                NUMPageNumber.Value = 1;
            }
        }
        private void _FillLevelCB()
        {
            cblevels.Items.Clear();
            cblevels.Items.Add("All");
            DataTable dt = clsGradeLevelBusiness.GetLevelsName();
            foreach (DataRow item in dt.Rows)
            {
                cblevels.Items.Add(item["GradeLevelName"].ToString());
            }
        }
        private void frmliststudents_Load(object sender, EventArgs e)
        {
            _Refresh();
            _fillcountstudent();
            _FillLevelCB();
        }
        string _GetRealNames()
        {
            switch (cbfilter.Text)
            {
                case "Student ID":
                    return "StudentID";

                case "Name":
                    return "StudentName";

                case "Gender":
                    return "Gender";

                case "Grade":
                    return "GradeLevelName";

                case "Age":
                    return "Age";

                default:
                    return "None";
            }
        }
        private void cbfilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtfilterr.Visible = (cbfilter.Text != "Grade" && cbfilter.Text != "Gender" && cbfilter.Text != "None");
            cbgender.Visible = (cbfilter.Text == "Gender");
            cblevels.Visible = (cbfilter.Text == "Grade");
            if (cbgender.Visible)
                cbgender.SelectedIndex = 0;
            if (txtfilterr.Visible)
            {
                txtfilterr.Text = "";
                txtfilterr.Focus();
            }
            if (cblevels.Visible)
                cblevels.SelectedIndex = 0;
        }
        private void txtfilterr_TextChanged(object sender, EventArgs e)
        {
            if (_dtStudents == null || _dtStudents.Rows.Count == 0)
                return;
            string columnName = _GetRealNames();
            if (string.IsNullOrEmpty(txtfilterr.Text.Trim()) || cbfilter.SelectedIndex == 0)
            {
                _dtStudents.DefaultView.RowFilter = "";
                lbrecord.Text = dgvlist.Rows.Count.ToString();
                return;
            }
            if (cbfilter.SelectedItem == "Age" || cbfilter.Text == "Student ID")
            {
                _dtStudents.DefaultView.RowFilter = string.Format("[{0}]={1}", columnName, txtfilterr.Text.Trim());
            }
            else
            {
                _dtStudents.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", columnName, txtfilterr.Text.Trim());
            }
            lbrecord.Text = dgvlist.Rows.Count.ToString();
        }
        private void txtfilterr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbfilter.SelectedItem == "StudentID" || cbfilter.SelectedItem == "Age")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }
        private void NUMPageNumber_ValueChanged(object sender, EventArgs e)
        {
            _Refresh();
            cbfilter.SelectedIndex = 0;
        }
        private void btnaddperson_Click(object sender, EventArgs e)
        {
            frmaddstudent f = new frmaddstudent();
            f.ShowDialog();
            Refresh();
        }
        private void cblevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_dtStudents == null || _dtStudents.Rows.Count == 0)
                return;
            if (cblevels.SelectedIndex == 0)
            {
                _dtStudents.DefaultView.RowFilter = "";
                lbrecord.Text = dgvlist.Rows.Count.ToString();
                return;
            }
            _dtStudents.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", "GradeLevelName", cblevels.Text);
            lbrecord.Text = dgvlist.Rows.Count.ToString();
        }
        private void cbgender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_dtStudents == null || _dtStudents.Rows.Count == 0)
                return;
            if (cbgender.SelectedIndex == 0)
            {
                _dtStudents.DefaultView.RowFilter = "";
                lbrecord.Text = dgvlist.Rows.Count.ToString();
                return;
            }
            _dtStudents.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", "Gender", cbgender.Text);
            lbrecord.Text = dgvlist.Rows.Count.ToString();
        }
        private void assignToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAssignStudentToGroup frmAssignStudentToGroup = new frmAssignStudentToGroup((int?)dgvlist.CurrentRow.Cells["StudentID"].Value, frmAssignStudentToGroup.entity.StudentID);
            frmAssignStudentToGroup.ShowDialog();
            _Refresh();
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsShowMessage.DeleteConfiirmation(_SelectedStudentID.ToString()) == DialogResult.No)
                return;
            if (clsstudentbusiness.DeleteStudent(_SelectedStudentID))
            {
                clsShowMessage.DeletedSuccessfuly("Student");
            }
            _Refresh();
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmaddstudent frmaddstudent = new frmaddstudent(_SelectedStudentID);
            frmaddstudent.ShowDialog();
            _Refresh();
        }
        private void showStudentsDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowStudentInfo frm = new frmShowStudentInfo(_SelectedStudentID);
            frm.ShowDialog();
        }
    }
}
