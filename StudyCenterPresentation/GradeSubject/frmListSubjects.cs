using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using StudyCenterbusiness;
namespace StudyCenterPresentation
{
    public partial class frmListSubjects : Form
    {
        DataTable _dtGradeSubject;
        int _RowsPerPage = 0;
        int? _SelectedGradeSubjectID => (int?)dgvlist.CurrentRow.Cells[0].Value;
        public frmListSubjects()
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
        void _CountRows()
        {
            int _GradeSubjectCount = clsGradeSubjectBusiness.CountGradeSubjects();
            short NumberOfPages = (short)Math.Ceiling((decimal)_GradeSubjectCount / _RowsPerPage);
            NUMPageNumber.Maximum = NumberOfPages;
            if (NumberOfPages > 0)
            {
                NUMPageNumber.Value = 1;
            }
        }
        void _Refresh()
        {
            cbfilter.SelectedIndex = 0;
            txtfilterr.Clear();
            _dtGradeSubject = clsGradeSubjectBusiness.ListGradeSubjectByPages((short)NUMPageNumber.Value, _RowsPerPage);
            dgvlist.DataSource = _dtGradeSubject;
            lbrecord.Text = dgvlist.Rows.Count.ToString();
            if (dgvlist.Rows.Count > 0)
            {
                dgvlist.Columns[0].HeaderText = "Subject Grade Level ID";
                dgvlist.Columns[0].Width = 70;
                dgvlist.Columns[1].HeaderText = "Subject Name";
                dgvlist.Columns[1].Width = 170;
                dgvlist.Columns[2].HeaderText = "Grade Level Name";
                dgvlist.Columns[2].Width = 170;
                dgvlist.Columns[3].HeaderText = "Title";
                dgvlist.Columns[3].Width = 270;
            }
        }
        string _GetRealNames()
        {
            switch (cbfilter.SelectedItem)
            {
                case "Subject Grade Level ID":
                    return "GradeSubjectID";
                case "Subject Name":
                    return "SubjectName";
                case "Grade Level Name":
                    return "GradeLevelName";
                default: return null;
            }
        }
        private void frmListSubjects_Load(object sender, EventArgs e)
        {
            _CountRows();
            _Refresh();
        }
        private void cbfilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtfilterr.Visible = cbfilter.SelectedIndex != 0;
            if (txtfilterr.Visible)
            {
                txtfilterr.Focus();
            }
        }
        private void txtfilterr_TextChanged(object sender, EventArgs e)
        {
            if (_dtGradeSubject == null || dgvlist.Rows.Count == 0)
            {
                _dtGradeSubject.DefaultView.RowFilter = "";
                return;
            }
            string CloumnName = _GetRealNames();
            if (string.IsNullOrEmpty(txtfilterr.Text.Trim()) || cbfilter.SelectedIndex == 0)
            {
                _dtGradeSubject.DefaultView.RowFilter = "";
                lbrecord.Text = _dtGradeSubject.Rows.Count.ToString();
                return;
            }
            if (cbfilter.Text == "Subject Grade Level ID")
            {
                _dtGradeSubject.DefaultView.RowFilter = string.Format("[{0}]={1}", CloumnName, txtfilterr.Text.Trim());
            }
            else
            {
                _dtGradeSubject.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", CloumnName, txtfilterr.Text.Trim());
            }
            lbrecord.Text = _dtGradeSubject.Rows.Count.ToString();
        }
        private void NUMPageNumber_ValueChanged(object sender, EventArgs e)
        {
            _Refresh();
        }
        private void txtfilterr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbfilter.SelectedText == "Subject Grade Level ID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }
        private void btnaddSubject_Click(object sender, EventArgs e)
        {
            frmAddGradeSubject frmAddGradeSubject = new frmAddGradeSubject();
            frmAddGradeSubject.ShowDialog();
            _Refresh();
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddGradeSubject frmAddGradeSubject = new frmAddGradeSubject(_SelectedGradeSubjectID);
            frmAddGradeSubject.ShowDialog();
            _Refresh();
        }
        private void whoTeachsThisSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int? SubjectID = clsSubjectBusiness.GetSubjecIDByName(dgvlist.CurrentRow.Cells[1].Value.ToString());
            frmTeachersTeachSubjectBySubjectID frmTeachersTeachSubjectBySubjectID = new frmTeachersTeachSubjectBySubjectID(SubjectID);
            frmTeachersTeachSubjectBySubjectID.ShowDialog();
        }
        private void showSubjectDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowGradeSubject frmShowGradeSubject = new frmShowGradeSubject(_SelectedGradeSubjectID);
            frmShowGradeSubject.ShowDialog();
        }
    }
}
