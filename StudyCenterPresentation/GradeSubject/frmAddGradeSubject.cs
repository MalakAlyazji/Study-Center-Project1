using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using StudyCenterbusiness;

namespace StudyCenterPresentation
{
    public partial class frmAddGradeSubject : Form
    {
        int? _GradeSubjectID;
        clsGradeSubjectBusiness _GradeSubject = null;
        public Action<int?> GradeSubjectIDBack;
        public enum enMode { Add, Update }
        enMode _Mode = enMode.Add;
        public frmAddGradeSubject()
        {
            InitializeComponent();
            _Mode = enMode.Add;
        }
        public frmAddGradeSubject(int? GradeSubjectID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _GradeSubjectID = GradeSubjectID;
        }
        private void btclose_Click(object sender, EventArgs e)
        {
            Close();
        }
        void _ResetFields()
        {
            lblGradeSubjectID.Text = "[????]";
            cbGradeLevelName.SelectedItem = string.Empty;
            cbSubjectName.SelectedItem = string.Empty;
            txtFees.Text = string.Empty;
            cbGradeLevelName.Focus();
            cbSubjectName.Focus();
            if (cbGradeLevelName.SelectedItem != null && cbSubjectName.SelectedItem != null)
                lblGradeSubjectTitles.Text = cbGradeLevelName.Text.Trim() + "-" + cbSubjectName.Text.Trim();

        }
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected values
            string selectedValue1 = cbSubjectName.SelectedItem?.ToString() ?? "None";
            string selectedValue2 = cbGradeLevelName.SelectedItem?.ToString() ?? "None";

