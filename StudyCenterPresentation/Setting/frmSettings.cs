using System.Configuration;
using System.Windows.Forms;
using StudyCenterBuisness;
using StudyCenterPresentation.Users;

namespace StudyCenterPresentation
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }
        private void lnkListUsers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmlistusers frmlistusers = new frmlistusers();
            frmlistusers.ShowDialog();
            frmSettings_Load(null, null);
        }
        private void lnkAddUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditUser frmAddEditUser = new frmAddEditUser();
            frmAddEditUser.ShowDialog();
            frmSettings_Load(null, null);
        }
        void _FillSettingsInfo()
        {
            lblOpeningTime.Text = ConfigurationManager.AppSettings["OpeningTime"] ?? "[????]";
            lblClosingTime.Text = ConfigurationManager.AppSettings["CloseTime"] ?? "[????]";
            lblDailyLectureDuration.Text = ConfigurationManager.AppSettings["Daily"] + " Hour" ?? "[????]";
            lblMWLectureDuration.Text = ConfigurationManager.AppSettings["MW"] + " Hours" ?? "[????]";
            lblSTTLectureDuration.Text = ConfigurationManager.AppSettings["STT"] + " Hours" ?? "[????]";
        }
        private void frmSettings_Load(object sender, System.EventArgs e)
        {
            _FillSettingsInfo();
            _CheckPermissions(clsuserbusiness.enPermissions.AddUser);
            _CheckPermissions(clsuserbusiness.enPermissions.AddUser);
        }
        void _CheckPermissions(clsuserbusiness.enPermissions PermissionType)
        {
            if (clsGlobal.LogInUser?.Permissions == -1)
            {
                _EnableDependingOnUserPermissions(PermissionType);
                return;
            }

            if (((int)PermissionType & clsGlobal.LogInUser?.Permissions) == (int)PermissionType)
            {
                _EnableDependingOnUserPermissions(PermissionType);
            }
            else
            {
                _DisableDependingOnUserPermissions(PermissionType);
            }
        }
        private void _EnableDependingOnUserPermissions(clsuserbusiness.enPermissions entityPermissions)
        {
            switch (entityPermissions)
            {
                case clsuserbusiness.enPermissions.AddUser:
                    lnkAddUser.Enabled = true;
                    break;

                case clsuserbusiness.enPermissions.ListUsers:
                    lnkListUsers.Enabled = true;
                    break;
            }
        }
        private void _DisableDependingOnUserPermissions(clsuserbusiness.enPermissions entityPermissions)
        {
            switch (entityPermissions)
            {
                case clsuserbusiness.enPermissions.AddUser:
                    lnkAddUser.Enabled = false;
                    break;

                case clsuserbusiness.enPermissions.ListUsers:
                    lnkListUsers.Enabled = false;
                    break;
            }
        }
    }
}
