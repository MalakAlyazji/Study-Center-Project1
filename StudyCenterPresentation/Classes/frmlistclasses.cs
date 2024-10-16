using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using StudyCenterbusiness;
namespace StudyCenterPresentation.NewFolder3
{
    public partial class frmlistclasses : Form
    {
        DataTable _dtClass;
        private int _RowsPerPage = 0;
        private int? _CountClasses = 0;
        int? _SelectedClassID => (int?)dgvlist.CurrentRow.Cells[0].Value;
        public frmlistclasses()
        {
            InitializeComponent();
            if (short.TryParse(ConfigurationManager.AppSettings["RowsPerPage"], out short value))
            {
                _RowsPerPage = value;
            }
            else
            {
                value = 8;
            }
        }
        void _FillCountClasses()
        {
            _CountClasses = clsClassBusiness.CountClasses();
            short numberofpages = (short)Math.Ceiling((decimal)_CountClasses / _RowsPerPage);
            NUMPageNumber.Maximum = numberofpages;
            if (numberofpages > 0)
            {
                NUMPageNumber.Value = 1;
            }
        }
        private void btnAddClass_Click(object sender, EventArgs e)
        {
            frmAddClass frmAddClass = new frmAddClass();
            frmAddClass.ShowDialog();
            _Refresh();
        }
        private void txtfilterr_TextChanged(object sender, EventArgs e)
        {
            if (_dtClass == null || _dtClass.Rows.Count == 0)
            {
                return;
            }
            string ColumnName = _GetTRealNames();
            if (string.IsNullOrEmpty(txtfilterr.Text) || cbfilter.SelectedIndex == 0)
            {
                _dtClass.DefaultView.RowFilter = null;
                dgvlist.DataSource = _dtClass;
                lbrecord.Text = dgvlist.Rows.Count.ToString();
                return;
            }
            if (cbfilter.Text == "Class ID")
            {
                _dtClass.DefaultView.RowFilter = string.Format("[{0}]={1}", ColumnName, txtfilterr.Text);
            }
            else
            {
                _dtClass.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", ColumnName, txtfilterr.Text);
            }
            lbrecord.Text = dgvlist.Rows.Count.ToString();
        }
        private void cbfilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtfilterr.Visible = cbfilter.SelectedIndex != 0;
        }
        string _GetTRealNames()
        {
            switch (cbfilter.Text)
            {
                case "Class ID":
                    return "ClassID";
                case "Class Name":
                    return "ClassName";
            }
            return "None";
        }
        private void NUMPageNumber_ValueChanged(object sender, EventArgs e)
        {
            _Refresh();
            cbfilter.SelectedIndex = 0;
        }
        private void _Refresh()
        {
            cbfilter.SelectedIndex = 0;
            _dtClass = clsClassBusiness.ListClassByPages((short)NUMPageNumber.Value, _RowsPerPage);
            dgvlist.DataSource = _dtClass;
            lbrecord.Text = dgvlist.Rows.Count.ToString();
            if (dgvlist.Rows.Count > 0)
            {
                dgvlist.Columns[0].HeaderText = "Class ID";
                dgvlist.Columns[0].Width = 210;
                dgvlist.Columns[1].HeaderText = "Class Name";
                dgvlist.Columns[1].Width = 210;
                dgvlist.Columns[2].HeaderText = "Capacity";
                dgvlist.Columns[2].Width = 240;
            }
        }
        private void frmlistclasses_Load(object sender, EventArgs e)
        {
            _Refresh();
            _FillCountClasses();
        }
        private void showClassDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowClassCard frmShowClassCard = new frmShowClassCard(_SelectedClassID);
            frmShowClassCard.ShowDialog();
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddClass frmAddClass = new frmAddClass(_SelectedClassID);
            frmAddClass.ShowDialog();
            _Refresh();
        }
        private void addGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Refresh();
        }
        private void showGroupsAndWhoTeachesInItToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowTeachersInClass frmShowTeachersInClass = new frmShowTeachersInClass(_SelectedClassID);
            frmShowTeachersInClass.ShowDialog(this);
        }
    }
}
