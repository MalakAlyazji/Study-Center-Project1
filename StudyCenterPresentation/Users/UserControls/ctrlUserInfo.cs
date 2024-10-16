using System.Collections.Generic;
using System.Windows.Forms;
using StudyCenterBuisness;

namespace StudyCenterPresentation
{
    public partial class ctrlUserInfo : UserControl
    {
        clsuserbusiness _User;
        int? _UserID = null;
        public int? UserID => _UserID;
        public clsuserbusiness User => _User;
        public ctrlUserInfo()
        {
            InitializeComponent();
        }
        public void ResetUser()
        {
            _UserID = null;
            _User = null;
            lblUserID.Text = "[????]";
            lblUserName.Text = "[????]";
            lblIsActive.Text = "[????]";
            lblPermissions.Text = "[????]";
            linkedituser.Enabled = true;
        }
        void _ShowPermissions()
        {
            if (_User == null)
            {
                lblPermissions.Text = "[????]";
                return;
            }
            List<string> permissions = _User.ListUserPermissions();
            lblPermissions.Text = string.Join(",", permissions);
        }
        void _FillUserInfo()
        {
            lblUserID.Text = _User.UserID.ToString();
            lblUserName.Text = _User.UserName;
            lblIsActive.Text = _User.IsActive ? "Active" : "Not Active";
            _ShowPermissions();
            _CheckPermissions();
        }
        public void LoadUserInfoByUserID(int? UserID)
        {
            if (!UserID.HasValue)
            {
                clsShowMessage.ShowMissingDataMessage("user", UserID);
                ResetUser();
                return;
            }
            _User = clsuserbusiness.FindUserBy(UserID, clsuserbusiness.EnFindUserBy.UserID);
            _UserID = _User.UserID;
            if (_User == null)
            {
                clsShowMessage.ShowMissingDataMessage("user", _User.UserID);
                ResetUser();
                return;
            }
            _UserID = _User.UserID;
            _FillUserInfo();
        }
        void _CheckPermissions()
        {
            if (linkedituser == null)
            {
                // Handle the null reference by logging or initializing it
                MessageBox.Show("Edit user link is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method early
            }
            bool hasPermission = clsGlobal.LogInUser?.Permissions == -1 ||
                                 ((int)clsuserbusiness.enPermissions.UpdateUser & (int)clsGlobal.LogInUser?.Permissions) == (int)clsuserbusiness.enPermissions.UpdateUser;

            linkedituser.Enabled = hasPermission; // Enable or disable based on permission
        }
        private void linkedituser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditUser frmAddEditUser = new frmAddEditUser(_UserID);
            frmAddEditUser.ShowDialog();
            LoadUserInfoByUserID(User.UserID);
        }
    }
}
