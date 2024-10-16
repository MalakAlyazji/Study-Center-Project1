using System;
using System.ComponentModel;
using System.Windows.Forms;
using StudyCenterBusinesss;

namespace StudyCenterPresentation
{
    public partial class frmaddteacher : Form
    {
        enum emode { add, update }
        emode _mode;
        clsteacherbusiness _teacher;
        int? _teacherid;
        public Action<int?> TeacherIDBack;
        int? _selectedpersonid = null;
        void _ResetTeacherInfo()
        {
            lblcreatedby.Text = "[????]";
            lblTeacherID.Text = "[????]";
            dtHireDate.Value = DateTime.Now;
            txtQualifications.Text = string.Empty;
            txtSalary.Text = string.Empty;
        }
        void _ResetFields()
        {
            ctrlpersoninfoFITER1.Reset();
            _ResetTeacherInfo();
        }
        public frmaddteacher()
        {
            _mode = emode.add;
            InitializeComponent();
        }
        public frmaddteacher(int? teacherid)
        {
            _mode = emode.update;
            _teacherid = teacherid;
            InitializeComponent();
        }
        void _ResetTitles()
        {
            if (_mode == emode.add)
            {
                ctrlpersoninfoFITER1.FilterEnable = true;
                groupTeacher.Enabled = false;
                Text = "Add New Teacher";
                lbltitle.Text = "Add New Teacher";
                _teacher = new clsteacherbusiness();
                _ResetFields();
            }
            else
            {
                ctrlpersoninfoFITER1.FilterEnable = false;
                groupTeacher.Enabled = true;
                groupTeacher.Focus();
                Text = "Update Teacher Info";
                lbltitle.Text = "Update Teacher Info";
            }
        }
        void _FillToUpdate()
        {
            ctrlpersoninfoFITER1.LoadPersonInfo(_teacher.PersonID);
            lblcreatedby.Text = "Malak";
            lblTeacherID.Text = _teacherid.ToString();
            dtHireDate.Value = (DateTime)_teacher.HireDate;
            txtSalary.Text = _teacher.Salary.ToString();
            txtQualifications.Text = _teacher.Qualification.ToString();
        }
        void _loadteacherinfo()
        {
            _teacher = clsteacherbusiness.FindBy(_teacherid, clsteacherbusiness.enFindBy.teacherid);
            if (_teacher == null)
            {
                clsShowMessage.IdNotFound("Teacher", _teacherid);
                Close();
                return;
            }
            _FillToUpdate();
        }
        private void frmaddteacher_Load(object sender, EventArgs e)
        {
            _ResetTitles();
            if (_mode == emode.update)
            {
                _loadteacherinfo();
            }
        }
        private void btclose_Click(object sender, EventArgs e)
        {
            Close();
        }
        void _SaveTeacher()
        {
            _FillToSave();
            if (_teacher.saveteacher())
            {
                _mode = emode.update;
                _ResetTitles();
                lblTeacherID.Text = _teacher.TeacherID.ToString();
                TeacherIDBack?.Invoke(_teacher.TeacherID);
                clsShowMessage.OperationDoneSuccessfully("Saved");

            }
            else
            {
                clsShowMessage.OperationFelid("Saved");
            }
        }
        void _FillToSave()
        {
            _teacher.PersonID = _selectedpersonid;
            _teacher.UserID = clsGlobal.LogInUser.UserID;
            _teacher.Salary = int.Parse(txtSalary.Text);
            _teacher.Qualification = txtQualifications.Text;
            _teacher.HireDate = dtHireDate.Value;
        }
        private void btsave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                clsShowMessage.ValidationErrorMessage();
                return;
            }
            _SaveTeacher();
        }
        private void ctrlpersoninfoFITER1_OnPersonSelected(object sender, ctrlpersoninfoFITER.PersonSelectedEventArgs e)
        {
            if (!e.PersonID.HasValue)
            {
                btsave.Enabled = false;
                return;
            }

            if (_mode == emode.add && clsteacherbusiness.IsTeacherExistByPersonID(e.PersonID))
            {
                MessageBox.Show("This person is already registered as a teacher. Please select another person.",
                                "Already Registered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btsave.Enabled = false;
                return;
            }
            btsave.Enabled = true;
            groupTeacher.Enabled = true;
            _selectedpersonid = e.PersonID;
        }
        private void pbclose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtSalary_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSalary.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtSalary, "This field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtSalary, null);
            }
        }
    }
}