            // Update the label text based on the ComboBox selections
            lblGradeSubjectTitles.Text = selectedValue1.Trim() + "-" + selectedValue2.Trim();
        }
        void _ResetTiltles()
        {
            _FillGradeName();
            _FillSubjectsName();
            if (_Mode == enMode.Add)
            {
                lbltitle.Text = "Add New Subject Grade Level";
                _GradeSubject = new clsGradeSubjectBusiness();
                _ResetFields();
            }
            else
            {
                lbltitle.Text = "Update Subject Grade Level";
                btsave.Enabled = true;
            }
            Text = lbltitle.Text;
        }
        void _loadGradeSubjectToUpdate()
        {
            _GradeSubject = clsGradeSubjectBusiness.FindGradeSubjectIDBy(_GradeSubjectID, clsGradeSubjectBusiness.enFindBy.GradeSubjectID);
            if (_GradeSubject == null)
            {
                clsShowMessage.ShowMissingDataMessage("Subject-GradeLevel", _GradeSubjectID);
                Close();
                return;
            }
            _FillToUpdate();
        }
        void _FillSubjectsName()
        {
            cbSubjectName.Items.Clear();
            DataTable SubjectNames = clsSubjectBusiness.GetSubjectNames();
            foreach (DataRow S in SubjectNames.Rows)
            {
                cbSubjectName.Items.Add(S["SubjectName"].ToString());
            }
            if (cbSubjectName.Items.Count > 0)
                cbSubjectName.SelectedIndex = 0;
        }
        void _FillGradeName()
        {
            cbGradeLevelName.Items.Clear();
            DataTable GradeNames = clsGradeLevelBusiness.GetLevelsName();
            foreach (DataRow G in GradeNames.Rows)
            {
                cbGradeLevelName.Items.Add(G["GradeLevelName"].ToString());
            }
            if (cbGradeLevelName.Items.Count > 0)
                cbGradeLevelName.SelectedIndex = 0;
        }
        private void cbGradeLevelsAndSubjectNames_Validating(object sender, CancelEventArgs e)
        {
            _ValidateSubjectAndGradeLevelExists(e);
        }
        void _ValidateSubjectAndGradeLevelExists(CancelEventArgs e)
        {
            int? SubjectID = clsSubjectBusiness.GetSubjecIDByName(cbSubjectName.SelectedText.Trim());
            int? GradeID = clsGradeLevelBusiness.GetGradeLevelIDbyName(cbGradeLevelName.SelectedText.Trim());
            if ((_Mode == enMode.Add || (_Mode == enMode.Update && (_GradeSubject?.GradeID != GradeID || _GradeSubject?.SubjectID != SubjectID))) && clsGradeSubjectBusiness.IsGradeSubjectExistBy(GradeID, clsGradeSubjectBusiness.enFindBy.Both, SubjectID))
            {
                e.Cancel = true;
                errorProvider1.SetError(cbGradeLevelName, $"There is already {cbGradeLevelName.Text} for {cbGradeLevelName.Text}!");
                errorProvider1.SetError(cbSubjectName, $"There is already {cbSubjectName.Text} for {cbSubjectName.Text}!");
            }
            else
            {
                errorProvider1.SetError(cbGradeLevelName, null);
                errorProvider1.SetError(cbSubjectName, null);
            }
            btsave.Enabled = cbGradeLevelName.SelectedItem != null && cbSubjectName.SelectedItem != null && txtFees.Text != null;
        }
        void _FillToUpdate()
        {
            lblGradeSubjectTitles.Text = _GradeSubject.Titles.ToString();
            lblGradeSubjectID.Text = _GradeSubject.GradeSubjectID.ToString();
            cbGradeLevelName.SelectedItem = _GradeSubject.GradeLevelInfo.GradeLevelName;
            cbSubjectName.SelectedItem = _GradeSubject.SubjectInfo.SubjectName;
            txtFees.Text = _GradeSubject.Fees.ToString();
        }
        void _FillToSave()
        {
            _GradeSubject.GradeID = clsGradeLevelBusiness.GetGradeLevelIDbyName(cbGradeLevelName.SelectedItem.ToString());
            _GradeSubject.SubjectID = clsSubjectBusiness.GetSubjecIDByName(cbSubjectName.SelectedItem.ToString());
            _GradeSubject.Fees = decimal.Parse(txtFees.Text);
            _GradeSubject.Titles = lblGradeSubjectTitles.Text;
        }
        void _SaveGradeSubject()
        {
            _FillToSave();
            if (_GradeSubject.SaveGradeSubject())
            {
                _Mode = enMode.Update;
                lbltitle.Text = "Update Subject Grade Level";
                btsave.Enabled = true;
                Text = lbltitle.Text;
                GradeSubjectIDBack?.Invoke(_GradeSubject?.GradeSubjectID);
                clsShowMessage.OperationDoneSuccessfully("Saved");
            }
            else
            {
                clsShowMessage.OperationFelid("Saved");
            }
        }
        private void btsave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                clsShowMessage.ShowValidationErrorMessage();
                return;
            }
            _SaveGradeSubject();
        }
        private void frmAddGradeSubject_Load(object sender, EventArgs e)
        {
            _ResetTiltles();
            if (_Mode == enMode.Update)
            {
                _loadGradeSubjectToUpdate();
            }
        }
        private void txtFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFees, "This field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtFees, null);
            }
        }
        private void txtFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
                return;

            // Allow one decimal point
            if (e.KeyChar == '.' && txtFees.Text.Contains("."))
            {
                e.Handled = true;
                return;
            }

            e.Handled = true;
        }
        void _LoadSubject(int? SubjectID)
        {
            _FillSubjectsName();
            _ResetFields();
            cbSubjectName.SelectedIndex = cbSubjectName.FindString(clsSubjectBusiness.GetSubjectNameByID(SubjectID));
            btsave.Enabled = txtFees.Text != string.Empty;
        }
        private void lnkAddNewSubject_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddSubject frmAddSubject = new frmAddSubject();
            frmAddSubject.SubjectIDBack += _LoadSubject;
            frmAddSubject.ShowDialog();
        }
    }
}
