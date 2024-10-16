using System.Windows.Forms;
using StudyCenterBuisness;

namespace StudyCenterPresentation
{
    public partial class frmChangePassword : Form
    {
        int? _UserID = null;
        clsuserbusiness _User = null;
        public frmChangePassword(int? UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }
        private void btclose_Click(object sender, System.EventArgs e)
        {
            Close();
        }
        private void _ResetFields()
        {
            txtCurrentPassword.Clear();
            txtNewPassword.Clear();
            txtConfirmPassword.Clear();
            txtCurrentPassword.Focus();
        }
        void _SavePasswordChanged()
        {
            if (_User.UpdatePassword(txtNewPassword.Text.Trim()))
            {
                MessageBox.Show("Password Changed Successfully.", "Success",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ResetFields();
            }
            else
            {
                MessageBox.Show("An Error Occurred, Password did not change.",
                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btsave_Click(object sender, System.EventArgs e)
        {
            if (!ValidateChildren())
            {
                clsShowMessage.ShowValidationErrorMessage();
                return;
            }
            _SavePasswordChanged();
        }
        private void txtCurrentPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtCurrentPassword.Text != _User.Password)
            {
                errorProvider1.SetError(txtCurrentPassword, "The Password does not match the current one");
            }
            else
            {
                errorProvider1.SetError(txtCurrentPassword, null);
            }
        }
        private void txtConfirmPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                errorProvider1.SetError(txtConfirmPassword, "This Feiled is required");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            }
            if (txtConfirmPassword.Text != txtNewPassword.Text)
            {
                errorProvider1.SetError(txtConfirmPassword, "The Passwords are not matched");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            }
        }
        private void txtNewPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPassword.Text))
            {
                errorProvider1.SetError(txtNewPassword, "This fieled is required!");
            }
            else
            {
                errorProvider1.SetError(txtNewPassword, null);
            }

        }
        private void frmChangePassword_Load(object sender, System.EventArgs e)
        {
            _ResetFields();
            _User = clsuserbusiness.FindUserBy(_UserID, clsuserbusiness.EnFindUserBy.UserID);
            if (_User == null)
            {
                clsShowMessage.ShowMissingDataMessage("user", _UserID);
                Close();
                return;
            }
            ctrlUserCard1.LoadUserInfoByUserID(_UserID);
        }
    }
}
