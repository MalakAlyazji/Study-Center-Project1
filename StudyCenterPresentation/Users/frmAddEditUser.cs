using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using StudyCenterBuisness;

namespace StudyCenterPresentation
{
    public partial class frmAddEditUser : Form
    {
        enum enMode { Add, Update }
        enMode _Mode = enMode.Add;
        int? _UserID = null;
        int? _SelectedPersonID = null;
        clsuserbusiness _User = null;
        public Action<int?> UserIDBack;
        public int? UserID => _UserID;
        public clsuserbusiness User => _User;
        public frmAddEditUser()
        {
            _Mode = enMode.Add;
            InitializeComponent();
        }
        public frmAddEditUser(int? UserID, bool allowToEditPermissions = true)
        {
            _Mode = enMode.Update;
            _UserID = UserID;
            InitializeComponent();
            gbPermissions.Enabled = allowToEditPermissions;
            lnkChangePassword.Enabled = allowToEditPermissions;
        }
        private void btclose_Click(object sender, EventArgs e)
        {
            Close();
        }
        void _FillUserInfoToSave()
        {
            _User.IsActive = chkISActive.Checked;
            _User.UserName = txtUserName.Text;
            _User.PersonID = _SelectedPersonID.Value;
            _User.Password = txtPass.Text;
            _User.Permissions = _CountPermissions();
        }
        void _SaveUser()
        {
            _FillUserInfoToSave();
            if (_User.Save())
            {
                _Mode = enMode.Update;
                lblTitle.Text = "Update User Info";
                Text = lblTitle.Text;
                UserIDBack?.Invoke(_User.UserID);
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
            if (!_CheckIFPermissionSelected())
            {
                MessageBox.Show("You have to select permissions for the user!", "Permissions Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _SaveUser();
        }
        private void lnkChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmChangePassword frmChangePassword = new frmChangePassword(_UserID);
            frmChangePassword.ShowDialog();
            frmAddEditUser_Load(null, null);
        }
        private void ctrlpersoninfoFITER1_OnPersonSelected(object sender, ctrlpersoninfoFITER.PersonSelectedEventArgs e)
        {
            if (!e.PersonID.HasValue)
            {
                btsave.Enabled = false;
                tbUserInfo.Enabled = false;
                return;
            }
            if (_Mode == enMode.Add && clsuserbusiness.IsUserExistBy(e.PersonID, clsuserbusiness.EnFindUserBy.PersonID))
            {
                MessageBox.Show("Selected Person already has a user, choose another one.",
                            "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);

                ctrlpersoninfoFITER1.FilterFocus();
                tbUserInfo.Enabled = false;
                btsave.Enabled = false;
                return;
            }
            _SelectedPersonID = e.PersonID;
            tbUserInfo.Enabled = true;
            btsave.Enabled = true;
        }
        private void _ResetFields()
        {
            ctrlpersoninfoFITER1.Reset();
            txtUserName.Clear();
            txtPass.Clear();
            txtConfirmPass.Clear();
            lblUserID.Text = "[????]";
            chkISActive.Checked = true;
        }
        void _ResetTiltles()
        {
            if (_Mode == enMode.Add)
            {
                ctrlpersoninfoFITER1.FilterEnable = true;
                lblTitle.Text = "Add New User";
                lnkChangePassword.Enabled = false;
                txtPass.Visible = true;
                txtConfirmPass.Visible = true;
                _User = new clsuserbusiness();
                ctrlpersoninfoFITER1.FilterFocus();
                _ResetFields();
            }
            else
            {
                ctrlpersoninfoFITER1.FilterEnable = false;
                lblTitle.Text = "Update User Info";
                lnkChangePassword.Enabled = true;
            }
            Text = lblTitle.Text;
        }
        bool _CheckIFPermissionSelected()
        {
            foreach (var item in gbPermissions.Controls)
            {
                if (item is Guna2CheckBox chk)
                {
                    if (chk.Tag.ToString() != "-1" && chk.Checked)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        void _FillCheckBoxPermissions()
        {
            if (_User.Permissions == -1)
            {
                chkAdmin.Checked = true;
                return;
            }
            foreach (var item in gbPermissions.Controls)
            {
                if (item is Guna2CheckBox chk)
                {
                    if (chk.Tag.ToString() != "-1")
                    {
                        if (((Convert.ToInt32(chk.Tag)) & _User.Permissions) == (Convert.ToInt32(chk.Tag)))
                        {
                            chk.Checked = true;
                        }
                    }
                }
            }
        }
        int? _CountPermissions()
        {
            int? Count = 0;
            if (chkAdmin.Checked)
                return -1;
            foreach (var item in gbPermissions.Controls)
            {
                if (item is Guna2CheckBox chk && chk.Checked)
                {
                    if (Int32.TryParse(chk.Tag.ToString(), out int permissionValue))
                    {
                        Count += permissionValue;
                    }
                }
            }
            return Count;
        }
        void _LoadToUpdate()
        {
            _User = clsuserbusiness.FindUserBy(_UserID, clsuserbusiness.EnFindUserBy.UserID);
            if (_User == null)
            {
                clsShowMessage.ShowMissingDataMessage("User", _UserID);
                Close();
                return;
            }
            _SelectedPersonID = _User.PersonID;
            ctrlpersoninfoFITER1.LoadPersonInfo(_User.PersonID);
            lblUserID.Text = _User.UserID.ToString();
            txtUserName.Text = _User.UserName.ToString();
            chkISActive.Checked = _User.IsActive;
            txtPass.Text = _User.Password;
            txtConfirmPass.Text = _User.Password;
            _FillCheckBoxPermissions();
        }
        private void guna2TextBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                errorProvider1.SetError(txtUserName, "This Feiled is required");
            }
            else
            {
                errorProvider1.SetError(txtUserName, null);
            }
        }
        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            _ResetTiltles();
            if (_Mode == enMode.Update)
            {
                _LoadToUpdate();
            }
        }
        private void txtPass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPass.Text))
            {
                errorProvider1.SetError(txtPass, "This Feiled is required");
            }
            else
            {
                errorProvider1.SetError(txtPass, null);
            }
        }
        private void txtConfirmPass_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmPass.Text))
            {
                errorProvider1.SetError(txtConfirmPass, "This Feiled is required");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPass, null);
            }
            if (txtConfirmPass.Text != txtPass.Text)
            {
                errorProvider1.SetError(txtConfirmPass, "The Passwords are not matched");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPass, null);
            }
        }
        private bool _CheckAllPermissions()
        {
            return gbPermissions.Controls.OfType<Guna2CheckBox>()
                .Where(chk => chk.Tag.ToString() != "-1")
                .All(chk => chk.Checked);
        }
        private void chkAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAdmin.Checked)
            {
                foreach (var item in gbPermissions.Controls)
                {
                    if (item is Guna2CheckBox chk)
                    {
                        chk.Checked = true;
                    }
                }
            }
        }
        private void chk_CheckedChanged(object sender, EventArgs e)
        {
            if (!((Guna2CheckBox)sender).Checked)
            {
                chkAdmin.Checked = false;
                return;
            }
            chkAdmin.Checked = _CheckAllPermissions();
        }
    }
}
