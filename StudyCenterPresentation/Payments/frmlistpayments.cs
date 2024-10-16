using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudyCenterbusiness;
using System.Configuration;
namespace StudyCenterPresentation.Payments
{
    public partial class frmlistpayments : Form
    {
        DataTable _dtPayments;
        int _countPayments;
        int _RowsPerPage = 0;
        int? SelectedPaymentID => (int?)dgvlist.CurrentRow.Cells[0].Value;
        public frmlistpayments()
        {
            InitializeComponent();
            if (short.TryParse(ConfigurationManager.AppSettings["RowsPerPage"], out short value))
            {
                _RowsPerPage = value;
            }
            else _RowsPerPage = 8;
        }
        void _Refresh()
        {
            cbfilter.SelectedIndex = 0;
            _FillcountPayments();
            _dtPayments = clsPaymentBusiness.ListPaymentByPages((short)NUMPageNumber.Value, _RowsPerPage);
            dgvlist.DataSource = _dtPayments;
            lbrecord.Text = dgvlist.Rows.Count.ToString();
            if (dgvlist.Rows.Count > 0)
            {
                dgvlist.Columns[0].HeaderText = "Payment ID";
                dgvlist.Columns[0].Width = 50;
                dgvlist.Columns[1].HeaderText = "Student Group ID";
                dgvlist.Columns[1].Width = 50;
                dgvlist.Columns[2].HeaderText = "Group ID";
                dgvlist.Columns[2].Width = 50;
                dgvlist.Columns[3].HeaderText = "Group Name";
                dgvlist.Columns[3].Width = 110;
                dgvlist.Columns[3].HeaderText = "Student ID";
                dgvlist.Columns[3].Width = 110;
                dgvlist.Columns[3].HeaderText = "Full Name";
                dgvlist.Columns[3].Width = 110;
                dgvlist.Columns[3].HeaderText = "Amount";
                dgvlist.Columns[3].Width = 110;
                dgvlist.Columns[3].HeaderText = "Date";
                dgvlist.Columns[3].Width = 110;
            }
        }
        void _FillcountPayments()
        {
            _countPayments=clsPaymentBusiness.CountPayments();
            short numberofpages = (short)Math.Ceiling((decimal)_countPayments / _RowsPerPage);
            NUMPageNumber.Maximum = numberofpages;
            if (numberofpages > 0)
            {
                NUMPageNumber.Value = 1;
            }
        }
        private void frmlistpayments_Load(object sender, EventArgs e)=>_Refresh();
        private void txtfilterr_TextChanged(object sender, EventArgs e)
        {
            if (_dtPayments == null || dgvlist.Rows.Count == 0)
                return;
            string ColoumnName = _GetRealNames(txtfilterr.Text);
            if (string.IsNullOrEmpty(txtfilterr.Text) || cbfilter.SelectedIndex == 0)
            {
                _dtPayments.DefaultView.RowFilter = "";
                lbrecord.Text = dgvlist.Rows.Count.ToString();
                return;
            }
            if (cbfilter.SelectedItem == "Full Name")
            {
                _dtPayments.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", ColoumnName, txtfilterr.Text);
            }
            else
            {
                _dtPayments.DefaultView.RowFilter = string.Format("[{0}] = {1}'", ColoumnName, txtfilterr.Text);
            }
            lbrecord.Text = dgvlist.Rows.Count.ToString();
        }
        string _GetRealNames(string Name)
        {
            switch (Name)
            {
                case "Payment ID":
                    return "PaymentID";
                case "Student ID":
                    return "StudentID";
                case "Group ID":
                    return "GroupID";
                case "Full Name":
                    return "FullName";
                case "Grade-Subject ID":
                    return "GradeSubjectID";
                default:
                    return null;
            }
        }
        private void cbfilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtfilterr.Visible = cbfilter.SelectedIndex != 0;
        }
        private void txtfilterr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbfilter.SelectedItem != "Full Name" )
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }
        private void NUMPageNumber_ValueChanged(object sender, EventArgs e)
        {
            cbfilter.SelectedIndex = 0;
            _Refresh();
        }
        private void showGroupInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int? GroupID =(int)dgvlist.CurrentRow.Cells[3].Value;
            //frmshowGroupInfo f = new frmshowGroupInfo(GroupID);
            //f.ShowDialog();
        }
        private void showStudentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int? StudentID = (int)dgvlist.CurrentRow.Cells[5].Value;
            frmShowStudentInfo f = new frmShowStudentInfo(StudentID);
            f.ShowDialog();
        }
        private void showSubjectGradeInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int SubjectGrade = (int)dgvlist.CurrentRow.Cells[1].Value;
            //frmShowGradeSubjectInfo f = new frmShowGradeSubjectInfo(SubjectGrade);
            //f.ShowDialog();
        }
    }
}
