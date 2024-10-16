using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using StudyCenterBusinesss;
namespace StudyCenterPresentation
{
    public partial class frmlistteacher : Form
    {
        DataTable _dtteacher;
        private readonly int _RowsPerPage = 0;
        int _Countteachers = 0;
        int? _selectedTeacherID => (int?)dgvlist.CurrentRow.Cells[0].Value;
        public frmlistteacher()
        {
            if (short.TryParse(ConfigurationManager.AppSettings["RowsPerPage"], out short value))
            {
                _RowsPerPage = value;
            }
            else
            {
                _RowsPerPage = 8;
            }
            InitializeComponent();
        }
        void _fillcbgender()
        {
            cbgender.Items.Clear();
            cbgender.Items.Add("All");
            cbgender.Items.Add("Male");
            cbgender.Items.Add("Female");

        }
        string _GetRealNames()
        {
            switch (cbfilter.Text)
            {
                case "Teacher ID":
                    return "teacherid";

                case "Teacher Name":
                    return "TeacherName";

                case "Qualification":
                    return "Qualification";
                case "Date Of Birth":
                    return "BirthDate";
                case "Age":
                    return "Age";
                case "Gender":
                    return "Gender";
                case "Hire Date":
                    return "Hire Date";
                case "Salary":
                    return "Salary";
                default:
                    return "None";
            }
        }
        void _Refresh()
        {
            cbfilter.SelectedIndex = 0;
            cbgender.SelectedIndex = 0;
            _dtteacher = clsteacherbusiness.listbypage((short)NUMPageNumber.Value, _RowsPerPage);
            dgvlist.DataSource = _dtteacher;
            lbrecord.Text = dgvlist.Rows.Count.ToString();
            if (dgvlist.Rows.Count > 0)
            {
                dgvlist.Columns[0].HeaderText = "Teacher ID";
                dgvlist.Columns[0].Width = 50;
                dgvlist.Columns[1].HeaderText = "Teacher Name";
                dgvlist.Columns[1].Width = 100;
                dgvlist.Columns[2].HeaderText = "Qualifications";
                dgvlist.Columns[2].Width = 180;
                dgvlist.Columns[3].HeaderText = "Date Of Birth";
                dgvlist.Columns[3].Width = 100;
                dgvlist.Columns[4].HeaderText = "Age";
                dgvlist.Columns[4].Width = 50;
                dgvlist.Columns[5].HeaderText = "Gender";
                dgvlist.Columns[5].Width = 60;
                dgvlist.Columns[6].HeaderText = "Hire Date";
                dgvlist.Columns[6].Width = 70;
                dgvlist.Columns[7].HeaderText = "Salary";
                dgvlist.Columns[7].Width = 70;
            }
        }
        void _fillcountTeachers()
        {
            _Countteachers = clsteacherbusiness.CountTeachers();
            short numberofpages = (short)Math.Ceiling((decimal)_Countteachers / _RowsPerPage);
            NUMPageNumber.Maximum = numberofpages;
            if (numberofpages > 0)
            {
                NUMPageNumber.Value = 1;
            }
        }
        private void frmlistteacher_Load(object sender, EventArgs e)
        {
            _fillcbgender();
            _fillcountTeachers();
            _Refresh();
        }
        private void txtfilterr_TextChanged(object sender, EventArgs e)
        {
            if (_dtteacher == null || _dtteacher.Rows.Count == 0)
                return;
            string columnName = _GetRealNames();
            if (string.IsNullOrEmpty(txtfilterr.Text.Trim()) || cbfilter.SelectedIndex == 0)
            {
                _dtteacher.DefaultView.RowFilter = "";
                lbrecord.Text = dgvlist.Rows.Count.ToString();
                return;
            }
            if (cbfilter.SelectedItem == "Age" || cbfilter.Text == "Teacher ID")
            {
                _dtteacher.DefaultView.RowFilter = string.Format("[{0}]={1}", columnName, txtfilterr.Text.Trim());
            }
            else
            {
                _dtteacher.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", columnName, txtfilterr.Text.Trim());
            }
            lbrecord.Text = dgvlist.Rows.Count.ToString();
        }
        private void cbgender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_dtteacher == null || _dtteacher.Rows.Count == 0)
                return;
            if (cbgender.SelectedIndex == 0)
            {
                _dtteacher.DefaultView.RowFilter = "";
                lbrecord.Text = dgvlist.Rows.Count.ToString();
                return;
            }
            _dtteacher.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", "Gender", cbgender.Text);
            lbrecord.Text = dgvlist.Rows.Count.ToString();
        }
        private void cbgender_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbfilter.SelectedItem == "Teacher ID" || cbfilter.SelectedItem == "Age")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }
        private void NUMPageNumber_ValueChanged(object sender, EventArgs e)
        {
            _Refresh();
        }
        private void btnaddperson_Click(object sender, EventArgs e)
        {
            frmaddteacher t = new frmaddteacher();
            t.ShowDialog();
            _Refresh();
        }
        private void cbfilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtfilterr.Visible = (cbfilter.Text != "Gender" && cbfilter.Text != "None");
            cbgender.Visible = (cbfilter.Text == "Gender");

            if (cbgender.Visible)
                cbgender.SelectedIndex = 0;
            if (txtfilterr.Visible)
            {
                txtfilterr.Text = "";
                txtfilterr.Focus();
            }

        }
        private void showTeachersDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            frmShowTeacherInfo frmShowTeacherInfo = new frmShowTeacherInfo(_selectedTeacherID);
            frmShowTeacherInfo.ShowDialog();
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmaddteacher t = new frmaddteacher(_selectedTeacherID);
            t.ShowDialog();
            _Refresh();
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsShowMessage.DeleteConfiirmation(_selectedTeacherID.ToString()) == DialogResult.No) return;
            if (clsteacherbusiness.DeleteTeacher(_selectedTeacherID))
            {
                clsShowMessage.DeletedSuccessfuly("Teacher");
            }
            _Refresh();
        }
        private void assignToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_selectedTeacherID.HasValue)
            {
                clsShowMessage.ShowMissingDataMessage("Found", _selectedTeacherID);
                return;
            }
            frmAssignTeacherToSubject frmAssignTeacherToSubject = new frmAssignTeacherToSubject(_selectedTeacherID, frmAssignTeacherToSubject.entity.TeacherID);
            frmAssignTeacherToSubject.ShowDialog();
            _Refresh();
        }
        private void teachedSubjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListTeacherSubjects frmListTeacherSubjects = new frmListTeacherSubjects(_selectedTeacherID);
            frmListTeacherSubjects.ShowDialog();
        }
        private void teachedClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowTeachersInClass frmShowTeachersInClass = new frmShowTeachersInClass(_selectedTeacherID);
            frmShowTeachersInClass.ShowDialog();
        }
    }
}
